

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
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.46657228508247717d,right: 0.9096992162326469d,bottom: 0.13464445428691452d,left: 0.4624865815499115d),

new NpgsqlTypes.NpgsqlBox(top: 0.9485854215830691d,right: 0.7641338563904522d,bottom: 0.4087399420540244d,left: 0.6348253216987819d),

new NpgsqlTypes.NpgsqlBox(top: 0.7893573478463077d,right: 0.7015747869018881d,bottom: 0.1943197465857025d,left: 0.4243955856712204d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9193387949559741d,right: 0.9006457551058785d,bottom: 0.7292900939843162d,left: 0.8358576111139093d),

new NpgsqlTypes.NpgsqlBox(top: 0.7430652464448381d,right: 0.649356624571484d,bottom: 0.3158965971036567d,left: 0.24337052473066434d),

new NpgsqlTypes.NpgsqlBox(top: 0.7514337856404736d,right: 0.8113155975763937d,bottom: 0.6350182813299066d,left: 0.8111587040527712d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7419528844120009d,right: 0.6364432150895859d,bottom: 0.19788363002467568d,left: 0.5699135557754695d),

new NpgsqlTypes.NpgsqlBox(top: 0.8966718903604186d,right: 0.43759491293161046d,bottom: 0.10321855817851344d,left: 0.20095147033925964d),

new NpgsqlTypes.NpgsqlBox(top: 0.6016208971673896d,right: 0.7276289438415703d,bottom: 0.5854152505944218d,left: 0.13067849310171253d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9547545996296147d,right: 0.6825799846895915d,bottom: 0.44189090170387246d,left: 0.39705735146109855d),

new NpgsqlTypes.NpgsqlBox(top: 0.83475418565d,right: 0.9911835979943757d,bottom: 0.28757198593677835d,left: 0.019740820341494825d),

new NpgsqlTypes.NpgsqlBox(top: 0.3444998189752472d,right: 0.9805295637265056d,bottom: 0.2364559813952587d,left: 0.09742147750009988d),

new NpgsqlTypes.NpgsqlBox(top: 0.7736751151027125d,right: 0.8202471977803829d,bottom: 0.2816975848432841d,left: 0.011773450369922611d),

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
new NpgsqlTypes.NpgsqlBox(top: 0.9249267298376147d,right: 0.9742749238907887d,bottom: 0.49899505903442687d,left: 0.033018787696395435d),

new NpgsqlTypes.NpgsqlBox(top: 0.9894729150889852d,right: 0.5562753931463358d,bottom: 0.7803661756938006d,left: 0.29539369715967767d),

new NpgsqlTypes.NpgsqlBox(top: 0.6426804035766945d,right: 0.16848764420384588d,bottom: 0.20730827802830099d,left: 0.12952913242595065d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3512747672087969d,right: 0.6566276168828663d,bottom: 0.219118116396673d,left: 0.02857970891232109d),

new NpgsqlTypes.NpgsqlBox(top: 0.8176431482592028d,right: 0.9590775463601509d,bottom: 0.4361474221253707d,left: 0.09748787568226569d),

new NpgsqlTypes.NpgsqlBox(top: 0.18846503876315635d,right: 0.439927962591789d,bottom: 0.13478315553547993d,left: 0.2106023376958075d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9927271300727151d,right: 0.0989445294422645d,bottom: 0.15708697286010243d,left: 0.05020246847783283d),

new NpgsqlTypes.NpgsqlBox(top: 0.15263112282213587d,right: 0.42993439419385515d,bottom: 0.07963725351363637d,left: 0.12906702632670053d),

new NpgsqlTypes.NpgsqlBox(top: 0.7154410138188837d,right: 0.9267728662116436d,bottom: 0.33221320668184173d,left: 0.7489821281119428d),

new NpgsqlTypes.NpgsqlBox(top: 0.3089423515254801d,right: 0.47831251419713294d,bottom: 0.26099842559474384d,left: 0.4595781610129326d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7139653587711962d,right: 0.1887422937217338d,bottom: 0.33683325992799085d,left: 0.12621937357673085d),

new NpgsqlTypes.NpgsqlBox(top: 0.8584266902687622d,right: 0.22418591059078874d,bottom: 0.07460892976363076d,left: 0.026244873111884948d),

new NpgsqlTypes.NpgsqlBox(top: 0.8923565464186464d,right: 0.840998250611374d,bottom: 0.22992369062202955d,left: 0.4646058586730648d),

new NpgsqlTypes.NpgsqlBox(top: 0.8696970441309719d,right: 0.8363198036707375d,bottom: 0.4226108492631113d,left: 0.6037339905645209d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8675558323422197d,right: 0.7023564554512316d,bottom: 0.7395796613811423d,left: 0.6713241287351085d),

new NpgsqlTypes.NpgsqlBox(top: 0.9055372370918137d,right: 0.9790734123496775d,bottom: 0.7603786569566547d,left: 0.5077982626619746d),

new NpgsqlTypes.NpgsqlBox(top: 0.649219743152947d,right: 0.7359762524693351d,bottom: 0.5064521664592726d,left: 0.3771758466320678d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5126959299403372d,right: 0.7714210309991139d,bottom: 0.43649340668449665d,left: 0.3095412389620381d),

new NpgsqlTypes.NpgsqlBox(top: 0.8929788754690726d,right: 0.10579028403157609d,bottom: 0.8076504512596033d,left: 0.10487667813403745d),

new NpgsqlTypes.NpgsqlBox(top: 0.7968072467103795d,right: 0.23358589554663767d,bottom: 0.5444122926560316d,left: 0.02530920254338298d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9296305230889551d,right: 0.8492635512842894d,bottom: 0.5546958690787626d,left: 0.4781832817334992d),

new NpgsqlTypes.NpgsqlBox(top: 0.660423521905685d,right: 0.7672940951379567d,bottom: 0.5612884677875345d,left: 0.5605631658436159d),

new NpgsqlTypes.NpgsqlBox(top: 0.8601929956822428d,right: 0.8794949288122993d,bottom: 0.3313233564373165d,left: 0.0055824524433608635d),

new NpgsqlTypes.NpgsqlBox(top: 0.8120901408477605d,right: 0.46450980833759603d,bottom: 0.4525922232319175d,left: 0.2852451372701158d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3943826766366524d,right: 0.8295587605717737d,bottom: 0.15423475226980443d,left: 0.1670341989114068d),

new NpgsqlTypes.NpgsqlBox(top: 0.5301487498816072d,right: 0.6878013149561815d,bottom: 0.348640774749821d,left: 0.2503122837564241d),

new NpgsqlTypes.NpgsqlBox(top: 0.7380390810891375d,right: 0.7995555365257772d,bottom: 0.3158827909637757d,left: 0.472126666328865d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8899116583855661d,right: 0.3676023253180478d,bottom: 0.15682630923037266d,left: 0.33900884168959877d),

new NpgsqlTypes.NpgsqlBox(top: 0.9828921270634244d,right: 0.6955018547657843d,bottom: 0.682176193706382d,left: 0.3063155004546946d),

new NpgsqlTypes.NpgsqlBox(top: 0.2723016430682441d,right: 0.957056203620141d,bottom: 0.10426446427992697d,left: 0.05750968650088717d),

new NpgsqlTypes.NpgsqlBox(top: 0.9357367143107901d,right: 0.20629180729740215d,bottom: 0.43692922931686673d,left: 0.17241623500796588d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5599747654622589d,right: 0.48935459436636275d,bottom: 0.38737156397602734d,left: 0.23553059711547053d),

new NpgsqlTypes.NpgsqlBox(top: 0.90065624709075d,right: 0.49271382739372527d,bottom: 0.04845995961835192d,left: 0.3169094843549899d),

new NpgsqlTypes.NpgsqlBox(top: 0.6551360447792486d,right: 0.8501675206583686d,bottom: 0.16844089719370836d,left: 0.5175966159511037d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4113917235360979d,right: 0.6367154093147732d,bottom: 0.34970458202184695d,left: 0.39088390285706387d),

new NpgsqlTypes.NpgsqlBox(top: 0.9959218203552285d,right: 0.8898704145055791d,bottom: 0.23866717799278236d,left: 0.3351337251570685d),

new NpgsqlTypes.NpgsqlBox(top: 0.8173045789369646d,right: 0.27485882350392354d,bottom: 0.22286312880487436d,left: 0.2625521274557845d),

new NpgsqlTypes.NpgsqlBox(top: 0.4534929096058591d,right: 0.644156680028036d,bottom: 0.18384489529428338d,left: 0.1817016330628286d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7945350792425933d,right: 0.9216213912716212d,bottom: 0.729260680730668d,left: 0.5894776938211562d),

new NpgsqlTypes.NpgsqlBox(top: 0.2873764976788068d,right: 0.7241666455345661d,bottom: 0.10678898282856142d,left: 0.29870130308729215d),

new NpgsqlTypes.NpgsqlBox(top: 0.9689082943466708d,right: 0.6106198355197642d,bottom: 0.1556973473147989d,left: 0.17544582777252116d),

new NpgsqlTypes.NpgsqlBox(top: 0.8074917443758072d,right: 0.8839361962999067d,bottom: 0.1581657266737715d,left: 0.6665670844616519d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8954778317825237d,right: 0.8875399214021282d,bottom: 0.7579224116894046d,left: 0.10230707330540512d),

new NpgsqlTypes.NpgsqlBox(top: 0.7224766280293726d,right: 0.2861911291988266d,bottom: 0.5910006305853729d,left: 0.05919112975785279d),

new NpgsqlTypes.NpgsqlBox(top: 0.3810178687544038d,right: 0.9950153777895433d,bottom: 0.19104751244090667d,left: 0.44117848633577206d),

new NpgsqlTypes.NpgsqlBox(top: 0.9089247408413696d,right: 0.6247679448872818d,bottom: 0.37923316939289076d,left: 0.4024756890104284d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3607535318603331d,right: 0.4804308975228232d,bottom: 0.12324793600221529d,left: 0.01692215933318597d),

new NpgsqlTypes.NpgsqlBox(top: 0.8097957635233757d,right: 0.714222497827889d,bottom: 0.4330467372969343d,left: 0.26746158895259864d),

new NpgsqlTypes.NpgsqlBox(top: 0.17698783820958408d,right: 0.750535970815225d,bottom: 0.04236120650263819d,left: 0.38567197062535763d),

new NpgsqlTypes.NpgsqlBox(top: 0.894345348089752d,right: 0.4989388578685101d,bottom: 0.26059399156871654d,left: 0.09045942342148772d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.95279795249021d,right: 0.7854953876475589d,bottom: 0.9323434706703166d,left: 0.17030870219196692d),

new NpgsqlTypes.NpgsqlBox(top: 0.8240984660261087d,right: 0.5415564605503101d,bottom: 0.48647482313805446d,left: 0.4119310487900285d),

new NpgsqlTypes.NpgsqlBox(top: 0.19387192979756362d,right: 0.6934406024133866d,bottom: 0.1494884483811335d,left: 0.21073784032162834d),

new NpgsqlTypes.NpgsqlBox(top: 0.9402292876208298d,right: 0.10294401210470716d,bottom: 0.4060718849552082d,left: 0.04294025129894763d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7780239446229483d,right: 0.5490360120113248d,bottom: 0.46715628677997445d,left: 0.5421377584496536d),

new NpgsqlTypes.NpgsqlBox(top: 0.9287600203676311d,right: 0.6910357653195369d,bottom: 0.5590761493594691d,left: 0.6865886754043581d),

new NpgsqlTypes.NpgsqlBox(top: 0.4856621678086456d,right: 0.7946049374369177d,bottom: 0.28584394945852054d,left: 0.7862907488652162d),

new NpgsqlTypes.NpgsqlBox(top: 0.29441153387786d,right: 0.9823889774099959d,bottom: 0.22742758904024551d,left: 0.03653528475641954d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.459576616247678d,right: 0.5208601364675362d,bottom: 0.24506132829279492d,left: 0.3183066921837323d),

new NpgsqlTypes.NpgsqlBox(top: 0.8015692859344776d,right: 0.9849379022723231d,bottom: 0.4008381196253763d,left: 0.8981104050665589d),

new NpgsqlTypes.NpgsqlBox(top: 0.6228297737188341d,right: 0.6817660212037785d,bottom: 0.08679784567639914d,left: 0.5421562379238404d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9152421545064399d,right: 0.689007763119416d,bottom: 0.2630737756428453d,left: 0.22195905795399795d),

new NpgsqlTypes.NpgsqlBox(top: 0.7291363171072037d,right: 0.776845634829363d,bottom: 0.297763882717313d,left: 0.6419504120998141d),

new NpgsqlTypes.NpgsqlBox(top: 0.934345300728735d,right: 0.3333227372720585d,bottom: 0.7711420384682346d,left: 0.050121815952754445d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8889156390105485d,right: 0.4688437175243174d,bottom: 0.5997632044958492d,left: 0.04173961254563596d),

new NpgsqlTypes.NpgsqlBox(top: 0.5826588512668789d,right: 0.22887168353808973d,bottom: 0.15779833932060972d,left: 0.10561241485327744d),

new NpgsqlTypes.NpgsqlBox(top: 0.5433940303526534d,right: 0.791139496331795d,bottom: 0.40401086673469633d,left: 0.5788976823159782d),

new NpgsqlTypes.NpgsqlBox(top: 0.9969522043958133d,right: 0.7348100735292734d,bottom: 0.5051563234555141d,left: 0.6224176699924022d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.869382622261793d,right: 0.6312384709166204d,bottom: 0.774679921167081d,left: 0.059757189572346325d),

new NpgsqlTypes.NpgsqlBox(top: 0.5900133043607582d,right: 0.7588533431221248d,bottom: 0.25005117709547897d,left: 0.37259424860167634d),

new NpgsqlTypes.NpgsqlBox(top: 0.9492887848196898d,right: 0.9903587505642679d,bottom: 0.6184231873317175d,left: 0.7177696554460767d),

new NpgsqlTypes.NpgsqlBox(top: 0.5422691186001007d,right: 0.7701648182664741d,bottom: 0.2305131958525003d,left: 0.172701560413985d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8748058923387184d,right: 0.6037538050504496d,bottom: 0.7221888441143712d,left: 0.1841268261996255d),

new NpgsqlTypes.NpgsqlBox(top: 0.8313678559576855d,right: 0.3452609205798727d,bottom: 0.08111894194449165d,left: 0.06918565041641811d),

new NpgsqlTypes.NpgsqlBox(top: 0.8387365476326106d,right: 0.779816658704352d,bottom: 0.7286119460252646d,left: 0.49344174384638406d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.2939426040194041d,right: 0.8353264656339978d,bottom: 0.23691532055933184d,left: 0.5738173283525315d),

new NpgsqlTypes.NpgsqlBox(top: 0.25789643650208016d,right: 0.8283572859904204d,bottom: 0.11804563918203381d,left: 0.11794251025902913d),

new NpgsqlTypes.NpgsqlBox(top: 0.7901492794152253d,right: 0.730416788523474d,bottom: 0.529347381428178d,left: 0.026233517118339877d),

new NpgsqlTypes.NpgsqlBox(top: 0.22156414510451772d,right: 0.721558641798216d,bottom: 0.11851715389655626d,left: 0.4350319062149607d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8644151966438485d,right: 0.6075848618463714d,bottom: 0.38874330239993204d,left: 0.5776552202390145d),

new NpgsqlTypes.NpgsqlBox(top: 0.7100459460339767d,right: 0.8232429601999903d,bottom: 0.5102668291984761d,left: 0.04542451829193095d),

new NpgsqlTypes.NpgsqlBox(top: 0.6977776181112015d,right: 0.9959905657139668d,bottom: 0.5537592901809725d,left: 0.7418809505015541d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6040619996627417d,right: 0.5673118756568282d,bottom: 0.36907760425075464d,left: 0.23824860161758188d),

new NpgsqlTypes.NpgsqlBox(top: 0.5370765376053366d,right: 0.15391533537246194d,bottom: 0.3555086122469585d,left: 0.07321187282958741d),

new NpgsqlTypes.NpgsqlBox(top: 0.8852714294061776d,right: 0.6759846403741738d,bottom: 0.29768565217365217d,left: 0.4881713039662562d),

new NpgsqlTypes.NpgsqlBox(top: 0.936568486000579d,right: 0.9075447351399127d,bottom: 0.8469349054258398d,left: 0.07201506221602061d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8372566630511564d,right: 0.8592943183619777d,bottom: 0.0966671720861525d,left: 0.6698188221621642d),

new NpgsqlTypes.NpgsqlBox(top: 0.31819275592369023d,right: 0.944176163800475d,bottom: 0.12288450883635527d,left: 0.4386975930774992d),

new NpgsqlTypes.NpgsqlBox(top: 0.9892374380332003d,right: 0.6773047957111078d,bottom: 0.3930361677489653d,left: 0.4226659810925336d),

new NpgsqlTypes.NpgsqlBox(top: 0.6099726604335967d,right: 0.5706057788179829d,bottom: 0.25052345327092296d,left: 0.3082353676982449d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8632186166538892d,right: 0.9285512653323967d,bottom: 0.05908982948575092d,left: 0.575872708921763d),

new NpgsqlTypes.NpgsqlBox(top: 0.7626775940351544d,right: 0.6236097279485665d,bottom: 0.42975585506934677d,left: 0.14836773324346852d),

new NpgsqlTypes.NpgsqlBox(top: 0.9844227709534631d,right: 0.2552107584890665d,bottom: 0.9220916990390204d,left: 0.08322561945101192d),

new NpgsqlTypes.NpgsqlBox(top: 0.7661148336878179d,right: 0.6830453864552488d,bottom: 0.34373121460550415d,left: 0.355147362293167d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7989165203936847d,right: 0.24445249307005512d,bottom: 0.08254182281458533d,left: 0.04871368537301324d),

new NpgsqlTypes.NpgsqlBox(top: 0.8767945499588276d,right: 0.729028292258558d,bottom: 0.4857678876414885d,left: 0.11444554218357761d),

new NpgsqlTypes.NpgsqlBox(top: 0.999990096272575d,right: 0.3942470286666938d,bottom: 0.8937668586284746d,left: 0.303370282693053d),

new NpgsqlTypes.NpgsqlBox(top: 0.9928229590582732d,right: 0.23726917307605522d,bottom: 0.03531624721899873d,left: 0.06639796982739277d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6294034872635063d,right: 0.6608948691241385d,bottom: 0.13984532977658748d,left: 0.13658364017414015d),

new NpgsqlTypes.NpgsqlBox(top: 0.36994449288367404d,right: 0.7937934098632925d,bottom: 0.3475128510707781d,left: 0.5188145632037481d),

new NpgsqlTypes.NpgsqlBox(top: 0.3087857235363365d,right: 0.9406516854132007d,bottom: 0.2045290808618051d,left: 0.03814573391726739d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.33287468223040795d,right: 0.46496451411576445d,bottom: 0.1256556737104596d,left: 0.14944614447535487d),

new NpgsqlTypes.NpgsqlBox(top: 0.9049514315192136d,right: 0.6880609133605166d,bottom: 0.1336428730604876d,left: 0.09218264003038279d),

new NpgsqlTypes.NpgsqlBox(top: 0.5196513171135331d,right: 0.8119895851165957d,bottom: 0.159713037595146d,left: 0.46528674035768647d),

new NpgsqlTypes.NpgsqlBox(top: 0.5241676152578695d,right: 0.29607306401543376d,bottom: 0.35667874487309903d,left: 0.07272393856250425d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7367275638905458d,right: 0.7708678783555907d,bottom: 0.43994503418196296d,left: 0.33565902008316484d),

new NpgsqlTypes.NpgsqlBox(top: 0.32579045860427536d,right: 0.7615127011236308d,bottom: 0.2435266571039728d,left: 0.21091946523784078d),

new NpgsqlTypes.NpgsqlBox(top: 0.5901249197726954d,right: 0.7579619309988814d,bottom: 0.3517144141554369d,left: 0.5774376778561601d),

new NpgsqlTypes.NpgsqlBox(top: 0.9400381247975875d,right: 0.9690890934940598d,bottom: 0.20538146183518446d,left: 0.21827596943942196d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3390840919226026d,right: 0.4726536657949052d,bottom: 0.16777331086105707d,left: 0.009320789949839092d),

new NpgsqlTypes.NpgsqlBox(top: 0.9935943752983558d,right: 0.12329780171623528d,bottom: 0.48788665302809986d,left: 0.05469058951751393d),

new NpgsqlTypes.NpgsqlBox(top: 0.5959162975320489d,right: 0.8726759156034576d,bottom: 0.29568918882748874d,left: 0.04113932278881982d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7013967610770389d,right: 0.6426157175256468d,bottom: 0.488782343666299d,left: 0.043824425931706434d),

new NpgsqlTypes.NpgsqlBox(top: 0.4614097295876164d,right: 0.5450415035964907d,bottom: 0.2181411602963651d,left: 0.057186171767668825d),

new NpgsqlTypes.NpgsqlBox(top: 0.47733379609415194d,right: 0.65208034758644d,bottom: 0.2405190773570708d,left: 0.166742484789003d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8406782383647676d,right: 0.36163010654730565d,bottom: 0.5394009415211106d,left: 0.11136703592973685d),

new NpgsqlTypes.NpgsqlBox(top: 0.2954479446995566d,right: 0.4657253710338165d,bottom: 0.19202567147427507d,left: 0.06586216009873813d),

new NpgsqlTypes.NpgsqlBox(top: 0.3563258638279354d,right: 0.7311540503667799d,bottom: 0.30127776359737235d,left: 0.32345996182688375d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9143779939940749d,right: 0.42011942217848863d,bottom: 0.852003973535226d,left: 0.05715174478329843d),

new NpgsqlTypes.NpgsqlBox(top: 0.5895142562435018d,right: 0.8455744425287475d,bottom: 0.10944137588123015d,left: 0.5480354607153443d),

new NpgsqlTypes.NpgsqlBox(top: 0.5176196005788095d,right: 0.8162790473662143d,bottom: 0.4817785781650116d,left: 0.6097546306920992d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6049376991028589d,right: 0.7101424564266547d,bottom: 0.38258602237448724d,left: 0.5773901060620041d),

new NpgsqlTypes.NpgsqlBox(top: 0.6563350707598959d,right: 0.7880742793964741d,bottom: 0.6358398911707281d,left: 0.327081028970294d),

new NpgsqlTypes.NpgsqlBox(top: 0.5101209005100956d,right: 0.08868917750446126d,bottom: 0.4509393723177031d,left: 0.04641398285035714d),

new NpgsqlTypes.NpgsqlBox(top: 0.729747260569829d,right: 0.7098134321889945d,bottom: 0.3149945135375144d,left: 0.6716097885345091d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9314187278414171d,right: 0.8255491862562574d,bottom: 0.9148070057434144d,left: 0.0460482152382784d),

new NpgsqlTypes.NpgsqlBox(top: 0.9649694810872147d,right: 0.7481976278294564d,bottom: 0.6342622617709782d,left: 0.2966063334987663d),

new NpgsqlTypes.NpgsqlBox(top: 0.694165530956716d,right: 0.5920882670743824d,bottom: 0.25113632758975213d,left: 0.023727391523448493d),

new NpgsqlTypes.NpgsqlBox(top: 0.4219770201105115d,right: 0.47830045761235507d,bottom: 0.23404556858826986d,left: 0.30209021828518345d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 109,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6388116686338026d,right: 0.5926486478442075d,bottom: 0.22450151822615705d,left: 0.3002537615343517d),

new NpgsqlTypes.NpgsqlBox(top: 0.24582207753381602d,right: 0.5294437204269812d,bottom: 0.02172986765633167d,left: 0.03670916659556689d),

new NpgsqlTypes.NpgsqlBox(top: 0.7229811999704261d,right: 0.7708229867405855d,bottom: 0.02618358536262999d,left: 0.20330160384511542d),

new NpgsqlTypes.NpgsqlBox(top: 0.7449819547732531d,right: 0.17898393764411136d,bottom: 0.05518129443161235d,left: 0.16864168801616575d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6858906832233055d,right: 0.7462748964083098d,bottom: 0.19344124534587226d,left: 0.7389409976259946d),

new NpgsqlTypes.NpgsqlBox(top: 0.8127356810354134d,right: 0.5945659181325115d,bottom: 0.3840955289204605d,left: 0.2814780038677116d),

new NpgsqlTypes.NpgsqlBox(top: 0.7622908926021582d,right: 0.7547800551378718d,bottom: 0.1925129258923256d,left: 0.527192216468614d),

new NpgsqlTypes.NpgsqlBox(top: 0.522711567842846d,right: 0.9869646478444443d,bottom: 0.32511238317430324d,left: 0.6590596014715306d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7983034967517413d,right: 0.8030768432268081d,bottom: 0.05194911219630216d,left: 0.6006802313789487d),

new NpgsqlTypes.NpgsqlBox(top: 0.8917450783123573d,right: 0.8340772392852916d,bottom: 0.5490779390114249d,left: 0.36020025990381654d),

new NpgsqlTypes.NpgsqlBox(top: 0.9986828472119723d,right: 0.9735605651175735d,bottom: 0.26848226908926964d,left: 0.8840710070967365d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6588440936790747d,right: 0.9300948032414438d,bottom: 0.19350160379043213d,left: 0.4975086365580488d),

new NpgsqlTypes.NpgsqlBox(top: 0.3997669469329148d,right: 0.5082526670646499d,bottom: 0.1431463325608625d,left: 0.4013291562630409d),

new NpgsqlTypes.NpgsqlBox(top: 0.08586207265347556d,right: 0.6347364164171171d,bottom: 0.0028327170704739446d,left: 0.5296659751635293d),

new NpgsqlTypes.NpgsqlBox(top: 0.8926412745462529d,right: 0.9620356613613057d,bottom: 0.5820510786682874d,left: 0.8022788514257008d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5666439369588285d,right: 0.8757001344628671d,bottom: 0.030908223890722564d,left: 0.18516216460188262d),

new NpgsqlTypes.NpgsqlBox(top: 0.7634333363227519d,right: 0.6030520440945044d,bottom: 0.46184706261434205d,left: 0.1480725363350195d),

new NpgsqlTypes.NpgsqlBox(top: 0.42835284771944404d,right: 0.8050499872058146d,bottom: 0.050812383550001616d,left: 0.24550413048469344d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8631718014588452d,right: 0.9469352105213729d,bottom: 0.8307826105125539d,left: 0.034064865180984616d),

new NpgsqlTypes.NpgsqlBox(top: 0.6297931665111032d,right: 0.9884254249599823d,bottom: 0.28209060627176585d,left: 0.8622427834231001d),

new NpgsqlTypes.NpgsqlBox(top: 0.934838985954085d,right: 0.32739154089479816d,bottom: 0.3693689104150327d,left: 0.2544026591009416d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3853237780273858d,right: 0.46634247719872146d,bottom: 0.08211778604412656d,left: 0.3244262023031269d),

new NpgsqlTypes.NpgsqlBox(top: 0.9237030440810818d,right: 0.8470429104875757d,bottom: 0.25916961489201873d,left: 0.5127869179669103d),

new NpgsqlTypes.NpgsqlBox(top: 0.7318725990597084d,right: 0.9170689190984075d,bottom: 0.6862350137131267d,left: 0.1084906170290666d),

new NpgsqlTypes.NpgsqlBox(top: 0.5222634227225076d,right: 0.5984520982888696d,bottom: 0.3546104166692876d,left: 0.06755856084244549d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 121,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.2900738783881762d,right: 0.9991242596973915d,bottom: 0.016210177121918523d,left: 0.10055156177890379d),

new NpgsqlTypes.NpgsqlBox(top: 0.8145265822397942d,right: 0.9439492377462382d,bottom: 0.7731149094025194d,left: 0.3895269728744998d),

new NpgsqlTypes.NpgsqlBox(top: 0.7340159096491972d,right: 0.6054434640224903d,bottom: 0.11335635081098816d,left: 0.09653298792195864d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4589855913733788d,right: 0.13380344267012456d,bottom: 0.27045480880635997d,left: 0.016615563761359753d),

new NpgsqlTypes.NpgsqlBox(top: 0.985413414230927d,right: 0.6758788685837425d,bottom: 0.6766160640188791d,left: 0.24035024985162878d),

new NpgsqlTypes.NpgsqlBox(top: 0.7503849155190655d,right: 0.7342077582898332d,bottom: 0.34152149181321234d,left: 0.14029612008633863d),

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
new NpgsqlTypes.NpgsqlBox(top: 0.5924086557485583d,right: 0.9659199916171204d,bottom: 0.19536084760409245d,left: 0.44383590058940037d),

new NpgsqlTypes.NpgsqlBox(top: 0.7947148117950231d,right: 0.7301053938644965d,bottom: 0.2986444864005351d,left: 0.012785587725698822d),

new NpgsqlTypes.NpgsqlBox(top: 0.28126226976182667d,right: 0.8618801556852231d,bottom: 0.0600654680477547d,left: 0.07008425216227421d),

new NpgsqlTypes.NpgsqlBox(top: 0.7249277162222229d,right: 0.6404239264221503d,bottom: 0.6025563497543207d,left: 0.524263658859785d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.39902751611720466d,right: 0.6843852312764325d,bottom: 0.12235027872496596d,left: 0.0901220980006795d),

new NpgsqlTypes.NpgsqlBox(top: 0.8016077397920736d,right: 0.790813211439413d,bottom: 0.6727874298421685d,left: 0.18012100922714536d),

new NpgsqlTypes.NpgsqlBox(top: 0.5998181943312028d,right: 0.9053816346039941d,bottom: 0.4796243240229249d,left: 0.6499598128972194d),

new NpgsqlTypes.NpgsqlBox(top: 0.7330329158922323d,right: 0.29545832066292477d,bottom: 0.6070708763666148d,left: 0.2932987071416674d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.37866136518238946d,right: 0.619059029688305d,bottom: 0.3148575105710161d,left: 0.27027455648826315d),

new NpgsqlTypes.NpgsqlBox(top: 0.6929635177588085d,right: 0.9492050721729497d,bottom: 0.6009041593410216d,left: 0.33099426890067896d),

new NpgsqlTypes.NpgsqlBox(top: 0.896579521978527d,right: 0.32181434657986496d,bottom: 0.6603977079302684d,left: 0.00966669599600245d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3936545291986122d,right: 0.9903662716795102d,bottom: 0.07150450024817401d,left: 0.5690149250545554d),

new NpgsqlTypes.NpgsqlBox(top: 0.4905624518035505d,right: 0.6191010388253121d,bottom: 0.18536071551484656d,left: 0.47369543752985543d),

new NpgsqlTypes.NpgsqlBox(top: 0.6956414924442987d,right: 0.6100294031301138d,bottom: 0.057553324555240426d,left: 0.32472837762581075d),

new NpgsqlTypes.NpgsqlBox(top: 0.09446248978170746d,right: 0.9651452174983852d,bottom: 0.006180837967393771d,left: 0.038786191927024705d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8543626967164644d,right: 0.4157209974861711d,bottom: 0.08731624842208541d,left: 0.0937832176723975d),

new NpgsqlTypes.NpgsqlBox(top: 0.43765063321882314d,right: 0.7925693801149577d,bottom: 0.1702392696742031d,left: 0.6639596829183853d),

new NpgsqlTypes.NpgsqlBox(top: 0.4770942731563098d,right: 0.42372182727689456d,bottom: 0.1049612833597402d,left: 0.2257568364917888d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5765080057862089d,right: 0.842601754186337d,bottom: 0.3619536582153582d,left: 0.3805771118639639d),

new NpgsqlTypes.NpgsqlBox(top: 0.257382012819794d,right: 0.7232249214492826d,bottom: 0.20553606822534354d,left: 0.6057899663673855d),

new NpgsqlTypes.NpgsqlBox(top: 0.7622500768289053d,right: 0.7751999135416022d,bottom: 0.4937910196659575d,left: 0.6256755941838537d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7366081972243097d,right: 0.2420450167102317d,bottom: 0.5302597382097612d,left: 0.09424258905463834d),

new NpgsqlTypes.NpgsqlBox(top: 0.9807859303365414d,right: 0.6089807622459147d,bottom: 0.804494377842778d,left: 0.4829736477568941d),

new NpgsqlTypes.NpgsqlBox(top: 0.48605185922380356d,right: 0.5577006604622365d,bottom: 0.27664871624357645d,left: 0.1471063069040477d),

new NpgsqlTypes.NpgsqlBox(top: 0.6335424252139165d,right: 0.10935047877200854d,bottom: 0.37255285901256985d,left: 0.04959172108341603d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9677793570200063d,right: 0.5636982237027095d,bottom: 0.6757581056358207d,left: 0.36625077334254597d),

new NpgsqlTypes.NpgsqlBox(top: 0.9448035782675421d,right: 0.5666221284091024d,bottom: 0.6419781055744348d,left: 0.5569100567576851d),

new NpgsqlTypes.NpgsqlBox(top: 0.223347464549297d,right: 0.9128115568961578d,bottom: 0.015087027260942687d,left: 0.7834717473483812d),

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
new NpgsqlTypes.NpgsqlBox(top: 0.8446698031372813d,right: 0.3187550320310596d,bottom: 0.22736302894773053d,left: 0.015510397013510091d),

new NpgsqlTypes.NpgsqlBox(top: 0.8481977833133594d,right: 0.9669733465435331d,bottom: 0.5001205652443639d,left: 0.37330981395264107d),

new NpgsqlTypes.NpgsqlBox(top: 0.7140602321771912d,right: 0.7946933211294125d,bottom: 0.7073123338770935d,left: 0.3601470099667927d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7017321490188766d,right: 0.545847292821952d,bottom: 0.5133469815495483d,left: 0.13976597857586237d),

new NpgsqlTypes.NpgsqlBox(top: 0.8547537831751486d,right: 0.5425454753284825d,bottom: 0.2997229691318284d,left: 0.3906232619517582d),

new NpgsqlTypes.NpgsqlBox(top: 0.5546156048677685d,right: 0.8315531946837946d,bottom: 0.3653806159361722d,left: 0.5693165401938765d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7642296294766905d,right: 0.36405101522251293d,bottom: 0.5193482916335082d,left: 0.30793386553359614d),

new NpgsqlTypes.NpgsqlBox(top: 0.981925226610452d,right: 0.517190555646347d,bottom: 0.5462033157701301d,left: 0.2116740055621651d),

new NpgsqlTypes.NpgsqlBox(top: 0.8801029067103986d,right: 0.747839598953247d,bottom: 0.6759231856972898d,left: 0.2710567453727819d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7593665902837917d,right: 0.6245165753118225d,bottom: 0.4845438850412265d,left: 0.48189045727016566d),

new NpgsqlTypes.NpgsqlBox(top: 0.9545310814317137d,right: 0.25934558372061145d,bottom: 0.9141301360061519d,left: 0.08267060490915812d),

new NpgsqlTypes.NpgsqlBox(top: 0.9841278026369251d,right: 0.7944561437272327d,bottom: 0.40044062438247763d,left: 0.39992708293369417d),

new NpgsqlTypes.NpgsqlBox(top: 0.893241887321367d,right: 0.1578247202426465d,bottom: 0.7167319955104823d,left: 0.03913786876468339d),

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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
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
                        Assert.That(models, Has.Count.EqualTo(27));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[3], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[4], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[5], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[6], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[7], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[8], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[9], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[10], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[11], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[12], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[13], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[14], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[15], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[16], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[17], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[18], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[19], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[20], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[21], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[22], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[23], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[24], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[25], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[26], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[24],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[25],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[19], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[20], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[21], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[22], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[23], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[24], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[25], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[26], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[29], false);
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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 35;
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
                        Assert.That(models, Has.Count.EqualTo(27));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[3], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[4], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[5], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[6], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[7], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[8], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[9], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[10], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[11], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[12], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[13], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[14], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[15], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[16], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[17], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[18], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[19], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[20], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[21], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[22], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[23], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[24], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[25], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[26], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[24],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[25],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[7], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[8], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[9], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[10], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[11], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[12], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[13], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[14], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[15], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[16], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[17], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[18], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[19], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[20], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[21], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[22], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[23], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[24], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[25], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[26], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[29], false);
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 34;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                        Assert.That(models, Has.Count.EqualTo(24));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[6], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[7], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[8], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[9], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[10], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[11], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[12], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[13], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[14], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[29], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[6], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[7], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[8], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[9], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[10], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[11], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[12], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[13], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[14], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[29], false);
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
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 142, query1, 109, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[20], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[21], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[22], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[23], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[24], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[25], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[26], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[29], false);
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
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 44, query1, 102, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[8], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[9], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[10], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[11], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[12], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[13], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[14], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[15], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[16], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[17], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[18], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[19], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[20], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[21], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[22], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[23], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[24], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[25], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[26], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[19], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[20], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[21], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[22], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[23], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[24], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[25], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[26], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[29], false);
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
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSelectModelBatchAsync(connection, 34, 49))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[6], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[7], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[8], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[9], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[10], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[11], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[12], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[13], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[14], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[9], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[10], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[11], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[12], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[13], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[14], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[29], false);
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
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSelectModelBatch(connection, 92, 34))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[6], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[7], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[8], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[9], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[10], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[11], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[12], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[13], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[14], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[29], false);
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
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 35);
                var models = await ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[7], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[8], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[9], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[10], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[11], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[12], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[13], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[14], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxListboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 97);
                var models =  ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(12));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[29], false);
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

