

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
    internal partial interface INpgsqlPathArraypathArray
    {
    }
    
    internal partial class NpgsqlPathArraypathArray : INpgsqlPathArraypathArray
    {


#region TestData

        private readonly NpgsqlPathpathArray1M[] _testData = new NpgsqlPathpathArray1M[]
        {
            new NpgsqlPathpathArray1M
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23013767941481766d, y: 0.9582799508237798d), new NpgsqlTypes.NpgsqlPoint(x: 0.17767205051684898d, y: 0.8015868482712728d), new NpgsqlTypes.NpgsqlPoint(x: 0.2800892004578911d, y: 0.14927552128584354d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10402133260039736d, y: 0.9708499780002163d), new NpgsqlTypes.NpgsqlPoint(x: 0.11430949514399158d, y: 0.16245245080268045d), new NpgsqlTypes.NpgsqlPoint(x: 0.11811958666521383d, y: 0.6576206180147417d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.005977244017563721d, y: 0.18011583948745302d), new NpgsqlTypes.NpgsqlPoint(x: 0.265253635532545d, y: 0.4541607864307238d), new NpgsqlTypes.NpgsqlPoint(x: 0.2918224133873373d, y: 0.0720923723153244d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.52976225844865d, y: 0.1429754810857139d), new NpgsqlTypes.NpgsqlPoint(x: 0.7456759427973878d, y: 0.35971096043629047d), new NpgsqlTypes.NpgsqlPoint(x: 0.5043129449393602d, y: 0.01732517385025667d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08775615318169028d, y: 0.2081146091938122d), new NpgsqlTypes.NpgsqlPoint(x: 0.8934565411411783d, y: 0.272586551572508d), new NpgsqlTypes.NpgsqlPoint(x: 0.42588132868871365d, y: 0.3772174878552471d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8475204486680515d, y: 0.6271590597381586d), new NpgsqlTypes.NpgsqlPoint(x: 0.41143675508237965d, y: 0.7201421817699399d), new NpgsqlTypes.NpgsqlPoint(x: 0.6647685804784895d, y: 0.4767614727285818d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9169374873048565d, y: 0.7772565416301859d), new NpgsqlTypes.NpgsqlPoint(x: 0.21239319314388316d, y: 0.10665480506999048d), new NpgsqlTypes.NpgsqlPoint(x: 0.9029509931349721d, y: 0.8719780235446412d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8500553193305777d, y: 0.09760342353655782d), new NpgsqlTypes.NpgsqlPoint(x: 0.8412951810164047d, y: 0.6331664025945545d), new NpgsqlTypes.NpgsqlPoint(x: 0.047413576553282155d, y: 0.6961687742802845d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1964425288241266d, y: 0.4472685665184317d), new NpgsqlTypes.NpgsqlPoint(x: 0.12188986858218809d, y: 0.08539734601166682d), new NpgsqlTypes.NpgsqlPoint(x: 0.462176010266067d, y: 0.4685191968929061d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8182282814257782d, y: 0.8106597378924587d), new NpgsqlTypes.NpgsqlPoint(x: 0.35580436696307105d, y: 0.09919068428387035d), new NpgsqlTypes.NpgsqlPoint(x: 0.03394487465468399d, y: 0.6458679560015225d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3224148483113424d, y: 0.7181248200217298d), new NpgsqlTypes.NpgsqlPoint(x: 0.8727553955458012d, y: 0.45290926135859777d), new NpgsqlTypes.NpgsqlPoint(x: 0.8716884892626158d, y: 0.7272268100886912d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2687603608789577d, y: 0.477357607768636d), new NpgsqlTypes.NpgsqlPoint(x: 0.03355246383344157d, y: 0.7405849937119929d), new NpgsqlTypes.NpgsqlPoint(x: 0.9557444539535572d, y: 0.4906138883127945d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13488304392841344d, y: 0.0049754676089663885d), new NpgsqlTypes.NpgsqlPoint(x: 0.8201516531332584d, y: 0.8147343070991213d), new NpgsqlTypes.NpgsqlPoint(x: 0.007226447439659389d, y: 0.2588824247551419d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26412061291007527d, y: 0.9003113186875588d), new NpgsqlTypes.NpgsqlPoint(x: 0.20128327505125365d, y: 0.29061170850517093d), new NpgsqlTypes.NpgsqlPoint(x: 0.8332266647056329d, y: 0.8945778288863706d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9839742054593237d, y: 0.4904083949663286d), new NpgsqlTypes.NpgsqlPoint(x: 0.40801391859878944d, y: 0.11866332325771378d), new NpgsqlTypes.NpgsqlPoint(x: 0.2749815923508828d, y: 0.33074787663642413d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38345529268488054d, y: 0.7877761508604817d), new NpgsqlTypes.NpgsqlPoint(x: 0.24507429705352257d, y: 0.6822008165565326d), new NpgsqlTypes.NpgsqlPoint(x: 0.2071585592895091d, y: 0.9602859390469903d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9802418826231232d, y: 0.2983458002216387d), new NpgsqlTypes.NpgsqlPoint(x: 0.7365705049882171d, y: 0.690663175916908d), new NpgsqlTypes.NpgsqlPoint(x: 0.09098612016147145d, y: 0.6281614510656837d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08426055124308296d, y: 0.6365437541596365d), new NpgsqlTypes.NpgsqlPoint(x: 0.36957715170870997d, y: 0.6958610279745725d), new NpgsqlTypes.NpgsqlPoint(x: 0.5653518643273097d, y: 0.07486125284903755d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7456229413353482d, y: 0.7223539841350926d), new NpgsqlTypes.NpgsqlPoint(x: 0.5861762826793399d, y: 0.4192136254849732d), new NpgsqlTypes.NpgsqlPoint(x: 0.05761268624195004d, y: 0.8290137975465034d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.354936638264455d, y: 0.7057580501806422d), new NpgsqlTypes.NpgsqlPoint(x: 0.02094515030293309d, y: 0.4599781424683129d), new NpgsqlTypes.NpgsqlPoint(x: 0.4841795042731515d, y: 0.5440590031458795d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5826284044057023d, y: 0.1999487508964679d), new NpgsqlTypes.NpgsqlPoint(x: 0.14546539771939204d, y: 0.7003726186064143d), new NpgsqlTypes.NpgsqlPoint(x: 0.870721801698377d, y: 0.4539730559561034d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9777379206489311d, y: 0.6046103777284557d), new NpgsqlTypes.NpgsqlPoint(x: 0.9111849844542412d, y: 0.9717402211269816d), new NpgsqlTypes.NpgsqlPoint(x: 0.40115770612112667d, y: 0.03271614849742688d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3600706538874462d, y: 0.774390414322716d), new NpgsqlTypes.NpgsqlPoint(x: 0.8481942033588533d, y: 0.4481620694536249d), new NpgsqlTypes.NpgsqlPoint(x: 0.9158241868205085d, y: 0.8110008467080143d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4733688702545614d, y: 0.5112682339190231d), new NpgsqlTypes.NpgsqlPoint(x: 0.1400293365067662d, y: 0.901645242223341d), new NpgsqlTypes.NpgsqlPoint(x: 0.8791483104947148d, y: 0.9336189489045641d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7903161080273419d, y: 0.912864740427695d), new NpgsqlTypes.NpgsqlPoint(x: 0.6170321749324289d, y: 0.33644540203267437d), new NpgsqlTypes.NpgsqlPoint(x: 0.12194601264880389d, y: 0.5156087082753041d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.958771510444996d, y: 0.7658016739737561d), new NpgsqlTypes.NpgsqlPoint(x: 0.8951980060359861d, y: 0.5001409878306952d), new NpgsqlTypes.NpgsqlPoint(x: 0.9948789852482101d, y: 0.5874589104137349d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4515726246771896d, y: 0.07877120977793861d), new NpgsqlTypes.NpgsqlPoint(x: 0.42465999485458505d, y: 0.08810762392468707d), new NpgsqlTypes.NpgsqlPoint(x: 0.25937189806848926d, y: 0.36160473246131364d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27081725408086255d, y: 0.30179390895271785d), new NpgsqlTypes.NpgsqlPoint(x: 0.9747076476829393d, y: 0.8857936883150701d), new NpgsqlTypes.NpgsqlPoint(x: 0.027288154546343257d, y: 0.7478806667037012d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.015076382865708782d, y: 0.7543036479492963d), new NpgsqlTypes.NpgsqlPoint(x: 0.43374982810041385d, y: 0.7843041840377349d), new NpgsqlTypes.NpgsqlPoint(x: 0.39981741300371365d, y: 0.7643812431658279d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8469780614913113d, y: 0.4163748721107021d), new NpgsqlTypes.NpgsqlPoint(x: 0.6932521240474879d, y: 0.4583369381054091d), new NpgsqlTypes.NpgsqlPoint(x: 0.4833566018767049d, y: 0.7136054928312324d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6224939562884461d, y: 0.9280323355400736d), new NpgsqlTypes.NpgsqlPoint(x: 0.45522762925248206d, y: 0.3955961383609362d), new NpgsqlTypes.NpgsqlPoint(x: 0.3040312543716567d, y: 0.25812061863617486d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.577792614223433d, y: 0.508094929847028d), new NpgsqlTypes.NpgsqlPoint(x: 0.37238322481647945d, y: 0.4460965549206857d), new NpgsqlTypes.NpgsqlPoint(x: 0.4000646568465799d, y: 0.5782053690652719d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8788362422922749d, y: 0.8564369742941103d), new NpgsqlTypes.NpgsqlPoint(x: 0.08559289427414407d, y: 0.43760415809084086d), new NpgsqlTypes.NpgsqlPoint(x: 0.11109264182207101d, y: 0.6366258077319692d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4986220283428804d, y: 0.016552940866409238d), new NpgsqlTypes.NpgsqlPoint(x: 0.15265757835689775d, y: 0.07967218730101655d), new NpgsqlTypes.NpgsqlPoint(x: 0.5068258340182933d, y: 0.16969459186409863d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.011122816326869511d, y: 0.5861439279177312d), new NpgsqlTypes.NpgsqlPoint(x: 0.9836935008242316d, y: 0.23563776423134697d), new NpgsqlTypes.NpgsqlPoint(x: 0.8397189259867927d, y: 0.0759168559613772d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26974851235857167d, y: 0.5693220421278659d), new NpgsqlTypes.NpgsqlPoint(x: 0.09538255357998182d, y: 0.6304488283533385d), new NpgsqlTypes.NpgsqlPoint(x: 0.11490049987084416d, y: 0.5831676727315124d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04004687597608081d, y: 0.8226707536726283d), new NpgsqlTypes.NpgsqlPoint(x: 0.4920478921539835d, y: 0.1325044020132521d), new NpgsqlTypes.NpgsqlPoint(x: 0.10115817224851253d, y: 0.6557884845700581d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21917331931190265d, y: 0.06269990728441344d), new NpgsqlTypes.NpgsqlPoint(x: 0.4822423268010948d, y: 0.18404813539202758d), new NpgsqlTypes.NpgsqlPoint(x: 0.7732774906975222d, y: 0.18498318537731595d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.022011762094402032d, y: 0.2540402911030326d), new NpgsqlTypes.NpgsqlPoint(x: 0.8212311120090442d, y: 0.02568264599904213d), new NpgsqlTypes.NpgsqlPoint(x: 0.34278683900807716d, y: 0.9058238339362659d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10692865915806449d, y: 0.5394903739818708d), new NpgsqlTypes.NpgsqlPoint(x: 0.6208162182349863d, y: 0.14031313441209703d), new NpgsqlTypes.NpgsqlPoint(x: 0.7345989799615842d, y: 0.7034461895690132d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.755046505918624d, y: 0.711551682031879d), new NpgsqlTypes.NpgsqlPoint(x: 0.5269718488922646d, y: 0.6857608758534451d), new NpgsqlTypes.NpgsqlPoint(x: 0.5457778479029306d, y: 0.4971732305168147d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08664641052046507d, y: 0.35307291569823307d), new NpgsqlTypes.NpgsqlPoint(x: 0.5184491700226843d, y: 0.4115753520120847d), new NpgsqlTypes.NpgsqlPoint(x: 0.5139398061958368d, y: 0.030537117142888315d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9854294805633818d, y: 0.5887978848162172d), new NpgsqlTypes.NpgsqlPoint(x: 0.0668936588994502d, y: 0.6754374044630447d), new NpgsqlTypes.NpgsqlPoint(x: 0.8601899195296175d, y: 0.43388181844991613d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5412945611657297d, y: 0.034592260334482594d), new NpgsqlTypes.NpgsqlPoint(x: 0.5456196103455538d, y: 0.18188284981849867d), new NpgsqlTypes.NpgsqlPoint(x: 0.2989186101876341d, y: 0.2912018158207228d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8793179204616043d, y: 0.1956072346467277d), new NpgsqlTypes.NpgsqlPoint(x: 0.7621991985931197d, y: 0.9578225860559965d), new NpgsqlTypes.NpgsqlPoint(x: 0.9495995926484269d, y: 0.9725880389742592d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.493542837887193d, y: 0.1673968591611661d), new NpgsqlTypes.NpgsqlPoint(x: 0.8270460760629464d, y: 0.5614080435966433d), new NpgsqlTypes.NpgsqlPoint(x: 0.8367244792466672d, y: 0.3456568479104771d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6365136481652813d, y: 0.9945538653337352d), new NpgsqlTypes.NpgsqlPoint(x: 0.21665683865706642d, y: 0.42917567324121775d), new NpgsqlTypes.NpgsqlPoint(x: 0.3085099363353706d, y: 0.7095870387607821d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9952471084018998d, y: 0.9125945558267307d), new NpgsqlTypes.NpgsqlPoint(x: 0.3158300159840326d, y: 0.20005441926547873d), new NpgsqlTypes.NpgsqlPoint(x: 0.14508774320425d, y: 0.20233506725671513d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.00714484654916181d, y: 0.7359704912096593d), new NpgsqlTypes.NpgsqlPoint(x: 0.47547193004918875d, y: 0.7720373982268051d), new NpgsqlTypes.NpgsqlPoint(x: 0.07717044920683458d, y: 0.04999570888928795d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6885012161386628d, y: 0.09949452071217979d), new NpgsqlTypes.NpgsqlPoint(x: 0.6814339011683674d, y: 0.466114093015521d), new NpgsqlTypes.NpgsqlPoint(x: 0.6919883281644702d, y: 0.7024861132027926d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2056667584303632d, y: 0.39963520111078144d), new NpgsqlTypes.NpgsqlPoint(x: 0.6633329940084046d, y: 0.3646744111981589d), new NpgsqlTypes.NpgsqlPoint(x: 0.15599167125600089d, y: 0.22936450137008735d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9111355818510919d, y: 0.8941587743069556d), new NpgsqlTypes.NpgsqlPoint(x: 0.8821596438822884d, y: 0.18416888891187166d), new NpgsqlTypes.NpgsqlPoint(x: 0.9721646985409615d, y: 0.057476090774164046d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06540835924857624d, y: 0.47213256531285874d), new NpgsqlTypes.NpgsqlPoint(x: 0.014410154133415398d, y: 0.4901996180950515d), new NpgsqlTypes.NpgsqlPoint(x: 0.9371548882628346d, y: 0.0020439686568398674d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.029392943514932268d, y: 0.33882321420916295d), new NpgsqlTypes.NpgsqlPoint(x: 0.691892774749337d, y: 0.7699249762725275d), new NpgsqlTypes.NpgsqlPoint(x: 0.4025798361794851d, y: 0.22119698361430895d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28019622530393806d, y: 0.969883820196117d), new NpgsqlTypes.NpgsqlPoint(x: 0.4191256444533661d, y: 0.48029189208601764d), new NpgsqlTypes.NpgsqlPoint(x: 0.6049604690559738d, y: 0.544919001188482d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08344451464344549d, y: 0.3846109565488214d), new NpgsqlTypes.NpgsqlPoint(x: 0.4641958456119115d, y: 0.0967436875764155d), new NpgsqlTypes.NpgsqlPoint(x: 0.24308552914697257d, y: 0.46669738569450536d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7981779744653529d, y: 0.5640665857431366d), new NpgsqlTypes.NpgsqlPoint(x: 0.12099955329574119d, y: 0.16997795396431148d), new NpgsqlTypes.NpgsqlPoint(x: 0.03917788509652864d, y: 0.8293992983401374d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.399301739906079d, y: 0.8905567702938765d), new NpgsqlTypes.NpgsqlPoint(x: 0.42632042307080065d, y: 0.5779917673228565d), new NpgsqlTypes.NpgsqlPoint(x: 0.20150459906657714d, y: 0.818088990090453d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8546766156493663d, y: 0.44550967936211927d), new NpgsqlTypes.NpgsqlPoint(x: 0.301204517834295d, y: 0.47967859567596993d), new NpgsqlTypes.NpgsqlPoint(x: 0.535468331353044d, y: 0.35419619853118955d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7041728761152259d, y: 0.3515710137867488d), new NpgsqlTypes.NpgsqlPoint(x: 0.14512017869256422d, y: 0.44790792819726166d), new NpgsqlTypes.NpgsqlPoint(x: 0.7268454506456212d, y: 0.3268349312575044d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.869853407153467d, y: 0.28325685815779167d), new NpgsqlTypes.NpgsqlPoint(x: 0.3327821707650661d, y: 0.7378998836325719d), new NpgsqlTypes.NpgsqlPoint(x: 0.39753068187403684d, y: 0.02105891019860817d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08709782246567799d, y: 0.34008122200389523d), new NpgsqlTypes.NpgsqlPoint(x: 0.31478789116032513d, y: 0.20347762986773565d), new NpgsqlTypes.NpgsqlPoint(x: 0.7635895238465029d, y: 0.17102004532428594d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3217543203519425d, y: 0.2215420957601757d), new NpgsqlTypes.NpgsqlPoint(x: 0.7885772909326533d, y: 0.8930060163176754d), new NpgsqlTypes.NpgsqlPoint(x: 0.9657251402698466d, y: 0.39135426451098665d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8463883815511312d, y: 0.8833368894737369d), new NpgsqlTypes.NpgsqlPoint(x: 0.7778861098583285d, y: 0.14252978664275473d), new NpgsqlTypes.NpgsqlPoint(x: 0.49156385737000363d, y: 0.722059487655353d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15268069427282338d, y: 0.8233862115556367d), new NpgsqlTypes.NpgsqlPoint(x: 0.5792026398575761d, y: 0.19591842859809994d), new NpgsqlTypes.NpgsqlPoint(x: 0.0741960156445789d, y: 0.45909145644246896d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.010923689253913849d, y: 0.31468838441589997d), new NpgsqlTypes.NpgsqlPoint(x: 0.05909530873966051d, y: 0.023270707270195867d), new NpgsqlTypes.NpgsqlPoint(x: 0.8699064408200652d, y: 0.2532772067124691d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5625146573171497d, y: 0.8278898128030208d), new NpgsqlTypes.NpgsqlPoint(x: 0.48714114399201003d, y: 0.996873032727853d), new NpgsqlTypes.NpgsqlPoint(x: 0.9239245946407546d, y: 0.8812884963465712d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4188742536461909d, y: 0.11039055427768663d), new NpgsqlTypes.NpgsqlPoint(x: 0.10799909633625171d, y: 0.41613681374304723d), new NpgsqlTypes.NpgsqlPoint(x: 0.44478442706936017d, y: 0.09283610784717211d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9215823430486401d, y: 0.15276108450245496d), new NpgsqlTypes.NpgsqlPoint(x: 0.5541031080504245d, y: 0.5226314630003378d), new NpgsqlTypes.NpgsqlPoint(x: 0.3806782289466363d, y: 0.5065133057332548d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9621403923923881d, y: 0.1736852612808385d), new NpgsqlTypes.NpgsqlPoint(x: 0.6376618277534335d, y: 0.4254941568407501d), new NpgsqlTypes.NpgsqlPoint(x: 0.21108286850615154d, y: 0.18721698117940544d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5073255861009586d, y: 0.45077699681119876d), new NpgsqlTypes.NpgsqlPoint(x: 0.6938871952778837d, y: 0.7518155277213896d), new NpgsqlTypes.NpgsqlPoint(x: 0.47428911946430374d, y: 0.9826688673483216d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4489923103581085d, y: 0.44944550117230186d), new NpgsqlTypes.NpgsqlPoint(x: 0.13992736695001995d, y: 0.5841531532951372d), new NpgsqlTypes.NpgsqlPoint(x: 0.5690056029042699d, y: 0.7828246685257062d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.006099065154952621d, y: 0.946716072073407d), new NpgsqlTypes.NpgsqlPoint(x: 0.15832996394076893d, y: 0.328397534874029d), new NpgsqlTypes.NpgsqlPoint(x: 0.1870696178539678d, y: 0.8051093660539054d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06472177838861015d, y: 0.5975074983048739d), new NpgsqlTypes.NpgsqlPoint(x: 0.2763504665885067d, y: 0.9022897753882952d), new NpgsqlTypes.NpgsqlPoint(x: 0.4172282420916935d, y: 0.47901461848712834d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43292507436394545d, y: 0.745042769917741d), new NpgsqlTypes.NpgsqlPoint(x: 0.34839224037206895d, y: 0.02964789729642603d), new NpgsqlTypes.NpgsqlPoint(x: 0.8986311876777383d, y: 0.008562477341972685d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.282609185458663d, y: 0.9205922513179683d), new NpgsqlTypes.NpgsqlPoint(x: 0.33524404361566695d, y: 0.2908803526096d), new NpgsqlTypes.NpgsqlPoint(x: 0.6776932159981103d, y: 0.25232281799804834d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6224201224564635d, y: 0.8631151765818198d), new NpgsqlTypes.NpgsqlPoint(x: 0.06426116224317702d, y: 0.6256798310681664d), new NpgsqlTypes.NpgsqlPoint(x: 0.45434301074665173d, y: 0.13573738953194692d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.576717032677081d, y: 0.4024165112526944d), new NpgsqlTypes.NpgsqlPoint(x: 0.2785209819790997d, y: 0.02036572055019903d), new NpgsqlTypes.NpgsqlPoint(x: 0.4957886209280792d, y: 0.731864697432013d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9376112679216625d, y: 0.754246048500468d), new NpgsqlTypes.NpgsqlPoint(x: 0.9473907832751591d, y: 0.9802598227122092d), new NpgsqlTypes.NpgsqlPoint(x: 0.30938310161515303d, y: 0.8743646458537583d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4498234104642381d, y: 0.29418255702933405d), new NpgsqlTypes.NpgsqlPoint(x: 0.02155687392340866d, y: 0.43411905671417383d), new NpgsqlTypes.NpgsqlPoint(x: 0.7165876950934416d, y: 0.3595701361782928d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2338915389084557d, y: 0.5504067979369819d), new NpgsqlTypes.NpgsqlPoint(x: 0.4035365961786077d, y: 0.649233154840099d), new NpgsqlTypes.NpgsqlPoint(x: 0.48753347079957754d, y: 0.0716284214492452d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.794376354672642d, y: 0.6064045629556495d), new NpgsqlTypes.NpgsqlPoint(x: 0.5968850787041078d, y: 0.2882441811486278d), new NpgsqlTypes.NpgsqlPoint(x: 0.5873701310460954d, y: 0.3131219158930304d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9257948419776307d, y: 0.26761956660523933d), new NpgsqlTypes.NpgsqlPoint(x: 0.8866646387453141d, y: 0.34903499021690765d), new NpgsqlTypes.NpgsqlPoint(x: 0.3453499877130788d, y: 0.05936838781292142d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43035722059979853d, y: 0.12654312625136155d), new NpgsqlTypes.NpgsqlPoint(x: 0.29682415931035055d, y: 0.9643353525143677d), new NpgsqlTypes.NpgsqlPoint(x: 0.0770521993466905d, y: 0.4050069804613795d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10364130337898725d, y: 0.21931304096893345d), new NpgsqlTypes.NpgsqlPoint(x: 0.8149465080782854d, y: 0.7229318580274042d), new NpgsqlTypes.NpgsqlPoint(x: 0.10164252890744663d, y: 0.40884844143639365d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7149981425975209d, y: 0.35042787404662334d), new NpgsqlTypes.NpgsqlPoint(x: 0.7589765511630334d, y: 0.3618519302055734d), new NpgsqlTypes.NpgsqlPoint(x: 0.9115235521959495d, y: 0.4737953276539941d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36761752013296867d, y: 0.7149407086819822d), new NpgsqlTypes.NpgsqlPoint(x: 0.2663524508239451d, y: 0.6656064280304582d), new NpgsqlTypes.NpgsqlPoint(x: 0.3854377866050144d, y: 0.3637466560224031d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7580017719744395d, y: 0.8462878761200656d), new NpgsqlTypes.NpgsqlPoint(x: 0.8185130410561657d, y: 0.573759057988798d), new NpgsqlTypes.NpgsqlPoint(x: 0.6543630151657585d, y: 0.5992491106969594d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01843965212304577d, y: 0.3394585162948256d), new NpgsqlTypes.NpgsqlPoint(x: 0.3592772500308715d, y: 0.3011124472788047d), new NpgsqlTypes.NpgsqlPoint(x: 0.3449311832365075d, y: 0.8006253943813838d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5759036556118465d, y: 0.5599756491719275d), new NpgsqlTypes.NpgsqlPoint(x: 0.7664311241647096d, y: 0.7603638563357112d), new NpgsqlTypes.NpgsqlPoint(x: 0.8333573491726006d, y: 0.26446013473402874d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16166486244427292d, y: 0.07868024108223781d), new NpgsqlTypes.NpgsqlPoint(x: 0.49272670256120343d, y: 0.14090386237296582d), new NpgsqlTypes.NpgsqlPoint(x: 0.9626518191583116d, y: 0.9457900395087077d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6459991480246866d, y: 0.989674869778286d), new NpgsqlTypes.NpgsqlPoint(x: 0.6602335197701067d, y: 0.7230728302795841d), new NpgsqlTypes.NpgsqlPoint(x: 0.5298847236723169d, y: 0.6697413958778813d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6869996080358869d, y: 0.799761251568062d), new NpgsqlTypes.NpgsqlPoint(x: 0.4861385189828268d, y: 0.8850046508127394d), new NpgsqlTypes.NpgsqlPoint(x: 0.13332781080668854d, y: 0.7746168424070191d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15944821689354638d, y: 0.5099956573923621d), new NpgsqlTypes.NpgsqlPoint(x: 0.6846939557180672d, y: 0.4038530607502753d), new NpgsqlTypes.NpgsqlPoint(x: 0.023411136564770896d, y: 0.8097591006959777d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07712560510970057d, y: 0.012448922618348957d), new NpgsqlTypes.NpgsqlPoint(x: 0.552301953096757d, y: 0.6174544280708625d), new NpgsqlTypes.NpgsqlPoint(x: 0.7115191243714755d, y: 0.970158070225272d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3417100232020692d, y: 0.538371199301423d), new NpgsqlTypes.NpgsqlPoint(x: 0.6528151484676336d, y: 0.1029228687075242d), new NpgsqlTypes.NpgsqlPoint(x: 0.4010502851952067d, y: 0.9599630094557416d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38085496925699003d, y: 0.8007398297248491d), new NpgsqlTypes.NpgsqlPoint(x: 0.7406781977819299d, y: 0.9045139573212667d), new NpgsqlTypes.NpgsqlPoint(x: 0.34659494499391663d, y: 0.8060056487910524d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8294700630122684d, y: 0.9828724515319054d), new NpgsqlTypes.NpgsqlPoint(x: 0.3305279847094864d, y: 0.990937213668522d), new NpgsqlTypes.NpgsqlPoint(x: 0.829051009300218d, y: 0.9837585304592219d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09405946212592053d, y: 0.04784965507606287d), new NpgsqlTypes.NpgsqlPoint(x: 0.04608741152948337d, y: 0.2488473768106395d), new NpgsqlTypes.NpgsqlPoint(x: 0.24600194340984038d, y: 0.39133506305103305d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9786508025560899d, y: 0.09419873659988787d), new NpgsqlTypes.NpgsqlPoint(x: 0.08418748009531207d, y: 0.1240322550154751d), new NpgsqlTypes.NpgsqlPoint(x: 0.1800363153863589d, y: 0.41820386148807553d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14468158499189976d, y: 0.22384631353379514d), new NpgsqlTypes.NpgsqlPoint(x: 0.40466801426772137d, y: 0.9219009942878592d), new NpgsqlTypes.NpgsqlPoint(x: 0.8655926664250719d, y: 0.01923655673091329d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9329982538183883d, y: 0.3143319788158355d), new NpgsqlTypes.NpgsqlPoint(x: 0.11536183716621773d, y: 0.8979306148339097d), new NpgsqlTypes.NpgsqlPoint(x: 0.4074773291293965d, y: 0.574123622701333d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7577351089661266d, y: 0.7610263437888469d), new NpgsqlTypes.NpgsqlPoint(x: 0.2393350397136319d, y: 0.21847329764990842d), new NpgsqlTypes.NpgsqlPoint(x: 0.8886764651988898d, y: 0.5172458984499189d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2092728138565516d, y: 0.30138039446362885d), new NpgsqlTypes.NpgsqlPoint(x: 0.7548944918114343d, y: 0.07033366318896817d), new NpgsqlTypes.NpgsqlPoint(x: 0.09354143590174113d, y: 0.9187241648606576d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.54182143785709d, y: 0.4242357992889375d), new NpgsqlTypes.NpgsqlPoint(x: 0.6408069607822248d, y: 0.9684600813164085d), new NpgsqlTypes.NpgsqlPoint(x: 0.5268003661482064d, y: 0.7107244501682431d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9350865249939107d, y: 0.9991424106848702d), new NpgsqlTypes.NpgsqlPoint(x: 0.33009289169565514d, y: 0.4718297201263342d), new NpgsqlTypes.NpgsqlPoint(x: 0.29088922943160944d, y: 0.8125372818202186d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6963770605365927d, y: 0.4815965781607052d), new NpgsqlTypes.NpgsqlPoint(x: 0.9336409349954751d, y: 0.953052209994427d), new NpgsqlTypes.NpgsqlPoint(x: 0.18108855200365992d, y: 0.2181457177897167d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4822978919561477d, y: 0.2719012244142004d), new NpgsqlTypes.NpgsqlPoint(x: 0.4078508031663707d, y: 0.3500374344820435d), new NpgsqlTypes.NpgsqlPoint(x: 0.8572081164225197d, y: 0.20674999854683362d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.116945930288745d, y: 0.9710845530517511d), new NpgsqlTypes.NpgsqlPoint(x: 0.13417330689719098d, y: 0.2959797036798376d), new NpgsqlTypes.NpgsqlPoint(x: 0.7842308416230086d, y: 0.4050773491719777d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8199438933758102d, y: 0.993748810852536d), new NpgsqlTypes.NpgsqlPoint(x: 0.318711943803895d, y: 0.09941427460615693d), new NpgsqlTypes.NpgsqlPoint(x: 0.14120414294321748d, y: 0.7895467709105319d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4367525143765417d, y: 0.025213606654032605d), new NpgsqlTypes.NpgsqlPoint(x: 0.5893729471398482d, y: 0.37647602840380157d), new NpgsqlTypes.NpgsqlPoint(x: 0.4078966244188511d, y: 0.6156979742849535d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6116846630005502d, y: 0.5503993713015506d), new NpgsqlTypes.NpgsqlPoint(x: 0.05631994454532141d, y: 0.8535730528850588d), new NpgsqlTypes.NpgsqlPoint(x: 0.8854878776572106d, y: 0.9531462711894476d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30741013280874885d, y: 0.18658119837613052d), new NpgsqlTypes.NpgsqlPoint(x: 0.9891327296115875d, y: 0.742096127974717d), new NpgsqlTypes.NpgsqlPoint(x: 0.2706303017749989d, y: 0.5190249411026793d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6823491849606389d, y: 0.4640088212078448d), new NpgsqlTypes.NpgsqlPoint(x: 0.10988189171178564d, y: 0.39272282435703976d), new NpgsqlTypes.NpgsqlPoint(x: 0.3115085041928227d, y: 0.5348832180360562d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3063404953723653d, y: 0.7479509547528947d), new NpgsqlTypes.NpgsqlPoint(x: 0.3061755104272992d, y: 0.1130928938753949d), new NpgsqlTypes.NpgsqlPoint(x: 0.773511768507269d, y: 0.19177658581609336d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.980283684240756d, y: 0.4534458272162294d), new NpgsqlTypes.NpgsqlPoint(x: 0.24717759435998232d, y: 0.43143127225912337d), new NpgsqlTypes.NpgsqlPoint(x: 0.3794885813016472d, y: 0.7227706359385717d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5158211845746837d, y: 0.6963531559642507d), new NpgsqlTypes.NpgsqlPoint(x: 0.06173968151892517d, y: 0.26571785087233935d), new NpgsqlTypes.NpgsqlPoint(x: 0.2866277531667162d, y: 0.33819074073553523d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6770831718116743d, y: 0.417112764688109d), new NpgsqlTypes.NpgsqlPoint(x: 0.5189257246748235d, y: 0.5657092944035353d), new NpgsqlTypes.NpgsqlPoint(x: 0.8807834165746385d, y: 0.09947785398452158d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7588828126307529d, y: 0.9264533041782382d), new NpgsqlTypes.NpgsqlPoint(x: 0.8310482557073932d, y: 0.4208783254473436d), new NpgsqlTypes.NpgsqlPoint(x: 0.2864324607894625d, y: 0.4553937027775038d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17599887634063338d, y: 0.19903384930809376d), new NpgsqlTypes.NpgsqlPoint(x: 0.27634071590098797d, y: 0.32973418670677246d), new NpgsqlTypes.NpgsqlPoint(x: 0.8639780091798268d, y: 0.6728668881619951d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07912493988595892d, y: 0.7892164317627728d), new NpgsqlTypes.NpgsqlPoint(x: 0.9123091898474588d, y: 0.8035719421408009d), new NpgsqlTypes.NpgsqlPoint(x: 0.33411409610755427d, y: 0.5629258006108604d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5313293750586155d, y: 0.48075569225098624d), new NpgsqlTypes.NpgsqlPoint(x: 0.7039745298269168d, y: 0.08222328808186963d), new NpgsqlTypes.NpgsqlPoint(x: 0.44926455795266707d, y: 0.6861146101335648d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7453805882194089d, y: 0.8685848606372016d), new NpgsqlTypes.NpgsqlPoint(x: 0.5444168380212452d, y: 0.7437567111253723d), new NpgsqlTypes.NpgsqlPoint(x: 0.35687017220632755d, y: 0.6081305773091334d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1691447185037359d, y: 0.6377431915412032d), new NpgsqlTypes.NpgsqlPoint(x: 0.15778007433327823d, y: 0.19747997373004644d), new NpgsqlTypes.NpgsqlPoint(x: 0.5089355449082142d, y: 0.4723958284548514d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09162772411008635d, y: 0.45314579673449384d), new NpgsqlTypes.NpgsqlPoint(x: 0.6689775714450538d, y: 0.018438404976319878d), new NpgsqlTypes.NpgsqlPoint(x: 0.1056855957807632d, y: 0.9255629674832585d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10952516669172685d, y: 0.8844484352363347d), new NpgsqlTypes.NpgsqlPoint(x: 0.4648476665552216d, y: 0.022711335691233514d), new NpgsqlTypes.NpgsqlPoint(x: 0.5443851917706206d, y: 0.7373788729016959d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6326873859913357d, y: 0.05978653026700598d), new NpgsqlTypes.NpgsqlPoint(x: 0.03997195716378332d, y: 0.12657188032488043d), new NpgsqlTypes.NpgsqlPoint(x: 0.40233442629308447d, y: 0.27014479687662485d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04350431756522699d, y: 0.7169048476517593d), new NpgsqlTypes.NpgsqlPoint(x: 0.8679533123492663d, y: 0.14063138023389166d), new NpgsqlTypes.NpgsqlPoint(x: 0.2779278289921723d, y: 0.8755054965642152d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37307279150751094d, y: 0.9897711868436785d), new NpgsqlTypes.NpgsqlPoint(x: 0.9807752575633105d, y: 0.9134281269702604d), new NpgsqlTypes.NpgsqlPoint(x: 0.3249444645645052d, y: 0.49498904527455523d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3601257253110026d, y: 0.7869251308905092d), new NpgsqlTypes.NpgsqlPoint(x: 0.2472697316371646d, y: 0.2931300739254128d), new NpgsqlTypes.NpgsqlPoint(x: 0.05355931317058338d, y: 0.7416758774561107d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20110897891813995d, y: 0.42386110833359913d), new NpgsqlTypes.NpgsqlPoint(x: 0.13558418473297462d, y: 0.5690170676809765d), new NpgsqlTypes.NpgsqlPoint(x: 0.6225396000528707d, y: 0.8058142149967267d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9192746913767315d, y: 0.7862421997626662d), new NpgsqlTypes.NpgsqlPoint(x: 0.9020090570102081d, y: 0.17229802637336156d), new NpgsqlTypes.NpgsqlPoint(x: 0.4704679670075169d, y: 0.19426576729413647d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28008201488012374d, y: 0.43215316830371653d), new NpgsqlTypes.NpgsqlPoint(x: 0.572723591089539d, y: 0.25851098244524384d), new NpgsqlTypes.NpgsqlPoint(x: 0.12993117544844512d, y: 0.6353723805333654d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6117543845993489d, y: 0.4728867791052329d), new NpgsqlTypes.NpgsqlPoint(x: 0.13303188336199867d, y: 0.7871663286293165d), new NpgsqlTypes.NpgsqlPoint(x: 0.7606314180924993d, y: 0.21376607709273798d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2319568994172465d, y: 0.8609811388575904d), new NpgsqlTypes.NpgsqlPoint(x: 0.5109921822474738d, y: 0.8694806536805874d), new NpgsqlTypes.NpgsqlPoint(x: 0.9132120617318934d, y: 0.6314077090619252d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7807552546220504d, y: 0.009525056180665126d), new NpgsqlTypes.NpgsqlPoint(x: 0.2942984434299418d, y: 0.2733098504480993d), new NpgsqlTypes.NpgsqlPoint(x: 0.16122535539599103d, y: 0.8410247523017176d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5643755763047908d, y: 0.5674508869087462d), new NpgsqlTypes.NpgsqlPoint(x: 0.4052927887755212d, y: 0.635501029700032d), new NpgsqlTypes.NpgsqlPoint(x: 0.6631179808273056d, y: 0.3419634548763699d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8683829933151814d, y: 0.07886656191792796d), new NpgsqlTypes.NpgsqlPoint(x: 0.3286152073870938d, y: 0.40441612788832226d), new NpgsqlTypes.NpgsqlPoint(x: 0.02111373876780054d, y: 0.8263613498096565d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15198848883883775d, y: 0.5529082959804614d), new NpgsqlTypes.NpgsqlPoint(x: 0.4546501054312474d, y: 0.8227078747109212d), new NpgsqlTypes.NpgsqlPoint(x: 0.470687409990026d, y: 0.11589414149179933d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8767559969949607d, y: 0.5087788002592365d), new NpgsqlTypes.NpgsqlPoint(x: 0.7731716469180095d, y: 0.6091140970219489d), new NpgsqlTypes.NpgsqlPoint(x: 0.40306433830861554d, y: 0.5617498004008478d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16921116071277476d, y: 0.23846355223816085d), new NpgsqlTypes.NpgsqlPoint(x: 0.6974117777237901d, y: 0.8658174250730143d), new NpgsqlTypes.NpgsqlPoint(x: 0.8430715434690866d, y: 0.17290073339249767d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8125938123458698d, y: 0.08889521983125392d), new NpgsqlTypes.NpgsqlPoint(x: 0.16734183008112347d, y: 0.17752150250723675d), new NpgsqlTypes.NpgsqlPoint(x: 0.6672700292310758d, y: 0.47951143685865205d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14238663170700216d, y: 0.32043183146621756d), new NpgsqlTypes.NpgsqlPoint(x: 0.08434792643476208d, y: 0.44693629087783393d), new NpgsqlTypes.NpgsqlPoint(x: 0.1726502925556297d, y: 0.018394471954957137d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3039663655237742d, y: 0.2660099672809202d), new NpgsqlTypes.NpgsqlPoint(x: 0.10670942339729506d, y: 0.6290283445330856d), new NpgsqlTypes.NpgsqlPoint(x: 0.9773112485478622d, y: 0.9290958222724367d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20705152142845862d, y: 0.18122317962460877d), new NpgsqlTypes.NpgsqlPoint(x: 0.9836297757144089d, y: 0.1824923658985007d), new NpgsqlTypes.NpgsqlPoint(x: 0.9092246021282344d, y: 0.8117752309392131d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3366017845642447d, y: 0.2598456905351799d), new NpgsqlTypes.NpgsqlPoint(x: 0.2531172767497605d, y: 0.5966039893633999d), new NpgsqlTypes.NpgsqlPoint(x: 0.33688855898289993d, y: 0.2785881715951667d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25425551066143437d, y: 0.0040796827043867445d), new NpgsqlTypes.NpgsqlPoint(x: 0.010588807348868357d, y: 0.5353200788691103d), new NpgsqlTypes.NpgsqlPoint(x: 0.5811178629480312d, y: 0.45881911811043186d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9696114105522625d, y: 0.7055954139276701d), new NpgsqlTypes.NpgsqlPoint(x: 0.05784601227747388d, y: 0.14556136083831117d), new NpgsqlTypes.NpgsqlPoint(x: 0.5726119184992493d, y: 0.9843593025518955d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6405840428449252d, y: 0.05136739611452634d), new NpgsqlTypes.NpgsqlPoint(x: 0.6514363212875752d, y: 0.9001320316341549d), new NpgsqlTypes.NpgsqlPoint(x: 0.6437197925047861d, y: 0.3055003118417505d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5985274014143368d, y: 0.8614132611063234d), new NpgsqlTypes.NpgsqlPoint(x: 0.17009868334635192d, y: 0.2825589305491234d), new NpgsqlTypes.NpgsqlPoint(x: 0.12316374652191353d, y: 0.08222412834670578d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6639739513099203d, y: 0.3846859863264114d), new NpgsqlTypes.NpgsqlPoint(x: 0.7770275219254911d, y: 0.39917365161620266d), new NpgsqlTypes.NpgsqlPoint(x: 0.38252950915899075d, y: 0.6727966137511282d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0339915018814938d, y: 0.2948933157246718d), new NpgsqlTypes.NpgsqlPoint(x: 0.41861082101664504d, y: 0.3517368550119018d), new NpgsqlTypes.NpgsqlPoint(x: 0.12135555943789522d, y: 0.016645703259101086d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7610245827834011d, y: 0.9449178646391475d), new NpgsqlTypes.NpgsqlPoint(x: 0.31294108944913945d, y: 0.3363667482257976d), new NpgsqlTypes.NpgsqlPoint(x: 0.04545270741279217d, y: 0.90530495567947d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.551231823709224d, y: 0.7575084355477973d), new NpgsqlTypes.NpgsqlPoint(x: 0.6093499681646417d, y: 0.14136380516597002d), new NpgsqlTypes.NpgsqlPoint(x: 0.4263664815200252d, y: 0.9420883689617653d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7079737854407558d, y: 0.12361263780101273d), new NpgsqlTypes.NpgsqlPoint(x: 0.11345972743264299d, y: 0.029323954748310288d), new NpgsqlTypes.NpgsqlPoint(x: 0.4173141014976881d, y: 0.7493719883863511d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7172856186836408d, y: 0.27352894791435134d), new NpgsqlTypes.NpgsqlPoint(x: 0.6542133752630457d, y: 0.8411338658125223d), new NpgsqlTypes.NpgsqlPoint(x: 0.4737154803919229d, y: 0.25382277063275804d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5555845922788739d, y: 0.02131457272696058d), new NpgsqlTypes.NpgsqlPoint(x: 0.8476703109603623d, y: 0.8095169343977675d), new NpgsqlTypes.NpgsqlPoint(x: 0.5567456762343849d, y: 0.052729892493918795d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1776420085694589d, y: 0.2656006460194106d), new NpgsqlTypes.NpgsqlPoint(x: 0.47267077919976186d, y: 0.21941237684632586d), new NpgsqlTypes.NpgsqlPoint(x: 0.991990050075444d, y: 0.1691389119868898d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9049616201486986d, y: 0.9579528614761583d), new NpgsqlTypes.NpgsqlPoint(x: 0.6772150976887558d, y: 0.20951580810216208d), new NpgsqlTypes.NpgsqlPoint(x: 0.6270391418079666d, y: 0.23603859061400345d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5091106015506697d, y: 0.4353324918245902d), new NpgsqlTypes.NpgsqlPoint(x: 0.21550282876875815d, y: 0.15166678032877412d), new NpgsqlTypes.NpgsqlPoint(x: 0.3016961440789936d, y: 0.3237873265690818d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 104,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3065918648731675d, y: 0.25092072136792876d), new NpgsqlTypes.NpgsqlPoint(x: 0.5731009628620428d, y: 0.1910602186670527d), new NpgsqlTypes.NpgsqlPoint(x: 0.4456333187493997d, y: 0.8589682111282416d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6390375155964952d, y: 0.9271045666343011d), new NpgsqlTypes.NpgsqlPoint(x: 0.5593727735254126d, y: 0.6875962463675973d), new NpgsqlTypes.NpgsqlPoint(x: 0.22325860188231572d, y: 0.40428642686579463d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9457947870708155d, y: 0.056559854413476884d), new NpgsqlTypes.NpgsqlPoint(x: 0.4506923527865707d, y: 0.4311056228235375d), new NpgsqlTypes.NpgsqlPoint(x: 0.6059627080389778d, y: 0.5318170963903948d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5303640064294708d, y: 0.031942119063161134d), new NpgsqlTypes.NpgsqlPoint(x: 0.1529317555181704d, y: 0.39170672773571935d), new NpgsqlTypes.NpgsqlPoint(x: 0.30694346445390086d, y: 0.7480678488172969d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7021562802011277d, y: 0.9891402229422169d), new NpgsqlTypes.NpgsqlPoint(x: 0.6808284251212967d, y: 0.1911561274097472d), new NpgsqlTypes.NpgsqlPoint(x: 0.7357489600355489d, y: 0.8884996070779586d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6211995409464416d, y: 0.6939798676264642d), new NpgsqlTypes.NpgsqlPoint(x: 0.45180146756615447d, y: 0.7957848493774132d), new NpgsqlTypes.NpgsqlPoint(x: 0.5040923363610538d, y: 0.04275121478701083d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5059143422616269d, y: 0.10500724108414916d), new NpgsqlTypes.NpgsqlPoint(x: 0.7383650724944519d, y: 0.18577222756285594d), new NpgsqlTypes.NpgsqlPoint(x: 0.11899905954268275d, y: 0.8661539203604529d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4800691915611116d, y: 0.5894501452409197d), new NpgsqlTypes.NpgsqlPoint(x: 0.21866842076681592d, y: 0.8406798567857432d), new NpgsqlTypes.NpgsqlPoint(x: 0.5306226543076296d, y: 0.8807305508665305d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.919761225283176d, y: 0.5582424046726919d), new NpgsqlTypes.NpgsqlPoint(x: 0.11128970411831451d, y: 0.758267566989593d), new NpgsqlTypes.NpgsqlPoint(x: 0.23942511618053286d, y: 0.8492267445430702d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9490753276280027d, y: 0.718599537122878d), new NpgsqlTypes.NpgsqlPoint(x: 0.6498291741733276d, y: 0.7905833647025258d), new NpgsqlTypes.NpgsqlPoint(x: 0.511758491091043d, y: 0.8179995961420994d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41053256268234095d, y: 0.5617013649250531d), new NpgsqlTypes.NpgsqlPoint(x: 0.6992372740113653d, y: 0.20805274171431087d), new NpgsqlTypes.NpgsqlPoint(x: 0.45410670732343517d, y: 0.09278820554996337d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4261942812033479d, y: 0.47885379075014234d), new NpgsqlTypes.NpgsqlPoint(x: 0.32600611432110715d, y: 0.07415784892572597d), new NpgsqlTypes.NpgsqlPoint(x: 0.08887734655830504d, y: 0.9023370822088518d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2446671607493559d, y: 0.08691771209600074d), new NpgsqlTypes.NpgsqlPoint(x: 0.5485853556466743d, y: 0.820195045011419d), new NpgsqlTypes.NpgsqlPoint(x: 0.6125437537388114d, y: 0.9332136770402114d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.476628129153594d, y: 0.13077418873686397d), new NpgsqlTypes.NpgsqlPoint(x: 0.07135715825680622d, y: 0.5754382412827295d), new NpgsqlTypes.NpgsqlPoint(x: 0.9202593313429636d, y: 0.5354180445944995d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 106,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6087541712321889d, y: 0.5288280364695737d), new NpgsqlTypes.NpgsqlPoint(x: 0.8729171361797762d, y: 0.3724973376225966d), new NpgsqlTypes.NpgsqlPoint(x: 0.6558195837287777d, y: 0.930234081744781d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.939056771627793d, y: 0.13348130184856077d), new NpgsqlTypes.NpgsqlPoint(x: 0.8897039455566048d, y: 0.7792573006902511d), new NpgsqlTypes.NpgsqlPoint(x: 0.1933524973808327d, y: 0.9844552202842973d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7718911019121261d, y: 0.17751107651750442d), new NpgsqlTypes.NpgsqlPoint(x: 0.19556316935217466d, y: 0.7310339954209768d), new NpgsqlTypes.NpgsqlPoint(x: 0.38354798228267317d, y: 0.1901801305361316d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 110,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8983831435766922d, y: 0.2777600511638705d), new NpgsqlTypes.NpgsqlPoint(x: 0.2958320490091848d, y: 0.14826034087910167d), new NpgsqlTypes.NpgsqlPoint(x: 0.21240006076373097d, y: 0.2872288657784482d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5669041177822772d, y: 0.3662635585439685d), new NpgsqlTypes.NpgsqlPoint(x: 0.4096156686018677d, y: 0.04399462968430523d), new NpgsqlTypes.NpgsqlPoint(x: 0.7385819228815897d, y: 0.786074846918187d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23211388177044145d, y: 0.11171735319888443d), new NpgsqlTypes.NpgsqlPoint(x: 0.3823627163767458d, y: 0.6270974359819649d), new NpgsqlTypes.NpgsqlPoint(x: 0.5611977167539562d, y: 0.021048711768129613d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44129669615488465d, y: 0.20610605399856186d), new NpgsqlTypes.NpgsqlPoint(x: 0.8544616164444996d, y: 0.48686786868061804d), new NpgsqlTypes.NpgsqlPoint(x: 0.34327299322632976d, y: 0.2699598309980379d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03889202542792758d, y: 0.5300016785625502d), new NpgsqlTypes.NpgsqlPoint(x: 0.5185668438882463d, y: 0.053064968618213526d), new NpgsqlTypes.NpgsqlPoint(x: 0.9739397380454878d, y: 0.2458250198538796d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7245316106316699d, y: 0.38947227630193626d), new NpgsqlTypes.NpgsqlPoint(x: 0.5746401864528847d, y: 0.5245956057368625d), new NpgsqlTypes.NpgsqlPoint(x: 0.6747820426494259d, y: 0.44427754142178044d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1757931019526d, y: 0.042967029879168006d), new NpgsqlTypes.NpgsqlPoint(x: 0.9038731246315076d, y: 0.5828669290414378d), new NpgsqlTypes.NpgsqlPoint(x: 0.37576327776529994d, y: 0.6562357543991522d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2861908120586858d, y: 0.9192194720091565d), new NpgsqlTypes.NpgsqlPoint(x: 0.12078240398077811d, y: 0.38742010190825693d), new NpgsqlTypes.NpgsqlPoint(x: 0.8483831192443718d, y: 0.23869027700198964d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 115,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2840921991675869d, y: 0.20371441385044564d), new NpgsqlTypes.NpgsqlPoint(x: 0.6533749539847107d, y: 0.8099387016418799d), new NpgsqlTypes.NpgsqlPoint(x: 0.4699217058748385d, y: 0.10435237105492035d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5409111618593508d, y: 0.26383320256746545d), new NpgsqlTypes.NpgsqlPoint(x: 0.8929775832629797d, y: 0.17273004682495452d), new NpgsqlTypes.NpgsqlPoint(x: 0.5841780885700033d, y: 0.7776711991823922d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5295026977595937d, y: 0.9363021325446421d), new NpgsqlTypes.NpgsqlPoint(x: 0.39720714358542686d, y: 0.565915396635736d), new NpgsqlTypes.NpgsqlPoint(x: 0.014493325283377323d, y: 0.8423662394175473d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12518314810567543d, y: 0.12006054298205715d), new NpgsqlTypes.NpgsqlPoint(x: 0.7367835748856435d, y: 0.7638492168653959d), new NpgsqlTypes.NpgsqlPoint(x: 0.04002133681055109d, y: 0.6089104028058866d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8897511935845611d, y: 0.8362875244221208d), new NpgsqlTypes.NpgsqlPoint(x: 0.2961490572916411d, y: 0.9275497440074907d), new NpgsqlTypes.NpgsqlPoint(x: 0.14882577528794905d, y: 0.5372916106931012d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3624092872914899d, y: 0.49380254367875187d), new NpgsqlTypes.NpgsqlPoint(x: 0.2882688699483912d, y: 0.232229453139851d), new NpgsqlTypes.NpgsqlPoint(x: 0.40537341852827524d, y: 0.05795925903276433d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9298565538392285d, y: 0.0916407725405457d), new NpgsqlTypes.NpgsqlPoint(x: 0.5334478788724212d, y: 0.6720744932270409d), new NpgsqlTypes.NpgsqlPoint(x: 0.4351359081932631d, y: 0.717580091681439d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17887188506404772d, y: 0.7954826777420797d), new NpgsqlTypes.NpgsqlPoint(x: 0.4190472230528446d, y: 0.32801173488693425d), new NpgsqlTypes.NpgsqlPoint(x: 0.32470787372867793d, y: 0.21310503621404564d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08719264915949088d, y: 0.9127056826311647d), new NpgsqlTypes.NpgsqlPoint(x: 0.36738324953785484d, y: 0.44984895913161793d), new NpgsqlTypes.NpgsqlPoint(x: 0.9792365424839578d, y: 0.03343703757781913d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9307436607862768d, y: 0.7670483048678352d), new NpgsqlTypes.NpgsqlPoint(x: 0.6919860471374085d, y: 0.8099860874835663d), new NpgsqlTypes.NpgsqlPoint(x: 0.8619559788909592d, y: 0.7077085436971217d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38023517760523384d, y: 0.022824307320027604d), new NpgsqlTypes.NpgsqlPoint(x: 0.3921363545552822d, y: 0.13271439327420465d), new NpgsqlTypes.NpgsqlPoint(x: 0.995269855579517d, y: 0.07904424216147676d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5344293998025931d, y: 0.4639376779365816d), new NpgsqlTypes.NpgsqlPoint(x: 0.5336172931079809d, y: 0.8301279401476476d), new NpgsqlTypes.NpgsqlPoint(x: 0.3556216521390517d, y: 0.7764404649582091d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31684442488312314d, y: 0.3533943981969786d), new NpgsqlTypes.NpgsqlPoint(x: 0.39851678415498837d, y: 0.8367391680889821d), new NpgsqlTypes.NpgsqlPoint(x: 0.8108874963537761d, y: 0.31480493582610203d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 123,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8833666539385555d, y: 0.11478194889491189d), new NpgsqlTypes.NpgsqlPoint(x: 0.48878225327197244d, y: 0.9778618939552829d), new NpgsqlTypes.NpgsqlPoint(x: 0.8856756201555008d, y: 0.6908992290581514d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06586666695080745d, y: 0.6085596594408552d), new NpgsqlTypes.NpgsqlPoint(x: 0.4730827086089864d, y: 0.9989815501096436d), new NpgsqlTypes.NpgsqlPoint(x: 0.8266617440771108d, y: 0.9526094287783233d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4866534018830837d, y: 0.9137477453888606d), new NpgsqlTypes.NpgsqlPoint(x: 0.6479879946887259d, y: 0.8182789976172193d), new NpgsqlTypes.NpgsqlPoint(x: 0.5201516508548866d, y: 0.2757875394853103d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6951181398733322d, y: 0.11767684597276551d), new NpgsqlTypes.NpgsqlPoint(x: 0.5691637511029454d, y: 0.618391678976706d), new NpgsqlTypes.NpgsqlPoint(x: 0.7937156455381634d, y: 0.35037258431830065d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 125,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4192826844838452d, y: 0.34771491613326866d), new NpgsqlTypes.NpgsqlPoint(x: 0.9710816321596489d, y: 0.2527152449416935d), new NpgsqlTypes.NpgsqlPoint(x: 0.8220824695498354d, y: 0.4913981122421591d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07887843808369621d, y: 0.894667211253253d), new NpgsqlTypes.NpgsqlPoint(x: 0.34751088889602655d, y: 0.2440581347256241d), new NpgsqlTypes.NpgsqlPoint(x: 0.8092082226347823d, y: 0.17094977348475848d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7544170842965032d, y: 0.19916975984073926d), new NpgsqlTypes.NpgsqlPoint(x: 0.03339655372787187d, y: 0.04796739265100258d), new NpgsqlTypes.NpgsqlPoint(x: 0.4228061168094933d, y: 0.686791897169244d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6176193364495133d, y: 0.8806971523965874d), new NpgsqlTypes.NpgsqlPoint(x: 0.061158960078104174d, y: 0.3512177433358239d), new NpgsqlTypes.NpgsqlPoint(x: 0.7869973456579944d, y: 0.6115532250784614d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06684480845774332d, y: 0.14376679318364471d), new NpgsqlTypes.NpgsqlPoint(x: 0.26093247588471047d, y: 0.25710671377170624d), new NpgsqlTypes.NpgsqlPoint(x: 0.8816285498779167d, y: 0.35557989763100983d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6919226584557764d, y: 0.5740906994762431d), new NpgsqlTypes.NpgsqlPoint(x: 0.17236030297737792d, y: 0.8239302487521228d), new NpgsqlTypes.NpgsqlPoint(x: 0.13807492823016487d, y: 0.4865650474871266d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29853453556273624d, y: 0.4180134740191769d), new NpgsqlTypes.NpgsqlPoint(x: 0.931030010241367d, y: 0.35613483944080315d), new NpgsqlTypes.NpgsqlPoint(x: 0.10288441238047619d, y: 0.17081233401819307d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6846561893896786d, y: 0.8157075504588571d), new NpgsqlTypes.NpgsqlPoint(x: 0.908168779954422d, y: 0.98675966997097d), new NpgsqlTypes.NpgsqlPoint(x: 0.8039823308400612d, y: 0.5217890179326772d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24114161102813314d, y: 0.05981811855303798d), new NpgsqlTypes.NpgsqlPoint(x: 0.7430317055596224d, y: 0.8179375307569589d), new NpgsqlTypes.NpgsqlPoint(x: 0.01553155186826205d, y: 0.5191500988067141d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8399234084756627d, y: 0.314930883961146d), new NpgsqlTypes.NpgsqlPoint(x: 0.04202494959899172d, y: 0.45541256405015906d), new NpgsqlTypes.NpgsqlPoint(x: 0.4326343931281269d, y: 0.4991516207703175d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 132,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.952750050446949d, y: 0.849300594540203d), new NpgsqlTypes.NpgsqlPoint(x: 0.5581754420144358d, y: 0.6449863757047811d), new NpgsqlTypes.NpgsqlPoint(x: 0.08581075016114503d, y: 0.5201987854439545d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.007342273890173057d, y: 0.023578324998740574d), new NpgsqlTypes.NpgsqlPoint(x: 0.5035262845112897d, y: 0.05742963580345961d), new NpgsqlTypes.NpgsqlPoint(x: 0.08346431524664666d, y: 0.6538242077958254d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7226735706439273d, y: 0.9177681296839347d), new NpgsqlTypes.NpgsqlPoint(x: 0.25794269729130836d, y: 0.5788498466254387d), new NpgsqlTypes.NpgsqlPoint(x: 0.5150364744603383d, y: 0.8475309967215352d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5989770898013597d, y: 0.2565287999971725d), new NpgsqlTypes.NpgsqlPoint(x: 0.51649914700543d, y: 0.0835784653137227d), new NpgsqlTypes.NpgsqlPoint(x: 0.6121026558865635d, y: 0.06730191889744275d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45490988644981967d, y: 0.07696723126374438d), new NpgsqlTypes.NpgsqlPoint(x: 0.1367614436416671d, y: 0.8990339528677065d), new NpgsqlTypes.NpgsqlPoint(x: 0.4971730534372153d, y: 0.3829710590032669d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8251225862839903d, y: 0.3987128500592012d), new NpgsqlTypes.NpgsqlPoint(x: 0.4632981433080544d, y: 0.1844893263638524d), new NpgsqlTypes.NpgsqlPoint(x: 0.30042012013529473d, y: 0.8712754633643007d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4229191433730791d, y: 0.4991401459131378d), new NpgsqlTypes.NpgsqlPoint(x: 0.09132570957766883d, y: 0.7564207209778872d), new NpgsqlTypes.NpgsqlPoint(x: 0.4225776280940332d, y: 0.8521807458448379d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 136,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.039081166264768985d, y: 0.02676643050008576d), new NpgsqlTypes.NpgsqlPoint(x: 0.13880986161493059d, y: 0.5953921412869748d), new NpgsqlTypes.NpgsqlPoint(x: 0.4709234327722307d, y: 0.7922820409671296d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.97218977165821d, y: 0.06013050134539344d), new NpgsqlTypes.NpgsqlPoint(x: 0.6936703363608547d, y: 0.6403395786414315d), new NpgsqlTypes.NpgsqlPoint(x: 0.32361499622690804d, y: 0.1765553918893118d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1110545381086755d, y: 0.4189820953714215d), new NpgsqlTypes.NpgsqlPoint(x: 0.020883132615845956d, y: 0.999466277143213d), new NpgsqlTypes.NpgsqlPoint(x: 0.7266171396868119d, y: 0.11882346579160541d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06425153151081553d, y: 0.6019586795505535d), new NpgsqlTypes.NpgsqlPoint(x: 0.015581769830247727d, y: 0.4043539946075885d), new NpgsqlTypes.NpgsqlPoint(x: 0.1123677599120283d, y: 0.12681342762172654d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06348304685370043d, y: 0.10714511339714106d), new NpgsqlTypes.NpgsqlPoint(x: 0.6909801785205744d, y: 0.027580062654232074d), new NpgsqlTypes.NpgsqlPoint(x: 0.302148790813454d, y: 0.13517367308207573d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4953513918240614d, y: 0.9416535624764596d), new NpgsqlTypes.NpgsqlPoint(x: 0.7479824186864873d, y: 0.7959639193591441d), new NpgsqlTypes.NpgsqlPoint(x: 0.9067867946293269d, y: 0.03380756434268095d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5856512280574967d, y: 0.10130036180097335d), new NpgsqlTypes.NpgsqlPoint(x: 0.9229340476246253d, y: 0.3849307795995487d), new NpgsqlTypes.NpgsqlPoint(x: 0.21085078958321313d, y: 0.11952775202705324d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06480955410310996d, y: 0.29306066992795843d), new NpgsqlTypes.NpgsqlPoint(x: 0.8364721267118678d, y: 0.6108760640631711d), new NpgsqlTypes.NpgsqlPoint(x: 0.2220327374172527d, y: 0.11871833619407524d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8023254223541597d, y: 0.9838926338958112d), new NpgsqlTypes.NpgsqlPoint(x: 0.20588961050533772d, y: 0.36704401483187d), new NpgsqlTypes.NpgsqlPoint(x: 0.8707535710903092d, y: 0.006340332625615619d)),
},
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1mi(
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
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

                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathArraypathArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathArraypathArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray1mi_id
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray1mi_id", 
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
                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray1mi_id
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
    npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6885012161386628d, y: 0.09949452071217979d), new NpgsqlTypes.NpgsqlPoint(x: 0.6814339011683674d, y: 0.466114093015521d), new NpgsqlTypes.NpgsqlPoint(x: 0.6919883281644702d, y: 0.7024861132027926d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2056667584303632d, y: 0.39963520111078144d), new NpgsqlTypes.NpgsqlPoint(x: 0.6633329940084046d, y: 0.3646744111981589d), new NpgsqlTypes.NpgsqlPoint(x: 0.15599167125600089d, y: 0.22936450137008735d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9111355818510919d, y: 0.8941587743069556d), new NpgsqlTypes.NpgsqlPoint(x: 0.8821596438822884d, y: 0.18416888891187166d), new NpgsqlTypes.NpgsqlPoint(x: 0.9721646985409615d, y: 0.057476090774164046d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06540835924857624d, y: 0.47213256531285874d), new NpgsqlTypes.NpgsqlPoint(x: 0.014410154133415398d, y: 0.4901996180950515d), new NpgsqlTypes.NpgsqlPoint(x: 0.9371548882628346d, y: 0.0020439686568398674d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.399301739906079d, y: 0.8905567702938765d), new NpgsqlTypes.NpgsqlPoint(x: 0.42632042307080065d, y: 0.5779917673228565d), new NpgsqlTypes.NpgsqlPoint(x: 0.20150459906657714d, y: 0.818088990090453d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8546766156493663d, y: 0.44550967936211927d), new NpgsqlTypes.NpgsqlPoint(x: 0.301204517834295d, y: 0.47967859567596993d), new NpgsqlTypes.NpgsqlPoint(x: 0.535468331353044d, y: 0.35419619853118955d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7041728761152259d, y: 0.3515710137867488d), new NpgsqlTypes.NpgsqlPoint(x: 0.14512017869256422d, y: 0.44790792819726166d), new NpgsqlTypes.NpgsqlPoint(x: 0.7268454506456212d, y: 0.3268349312575044d)),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray1mi_id
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
    npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray1mi_id", 
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
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.576717032677081d, y: 0.4024165112526944d), new NpgsqlTypes.NpgsqlPoint(x: 0.2785209819790997d, y: 0.02036572055019903d), new NpgsqlTypes.NpgsqlPoint(x: 0.4957886209280792d, y: 0.731864697432013d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9376112679216625d, y: 0.754246048500468d), new NpgsqlTypes.NpgsqlPoint(x: 0.9473907832751591d, y: 0.9802598227122092d), new NpgsqlTypes.NpgsqlPoint(x: 0.30938310161515303d, y: 0.8743646458537583d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4498234104642381d, y: 0.29418255702933405d), new NpgsqlTypes.NpgsqlPoint(x: 0.02155687392340866d, y: 0.43411905671417383d), new NpgsqlTypes.NpgsqlPoint(x: 0.7165876950934416d, y: 0.3595701361782928d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38085496925699003d, y: 0.8007398297248491d), new NpgsqlTypes.NpgsqlPoint(x: 0.7406781977819299d, y: 0.9045139573212667d), new NpgsqlTypes.NpgsqlPoint(x: 0.34659494499391663d, y: 0.8060056487910524d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8294700630122684d, y: 0.9828724515319054d), new NpgsqlTypes.NpgsqlPoint(x: 0.3305279847094864d, y: 0.990937213668522d), new NpgsqlTypes.NpgsqlPoint(x: 0.829051009300218d, y: 0.9837585304592219d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09405946212592053d, y: 0.04784965507606287d), new NpgsqlTypes.NpgsqlPoint(x: 0.04608741152948337d, y: 0.2488473768106395d), new NpgsqlTypes.NpgsqlPoint(x: 0.24600194340984038d, y: 0.39133506305103305d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray1M> models = null;

                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray1M> models = null;

                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathArraypathArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathArraypathArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await ((INpgsqlPathArraypathArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathArraypathArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathArraypathArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathArraypathArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await ((INpgsqlPathArraypathArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathArraypathArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr2.Value = 70;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 15;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[29], false);
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
                parametr1.Value = 24;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[29], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[23],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[29], false);
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
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[3], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[4], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[5], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[6], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[7], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[8], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[9], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[10], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[21],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[22],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[23],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[24],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[25],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 106, query1, 52, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 24, query1, 40, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 23, query1, 123, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 90, query1, 6, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[28],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 106, query1, 72, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 23, query1, 116, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 52, query1, 24, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 104, query1, 24, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[24],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelBatchAsync(connection, 123, 10))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[27],_testData[29], false);
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
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelBatch(connection, 116, 58))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPathArraypathArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 81);
                var models = await ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(13));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[17], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[18], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[19], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[20], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[9],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[10],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[11],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[12],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathArraypathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 47);
                var models =  ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(21));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[9], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[10], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[11], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[12], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[13], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[14], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[15], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[16], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[17], false);NpgsqlPathpathArray1M.AssertModel(models[9],_testData[18], false);NpgsqlPathpathArray1M.AssertModel(models[10],_testData[19], false);NpgsqlPathpathArray1M.AssertModel(models[11],_testData[20], false);NpgsqlPathpathArray1M.AssertModel(models[12],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[13],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[14],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[15],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[16],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[17],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[18],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[19],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[20],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray1MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
FROM public.binary_npgsqlpathpatharray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpathArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPathArraypathArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathArraypathArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPathArraypathArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPathArraypathArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
FROM public.binary_npgsqlpathpatharray1m m
LEFT JOIN public.binary_npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpathArray1M>(15);

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
                ((INpgsqlPathArraypathArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathArraypathArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpathArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpathArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpathArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpathArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpathArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpathArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpathArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpathArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpathArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpathArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpathArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpathArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpathArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpathArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPathArraypathArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPathArraypathArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpathArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpathArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpathArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpathArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpathArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpathArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpathArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpathArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpathArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpathArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpathArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpathArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpathArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpathArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlPathpathArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlPathpathArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlPathpathArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlPathpathArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlPathpathArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlPathpathArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlPathpathArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlPathpathArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlPathpathArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlPathpathArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlPathpathArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlPathpathArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlPathpathArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlPathpathArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlPathpathArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathArraypathArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathArraypathArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathArraypathArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathArraypathArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

