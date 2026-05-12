

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
    internal partial interface INpgsqlPathSingleTypepath
    {
    }
    
    internal partial class NpgsqlPathSingleTypepath : INpgsqlPathSingleTypepath
    {


#region TestData

        private readonly NpgsqlPathpathE0M[] _testData = new NpgsqlPathpathE0M[]
        {
            new NpgsqlPathpathE0M
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2943063828462218d, y: 0.4223008780842006d), new NpgsqlTypes.NpgsqlPoint(x: 0.7088366958195317d, y: 0.7323588064112471d), new NpgsqlTypes.NpgsqlPoint(x: 0.7116117372205234d, y: 0.16147230522725764d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 10,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3457016545805194d, y: 0.19937290941649377d), new NpgsqlTypes.NpgsqlPoint(x: 0.32252545436885205d, y: 0.58939389611202d), new NpgsqlTypes.NpgsqlPoint(x: 0.056632154195299655d, y: 0.06034161871597343d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 2,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15174491039313232d, y: 0.6941834505708518d), new NpgsqlTypes.NpgsqlPoint(x: 0.6415357142900434d, y: 0.004689622371049307d), new NpgsqlTypes.NpgsqlPoint(x: 0.1660491543096282d, y: 0.5858570446054518d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8840849256756335d, y: 0.09321229329547076d), new NpgsqlTypes.NpgsqlPoint(x: 0.41627581385955814d, y: 0.7338626660922946d), new NpgsqlTypes.NpgsqlPoint(x: 0.32510515368025505d, y: 0.7012034267972733d)),
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5214799928340621d, y: 0.07136445419030557d), new NpgsqlTypes.NpgsqlPoint(x: 0.22646535393786327d, y: 0.8301936804140235d), new NpgsqlTypes.NpgsqlPoint(x: 0.6563313594889905d, y: 0.40702940967200285d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15856284677495447d, y: 0.45473098809026335d), new NpgsqlTypes.NpgsqlPoint(x: 0.9595745488226318d, y: 0.523267640092695d), new NpgsqlTypes.NpgsqlPoint(x: 0.8182319771001502d, y: 0.6430002365162855d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7716306431260003d, y: 0.5334363521072574d), new NpgsqlTypes.NpgsqlPoint(x: 0.07276172381054336d, y: 0.30847643360715804d), new NpgsqlTypes.NpgsqlPoint(x: 0.5972159907148079d, y: 0.15775649152811788d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02298354361302879d, y: 0.573025202606315d), new NpgsqlTypes.NpgsqlPoint(x: 0.17983493964099284d, y: 0.30378938617331663d), new NpgsqlTypes.NpgsqlPoint(x: 0.8262364670288097d, y: 0.26023427661062726d)),
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 20,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6517279885637044d, y: 0.8843828371934522d), new NpgsqlTypes.NpgsqlPoint(x: 0.08249598752889109d, y: 0.43082782099536276d), new NpgsqlTypes.NpgsqlPoint(x: 0.13949302650257622d, y: 0.007154529760535766d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6472178527852397d, y: 0.8811474091420886d), new NpgsqlTypes.NpgsqlPoint(x: 0.48174448225184385d, y: 0.47552334568597365d), new NpgsqlTypes.NpgsqlPoint(x: 0.5339766257756161d, y: 0.8514849723767293d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37829836651513726d, y: 0.6586057021021484d), new NpgsqlTypes.NpgsqlPoint(x: 0.13057003316334514d, y: 0.6441785423617115d), new NpgsqlTypes.NpgsqlPoint(x: 0.20558264867866927d, y: 0.2742084689820138d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8620521142647541d, y: 0.2777539157712603d), new NpgsqlTypes.NpgsqlPoint(x: 0.2297096567166611d, y: 0.6390863407113285d), new NpgsqlTypes.NpgsqlPoint(x: 0.12800707496496067d, y: 0.5949621213915566d)),
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 34,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8530414711200092d, y: 0.23624295011918206d), new NpgsqlTypes.NpgsqlPoint(x: 0.64936655010633d, y: 0.46458789070371664d), new NpgsqlTypes.NpgsqlPoint(x: 0.9239917703499793d, y: 0.4693335824783096d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 36,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8778914191421986d, y: 0.1739117213028013d), new NpgsqlTypes.NpgsqlPoint(x: 0.23384352136028375d, y: 0.452836615830863d), new NpgsqlTypes.NpgsqlPoint(x: 0.8325472218238216d, y: 0.14822681467797572d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6608446756750906d, y: 0.8154391002101401d), new NpgsqlTypes.NpgsqlPoint(x: 0.9321896578670825d, y: 0.7677559006127962d), new NpgsqlTypes.NpgsqlPoint(x: 0.3577526904159707d, y: 0.8344154561916055d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31426095847161395d, y: 0.6780993825656431d), new NpgsqlTypes.NpgsqlPoint(x: 0.6006620452138259d, y: 0.9107861016701815d), new NpgsqlTypes.NpgsqlPoint(x: 0.3490498493898123d, y: 0.29209608001514564d)),
},
            new NpgsqlPathpathE0M
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45437437935344305d, y: 0.3828467947819314d), new NpgsqlTypes.NpgsqlPoint(x: 0.5185040928855102d, y: 0.7774224690437012d), new NpgsqlTypes.NpgsqlPoint(x: 0.1678537404960132d, y: 0.07772939135591372d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3018492897254009d, y: 0.8089150608599789d), new NpgsqlTypes.NpgsqlPoint(x: 0.010719575191412645d, y: 0.8894466304590346d), new NpgsqlTypes.NpgsqlPoint(x: 0.21906885659056963d, y: 0.9251465776238486d)),
},
            new NpgsqlPathpathE0M
{
    Id = 39,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23264730002893153d, y: 0.2917581151004466d), new NpgsqlTypes.NpgsqlPoint(x: 0.9849310990615285d, y: 0.5896153969279777d), new NpgsqlTypes.NpgsqlPoint(x: 0.909933604688714d, y: 0.6335023828800639d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 24,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5537897336487231d, y: 0.2839410322384055d), new NpgsqlTypes.NpgsqlPoint(x: 0.6770458798598427d, y: 0.5226669033985403d), new NpgsqlTypes.NpgsqlPoint(x: 0.13951082704697926d, y: 0.685359171543383d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9546723874779496d, y: 0.3782940843118202d), new NpgsqlTypes.NpgsqlPoint(x: 0.38052491350759843d, y: 0.8864493155541051d), new NpgsqlTypes.NpgsqlPoint(x: 0.5358729097426651d, y: 0.6576633640866234d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43410473623293544d, y: 0.28420967219291704d), new NpgsqlTypes.NpgsqlPoint(x: 0.9304445183908662d, y: 0.8219364980150006d), new NpgsqlTypes.NpgsqlPoint(x: 0.45774578736730576d, y: 0.28951472425531566d)),
},
            new NpgsqlPathpathE0M
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8882654436014283d, y: 0.47485721746347465d), new NpgsqlTypes.NpgsqlPoint(x: 0.20339428194995368d, y: 0.500368975820952d), new NpgsqlTypes.NpgsqlPoint(x: 0.13980803134881636d, y: 0.5503026489555745d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 28,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7145505454652759d, y: 0.0011756154001641983d), new NpgsqlTypes.NpgsqlPoint(x: 0.4329094054312106d, y: 0.10500350385370927d), new NpgsqlTypes.NpgsqlPoint(x: 0.6255739100230066d, y: 0.21640261924639603d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.004304206737611338d, y: 0.3287462496436948d), new NpgsqlTypes.NpgsqlPoint(x: 0.08631705611293394d, y: 0.40011183147212415d), new NpgsqlTypes.NpgsqlPoint(x: 0.6900128107494722d, y: 0.2630908007734504d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17368685917935256d, y: 0.6561637322665089d), new NpgsqlTypes.NpgsqlPoint(x: 0.8980511732448135d, y: 0.8649718919224556d), new NpgsqlTypes.NpgsqlPoint(x: 0.6905999103439184d, y: 0.4252286359914451d)),
},
            new NpgsqlPathpathE0M
{
    Id = 46,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.634909550622163d, y: 0.6249730712526281d), new NpgsqlTypes.NpgsqlPoint(x: 0.12875988389072313d, y: 0.7758029528786727d), new NpgsqlTypes.NpgsqlPoint(x: 0.3437769730157445d, y: 0.21574243607116816d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6421167037674782d, y: 0.695710968520549d), new NpgsqlTypes.NpgsqlPoint(x: 0.2064216067688175d, y: 0.08990068095818338d), new NpgsqlTypes.NpgsqlPoint(x: 0.6274101330312508d, y: 0.09288261567849376d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7134296239339509d, y: 0.9600838793210905d), new NpgsqlTypes.NpgsqlPoint(x: 0.3375230033386123d, y: 0.4638098014667684d), new NpgsqlTypes.NpgsqlPoint(x: 0.7319629833108078d, y: 0.6387732047262011d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.372572656691619d, y: 0.07613886897523581d), new NpgsqlTypes.NpgsqlPoint(x: 0.4503994690171462d, y: 0.5738636411867472d), new NpgsqlTypes.NpgsqlPoint(x: 0.7774684789147546d, y: 0.7402839322847566d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9497981519192854d, y: 0.22496869074683357d), new NpgsqlTypes.NpgsqlPoint(x: 0.6905307474210672d, y: 0.441509273600599d), new NpgsqlTypes.NpgsqlPoint(x: 0.5153872718357374d, y: 0.6536950101323958d)),
},
            new NpgsqlPathpathE0M
{
    Id = 53,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6777373410021967d, y: 0.769492944859957d), new NpgsqlTypes.NpgsqlPoint(x: 0.08265084197172912d, y: 0.9566078932135164d), new NpgsqlTypes.NpgsqlPoint(x: 0.051288310602042086d, y: 0.4462279475833879d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 62,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48485212508379016d, y: 0.45601054051888945d), new NpgsqlTypes.NpgsqlPoint(x: 0.834420780857974d, y: 0.32045715149358045d), new NpgsqlTypes.NpgsqlPoint(x: 0.8437488590888037d, y: 0.06666103070672247d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6526689862814539d, y: 0.004683839949335966d), new NpgsqlTypes.NpgsqlPoint(x: 0.652009991243411d, y: 0.06202932621734081d), new NpgsqlTypes.NpgsqlPoint(x: 0.43932889368962d, y: 0.5723416015311779d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6949350002228084d, y: 0.06196532073888217d), new NpgsqlTypes.NpgsqlPoint(x: 0.4894653807390784d, y: 0.4055591674832235d), new NpgsqlTypes.NpgsqlPoint(x: 0.040233282657409664d, y: 0.12016204833061572d)),
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 71,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3768263476255552d, y: 0.9116376681204605d), new NpgsqlTypes.NpgsqlPoint(x: 0.017373711056493657d, y: 0.7427002629869126d), new NpgsqlTypes.NpgsqlPoint(x: 0.24957484026045884d, y: 0.4165265963692123d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8272779775384684d, y: 0.14754798256517088d), new NpgsqlTypes.NpgsqlPoint(x: 0.3925760559700403d, y: 0.6100218369492432d), new NpgsqlTypes.NpgsqlPoint(x: 0.8549143645943306d, y: 0.6675794990530898d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6019342869692381d, y: 0.11446316478915397d), new NpgsqlTypes.NpgsqlPoint(x: 0.32050147831003417d, y: 0.028844589976679935d), new NpgsqlTypes.NpgsqlPoint(x: 0.7998589903679362d, y: 0.9152196121093112d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2951346077116521d, y: 0.9088111652494422d), new NpgsqlTypes.NpgsqlPoint(x: 0.9828408950558158d, y: 0.002442478973108231d), new NpgsqlTypes.NpgsqlPoint(x: 0.20144291148936033d, y: 0.8963954698162548d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3108642826956265d, y: 0.9430564129820774d), new NpgsqlTypes.NpgsqlPoint(x: 0.17780220561759508d, y: 0.34721720295907443d), new NpgsqlTypes.NpgsqlPoint(x: 0.5371863622943632d, y: 0.06536562109574329d)),
},
            new NpgsqlPathpathE0M
{
    Id = 87,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.520377082606236d, y: 0.052102894872584904d), new NpgsqlTypes.NpgsqlPoint(x: 0.41247303079429887d, y: 0.23877549727432068d), new NpgsqlTypes.NpgsqlPoint(x: 0.7980101103222623d, y: 0.41150528589491886d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 95,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3945012109346686d, y: 0.5163108961637402d), new NpgsqlTypes.NpgsqlPoint(x: 0.43018976511900275d, y: 0.6959403824694594d), new NpgsqlTypes.NpgsqlPoint(x: 0.989006964411689d, y: 0.47224575190159845d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5466728686096647d, y: 0.18167819647000283d), new NpgsqlTypes.NpgsqlPoint(x: 0.17296126273513202d, y: 0.5678443274105621d), new NpgsqlTypes.NpgsqlPoint(x: 0.82824302733162d, y: 0.36322990909695463d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 101,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6289999023169749d, y: 0.03075716802719264d), new NpgsqlTypes.NpgsqlPoint(x: 0.225712336859626d, y: 0.07907410487824285d), new NpgsqlTypes.NpgsqlPoint(x: 0.08177045188231002d, y: 0.08533501262269794d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 108,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4921150148961769d, y: 0.4803115323538598d), new NpgsqlTypes.NpgsqlPoint(x: 0.4632293183710211d, y: 0.3724179365886582d), new NpgsqlTypes.NpgsqlPoint(x: 0.492273651196791d, y: 0.7122274556196553d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 52,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0956197332463753d, y: 0.8427484238057132d), new NpgsqlTypes.NpgsqlPoint(x: 0.9085077801387819d, y: 0.5442677099407394d), new NpgsqlTypes.NpgsqlPoint(x: 0.38184710146900624d, y: 0.22863304819103936d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8677458910679977d, y: 0.41895647684408543d), new NpgsqlTypes.NpgsqlPoint(x: 0.36812078186283625d, y: 0.19860370463014831d), new NpgsqlTypes.NpgsqlPoint(x: 0.35886281043512513d, y: 0.827466684969674d)),
},
            new NpgsqlPathpathE0M
{
    Id = 111,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7450366319609992d, y: 0.2953744456735631d), new NpgsqlTypes.NpgsqlPoint(x: 0.07844098639762387d, y: 0.4338975566025919d), new NpgsqlTypes.NpgsqlPoint(x: 0.8364679680907767d, y: 0.09577599163172024d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20314752427225025d, y: 0.8071654511781318d), new NpgsqlTypes.NpgsqlPoint(x: 0.8158340910663149d, y: 0.5614261536145347d), new NpgsqlTypes.NpgsqlPoint(x: 0.7066553320813339d, y: 0.47770090110651686d)),
},
            new NpgsqlPathpathE0M
{
    Id = 115,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35359425233110553d, y: 0.35865831578235374d), new NpgsqlTypes.NpgsqlPoint(x: 0.5059298040043843d, y: 0.7385154378179704d), new NpgsqlTypes.NpgsqlPoint(x: 0.8217055371907107d, y: 0.8902216716314132d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8701283174755245d, y: 0.9808809801776023d), new NpgsqlTypes.NpgsqlPoint(x: 0.8778259671351123d, y: 0.1719414327579154d), new NpgsqlTypes.NpgsqlPoint(x: 0.9494113953152719d, y: 0.8856221881524697d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7795705472968412d, y: 0.7274818747991801d), new NpgsqlTypes.NpgsqlPoint(x: 0.7076277830511266d, y: 0.686381202151665d), new NpgsqlTypes.NpgsqlPoint(x: 0.33056688332803197d, y: 0.06676369345947109d)),
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 118,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2231349624846204d, y: 0.6217123848485921d), new NpgsqlTypes.NpgsqlPoint(x: 0.24467133410264275d, y: 0.50955237925091d), new NpgsqlTypes.NpgsqlPoint(x: 0.9885783675952804d, y: 0.3757732324379991d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 123,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8229285246136779d, y: 0.765917567765037d), new NpgsqlTypes.NpgsqlPoint(x: 0.45256646742268525d, y: 0.26440170467247914d), new NpgsqlTypes.NpgsqlPoint(x: 0.6715520645577081d, y: 0.9482295288081418d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 67,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5955926301048909d, y: 0.7153023220246724d), new NpgsqlTypes.NpgsqlPoint(x: 0.8074526150922766d, y: 0.4604001323331921d), new NpgsqlTypes.NpgsqlPoint(x: 0.3659847317666819d, y: 0.12628350153272327d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17876389327482467d, y: 0.31308018056709874d), new NpgsqlTypes.NpgsqlPoint(x: 0.8892560455357688d, y: 0.4962587146355044d), new NpgsqlTypes.NpgsqlPoint(x: 0.25450760701538155d, y: 0.65650254456945d)),
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 125,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7713816955722805d, y: 0.5554927612151223d), new NpgsqlTypes.NpgsqlPoint(x: 0.4167563638956727d, y: 0.19522955425654653d), new NpgsqlTypes.NpgsqlPoint(x: 0.9491959133203125d, y: 0.5986817125329889d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 127,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8315493375339887d, y: 0.22434195026879167d), new NpgsqlTypes.NpgsqlPoint(x: 0.2071754671330841d, y: 0.5101312994178253d), new NpgsqlTypes.NpgsqlPoint(x: 0.5105679914981442d, y: 0.2801360288475412d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 75,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.374066785690194d, y: 0.12977908803409532d), new NpgsqlTypes.NpgsqlPoint(x: 0.23836267794462584d, y: 0.652117643219583d), new NpgsqlTypes.NpgsqlPoint(x: 0.4019109697056278d, y: 0.8292932606550463d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9760944496526981d, y: 0.3510819018387984d), new NpgsqlTypes.NpgsqlPoint(x: 0.36247387764893746d, y: 0.8065507152141553d), new NpgsqlTypes.NpgsqlPoint(x: 0.5057645289125312d, y: 0.1589775784511177d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4999581267563671d, y: 0.33200265384396477d), new NpgsqlTypes.NpgsqlPoint(x: 0.18858556403653692d, y: 0.6946418199581172d), new NpgsqlTypes.NpgsqlPoint(x: 0.023332713258172544d, y: 0.989712501352034d)),
},
            new NpgsqlPathpathE0M
{
    Id = 131,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.209649137942982d, y: 0.5376865312937226d), new NpgsqlTypes.NpgsqlPoint(x: 0.29067213398333636d, y: 0.6778448438762479d), new NpgsqlTypes.NpgsqlPoint(x: 0.6856220421740169d, y: 0.7192427911498473d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.031830775965493996d, y: 0.8424283455859332d), new NpgsqlTypes.NpgsqlPoint(x: 0.5926286261230942d, y: 0.5546559616532356d), new NpgsqlTypes.NpgsqlPoint(x: 0.6245084434889222d, y: 0.20984640407044963d)),
},
            new NpgsqlPathpathE0M
{
    Id = 138,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8960362200866638d, y: 0.22333594881197405d), new NpgsqlTypes.NpgsqlPoint(x: 0.6937725778592038d, y: 0.9004262282215962d), new NpgsqlTypes.NpgsqlPoint(x: 0.6303364578414195d, y: 0.36725319690222946d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 84,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4194245582587348d, y: 0.8547638405390008d), new NpgsqlTypes.NpgsqlPoint(x: 0.07813164195264521d, y: 0.03619557048040134d), new NpgsqlTypes.NpgsqlPoint(x: 0.47123783386735296d, y: 0.8964597319128887d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.006727019227837472d, y: 0.08918991120750852d), new NpgsqlTypes.NpgsqlPoint(x: 0.7571765809276793d, y: 0.2738226404797589d), new NpgsqlTypes.NpgsqlPoint(x: 0.17302302344692122d, y: 0.7415579263660768d)),
},
            new NpgsqlPathpathE0M
{
    Id = 145,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5921216854963796d, y: 0.7428479449936273d), new NpgsqlTypes.NpgsqlPoint(x: 0.8959765915822759d, y: 0.8644266410844204d), new NpgsqlTypes.NpgsqlPoint(x: 0.5652262081253172d, y: 0.9067908100344435d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41580105507944853d, y: 0.44304863743471057d), new NpgsqlTypes.NpgsqlPoint(x: 0.003850576096016467d, y: 0.04242493073077491d), new NpgsqlTypes.NpgsqlPoint(x: 0.859041393023175d, y: 0.16779888931785403d)),
},
            new NpgsqlPathpathE0M
{
    Id = 147,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9639084651959174d, y: 0.42743398285833434d), new NpgsqlTypes.NpgsqlPoint(x: 0.5292326225920189d, y: 0.6623899256068609d), new NpgsqlTypes.NpgsqlPoint(x: 0.4715827797023645d, y: 0.9839138490025101d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 87,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3966846594269643d, y: 0.4350111090336962d), new NpgsqlTypes.NpgsqlPoint(x: 0.5066880265269308d, y: 0.047626194184129944d), new NpgsqlTypes.NpgsqlPoint(x: 0.26263746827885825d, y: 0.4725142027047895d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8708968717122658d, y: 0.736472598792899d), new NpgsqlTypes.NpgsqlPoint(x: 0.9833487657852786d, y: 0.44979607276078404d), new NpgsqlTypes.NpgsqlPoint(x: 0.9161495375702551d, y: 0.19029129853007565d)),
},
    NullableValue = null,
},
            new NpgsqlPathpathE0M
{
    Id = 155,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5553014931145612d, y: 0.7243639281733594d), new NpgsqlTypes.NpgsqlPoint(x: 0.43306746177034894d, y: 0.9414840584810329d), new NpgsqlTypes.NpgsqlPoint(x: 0.2908983221781978d, y: 0.08932010761445708d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9677204896085592d, y: 0.5529288651803259d), new NpgsqlTypes.NpgsqlPoint(x: 0.04313043276561346d, y: 0.47719753256932895d), new NpgsqlTypes.NpgsqlPoint(x: 0.34021498993990495d, y: 0.2338842153497711d)),
},
            new NpgsqlPathpathE0M
{
    Id = 160,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6712729111160517d, y: 0.5438574641060463d), new NpgsqlTypes.NpgsqlPoint(x: 0.056805404079879884d, y: 0.9906754300091102d), new NpgsqlTypes.NpgsqlPoint(x: 0.629362654855037d, y: 0.869852472239192d)),
    ModelInner = new NpgsqlPathpathE0MI
{
    Id = 91,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2731926019413986d, y: 0.23569133856317614d), new NpgsqlTypes.NpgsqlPoint(x: 0.5137326087945432d, y: 0.35189682939745515d), new NpgsqlTypes.NpgsqlPoint(x: 0.21870246351953615d, y: 0.1510924849749702d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5101414438578697d, y: 0.35863827507035617d), new NpgsqlTypes.NpgsqlPoint(x: 0.2830330188494077d, y: 0.8494231548623306d), new NpgsqlTypes.NpgsqlPoint(x: 0.7303670466640643d, y: 0.009773614645201767d)),
},
            new NpgsqlPathpathE0M
{
    Id = 165,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34143910153824375d, y: 0.6766310484868702d), new NpgsqlTypes.NpgsqlPoint(x: 0.19565598196736433d, y: 0.9031521204865745d), new NpgsqlTypes.NpgsqlPoint(x: 0.9240725977560821d, y: 0.5112584223982486d)),
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathe0mi(
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathe0mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(14))]
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

                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathe0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    @id,
    @value, 
    @nullablevalue
)
",
            methodName:"DbConnectionInsertInnerModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13), 
                nullable: true)]
        public void DbConnectionInsertInnerModelConfig()
        {
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathe0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathe0mi_id
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpathe0mi_id", 
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
                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathe0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathe0mi_id
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
    npgsqlpathpathe0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                NpgsqlTypes.NpgsqlPath? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlPath? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31426095847161395d, y: 0.6780993825656431d), new NpgsqlTypes.NpgsqlPoint(x: 0.6006620452138259d, y: 0.9107861016701815d), new NpgsqlTypes.NpgsqlPoint(x: 0.3490498493898123d, y: 0.29209608001514564d))));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathe0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathe0mi_id
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
    npgsqlpathpathe0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpathe0mi_id", 
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
                NpgsqlTypes.NpgsqlPath? nullable = null;
                nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3018492897254009d, y: 0.8089150608599789d), new NpgsqlTypes.NpgsqlPoint(x: 0.010719575191412645d, y: 0.8894466304590346d), new NpgsqlTypes.NpgsqlPoint(x: 0.21906885659056963d, y: 0.9251465776238486d))));
                nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath? nullable = null;
                nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43410473623293544d, y: 0.28420967219291704d), new NpgsqlTypes.NpgsqlPoint(x: 0.9304445183908662d, y: 0.8219364980150006d), new NpgsqlTypes.NpgsqlPoint(x: 0.45774578736730576d, y: 0.28951472425531566d))));
                nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17368685917935256d, y: 0.6561637322665089d), new NpgsqlTypes.NpgsqlPoint(x: 0.8980511732448135d, y: 0.8649718919224556d), new NpgsqlTypes.NpgsqlPoint(x: 0.6905999103439184d, y: 0.4252286359914451d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathE0M> models = null;

                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathE0M> models = null;

                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathE0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathe0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathe0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlpathpathe0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlPath), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlpathpathe0mi_id", 
                methodParametrName: "npgsqlpathpathe0mi_id", 
                dbType: (System.Data.DbType)(11),
                nullable: true)]
        public void DbConnectionInsertModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M), typeof(FlatNpgsqlPathpathE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
LEFT JOIN public.npgsqlpathpathe0mi mi ON mi.id = m.npgsqlpathpathe0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await ((INpgsqlPathSingleTypepath)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathSingleTypepath)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M), typeof(FlatNpgsqlPathpathE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
LEFT JOIN public.npgsqlpathpathe0mi mi ON mi.id = m.npgsqlpathpathe0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await ((INpgsqlPathSingleTypepath)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathSingleTypepath)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M), typeof(FlatNpgsqlPathpathE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                await((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[31],_testData[34], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 39;
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[20],_testData[34], false);
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
                parametr1.Value = 101;
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
LEFT JOIN public.npgsqlpathpathe0mi mi ON mi.id = m.npgsqlpathpathe0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[10],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPathpathE0M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPathpathE0M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPathpathE0M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPathpathE0M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPathpathE0M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPathpathE0M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPathpathE0M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[20],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[21],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[22],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[23],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[24],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[25],_testData[34], false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[10],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[11],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[12],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[11], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[12], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[13], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[14], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[15], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[16], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[17], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[18], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[19], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[20], false);
                        NpgsqlPathpathE0M.AssertModel(models[10],_testData[21], false);
                        NpgsqlPathpathE0M.AssertModel(models[11],_testData[22], false);
                        NpgsqlPathpathE0M.AssertModel(models[12],_testData[23], false);
                        NpgsqlPathpathE0M.AssertModel(models[13],_testData[24], false);
                        NpgsqlPathpathE0M.AssertModel(models[14],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[15],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[16],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[17],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[18],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[19],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[20],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[21],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[22],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M), typeof(FlatNpgsqlPathpathE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                await((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 6, query1, 47, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 12, query1, 95, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathE0M>();
                var models2 = new List<FlatNpgsqlPathpathE0M>();
                ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 111, query1, 101, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var firstItems2 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatch(connection, 34, query1, 108, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 42, query1, 39, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[24],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 39, query1, 125, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatch(connection, 123, query1, 101, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPathpathE0M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(models[13],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
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
FROM public.npgsqlpathpathe0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems1 = new List<FlatNpgsqlPathpathE0M>();
                var secondItems2 = new List<FlatNpgsqlPathpathE0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatch(connection, 131, query1, 87, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlPathpathE0M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
LEFT JOIN public.npgsqlpathpathe0mi mi ON mi.id = m.npgsqlpathpathe0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatchAsync(connection, 10, 101))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPathpathE0M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPathpathE0M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPathpathE0M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPathpathE0M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPathpathE0M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPathpathE0M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPathpathE0M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPathpathE0M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPathpathE0M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPathpathE0M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPathpathE0M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPathpathE0M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPathpathE0M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPathpathE0M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[27],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[28],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[29],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[30],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[31],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPathpathE0M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPathpathE0M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPathpathE0M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPathpathE0M.AssertModel(models[8],_testData[29], false);
                        NpgsqlPathpathE0M.AssertModel(models[9],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[10],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[11],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[12],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[13],_testData[34], false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatch(connection, 155, 138))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPathpathE0M.AssertModel(models[0],_testData[30], false);
                        NpgsqlPathpathE0M.AssertModel(models[1],_testData[31], false);
                        NpgsqlPathpathE0M.AssertModel(models[2],_testData[32], false);
                        NpgsqlPathpathE0M.AssertModel(models[3],_testData[33], false);
                        NpgsqlPathpathE0M.AssertModel(models[4],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPathSingleTypepath)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 40);
                var models = await ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(24));

                NpgsqlPathpathE0M.AssertModel(models[0],_testData[11], false);
                NpgsqlPathpathE0M.AssertModel(models[1],_testData[12], false);
                NpgsqlPathpathE0M.AssertModel(models[2],_testData[13], false);
                NpgsqlPathpathE0M.AssertModel(models[3],_testData[14], false);
                NpgsqlPathpathE0M.AssertModel(models[4],_testData[15], false);
                NpgsqlPathpathE0M.AssertModel(models[5],_testData[16], false);
                NpgsqlPathpathE0M.AssertModel(models[6],_testData[17], false);
                NpgsqlPathpathE0M.AssertModel(models[7],_testData[18], false);
                NpgsqlPathpathE0M.AssertModel(models[8],_testData[19], false);
                NpgsqlPathpathE0M.AssertModel(models[9],_testData[20], false);
                NpgsqlPathpathE0M.AssertModel(models[10],_testData[21], false);
                NpgsqlPathpathE0M.AssertModel(models[11],_testData[22], false);
                NpgsqlPathpathE0M.AssertModel(models[12],_testData[23], false);
                NpgsqlPathpathE0M.AssertModel(models[13],_testData[24], false);
                NpgsqlPathpathE0M.AssertModel(models[14],_testData[25], false);
                NpgsqlPathpathE0M.AssertModel(models[15],_testData[26], false);
                NpgsqlPathpathE0M.AssertModel(models[16],_testData[27], false);
                NpgsqlPathpathE0M.AssertModel(models[17],_testData[28], false);
                NpgsqlPathpathE0M.AssertModel(models[18],_testData[29], false);
                NpgsqlPathpathE0M.AssertModel(models[19],_testData[30], false);
                NpgsqlPathpathE0M.AssertModel(models[20],_testData[31], false);
                NpgsqlPathpathE0M.AssertModel(models[21],_testData[32], false);
                NpgsqlPathpathE0M.AssertModel(models[22],_testData[33], false);
                NpgsqlPathpathE0M.AssertModel(models[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathSingleTypepath)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 118);
                var models =  ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(10));

                NpgsqlPathpathE0M.AssertModel(models[0],_testData[25], false);
                NpgsqlPathpathE0M.AssertModel(models[1],_testData[26], false);
                NpgsqlPathpathE0M.AssertModel(models[2],_testData[27], false);
                NpgsqlPathpathE0M.AssertModel(models[3],_testData[28], false);
                NpgsqlPathpathE0M.AssertModel(models[4],_testData[29], false);
                NpgsqlPathpathE0M.AssertModel(models[5],_testData[30], false);
                NpgsqlPathpathE0M.AssertModel(models[6],_testData[31], false);
                NpgsqlPathpathE0M.AssertModel(models[7],_testData[32], false);
                NpgsqlPathpathE0M.AssertModel(models[8],_testData[33], false);
                NpgsqlPathpathE0M.AssertModel(models[9],_testData[34], false);
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
FROM public.npgsqlpathpathe0m m
LEFT JOIN public.npgsqlpathpathe0mi mi ON mi.id = m.npgsqlpathpathe0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelToObjArr",
            queryMapTypes: [typeof(object[])],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2943063828462218d, y: 0.4223008780842006d), new NpgsqlTypes.NpgsqlPoint(x: 0.7088366958195317d, y: 0.7323588064112471d), new NpgsqlTypes.NpgsqlPoint(x: 0.7116117372205234d, y: 0.16147230522725764d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3457016545805194d, y: 0.19937290941649377d), new NpgsqlTypes.NpgsqlPoint(x: 0.32252545436885205d, y: 0.58939389611202d), new NpgsqlTypes.NpgsqlPoint(x: 0.056632154195299655d, y: 0.06034161871597343d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15174491039313232d, y: 0.6941834505708518d), new NpgsqlTypes.NpgsqlPoint(x: 0.6415357142900434d, y: 0.004689622371049307d), new NpgsqlTypes.NpgsqlPoint(x: 0.1660491543096282d, y: 0.5858570446054518d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8840849256756335d, y: 0.09321229329547076d), new NpgsqlTypes.NpgsqlPoint(x: 0.41627581385955814d, y: 0.7338626660922946d), new NpgsqlTypes.NpgsqlPoint(x: 0.32510515368025505d, y: 0.7012034267972733d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5214799928340621d, y: 0.07136445419030557d), new NpgsqlTypes.NpgsqlPoint(x: 0.22646535393786327d, y: 0.8301936804140235d), new NpgsqlTypes.NpgsqlPoint(x: 0.6563313594889905d, y: 0.40702940967200285d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15856284677495447d, y: 0.45473098809026335d), new NpgsqlTypes.NpgsqlPoint(x: 0.9595745488226318d, y: 0.523267640092695d), new NpgsqlTypes.NpgsqlPoint(x: 0.8182319771001502d, y: 0.6430002365162855d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7716306431260003d, y: 0.5334363521072574d), new NpgsqlTypes.NpgsqlPoint(x: 0.07276172381054336d, y: 0.30847643360715804d), new NpgsqlTypes.NpgsqlPoint(x: 0.5972159907148079d, y: 0.15775649152811788d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02298354361302879d, y: 0.573025202606315d), new NpgsqlTypes.NpgsqlPoint(x: 0.17983493964099284d, y: 0.30378938617331663d), new NpgsqlTypes.NpgsqlPoint(x: 0.8262364670288097d, y: 0.26023427661062726d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6517279885637044d, y: 0.8843828371934522d), new NpgsqlTypes.NpgsqlPoint(x: 0.08249598752889109d, y: 0.43082782099536276d), new NpgsqlTypes.NpgsqlPoint(x: 0.13949302650257622d, y: 0.007154529760535766d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6472178527852397d, y: 0.8811474091420886d), new NpgsqlTypes.NpgsqlPoint(x: 0.48174448225184385d, y: 0.47552334568597365d), new NpgsqlTypes.NpgsqlPoint(x: 0.5339766257756161d, y: 0.8514849723767293d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37829836651513726d, y: 0.6586057021021484d), new NpgsqlTypes.NpgsqlPoint(x: 0.13057003316334514d, y: 0.6441785423617115d), new NpgsqlTypes.NpgsqlPoint(x: 0.20558264867866927d, y: 0.2742084689820138d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8620521142647541d, y: 0.2777539157712603d), new NpgsqlTypes.NpgsqlPoint(x: 0.2297096567166611d, y: 0.6390863407113285d), new NpgsqlTypes.NpgsqlPoint(x: 0.12800707496496067d, y: 0.5949621213915566d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8530414711200092d, y: 0.23624295011918206d), new NpgsqlTypes.NpgsqlPoint(x: 0.64936655010633d, y: 0.46458789070371664d), new NpgsqlTypes.NpgsqlPoint(x: 0.9239917703499793d, y: 0.4693335824783096d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8778914191421986d, y: 0.1739117213028013d), new NpgsqlTypes.NpgsqlPoint(x: 0.23384352136028375d, y: 0.452836615830863d), new NpgsqlTypes.NpgsqlPoint(x: 0.8325472218238216d, y: 0.14822681467797572d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6608446756750906d, y: 0.8154391002101401d), new NpgsqlTypes.NpgsqlPoint(x: 0.9321896578670825d, y: 0.7677559006127962d), new NpgsqlTypes.NpgsqlPoint(x: 0.3577526904159707d, y: 0.8344154561916055d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31426095847161395d, y: 0.6780993825656431d), new NpgsqlTypes.NpgsqlPoint(x: 0.6006620452138259d, y: 0.9107861016701815d), new NpgsqlTypes.NpgsqlPoint(x: 0.3490498493898123d, y: 0.29209608001514564d)))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45437437935344305d, y: 0.3828467947819314d), new NpgsqlTypes.NpgsqlPoint(x: 0.5185040928855102d, y: 0.7774224690437012d), new NpgsqlTypes.NpgsqlPoint(x: 0.1678537404960132d, y: 0.07772939135591372d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3018492897254009d, y: 0.8089150608599789d), new NpgsqlTypes.NpgsqlPoint(x: 0.010719575191412645d, y: 0.8894466304590346d), new NpgsqlTypes.NpgsqlPoint(x: 0.21906885659056963d, y: 0.9251465776238486d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23264730002893153d, y: 0.2917581151004466d), new NpgsqlTypes.NpgsqlPoint(x: 0.9849310990615285d, y: 0.5896153969279777d), new NpgsqlTypes.NpgsqlPoint(x: 0.909933604688714d, y: 0.6335023828800639d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5537897336487231d, y: 0.2839410322384055d), new NpgsqlTypes.NpgsqlPoint(x: 0.6770458798598427d, y: 0.5226669033985403d), new NpgsqlTypes.NpgsqlPoint(x: 0.13951082704697926d, y: 0.685359171543383d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9546723874779496d, y: 0.3782940843118202d), new NpgsqlTypes.NpgsqlPoint(x: 0.38052491350759843d, y: 0.8864493155541051d), new NpgsqlTypes.NpgsqlPoint(x: 0.5358729097426651d, y: 0.6576633640866234d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43410473623293544d, y: 0.28420967219291704d), new NpgsqlTypes.NpgsqlPoint(x: 0.9304445183908662d, y: 0.8219364980150006d), new NpgsqlTypes.NpgsqlPoint(x: 0.45774578736730576d, y: 0.28951472425531566d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8882654436014283d, y: 0.47485721746347465d), new NpgsqlTypes.NpgsqlPoint(x: 0.20339428194995368d, y: 0.500368975820952d), new NpgsqlTypes.NpgsqlPoint(x: 0.13980803134881636d, y: 0.5503026489555745d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7145505454652759d, y: 0.0011756154001641983d), new NpgsqlTypes.NpgsqlPoint(x: 0.4329094054312106d, y: 0.10500350385370927d), new NpgsqlTypes.NpgsqlPoint(x: 0.6255739100230066d, y: 0.21640261924639603d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.004304206737611338d, y: 0.3287462496436948d), new NpgsqlTypes.NpgsqlPoint(x: 0.08631705611293394d, y: 0.40011183147212415d), new NpgsqlTypes.NpgsqlPoint(x: 0.6900128107494722d, y: 0.2630908007734504d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17368685917935256d, y: 0.6561637322665089d), new NpgsqlTypes.NpgsqlPoint(x: 0.8980511732448135d, y: 0.8649718919224556d), new NpgsqlTypes.NpgsqlPoint(x: 0.6905999103439184d, y: 0.4252286359914451d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.634909550622163d, y: 0.6249730712526281d), new NpgsqlTypes.NpgsqlPoint(x: 0.12875988389072313d, y: 0.7758029528786727d), new NpgsqlTypes.NpgsqlPoint(x: 0.3437769730157445d, y: 0.21574243607116816d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6421167037674782d, y: 0.695710968520549d), new NpgsqlTypes.NpgsqlPoint(x: 0.2064216067688175d, y: 0.08990068095818338d), new NpgsqlTypes.NpgsqlPoint(x: 0.6274101330312508d, y: 0.09288261567849376d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7134296239339509d, y: 0.9600838793210905d), new NpgsqlTypes.NpgsqlPoint(x: 0.3375230033386123d, y: 0.4638098014667684d), new NpgsqlTypes.NpgsqlPoint(x: 0.7319629833108078d, y: 0.6387732047262011d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.372572656691619d, y: 0.07613886897523581d), new NpgsqlTypes.NpgsqlPoint(x: 0.4503994690171462d, y: 0.5738636411867472d), new NpgsqlTypes.NpgsqlPoint(x: 0.7774684789147546d, y: 0.7402839322847566d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9497981519192854d, y: 0.22496869074683357d), new NpgsqlTypes.NpgsqlPoint(x: 0.6905307474210672d, y: 0.441509273600599d), new NpgsqlTypes.NpgsqlPoint(x: 0.5153872718357374d, y: 0.6536950101323958d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6777373410021967d, y: 0.769492944859957d), new NpgsqlTypes.NpgsqlPoint(x: 0.08265084197172912d, y: 0.9566078932135164d), new NpgsqlTypes.NpgsqlPoint(x: 0.051288310602042086d, y: 0.4462279475833879d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48485212508379016d, y: 0.45601054051888945d), new NpgsqlTypes.NpgsqlPoint(x: 0.834420780857974d, y: 0.32045715149358045d), new NpgsqlTypes.NpgsqlPoint(x: 0.8437488590888037d, y: 0.06666103070672247d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6526689862814539d, y: 0.004683839949335966d), new NpgsqlTypes.NpgsqlPoint(x: 0.652009991243411d, y: 0.06202932621734081d), new NpgsqlTypes.NpgsqlPoint(x: 0.43932889368962d, y: 0.5723416015311779d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6949350002228084d, y: 0.06196532073888217d), new NpgsqlTypes.NpgsqlPoint(x: 0.4894653807390784d, y: 0.4055591674832235d), new NpgsqlTypes.NpgsqlPoint(x: 0.040233282657409664d, y: 0.12016204833061572d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3768263476255552d, y: 0.9116376681204605d), new NpgsqlTypes.NpgsqlPoint(x: 0.017373711056493657d, y: 0.7427002629869126d), new NpgsqlTypes.NpgsqlPoint(x: 0.24957484026045884d, y: 0.4165265963692123d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8272779775384684d, y: 0.14754798256517088d), new NpgsqlTypes.NpgsqlPoint(x: 0.3925760559700403d, y: 0.6100218369492432d), new NpgsqlTypes.NpgsqlPoint(x: 0.8549143645943306d, y: 0.6675794990530898d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6019342869692381d, y: 0.11446316478915397d), new NpgsqlTypes.NpgsqlPoint(x: 0.32050147831003417d, y: 0.028844589976679935d), new NpgsqlTypes.NpgsqlPoint(x: 0.7998589903679362d, y: 0.9152196121093112d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2951346077116521d, y: 0.9088111652494422d), new NpgsqlTypes.NpgsqlPoint(x: 0.9828408950558158d, y: 0.002442478973108231d), new NpgsqlTypes.NpgsqlPoint(x: 0.20144291148936033d, y: 0.8963954698162548d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3108642826956265d, y: 0.9430564129820774d), new NpgsqlTypes.NpgsqlPoint(x: 0.17780220561759508d, y: 0.34721720295907443d), new NpgsqlTypes.NpgsqlPoint(x: 0.5371863622943632d, y: 0.06536562109574329d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.520377082606236d, y: 0.052102894872584904d), new NpgsqlTypes.NpgsqlPoint(x: 0.41247303079429887d, y: 0.23877549727432068d), new NpgsqlTypes.NpgsqlPoint(x: 0.7980101103222623d, y: 0.41150528589491886d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3945012109346686d, y: 0.5163108961637402d), new NpgsqlTypes.NpgsqlPoint(x: 0.43018976511900275d, y: 0.6959403824694594d), new NpgsqlTypes.NpgsqlPoint(x: 0.989006964411689d, y: 0.47224575190159845d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5466728686096647d, y: 0.18167819647000283d), new NpgsqlTypes.NpgsqlPoint(x: 0.17296126273513202d, y: 0.5678443274105621d), new NpgsqlTypes.NpgsqlPoint(x: 0.82824302733162d, y: 0.36322990909695463d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6289999023169749d, y: 0.03075716802719264d), new NpgsqlTypes.NpgsqlPoint(x: 0.225712336859626d, y: 0.07907410487824285d), new NpgsqlTypes.NpgsqlPoint(x: 0.08177045188231002d, y: 0.08533501262269794d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4921150148961769d, y: 0.4803115323538598d), new NpgsqlTypes.NpgsqlPoint(x: 0.4632293183710211d, y: 0.3724179365886582d), new NpgsqlTypes.NpgsqlPoint(x: 0.492273651196791d, y: 0.7122274556196553d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0956197332463753d, y: 0.8427484238057132d), new NpgsqlTypes.NpgsqlPoint(x: 0.9085077801387819d, y: 0.5442677099407394d), new NpgsqlTypes.NpgsqlPoint(x: 0.38184710146900624d, y: 0.22863304819103936d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8677458910679977d, y: 0.41895647684408543d), new NpgsqlTypes.NpgsqlPoint(x: 0.36812078186283625d, y: 0.19860370463014831d), new NpgsqlTypes.NpgsqlPoint(x: 0.35886281043512513d, y: 0.827466684969674d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7450366319609992d, y: 0.2953744456735631d), new NpgsqlTypes.NpgsqlPoint(x: 0.07844098639762387d, y: 0.4338975566025919d), new NpgsqlTypes.NpgsqlPoint(x: 0.8364679680907767d, y: 0.09577599163172024d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20314752427225025d, y: 0.8071654511781318d), new NpgsqlTypes.NpgsqlPoint(x: 0.8158340910663149d, y: 0.5614261536145347d), new NpgsqlTypes.NpgsqlPoint(x: 0.7066553320813339d, y: 0.47770090110651686d)))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35359425233110553d, y: 0.35865831578235374d), new NpgsqlTypes.NpgsqlPoint(x: 0.5059298040043843d, y: 0.7385154378179704d), new NpgsqlTypes.NpgsqlPoint(x: 0.8217055371907107d, y: 0.8902216716314132d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8701283174755245d, y: 0.9808809801776023d), new NpgsqlTypes.NpgsqlPoint(x: 0.8778259671351123d, y: 0.1719414327579154d), new NpgsqlTypes.NpgsqlPoint(x: 0.9494113953152719d, y: 0.8856221881524697d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7795705472968412d, y: 0.7274818747991801d), new NpgsqlTypes.NpgsqlPoint(x: 0.7076277830511266d, y: 0.686381202151665d), new NpgsqlTypes.NpgsqlPoint(x: 0.33056688332803197d, y: 0.06676369345947109d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2231349624846204d, y: 0.6217123848485921d), new NpgsqlTypes.NpgsqlPoint(x: 0.24467133410264275d, y: 0.50955237925091d), new NpgsqlTypes.NpgsqlPoint(x: 0.9885783675952804d, y: 0.3757732324379991d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8229285246136779d, y: 0.765917567765037d), new NpgsqlTypes.NpgsqlPoint(x: 0.45256646742268525d, y: 0.26440170467247914d), new NpgsqlTypes.NpgsqlPoint(x: 0.6715520645577081d, y: 0.9482295288081418d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5955926301048909d, y: 0.7153023220246724d), new NpgsqlTypes.NpgsqlPoint(x: 0.8074526150922766d, y: 0.4604001323331921d), new NpgsqlTypes.NpgsqlPoint(x: 0.3659847317666819d, y: 0.12628350153272327d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17876389327482467d, y: 0.31308018056709874d), new NpgsqlTypes.NpgsqlPoint(x: 0.8892560455357688d, y: 0.4962587146355044d), new NpgsqlTypes.NpgsqlPoint(x: 0.25450760701538155d, y: 0.65650254456945d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7713816955722805d, y: 0.5554927612151223d), new NpgsqlTypes.NpgsqlPoint(x: 0.4167563638956727d, y: 0.19522955425654653d), new NpgsqlTypes.NpgsqlPoint(x: 0.9491959133203125d, y: 0.5986817125329889d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8315493375339887d, y: 0.22434195026879167d), new NpgsqlTypes.NpgsqlPoint(x: 0.2071754671330841d, y: 0.5101312994178253d), new NpgsqlTypes.NpgsqlPoint(x: 0.5105679914981442d, y: 0.2801360288475412d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.374066785690194d, y: 0.12977908803409532d), new NpgsqlTypes.NpgsqlPoint(x: 0.23836267794462584d, y: 0.652117643219583d), new NpgsqlTypes.NpgsqlPoint(x: 0.4019109697056278d, y: 0.8292932606550463d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9760944496526981d, y: 0.3510819018387984d), new NpgsqlTypes.NpgsqlPoint(x: 0.36247387764893746d, y: 0.8065507152141553d), new NpgsqlTypes.NpgsqlPoint(x: 0.5057645289125312d, y: 0.1589775784511177d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4999581267563671d, y: 0.33200265384396477d), new NpgsqlTypes.NpgsqlPoint(x: 0.18858556403653692d, y: 0.6946418199581172d), new NpgsqlTypes.NpgsqlPoint(x: 0.023332713258172544d, y: 0.989712501352034d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.209649137942982d, y: 0.5376865312937226d), new NpgsqlTypes.NpgsqlPoint(x: 0.29067213398333636d, y: 0.6778448438762479d), new NpgsqlTypes.NpgsqlPoint(x: 0.6856220421740169d, y: 0.7192427911498473d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.031830775965493996d, y: 0.8424283455859332d), new NpgsqlTypes.NpgsqlPoint(x: 0.5926286261230942d, y: 0.5546559616532356d), new NpgsqlTypes.NpgsqlPoint(x: 0.6245084434889222d, y: 0.20984640407044963d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8960362200866638d, y: 0.22333594881197405d), new NpgsqlTypes.NpgsqlPoint(x: 0.6937725778592038d, y: 0.9004262282215962d), new NpgsqlTypes.NpgsqlPoint(x: 0.6303364578414195d, y: 0.36725319690222946d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4194245582587348d, y: 0.8547638405390008d), new NpgsqlTypes.NpgsqlPoint(x: 0.07813164195264521d, y: 0.03619557048040134d), new NpgsqlTypes.NpgsqlPoint(x: 0.47123783386735296d, y: 0.8964597319128887d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.006727019227837472d, y: 0.08918991120750852d), new NpgsqlTypes.NpgsqlPoint(x: 0.7571765809276793d, y: 0.2738226404797589d), new NpgsqlTypes.NpgsqlPoint(x: 0.17302302344692122d, y: 0.7415579263660768d)))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5921216854963796d, y: 0.7428479449936273d), new NpgsqlTypes.NpgsqlPoint(x: 0.8959765915822759d, y: 0.8644266410844204d), new NpgsqlTypes.NpgsqlPoint(x: 0.5652262081253172d, y: 0.9067908100344435d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41580105507944853d, y: 0.44304863743471057d), new NpgsqlTypes.NpgsqlPoint(x: 0.003850576096016467d, y: 0.04242493073077491d), new NpgsqlTypes.NpgsqlPoint(x: 0.859041393023175d, y: 0.16779888931785403d)))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9639084651959174d, y: 0.42743398285833434d), new NpgsqlTypes.NpgsqlPoint(x: 0.5292326225920189d, y: 0.6623899256068609d), new NpgsqlTypes.NpgsqlPoint(x: 0.4715827797023645d, y: 0.9839138490025101d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3966846594269643d, y: 0.4350111090336962d), new NpgsqlTypes.NpgsqlPoint(x: 0.5066880265269308d, y: 0.047626194184129944d), new NpgsqlTypes.NpgsqlPoint(x: 0.26263746827885825d, y: 0.4725142027047895d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8708968717122658d, y: 0.736472598792899d), new NpgsqlTypes.NpgsqlPoint(x: 0.9833487657852786d, y: 0.44979607276078404d), new NpgsqlTypes.NpgsqlPoint(x: 0.9161495375702551d, y: 0.19029129853007565d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5553014931145612d, y: 0.7243639281733594d), new NpgsqlTypes.NpgsqlPoint(x: 0.43306746177034894d, y: 0.9414840584810329d), new NpgsqlTypes.NpgsqlPoint(x: 0.2908983221781978d, y: 0.08932010761445708d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9677204896085592d, y: 0.5529288651803259d), new NpgsqlTypes.NpgsqlPoint(x: 0.04313043276561346d, y: 0.47719753256932895d), new NpgsqlTypes.NpgsqlPoint(x: 0.34021498993990495d, y: 0.2338842153497711d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6712729111160517d, y: 0.5438574641060463d), new NpgsqlTypes.NpgsqlPoint(x: 0.056805404079879884d, y: 0.9906754300091102d), new NpgsqlTypes.NpgsqlPoint(x: 0.629362654855037d, y: 0.869852472239192d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2731926019413986d, y: 0.23569133856317614d), new NpgsqlTypes.NpgsqlPoint(x: 0.5137326087945432d, y: 0.35189682939745515d), new NpgsqlTypes.NpgsqlPoint(x: 0.21870246351953615d, y: 0.1510924849749702d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5101414438578697d, y: 0.35863827507035617d), new NpgsqlTypes.NpgsqlPoint(x: 0.2830330188494077d, y: 0.8494231548623306d), new NpgsqlTypes.NpgsqlPoint(x: 0.7303670466640643d, y: 0.009773614645201767d)))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34143910153824375d, y: 0.6766310484868702d), new NpgsqlTypes.NpgsqlPoint(x: 0.19565598196736433d, y: 0.9031521204865745d), new NpgsqlTypes.NpgsqlPoint(x: 0.9240725977560821d, y: 0.5112584223982486d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2943063828462218d, y: 0.4223008780842006d), new NpgsqlTypes.NpgsqlPoint(x: 0.7088366958195317d, y: 0.7323588064112471d), new NpgsqlTypes.NpgsqlPoint(x: 0.7116117372205234d, y: 0.16147230522725764d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3457016545805194d, y: 0.19937290941649377d), new NpgsqlTypes.NpgsqlPoint(x: 0.32252545436885205d, y: 0.58939389611202d), new NpgsqlTypes.NpgsqlPoint(x: 0.056632154195299655d, y: 0.06034161871597343d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((2)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15174491039313232d, y: 0.6941834505708518d), new NpgsqlTypes.NpgsqlPoint(x: 0.6415357142900434d, y: 0.004689622371049307d), new NpgsqlTypes.NpgsqlPoint(x: 0.1660491543096282d, y: 0.5858570446054518d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8840849256756335d, y: 0.09321229329547076d), new NpgsqlTypes.NpgsqlPoint(x: 0.41627581385955814d, y: 0.7338626660922946d), new NpgsqlTypes.NpgsqlPoint(x: 0.32510515368025505d, y: 0.7012034267972733d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5214799928340621d, y: 0.07136445419030557d), new NpgsqlTypes.NpgsqlPoint(x: 0.22646535393786327d, y: 0.8301936804140235d), new NpgsqlTypes.NpgsqlPoint(x: 0.6563313594889905d, y: 0.40702940967200285d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15856284677495447d, y: 0.45473098809026335d), new NpgsqlTypes.NpgsqlPoint(x: 0.9595745488226318d, y: 0.523267640092695d), new NpgsqlTypes.NpgsqlPoint(x: 0.8182319771001502d, y: 0.6430002365162855d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7716306431260003d, y: 0.5334363521072574d), new NpgsqlTypes.NpgsqlPoint(x: 0.07276172381054336d, y: 0.30847643360715804d), new NpgsqlTypes.NpgsqlPoint(x: 0.5972159907148079d, y: 0.15775649152811788d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02298354361302879d, y: 0.573025202606315d), new NpgsqlTypes.NpgsqlPoint(x: 0.17983493964099284d, y: 0.30378938617331663d), new NpgsqlTypes.NpgsqlPoint(x: 0.8262364670288097d, y: 0.26023427661062726d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((20)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6517279885637044d, y: 0.8843828371934522d), new NpgsqlTypes.NpgsqlPoint(x: 0.08249598752889109d, y: 0.43082782099536276d), new NpgsqlTypes.NpgsqlPoint(x: 0.13949302650257622d, y: 0.007154529760535766d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6472178527852397d, y: 0.8811474091420886d), new NpgsqlTypes.NpgsqlPoint(x: 0.48174448225184385d, y: 0.47552334568597365d), new NpgsqlTypes.NpgsqlPoint(x: 0.5339766257756161d, y: 0.8514849723767293d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37829836651513726d, y: 0.6586057021021484d), new NpgsqlTypes.NpgsqlPoint(x: 0.13057003316334514d, y: 0.6441785423617115d), new NpgsqlTypes.NpgsqlPoint(x: 0.20558264867866927d, y: 0.2742084689820138d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8620521142647541d, y: 0.2777539157712603d), new NpgsqlTypes.NpgsqlPoint(x: 0.2297096567166611d, y: 0.6390863407113285d), new NpgsqlTypes.NpgsqlPoint(x: 0.12800707496496067d, y: 0.5949621213915566d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((34)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8530414711200092d, y: 0.23624295011918206d), new NpgsqlTypes.NpgsqlPoint(x: 0.64936655010633d, y: 0.46458789070371664d), new NpgsqlTypes.NpgsqlPoint(x: 0.9239917703499793d, y: 0.4693335824783096d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((36)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8778914191421986d, y: 0.1739117213028013d), new NpgsqlTypes.NpgsqlPoint(x: 0.23384352136028375d, y: 0.452836615830863d), new NpgsqlTypes.NpgsqlPoint(x: 0.8325472218238216d, y: 0.14822681467797572d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((19)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6608446756750906d, y: 0.8154391002101401d), new NpgsqlTypes.NpgsqlPoint(x: 0.9321896578670825d, y: 0.7677559006127962d), new NpgsqlTypes.NpgsqlPoint(x: 0.3577526904159707d, y: 0.8344154561916055d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31426095847161395d, y: 0.6780993825656431d), new NpgsqlTypes.NpgsqlPoint(x: 0.6006620452138259d, y: 0.9107861016701815d), new NpgsqlTypes.NpgsqlPoint(x: 0.3490498493898123d, y: 0.29209608001514564d)))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45437437935344305d, y: 0.3828467947819314d), new NpgsqlTypes.NpgsqlPoint(x: 0.5185040928855102d, y: 0.7774224690437012d), new NpgsqlTypes.NpgsqlPoint(x: 0.1678537404960132d, y: 0.07772939135591372d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3018492897254009d, y: 0.8089150608599789d), new NpgsqlTypes.NpgsqlPoint(x: 0.010719575191412645d, y: 0.8894466304590346d), new NpgsqlTypes.NpgsqlPoint(x: 0.21906885659056963d, y: 0.9251465776238486d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23264730002893153d, y: 0.2917581151004466d), new NpgsqlTypes.NpgsqlPoint(x: 0.9849310990615285d, y: 0.5896153969279777d), new NpgsqlTypes.NpgsqlPoint(x: 0.909933604688714d, y: 0.6335023828800639d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((24)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5537897336487231d, y: 0.2839410322384055d), new NpgsqlTypes.NpgsqlPoint(x: 0.6770458798598427d, y: 0.5226669033985403d), new NpgsqlTypes.NpgsqlPoint(x: 0.13951082704697926d, y: 0.685359171543383d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9546723874779496d, y: 0.3782940843118202d), new NpgsqlTypes.NpgsqlPoint(x: 0.38052491350759843d, y: 0.8864493155541051d), new NpgsqlTypes.NpgsqlPoint(x: 0.5358729097426651d, y: 0.6576633640866234d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43410473623293544d, y: 0.28420967219291704d), new NpgsqlTypes.NpgsqlPoint(x: 0.9304445183908662d, y: 0.8219364980150006d), new NpgsqlTypes.NpgsqlPoint(x: 0.45774578736730576d, y: 0.28951472425531566d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8882654436014283d, y: 0.47485721746347465d), new NpgsqlTypes.NpgsqlPoint(x: 0.20339428194995368d, y: 0.500368975820952d), new NpgsqlTypes.NpgsqlPoint(x: 0.13980803134881636d, y: 0.5503026489555745d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((28)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7145505454652759d, y: 0.0011756154001641983d), new NpgsqlTypes.NpgsqlPoint(x: 0.4329094054312106d, y: 0.10500350385370927d), new NpgsqlTypes.NpgsqlPoint(x: 0.6255739100230066d, y: 0.21640261924639603d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.004304206737611338d, y: 0.3287462496436948d), new NpgsqlTypes.NpgsqlPoint(x: 0.08631705611293394d, y: 0.40011183147212415d), new NpgsqlTypes.NpgsqlPoint(x: 0.6900128107494722d, y: 0.2630908007734504d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17368685917935256d, y: 0.6561637322665089d), new NpgsqlTypes.NpgsqlPoint(x: 0.8980511732448135d, y: 0.8649718919224556d), new NpgsqlTypes.NpgsqlPoint(x: 0.6905999103439184d, y: 0.4252286359914451d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.634909550622163d, y: 0.6249730712526281d), new NpgsqlTypes.NpgsqlPoint(x: 0.12875988389072313d, y: 0.7758029528786727d), new NpgsqlTypes.NpgsqlPoint(x: 0.3437769730157445d, y: 0.21574243607116816d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6421167037674782d, y: 0.695710968520549d), new NpgsqlTypes.NpgsqlPoint(x: 0.2064216067688175d, y: 0.08990068095818338d), new NpgsqlTypes.NpgsqlPoint(x: 0.6274101330312508d, y: 0.09288261567849376d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7134296239339509d, y: 0.9600838793210905d), new NpgsqlTypes.NpgsqlPoint(x: 0.3375230033386123d, y: 0.4638098014667684d), new NpgsqlTypes.NpgsqlPoint(x: 0.7319629833108078d, y: 0.6387732047262011d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.372572656691619d, y: 0.07613886897523581d), new NpgsqlTypes.NpgsqlPoint(x: 0.4503994690171462d, y: 0.5738636411867472d), new NpgsqlTypes.NpgsqlPoint(x: 0.7774684789147546d, y: 0.7402839322847566d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9497981519192854d, y: 0.22496869074683357d), new NpgsqlTypes.NpgsqlPoint(x: 0.6905307474210672d, y: 0.441509273600599d), new NpgsqlTypes.NpgsqlPoint(x: 0.5153872718357374d, y: 0.6536950101323958d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((53)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6777373410021967d, y: 0.769492944859957d), new NpgsqlTypes.NpgsqlPoint(x: 0.08265084197172912d, y: 0.9566078932135164d), new NpgsqlTypes.NpgsqlPoint(x: 0.051288310602042086d, y: 0.4462279475833879d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48485212508379016d, y: 0.45601054051888945d), new NpgsqlTypes.NpgsqlPoint(x: 0.834420780857974d, y: 0.32045715149358045d), new NpgsqlTypes.NpgsqlPoint(x: 0.8437488590888037d, y: 0.06666103070672247d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((40)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6526689862814539d, y: 0.004683839949335966d), new NpgsqlTypes.NpgsqlPoint(x: 0.652009991243411d, y: 0.06202932621734081d), new NpgsqlTypes.NpgsqlPoint(x: 0.43932889368962d, y: 0.5723416015311779d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6949350002228084d, y: 0.06196532073888217d), new NpgsqlTypes.NpgsqlPoint(x: 0.4894653807390784d, y: 0.4055591674832235d), new NpgsqlTypes.NpgsqlPoint(x: 0.040233282657409664d, y: 0.12016204833061572d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3768263476255552d, y: 0.9116376681204605d), new NpgsqlTypes.NpgsqlPoint(x: 0.017373711056493657d, y: 0.7427002629869126d), new NpgsqlTypes.NpgsqlPoint(x: 0.24957484026045884d, y: 0.4165265963692123d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8272779775384684d, y: 0.14754798256517088d), new NpgsqlTypes.NpgsqlPoint(x: 0.3925760559700403d, y: 0.6100218369492432d), new NpgsqlTypes.NpgsqlPoint(x: 0.8549143645943306d, y: 0.6675794990530898d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6019342869692381d, y: 0.11446316478915397d), new NpgsqlTypes.NpgsqlPoint(x: 0.32050147831003417d, y: 0.028844589976679935d), new NpgsqlTypes.NpgsqlPoint(x: 0.7998589903679362d, y: 0.9152196121093112d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2951346077116521d, y: 0.9088111652494422d), new NpgsqlTypes.NpgsqlPoint(x: 0.9828408950558158d, y: 0.002442478973108231d), new NpgsqlTypes.NpgsqlPoint(x: 0.20144291148936033d, y: 0.8963954698162548d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3108642826956265d, y: 0.9430564129820774d), new NpgsqlTypes.NpgsqlPoint(x: 0.17780220561759508d, y: 0.34721720295907443d), new NpgsqlTypes.NpgsqlPoint(x: 0.5371863622943632d, y: 0.06536562109574329d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.520377082606236d, y: 0.052102894872584904d), new NpgsqlTypes.NpgsqlPoint(x: 0.41247303079429887d, y: 0.23877549727432068d), new NpgsqlTypes.NpgsqlPoint(x: 0.7980101103222623d, y: 0.41150528589491886d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((95)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3945012109346686d, y: 0.5163108961637402d), new NpgsqlTypes.NpgsqlPoint(x: 0.43018976511900275d, y: 0.6959403824694594d), new NpgsqlTypes.NpgsqlPoint(x: 0.989006964411689d, y: 0.47224575190159845d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5466728686096647d, y: 0.18167819647000283d), new NpgsqlTypes.NpgsqlPoint(x: 0.17296126273513202d, y: 0.5678443274105621d), new NpgsqlTypes.NpgsqlPoint(x: 0.82824302733162d, y: 0.36322990909695463d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((101)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6289999023169749d, y: 0.03075716802719264d), new NpgsqlTypes.NpgsqlPoint(x: 0.225712336859626d, y: 0.07907410487824285d), new NpgsqlTypes.NpgsqlPoint(x: 0.08177045188231002d, y: 0.08533501262269794d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4921150148961769d, y: 0.4803115323538598d), new NpgsqlTypes.NpgsqlPoint(x: 0.4632293183710211d, y: 0.3724179365886582d), new NpgsqlTypes.NpgsqlPoint(x: 0.492273651196791d, y: 0.7122274556196553d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0956197332463753d, y: 0.8427484238057132d), new NpgsqlTypes.NpgsqlPoint(x: 0.9085077801387819d, y: 0.5442677099407394d), new NpgsqlTypes.NpgsqlPoint(x: 0.38184710146900624d, y: 0.22863304819103936d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8677458910679977d, y: 0.41895647684408543d), new NpgsqlTypes.NpgsqlPoint(x: 0.36812078186283625d, y: 0.19860370463014831d), new NpgsqlTypes.NpgsqlPoint(x: 0.35886281043512513d, y: 0.827466684969674d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7450366319609992d, y: 0.2953744456735631d), new NpgsqlTypes.NpgsqlPoint(x: 0.07844098639762387d, y: 0.4338975566025919d), new NpgsqlTypes.NpgsqlPoint(x: 0.8364679680907767d, y: 0.09577599163172024d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20314752427225025d, y: 0.8071654511781318d), new NpgsqlTypes.NpgsqlPoint(x: 0.8158340910663149d, y: 0.5614261536145347d), new NpgsqlTypes.NpgsqlPoint(x: 0.7066553320813339d, y: 0.47770090110651686d)))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35359425233110553d, y: 0.35865831578235374d), new NpgsqlTypes.NpgsqlPoint(x: 0.5059298040043843d, y: 0.7385154378179704d), new NpgsqlTypes.NpgsqlPoint(x: 0.8217055371907107d, y: 0.8902216716314132d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8701283174755245d, y: 0.9808809801776023d), new NpgsqlTypes.NpgsqlPoint(x: 0.8778259671351123d, y: 0.1719414327579154d), new NpgsqlTypes.NpgsqlPoint(x: 0.9494113953152719d, y: 0.8856221881524697d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7795705472968412d, y: 0.7274818747991801d), new NpgsqlTypes.NpgsqlPoint(x: 0.7076277830511266d, y: 0.686381202151665d), new NpgsqlTypes.NpgsqlPoint(x: 0.33056688332803197d, y: 0.06676369345947109d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((118)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2231349624846204d, y: 0.6217123848485921d), new NpgsqlTypes.NpgsqlPoint(x: 0.24467133410264275d, y: 0.50955237925091d), new NpgsqlTypes.NpgsqlPoint(x: 0.9885783675952804d, y: 0.3757732324379991d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8229285246136779d, y: 0.765917567765037d), new NpgsqlTypes.NpgsqlPoint(x: 0.45256646742268525d, y: 0.26440170467247914d), new NpgsqlTypes.NpgsqlPoint(x: 0.6715520645577081d, y: 0.9482295288081418d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5955926301048909d, y: 0.7153023220246724d), new NpgsqlTypes.NpgsqlPoint(x: 0.8074526150922766d, y: 0.4604001323331921d), new NpgsqlTypes.NpgsqlPoint(x: 0.3659847317666819d, y: 0.12628350153272327d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17876389327482467d, y: 0.31308018056709874d), new NpgsqlTypes.NpgsqlPoint(x: 0.8892560455357688d, y: 0.4962587146355044d), new NpgsqlTypes.NpgsqlPoint(x: 0.25450760701538155d, y: 0.65650254456945d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7713816955722805d, y: 0.5554927612151223d), new NpgsqlTypes.NpgsqlPoint(x: 0.4167563638956727d, y: 0.19522955425654653d), new NpgsqlTypes.NpgsqlPoint(x: 0.9491959133203125d, y: 0.5986817125329889d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((127)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8315493375339887d, y: 0.22434195026879167d), new NpgsqlTypes.NpgsqlPoint(x: 0.2071754671330841d, y: 0.5101312994178253d), new NpgsqlTypes.NpgsqlPoint(x: 0.5105679914981442d, y: 0.2801360288475412d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((75)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.374066785690194d, y: 0.12977908803409532d), new NpgsqlTypes.NpgsqlPoint(x: 0.23836267794462584d, y: 0.652117643219583d), new NpgsqlTypes.NpgsqlPoint(x: 0.4019109697056278d, y: 0.8292932606550463d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9760944496526981d, y: 0.3510819018387984d), new NpgsqlTypes.NpgsqlPoint(x: 0.36247387764893746d, y: 0.8065507152141553d), new NpgsqlTypes.NpgsqlPoint(x: 0.5057645289125312d, y: 0.1589775784511177d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4999581267563671d, y: 0.33200265384396477d), new NpgsqlTypes.NpgsqlPoint(x: 0.18858556403653692d, y: 0.6946418199581172d), new NpgsqlTypes.NpgsqlPoint(x: 0.023332713258172544d, y: 0.989712501352034d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.209649137942982d, y: 0.5376865312937226d), new NpgsqlTypes.NpgsqlPoint(x: 0.29067213398333636d, y: 0.6778448438762479d), new NpgsqlTypes.NpgsqlPoint(x: 0.6856220421740169d, y: 0.7192427911498473d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.031830775965493996d, y: 0.8424283455859332d), new NpgsqlTypes.NpgsqlPoint(x: 0.5926286261230942d, y: 0.5546559616532356d), new NpgsqlTypes.NpgsqlPoint(x: 0.6245084434889222d, y: 0.20984640407044963d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8960362200866638d, y: 0.22333594881197405d), new NpgsqlTypes.NpgsqlPoint(x: 0.6937725778592038d, y: 0.9004262282215962d), new NpgsqlTypes.NpgsqlPoint(x: 0.6303364578414195d, y: 0.36725319690222946d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4194245582587348d, y: 0.8547638405390008d), new NpgsqlTypes.NpgsqlPoint(x: 0.07813164195264521d, y: 0.03619557048040134d), new NpgsqlTypes.NpgsqlPoint(x: 0.47123783386735296d, y: 0.8964597319128887d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.006727019227837472d, y: 0.08918991120750852d), new NpgsqlTypes.NpgsqlPoint(x: 0.7571765809276793d, y: 0.2738226404797589d), new NpgsqlTypes.NpgsqlPoint(x: 0.17302302344692122d, y: 0.7415579263660768d)))));

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((145)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5921216854963796d, y: 0.7428479449936273d), new NpgsqlTypes.NpgsqlPoint(x: 0.8959765915822759d, y: 0.8644266410844204d), new NpgsqlTypes.NpgsqlPoint(x: 0.5652262081253172d, y: 0.9067908100344435d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41580105507944853d, y: 0.44304863743471057d), new NpgsqlTypes.NpgsqlPoint(x: 0.003850576096016467d, y: 0.04242493073077491d), new NpgsqlTypes.NpgsqlPoint(x: 0.859041393023175d, y: 0.16779888931785403d)))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((147)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9639084651959174d, y: 0.42743398285833434d), new NpgsqlTypes.NpgsqlPoint(x: 0.5292326225920189d, y: 0.6623899256068609d), new NpgsqlTypes.NpgsqlPoint(x: 0.4715827797023645d, y: 0.9839138490025101d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3966846594269643d, y: 0.4350111090336962d), new NpgsqlTypes.NpgsqlPoint(x: 0.5066880265269308d, y: 0.047626194184129944d), new NpgsqlTypes.NpgsqlPoint(x: 0.26263746827885825d, y: 0.4725142027047895d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8708968717122658d, y: 0.736472598792899d), new NpgsqlTypes.NpgsqlPoint(x: 0.9833487657852786d, y: 0.44979607276078404d), new NpgsqlTypes.NpgsqlPoint(x: 0.9161495375702551d, y: 0.19029129853007565d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5553014931145612d, y: 0.7243639281733594d), new NpgsqlTypes.NpgsqlPoint(x: 0.43306746177034894d, y: 0.9414840584810329d), new NpgsqlTypes.NpgsqlPoint(x: 0.2908983221781978d, y: 0.08932010761445708d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9677204896085592d, y: 0.5529288651803259d), new NpgsqlTypes.NpgsqlPoint(x: 0.04313043276561346d, y: 0.47719753256932895d), new NpgsqlTypes.NpgsqlPoint(x: 0.34021498993990495d, y: 0.2338842153497711d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((160)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6712729111160517d, y: 0.5438574641060463d), new NpgsqlTypes.NpgsqlPoint(x: 0.056805404079879884d, y: 0.9906754300091102d), new NpgsqlTypes.NpgsqlPoint(x: 0.629362654855037d, y: 0.869852472239192d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((91)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2731926019413986d, y: 0.23569133856317614d), new NpgsqlTypes.NpgsqlPoint(x: 0.5137326087945432d, y: 0.35189682939745515d), new NpgsqlTypes.NpgsqlPoint(x: 0.21870246351953615d, y: 0.1510924849749702d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5101414438578697d, y: 0.35863827507035617d), new NpgsqlTypes.NpgsqlPoint(x: 0.2830330188494077d, y: 0.8494231548623306d), new NpgsqlTypes.NpgsqlPoint(x: 0.7303670466640643d, y: 0.009773614645201767d)))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34143910153824375d, y: 0.6766310484868702d), new NpgsqlTypes.NpgsqlPoint(x: 0.19565598196736433d, y: 0.9031521204865745d), new NpgsqlTypes.NpgsqlPoint(x: 0.9240725977560821d, y: 0.5112584223982486d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

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
FROM public.binary_npgsqlpathpathe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathE0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathE0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathSingleTypepath)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathSingleTypepath)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathE0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathSingleTypepath)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathSingleTypepath)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathE0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathSingleTypepath)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathE0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathSingleTypepath)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathe0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathE0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathE0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathSingleTypepath)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathSingleTypepath)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathE0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathSingleTypepath)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathe0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathe0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathE0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathSingleTypepath)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathSingleTypepath)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathE0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathSingleTypepath)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathe0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpathe0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathE0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
FROM public.binary_npgsqlpathpathe0m m
LEFT JOIN public.binary_npgsqlpathpathe0mi mi ON mi.id = m.npgsqlpathpathe0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathE0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathSingleTypepath)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathSingleTypepath)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathE0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathE0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathSingleTypepath)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathe0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpathe0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models =  ((INpgsqlPathSingleTypepath)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathSingleTypepath)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA), typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models1 = new List<NpgsqlPathpathE0MIWA>();
                var models2 = new List<NpgsqlPathpathE0MIWA>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathE0MIWA>();
                var models2 = new List<NpgsqlPathpathE0MIWA>();
                ((INpgsqlPathSingleTypepath)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models = await ((INpgsqlPathSingleTypepath)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathe0mi
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
                    NpgsqlPathpathE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathe0mi
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
                    NpgsqlPathpathE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA), typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models1 = new List<NpgsqlPathpathE0MIWA>();
                var models2 = new List<NpgsqlPathpathE0MIWA>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathE0MIWA>();
                var models2 = new List<NpgsqlPathpathE0MIWA>();
                ((INpgsqlPathSingleTypepath)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathe0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models = await ((INpgsqlPathSingleTypepath)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathe0mi
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
                    NpgsqlPathpathE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathe0mi
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
                    NpgsqlPathpathE0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathe0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MI), typeof(NpgsqlPathpathE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models1 = new List<NpgsqlPathpathE0MI>();
                var models2 = new List<NpgsqlPathpathE0MI>();
                await ((INpgsqlPathSingleTypepath)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathE0MI>();
                var models2 = new List<NpgsqlPathpathE0MI>();
                ((INpgsqlPathSingleTypepath)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathe0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
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
                var models = await ((INpgsqlPathSingleTypepath)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathSingleTypepath)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathE0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathe0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA), typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models1 = new List<NpgsqlPathpathE0MIWA>();
                var models2 = new List<NpgsqlPathpathE0MIWA>();
                await ((INpgsqlPathSingleTypepath)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathE0MIWA>();
                var models2 = new List<NpgsqlPathpathE0MIWA>();
                ((INpgsqlPathSingleTypepath)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathe0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
                var models = await ((INpgsqlPathSingleTypepath)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathSingleTypepath)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

