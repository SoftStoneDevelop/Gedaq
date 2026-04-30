

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
    internal partial interface INpgsqlBoxArrayboxArray
    {
    }
    
    internal partial class NpgsqlBoxArrayboxArray : INpgsqlBoxArrayboxArray
    {


#region TestData

        private readonly NpgsqlBoxboxArray1M[] _testData = new NpgsqlBoxboxArray1M[]
        {
            new NpgsqlBoxboxArray1M
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.287458968857759d,right: 0.9731796412944049d,bottom: 0.26778105897201954d,left: 0.28351635527884744d),
new NpgsqlTypes.NpgsqlBox(top: 0.7896480209741946d,right: 0.811588463059661d,bottom: 0.11486055188980304d,left: 0.5029998595908182d),
new NpgsqlTypes.NpgsqlBox(top: 0.7898228138151495d,right: 0.6864281812713505d,bottom: 0.1645401255343264d,left: 0.05883692133805385d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9726032738690025d,right: 0.24803576625142787d,bottom: 0.3485683761119961d,left: 0.23991104418093268d),
new NpgsqlTypes.NpgsqlBox(top: 0.35795858155466287d,right: 0.45285637967501535d,bottom: 0.0928203710558756d,left: 0.11709515859230069d),
new NpgsqlTypes.NpgsqlBox(top: 0.1745691211101208d,right: 0.8397916574763391d,bottom: 0.100191830176802d,left: 0.506053909606233d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4770574347966756d,right: 0.7089273328949378d,bottom: 0.3490754397871897d,left: 0.4823358170665166d),
new NpgsqlTypes.NpgsqlBox(top: 0.555980476985986d,right: 0.582311612823508d,bottom: 0.4426177578171998d,left: 0.35797231603588386d),
new NpgsqlTypes.NpgsqlBox(top: 0.9741657930840472d,right: 0.7617096898705052d,bottom: 0.051084617932849796d,left: 0.29903893845850815d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.847714389257702d,right: 0.3887279653061626d,bottom: 0.4828575937558116d,left: 0.1881380433051908d),
new NpgsqlTypes.NpgsqlBox(top: 0.8808480813942101d,right: 0.8054110024384454d,bottom: 0.6730390134913597d,left: 0.721367938798943d),
new NpgsqlTypes.NpgsqlBox(top: 0.6295993730599668d,right: 0.4029533080830041d,bottom: 0.4682181820705267d,left: 0.30080012113119414d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.33121304032604604d,right: 0.949935776213689d,bottom: 0.28659477656826826d,left: 0.7261273569477764d),
new NpgsqlTypes.NpgsqlBox(top: 0.9725860605798485d,right: 0.9978489101667238d,bottom: 0.3428587398413333d,left: 0.8796881176106041d),
new NpgsqlTypes.NpgsqlBox(top: 0.18999085942784644d,right: 0.9291014122413034d,bottom: 0.10144693664944715d,left: 0.8222488065169279d),
new NpgsqlTypes.NpgsqlBox(top: 0.5394338333546862d,right: 0.42347127714882316d,bottom: 0.17360694486613948d,left: 0.278038277492871d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8855685470570489d,right: 0.4850317815431301d,bottom: 0.22189486659897317d,left: 0.24723000557876207d),
new NpgsqlTypes.NpgsqlBox(top: 0.9200112171384737d,right: 0.46874849340266955d,bottom: 0.6444956811831362d,left: 0.1419800359512624d),
new NpgsqlTypes.NpgsqlBox(top: 0.49568991757801006d,right: 0.7123640140151518d,bottom: 0.4714371866319922d,left: 0.40499981752349823d),
new NpgsqlTypes.NpgsqlBox(top: 0.9569981978977107d,right: 0.8744323603892026d,bottom: 0.5492440102319831d,left: 0.5949447578020438d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7673254961184534d,right: 0.5379229441023551d,bottom: 0.7593416360964805d,left: 0.4242321801400668d),
new NpgsqlTypes.NpgsqlBox(top: 0.9474579949575909d,right: 0.22905388836481944d,bottom: 0.5004738083192981d,left: 0.04185972616460354d),
new NpgsqlTypes.NpgsqlBox(top: 0.8380840079428843d,right: 0.6025299723575376d,bottom: 0.8329628424043181d,left: 0.46485931470253894d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9053089802990707d,right: 0.76493396394994d,bottom: 0.8748511868529756d,left: 0.3928061671756605d),
new NpgsqlTypes.NpgsqlBox(top: 0.8910429765270873d,right: 0.7713701643535259d,bottom: 0.1977586747928185d,left: 0.6950825862772848d),
new NpgsqlTypes.NpgsqlBox(top: 0.8146608976387865d,right: 0.6327871848053171d,bottom: 0.003913567282282204d,left: 0.05215870237291964d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9803702149645652d,right: 0.20554608113253647d,bottom: 0.463068742203975d,left: 0.17325254349743247d),
new NpgsqlTypes.NpgsqlBox(top: 0.8108432094464219d,right: 0.8294275763194113d,bottom: 0.7921572473308169d,left: 0.7250448682187333d),
new NpgsqlTypes.NpgsqlBox(top: 0.14188972716390758d,right: 0.459872646622975d,bottom: 0.11455448743377417d,left: 0.15874411114966291d),
new NpgsqlTypes.NpgsqlBox(top: 0.9580152520681464d,right: 0.9297323315423656d,bottom: 0.539050479455303d,left: 0.8730159448140619d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9002743828973819d,right: 0.9665200066677955d,bottom: 0.08802370317705843d,left: 0.19721966394970591d),
new NpgsqlTypes.NpgsqlBox(top: 0.4629869246854398d,right: 0.8892933857500229d,bottom: 0.06422882490149906d,left: 0.6557738025870479d),
new NpgsqlTypes.NpgsqlBox(top: 0.650727043117167d,right: 0.9882938253783964d,bottom: 0.2041017784653476d,left: 0.17191773233542051d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6581380028015756d,right: 0.9843117243494136d,bottom: 0.08639273416459858d,left: 0.17577164306839066d),
new NpgsqlTypes.NpgsqlBox(top: 0.8918939093837862d,right: 0.37997062950304195d,bottom: 0.24533446606763498d,left: 0.3576632228097302d),
new NpgsqlTypes.NpgsqlBox(top: 0.47942863429686766d,right: 0.6038051634015184d,bottom: 0.45621215768852486d,left: 0.35861354114240607d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9859439710438701d,right: 0.9492916399543349d,bottom: 0.7849007934130297d,left: 0.30652549535024554d),
new NpgsqlTypes.NpgsqlBox(top: 0.9047251195881676d,right: 0.5542006887218348d,bottom: 0.8648637356406146d,left: 0.09456457320592437d),
new NpgsqlTypes.NpgsqlBox(top: 0.8924807747483412d,right: 0.23166780183527913d,bottom: 0.07670876406070715d,left: 0.198263332915653d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.12526869815556307d,right: 0.12209910320647621d,bottom: 0.06945576774519635d,left: 0.01784702781958325d),
new NpgsqlTypes.NpgsqlBox(top: 0.22912006988015465d,right: 0.8999917612767963d,bottom: 0.07993055314888386d,left: 0.7273275879278774d),
new NpgsqlTypes.NpgsqlBox(top: 0.3436010483383246d,right: 0.256855481665043d,bottom: 0.21023559306071982d,left: 0.04577558286318528d),
new NpgsqlTypes.NpgsqlBox(top: 0.37986647066735535d,right: 0.883062733614056d,bottom: 0.3293967525726583d,left: 0.49552756670221887d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8869773499487977d,right: 0.2725380545715914d,bottom: 0.6016255462048354d,left: 0.048429776022672844d),
new NpgsqlTypes.NpgsqlBox(top: 0.6885511808643362d,right: 0.8827540134547274d,bottom: 0.05846728368364351d,left: 0.47605306622431764d),
new NpgsqlTypes.NpgsqlBox(top: 0.6322756200427461d,right: 0.9392173246377512d,bottom: 0.4742758361066737d,left: 0.0859779566668536d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5509498387571657d,right: 0.3746567180856051d,bottom: 0.20389054952554964d,left: 0.07102706107506751d),
new NpgsqlTypes.NpgsqlBox(top: 0.6707143975492353d,right: 0.8163045658501539d,bottom: 0.6241887606617589d,left: 0.030001669201105252d),
new NpgsqlTypes.NpgsqlBox(top: 0.9758105380913592d,right: 0.6687561260007587d,bottom: 0.34695049626340757d,left: 0.3859987977268483d),
new NpgsqlTypes.NpgsqlBox(top: 0.7667491789434009d,right: 0.5629527126544092d,bottom: 0.16387254520673d,left: 0.16067545251209336d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7652084796310026d,right: 0.22090015706181987d,bottom: 0.2790861081497795d,left: 0.20215561057938958d),
new NpgsqlTypes.NpgsqlBox(top: 0.9053670923779114d,right: 0.886152612741529d,bottom: 0.859758416125976d,left: 0.7787286413736245d),
new NpgsqlTypes.NpgsqlBox(top: 0.35405338215297977d,right: 0.726145661964013d,bottom: 0.2752453389010241d,left: 0.19805396549637422d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.626794086520841d,right: 0.7781822700634182d,bottom: 0.1587895445353642d,left: 0.1101666489625236d),
new NpgsqlTypes.NpgsqlBox(top: 0.6421298934504912d,right: 0.4202686357254345d,bottom: 0.5990219458754076d,left: 0.009978168294271117d),
new NpgsqlTypes.NpgsqlBox(top: 0.8832046803166422d,right: 0.9067396525136385d,bottom: 0.4610070584671444d,left: 0.022686485708715676d),
new NpgsqlTypes.NpgsqlBox(top: 0.5630061735771866d,right: 0.39631086329720244d,bottom: 0.1888882987572994d,left: 0.18835991812059205d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7165759643599591d,right: 0.9665205030774984d,bottom: 0.30924495421683307d,left: 0.7955655930352257d),
new NpgsqlTypes.NpgsqlBox(top: 0.6324749150874982d,right: 0.6206345875955884d,bottom: 0.12391025976798642d,left: 0.18372174938236197d),
new NpgsqlTypes.NpgsqlBox(top: 0.47581163450591146d,right: 0.2265477220370865d,bottom: 0.05881883773059404d,left: 0.09937966239550777d),
new NpgsqlTypes.NpgsqlBox(top: 0.2951857311873993d,right: 0.8569359345265967d,bottom: 0.2148495158947903d,left: 0.8383483232426177d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9862413033667837d,right: 0.9926497914960914d,bottom: 0.7790473189862653d,left: 0.7452013462333935d),
new NpgsqlTypes.NpgsqlBox(top: 0.6063204299774401d,right: 0.9805137273488568d,bottom: 0.45023651784160656d,left: 0.9518445912251928d),
new NpgsqlTypes.NpgsqlBox(top: 0.875602624647311d,right: 0.7228036680683552d,bottom: 0.34075273193203737d,left: 0.36812576989272827d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6560607118205684d,right: 0.7934229973424048d,bottom: 0.24903288976246285d,left: 0.6878160457774465d),
new NpgsqlTypes.NpgsqlBox(top: 0.3156502820507838d,right: 0.9900980809995621d,bottom: 0.11855847828901378d,left: 0.127069911390441d),
new NpgsqlTypes.NpgsqlBox(top: 0.8146196463773049d,right: 0.8736556091492685d,bottom: 0.7338941135232195d,left: 0.6919025595739592d),
new NpgsqlTypes.NpgsqlBox(top: 0.33638794789235993d,right: 0.9012867322410872d,bottom: 0.025707691978073544d,left: 0.5280967048139209d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8150748566506575d,right: 0.22086808740663122d,bottom: 0.46559561784500314d,left: 0.1820565418803386d),
new NpgsqlTypes.NpgsqlBox(top: 0.8449968253506316d,right: 0.6796807109876978d,bottom: 0.02342661497986176d,left: 0.47499869381985593d),
new NpgsqlTypes.NpgsqlBox(top: 0.21704129896966406d,right: 0.9042971558445495d,bottom: 0.10118644303413105d,left: 0.8650900697945734d),
new NpgsqlTypes.NpgsqlBox(top: 0.9578175666764327d,right: 0.9481063332568739d,bottom: 0.0952025619898772d,left: 0.1348241671967474d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.543894955980231d,right: 0.84688401166237d,bottom: 0.35100388401727756d,left: 0.6671050573812518d),
new NpgsqlTypes.NpgsqlBox(top: 0.13056071461833518d,right: 0.8163294286492211d,bottom: 0.09735738417771922d,left: 0.3728599979353098d),
new NpgsqlTypes.NpgsqlBox(top: 0.3706266514362191d,right: 0.4482941182830319d,bottom: 0.3653876457180537d,left: 0.05389717332082d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8211807927969419d,right: 0.6615816227300992d,bottom: 0.6570461047036907d,left: 0.3827463397757117d),
new NpgsqlTypes.NpgsqlBox(top: 0.620827327588836d,right: 0.8657130535163425d,bottom: 0.2329659650463204d,left: 0.014788591170056042d),
new NpgsqlTypes.NpgsqlBox(top: 0.6777632648296675d,right: 0.3284697719757934d,bottom: 0.5463322463997816d,left: 0.22218711775496336d),
new NpgsqlTypes.NpgsqlBox(top: 0.2099465032956992d,right: 0.36312362658168884d,bottom: 0.0022963755282850995d,left: 0.014051164988647113d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6877027962593126d,right: 0.8843285082836747d,bottom: 0.5326375340162495d,left: 0.403013587242518d),
new NpgsqlTypes.NpgsqlBox(top: 0.7984675273337059d,right: 0.9441389621718149d,bottom: 0.05240268732607589d,left: 0.7647634694388654d),
new NpgsqlTypes.NpgsqlBox(top: 0.6465941408420284d,right: 0.950184189415781d,bottom: 0.3516469748769935d,left: 0.6053604578419216d),
new NpgsqlTypes.NpgsqlBox(top: 0.6261953903937022d,right: 0.2691392940960122d,bottom: 0.41884147378622694d,left: 0.09914795812069332d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9007950350340922d,right: 0.3415505322819987d,bottom: 0.015169171210999588d,left: 0.3163192264849377d),
new NpgsqlTypes.NpgsqlBox(top: 0.22931615832733165d,right: 0.5351427885084322d,bottom: 0.13903633300568086d,left: 0.18535046778249664d),
new NpgsqlTypes.NpgsqlBox(top: 0.5938632627216038d,right: 0.5966951627800686d,bottom: 0.3763693697383419d,left: 0.19328779299191434d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6712312552609664d,right: 0.7012516743349114d,bottom: 0.4357194522807607d,left: 0.23817229280926522d),
new NpgsqlTypes.NpgsqlBox(top: 0.9128413107268134d,right: 0.7099134608547473d,bottom: 0.5863782635640133d,left: 0.12097693510461327d),
new NpgsqlTypes.NpgsqlBox(top: 0.24064798734142245d,right: 0.8640260451436486d,bottom: 0.1229079497596478d,left: 0.8607517269462003d),
new NpgsqlTypes.NpgsqlBox(top: 0.9936643896064685d,right: 0.6847668796438212d,bottom: 0.9200911889421829d,left: 0.26845272336904713d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8247726509419531d,right: 0.6878353082676514d,bottom: 0.6470410201916102d,left: 0.48440356214993274d),
new NpgsqlTypes.NpgsqlBox(top: 0.744650419360882d,right: 0.8308692175560416d,bottom: 0.4563198309490354d,left: 0.7641677170585641d),
new NpgsqlTypes.NpgsqlBox(top: 0.9528560508991891d,right: 0.9628356868909798d,bottom: 0.5516345044435103d,left: 0.8187484178027788d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8185262564944038d,right: 0.3228156213815836d,bottom: 0.4272942196831153d,left: 0.23641893794500546d),
new NpgsqlTypes.NpgsqlBox(top: 0.6734645133748313d,right: 0.46643964325069187d,bottom: 0.146379026996993d,left: 0.046223341725893374d),
new NpgsqlTypes.NpgsqlBox(top: 0.5093223723117081d,right: 0.4599249839838009d,bottom: 0.1385227245610131d,left: 0.4305343865874157d),
new NpgsqlTypes.NpgsqlBox(top: 0.36924009621163534d,right: 0.6025799262278748d,bottom: 0.3040216262328338d,left: 0.30562189977107546d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.618639640180746d,right: 0.6764492307880848d,bottom: 0.15493657874574496d,left: 0.3788404095291217d),
new NpgsqlTypes.NpgsqlBox(top: 0.6103234381764091d,right: 0.9172581136857665d,bottom: 0.25795700254078235d,left: 0.5164664474549213d),
new NpgsqlTypes.NpgsqlBox(top: 0.10455335511500286d,right: 0.36670844362514676d,bottom: 0.09352787273223784d,left: 0.26001347002585007d),
new NpgsqlTypes.NpgsqlBox(top: 0.2587166966565534d,right: 0.969800649125964d,bottom: 0.16082340063265455d,left: 0.2624300215401333d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.863853227651529d,right: 0.9635064050658738d,bottom: 0.27100118573698895d,left: 0.8148403455022797d),
new NpgsqlTypes.NpgsqlBox(top: 0.8071475719347397d,right: 0.44612812381944855d,bottom: 0.06871262360403785d,left: 0.10833095621742062d),
new NpgsqlTypes.NpgsqlBox(top: 0.8688188565129494d,right: 0.9847517652745547d,bottom: 0.23980280894285277d,left: 0.2256444979429103d),
new NpgsqlTypes.NpgsqlBox(top: 0.889611250503737d,right: 0.3845006257698853d,bottom: 0.5694229309410906d,left: 0.16052813814729727d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.43371573270310404d,right: 0.48304766131984134d,bottom: 0.07859895730440969d,left: 0.2887851248832666d),
new NpgsqlTypes.NpgsqlBox(top: 0.9450612926036266d,right: 0.5660087927685968d,bottom: 0.7443197598164493d,left: 0.41518862240415855d),
new NpgsqlTypes.NpgsqlBox(top: 0.7813069481571742d,right: 0.7273876799715435d,bottom: 0.03696293612231616d,left: 0.397000586086802d),
new NpgsqlTypes.NpgsqlBox(top: 0.5032608988148579d,right: 0.8813354724123115d,bottom: 0.06329819506974144d,left: 0.239378421419978d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3485651015470921d,right: 0.821789200184014d,bottom: 0.22050704605125804d,left: 0.6338385660656792d),
new NpgsqlTypes.NpgsqlBox(top: 0.5864501923085714d,right: 0.9733072591326086d,bottom: 0.31756062358696047d,left: 0.9240357773510681d),
new NpgsqlTypes.NpgsqlBox(top: 0.8546831008995958d,right: 0.6281723801882929d,bottom: 0.7064550148312903d,left: 0.19062543507134988d),
new NpgsqlTypes.NpgsqlBox(top: 0.5636059670906478d,right: 0.7493210326822656d,bottom: 0.41220389611811814d,left: 0.4681519340882295d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7779166614941433d,right: 0.899791289251988d,bottom: 0.24325262789700874d,left: 0.581787025158841d),
new NpgsqlTypes.NpgsqlBox(top: 0.48344252800118304d,right: 0.8845891129347637d,bottom: 0.25536035958998027d,left: 0.7787410819685346d),
new NpgsqlTypes.NpgsqlBox(top: 0.7283465818691511d,right: 0.9043696921298047d,bottom: 0.432573159488048d,left: 0.12906630414878506d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.25114696759480915d,right: 0.48457268251312713d,bottom: 0.1894422077014738d,left: 0.20650403169834552d),
new NpgsqlTypes.NpgsqlBox(top: 0.6393806337735946d,right: 0.4699602180575515d,bottom: 0.10757030141571822d,left: 0.3784015364451615d),
new NpgsqlTypes.NpgsqlBox(top: 0.99199966165729d,right: 0.5003134902533071d,bottom: 0.17448748351695198d,left: 0.29625856774304915d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 110,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6201045928465456d,right: 0.8912523138060368d,bottom: 0.07152443547682841d,left: 0.2046673329145544d),
new NpgsqlTypes.NpgsqlBox(top: 0.7952163062434884d,right: 0.5760242251181895d,bottom: 0.6073716417920898d,left: 0.4139764745007303d),
new NpgsqlTypes.NpgsqlBox(top: 0.8085523407937747d,right: 0.47658439021802534d,bottom: 0.5480104102753455d,left: 0.16323263674296784d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9737019187408588d,right: 0.36033708294696176d,bottom: 0.6873869008641249d,left: 0.3192536547721111d),
new NpgsqlTypes.NpgsqlBox(top: 0.6629173642171857d,right: 0.47500404229362136d,bottom: 0.38008175964912305d,left: 0.41847283622997133d),
new NpgsqlTypes.NpgsqlBox(top: 0.9385327256313284d,right: 0.9686579728667489d,bottom: 0.6743203771645833d,left: 0.6883258367400963d),
new NpgsqlTypes.NpgsqlBox(top: 0.9377411477390881d,right: 0.9390874659117384d,bottom: 0.5143013412606441d,left: 0.8050856698970908d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5723961889064588d,right: 0.8157654093551456d,bottom: 0.140964889415363d,left: 0.3258500645460958d),
new NpgsqlTypes.NpgsqlBox(top: 0.8116362958125726d,right: 0.577201517010219d,bottom: 0.5467163900598293d,left: 0.37236774344743473d),
new NpgsqlTypes.NpgsqlBox(top: 0.6010085959177054d,right: 0.5342327646948647d,bottom: 0.33832746430018135d,left: 0.2751481151840024d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9310842231853587d,right: 0.5804541507758012d,bottom: 0.6894865762835558d,left: 0.33570693737024915d),
new NpgsqlTypes.NpgsqlBox(top: 0.8498642846573816d,right: 0.8588575410278162d,bottom: 0.619640108094328d,left: 0.7559938671557771d),
new NpgsqlTypes.NpgsqlBox(top: 0.5108432637196129d,right: 0.979263536533607d,bottom: 0.018969102879097366d,left: 0.0898452950908305d),
new NpgsqlTypes.NpgsqlBox(top: 0.9424608379440667d,right: 0.7305285059592795d,bottom: 0.769011856027545d,left: 0.05728897095674723d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 115,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6776745719125636d,right: 0.8512754775981646d,bottom: 0.08510895590878831d,left: 0.002958237071226555d),
new NpgsqlTypes.NpgsqlBox(top: 0.45412436431082326d,right: 0.33695523886914136d,bottom: 0.2798304728157588d,left: 0.17968059992442265d),
new NpgsqlTypes.NpgsqlBox(top: 0.13766087327308874d,right: 0.6724721552595307d,bottom: 0.1330452362038581d,left: 0.2493981069182919d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.34920825826642676d,right: 0.5658145591296063d,bottom: 0.027637339104938707d,left: 0.4920102476079302d),
new NpgsqlTypes.NpgsqlBox(top: 0.9824403957083698d,right: 0.5597586185704881d,bottom: 0.39590486376881495d,left: 0.13777987548783366d),
new NpgsqlTypes.NpgsqlBox(top: 0.673433839196053d,right: 0.6772418438152256d,bottom: 0.23190753833980082d,left: 0.044801509764282654d),
new NpgsqlTypes.NpgsqlBox(top: 0.985331227297119d,right: 0.7617202633917796d,bottom: 0.002947725263672374d,left: 0.12255605705588213d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.850452701580975d,right: 0.6153532017855681d,bottom: 0.30775083331405373d,left: 0.03378469839304332d),
new NpgsqlTypes.NpgsqlBox(top: 0.9490815374367941d,right: 0.4980062634729353d,bottom: 0.9418955829078266d,left: 0.07712502218990036d),
new NpgsqlTypes.NpgsqlBox(top: 0.6856050905295692d,right: 0.46258962810875737d,bottom: 0.49376516179008567d,left: 0.3046671706259697d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9311344007074098d,right: 0.7112459921926447d,bottom: 0.13588940410225503d,left: 0.3524387371457691d),
new NpgsqlTypes.NpgsqlBox(top: 0.8308496104285185d,right: 0.6332186986834761d,bottom: 0.8177312371909928d,left: 0.47628183555210246d),
new NpgsqlTypes.NpgsqlBox(top: 0.5783484405765925d,right: 0.5628760415220866d,bottom: 0.3775825344377597d,left: 0.2848723548101071d),
new NpgsqlTypes.NpgsqlBox(top: 0.5235650881842895d,right: 0.936803712429017d,bottom: 0.09803566035652822d,left: 0.6117987716966444d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6441488481711843d,right: 0.7988236145800119d,bottom: 0.25616571688477496d,left: 0.14930295583251874d),
new NpgsqlTypes.NpgsqlBox(top: 0.9344974803949888d,right: 0.6308895793506212d,bottom: 0.22325804227354096d,left: 0.0559231337158409d),
new NpgsqlTypes.NpgsqlBox(top: 0.521774520247367d,right: 0.1763706360268823d,bottom: 0.11697604867172173d,left: 0.03626395267393201d),
new NpgsqlTypes.NpgsqlBox(top: 0.6843850564743846d,right: 0.9644687949194464d,bottom: 0.5442125383606324d,left: 0.6924128688885031d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8901627070084519d,right: 0.9799760442882478d,bottom: 0.4536143485201257d,left: 0.5515073967808076d),
new NpgsqlTypes.NpgsqlBox(top: 0.7257856060037741d,right: 0.8767362116537446d,bottom: 0.3020532997187292d,left: 0.6352234647798839d),
new NpgsqlTypes.NpgsqlBox(top: 0.23744975020281633d,right: 0.34299676111739874d,bottom: 0.05896477144461709d,left: 0.04366454314918522d),
new NpgsqlTypes.NpgsqlBox(top: 0.3451198861754208d,right: 0.8383337956289891d,bottom: 0.15008644827098427d,left: 0.5119792119107873d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 118,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7557468207433937d,right: 0.9949517877212907d,bottom: 0.3799224781639723d,left: 0.3695136616024509d),
new NpgsqlTypes.NpgsqlBox(top: 0.7155643782103317d,right: 0.5895857338236571d,bottom: 0.5293226803210237d,left: 0.46217143389288884d),
new NpgsqlTypes.NpgsqlBox(top: 0.6578142994330656d,right: 0.6727945141484788d,bottom: 0.5045296069409325d,left: 0.386538217194074d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9275695531343098d,right: 0.9504124495119508d,bottom: 0.4443983492347694d,left: 0.32036218936529137d),
new NpgsqlTypes.NpgsqlBox(top: 0.8364112317882066d,right: 0.6648586596833371d,bottom: 0.13452118844116356d,left: 0.06485922589116266d),
new NpgsqlTypes.NpgsqlBox(top: 0.7992229878217435d,right: 0.19014158564168482d,bottom: 0.18755743582238626d,left: 0.06212988697632904d),
new NpgsqlTypes.NpgsqlBox(top: 0.3003847785188354d,right: 0.8807383332777461d,bottom: 0.2831617480707358d,left: 0.8589060891298521d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6784513510628597d,right: 0.9069028546801382d,bottom: 0.6486813777655633d,left: 0.6508091040238408d),
new NpgsqlTypes.NpgsqlBox(top: 0.7766837085963059d,right: 0.9919834124396828d,bottom: 0.4842363155001006d,left: 0.44178884524306195d),
new NpgsqlTypes.NpgsqlBox(top: 0.5656954075348295d,right: 0.869207938215479d,bottom: 0.24538938185674364d,left: 0.6224428003455471d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 122,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8900171422692493d,right: 0.47368321738377983d,bottom: 0.5789965867714052d,left: 0.16041657199384574d),
new NpgsqlTypes.NpgsqlBox(top: 0.7539718149998268d,right: 0.4832605647559166d,bottom: 0.008946112460111455d,left: 0.00399038139381569d),
new NpgsqlTypes.NpgsqlBox(top: 0.7725583812341612d,right: 0.19445550414723445d,bottom: 0.29218615757063215d,left: 0.03182296190310829d),
new NpgsqlTypes.NpgsqlBox(top: 0.8599739841791775d,right: 0.5837255801155566d,bottom: 0.3092358892119679d,left: 0.4243546330908756d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6339216319051254d,right: 0.5205201942865746d,bottom: 0.09780010583928556d,left: 0.30881397126469956d),
new NpgsqlTypes.NpgsqlBox(top: 0.9913055094379972d,right: 0.7560262392751451d,bottom: 0.4097859331265227d,left: 0.2626999537813549d),
new NpgsqlTypes.NpgsqlBox(top: 0.765419919977188d,right: 0.6219931021076264d,bottom: 0.5870367342904339d,left: 0.3615347725833954d),
new NpgsqlTypes.NpgsqlBox(top: 0.8762489340642642d,right: 0.717806376677122d,bottom: 0.5142503397587336d,left: 0.33619687146041044d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.942014988523858d,right: 0.6132086736223056d,bottom: 0.8888606042823697d,left: 0.591521796203195d),
new NpgsqlTypes.NpgsqlBox(top: 0.6543141347041537d,right: 0.45436115339102456d,bottom: 0.4889951226972524d,left: 0.016715746998089087d),
new NpgsqlTypes.NpgsqlBox(top: 0.9205938708666633d,right: 0.5211996577507472d,bottom: 0.22102298855529845d,left: 0.4538431389113422d),
new NpgsqlTypes.NpgsqlBox(top: 0.5114419862829286d,right: 0.6318556380327605d,bottom: 0.04246709233179469d,left: 0.41594826509601135d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8038108052192369d,right: 0.6526127263355266d,bottom: 0.10269224301290447d,left: 0.3994743363260579d),
new NpgsqlTypes.NpgsqlBox(top: 0.6318097737601747d,right: 0.8094072129485913d,bottom: 0.3948334382106503d,left: 0.52762995091496d),
new NpgsqlTypes.NpgsqlBox(top: 0.7507923191461882d,right: 0.8111049133263301d,bottom: 0.6921615605878811d,left: 0.6845128077391682d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 137,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4515297238807392d,right: 0.7907947450961905d,bottom: 0.37860482713275423d,left: 0.1468307679742612d),
new NpgsqlTypes.NpgsqlBox(top: 0.3776324288020596d,right: 0.9554770913065858d,bottom: 0.19815844672072502d,left: 0.6630144929240723d),
new NpgsqlTypes.NpgsqlBox(top: 0.766504246960975d,right: 0.924513477176726d,bottom: 0.6525752400974524d,left: 0.33363359954655747d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 146,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5273127210880783d,right: 0.9202941570023747d,bottom: 0.4022795081720121d,left: 0.8109287962341507d),
new NpgsqlTypes.NpgsqlBox(top: 0.5203097096450252d,right: 0.9631853200658457d,bottom: 0.06173278957736783d,left: 0.6032258708069024d),
new NpgsqlTypes.NpgsqlBox(top: 0.8357272951741029d,right: 0.9444868723185712d,bottom: 0.2688540702340245d,left: 0.09549653083318588d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8900160265056581d,right: 0.6445486663975871d,bottom: 0.08938332812645322d,left: 0.21217600872491738d),
new NpgsqlTypes.NpgsqlBox(top: 0.49838490183516815d,right: 0.4857686457430971d,bottom: 0.21466148366995297d,left: 0.299772945465306d),
new NpgsqlTypes.NpgsqlBox(top: 0.7563459666064087d,right: 0.8607950498163419d,bottom: 0.0851681944681264d,left: 0.6594617758744762d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.33720601325226696d,right: 0.6081759972477455d,bottom: 2.9272159164595024E-05d,left: 0.24104730635685345d),
new NpgsqlTypes.NpgsqlBox(top: 0.8649165811299441d,right: 0.8489685455624347d,bottom: 0.4754650136197829d,left: 0.5727441145918131d),
new NpgsqlTypes.NpgsqlBox(top: 0.48197407428839434d,right: 0.27219536383367027d,bottom: 0.38542811253615505d,left: 0.18792694754244166d),
new NpgsqlTypes.NpgsqlBox(top: 0.9492986187291156d,right: 0.3054534078875907d,bottom: 0.16378311065040985d,left: 0.1927998302477839d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 147,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6482116839598684d,right: 0.5902998030421427d,bottom: 0.14590968072306876d,left: 0.0459565188081964d),
new NpgsqlTypes.NpgsqlBox(top: 0.49124636561940294d,right: 0.3630181610027087d,bottom: 0.08560489368882374d,left: 0.19523017210764526d),
new NpgsqlTypes.NpgsqlBox(top: 0.8512680529181454d,right: 0.861308965948338d,bottom: 0.7979607750100975d,left: 0.4112206106550411d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 151,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5083028142713106d,right: 0.20259841185975758d,bottom: 0.3850370813445615d,left: 0.179346442411637d),
new NpgsqlTypes.NpgsqlBox(top: 0.6595323343056174d,right: 0.18919034331258255d,bottom: 0.6404795641065322d,left: 0.12472312374840744d),
new NpgsqlTypes.NpgsqlBox(top: 0.8388110546577326d,right: 0.8847535450888426d,bottom: 0.835001684658353d,left: 0.624849124024578d),
new NpgsqlTypes.NpgsqlBox(top: 0.8718792017123853d,right: 0.7819367115281886d,bottom: 0.5238752287960475d,left: 0.5960128916427972d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8219823711023265d,right: 0.8821500596279435d,bottom: 0.46489511236887826d,left: 0.12012619292116444d),
new NpgsqlTypes.NpgsqlBox(top: 0.5431401026804482d,right: 0.8926417002998731d,bottom: 0.1027891330397529d,left: 0.36859105579159435d),
new NpgsqlTypes.NpgsqlBox(top: 0.9653169703490101d,right: 0.7519512716985428d,bottom: 0.802809757132495d,left: 0.32750664344098934d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 157,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4904302011001225d,right: 0.9851538514374131d,bottom: 0.33621899385520615d,left: 0.5287330991274883d),
new NpgsqlTypes.NpgsqlBox(top: 0.730347517381271d,right: 0.7545074928169032d,bottom: 0.14774455390751517d,left: 0.4390113406251064d),
new NpgsqlTypes.NpgsqlBox(top: 0.7305382109648336d,right: 0.9632990115000439d,bottom: 0.08226065091154067d,left: 0.41555237131359835d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4095743701105541d,right: 0.7569385733111034d,bottom: 0.09124128110687546d,left: 0.05054740543188008d),
new NpgsqlTypes.NpgsqlBox(top: 0.7646489425257185d,right: 0.9027731550658108d,bottom: 0.22901026813752678d,left: 0.34853548459875083d),
new NpgsqlTypes.NpgsqlBox(top: 0.8897756059556019d,right: 0.8210569802452335d,bottom: 0.8755468287187582d,left: 0.6527613460807202d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 164,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4121294473536734d,right: 0.5657039412991752d,bottom: 0.09058626981734696d,left: 0.24357131938518672d),
new NpgsqlTypes.NpgsqlBox(top: 0.7385222304544193d,right: 0.4022863270093813d,bottom: 0.5049825589971301d,left: 0.016482787048914593d),
new NpgsqlTypes.NpgsqlBox(top: 0.7904383692099338d,right: 0.8976282729632938d,bottom: 0.30035874608794344d,left: 0.5484691210564127d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7874280560164199d,right: 0.8366420857822312d,bottom: 0.09070010991226574d,left: 0.6237814557324465d),
new NpgsqlTypes.NpgsqlBox(top: 0.9351637289102733d,right: 0.9395462564330469d,bottom: 0.7668067319976903d,left: 0.7742832493384363d),
new NpgsqlTypes.NpgsqlBox(top: 0.7255468960550645d,right: 0.7315657492249356d,bottom: 0.39850489200551d,left: 0.25720424802930597d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4250355915574622d,right: 0.9294185302149189d,bottom: 0.22145176968795488d,left: 0.7968533554678101d),
new NpgsqlTypes.NpgsqlBox(top: 0.2513505584187333d,right: 0.0778082930741456d,bottom: 0.12529804959525004d,left: 0.033097657643860856d),
new NpgsqlTypes.NpgsqlBox(top: 0.7988362994774499d,right: 0.956292444236465d,bottom: 0.5966018368300567d,left: 0.33599226335414145d),
new NpgsqlTypes.NpgsqlBox(top: 0.3973883361744671d,right: 0.42977881026174847d,bottom: 0.38767946078439464d,left: 0.28114155750112246d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7022642741704651d,right: 0.9838080945541171d,bottom: 0.5444629632018675d,left: 0.43318589873924485d),
new NpgsqlTypes.NpgsqlBox(top: 0.47406645073041076d,right: 0.7980996768975405d,bottom: 0.07363335808155369d,left: 0.5433777248199745d),
new NpgsqlTypes.NpgsqlBox(top: 0.9941193549246515d,right: 0.7886074597400229d,bottom: 0.021236682918932215d,left: 0.7274031926258077d),
new NpgsqlTypes.NpgsqlBox(top: 0.09773877444677859d,right: 0.5540985224196546d,bottom: 0.009493803140669166d,left: 0.13509553914134143d),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1mi(
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1mi(
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
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
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

                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray1mi_id
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxarray1mi_id", 
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
                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray1mi_id
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
    npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6581380028015756d,right: 0.9843117243494136d,bottom: 0.08639273416459858d,left: 0.17577164306839066d),
new NpgsqlTypes.NpgsqlBox(top: 0.8918939093837862d,right: 0.37997062950304195d,bottom: 0.24533446606763498d,left: 0.3576632228097302d),
new NpgsqlTypes.NpgsqlBox(top: 0.47942863429686766d,right: 0.6038051634015184d,bottom: 0.45621215768852486d,left: 0.35861354114240607d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.12526869815556307d,right: 0.12209910320647621d,bottom: 0.06945576774519635d,left: 0.01784702781958325d),
new NpgsqlTypes.NpgsqlBox(top: 0.22912006988015465d,right: 0.8999917612767963d,bottom: 0.07993055314888386d,left: 0.7273275879278774d),
new NpgsqlTypes.NpgsqlBox(top: 0.3436010483383246d,right: 0.256855481665043d,bottom: 0.21023559306071982d,left: 0.04577558286318528d),
new NpgsqlTypes.NpgsqlBox(top: 0.37986647066735535d,right: 0.883062733614056d,bottom: 0.3293967525726583d,left: 0.49552756670221887d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray1mi_id
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
    npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxarray1mi_id", 
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
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6560607118205684d,right: 0.7934229973424048d,bottom: 0.24903288976246285d,left: 0.6878160457774465d),
new NpgsqlTypes.NpgsqlBox(top: 0.3156502820507838d,right: 0.9900980809995621d,bottom: 0.11855847828901378d,left: 0.127069911390441d),
new NpgsqlTypes.NpgsqlBox(top: 0.8146196463773049d,right: 0.8736556091492685d,bottom: 0.7338941135232195d,left: 0.6919025595739592d),
new NpgsqlTypes.NpgsqlBox(top: 0.33638794789235993d,right: 0.9012867322410872d,bottom: 0.025707691978073544d,left: 0.5280967048139209d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.543894955980231d,right: 0.84688401166237d,bottom: 0.35100388401727756d,left: 0.6671050573812518d),
new NpgsqlTypes.NpgsqlBox(top: 0.13056071461833518d,right: 0.8163294286492211d,bottom: 0.09735738417771922d,left: 0.3728599979353098d),
new NpgsqlTypes.NpgsqlBox(top: 0.3706266514362191d,right: 0.4482941182830319d,bottom: 0.3653876457180537d,left: 0.05389717332082d),
}));
                nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxArray1M> models = null;

                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxArray1M> models = null;

                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await ((INpgsqlBoxArrayboxArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await ((INpgsqlBoxArrayboxArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxArrayboxArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 146;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[26],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 82;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 6;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[29], false);
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
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 33;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[24],_testData[29], false);
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
                parametr1.Value = 151;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 69;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[29], false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[9], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 98, query1, 122, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 116, query1, 29, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[25],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 110, query1, 146, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 137, query1, 41, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 118, query1, 115, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 151, query1, 82, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 131, query1, 122, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 137, query1, 57, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[20],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelBatchAsync(connection, 102, 118))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[29], false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelBatch(connection, 50, 137))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[8], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[9], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[29], false);
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
                await using var cmd = await ((INpgsqlBoxArrayboxArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 105);
                var models = await ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(13));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxArrayboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 146);
                var models =  ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(4));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[29], false);
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
FROM public.binary_npgsqlboxboxarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray1MIWA),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxArrayboxArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlBoxboxArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxArrayboxArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxArrayboxArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray1MI),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxArray1MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxArrayboxArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxArrayboxArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlBoxboxArray1MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxArrayboxArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlBoxboxArray1M),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
FROM public.binary_npgsqlboxboxarray1m m
LEFT JOIN public.binary_npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(5)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlBoxboxArray1M>(15);

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
                ((INpgsqlBoxArrayboxArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlBoxArrayboxArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlBoxArrayboxArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlBoxboxArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlBoxboxArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlBoxboxArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxArrayboxArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(6)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxArrayboxArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxArrayboxArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxArrayboxArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

