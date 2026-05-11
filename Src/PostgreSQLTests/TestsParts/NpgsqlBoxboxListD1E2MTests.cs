

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
    internal partial interface INpgsqlBoxListboxListD1
    {
    }
    
    internal partial class NpgsqlBoxListboxListD1 : INpgsqlBoxListboxListD1
    {


#region TestData

        private readonly NpgsqlBoxboxListD1E2M[] _testData = new NpgsqlBoxboxListD1E2M[]
        {
            new NpgsqlBoxboxListD1E2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6470704591501888d,right: 0.8388143680599209d,bottom: 0.032234311170123875d,left: 0.6834124680821954d),

new NpgsqlTypes.NpgsqlBox(top: 0.45215284977793047d,right: 0.6899662264666943d,bottom: 0.41537178200212244d,left: 0.2983454395986753d),

new NpgsqlTypes.NpgsqlBox(top: 0.8872671343223753d,right: 0.7542718084533184d,bottom: 0.3355215038549184d,left: 0.047449934824897455d),

new NpgsqlTypes.NpgsqlBox(top: 0.6916723427126957d,right: 0.5193209719847223d,bottom: 0.09252190756755108d,left: 0.22617007217429652d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9254105563425283d,right: 0.9193805945766246d,bottom: 0.7178920343037218d,left: 0.824071196749989d),

new NpgsqlTypes.NpgsqlBox(top: 0.9766583227541681d,right: 0.7019362223879972d,bottom: 0.4976590026429638d,left: 0.4127628910225408d),

new NpgsqlTypes.NpgsqlBox(top: 0.7736641401313932d,right: 0.933636927039062d,bottom: 0.027305399158402688d,left: 0.11666963748111925d),

new NpgsqlTypes.NpgsqlBox(top: 0.9483453639795018d,right: 0.7189607639592335d,bottom: 0.3700599734756457d,left: 0.34611989220797246d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8382689335802593d,right: 0.30939605169901596d,bottom: 0.21165258971255718d,left: 0.1878530111684663d),

new NpgsqlTypes.NpgsqlBox(top: 0.5663107956128983d,right: 0.8484690185097105d,bottom: 0.5290137304895492d,left: 0.8005411145191271d),

new NpgsqlTypes.NpgsqlBox(top: 0.7263676488491841d,right: 0.9566299086990533d,bottom: 0.09908434260569465d,left: 0.03662904089163155d),

new NpgsqlTypes.NpgsqlBox(top: 0.6519589028380866d,right: 0.6327521396384417d,bottom: 0.20008813124032876d,left: 0.4444373112634856d),

},
    ModelInner = new NpgsqlBoxboxListD12MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6807599548764427d,right: 0.8253326742771031d,bottom: 0.6284612784189971d,left: 0.8072154081460591d),

new NpgsqlTypes.NpgsqlBox(top: 0.5668879807438498d,right: 0.7185839214457619d,bottom: 0.3735455333506764d,left: 0.2839658233959651d),

new NpgsqlTypes.NpgsqlBox(top: 0.798429370494125d,right: 0.9426237056552903d,bottom: 0.17765592117985562d,left: 0.3041550211537155d),

new NpgsqlTypes.NpgsqlBox(top: 0.3588969132810763d,right: 0.29819899238752845d,bottom: 0.28394354584832115d,left: 0.22148013786548815d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.32807853024206357d,right: 0.39698533196246455d,bottom: 0.3018773373205641d,left: 0.19395883081934162d),

new NpgsqlTypes.NpgsqlBox(top: 0.6150606931651724d,right: 0.2622989291758481d,bottom: 0.3143871866107847d,left: 0.04655530310437617d),

new NpgsqlTypes.NpgsqlBox(top: 0.21687840753518195d,right: 0.959187916523752d,bottom: 0.1961708245561029d,left: 0.6027980548814188d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.32083136524368105d,right: 0.6384510744693265d,bottom: 0.29256247696078375d,left: 0.42222386039371473d),

new NpgsqlTypes.NpgsqlBox(top: 0.539946909638261d,right: 0.32235222861458424d,bottom: 0.5054904836647326d,left: 0.09024768399985028d),

new NpgsqlTypes.NpgsqlBox(top: 0.6010984738904702d,right: 0.7358276791204674d,bottom: 0.1033611254591772d,left: 0.15558743262485075d),

new NpgsqlTypes.NpgsqlBox(top: 0.5004574572377278d,right: 0.8390703732357285d,bottom: 0.4878237530749302d,left: 0.40245111508752174d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5152436616762108d,right: 0.5782587085378245d,bottom: 0.17721165639814707d,left: 0.4268739952308759d),

new NpgsqlTypes.NpgsqlBox(top: 0.9230465882039254d,right: 0.9186053462086544d,bottom: 0.4173654195673243d,left: 0.6283214492313646d),

new NpgsqlTypes.NpgsqlBox(top: 0.5733713561905703d,right: 0.5683336053334628d,bottom: 0.3821738454849114d,left: 0.3039822770314591d),

new NpgsqlTypes.NpgsqlBox(top: 0.7322274115265343d,right: 0.9148399281573505d,bottom: 0.28936833612085655d,left: 0.589363051879635d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6390048651199973d,right: 0.7856062384276697d,bottom: 0.5574345885455245d,left: 0.3264597655109758d),

new NpgsqlTypes.NpgsqlBox(top: 0.7018723883566529d,right: 0.4033493636494707d,bottom: 0.15924573830688882d,left: 0.2630484348175114d),

new NpgsqlTypes.NpgsqlBox(top: 0.7786843643344935d,right: 0.7725243292390808d,bottom: 0.3609389427288089d,left: 0.12401064233205861d),

new NpgsqlTypes.NpgsqlBox(top: 0.6309742759722075d,right: 0.46534201788383056d,bottom: 0.23090138021563067d,left: 0.38215337429151275d),

},
    ModelInner = new NpgsqlBoxboxListD12MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8323926281558061d,right: 0.15219230009771945d,bottom: 0.05375942771205d,left: 0.14445957545452726d),

new NpgsqlTypes.NpgsqlBox(top: 0.8194955902417502d,right: 0.5075070698591294d,bottom: 0.4127385659483801d,left: 0.414304424874558d),

new NpgsqlTypes.NpgsqlBox(top: 0.7265022536486445d,right: 0.8145265770556434d,bottom: 0.050165256382100565d,left: 0.2865840245389183d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.44156551111433795d,right: 0.4036563699553032d,bottom: 0.33756271369351587d,left: 0.15395177389608783d),

new NpgsqlTypes.NpgsqlBox(top: 0.5247924759829207d,right: 0.760973395310218d,bottom: 0.29256006300416026d,left: 0.26725002307299883d),

new NpgsqlTypes.NpgsqlBox(top: 0.9383666618385162d,right: 0.4765890959325688d,bottom: 0.5926720124352683d,left: 0.2537269358587335d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.1421271825097924d,right: 0.6781695299098555d,bottom: 0.010874512635674294d,left: 0.22097552479059124d),

new NpgsqlTypes.NpgsqlBox(top: 0.7297707863477898d,right: 0.945561734538361d,bottom: 0.30214906904753447d,left: 0.17098385952941442d),

new NpgsqlTypes.NpgsqlBox(top: 0.2766869752197184d,right: 0.513718642659593d,bottom: 0.2757867205458947d,left: 0.3801417859937235d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8448335046111566d,right: 0.9782643995071035d,bottom: 0.49476024616327974d,left: 0.11745663094232073d),

new NpgsqlTypes.NpgsqlBox(top: 0.9977516956239104d,right: 0.9125253021435736d,bottom: 0.22538534131697696d,left: 0.7299816368901683d),

new NpgsqlTypes.NpgsqlBox(top: 0.5568917474278495d,right: 0.3966805483067397d,bottom: 0.2806290396974367d,left: 0.32771450238734356d),

new NpgsqlTypes.NpgsqlBox(top: 0.652933186508116d,right: 0.9573751577810303d,bottom: 0.6439269518122571d,left: 0.6439352205424178d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4909780641339827d,right: 0.537995664536362d,bottom: 0.49014127020225096d,left: 0.30699314560643054d),

new NpgsqlTypes.NpgsqlBox(top: 0.5835942603246402d,right: 0.6766725611545408d,bottom: 0.5589499082029296d,left: 0.2981191910343459d),

new NpgsqlTypes.NpgsqlBox(top: 0.2992009609444378d,right: 0.7928813801923497d,bottom: 0.2509429015696495d,left: 0.13855354393001607d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9922245087916806d,right: 0.8070609058678451d,bottom: 0.8424417743401013d,left: 0.12246224538711936d),

new NpgsqlTypes.NpgsqlBox(top: 0.2763773949426529d,right: 0.7696213578512151d,bottom: 0.19146247897878166d,left: 0.09887242292115994d),

new NpgsqlTypes.NpgsqlBox(top: 0.9856884723657834d,right: 0.3640641959220765d,bottom: 0.7935559734644864d,left: 0.13237826009053433d),

},
    ModelInner = new NpgsqlBoxboxListD12MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6699218455503094d,right: 0.8159585874539907d,bottom: 0.38085081921156705d,left: 0.30155860978511617d),

new NpgsqlTypes.NpgsqlBox(top: 0.9536527220006076d,right: 0.8730144792994512d,bottom: 0.26122502055916585d,left: 0.3844967136404579d),

new NpgsqlTypes.NpgsqlBox(top: 0.3173271393089965d,right: 0.7010693152121418d,bottom: 0.17558572353427082d,left: 0.11562870389338675d),

new NpgsqlTypes.NpgsqlBox(top: 0.677618791027405d,right: 0.8448014421493099d,bottom: 0.658228013281133d,left: 0.03709591408338586d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8656194795695829d,right: 0.9355380318856021d,bottom: 0.18503226203418188d,left: 0.6086771730241408d),

new NpgsqlTypes.NpgsqlBox(top: 0.6952294610583875d,right: 0.6194042003420608d,bottom: 0.2395048124714685d,left: 0.1477469603598971d),

new NpgsqlTypes.NpgsqlBox(top: 0.3874118934178826d,right: 0.5190250345719196d,bottom: 0.3246589092336196d,left: 0.4829570260612348d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7505742031362713d,right: 0.6534405714252217d,bottom: 0.4043185095728714d,left: 0.505947320338482d),

new NpgsqlTypes.NpgsqlBox(top: 0.6685145404333298d,right: 0.9592373966087681d,bottom: 0.5657403264507688d,left: 0.7139959227205808d),

new NpgsqlTypes.NpgsqlBox(top: 0.8640935819335549d,right: 0.3447794674829471d,bottom: 0.4234945111611216d,left: 0.1657360310228867d),

new NpgsqlTypes.NpgsqlBox(top: 0.27840196661924677d,right: 0.7417724100640309d,bottom: 0.16379327783145992d,left: 0.2279406985088438d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.19127927862675664d,right: 0.9181405572427195d,bottom: 0.1673749875699263d,left: 0.09239915109229069d),

new NpgsqlTypes.NpgsqlBox(top: 0.7280096186262021d,right: 0.1747395705793081d,bottom: 0.0072413705861219535d,left: 0.09503309821453954d),

new NpgsqlTypes.NpgsqlBox(top: 0.8090941307831696d,right: 0.6864069527192603d,bottom: 0.5536982158776488d,left: 0.424709892061363d),

new NpgsqlTypes.NpgsqlBox(top: 0.7154432301721291d,right: 0.9596570418647118d,bottom: 0.16182737997658714d,left: 0.7955708684045646d),

},
    ModelInner = new NpgsqlBoxboxListD12MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8435889965789773d,right: 0.9470232983214015d,bottom: 0.020573256184793443d,left: 0.33044271983515294d),

new NpgsqlTypes.NpgsqlBox(top: 0.7757256527866239d,right: 0.5369595944652096d,bottom: 0.13805300073390758d,left: 0.5254114801522095d),

new NpgsqlTypes.NpgsqlBox(top: 0.9925972857289602d,right: 0.8713491005625105d,bottom: 0.7318713192819096d,left: 0.1899655069775401d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5033590912975189d,right: 0.9475313829107805d,bottom: 0.010331171450237764d,left: 0.7196598148405947d),

new NpgsqlTypes.NpgsqlBox(top: 0.7830835123754634d,right: 0.8164416491570262d,bottom: 0.23513083263499435d,left: 0.612155196510033d),

new NpgsqlTypes.NpgsqlBox(top: 0.9480985621907494d,right: 0.9522505357767921d,bottom: 0.22044232079721926d,left: 0.36968461143212294d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9708322909828412d,right: 0.4593950791294745d,bottom: 0.8108959897409302d,left: 0.4152378110621173d),

new NpgsqlTypes.NpgsqlBox(top: 0.6619162353173869d,right: 0.9956125224793118d,bottom: 0.07133849894203548d,left: 0.07008444629798005d),

new NpgsqlTypes.NpgsqlBox(top: 0.9315638320870683d,right: 0.40869334573510696d,bottom: 0.10369199183298061d,left: 0.40747222719896137d),

new NpgsqlTypes.NpgsqlBox(top: 0.6384589135988585d,right: 0.6266750699160064d,bottom: 0.13053527029973344d,left: 0.21327067837487157d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9279028570522387d,right: 0.45273696083198545d,bottom: 0.6216053751776087d,left: 0.21297131927076363d),

new NpgsqlTypes.NpgsqlBox(top: 0.5136288780845283d,right: 0.7011126741288555d,bottom: 0.17343294818820032d,left: 0.3112480579811059d),

new NpgsqlTypes.NpgsqlBox(top: 0.9974626378556376d,right: 0.7681369536072679d,bottom: 0.23122536572717756d,left: 0.7007796357557722d),

new NpgsqlTypes.NpgsqlBox(top: 0.7997057015058648d,right: 0.8786542714862285d,bottom: 0.48979402899552715d,left: 0.10318694395825934d),

},
    ModelInner = new NpgsqlBoxboxListD12MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.37555546048806476d,right: 0.9101043736358324d,bottom: 0.007316361426078166d,left: 0.7360030183574224d),

new NpgsqlTypes.NpgsqlBox(top: 0.8373769100172123d,right: 0.5537455512666383d,bottom: 0.05550000955353429d,left: 0.312701498372862d),

new NpgsqlTypes.NpgsqlBox(top: 0.596324649708761d,right: 0.8413615828280038d,bottom: 0.5615543710448655d,left: 0.1533471102848617d),

new NpgsqlTypes.NpgsqlBox(top: 0.5256537322885148d,right: 0.4100725882458167d,bottom: 0.021751869437423244d,left: 0.1223160048090225d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6169718023473056d,right: 0.9938255689761936d,bottom: 0.43127591436219537d,left: 0.211981644509865d),

new NpgsqlTypes.NpgsqlBox(top: 0.810588717980336d,right: 0.5374939627147479d,bottom: 0.1271168296450318d,left: 0.14313679565136428d),

new NpgsqlTypes.NpgsqlBox(top: 0.5430546853255747d,right: 0.9475295194301304d,bottom: 0.34705490815061923d,left: 0.7569928200733055d),

new NpgsqlTypes.NpgsqlBox(top: 0.7295606359571906d,right: 0.7696592874453454d,bottom: 0.23941224386930737d,left: 0.5851992756407104d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5639309249100544d,right: 0.17497574676961358d,bottom: 0.26064795216340053d,left: 0.1637945435988103d),

new NpgsqlTypes.NpgsqlBox(top: 0.3825353766032593d,right: 0.3645258932655884d,bottom: 0.1591289371438338d,left: 0.011237989374993984d),

new NpgsqlTypes.NpgsqlBox(top: 0.06538252961311075d,right: 0.7769178471052721d,bottom: 0.008801394270670948d,left: 0.33946297981156925d),

new NpgsqlTypes.NpgsqlBox(top: 0.5544789284046215d,right: 0.9543150816318381d,bottom: 0.22374157929948202d,left: 0.18933052560579444d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3845618641238887d,right: 0.6435667144258765d,bottom: 0.08974580048380565d,left: 0.13041592834150384d),

new NpgsqlTypes.NpgsqlBox(top: 0.6142455025643883d,right: 0.5910826478805702d,bottom: 0.44268786743524025d,left: 0.19823831593739982d),

new NpgsqlTypes.NpgsqlBox(top: 0.30192235756009544d,right: 0.7083632142702045d,bottom: 0.15194575857354398d,left: 0.41472430789163917d),

new NpgsqlTypes.NpgsqlBox(top: 0.23538460682451168d,right: 0.1930684380594353d,bottom: 0.2173562322966215d,left: 0.10175668895972367d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9411179862619826d,right: 0.7424156613194952d,bottom: 0.7824773572620319d,left: 0.43402726185643625d),

new NpgsqlTypes.NpgsqlBox(top: 0.9931111278808491d,right: 0.4881909945257147d,bottom: 0.7736372508699088d,left: 0.38669705237257923d),

new NpgsqlTypes.NpgsqlBox(top: 0.3233941995979711d,right: 0.7267107591738201d,bottom: 0.14836233385877318d,left: 0.6849624974504626d),

new NpgsqlTypes.NpgsqlBox(top: 0.8612366537756992d,right: 0.4640906589128131d,bottom: 0.3573381859934843d,left: 0.21920494349754827d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.344223031668181d,right: 0.7833457037244652d,bottom: 0.24769719804282597d,left: 0.48630208776026074d),

new NpgsqlTypes.NpgsqlBox(top: 0.8297538730730489d,right: 0.9136807071737144d,bottom: 0.5123293555472304d,left: 0.003414306261840805d),

new NpgsqlTypes.NpgsqlBox(top: 0.211335235256345d,right: 0.5122494619353591d,bottom: 0.15236343559817767d,left: 0.2504174396467953d),

new NpgsqlTypes.NpgsqlBox(top: 0.19198843494481677d,right: 0.20963976256306427d,bottom: 0.04859694692055361d,left: 0.11343737220296846d),

},
    ModelInner = new NpgsqlBoxboxListD12MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6791362350330784d,right: 0.11158504098430022d,bottom: 0.4548301455165291d,left: 0.09426537729276063d),

new NpgsqlTypes.NpgsqlBox(top: 0.27910413057497574d,right: 0.9168825026674876d,bottom: 0.10020254188292554d,left: 0.8154609569370238d),

new NpgsqlTypes.NpgsqlBox(top: 0.7601728265429999d,right: 0.18735352604888433d,bottom: 0.111796797660218d,left: 0.058407096570456396d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3923966473223871d,right: 0.7326536863129415d,bottom: 0.30808577135175397d,left: 0.03247367437781201d),

new NpgsqlTypes.NpgsqlBox(top: 0.9890103078814853d,right: 0.7390633646239291d,bottom: 0.3653453273381613d,left: 0.3893986754246801d),

new NpgsqlTypes.NpgsqlBox(top: 0.5993392893109879d,right: 0.6723171229159945d,bottom: 0.18227779527248555d,left: 0.3350383122831737d),

new NpgsqlTypes.NpgsqlBox(top: 0.5454933970215211d,right: 0.24764081403308147d,bottom: 0.48156355007819196d,left: 0.18260993789926172d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7419962903821106d,right: 0.8506568507264043d,bottom: 0.7339468470401788d,left: 0.11834830743910918d),

new NpgsqlTypes.NpgsqlBox(top: 0.5510693689048015d,right: 0.5538065921553259d,bottom: 0.004672653309835018d,left: 0.12637398207310802d),

new NpgsqlTypes.NpgsqlBox(top: 0.18546182890281093d,right: 0.8925247901023698d,bottom: 0.1768953702823065d,left: 0.3069360859764294d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5353150155514058d,right: 0.13932633919995585d,bottom: 0.4518116611351193d,left: 0.06292451689593892d),

new NpgsqlTypes.NpgsqlBox(top: 0.94634659196873d,right: 0.4126229816477025d,bottom: 0.6545825195025997d,left: 0.34138424477205964d),

new NpgsqlTypes.NpgsqlBox(top: 0.1448929647819105d,right: 0.8710233090915105d,bottom: 0.13505987006024722d,left: 0.038442740124167485d),

new NpgsqlTypes.NpgsqlBox(top: 0.7948930668267937d,right: 0.8465414594999477d,bottom: 0.2564773955887133d,left: 0.05203883198296788d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5512699268778305d,right: 0.3490666404515963d,bottom: 0.11792176017487888d,left: 0.06245469634263867d),

new NpgsqlTypes.NpgsqlBox(top: 0.8862806489322174d,right: 0.37665246681492237d,bottom: 0.6378211932988181d,left: 0.15060411937037887d),

new NpgsqlTypes.NpgsqlBox(top: 0.8380917862693421d,right: 0.9277850926389312d,bottom: 0.587138759485758d,left: 0.10279239770228188d),

new NpgsqlTypes.NpgsqlBox(top: 0.29313569284220575d,right: 0.8891442853232822d,bottom: 0.08408922427694243d,left: 0.4943555627072128d),

},
    ModelInner = new NpgsqlBoxboxListD12MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5851052775072639d,right: 0.8574685798208145d,bottom: 0.09919006446665679d,left: 0.2167078209026857d),

new NpgsqlTypes.NpgsqlBox(top: 0.10287487037738541d,right: 0.11009312406919236d,bottom: 0.09439339217778075d,left: 0.019458531784119937d),

new NpgsqlTypes.NpgsqlBox(top: 0.6256438605611019d,right: 0.8872649342582287d,bottom: 0.05827206663599971d,left: 0.4165127267284555d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9545843560554914d,right: 0.9393477541231594d,bottom: 0.8385284383372177d,left: 0.8843192193180853d),

new NpgsqlTypes.NpgsqlBox(top: 0.5753701382078161d,right: 0.4554639295113263d,bottom: 0.551658655791175d,left: 0.4201167599061172d),

new NpgsqlTypes.NpgsqlBox(top: 0.8201949890102791d,right: 0.9381874071864529d,bottom: 0.2920185200129831d,left: 0.785596638663575d),

new NpgsqlTypes.NpgsqlBox(top: 0.544401168312224d,right: 0.822319420960264d,bottom: 0.1854758376453346d,left: 0.24854042510969443d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.526175622999076d,right: 0.4388273659152062d,bottom: 0.4953062178529821d,left: 0.03991865106873227d),

new NpgsqlTypes.NpgsqlBox(top: 0.39464216433698096d,right: 0.815081674046101d,bottom: 0.36085389557953707d,left: 0.37787613481181226d),

new NpgsqlTypes.NpgsqlBox(top: 0.9558072261226916d,right: 0.5963221614827743d,bottom: 0.6541400895677774d,left: 0.4150692156247767d),

new NpgsqlTypes.NpgsqlBox(top: 0.7898424048249726d,right: 0.23741741594765053d,bottom: 0.1454660476930313d,left: 0.18020960700653843d),

},
    ModelInner = new NpgsqlBoxboxListD12MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7987900511759379d,right: 0.8368020885906442d,bottom: 0.6864188565121743d,left: 0.21332752093465301d),

new NpgsqlTypes.NpgsqlBox(top: 0.8108255646114418d,right: 0.6286857194081792d,bottom: 0.31425970371770895d,left: 0.45691677686611076d),

new NpgsqlTypes.NpgsqlBox(top: 0.9878224629164052d,right: 0.9002778821056824d,bottom: 0.5034653796148417d,left: 0.7093534882958374d),

new NpgsqlTypes.NpgsqlBox(top: 0.8580095797081392d,right: 0.8770140613055537d,bottom: 0.42690376844549527d,left: 0.08479939949598414d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.43197078479751916d,right: 0.2528269297777327d,bottom: 0.14987178628193554d,left: 0.033906927124240926d),

new NpgsqlTypes.NpgsqlBox(top: 0.828174004666403d,right: 0.9567353319493253d,bottom: 0.6780921618738545d,left: 0.3131004375049251d),

new NpgsqlTypes.NpgsqlBox(top: 0.2315968195962752d,right: 0.6204558527270831d,bottom: 0.016515670242311264d,left: 0.20280047275209023d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5095746559294563d,right: 0.44218376623300604d,bottom: 0.16662051405685696d,left: 0.23641203912408837d),

new NpgsqlTypes.NpgsqlBox(top: 0.6182076978711784d,right: 0.5773336151653911d,bottom: 0.13476366466318668d,left: 0.3072506841745768d),

new NpgsqlTypes.NpgsqlBox(top: 0.9192692405497436d,right: 0.11126856707325072d,bottom: 0.6064951560086811d,left: 0.0221545762641564d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8844223927050354d,right: 0.8904481169617383d,bottom: 0.6096425134712656d,left: 0.8525822232825214d),

new NpgsqlTypes.NpgsqlBox(top: 0.7715283849424344d,right: 0.9616996342175206d,bottom: 0.0233696373479938d,left: 0.7376231929681687d),

new NpgsqlTypes.NpgsqlBox(top: 0.8648249678044653d,right: 0.9778567160931999d,bottom: 0.4178569675238186d,left: 0.4411104672618752d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3802808594616054d,right: 0.740275747272988d,bottom: 0.03829527945632083d,left: 0.47793644358036236d),

new NpgsqlTypes.NpgsqlBox(top: 0.851311970358262d,right: 0.6329497201471851d,bottom: 0.5890757584348891d,left: 0.6263350198265802d),

new NpgsqlTypes.NpgsqlBox(top: 0.2418063414316678d,right: 0.7488295769004115d,bottom: 0.11894191122924924d,left: 0.6680839153116169d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.49006908472512567d,right: 0.7484688990441992d,bottom: 0.284936366481113d,left: 0.6772383412830278d),

new NpgsqlTypes.NpgsqlBox(top: 0.7742899836171061d,right: 0.7954418370749343d,bottom: 0.29300524877489353d,left: 0.5124542465338264d),

new NpgsqlTypes.NpgsqlBox(top: 0.6677969984062326d,right: 0.6991777837139213d,bottom: 0.171239213173353d,left: 0.47014353101098927d),

new NpgsqlTypes.NpgsqlBox(top: 0.7901142632417502d,right: 0.7708181086937821d,bottom: 0.50805947134939d,left: 0.39401969468654674d),

},
    ModelInner = new NpgsqlBoxboxListD12MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.07399102878935415d,right: 0.8213314192372815d,bottom: 0.02402475142776106d,left: 0.3443263196357721d),

new NpgsqlTypes.NpgsqlBox(top: 0.5853058324390725d,right: 0.6791323145920143d,bottom: 0.2661312371024649d,left: 0.308525336855329d),

new NpgsqlTypes.NpgsqlBox(top: 0.5007396313479575d,right: 0.6713858802828774d,bottom: 0.4086060527599681d,left: 0.053641994225933964d),

new NpgsqlTypes.NpgsqlBox(top: 0.772596756001144d,right: 0.4350302802674906d,bottom: 0.008504791682750423d,left: 0.40673064791927316d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6644374776732612d,right: 0.7989115809692503d,bottom: 0.6430448902953101d,left: 0.6777272349320097d),

new NpgsqlTypes.NpgsqlBox(top: 0.7403139443068835d,right: 0.05293927924911224d,bottom: 0.5805170194881798d,left: 0.043385021412085d),

new NpgsqlTypes.NpgsqlBox(top: 0.07072663382453104d,right: 0.9761591962842563d,bottom: 0.015772169253037704d,left: 0.2696960277117376d),

new NpgsqlTypes.NpgsqlBox(top: 0.3681828540204747d,right: 0.6369392898942731d,bottom: 0.21074350406407338d,left: 0.2766235337983557d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5155843084269737d,right: 0.1977625284190605d,bottom: 0.07942254776749436d,left: 0.19416665111156717d),

new NpgsqlTypes.NpgsqlBox(top: 0.738508996341267d,right: 0.4419367389444926d,bottom: 0.4101943785685922d,left: 0.4341268243223194d),

new NpgsqlTypes.NpgsqlBox(top: 0.7428139461507066d,right: 0.7386805746240706d,bottom: 0.3356943551683772d,left: 0.03806308649797474d),

new NpgsqlTypes.NpgsqlBox(top: 0.5316527929177362d,right: 0.8138195188153162d,bottom: 0.02462566050285986d,left: 0.22472747796673742d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6628221065675036d,right: 0.7098926838066477d,bottom: 0.47796775995110397d,left: 0.6722602990909206d),

new NpgsqlTypes.NpgsqlBox(top: 0.8353526099093915d,right: 0.9702564938631042d,bottom: 0.6800185669606489d,left: 0.9512128943880732d),

new NpgsqlTypes.NpgsqlBox(top: 0.4319261946756844d,right: 0.8737656902851467d,bottom: 0.2525966395666762d,left: 0.7248776897965862d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.722478346672645d,right: 0.5456033874825806d,bottom: 0.5257700575597689d,left: 0.12639206705464934d),

new NpgsqlTypes.NpgsqlBox(top: 0.8258166534546127d,right: 0.9912883571806549d,bottom: 0.29545823320659703d,left: 0.5139344645198984d),

new NpgsqlTypes.NpgsqlBox(top: 0.540096143662478d,right: 0.9189840280239867d,bottom: 0.03887292071455617d,left: 0.4831141574486131d),

new NpgsqlTypes.NpgsqlBox(top: 0.6059438990388326d,right: 0.9415292858573635d,bottom: 0.09724824938675425d,left: 0.07791323919521176d),

},
    ModelInner = new NpgsqlBoxboxListD12MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9531771329789929d,right: 0.1380306887613063d,bottom: 0.22157144707115384d,left: 0.05527223322138197d),

new NpgsqlTypes.NpgsqlBox(top: 0.578810272407512d,right: 0.88948131805122d,bottom: 0.20349699811879585d,left: 0.6668721390860323d),

new NpgsqlTypes.NpgsqlBox(top: 0.8796216487476389d,right: 0.25663545950747924d,bottom: 0.7353933197877668d,left: 0.12634516244040261d),

new NpgsqlTypes.NpgsqlBox(top: 0.11890220147335107d,right: 0.41782180324995954d,bottom: 0.1107600542898215d,left: 0.26195216290642775d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5830755539683355d,right: 0.8723150172382623d,bottom: 0.5208071709834096d,left: 0.318320051960568d),

new NpgsqlTypes.NpgsqlBox(top: 0.9713581508962541d,right: 0.6001941416382977d,bottom: 0.5344418818132826d,left: 0.10140792665540155d),

new NpgsqlTypes.NpgsqlBox(top: 0.18942271648166986d,right: 0.873151098701463d,bottom: 0.062085101042689717d,left: 0.03501258379295602d),

new NpgsqlTypes.NpgsqlBox(top: 0.9810817648258607d,right: 0.7804295396702309d,bottom: 0.6486381119057284d,left: 0.23153716345334163d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5742360974652991d,right: 0.37552331645983694d,bottom: 0.3571100050286782d,left: 0.33989447510351534d),

new NpgsqlTypes.NpgsqlBox(top: 0.8151681478735302d,right: 0.5261966509436165d,bottom: 0.39952255376569423d,left: 0.23543943503432008d),

new NpgsqlTypes.NpgsqlBox(top: 0.7413860318616228d,right: 0.4293962557703088d,bottom: 0.0715505964559312d,left: 0.3855311183833363d),

new NpgsqlTypes.NpgsqlBox(top: 0.846425665126258d,right: 0.8646801630022751d,bottom: 0.1617509961927882d,left: 0.27194617480068795d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7152457604969574d,right: 0.5662965970289943d,bottom: 0.05166235342839376d,left: 0.1527687970839049d),

new NpgsqlTypes.NpgsqlBox(top: 0.48320256580239684d,right: 0.1907551208402477d,bottom: 0.15370517766339653d,left: 0.099224764358113d),

new NpgsqlTypes.NpgsqlBox(top: 0.9584624568022629d,right: 0.84683187132628d,bottom: 0.8483804479824192d,left: 0.3236111280182079d),

new NpgsqlTypes.NpgsqlBox(top: 0.43851051254574036d,right: 0.7164268333043784d,bottom: 0.02047686468685217d,left: 0.6211188802017816d),

},
    ModelInner = new NpgsqlBoxboxListD12MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3619789095220226d,right: 0.913247009290762d,bottom: 0.2898169419290453d,left: 0.5910532108047188d),

new NpgsqlTypes.NpgsqlBox(top: 0.48153754446759633d,right: 0.9228038748487332d,bottom: 0.35457590663079075d,left: 0.20793156825634185d),

new NpgsqlTypes.NpgsqlBox(top: 0.23745126754900092d,right: 0.6233121420437646d,bottom: 0.14786103228451397d,left: 0.4087511933960707d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9659308743940295d,right: 0.901900060280233d,bottom: 0.3991024064514581d,left: 0.6285740793477747d),

new NpgsqlTypes.NpgsqlBox(top: 0.7990292240997408d,right: 0.42497146846518574d,bottom: 0.5399643015573498d,left: 0.25763508421627546d),

new NpgsqlTypes.NpgsqlBox(top: 0.776398680429385d,right: 0.7343377232480115d,bottom: 0.6832894738403444d,left: 0.41461820650328884d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8297879372880368d,right: 0.6891111378786285d,bottom: 0.13416227050825835d,left: 0.09143659316503805d),

new NpgsqlTypes.NpgsqlBox(top: 0.46901036677705443d,right: 0.6775812210197553d,bottom: 0.012520415777431904d,left: 0.31524722496657653d),

new NpgsqlTypes.NpgsqlBox(top: 0.29820096433149423d,right: 0.49751873952825887d,bottom: 0.020682461213847758d,left: 0.31312821988304196d),

new NpgsqlTypes.NpgsqlBox(top: 0.634356350580813d,right: 0.3806003046739813d,bottom: 0.5803832387742246d,left: 0.04103274719241623d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9587145148706252d,right: 0.9483344900904263d,bottom: 0.18117565885637077d,left: 0.01039197321676033d),

new NpgsqlTypes.NpgsqlBox(top: 0.08874951313543389d,right: 0.8227422037156178d,bottom: 0.03936941358676438d,left: 0.04039476328418934d),

new NpgsqlTypes.NpgsqlBox(top: 0.8919594975658051d,right: 0.19076651780160725d,bottom: 0.18426646818057746d,left: 0.10548204153458907d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7308517837517017d,right: 0.36279982564652435d,bottom: 0.578210723388906d,left: 0.32172527952333463d),

new NpgsqlTypes.NpgsqlBox(top: 0.8510263088210156d,right: 0.8736686668078437d,bottom: 0.021615960885202012d,left: 0.07082212306556868d),

new NpgsqlTypes.NpgsqlBox(top: 0.8633248761691072d,right: 0.9541672828225495d,bottom: 0.49909490375938037d,left: 0.7440844060873785d),

new NpgsqlTypes.NpgsqlBox(top: 0.23122474555575034d,right: 0.9873938830064428d,bottom: 0.12133851090501102d,left: 0.29516087626906395d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.48968183291194567d,right: 0.4636666538058555d,bottom: 0.25826417811956437d,left: 0.09791545155684922d),

new NpgsqlTypes.NpgsqlBox(top: 0.6097399780071461d,right: 0.7585799005663164d,bottom: 0.49349558978216657d,left: 0.3715846699549429d),

new NpgsqlTypes.NpgsqlBox(top: 0.5334925126684641d,right: 0.9959211086913864d,bottom: 0.15250909554151493d,left: 0.8333211010557341d),

new NpgsqlTypes.NpgsqlBox(top: 0.6865684284009955d,right: 0.5957326248018923d,bottom: 0.5401794004513081d,left: 0.10797260256364694d),

},
    ModelInner = new NpgsqlBoxboxListD12MI
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7234485719805835d,right: 0.8820202731709164d,bottom: 0.35191222527960764d,left: 0.7263731998779396d),

new NpgsqlTypes.NpgsqlBox(top: 0.49170308207766367d,right: 0.3946839243777588d,bottom: 0.3658554969776723d,left: 0.15741909386619635d),

new NpgsqlTypes.NpgsqlBox(top: 0.7074709351329658d,right: 0.7045118741406354d,bottom: 0.6159746206253655d,left: 0.5217069632189177d),

new NpgsqlTypes.NpgsqlBox(top: 0.7442116460125352d,right: 0.9358085389977295d,bottom: 0.20562667712408933d,left: 0.05441157740998537d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9455151561801884d,right: 0.782472135810685d,bottom: 0.07198363384770201d,left: 0.08253389082105045d),

new NpgsqlTypes.NpgsqlBox(top: 0.06875475639232953d,right: 0.809478053138619d,bottom: 0.011489565728985074d,left: 0.24761565485378612d),

new NpgsqlTypes.NpgsqlBox(top: 0.3656602794160546d,right: 0.832272799418181d,bottom: 0.2898098997774359d,left: 0.2740724825355584d),

new NpgsqlTypes.NpgsqlBox(top: 0.6446287583990828d,right: 0.7069897526957437d,bottom: 0.6425565839959528d,left: 0.4260759688426211d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5696480531395757d,right: 0.6445958071627264d,bottom: 0.07154394969308575d,left: 0.1622067958248078d),

new NpgsqlTypes.NpgsqlBox(top: 0.8206397611904238d,right: 0.9814049576790702d,bottom: 0.29048417133998117d,left: 0.26446089859312516d),

new NpgsqlTypes.NpgsqlBox(top: 0.5628774586779176d,right: 0.9483829142197758d,bottom: 0.19075523455728483d,left: 0.15845877254903873d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7609597201103984d,right: 0.743767572113337d,bottom: 0.13849450815937858d,left: 0.04606983144391463d),

new NpgsqlTypes.NpgsqlBox(top: 0.6179493260889095d,right: 0.8879116689834659d,bottom: 0.4074960595744287d,left: 0.03532023727429545d),

new NpgsqlTypes.NpgsqlBox(top: 0.8672769139131961d,right: 0.8805906171929543d,bottom: 0.25961758973584537d,left: 0.623481551596671d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9804928023667293d,right: 0.7006682587291623d,bottom: 0.05696221595364104d,left: 0.20915580960342695d),

new NpgsqlTypes.NpgsqlBox(top: 0.38177939093291036d,right: 0.599387162745796d,bottom: 0.3160183182378302d,left: 0.24860370911863172d),

new NpgsqlTypes.NpgsqlBox(top: 0.25468626773463876d,right: 0.637284967461835d,bottom: 0.19478174339409615d,left: 0.03538196220335199d),

},
    ModelInner = new NpgsqlBoxboxListD12MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6827244412187715d,right: 0.9583693448117057d,bottom: 0.04157991076954848d,left: 0.04163542562097977d),

new NpgsqlTypes.NpgsqlBox(top: 0.6577919099330936d,right: 0.9462683786174749d,bottom: 0.24562706021476632d,left: 0.8400997919791223d),

new NpgsqlTypes.NpgsqlBox(top: 0.8381262294944416d,right: 0.7829708963461537d,bottom: 0.34615368104737154d,left: 0.6381178289366382d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9295645689073325d,right: 0.9492434610118663d,bottom: 0.31200573431433565d,left: 0.5991285710334869d),

new NpgsqlTypes.NpgsqlBox(top: 0.7878773601263188d,right: 0.4348524655848882d,bottom: 0.08556912562052366d,left: 0.1908999798640887d),

new NpgsqlTypes.NpgsqlBox(top: 0.812614100281064d,right: 0.22517754939195034d,bottom: 0.18439131857651925d,left: 0.0759228867702002d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.41782511855125903d,right: 0.45519587794681915d,bottom: 0.2181463793555356d,left: 0.38722345288824156d),

new NpgsqlTypes.NpgsqlBox(top: 0.7424674191190888d,right: 0.8750894446019913d,bottom: 0.46793967793915336d,left: 0.4344779152434024d),

new NpgsqlTypes.NpgsqlBox(top: 0.7144686603280711d,right: 0.9703839380845154d,bottom: 0.5122437990830141d,left: 0.3741979303619596d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6174220812816558d,right: 0.6217607814173503d,bottom: 0.3256552939931363d,left: 0.038783420068898344d),

new NpgsqlTypes.NpgsqlBox(top: 0.985978940215781d,right: 0.3764261092188228d,bottom: 0.4585852307151187d,left: 0.13848138105058772d),

new NpgsqlTypes.NpgsqlBox(top: 0.6063236474862952d,right: 0.5019308917045803d,bottom: 0.35160768436466316d,left: 0.20797845931848036d),

new NpgsqlTypes.NpgsqlBox(top: 0.8680413928868944d,right: 0.4056657694843433d,bottom: 0.25124352780075476d,left: 0.04327478647110605d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8785238433992075d,right: 0.6328285727725094d,bottom: 0.41373300378609146d,left: 0.5901096610700639d),

new NpgsqlTypes.NpgsqlBox(top: 0.6421446050345432d,right: 0.49009596159831803d,bottom: 0.25970969504024677d,left: 0.38019333728117544d),

new NpgsqlTypes.NpgsqlBox(top: 0.9214910599690632d,right: 0.6702711756748733d,bottom: 0.7025956393608738d,left: 0.40961098846728605d),

},
    ModelInner = new NpgsqlBoxboxListD12MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.640770680971333d,right: 0.6955823559179314d,bottom: 0.21402603008683707d,left: 0.5950578288738002d),

new NpgsqlTypes.NpgsqlBox(top: 0.9971313766714925d,right: 0.7647907460890485d,bottom: 0.225736931127963d,left: 0.45976064259914273d),

new NpgsqlTypes.NpgsqlBox(top: 0.7598229972079122d,right: 0.23342536721942386d,bottom: 0.26725190541675836d,left: 0.20741727400543197d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.659919314151876d,right: 0.5510363729654559d,bottom: 0.31916276374218255d,left: 0.32687595127161506d),

new NpgsqlTypes.NpgsqlBox(top: 0.9714801809789605d,right: 0.5953727440189998d,bottom: 0.45692658551253895d,left: 0.29276745263642123d),

new NpgsqlTypes.NpgsqlBox(top: 0.890697871459942d,right: 0.3393315182423241d,bottom: 0.16084253023368666d,left: 0.19435712685055329d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8967480781964298d,right: 0.7276558744415382d,bottom: 0.2329956946347126d,left: 0.6495736193339117d),

new NpgsqlTypes.NpgsqlBox(top: 0.4976880708666582d,right: 0.422168546015546d,bottom: 0.3423211034073693d,left: 0.09630249858849627d),

new NpgsqlTypes.NpgsqlBox(top: 0.06360328674613724d,right: 0.9299553721074255d,bottom: 0.05818840686680282d,left: 0.5575182672719613d),

new NpgsqlTypes.NpgsqlBox(top: 0.6741640501870749d,right: 0.640742158348931d,bottom: 0.4497046467304662d,left: 0.047484528652878444d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7516689824886195d,right: 0.9869658030549631d,bottom: 0.24458269031599567d,left: 0.32540096111608985d),

new NpgsqlTypes.NpgsqlBox(top: 0.7155342716089896d,right: 0.9031830085669056d,bottom: 0.6752055351623732d,left: 0.4758254437763497d),

new NpgsqlTypes.NpgsqlBox(top: 0.9723514228763833d,right: 0.3607797220158705d,bottom: 0.6175436097775975d,left: 0.10204129155361297d),

new NpgsqlTypes.NpgsqlBox(top: 0.45299749860697225d,right: 0.3879974217296699d,bottom: 0.4066525582737045d,left: 0.048194886490244726d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.856128695781917d,right: 0.9746929945286187d,bottom: 0.845029755099157d,left: 0.41163744394012713d),

new NpgsqlTypes.NpgsqlBox(top: 0.9149137462624032d,right: 0.3954777095898657d,bottom: 0.014014379371431573d,left: 0.013690927062991243d),

new NpgsqlTypes.NpgsqlBox(top: 0.866353343671237d,right: 0.304407075397505d,bottom: 0.7352509744630682d,left: 0.08381354783880413d),

new NpgsqlTypes.NpgsqlBox(top: 0.9843116793126282d,right: 0.42943646580105344d,bottom: 0.5930029140384832d,left: 0.23433973428997612d),

},
    ModelInner = new NpgsqlBoxboxListD12MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7454996315186031d,right: 0.9575091242307034d,bottom: 0.06462189097399562d,left: 0.34489936686778755d),

new NpgsqlTypes.NpgsqlBox(top: 0.450623090145147d,right: 0.8960899198752138d,bottom: 0.012048736016027073d,left: 0.5297567319587081d),

new NpgsqlTypes.NpgsqlBox(top: 0.971437502518912d,right: 0.7720009624744641d,bottom: 0.11402057822426903d,left: 0.037320944863606376d),

new NpgsqlTypes.NpgsqlBox(top: 0.19221715734033407d,right: 0.9563861882393603d,bottom: 0.0968365660838213d,left: 0.7283466886109122d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9751827664846786d,right: 0.5104681795322332d,bottom: 0.8051460769343413d,left: 0.11126848418281932d),

new NpgsqlTypes.NpgsqlBox(top: 0.3556178104721409d,right: 0.6489246329155895d,bottom: 0.2627221694887374d,left: 0.019075392787921586d),

new NpgsqlTypes.NpgsqlBox(top: 0.7831396962404072d,right: 0.9134582578477576d,bottom: 0.4119058755850571d,left: 0.7604893677069766d),

new NpgsqlTypes.NpgsqlBox(top: 0.6382015624641382d,right: 0.8510391915843672d,bottom: 0.2408516350723009d,left: 0.4352143692326156d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5608141301822435d,right: 0.9331820338840194d,bottom: 0.47048956782837004d,left: 0.8008578668059371d),

new NpgsqlTypes.NpgsqlBox(top: 0.9308517761635752d,right: 0.8292648504401755d,bottom: 0.002233192424089925d,left: 0.04623109026206129d),

new NpgsqlTypes.NpgsqlBox(top: 0.9397183514900649d,right: 0.7698609821178873d,bottom: 0.09496067123636143d,left: 0.4957358491481667d),

new NpgsqlTypes.NpgsqlBox(top: 0.5539572783753183d,right: 0.41141669113182533d,bottom: 0.17230535310513273d,left: 0.16462291048780997d),

},
    ModelInner = new NpgsqlBoxboxListD12MI
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8033359851811419d,right: 0.9650893812159523d,bottom: 0.20832856452764847d,left: 0.7410263246482115d),

new NpgsqlTypes.NpgsqlBox(top: 0.9341720941977474d,right: 0.522824451161162d,bottom: 0.41430758265048107d,left: 0.4497258347232794d),

new NpgsqlTypes.NpgsqlBox(top: 0.6112793938353488d,right: 0.39590167745055127d,bottom: 0.4238630175316268d,left: 0.07709073026881752d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8033713490981725d,right: 0.4047619494829686d,bottom: 0.18842402621465537d,left: 0.046565754233523826d),

new NpgsqlTypes.NpgsqlBox(top: 0.6915519705743977d,right: 0.5420599364672735d,bottom: 0.25787630025476105d,left: 0.0011013139389384197d),

new NpgsqlTypes.NpgsqlBox(top: 0.12134704276854469d,right: 0.3490214275616226d,bottom: 0.07085119168011178d,left: 0.1838510248756695d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.49341733984707625d,right: 0.4084504865039702d,bottom: 0.06845703951224269d,left: 0.20664086318037445d),

new NpgsqlTypes.NpgsqlBox(top: 0.5173552563684608d,right: 0.8863727177366183d,bottom: 0.014101583930951178d,left: 0.3091755351868536d),

new NpgsqlTypes.NpgsqlBox(top: 0.9902503511161306d,right: 0.515047467569514d,bottom: 0.09732953912863174d,left: 0.047891968201043356d),

new NpgsqlTypes.NpgsqlBox(top: 0.7948966243640615d,right: 0.7821372585614674d,bottom: 0.15682706858459394d,left: 0.4932803939982702d),

},
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9397150622809365d,right: 0.27733872439884d,bottom: 0.16122617435696573d,left: 0.0744216127231182d),

new NpgsqlTypes.NpgsqlBox(top: 0.8248932418446494d,right: 0.7236727815744327d,bottom: 0.5916506196343704d,left: 0.0911223162512299d),

new NpgsqlTypes.NpgsqlBox(top: 0.7096283821498823d,right: 0.7611826277462947d,bottom: 0.705539186237963d,left: 0.016392186359396543d),

},
    ModelInner = new NpgsqlBoxboxListD12MI
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9295827121514382d,right: 0.49453718866008634d,bottom: 0.8249875729660764d,left: 0.12313187236736678d),

new NpgsqlTypes.NpgsqlBox(top: 0.44910506536215455d,right: 0.9274493429679086d,bottom: 0.15526485535633594d,left: 0.5201142617189705d),

new NpgsqlTypes.NpgsqlBox(top: 0.5294957376829348d,right: 0.8535554876229953d,bottom: 0.08628716488968513d,left: 0.6270593041472363d),

new NpgsqlTypes.NpgsqlBox(top: 0.6557925627432772d,right: 0.837705143387761d,bottom: 0.0322529503476916d,left: 0.19364560199782876d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8008522133091452d,right: 0.6042065344017957d,bottom: 0.3973323439172992d,left: 0.3821357611199947d),

new NpgsqlTypes.NpgsqlBox(top: 0.7951100060615113d,right: 0.8146464620050079d,bottom: 0.344245474333046d,left: 0.26856460362259427d),

new NpgsqlTypes.NpgsqlBox(top: 0.5243065158532524d,right: 0.7230498298859399d,bottom: 0.39997457393058355d,left: 0.6437554150334591d),

new NpgsqlTypes.NpgsqlBox(top: 0.8851161289595058d,right: 0.3822844098883227d,bottom: 0.44981105301900026d,left: 0.2013951489353869d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxListD1E2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7486478703203295d,right: 0.3258777810107969d,bottom: 0.6879636535325232d,left: 0.07503747807979566d),

new NpgsqlTypes.NpgsqlBox(top: 0.8614021107933413d,right: 0.7542284835080267d,bottom: 0.14961582359588665d,left: 0.19292698083829174d),

new NpgsqlTypes.NpgsqlBox(top: 0.6698346139210134d,right: 0.46863043601031396d,bottom: 0.5141240152287472d,left: 0.16267363800028567d),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxlistd12mi(
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
INSERT INTO public.npgsqlboxboxlistd12mi(
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
            queryMapTypes: [typeof(NpgsqlBoxboxListD12MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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

                changedRows =  ((INpgsqlBoxListboxListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxListboxListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlBoxListboxListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxlistd12mi_id
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)), 
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
                methodParametrName: "npgsqlboxboxlistd12mi_id", 
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
                changedRows =  ((INpgsqlBoxListboxListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxListboxListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxListboxListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxListboxListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxlistd12mi_id
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
    npgsqlboxboxlistd12mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxlistd12mi_id
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
    npgsqlboxboxlistd12mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
                methodParametrName: "npgsqlboxboxlistd12mi_id", 
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
                List<NpgsqlBoxboxListD1E2M> models = null;

                models =  ((INpgsqlBoxListboxListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlBoxListboxListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlBoxListboxListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlBoxListboxListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxListD1E2M> models = null;

                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlBoxListboxListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxListD1E2M), typeof(FlatNpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var models2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await ((INpgsqlBoxListboxListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var models2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                ((INpgsqlBoxListboxListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxListboxListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxListboxListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
LEFT JOIN public.npgsqlboxboxlistd12mi mi ON mi.id = m.npgsqlboxboxlistd12mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
                var models = await ((INpgsqlBoxListboxListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxListboxListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxListD1E2M), typeof(FlatNpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var models2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await ((INpgsqlBoxListboxListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var models2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                ((INpgsqlBoxListboxListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxListboxListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxListboxListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
LEFT JOIN public.npgsqlboxboxlistd12mi mi ON mi.id = m.npgsqlboxboxlistd12mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
                var models = await ((INpgsqlBoxListboxListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxListboxListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxListD1E2M), typeof(FlatNpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var models2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await((INpgsqlBoxListboxListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await ((INpgsqlBoxListboxListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 69;
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await ((INpgsqlBoxListboxListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[8],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var models2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                ((INpgsqlBoxListboxListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 134;
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                 ((INpgsqlBoxListboxListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                 ((INpgsqlBoxListboxListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[10],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxListboxListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[34], false);
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
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await ((INpgsqlBoxListboxListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxListboxListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 116;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                 ((INpgsqlBoxListboxListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
LEFT JOIN public.npgsqlboxboxlistd12mi mi ON mi.id = m.npgsqlboxboxlistd12mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
                var models = await((INpgsqlBoxListboxListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[31], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[32], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[33], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[1], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[2], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[3], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[4], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[5], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[6], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[7], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[8], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[9], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[10], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[11], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[12], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[13], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[14], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[15], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[16], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[17], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[18], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[18],_testData[19], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[19],_testData[20], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[20],_testData[21], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[21],_testData[22], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[22],_testData[23], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[23],_testData[24], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[24],_testData[25], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[25],_testData[26], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[26],_testData[27], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[27],_testData[28], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[28],_testData[29], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[29],_testData[30], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[30],_testData[31], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[31],_testData[32], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[32],_testData[33], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[33],_testData[34], false);
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
                var models = ((INpgsqlBoxListboxListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 97;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[14], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[15], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[16], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[17], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[18], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[19], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[20], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[21], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[22], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[23], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[24], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[25], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[26], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[27], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[28], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[29], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[30], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[31], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[18],_testData[32], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[19],_testData[33], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[21], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[22], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[23], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[24], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[25], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[26], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[27], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[28], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[29], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[30], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[31], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[32], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[33], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxListD1E2M), typeof(FlatNpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var models2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await((INpgsqlBoxListboxListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await ((INpgsqlBoxListboxListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 9, query1, 76, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await ((INpgsqlBoxListboxListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 132, query1, 97, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[13],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var models2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                ((INpgsqlBoxListboxListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                 ((INpgsqlBoxListboxListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 93, query1, 125, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                 ((INpgsqlBoxListboxListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 106, query1, 102, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[11],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxListboxListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxListboxListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 53, query1, 17, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[29],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                await ((INpgsqlBoxListboxListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 79, query1, 134, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxListboxListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxListboxListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 102, query1, 105, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
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
FROM public.npgsqlboxboxlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxListD1E2M>();
                 ((INpgsqlBoxListboxListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 98, query1, 125, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlBoxboxListD1E2M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.npgsqlboxboxlistd1e2m m
LEFT JOIN public.npgsqlboxboxlistd12mi mi ON mi.id = m.npgsqlboxboxlistd12mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
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
                var models = await((INpgsqlBoxListboxListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxListboxListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 69, 106))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[16], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[17], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[18], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[19], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[20], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[21], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[22], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[23], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[24], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[25], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[26], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[27], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[28], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[29], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[30], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[31], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[32], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[33], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[25], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[26], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[27], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[28], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[29], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[30], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[31], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[32], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[33], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[34], false);
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
                var models = ((INpgsqlBoxListboxListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlBoxboxListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxListboxListD1)this).DbConnectionSTSelectModelBatch(connection, 102, 97))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[23], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[24], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[25], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[26], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[27], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[28], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[29], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[30], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[31], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[32], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[33], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[21], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[22], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[23], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[24], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[25], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[26], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[27], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[28], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[29], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[30], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[31], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[32], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[33], false);
                        NpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[34], false);
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
                await using var cmd = await ((INpgsqlBoxListboxListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxListboxListD1)this).SetDbConnectionSelectModelParametrs(cmd, 69);
                var models = await ((INpgsqlBoxListboxListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(19));

                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[16], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[17], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[18], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[3],_testData[19], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[4],_testData[20], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[5],_testData[21], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[6],_testData[22], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[7],_testData[23], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[8],_testData[24], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[9],_testData[25], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[10],_testData[26], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[11],_testData[27], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[12],_testData[28], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[13],_testData[29], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[14],_testData[30], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[15],_testData[31], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[16],_testData[32], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[17],_testData[33], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxListboxListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxListboxListD1)this).SetDbConnectionSelectModelParametrs(cmd, 132);
                var models =  ((INpgsqlBoxListboxListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(3));

                NpgsqlBoxboxListD1E2M.AssertModel(models[0],_testData[32], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[1],_testData[33], false);
                NpgsqlBoxboxListD1E2M.AssertModel(models[2],_testData[34], false);
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
FROM public.binary_npgsqlboxboxlistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxListD12MIWA),
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxListD12MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxListboxListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxlistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxListboxListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxListD12MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxListboxListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxlistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxListboxListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxListD12MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxlistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxListD12MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxListD12MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxListboxListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxlistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlBoxListboxListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxListD12MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxListboxListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxlistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxListboxListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxListD12MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxlistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD12MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxlistd12mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxListD12MI),
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxListD12MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxListboxListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxListboxListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxListD12MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxListD12MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxListboxListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxListboxListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxListD12MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlboxboxlistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxlistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxListD12MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxListD12MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlBoxListboxListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlBoxListboxListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxListD12MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlBoxboxListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlBoxListboxListD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxListboxListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxListD12MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxboxlistd12mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlBoxboxListD1E2M),
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
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
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
FROM public.binary_npgsqlboxboxlistd1e2m m
LEFT JOIN public.binary_npgsqlboxboxlistd12mi mi ON mi.id = m.npgsqlboxboxlistd12mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlBoxboxListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlBoxListboxListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlBoxListboxListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlBoxboxListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlBoxListboxListD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxListboxListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlBoxboxListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxboxlistd12mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models =  ((INpgsqlBoxListboxListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxListboxListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD12MIWA), typeof(NpgsqlBoxboxListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models1 = new List<NpgsqlBoxboxListD12MIWA>();
                var models2 = new List<NpgsqlBoxboxListD12MIWA>();
                await ((INpgsqlBoxListboxListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxlistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxListD12MIWA>();
                var models2 = new List<NpgsqlBoxboxListD12MIWA>();
                ((INpgsqlBoxListboxListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxlistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models = await ((INpgsqlBoxListboxListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxlistd12mi
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
                    NpgsqlBoxboxListD12MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxListboxListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxlistd12mi
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
                    NpgsqlBoxboxListD12MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD12MIWA), typeof(NpgsqlBoxboxListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
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
                var models1 = new List<NpgsqlBoxboxListD12MIWA>();
                var models2 = new List<NpgsqlBoxboxListD12MIWA>();
                await ((INpgsqlBoxListboxListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxlistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxListD12MIWA>();
                var models2 = new List<NpgsqlBoxboxListD12MIWA>();
                ((INpgsqlBoxListboxListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlboxboxlistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
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
                var models = await ((INpgsqlBoxListboxListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlboxboxlistd12mi
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
                    NpgsqlBoxboxListD12MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxListboxListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlboxboxlistd12mi
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
                    NpgsqlBoxboxListD12MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxlistd12mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD12MI), typeof(NpgsqlBoxboxListD12MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models1 = new List<NpgsqlBoxboxListD12MI>();
                var models2 = new List<NpgsqlBoxboxListD12MI>();
                await ((INpgsqlBoxListboxListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxListD12MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxListD12MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxListD12MI>();
                var models2 = new List<NpgsqlBoxboxListD12MI>();
                ((INpgsqlBoxListboxListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxListD12MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxListD12MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxlistd12mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD12MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
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
                var models = await ((INpgsqlBoxListboxListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxListD12MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxListboxListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxListD12MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlboxboxlistd12mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD12MIWA), typeof(NpgsqlBoxboxListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
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
                var models1 = new List<NpgsqlBoxboxListD12MIWA>();
                var models2 = new List<NpgsqlBoxboxListD12MIWA>();
                await ((INpgsqlBoxListboxListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlBoxboxListD12MIWA>();
                var models2 = new List<NpgsqlBoxboxListD12MIWA>();
                ((INpgsqlBoxListboxListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlBoxboxListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlBoxboxListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxlistd12mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxListD1))]
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
                var models = await ((INpgsqlBoxListboxListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxListD12MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlBoxListboxListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxListD12MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

