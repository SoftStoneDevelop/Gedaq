

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
    internal partial interface INpgsqlCircleListcircleArray
    {
    }
    
    internal partial class NpgsqlCircleListcircleArray : INpgsqlCircleListcircleArray
    {


#region TestData

        private readonly NpgsqlCirclecircleArray2M[] _testData = new NpgsqlCirclecircleArray2M[]
        {
            new NpgsqlCirclecircleArray2M
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.950256945704121d, y: 0.5878827053337059d), radius: 0.6268887942572849d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7660247427396513d, y: 0.780754908041039d), radius: 0.37807852392848884d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8773597626290108d, y: 0.5291988146647217d), radius: 0.4836667407272084d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3625082509635428d, y: 0.44507252250963336d), radius: 0.578813244918276d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43326725938914357d, y: 0.8140259532705864d), radius: 0.7187120224723776d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14200896801402718d, y: 0.5452287871522766d), radius: 0.6446181735452902d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2988025282456416d, y: 0.002965695776803945d), radius: 0.09507392142073712d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5469759057707262d, y: 0.9562517465795867d), radius: 0.7409442663783828d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39205412884747304d, y: 0.5050570362087188d), radius: 0.27594182439172776d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8665312236401265d, y: 0.6849095932198752d), radius: 0.06582359199364596d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9923029630114388d, y: 0.7902289301485583d), radius: 0.2754812840905013d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9281387470718268d, y: 0.5039654656195806d), radius: 0.45363413503542416d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6394237305644761d, y: 0.772978704854663d), radius: 0.6244565066664036d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6148270425577718d, y: 0.40499203079620893d), radius: 0.9133864057488598d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42531940969127613d, y: 0.02079709979792388d), radius: 0.6645852725364378d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3194445852894604d, y: 0.4409679831996355d), radius: 0.9649823105740803d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07225589894392892d, y: 0.3162148294468178d), radius: 0.16727048185602733d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4833336116489869d, y: 0.01190698833793602d), radius: 0.682187418764869d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6555433883633351d, y: 0.35179016117557327d), radius: 0.8233672903340831d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06820072276097122d, y: 0.7729747274571535d), radius: 0.32296249574058566d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0943291789378441d, y: 0.6391816636631478d), radius: 0.49799514283026947d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6519106942124847d, y: 0.6728695283468212d), radius: 0.07090761023570658d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.327982630013984d, y: 0.07238632136657341d), radius: 0.6955564228221218d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9419395060668065d, y: 0.7008621804073893d), radius: 0.6621290633086578d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39677264962802516d, y: 0.8861940211719131d), radius: 0.43047651852180346d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5519278088452326d, y: 0.09317510088666825d), radius: 0.474226593500379d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45355464214745045d, y: 0.9984226401389878d), radius: 0.0718243663596394d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16179731536608621d, y: 0.8685667686298841d), radius: 0.9329132310311893d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5158333473468468d, y: 0.33531937017544766d), radius: 0.672748959087087d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4432818712451587d, y: 0.8558681000519703d), radius: 0.9254589874322843d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3264502734028685d, y: 0.022683061724802278d), radius: 0.3756865622241693d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09926608509904111d, y: 0.06465269959469999d), radius: 0.22079421636672192d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26548278993890195d, y: 0.5028415099050421d), radius: 0.16116817095735392d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08109180981971875d, y: 0.6815042391810189d), radius: 0.14552705235400787d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47767717775802876d, y: 0.7943040219126395d), radius: 0.6347319199252335d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8393940232683915d, y: 0.26196404729711364d), radius: 0.8291976903603697d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5891023699556688d, y: 0.08550247873372019d), radius: 0.024772099048251617d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6510202330202216d, y: 0.15462446996355306d), radius: 0.8001083621330047d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7856880178441532d, y: 0.528124795491852d), radius: 0.9963819288695753d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42618531126479764d, y: 0.2054105878018403d), radius: 0.5994193683325095d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.009098180838952974d, y: 0.5689312562922797d), radius: 0.8232373767323423d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27102541359746735d, y: 0.11333213676703835d), radius: 0.5500982788788323d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.538027774165385d, y: 0.6439900026239805d), radius: 0.7600401689899222d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6155597730363908d, y: 0.42108336142004654d), radius: 0.3323665972744436d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5174040896579823d, y: 0.6945042066100341d), radius: 0.4297622474394379d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1558711384604965d, y: 0.4954264984047444d), radius: 0.5112321382060551d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7652230180056593d, y: 0.11332269571003717d), radius: 0.9244153576966578d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3626549027499941d, y: 0.05308676573669824d), radius: 0.9624323465174102d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9293137742634423d, y: 0.8846575883605411d), radius: 0.5815860822793403d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.772225273179671d, y: 0.049367639873006186d), radius: 0.4640802036979187d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07583582535338118d, y: 0.1426998238610664d), radius: 0.415681355024771d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9653351113726764d, y: 0.2884266304056117d), radius: 0.00013056008581757705d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24153180021979326d, y: 0.7174074423034151d), radius: 0.37922639084531995d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.007030222845471279d, y: 0.4889260882992231d), radius: 0.08872260728085701d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3368012704323954d, y: 0.3695312708291134d), radius: 0.2856856445681908d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5089128643311062d, y: 0.9257493185784602d), radius: 0.3790547708441546d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15095533511325832d, y: 0.9528513756641094d), radius: 0.18559369827173933d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8348657982638962d, y: 0.25943327768651514d), radius: 0.5538892000683412d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8404486396780688d, y: 0.4403553802941351d), radius: 0.7461583425808204d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.530219425602598d, y: 0.6300808195599863d), radius: 0.3740580017268269d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9608892423704518d, y: 0.02411654884489567d), radius: 0.27035110204540025d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5326528597047512d, y: 0.880656699184037d), radius: 0.7476505650728319d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9862547079251927d, y: 0.377343763788914d), radius: 0.8992421718523553d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2609693390595974d, y: 0.06469141953243329d), radius: 0.4762265342472939d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.841897406513076d, y: 0.4544081427451242d), radius: 0.9282113684088773d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7683999259567101d, y: 0.8683680276140247d), radius: 0.7016761481724064d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3731301931049765d, y: 0.07860870191954572d), radius: 0.2750420118537078d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5408602545994952d, y: 0.6205425966836462d), radius: 0.2783846676419335d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27444594470975237d, y: 0.26330657793163825d), radius: 0.12394047233248107d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9681071669142113d, y: 0.782419210407712d), radius: 0.8592231341360428d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8760143444289867d, y: 0.8825480371380962d), radius: 0.5237678412111255d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07980061648784487d, y: 0.19881385063731016d), radius: 0.520255459078866d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3834751680070856d, y: 0.37088287111845286d), radius: 0.24694482312147115d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05464198428384237d, y: 0.17374453976903026d), radius: 0.3495570678591692d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6627733111766816d, y: 0.21388430245901424d), radius: 0.08510737081400943d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.014018695236062362d, y: 0.22910794704807913d), radius: 0.4891256306089835d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6288529541224435d, y: 0.04320796055490517d), radius: 0.5974563083017203d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.540218912655425d, y: 0.13944010722764422d), radius: 0.7168954884697428d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6083282944427194d, y: 0.6780921905011325d), radius: 0.6256048319202615d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.768746860062735d, y: 0.044425053279998905d), radius: 0.03202112530620993d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9245185182250778d, y: 0.4464531453753743d), radius: 0.34231177325445916d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5434102116088961d, y: 0.027758777288619862d), radius: 0.6369498242187783d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9715687049062779d, y: 0.21359235381028874d), radius: 0.8681820564985848d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44709305021325363d, y: 0.7460674993371147d), radius: 0.7217711298351547d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4237388111304784d, y: 0.7842055780251486d), radius: 0.18744745489457781d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9454572041149771d, y: 0.8021225363999117d), radius: 0.6538032706097808d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5497006455899173d, y: 0.6905873499777079d), radius: 0.28864205157027356d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5109187594734937d, y: 0.7368143366638735d), radius: 0.8997597679492269d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7481784308825215d, y: 0.08723064941796499d), radius: 0.3992794255215385d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8457495987852869d, y: 0.06916283241628707d), radius: 0.5935274574681465d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.763952009479544d, y: 0.30386018703714923d), radius: 0.28678322492260067d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6643003622206783d, y: 0.7984101634928921d), radius: 0.7474357127468628d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3626603275078907d, y: 0.35081234527813643d), radius: 0.7852349772838801d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.623552943602283d, y: 0.9933289909964512d), radius: 0.9768543306676891d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.661525387481098d, y: 0.7361471688809388d), radius: 0.379145925434892d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.734270033674927d, y: 0.7608502552655767d), radius: 0.7663649860842314d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48068761960911566d, y: 0.17231577125681696d), radius: 0.1881010270031277d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24495970518437804d, y: 0.28067042015357546d), radius: 0.28129906159210527d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8391838483753641d, y: 0.4411533851300955d), radius: 0.7918540023218112d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5442959147794114d, y: 0.5225028319958853d), radius: 0.26200927896803494d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07131554069498236d, y: 0.7209965868541719d), radius: 0.2855117459452905d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1847588879500549d, y: 0.057289867979181563d), radius: 0.5546022487171571d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3605497708200903d, y: 0.42590143947488945d), radius: 0.2691199163716397d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7625812150126668d, y: 0.5209140476596321d), radius: 0.5101068482331226d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5687342461116579d, y: 0.4134435655286115d), radius: 0.8247344148430178d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4411492548914968d, y: 0.5704767229805932d), radius: 0.6082218251816726d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6049379892717281d, y: 0.9817020036443141d), radius: 0.9244107065822631d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.004354430255556152d, y: 0.3091821094530952d), radius: 0.7062740321284451d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4546938159333477d, y: 0.3967227697235569d), radius: 0.850444809691162d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8613381369973248d, y: 0.5296121562504804d), radius: 0.8460031772023534d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.799624784393914d, y: 0.42040248183679796d), radius: 0.6064858106021077d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2873210969762744d, y: 0.32682707102061004d), radius: 0.09474785674043396d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2856775199959284d, y: 0.16066518360390913d), radius: 0.07394739099318814d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18783647171973872d, y: 0.37878339113291615d), radius: 0.8919806853089671d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0020034921672830164d, y: 0.38164116662317726d), radius: 0.0449464746895043d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2876477853607512d, y: 0.14268149785377415d), radius: 0.11373291744414249d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8986321486854617d, y: 0.8923272484714788d), radius: 0.7573549945488918d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.620010707472417d, y: 0.02403003561622663d), radius: 0.31643752388934754d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2369160086417288d, y: 0.9559360499227365d), radius: 0.09905131966883518d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7092358502256451d, y: 0.03845986245493749d), radius: 0.06621074334567234d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06950652738602026d, y: 0.8023373745355326d), radius: 0.25996148459624013d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5119759771628842d, y: 0.018409502073892248d), radius: 0.007885213927328993d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9181973243020228d, y: 0.6003555202734541d), radius: 0.4093067407975487d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.57320394360911d, y: 0.5330603244701749d), radius: 0.8371976928720554d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13924728363031813d, y: 0.927225003775349d), radius: 0.8355203950696746d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4334560719673175d, y: 0.5054119759688445d), radius: 0.945443461981446d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0325958556614756d, y: 0.020891856418217225d), radius: 0.974823259360719d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20806406553286738d, y: 0.40406946070381444d), radius: 0.40857037682349984d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7351531797998112d, y: 0.3681801326402393d), radius: 0.5476736085883613d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7006569625043136d, y: 0.12430658193294297d), radius: 0.683875169957107d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21727946606700999d, y: 0.6248092289665982d), radius: 0.6004228709761429d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45402840154313107d, y: 0.013308074959452298d), radius: 0.7229547563089855d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.006352411603981478d, y: 0.3709421382458794d), radius: 0.15618875457301107d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.254122265807357d, y: 0.9872824280565118d), radius: 0.05648403197777785d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20475388899326563d, y: 0.1906451494130409d), radius: 0.14702650282920715d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5020814086983886d, y: 0.8902416722456159d), radius: 0.312325084855133d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4371530895033704d, y: 0.46268580667379633d), radius: 0.25981920060982533d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6935686740961745d, y: 0.6836278385404826d), radius: 0.9422980566962187d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13892147920839126d, y: 0.8340779457382267d), radius: 0.20329651121500258d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39081828224939963d, y: 0.8961864484054217d), radius: 0.9730369217448583d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09595390568024098d, y: 0.34181707821621665d), radius: 0.2582177409377029d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8390239735478874d, y: 0.22386134502918464d), radius: 0.32311682763292293d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.026548746726560823d, y: 0.6004573507668313d), radius: 0.9839527353669321d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3295111451446062d, y: 0.8785881925725931d), radius: 0.6580403139148607d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41105057226475206d, y: 0.0011527243053504055d), radius: 0.7615397659452434d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.025667221819810404d, y: 0.7104456463953932d), radius: 0.8660597818908178d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.795830457779651d, y: 0.21019954323962053d), radius: 0.9740435368009166d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.489060913824651d, y: 0.13324241630237765d), radius: 0.8256442292535215d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6987861738142568d, y: 0.4546474821263976d), radius: 0.19774802469306796d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6140513505923649d, y: 0.3049215093049351d), radius: 0.8947452176976154d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6085462913508424d, y: 0.4635465084448279d), radius: 0.7647070765804279d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22147414788333974d, y: 0.7441804874545329d), radius: 0.30823300089023953d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1616240234675076d, y: 0.5902349915900007d), radius: 0.3968911392661775d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9713157370352693d, y: 0.45358310253695044d), radius: 0.5956802106071187d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5970352138614118d, y: 0.5386317139724572d), radius: 0.0512059712244306d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30139331618644527d, y: 0.14273612313098505d), radius: 0.23216770806602605d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.030832280526363665d, y: 0.16006842113839082d), radius: 0.09253642244313376d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9837828712770156d, y: 0.5975070477563739d), radius: 0.6206521177909303d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8957844773632335d, y: 0.2765886677108028d), radius: 0.38367779247364675d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7404815880070938d, y: 0.09184153032105236d), radius: 0.6990857654418688d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2800919361643559d, y: 0.6941169217820289d), radius: 0.36238574440697824d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5739537880750878d, y: 0.8992613869820416d), radius: 0.6052018467440844d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.898540199614939d, y: 0.6256885266138331d), radius: 0.9327957227494096d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9170458818811593d, y: 0.9453420010059645d), radius: 0.4354844356891082d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7388937896968055d, y: 0.14190649734852223d), radius: 0.6805276701457814d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47338823745845604d, y: 0.7090567640770568d), radius: 0.5846240396603316d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1574525300498434d, y: 0.7988749967264592d), radius: 0.31286041100320905d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17530428417366073d, y: 0.6193077831238688d), radius: 0.5593287201922176d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5559045730986524d, y: 0.5516384433629049d), radius: 0.512335304098843d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3471750271250874d, y: 0.20950431997998897d), radius: 0.3686252238850064d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.949575484339454d, y: 0.44798612960165785d), radius: 0.06839713330200425d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4540146036492312d, y: 0.3123426001560198d), radius: 0.4539747978501091d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5993272341878592d, y: 0.7821038384738374d), radius: 0.34042159304034925d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6499022076329495d, y: 0.03754733132823429d), radius: 0.21131577678399627d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39031927612610673d, y: 0.5085467339352384d), radius: 0.26877854056371264d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07743376589305906d, y: 0.9380824170355617d), radius: 0.04309730874681805d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8983742088220185d, y: 0.17232299439676757d), radius: 0.029524473993708167d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04299904978018709d, y: 0.8121411586303523d), radius: 0.26944701688327233d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9297493223484318d, y: 0.6034144305439921d), radius: 0.30240680415654553d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9687824023133774d, y: 0.6980074300102038d), radius: 0.87343531408546d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13349120310084028d, y: 0.35785187272063346d), radius: 0.8031093278216347d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8751924006719854d, y: 0.38032755717687716d), radius: 0.0958669239054607d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6456797185925723d, y: 0.44013728296224963d), radius: 0.21747460372491056d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9229579009111518d, y: 0.6740391852913528d), radius: 0.8774738380297339d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4349626087318632d, y: 0.16592924581165003d), radius: 0.6802910512248139d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6942755332332327d, y: 0.09767618032937986d), radius: 0.4154041399355539d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9717134138751063d, y: 0.6826881418097756d), radius: 0.9802190162221392d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.828100215213502d, y: 0.7531623249978696d), radius: 0.617962576655994d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.005524296763526504d, y: 0.883243146487624d), radius: 0.9492654572519873d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9654824448622007d, y: 0.4357650314957243d), radius: 0.861109890122888d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5572964274798513d, y: 0.14679087521770529d), radius: 0.6327285686013704d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8429422645641067d, y: 0.579363489550116d), radius: 0.9305908286835931d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2108665439958528d, y: 0.6778939694152362d), radius: 0.877788581994216d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9443651534020648d, y: 0.17577241362600315d), radius: 0.9694204502131057d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1520247718919795d, y: 0.8761475985657667d), radius: 0.23592544012800287d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6950361201377251d, y: 0.7150239447515048d), radius: 0.22406745942815653d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13480984611090063d, y: 0.19340113848699314d), radius: 0.55318564665938d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7245813180224473d, y: 0.21495369932622388d), radius: 0.644223688189166d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46349794808322886d, y: 0.8590708716377475d), radius: 0.6468414639242968d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7690371070751245d, y: 0.8241629253322549d), radius: 0.975332793908506d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23552662181659212d, y: 0.5545485472121005d), radius: 0.28236298707413165d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11462649797211932d, y: 0.654713043552211d), radius: 0.8200585289495412d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.329617885354209d, y: 0.7369983804041501d), radius: 0.26771597769322686d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.821238143160671d, y: 0.08170656789930697d), radius: 0.8625999534389176d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6676347593789669d, y: 0.8980000430126754d), radius: 0.9353628891353724d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5041357893285822d, y: 0.10852667259675819d), radius: 0.8509039051589822d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2977553277432651d, y: 0.9088649066697658d), radius: 0.43623619374114864d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1327068426611142d, y: 0.7227445866244838d), radius: 0.8049047739585553d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09817177963045554d, y: 0.2115146351999585d), radius: 0.2918168685517769d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16285626345723714d, y: 0.1410119219509618d), radius: 0.9537666491214626d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7513584639978903d, y: 0.5400857101581464d), radius: 0.7883350444769034d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6049536514645005d, y: 0.2205909635832367d), radius: 0.5239311658554565d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9094104280051931d, y: 0.419523967807788d), radius: 0.03133766085742118d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5709266411198344d, y: 0.6378344371721468d), radius: 0.8695710914641533d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7638602623680176d, y: 0.3376619143426226d), radius: 0.4536731766219255d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07185945763339796d, y: 0.04827466860422058d), radius: 0.28063134203207507d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7524505399809043d, y: 0.4125352733223818d), radius: 0.013398904282315827d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3625509667983373d, y: 0.11758003187209198d), radius: 0.09668615323300223d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2153218100785561d, y: 0.5177438831486364d), radius: 0.02986210991252858d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8582138275133288d, y: 0.8335691520038805d), radius: 0.09501222219052463d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1922448404058138d, y: 0.8424111707116246d), radius: 0.7189640390447632d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1431772913152336d, y: 0.690229590724169d), radius: 0.5622525462600942d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6276081583228131d, y: 0.5317019741907851d), radius: 0.886308031552207d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6129946078343049d, y: 0.28715834925903994d), radius: 0.9259657960679623d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7839529302310596d, y: 0.3852962180306082d), radius: 0.8318090049868966d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1993281643368d, y: 0.8260642837244023d), radius: 0.45149785699659306d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4157046650427284d, y: 0.2293271530049683d), radius: 0.22976381294553716d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3197032723821954d, y: 0.08260372219717582d), radius: 0.6954872273794684d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08438922691678619d, y: 0.9692786322704688d), radius: 0.07803386076457564d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4506080139453924d, y: 0.6398954783859837d), radius: 0.8478766920756089d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46777185287890566d, y: 0.6514925442557685d), radius: 0.8169939804537385d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5479994359809847d, y: 0.6172175879165908d), radius: 0.5591692475409621d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6840079616921428d, y: 0.6468451808735238d), radius: 0.826104513332787d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21716332933488336d, y: 0.06150914671663377d), radius: 0.7141756762851246d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8040789915898227d, y: 0.9545949258631103d), radius: 0.3096509918690461d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.551286030240953d, y: 0.18041138618875463d), radius: 0.40905970606969055d),

},
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray2mi(
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray2mi(
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
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
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

                changedRows =  ((INpgsqlCircleListcircleArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleListcircleArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray2m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray2mi_id
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclearray2mi_id", 
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
                changedRows =  ((INpgsqlCircleListcircleArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlCircleListcircleArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlCircleListcircleArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlCircleListcircleArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray2m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray2mi_id
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
    npgsqlcirclecirclearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray2m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray2mi_id
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
    npgsqlcirclecirclearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclearray2mi_id", 
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
                List<NpgsqlCirclecircleArray2M> models = null;

                models =  ((INpgsqlCircleListcircleArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlCircleListcircleArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlCircleListcircleArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlCircleListcircleArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleArray2M> models = null;

                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models = await ((INpgsqlCircleListcircleArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((INpgsqlCircleListcircleArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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

                var models = await ((INpgsqlCircleListcircleArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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

                var models =  ((INpgsqlCircleListcircleArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleListcircleArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlCircleListcircleArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
                var models = await ((INpgsqlCircleListcircleArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlCircleListcircleArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 126;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[24], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[25], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[26], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[27], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[28], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[28], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 3;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[11], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[12], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[13], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[14], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[15], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[16], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[17], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[18], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[19], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[20], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[21], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[22], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[23], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[24], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[25], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[26], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[27], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[28], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[1], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[2], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[3], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[4], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[5], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[6], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[7], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[8], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[9], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[10], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[11], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[12], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[13], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[14], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[15], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[16], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[17], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[18], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[19], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[20], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[21], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[22], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[23], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[24], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[25], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[26], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[27], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[27],_testData[28], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[28],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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

                var models = await ((INpgsqlCircleListcircleArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[4], false);NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[5], false);NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[6], false);NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[7], false);NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[8], false);NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[9], false);NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[10], false);NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[11], false);NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[12], false);NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[13], false);NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[14], false);NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[15], false);NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[16], false);NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[17], false);NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[18], false);NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[19], false);NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[20], false);NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[21], false);NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[22], false);NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[23], false);NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[24], false);NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[25], false);NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[26], false);NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[27], false);NpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[28], false);NpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[2], false);NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[3], false);NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[4], false);NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[5], false);NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[6], false);NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[7], false);NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[8], false);NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[9], false);NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[10], false);NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[11], false);NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[12], false);NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[13], false);NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[14], false);NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[15], false);NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[16], false);NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[17], false);NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[18], false);NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[19], false);NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[20], false);NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[21], false);NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[22], false);NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[23], false);NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[24], false);NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[25], false);NpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[26], false);NpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[27], false);NpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[28], false);NpgsqlCirclecircleArray2M.AssertModel(models[27],_testData[29], false);
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

                var models =  ((INpgsqlCircleListcircleArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[19], false);NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[20], false);NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[21], false);NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[22], false);NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[23], false);NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[24], false);NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[25], false);NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[26], false);NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[27], false);NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[28], false);NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[9], false);NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[10], false);NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[11], false);NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[12], false);NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[13], false);NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[14], false);NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[15], false);NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[16], false);NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[17], false);NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[18], false);NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[19], false);NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[20], false);NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[21], false);NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[22], false);NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[23], false);NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[24], false);NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[25], false);NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[26], false);NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[27], false);NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[28], false);NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 40, query1, 47, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[8], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[9], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[10], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[11], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[12], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[13], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[14], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[15], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[16], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[17], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[18], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[19], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[20], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[21], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[22], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[23], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[24], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[25], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[26], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[27], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[28], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[10], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[11], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[12], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[13], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[14], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[15], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[16], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[17], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[18], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[19], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[20], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[21], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[22], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[23], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[24], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[25], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[26], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[27], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[28], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelBatch(connection, 26, query1, 123, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[4], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[5], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[6], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[7], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[8], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[9], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[10], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[11], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[12], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[13], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[14], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[15], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[16], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[17], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[18], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[19], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[20], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[21], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[22], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[23], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[24], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[25], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[26], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[27], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[28], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[27], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[28], false);FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[29], false);
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
                var models = await ((INpgsqlCircleListcircleArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSelectModelBatchAsync(connection, 18, 55))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[3], false);NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[4], false);NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[5], false);NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[6], false);NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[7], false);NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[8], false);NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[9], false);NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[10], false);NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[11], false);NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[12], false);NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[13], false);NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[14], false);NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[15], false);NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[16], false);NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[17], false);NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[18], false);NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[19], false);NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[20], false);NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[21], false);NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[22], false);NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[23], false);NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[24], false);NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[25], false);NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[26], false);NpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[27], false);NpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[28], false);NpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[11], false);NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[12], false);NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[13], false);NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[14], false);NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[15], false);NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[16], false);NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[17], false);NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[18], false);NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[19], false);NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[20], false);NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[21], false);NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[22], false);NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[23], false);NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[24], false);NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[25], false);NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[26], false);NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[27], false);NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[28], false);NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[29], false);
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
                var models =  ((INpgsqlCircleListcircleArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSelectModelBatch(connection, 89, 18))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[19], false);NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[20], false);NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[21], false);NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[22], false);NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[23], false);NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[24], false);NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[25], false);NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[26], false);NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[27], false);NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[28], false);NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[3], false);NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[4], false);NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[5], false);NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[6], false);NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[7], false);NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[8], false);NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[9], false);NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[10], false);NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[11], false);NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[12], false);NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[13], false);NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[14], false);NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[15], false);NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[16], false);NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[17], false);NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[18], false);NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[19], false);NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[20], false);NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[21], false);NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[22], false);NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[23], false);NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[24], false);NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[25], false);NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[26], false);NpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[27], false);NpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[28], false);NpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[29], false);
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
                await using var cmd = await ((INpgsqlCircleListcircleArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlCircleListcircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 55);
                var models = await ((INpgsqlCircleListcircleArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(19));
NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[11], false);NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[12], false);NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[13], false);NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[14], false);NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[15], false);NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[16], false);NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[17], false);NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[18], false);NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[19], false);NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[20], false);NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[21], false);NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[22], false);NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[23], false);NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[24], false);NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[25], false);NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[26], false);NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[27], false);NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[28], false);NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleListcircleArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleListcircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 120);
                var models =  ((INpgsqlCircleListcircleArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(4));
NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[26], false);NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[27], false);NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[28], false);NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MI)],
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
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
FROM public.binary_npgsqlcirclecirclearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlCirclecircleArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlCircleListcircleArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleListcircleArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlCircleListcircleArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlCircleListcircleArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlcirclecirclearray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
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
FROM public.binary_npgsqlcirclecirclearray2m m
LEFT JOIN public.binary_npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlCirclecircleArray2M>(15);

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
                ((INpgsqlCircleListcircleArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleListcircleArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlCircleListcircleArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlCircleListcircleArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[14], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[15], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[16], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[17], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[18], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[19], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[20], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[21], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[22], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[23], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[24], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[25], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[26], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[27],_testData[27], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[28],_testData[28], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlcirclecirclearray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlCircleListcircleArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleListcircleArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MI)],
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlCircleListcircleArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleListcircleArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

