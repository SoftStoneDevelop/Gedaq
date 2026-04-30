

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
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4167327519356858d, y: 0.8973823148963005d), radius: 0.032916595901081314d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7576822357504238d, y: 0.7752927787465559d), radius: 0.6751755774318028d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5448862561404134d, y: 0.8459699561039238d), radius: 0.3546695866889451d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9358548706851342d, y: 0.18500244139890787d), radius: 0.000317078850749386d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1765154943989653d, y: 0.8385113904971988d), radius: 0.6379440140440984d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2027513682428258d, y: 0.7773104674805511d), radius: 0.11747068347514045d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3367605340588d, y: 0.3281410860495927d), radius: 0.7659006990390277d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7408647225694034d, y: 0.0269140042714775d), radius: 0.19472570055736493d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.610486943910012d, y: 0.7018499628004128d), radius: 0.5473140917767526d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9301253512142896d, y: 0.445003303883431d), radius: 0.23400494668812066d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7557058103758862d, y: 0.5845730872015971d), radius: 0.9870213576595713d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11457864458952705d, y: 0.25933019899511567d), radius: 0.5874098891569303d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8638409807791575d, y: 0.24440930188085108d), radius: 0.4359143762722044d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8189468557265491d, y: 0.458278229310939d), radius: 0.1830020711976662d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7638373894403918d, y: 0.5705292858274734d), radius: 0.39975809347810043d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9660058299943404d, y: 0.48048784031092917d), radius: 0.9060125895672307d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2965820587757805d, y: 0.5106928112466181d), radius: 0.5688232863093022d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8420862931186446d, y: 0.2310911786729496d), radius: 0.5580707546878254d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38149851839132976d, y: 0.3012825060221219d), radius: 0.21296731915550615d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15120015751431148d, y: 0.8062042058037602d), radius: 0.7256741396177355d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.345187572469823d, y: 0.11625375867534049d), radius: 0.5508219680215485d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31333605257919916d, y: 0.5720854319558895d), radius: 0.14036561737862396d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2631605008069582d, y: 0.6592980552193837d), radius: 0.25369555063968086d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9435179073699831d, y: 0.9873434228184765d), radius: 0.49682929892473615d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07032131971014954d, y: 0.08673965664402705d), radius: 0.010706609823254887d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25091287947356133d, y: 0.18072522729263385d), radius: 0.5323142148369522d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6769461892607118d, y: 0.8795071583492776d), radius: 0.8476708386373458d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.012363647880641926d, y: 0.9560513779151549d), radius: 0.11120627118647886d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2992271249811791d, y: 0.49026695202803094d), radius: 0.9770563919448118d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20310364253450197d, y: 0.008023941587511962d), radius: 0.09135001051397373d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9069937421385301d, y: 0.2875759000138126d), radius: 0.04306556758292557d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36030975376725116d, y: 0.8075531068064158d), radius: 0.6320493005242469d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10110563786533922d, y: 0.94434483462569d), radius: 0.23439600917182424d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7598095997768747d, y: 0.85505242349747d), radius: 0.8250866705463511d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09251385611381613d, y: 0.10391560801764699d), radius: 0.7006696781135258d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25986996836183596d, y: 0.6609173263565412d), radius: 0.3528526592113823d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.515813058084996d, y: 0.6250130683871405d), radius: 0.12945480580368462d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.72625986064864d, y: 0.29379212593726745d), radius: 0.8948456424834156d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7864676792252758d, y: 0.4556898334522217d), radius: 0.19169859884804552d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5326710770035012d, y: 0.6651302618950631d), radius: 0.864530199890509d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.052494520225713104d, y: 0.35277006840287783d), radius: 0.07833792316743726d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5413557241942085d, y: 0.7969362830792485d), radius: 0.9583630060047222d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44201827224439594d, y: 0.8737369037953319d), radius: 0.6377419610285768d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45232975090690974d, y: 0.04853518265372936d), radius: 0.6727911168918784d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7780133421472399d, y: 0.4281669458255726d), radius: 0.7054561045133845d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9974277958279445d, y: 0.1344774795662067d), radius: 0.036977847166147604d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2216692190896602d, y: 0.557971590579558d), radius: 0.257827775408516d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30671424161690075d, y: 0.3401267718032761d), radius: 0.46255972229872944d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13269965677866413d, y: 0.1830992287256057d), radius: 0.9701466426760198d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4755018849176532d, y: 0.1740558462923616d), radius: 0.9924029542569708d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11390602867060895d, y: 0.21812885777800828d), radius: 0.8023076288984489d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25246732058428556d, y: 0.6760735321341672d), radius: 0.36858944448570463d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6244555575305535d, y: 0.7564930554729734d), radius: 0.10475915679153203d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4492216093523149d, y: 0.6553755717198227d), radius: 0.12109640144446265d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6933017693223822d, y: 0.6642777541832986d), radius: 0.8447420624275177d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2336215749112407d, y: 0.7931461948812082d), radius: 0.8933566272282769d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28879664268232974d, y: 0.2170384835921476d), radius: 0.5384951235118159d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13060723871038182d, y: 0.12264305159950017d), radius: 0.28786345879604625d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4540937592081741d, y: 0.3392199482141186d), radius: 0.010728195629230997d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7637147399283905d, y: 0.4136967335595192d), radius: 0.16852776291708016d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3142771278445414d, y: 0.17446321640924556d), radius: 0.32934810453900576d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04262534272412677d, y: 0.7719575667582352d), radius: 0.6828999913604324d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0860260925931483d, y: 0.27692516263717515d), radius: 0.8591894934946179d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18548949339777687d, y: 0.4579093358741886d), radius: 0.0832521935832572d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8019811625801078d, y: 0.5828865482048633d), radius: 0.834196048820923d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41493842769768174d, y: 0.8734017260384199d), radius: 0.3549095996153433d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9268115417076347d, y: 0.9027878982386379d), radius: 0.5091709203282068d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41590905990468996d, y: 0.23588696863394043d), radius: 0.14937588812379554d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3244350999100365d, y: 0.30865431531165777d), radius: 0.6662709406813953d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27321719496765895d, y: 0.10476214795693317d), radius: 0.16135189987923393d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5122417970880205d, y: 0.21211894252420838d), radius: 0.5641430252230992d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8416189660562968d, y: 0.21975873143641467d), radius: 0.21790128258619845d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.028720898211492152d, y: 0.7595282358553473d), radius: 0.7349045874077044d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08129237597882744d, y: 0.3010810583401017d), radius: 0.11662210373063175d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7850929654045716d, y: 0.9086558595644696d), radius: 0.03320920306929909d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18390315542040248d, y: 0.3554617483991842d), radius: 0.8775394044312583d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7537715722487197d, y: 0.22400535992815718d), radius: 0.04650325430737001d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17800290259321006d, y: 0.8610635734990557d), radius: 0.21584315854888736d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5042401357923698d, y: 0.30781672665182847d), radius: 0.23339637969665616d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.028686828489567384d, y: 0.5011240067338578d), radius: 0.9596833934455803d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.019899652551795488d, y: 0.8400376817330321d), radius: 0.8323501489110844d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42949722043431227d, y: 0.057913947094949125d), radius: 0.9156190465225255d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5091957367598559d, y: 0.520125008831727d), radius: 0.7560246376603336d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2959484146668169d, y: 0.7757187454273278d), radius: 0.4947683705194589d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5339243610825427d, y: 0.5953494259399544d), radius: 0.5241339040900979d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29696811674376744d, y: 0.0707962688795678d), radius: 0.8658594749903177d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7789164885455271d, y: 0.8676832695994534d), radius: 0.32638951099315616d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9010802986725589d, y: 0.28710296017052295d), radius: 0.7147827070442527d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11449455288055477d, y: 0.40727646594253397d), radius: 0.029627505598823767d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31854839879216956d, y: 0.45016957124059087d), radius: 0.8386664486735985d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32116535571498417d, y: 0.962121167981007d), radius: 0.22857077814325377d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6128003196315862d, y: 0.9825134562107598d), radius: 0.6611273207738046d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6141153484720996d, y: 0.011523683128697448d), radius: 0.6639909932919482d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.007556260104477408d, y: 0.49359373472771295d), radius: 0.04199363314587101d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6144783240397715d, y: 0.6797611715319163d), radius: 0.8706187413751582d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9944667054120363d, y: 0.032992160995390596d), radius: 0.5432654162535759d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9009091834051423d, y: 0.14394213203231365d), radius: 0.40029440668052896d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9087891551516949d, y: 0.6176670232404723d), radius: 0.865235331581754d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.772070843230513d, y: 0.8495832476968685d), radius: 0.7436962644157002d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9393758783647808d, y: 0.5637942646797784d), radius: 0.5717439733712821d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37631056879174907d, y: 0.6748132821978797d), radius: 0.8089196781420397d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9106309986139227d, y: 0.41960805841466453d), radius: 0.7672999287758708d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.964563479199779d, y: 0.6148151491633296d), radius: 0.29044693150328327d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.013021145548627766d, y: 0.02466567967939781d), radius: 0.38113558392902336d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6337595632903968d, y: 0.9644898915025142d), radius: 0.26030810630259693d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49540318672343897d, y: 0.6452711526562858d), radius: 0.8311401765373133d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 101,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13450138115449717d, y: 0.9821382940832478d), radius: 0.31567957827107584d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3625155230003868d, y: 0.8410797995548349d), radius: 0.42971640084622686d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7039825436138569d, y: 0.1309793334274042d), radius: 0.2075434706389443d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5326547339220615d, y: 0.2025957194032516d), radius: 0.9900011474801437d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6182207956305392d, y: 0.361998099012417d), radius: 0.5032446760593076d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1422586838232266d, y: 0.4043409202353333d), radius: 0.24111147338600636d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8420750737949909d, y: 0.7904642097484749d), radius: 0.4899896843119159d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5314273343679506d, y: 0.692797763175149d), radius: 0.20306417031253265d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42260900770897336d, y: 0.40421307016271624d), radius: 0.19516695783441018d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5094038702475316d, y: 0.7195729217694935d), radius: 0.8357841325873822d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 103,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9668072472218616d, y: 0.36316032954138d), radius: 0.02864278670599396d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6257252768585995d, y: 0.8180977165679748d), radius: 0.6475977147479504d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4469520166340012d, y: 0.7299944733097717d), radius: 0.9446775170905677d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 111,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.003978682739280481d, y: 0.5989268871177627d), radius: 0.7815597306764422d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4977815889002889d, y: 0.8720686118516029d), radius: 0.18101162679460536d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21346756807108347d, y: 0.0036945527754076446d), radius: 0.10321080717091646d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3425246437567828d, y: 0.015648471598952662d), radius: 0.3733212696704885d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3891075117116619d, y: 0.6251836260832301d), radius: 0.6405474663477445d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5195014890308821d, y: 0.24892523011917156d), radius: 0.18545275466801003d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7871343907709926d, y: 0.7959376808135692d), radius: 0.5222120473444405d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6331459284568478d, y: 0.8247040363065532d), radius: 0.7286714174826646d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6299096751981271d, y: 0.1020787792808101d), radius: 0.4503913207279907d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15126503332728813d, y: 0.05350668791525781d), radius: 0.6811863190805565d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20095875562157117d, y: 0.3240516791928938d), radius: 0.3945368070067041d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8942318072721708d, y: 0.8217097132829031d), radius: 0.46355944861573717d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 120,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19910872823090464d, y: 0.6779554384563233d), radius: 0.43630172797694444d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7763250741369212d, y: 0.5720635956991045d), radius: 0.8292542654611382d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6383739533262256d, y: 0.9866518688369772d), radius: 0.9238500751869598d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4916591088777166d, y: 0.11092177797379332d), radius: 0.7334626233808725d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6370109771978818d, y: 0.9386100801866615d), radius: 0.6310972088142354d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8143437777730427d, y: 0.5938302087107178d), radius: 0.29838420276611965d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33114834387595615d, y: 0.42842507487712567d), radius: 0.9924222445577536d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 122,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5234272073599159d, y: 0.6358932925367647d), radius: 0.36767799763260445d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6593871020538111d, y: 0.5275609851340646d), radius: 0.7487862696682855d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5642872623142752d, y: 0.6995501473283242d), radius: 0.10714233984025934d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43777990329443217d, y: 0.0018540488460296878d), radius: 0.8619034216477197d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39537399862831335d, y: 0.08985824899074912d), radius: 0.8616066665790366d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20774610748046274d, y: 0.7343762208765573d), radius: 0.9916575655112063d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06198620863735127d, y: 0.6057558829282879d), radius: 0.45816438671979676d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18731796187866256d, y: 0.9271224373899088d), radius: 0.534423305669484d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5356115358892951d, y: 0.8291985254287582d), radius: 0.3745837863159953d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3888195473149011d, y: 0.2722464730303392d), radius: 0.5927933249332692d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5430323072401503d, y: 0.31398600836819357d), radius: 0.014310048113293727d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07972181052850669d, y: 0.23955813413985483d), radius: 0.4435079949856441d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6954082887470672d, y: 0.21521644031740572d), radius: 0.9614016547088585d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40703032813249485d, y: 0.8206453180937008d), radius: 0.07651635868301754d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 125,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6274036201813102d, y: 0.4236399398750834d), radius: 0.5306066859062624d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6796550409826737d, y: 0.43097212013238073d), radius: 0.5716379381848685d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1394005250190996d, y: 0.662509490050316d), radius: 0.41627717474154313d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8977830171025265d, y: 0.6858634507018246d), radius: 0.5124183019941457d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.905313199466774d, y: 0.18730237808050998d), radius: 0.015076698569629565d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4631093625655587d, y: 0.8199189926823643d), radius: 0.0646643710355399d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9894098219263688d, y: 0.10286910423769591d), radius: 0.40143959944121754d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43318287977345904d, y: 0.20562714314584152d), radius: 0.9339327352535414d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 126,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6885027803786358d, y: 0.6629746159425194d), radius: 0.6183958193863937d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7355663091007243d, y: 0.30536389713241074d), radius: 0.16759302704250845d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9629827011046332d, y: 0.7855563656658028d), radius: 0.6983075793829255d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23423646299329504d, y: 0.32870314900982367d), radius: 0.5617229434488524d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41408206877937714d, y: 0.42282544111962406d), radius: 0.9431036633043637d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12217869538720538d, y: 0.05077111602261308d), radius: 0.4211767505021127d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03506817082048597d, y: 0.6583548472234257d), radius: 0.6997347370493264d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 134,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.022955405075260282d, y: 0.30388751153800886d), radius: 0.24255706171738056d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12771980562191498d, y: 0.3883718491562075d), radius: 0.4374966146693252d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25160454048707004d, y: 0.22954462403677867d), radius: 0.49997474994626223d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 140,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.038867302167748585d, y: 0.3984949626069765d), radius: 0.08917585043177823d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45133273785918837d, y: 0.7419448596488019d), radius: 0.45951457384805405d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4650790235862138d, y: 0.5486175680403105d), radius: 0.9887606541357774d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23630276064704436d, y: 0.5158102360546376d), radius: 0.8171120171756129d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46057105045035607d, y: 0.4475260256182003d), radius: 0.6612613608098307d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6086032544231827d, y: 0.05799103403968486d), radius: 0.6285973320258114d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5399913706902051d, y: 0.36078114169863484d), radius: 0.6259553628258993d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9914954137591209d, y: 0.04862803561213758d), radius: 0.27003633651278225d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04248962488368657d, y: 0.9434427986280094d), radius: 0.36690821582565636d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.00751103813362064d, y: 0.40939202390241036d), radius: 0.8841859852161107d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12633600267944245d, y: 0.498360786130298d), radius: 0.383408891416382d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 146,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6428608441723636d, y: 0.6763065069141667d), radius: 0.9905470407022245d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43279766027629296d, y: 0.6530816379409797d), radius: 0.25463057325088867d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6970917677160979d, y: 0.1228907150059031d), radius: 0.3612288550887568d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 147,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7050168997956393d, y: 0.6910856245554542d), radius: 0.2690151439676539d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40065396610411674d, y: 0.11216867980852496d), radius: 0.768041451859239d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.008019536949298689d, y: 0.004799526898806361d), radius: 0.49632699476484854d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8621573693210577d, y: 0.14487019394085443d), radius: 0.12469960257589108d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19769997830320007d, y: 0.5786904377994347d), radius: 0.20283914213103804d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.517196666892007d, y: 0.3458522994514127d), radius: 0.05198963890141772d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4759424263369755d, y: 0.14128558925624723d), radius: 0.15574800927524957d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7007561731059638d, y: 0.9335346614303736d), radius: 0.20929607402319728d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3758314683395291d, y: 0.6877065998656025d), radius: 0.03269815666702858d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2888737724419188d, y: 0.41225376643558287d), radius: 0.16578738183344222d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.051074762611077795d, y: 0.5808274752823568d), radius: 0.6918004100190376d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04721854283733318d, y: 0.8186884595475191d), radius: 0.5363069307617157d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6089553217884007d, y: 0.5492124056330864d), radius: 0.8771595120353357d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.01832828396428443d, y: 0.8832289318673687d), radius: 0.358993869650025d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9755837287978943d, y: 0.1323786604502789d), radius: 0.7411089335298832d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 152,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8917220600125523d, y: 0.4491532638250324d), radius: 0.5441255598251109d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32104339766084367d, y: 0.24536866738698127d), radius: 0.6856008902328683d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7642990016466407d, y: 0.20896521273772828d), radius: 0.26644150593664917d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21225171021804234d, y: 0.08775310973528727d), radius: 0.9572340571789767d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8372183102234546d, y: 0.2691412883017231d), radius: 0.35751357310155796d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6200909881803572d, y: 0.732069396891843d), radius: 0.06446702593110387d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19365427010905234d, y: 0.8631707702439858d), radius: 0.16028912920885152d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 159,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6676483098250923d, y: 0.4986585762899858d), radius: 0.5712929406886202d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5833114302377417d, y: 0.9526406993861064d), radius: 0.7334114503844644d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5652346359077116d, y: 0.41798560327153655d), radius: 0.026106452809968705d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18388372364042138d, y: 0.5200794014905745d), radius: 0.5800411712759292d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3706710379201926d, y: 0.6383241883165413d), radius: 0.347159907283059d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02473285386093005d, y: 0.07983515051921242d), radius: 0.11767134352815356d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13616642332764484d, y: 0.6091773742771422d), radius: 0.049453044281308256d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7347794369005253d, y: 0.10810667505155913d), radius: 0.844427646163632d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47067001697429767d, y: 0.014688005808016547d), radius: 0.6036778807986659d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41151624672335374d, y: 0.6396754280599954d), radius: 0.2430401366624897d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 165,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0006671434530105547d, y: 0.9603135679890239d), radius: 0.9841622152226196d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3182060779747352d, y: 0.17916434774531897d), radius: 0.41692119382192316d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39505169500593784d, y: 0.35884402652876823d), radius: 0.5672587321528746d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1891558589959258d, y: 0.6199994900641612d), radius: 0.2913198982662021d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 170,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5205212103868271d, y: 0.44428339235806025d), radius: 0.40737168042247196d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8330000222771087d, y: 0.871470560474055d), radius: 0.7996372892847654d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7980123795786901d, y: 0.5935384490919229d), radius: 0.5682537555419078d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0605871983237497d, y: 0.3103552329557754d), radius: 0.10576126470790503d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7508147801411156d, y: 0.6583676576680599d), radius: 0.16135772046257357d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8733190373074454d, y: 0.7917320660715575d), radius: 0.8037710128220257d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1939471628556898d, y: 0.8333895911302606d), radius: 0.7447561365736183d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14682655593395955d, y: 0.7084699637351997d), radius: 0.043733761125256954d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33145891634282465d, y: 0.6582491574984419d), radius: 0.21442807718221413d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6525245912586128d, y: 0.8004034916958337d), radius: 0.7893706096406832d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8454395188890392d, y: 0.7431625453104662d), radius: 0.6824918282101062d),
},
},
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.012363647880641926d, y: 0.9560513779151549d), radius: 0.11120627118647886d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2992271249811791d, y: 0.49026695202803094d), radius: 0.9770563919448118d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20310364253450197d, y: 0.008023941587511962d), radius: 0.09135001051397373d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9069937421385301d, y: 0.2875759000138126d), radius: 0.04306556758292557d),
}));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.72625986064864d, y: 0.29379212593726745d), radius: 0.8948456424834156d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7864676792252758d, y: 0.4556898334522217d), radius: 0.19169859884804552d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5326710770035012d, y: 0.6651302618950631d), radius: 0.864530199890509d),
}));
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
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11390602867060895d, y: 0.21812885777800828d), radius: 0.8023076288984489d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25246732058428556d, y: 0.6760735321341672d), radius: 0.36858944448570463d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6244555575305535d, y: 0.7564930554729734d), radius: 0.10475915679153203d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4492216093523149d, y: 0.6553755717198227d), radius: 0.12109640144446265d),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4540937592081741d, y: 0.3392199482141186d), radius: 0.010728195629230997d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7637147399283905d, y: 0.4136967335595192d), radius: 0.16852776291708016d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3142771278445414d, y: 0.17446321640924556d), radius: 0.32934810453900576d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04262534272412677d, y: 0.7719575667582352d), radius: 0.6828999913604324d),
}));
                nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.028720898211492152d, y: 0.7595282358553473d), radius: 0.7349045874077044d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08129237597882744d, y: 0.3010810583401017d), radius: 0.11662210373063175d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7850929654045716d, y: 0.9086558595644696d), radius: 0.03320920306929909d),
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 125;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
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
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[26],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 152;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 84;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
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
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
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
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[29], false);
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 152;
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
                        Assert.That(models, Has.Count.EqualTo(28));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[29], false);
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
                parametr1.Value = 27;
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
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 159;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[3], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[4], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[5], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[6], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[7], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[8], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[9], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[10], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[11], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[12], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[26],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 55, query1, 159, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
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
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[29], false);
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
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 140, query1, 63, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 103, query1, 101, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[29], false);
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
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 14, query1, 152, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 52, query1, 120, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[29], false);
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
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 120, query1, 52, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 152, query1, 111, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[29], false);
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
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelBatch(connection, 38, query1, 27, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelBatchAsync(connection, 63, 9))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

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
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[1], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[2], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[3], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[4], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[5], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[6], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[7], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[8], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[9], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[10], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[11], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[12], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[26],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[27],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[28],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelBatch(connection, 74, 52))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[8], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[9], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[10], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[11], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[12], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[29], false);
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

                Assert.That(models, Has.Count.EqualTo(15));
NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[15], false);NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[16], false);NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[17], false);NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[18], false);NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[19], false);NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[20], false);NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[21], false);NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[22], false);NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[23], false);NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[24], false);NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[25], false);NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[26], false);NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[27], false);NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[28], false);NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleArraycircleArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleArraycircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 38);
                var models =  ((INpgsqlCircleArraycircleArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));
NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[6], false);NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[7], false);NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[8], false);NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[9], false);NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[10], false);NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[11], false);NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[12], false);NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[13], false);NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[14], false);NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[15], false);NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[16], false);NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[17], false);NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[18], false);NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[19], false);NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[20], false);NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[21], false);NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[22], false);NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[23], false);NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[24], false);NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[25], false);NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[26], false);NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[27], false);NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[28], false);NpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[29], false);
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
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlCirclecircleArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlCircleArraycircleArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleArraycircleArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlCircleArraycircleArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                models = await ((INpgsqlCircleArraycircleArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
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
            methodName:"ImportModelInner",
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
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlCirclecircleArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlCircleArraycircleArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleArraycircleArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlCircleArraycircleArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlCircleArraycircleArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlCirclecircleArray1M>(15);

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
                ((INpgsqlCircleArraycircleArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleArraycircleArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlCircleArraycircleArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlCircleArraycircleArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[29],_testData[29], false);
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlCircleArraycircleArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleArraycircleArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

