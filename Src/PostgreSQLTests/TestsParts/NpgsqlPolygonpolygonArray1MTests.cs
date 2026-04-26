

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
    internal partial interface INpgsqlPolygonArraypolygonArray
    {
    }
    
    internal partial class NpgsqlPolygonArraypolygonArray : INpgsqlPolygonArraypolygonArray
    {


#region TestData

        private readonly NpgsqlPolygonpolygonArray1M[] _testData = new NpgsqlPolygonpolygonArray1M[]
        {
            new NpgsqlPolygonpolygonArray1M
{
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6408162944797187d, y: 0.9076577682407148d), new NpgsqlTypes.NpgsqlPoint(x: 0.09638624746957203d, y: 0.8769194722514514d), new NpgsqlTypes.NpgsqlPoint(x: 0.7840961345493606d, y: 0.6221214177785019d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9524557496430877d, y: 0.8284803589319716d), new NpgsqlTypes.NpgsqlPoint(x: 0.28593426766817776d, y: 0.2668342550474281d), new NpgsqlTypes.NpgsqlPoint(x: 0.5153355429055141d, y: 0.3102799838169563d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8900375847269257d, y: 0.9342004457360599d), new NpgsqlTypes.NpgsqlPoint(x: 0.4841687308401095d, y: 0.277263131729792d), new NpgsqlTypes.NpgsqlPoint(x: 0.44124998111226477d, y: 0.4299673616093832d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8745715035108109d, y: 0.05015434293568488d), new NpgsqlTypes.NpgsqlPoint(x: 0.09742662095239518d, y: 0.9450979228907207d), new NpgsqlTypes.NpgsqlPoint(x: 0.47301488566878847d, y: 0.8028737213212451d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40586157437632475d, y: 0.1877514232940598d), new NpgsqlTypes.NpgsqlPoint(x: 0.9230564411712969d, y: 0.8007934208081859d), new NpgsqlTypes.NpgsqlPoint(x: 0.9488905557452856d, y: 0.383268059885851d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6895076033120895d, y: 0.9323002149388374d), new NpgsqlTypes.NpgsqlPoint(x: 0.5683904573435753d, y: 0.7044037233860106d), new NpgsqlTypes.NpgsqlPoint(x: 0.5444026325493065d, y: 0.5979735208278054d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3062858691196215d, y: 0.36216563890152464d), new NpgsqlTypes.NpgsqlPoint(x: 0.218057461034318d, y: 0.13127976952984943d), new NpgsqlTypes.NpgsqlPoint(x: 0.8722797142508137d, y: 0.06040742752649486d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9052116829537374d, y: 0.8766139012558345d), new NpgsqlTypes.NpgsqlPoint(x: 0.5418251248336485d, y: 0.7698197160083436d), new NpgsqlTypes.NpgsqlPoint(x: 0.007036158368474044d, y: 0.498690412366828d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9744890729749879d, y: 0.5740479018469556d), new NpgsqlTypes.NpgsqlPoint(x: 0.229154752156299d, y: 0.06843047727557017d), new NpgsqlTypes.NpgsqlPoint(x: 0.20472140345590595d, y: 0.09189311900516295d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4896880333349707d, y: 0.37882261654292415d), new NpgsqlTypes.NpgsqlPoint(x: 0.10259049621324967d, y: 0.5931529043133031d), new NpgsqlTypes.NpgsqlPoint(x: 0.657542216637737d, y: 0.6605572113605209d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8381579991444607d, y: 0.44281411536878057d), new NpgsqlTypes.NpgsqlPoint(x: 0.07758876264468861d, y: 0.2072177783168695d), new NpgsqlTypes.NpgsqlPoint(x: 0.34321677327618527d, y: 0.29141357142473967d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6941238951737772d, y: 0.8117651879374373d), new NpgsqlTypes.NpgsqlPoint(x: 0.9476089810631149d, y: 0.217722814208285d), new NpgsqlTypes.NpgsqlPoint(x: 0.954179185066239d, y: 0.39890595864259715d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6774479137161397d, y: 0.7363996857347063d), new NpgsqlTypes.NpgsqlPoint(x: 0.25515447845204187d, y: 0.2592317813756242d), new NpgsqlTypes.NpgsqlPoint(x: 0.6388128662815408d, y: 0.4978623237288704d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05054873351333755d, y: 0.3120291022035784d), new NpgsqlTypes.NpgsqlPoint(x: 0.47654951713393157d, y: 0.571816297043104d), new NpgsqlTypes.NpgsqlPoint(x: 0.9292957418050438d, y: 0.1649881361515826d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7762485496931272d, y: 0.5361134427154962d), new NpgsqlTypes.NpgsqlPoint(x: 0.9352920505493942d, y: 0.46622495697406197d), new NpgsqlTypes.NpgsqlPoint(x: 0.1257423864945577d, y: 0.24364168151437426d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43656056373988483d, y: 0.17870798030410207d), new NpgsqlTypes.NpgsqlPoint(x: 0.7295398108773254d, y: 0.2929492324900935d), new NpgsqlTypes.NpgsqlPoint(x: 0.6750733625163003d, y: 0.9818152673758163d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6112626397701155d, y: 0.9358701375049163d), new NpgsqlTypes.NpgsqlPoint(x: 0.9591459236078884d, y: 0.053592022572491405d), new NpgsqlTypes.NpgsqlPoint(x: 0.8659638755771351d, y: 0.058440212439019645d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9986710760706974d, y: 0.6189873091659764d), new NpgsqlTypes.NpgsqlPoint(x: 0.18627469014780573d, y: 0.4118479321296932d), new NpgsqlTypes.NpgsqlPoint(x: 0.6202625437461278d, y: 0.06138136333379873d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4665070577200483d, y: 0.31514648273824775d), new NpgsqlTypes.NpgsqlPoint(x: 0.6551141486642921d, y: 0.7578227532224958d), new NpgsqlTypes.NpgsqlPoint(x: 0.7658323414252478d, y: 0.0411162950224957d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40696027765564813d, y: 0.8498117550369002d), new NpgsqlTypes.NpgsqlPoint(x: 0.9219811230626913d, y: 0.19135960452908618d), new NpgsqlTypes.NpgsqlPoint(x: 0.42049717784001217d, y: 0.2548833173186038d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04891448033078938d, y: 0.11389988098265813d), new NpgsqlTypes.NpgsqlPoint(x: 0.9058949418575202d, y: 0.6293434509066994d), new NpgsqlTypes.NpgsqlPoint(x: 0.7708800593767341d, y: 0.024314453235714906d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9862198095745656d, y: 0.03885852964105685d), new NpgsqlTypes.NpgsqlPoint(x: 0.6619284969566982d, y: 0.20799156917345019d), new NpgsqlTypes.NpgsqlPoint(x: 0.4781242049254062d, y: 0.5959706865692002d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8442259171625506d, y: 0.12907089314966014d), new NpgsqlTypes.NpgsqlPoint(x: 0.051810575142913984d, y: 0.14067819717023222d), new NpgsqlTypes.NpgsqlPoint(x: 0.7482526867165611d, y: 0.5676522814099128d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8329693578588241d, y: 0.679935319057617d), new NpgsqlTypes.NpgsqlPoint(x: 0.18703914303061697d, y: 0.0403074400842387d), new NpgsqlTypes.NpgsqlPoint(x: 0.11925097950455488d, y: 0.7341326016819192d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9676792621109981d, y: 0.5980078646271557d), new NpgsqlTypes.NpgsqlPoint(x: 0.18618691685674482d, y: 0.33832622084747577d), new NpgsqlTypes.NpgsqlPoint(x: 0.02816292654926511d, y: 0.9515375996585768d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5812724915667106d, y: 0.1419730196340513d), new NpgsqlTypes.NpgsqlPoint(x: 0.0009724840563283266d, y: 0.6078518779143948d), new NpgsqlTypes.NpgsqlPoint(x: 0.06276527554214761d, y: 0.3610227115174375d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6579578860960027d, y: 0.6086142350916987d), new NpgsqlTypes.NpgsqlPoint(x: 0.7177172884360083d, y: 0.6721881360814196d), new NpgsqlTypes.NpgsqlPoint(x: 0.9861358111162721d, y: 0.8989870620847384d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9019364285415779d, y: 0.7731295469222497d), new NpgsqlTypes.NpgsqlPoint(x: 0.589080937943074d, y: 0.26060198680413227d), new NpgsqlTypes.NpgsqlPoint(x: 0.11169774304461022d, y: 0.15004898732639282d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5675643284349572d, y: 0.5874539645294392d), new NpgsqlTypes.NpgsqlPoint(x: 0.4826972807990939d, y: 0.5097176952733173d), new NpgsqlTypes.NpgsqlPoint(x: 0.509811005773676d, y: 0.1368990351228313d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12300108437434776d, y: 0.13873039937749287d), new NpgsqlTypes.NpgsqlPoint(x: 0.5778388368971417d, y: 0.2220971734666526d), new NpgsqlTypes.NpgsqlPoint(x: 0.009525546770633997d, y: 0.475994918674703d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6637638900045819d, y: 0.012665827117268602d), new NpgsqlTypes.NpgsqlPoint(x: 0.024543674818666594d, y: 0.5806099945073027d), new NpgsqlTypes.NpgsqlPoint(x: 0.10459240754432297d, y: 0.4600579005159535d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9514028664637304d, y: 0.9087849913757374d), new NpgsqlTypes.NpgsqlPoint(x: 0.5078084133260091d, y: 0.1561488086117474d), new NpgsqlTypes.NpgsqlPoint(x: 0.011519111206781285d, y: 0.11427454755259803d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8067629918880375d, y: 0.8907693543215088d), new NpgsqlTypes.NpgsqlPoint(x: 0.4064639519709343d, y: 0.3428830734867505d), new NpgsqlTypes.NpgsqlPoint(x: 0.8729943166447087d, y: 0.047240468044844275d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33053010257387894d, y: 0.1497855379288474d), new NpgsqlTypes.NpgsqlPoint(x: 0.30424717486079034d, y: 0.9275527179038691d), new NpgsqlTypes.NpgsqlPoint(x: 0.3255087739588567d, y: 0.8598229434414798d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0764052380614455d, y: 0.16284899542236275d), new NpgsqlTypes.NpgsqlPoint(x: 0.23240815556894856d, y: 0.8720968189442698d), new NpgsqlTypes.NpgsqlPoint(x: 0.5155699554928449d, y: 0.36052021133602763d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4856647470634613d, y: 0.7035054624546142d), new NpgsqlTypes.NpgsqlPoint(x: 0.5355948928579239d, y: 0.5416519133781078d), new NpgsqlTypes.NpgsqlPoint(x: 0.863237997877673d, y: 0.1634182299761634d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5243171445851778d, y: 0.14771025256372616d), new NpgsqlTypes.NpgsqlPoint(x: 0.33502237625478415d, y: 0.8725287825334545d), new NpgsqlTypes.NpgsqlPoint(x: 0.5843967539543277d, y: 0.6306643243236333d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6189720488215943d, y: 0.3460234539822443d), new NpgsqlTypes.NpgsqlPoint(x: 0.6699053085367564d, y: 0.6317766929949999d), new NpgsqlTypes.NpgsqlPoint(x: 0.5035522726547372d, y: 0.25622820642544475d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18314714273294952d, y: 0.3734367465445494d), new NpgsqlTypes.NpgsqlPoint(x: 0.329466865302367d, y: 0.6228768160349096d), new NpgsqlTypes.NpgsqlPoint(x: 0.9526833929770386d, y: 0.02708412070991917d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47022820446832125d, y: 0.9804501126257981d), new NpgsqlTypes.NpgsqlPoint(x: 0.24923603428191843d, y: 0.3499519900465148d), new NpgsqlTypes.NpgsqlPoint(x: 0.4851518746798419d, y: 0.5395337507543297d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17489136088705237d, y: 0.7510530266180058d), new NpgsqlTypes.NpgsqlPoint(x: 0.9765150050210158d, y: 0.38205809559668125d), new NpgsqlTypes.NpgsqlPoint(x: 0.18761308320439063d, y: 0.05271568315860309d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.899860534833887d, y: 0.5571951397176268d), new NpgsqlTypes.NpgsqlPoint(x: 0.2184082977676053d, y: 0.6580461339011464d), new NpgsqlTypes.NpgsqlPoint(x: 0.19646561292637965d, y: 0.9817250221529704d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5802996280312225d, y: 0.9407095215313941d), new NpgsqlTypes.NpgsqlPoint(x: 0.5621717289137905d, y: 0.3708175470652607d), new NpgsqlTypes.NpgsqlPoint(x: 0.8103262970477383d, y: 0.7269550064023754d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6188514128849111d, y: 0.042918689807393995d), new NpgsqlTypes.NpgsqlPoint(x: 0.054138583565646936d, y: 0.42640548062639816d), new NpgsqlTypes.NpgsqlPoint(x: 0.38378352995540554d, y: 0.2504364665384978d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5271169685516055d, y: 0.5909352517468768d), new NpgsqlTypes.NpgsqlPoint(x: 0.9525342431224122d, y: 0.1611624428567454d), new NpgsqlTypes.NpgsqlPoint(x: 0.4090884157492468d, y: 0.8823187661787216d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28387382120928484d, y: 0.2960071887182295d), new NpgsqlTypes.NpgsqlPoint(x: 0.615101183517593d, y: 0.44463697072135366d), new NpgsqlTypes.NpgsqlPoint(x: 0.6098312725417411d, y: 0.7403477796786955d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49739536253153926d, y: 0.8094902993385967d), new NpgsqlTypes.NpgsqlPoint(x: 0.4436039326351734d, y: 0.8941677780275825d), new NpgsqlTypes.NpgsqlPoint(x: 0.7867823124922149d, y: 0.8771390138830496d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9194618787202131d, y: 0.7703502155404088d), new NpgsqlTypes.NpgsqlPoint(x: 0.7562303475588965d, y: 0.5471446085612466d), new NpgsqlTypes.NpgsqlPoint(x: 0.8254468774920513d, y: 0.9172999735529377d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45708010612943994d, y: 0.03683302924065768d), new NpgsqlTypes.NpgsqlPoint(x: 0.010963389585711414d, y: 0.40310579850164396d), new NpgsqlTypes.NpgsqlPoint(x: 0.6895585059177066d, y: 0.13832559942863387d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4841637079635599d, y: 0.4168373736162133d), new NpgsqlTypes.NpgsqlPoint(x: 0.468287696300805d, y: 0.8919558514994168d), new NpgsqlTypes.NpgsqlPoint(x: 0.826551282034115d, y: 0.3743449040279019d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26169763986559813d, y: 0.6913228193639307d), new NpgsqlTypes.NpgsqlPoint(x: 0.22021396336828736d, y: 0.3577582103272009d), new NpgsqlTypes.NpgsqlPoint(x: 0.7754099951727951d, y: 0.5696080507543863d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8131415294952272d, y: 0.055923375686055654d), new NpgsqlTypes.NpgsqlPoint(x: 0.9973230470380143d, y: 0.5239282011863614d), new NpgsqlTypes.NpgsqlPoint(x: 0.13795583181964366d, y: 0.9389091700440819d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.006456047133355347d, y: 0.27041817824508674d), new NpgsqlTypes.NpgsqlPoint(x: 0.22277749223801224d, y: 0.20966319248653165d), new NpgsqlTypes.NpgsqlPoint(x: 0.14234208585584807d, y: 0.3108961703840464d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2900279827691813d, y: 0.9153301601394362d), new NpgsqlTypes.NpgsqlPoint(x: 0.8281415727072723d, y: 0.7734775675808915d), new NpgsqlTypes.NpgsqlPoint(x: 0.5857020400569735d, y: 0.33127957451782386d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39991502455618344d, y: 0.32261439039414863d), new NpgsqlTypes.NpgsqlPoint(x: 0.3104218480719383d, y: 0.5793458249386387d), new NpgsqlTypes.NpgsqlPoint(x: 0.4681949356763154d, y: 0.15395476177468448d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48172003272573216d, y: 0.3355743059216013d), new NpgsqlTypes.NpgsqlPoint(x: 0.37882385879871994d, y: 0.8465392185418141d), new NpgsqlTypes.NpgsqlPoint(x: 0.965203402687102d, y: 0.6659791475835035d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9112480136841232d, y: 0.4171734642338618d), new NpgsqlTypes.NpgsqlPoint(x: 0.7208491421350713d, y: 0.2997244457680498d), new NpgsqlTypes.NpgsqlPoint(x: 0.6367213157346474d, y: 0.9197290356082815d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4597377882966138d, y: 0.1523923704310136d), new NpgsqlTypes.NpgsqlPoint(x: 0.13222838491983913d, y: 0.43264682225906914d), new NpgsqlTypes.NpgsqlPoint(x: 0.5477431338557314d, y: 0.9408474893057429d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16042351249123699d, y: 0.9626311150490995d), new NpgsqlTypes.NpgsqlPoint(x: 0.25551840429978734d, y: 0.237410707849679d), new NpgsqlTypes.NpgsqlPoint(x: 0.7201764513929365d, y: 0.2449687548643391d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6020543333670371d, y: 0.3175840141008811d), new NpgsqlTypes.NpgsqlPoint(x: 0.29202188962897213d, y: 0.4064058928554253d), new NpgsqlTypes.NpgsqlPoint(x: 0.4322122934434357d, y: 0.18468435157047924d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9655371717650378d, y: 0.8122743836005288d), new NpgsqlTypes.NpgsqlPoint(x: 0.5044427316840496d, y: 0.005962670302676276d), new NpgsqlTypes.NpgsqlPoint(x: 0.9738444257372365d, y: 0.6264932205236831d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38038374617861836d, y: 0.6298991754013953d), new NpgsqlTypes.NpgsqlPoint(x: 0.18136607908412306d, y: 0.2098848891947912d), new NpgsqlTypes.NpgsqlPoint(x: 0.514590648112927d, y: 0.4875950189312458d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9029546450430953d, y: 0.4810464504971097d), new NpgsqlTypes.NpgsqlPoint(x: 0.14515002111973074d, y: 0.3110675063220997d), new NpgsqlTypes.NpgsqlPoint(x: 0.7819632869982173d, y: 0.11744740927307651d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5740371199221217d, y: 0.7569060556468739d), new NpgsqlTypes.NpgsqlPoint(x: 0.22713765935444807d, y: 0.5549015495197522d), new NpgsqlTypes.NpgsqlPoint(x: 0.5950107559746346d, y: 0.3765524106259499d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5002888781539276d, y: 0.01608910698613697d), new NpgsqlTypes.NpgsqlPoint(x: 0.5822348945359691d, y: 0.03863960483277762d), new NpgsqlTypes.NpgsqlPoint(x: 0.9646949070651492d, y: 0.4195505163814265d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7068786028022321d, y: 0.604222933681686d), new NpgsqlTypes.NpgsqlPoint(x: 0.40493612430287096d, y: 0.38842326607989763d), new NpgsqlTypes.NpgsqlPoint(x: 0.0438412812653356d, y: 0.9981449980949382d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7106198303930481d, y: 0.09679240257917121d), new NpgsqlTypes.NpgsqlPoint(x: 0.2659217642299294d, y: 0.5597902126818004d), new NpgsqlTypes.NpgsqlPoint(x: 0.7702840213123338d, y: 0.5013575319285958d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03472204686040947d, y: 0.5940403483213637d), new NpgsqlTypes.NpgsqlPoint(x: 0.47806337989899905d, y: 0.9001973512186615d), new NpgsqlTypes.NpgsqlPoint(x: 0.28680141430894424d, y: 0.4260636081349881d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8403591386012184d, y: 0.8780916189240286d), new NpgsqlTypes.NpgsqlPoint(x: 0.40219046667432656d, y: 0.7727859428351301d), new NpgsqlTypes.NpgsqlPoint(x: 0.9553734804361892d, y: 0.4527100698696609d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7418712029972009d, y: 0.8008690459646391d), new NpgsqlTypes.NpgsqlPoint(x: 0.9139284383447408d, y: 0.13049372725067143d), new NpgsqlTypes.NpgsqlPoint(x: 0.7323227086418601d, y: 0.07150625788652676d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9610456865160383d, y: 0.5112936128546787d), new NpgsqlTypes.NpgsqlPoint(x: 0.8599842351404211d, y: 0.9465762012042153d), new NpgsqlTypes.NpgsqlPoint(x: 0.9085892648970071d, y: 0.582506683891487d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4001428169277197d, y: 0.9323051305465333d), new NpgsqlTypes.NpgsqlPoint(x: 0.22968792906269386d, y: 0.8807701543442841d), new NpgsqlTypes.NpgsqlPoint(x: 0.2809144120874768d, y: 0.8263206482533767d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7548236286403632d, y: 0.5690213474390176d), new NpgsqlTypes.NpgsqlPoint(x: 0.9031900576841068d, y: 0.5169175778975547d), new NpgsqlTypes.NpgsqlPoint(x: 0.5190457101424131d, y: 0.07720687042550811d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9845327468482113d, y: 0.282489154169311d), new NpgsqlTypes.NpgsqlPoint(x: 0.672784393287977d, y: 0.8093690082034916d), new NpgsqlTypes.NpgsqlPoint(x: 0.49707783489638013d, y: 0.8214674086835473d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8491141184065825d, y: 0.08902195867662333d), new NpgsqlTypes.NpgsqlPoint(x: 0.10773804213798999d, y: 0.761372304260455d), new NpgsqlTypes.NpgsqlPoint(x: 0.14505455811102796d, y: 0.06557483343078918d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0400115618061202d, y: 0.09103437321886143d), new NpgsqlTypes.NpgsqlPoint(x: 0.2080708880435177d, y: 0.008243451788070177d), new NpgsqlTypes.NpgsqlPoint(x: 0.5986691600560229d, y: 0.7123374898475119d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7713964538870373d, y: 0.04250415053878909d), new NpgsqlTypes.NpgsqlPoint(x: 0.2932992226115184d, y: 0.3444493868343518d), new NpgsqlTypes.NpgsqlPoint(x: 0.16196753707727762d, y: 0.12824738448334783d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7899917273133346d, y: 0.43959478379608863d), new NpgsqlTypes.NpgsqlPoint(x: 0.6929193641597117d, y: 0.44162960167371657d), new NpgsqlTypes.NpgsqlPoint(x: 0.7584817121759626d, y: 0.6894311163503036d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7189566315979657d, y: 0.9259929631289407d), new NpgsqlTypes.NpgsqlPoint(x: 0.9716082496163737d, y: 0.4800941446018099d), new NpgsqlTypes.NpgsqlPoint(x: 0.200109897256323d, y: 0.35602552782468744d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4295767186392484d, y: 0.5976291641679596d), new NpgsqlTypes.NpgsqlPoint(x: 0.6412476488361973d, y: 0.13196448177860587d), new NpgsqlTypes.NpgsqlPoint(x: 0.322468288678494d, y: 0.6258616042453694d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.055803227317101745d, y: 0.5338753148665644d), new NpgsqlTypes.NpgsqlPoint(x: 0.22439146546804d, y: 0.03951569283449252d), new NpgsqlTypes.NpgsqlPoint(x: 0.5517340095350447d, y: 0.19295502311574064d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14760301099501028d, y: 0.31382637594808105d), new NpgsqlTypes.NpgsqlPoint(x: 0.8443510560345017d, y: 0.3896879719776871d), new NpgsqlTypes.NpgsqlPoint(x: 0.05456155490806924d, y: 0.2985704523984273d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6158728953938314d, y: 0.6806232724015469d), new NpgsqlTypes.NpgsqlPoint(x: 0.8322974079779002d, y: 0.9779971562352296d), new NpgsqlTypes.NpgsqlPoint(x: 0.4137700717493138d, y: 0.46021009932809964d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8134891109196363d, y: 0.6379438922886198d), new NpgsqlTypes.NpgsqlPoint(x: 0.8623413249065471d, y: 0.9968716126605428d), new NpgsqlTypes.NpgsqlPoint(x: 0.18873716048332467d, y: 0.3091015490843617d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3677810148750177d, y: 0.06810565408328939d), new NpgsqlTypes.NpgsqlPoint(x: 0.637260594079107d, y: 0.2507402108806275d), new NpgsqlTypes.NpgsqlPoint(x: 0.6441949659295159d, y: 0.3348497102321062d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49409123891796813d, y: 0.8090605251561953d), new NpgsqlTypes.NpgsqlPoint(x: 0.3004738682257825d, y: 0.5697632964034365d), new NpgsqlTypes.NpgsqlPoint(x: 0.778376118001906d, y: 0.8994293810413838d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1677003293551047d, y: 0.9084312508975245d), new NpgsqlTypes.NpgsqlPoint(x: 0.9616486979244169d, y: 0.03211844893069371d), new NpgsqlTypes.NpgsqlPoint(x: 0.7373502160772519d, y: 0.6228855187197688d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6810387606734859d, y: 0.11749185906407122d), new NpgsqlTypes.NpgsqlPoint(x: 0.2498316529404606d, y: 0.5096522523329909d), new NpgsqlTypes.NpgsqlPoint(x: 0.9415286886314139d, y: 0.956572950353585d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12863324978926904d, y: 0.6027525648207664d), new NpgsqlTypes.NpgsqlPoint(x: 0.9760516473056692d, y: 0.9030329215208026d), new NpgsqlTypes.NpgsqlPoint(x: 0.6131643748362903d, y: 0.14539250463998288d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8776753336157411d, y: 0.4927013824864005d), new NpgsqlTypes.NpgsqlPoint(x: 0.07782286841043995d, y: 0.66751659815979d), new NpgsqlTypes.NpgsqlPoint(x: 0.02050163488378065d, y: 0.061843582832665556d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3625214610335894d, y: 0.7457363785513542d), new NpgsqlTypes.NpgsqlPoint(x: 0.5905369309783236d, y: 0.4943731895562974d), new NpgsqlTypes.NpgsqlPoint(x: 0.014316338017813512d, y: 0.9296536604825152d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.505236511741713d, y: 0.9262085941691393d), new NpgsqlTypes.NpgsqlPoint(x: 0.4312711670597482d, y: 0.22123113000964523d), new NpgsqlTypes.NpgsqlPoint(x: 0.8393481249947787d, y: 0.9637023347116218d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22004343529736592d, y: 0.942444226627895d), new NpgsqlTypes.NpgsqlPoint(x: 0.5196061496810703d, y: 0.2822867939675203d), new NpgsqlTypes.NpgsqlPoint(x: 0.5144029349306113d, y: 0.3678033184834396d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0748198540969679d, y: 0.6893313114493815d), new NpgsqlTypes.NpgsqlPoint(x: 0.10788382293864496d, y: 0.23358603880996787d), new NpgsqlTypes.NpgsqlPoint(x: 0.9366388741769764d, y: 0.14861828465537685d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23302521052228453d, y: 0.9183535534396878d), new NpgsqlTypes.NpgsqlPoint(x: 0.2766099557807441d, y: 0.9969930610746832d), new NpgsqlTypes.NpgsqlPoint(x: 0.4848704579975506d, y: 0.5284127404458677d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3555160353342245d, y: 0.06623697924388572d), new NpgsqlTypes.NpgsqlPoint(x: 0.8272025164055552d, y: 0.019091822972213457d), new NpgsqlTypes.NpgsqlPoint(x: 0.07049973222857231d, y: 0.8742797766380548d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8893224779511156d, y: 0.36349020679347377d), new NpgsqlTypes.NpgsqlPoint(x: 0.7912825592256019d, y: 0.09220058034360401d), new NpgsqlTypes.NpgsqlPoint(x: 0.7187392979558584d, y: 0.029612612024826346d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19883507654251875d, y: 0.13085538611274017d), new NpgsqlTypes.NpgsqlPoint(x: 0.7439740094425221d, y: 0.7763712952628785d), new NpgsqlTypes.NpgsqlPoint(x: 0.6455193999350912d, y: 0.35366447706540505d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9405824299071159d, y: 0.8951902492726422d), new NpgsqlTypes.NpgsqlPoint(x: 0.9749342808410064d, y: 0.8390428219997297d), new NpgsqlTypes.NpgsqlPoint(x: 0.5786119493877271d, y: 0.7622381032682933d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5111913824659011d, y: 0.8201657545140709d), new NpgsqlTypes.NpgsqlPoint(x: 0.07385115302537071d, y: 0.7990639751852463d), new NpgsqlTypes.NpgsqlPoint(x: 0.24137711528119288d, y: 0.9724874393031296d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6294446390708822d, y: 0.7015088308330872d), new NpgsqlTypes.NpgsqlPoint(x: 0.5674596408906848d, y: 0.35102701231132416d), new NpgsqlTypes.NpgsqlPoint(x: 0.708456771718187d, y: 0.8179547502720206d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9893581281082201d, y: 0.49820234093137006d), new NpgsqlTypes.NpgsqlPoint(x: 0.7132084910217981d, y: 0.024637916672694216d), new NpgsqlTypes.NpgsqlPoint(x: 0.026927565740239023d, y: 0.08183983661373095d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5138079807121787d, y: 0.4830669015956848d), new NpgsqlTypes.NpgsqlPoint(x: 0.8911412653109877d, y: 0.2878463005728439d), new NpgsqlTypes.NpgsqlPoint(x: 0.8945614796057778d, y: 0.10096300847294248d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8572812088876859d, y: 0.2935021133346044d), new NpgsqlTypes.NpgsqlPoint(x: 0.17158700881452438d, y: 0.46974227626024234d), new NpgsqlTypes.NpgsqlPoint(x: 0.7538694376854325d, y: 0.08042659165563903d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16549076897398762d, y: 0.5746645733917979d), new NpgsqlTypes.NpgsqlPoint(x: 0.1315879067358886d, y: 0.1805440525201737d), new NpgsqlTypes.NpgsqlPoint(x: 0.4946765464227514d, y: 0.619758501023307d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5360752004320946d, y: 0.8133759104239091d), new NpgsqlTypes.NpgsqlPoint(x: 0.5749129531015837d, y: 0.813297451356266d), new NpgsqlTypes.NpgsqlPoint(x: 0.7009171274733468d, y: 0.952795034375577d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.638572129340695d, y: 0.7072862623644097d), new NpgsqlTypes.NpgsqlPoint(x: 0.29027904118221515d, y: 0.9682633668641754d), new NpgsqlTypes.NpgsqlPoint(x: 0.2069948884359738d, y: 0.6646292658719126d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3704930520531309d, y: 0.2319337910845337d), new NpgsqlTypes.NpgsqlPoint(x: 0.13483376537901237d, y: 0.29081385286050954d), new NpgsqlTypes.NpgsqlPoint(x: 0.5090044416739673d, y: 0.3222138271838293d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9404820712967303d, y: 0.9932137480976128d), new NpgsqlTypes.NpgsqlPoint(x: 0.11911864667018379d, y: 0.9381322561010016d), new NpgsqlTypes.NpgsqlPoint(x: 0.471911765925617d, y: 0.411021983084803d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9568129298482689d, y: 0.19640310018780116d), new NpgsqlTypes.NpgsqlPoint(x: 0.10355467683785369d, y: 0.37002145932784447d), new NpgsqlTypes.NpgsqlPoint(x: 0.35494937280612404d, y: 0.15543942855162196d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9828113288789009d, y: 0.5791419089433075d), new NpgsqlTypes.NpgsqlPoint(x: 0.4600002983027224d, y: 0.656666289169638d), new NpgsqlTypes.NpgsqlPoint(x: 0.1433015781840874d, y: 0.07797384055951506d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9104892678798179d, y: 0.31386608506152014d), new NpgsqlTypes.NpgsqlPoint(x: 0.380357823789656d, y: 0.9224103033425785d), new NpgsqlTypes.NpgsqlPoint(x: 0.8607795267881215d, y: 0.3603624180404713d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4788399061996923d, y: 0.5483598973470618d), new NpgsqlTypes.NpgsqlPoint(x: 0.9185287929240167d, y: 0.8386732920866665d), new NpgsqlTypes.NpgsqlPoint(x: 0.7651150342257889d, y: 0.7617918382214162d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14370483223640673d, y: 0.7769671913031623d), new NpgsqlTypes.NpgsqlPoint(x: 0.8793994188852784d, y: 0.8473106149124588d), new NpgsqlTypes.NpgsqlPoint(x: 0.5107648695437769d, y: 0.1516688168908885d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4212616577173617d, y: 0.8237696521830229d), new NpgsqlTypes.NpgsqlPoint(x: 0.8960750269679552d, y: 0.3163898890958663d), new NpgsqlTypes.NpgsqlPoint(x: 0.5339705322370263d, y: 0.9920495275732023d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36675937111920165d, y: 0.4980491227945204d), new NpgsqlTypes.NpgsqlPoint(x: 0.6269743327359122d, y: 0.5295682607552461d), new NpgsqlTypes.NpgsqlPoint(x: 0.09421660322914538d, y: 0.6613328367417259d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03589358464117787d, y: 0.04148946509438223d), new NpgsqlTypes.NpgsqlPoint(x: 0.7519683579667854d, y: 0.9029540144122022d), new NpgsqlTypes.NpgsqlPoint(x: 0.8301315572638118d, y: 0.16417507530918185d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4113409610574362d, y: 0.35071024239203386d), new NpgsqlTypes.NpgsqlPoint(x: 0.46611635974540844d, y: 0.19243026174196542d), new NpgsqlTypes.NpgsqlPoint(x: 0.6219911868841214d, y: 0.403173007603855d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22995383009249382d, y: 0.5672177298971677d), new NpgsqlTypes.NpgsqlPoint(x: 0.6349678830806955d, y: 0.956823343550194d), new NpgsqlTypes.NpgsqlPoint(x: 0.4322133299119464d, y: 0.21689607354880103d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.311748586171148d, y: 0.8510508737864735d), new NpgsqlTypes.NpgsqlPoint(x: 0.739268566260247d, y: 0.3376967928305301d), new NpgsqlTypes.NpgsqlPoint(x: 0.24497940221927217d, y: 0.29599337241702817d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7094863620764706d, y: 0.92185395101202d), new NpgsqlTypes.NpgsqlPoint(x: 0.3796133081842591d, y: 0.8325616279310917d), new NpgsqlTypes.NpgsqlPoint(x: 0.6402298369495932d, y: 0.9271061483374871d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44578710797333465d, y: 0.6320695209304059d), new NpgsqlTypes.NpgsqlPoint(x: 0.8109506521295682d, y: 0.8023829608170212d), new NpgsqlTypes.NpgsqlPoint(x: 0.6403063682866758d, y: 0.6895822315125574d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34634059412476126d, y: 0.8464791676147264d), new NpgsqlTypes.NpgsqlPoint(x: 0.17077948418430755d, y: 0.3631727461147446d), new NpgsqlTypes.NpgsqlPoint(x: 0.08322225254478477d, y: 0.7227387109677668d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14969674569894675d, y: 0.6923168104666917d), new NpgsqlTypes.NpgsqlPoint(x: 0.3723939773669134d, y: 0.2442461701975983d), new NpgsqlTypes.NpgsqlPoint(x: 0.525939917896815d, y: 0.653492532658884d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42012708826000844d, y: 0.9756225610114262d), new NpgsqlTypes.NpgsqlPoint(x: 0.9012038676841613d, y: 0.7769939826892907d), new NpgsqlTypes.NpgsqlPoint(x: 0.48422080290636926d, y: 0.4106914901345734d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15306755934175043d, y: 0.8309952030717319d), new NpgsqlTypes.NpgsqlPoint(x: 0.8664118557464867d, y: 0.33121621617937347d), new NpgsqlTypes.NpgsqlPoint(x: 0.9342412140296328d, y: 0.42608716986797035d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4379691134654724d, y: 0.16617289518167744d), new NpgsqlTypes.NpgsqlPoint(x: 0.2531849824060617d, y: 0.6363556167140013d), new NpgsqlTypes.NpgsqlPoint(x: 0.9739752017699504d, y: 0.15757220192578303d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7947415375718825d, y: 0.5680243948774549d), new NpgsqlTypes.NpgsqlPoint(x: 0.0974043138182844d, y: 0.019793248547160247d), new NpgsqlTypes.NpgsqlPoint(x: 0.22161875645448392d, y: 0.380325017292647d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2290060991188414d, y: 0.2626275263460073d), new NpgsqlTypes.NpgsqlPoint(x: 0.29830315173770583d, y: 0.16757248789480972d), new NpgsqlTypes.NpgsqlPoint(x: 0.9538127629448477d, y: 0.1777257652655838d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05020467802001538d, y: 0.10717808636133563d), new NpgsqlTypes.NpgsqlPoint(x: 0.8760830183594392d, y: 0.7698023591103202d), new NpgsqlTypes.NpgsqlPoint(x: 0.6302195665750577d, y: 0.24085375048365842d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8204529934582053d, y: 0.78750824427905d), new NpgsqlTypes.NpgsqlPoint(x: 0.8170263305810234d, y: 0.18568908623629754d), new NpgsqlTypes.NpgsqlPoint(x: 0.606510597301232d, y: 0.7058924783663214d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6574789265061073d, y: 0.8292128584773378d), new NpgsqlTypes.NpgsqlPoint(x: 0.39125846065612535d, y: 0.4261025715215174d), new NpgsqlTypes.NpgsqlPoint(x: 0.23902100210391686d, y: 0.7918073275308548d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3651243327018526d, y: 0.2397486818314687d), new NpgsqlTypes.NpgsqlPoint(x: 0.5824073038614712d, y: 0.2923651241480769d), new NpgsqlTypes.NpgsqlPoint(x: 0.9531065741406046d, y: 0.32548873003955114d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7828510740407185d, y: 0.4692194402985779d), new NpgsqlTypes.NpgsqlPoint(x: 0.46777107541528096d, y: 0.7678923443983677d), new NpgsqlTypes.NpgsqlPoint(x: 0.6159032199436056d, y: 0.9669712843123355d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4096590925137872d, y: 0.21017726845786688d), new NpgsqlTypes.NpgsqlPoint(x: 0.9971355765565839d, y: 0.13412056656882854d), new NpgsqlTypes.NpgsqlPoint(x: 0.37951843007075137d, y: 0.3389991586172668d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11695441674837226d, y: 0.1742420724052205d), new NpgsqlTypes.NpgsqlPoint(x: 0.8630877710421923d, y: 0.14316951102354492d), new NpgsqlTypes.NpgsqlPoint(x: 0.0033850932548536994d, y: 0.5031314924565272d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4562520643999447d, y: 0.3600954948639742d), new NpgsqlTypes.NpgsqlPoint(x: 0.774201084733374d, y: 0.6579478013519456d), new NpgsqlTypes.NpgsqlPoint(x: 0.14357026320312816d, y: 0.37468293929272556d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.61897682137679d, y: 0.1796617092285152d), new NpgsqlTypes.NpgsqlPoint(x: 0.1484424795289243d, y: 0.3643011602910379d), new NpgsqlTypes.NpgsqlPoint(x: 0.13317444511790766d, y: 0.8466596109477471d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4230946851063485d, y: 0.9087304698349726d), new NpgsqlTypes.NpgsqlPoint(x: 0.8378738953075169d, y: 0.09378474141890158d), new NpgsqlTypes.NpgsqlPoint(x: 0.3890083862131467d, y: 0.07741480022175429d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05336173427841606d, y: 0.618973552943596d), new NpgsqlTypes.NpgsqlPoint(x: 0.6860302339834313d, y: 0.48029245557675726d), new NpgsqlTypes.NpgsqlPoint(x: 0.34368312851975524d, y: 0.8392265902855772d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13410445891802614d, y: 0.7866183565231107d), new NpgsqlTypes.NpgsqlPoint(x: 0.09517660408458706d, y: 0.16726336920474005d), new NpgsqlTypes.NpgsqlPoint(x: 0.09383329882076086d, y: 0.4121998200630652d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11575236145437351d, y: 0.9384194436202311d), new NpgsqlTypes.NpgsqlPoint(x: 0.4418144411927405d, y: 0.033393315571445537d), new NpgsqlTypes.NpgsqlPoint(x: 0.4615146367673172d, y: 0.6987395999607494d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2563292273455714d, y: 0.34137694442813615d), new NpgsqlTypes.NpgsqlPoint(x: 0.5526291700370093d, y: 0.8492273263672823d), new NpgsqlTypes.NpgsqlPoint(x: 0.8487442490643998d, y: 0.6688963621526327d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1389322852513234d, y: 0.2737425713875661d), new NpgsqlTypes.NpgsqlPoint(x: 0.7383530657046735d, y: 0.673307019987155d), new NpgsqlTypes.NpgsqlPoint(x: 0.9720590654267569d, y: 0.19637223689217354d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3908954237878569d, y: 0.9120770084229421d), new NpgsqlTypes.NpgsqlPoint(x: 0.1910297508227794d, y: 0.10485318709978009d), new NpgsqlTypes.NpgsqlPoint(x: 0.7618872706788861d, y: 0.04443554203627498d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8276059277692565d, y: 0.16460253297356364d), new NpgsqlTypes.NpgsqlPoint(x: 0.06790358653157713d, y: 0.3516576127016724d), new NpgsqlTypes.NpgsqlPoint(x: 0.1796166296166437d, y: 0.5443657272893737d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9928975765018503d, y: 0.6579258305531126d), new NpgsqlTypes.NpgsqlPoint(x: 0.37694363204009795d, y: 0.7337398208370844d), new NpgsqlTypes.NpgsqlPoint(x: 0.9019108205064409d, y: 0.6647424721460071d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5969245779984683d, y: 0.9600649120210548d), new NpgsqlTypes.NpgsqlPoint(x: 0.6848576679913744d, y: 0.7494462694488414d), new NpgsqlTypes.NpgsqlPoint(x: 0.33557252900341017d, y: 0.06308028487814699d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24572390312339365d, y: 0.1490751340629357d), new NpgsqlTypes.NpgsqlPoint(x: 0.9796225141220247d, y: 0.6670955494130869d), new NpgsqlTypes.NpgsqlPoint(x: 0.31447551109273897d, y: 0.5288734995751119d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7502482157101177d, y: 0.6892535226755375d), new NpgsqlTypes.NpgsqlPoint(x: 0.05750076854174657d, y: 0.07762688506215099d), new NpgsqlTypes.NpgsqlPoint(x: 0.4549696173032609d, y: 0.04850192184720703d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6811408277272281d, y: 0.3055233217686558d), new NpgsqlTypes.NpgsqlPoint(x: 0.632970921209861d, y: 0.3094223201244859d), new NpgsqlTypes.NpgsqlPoint(x: 0.7723691054031073d, y: 0.7769355947123996d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6331748153181959d, y: 0.07053375458780431d), new NpgsqlTypes.NpgsqlPoint(x: 0.04913235928455273d, y: 0.40969805230696843d), new NpgsqlTypes.NpgsqlPoint(x: 0.45822947631539057d, y: 0.48108526794929907d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15548290633871276d, y: 0.8714470407982099d), new NpgsqlTypes.NpgsqlPoint(x: 0.7610377554711452d, y: 0.86175900288643d), new NpgsqlTypes.NpgsqlPoint(x: 0.3077009883737536d, y: 0.3235805034227033d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13035685742971537d, y: 0.7428244522357008d), new NpgsqlTypes.NpgsqlPoint(x: 0.6515384858464547d, y: 0.9674617547842664d), new NpgsqlTypes.NpgsqlPoint(x: 0.6932762532562384d, y: 0.47760515925319624d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6213650343553774d, y: 0.053879978965178266d), new NpgsqlTypes.NpgsqlPoint(x: 0.35686677133126565d, y: 0.32111013129107924d), new NpgsqlTypes.NpgsqlPoint(x: 0.020386163326686857d, y: 0.0009997735111295647d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7426856086099929d, y: 0.3603909658282577d), new NpgsqlTypes.NpgsqlPoint(x: 0.7527237366248709d, y: 0.9428135929764213d), new NpgsqlTypes.NpgsqlPoint(x: 0.7407467150803464d, y: 0.9889405849887204d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.00012176431260324527d, y: 0.7888053387917155d), new NpgsqlTypes.NpgsqlPoint(x: 0.36185904613188313d, y: 0.5233918199298226d), new NpgsqlTypes.NpgsqlPoint(x: 0.6338656500583602d, y: 0.9333292960534549d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 106,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3759263229496589d, y: 0.7379647220501383d), new NpgsqlTypes.NpgsqlPoint(x: 0.567819737296416d, y: 0.44671279388396357d), new NpgsqlTypes.NpgsqlPoint(x: 0.6304856735332258d, y: 0.6855460914541249d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9578127993377628d, y: 0.7649907865255194d), new NpgsqlTypes.NpgsqlPoint(x: 0.805936862203564d, y: 0.5997314908730339d), new NpgsqlTypes.NpgsqlPoint(x: 0.4014703287695369d, y: 0.147795329568022d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11924376320265595d, y: 0.306771009495989d), new NpgsqlTypes.NpgsqlPoint(x: 0.35288416906067943d, y: 0.15945397229163782d), new NpgsqlTypes.NpgsqlPoint(x: 0.9907542093147845d, y: 0.7674895549172517d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0430872439920007d, y: 0.712693475733802d), new NpgsqlTypes.NpgsqlPoint(x: 0.14054105968231456d, y: 0.8586916115717184d), new NpgsqlTypes.NpgsqlPoint(x: 0.865172408016858d, y: 0.2119493912014555d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 115,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.958986154266905d, y: 0.6871764930130881d), new NpgsqlTypes.NpgsqlPoint(x: 0.6422871263086637d, y: 0.17049179034356798d), new NpgsqlTypes.NpgsqlPoint(x: 0.06220503550981704d, y: 0.4915367544881051d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.61880654306097d, y: 0.6142786308210735d), new NpgsqlTypes.NpgsqlPoint(x: 0.19405048617296505d, y: 0.1672345176175669d), new NpgsqlTypes.NpgsqlPoint(x: 0.7783521413927765d, y: 0.3096057745794354d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6544828000481516d, y: 0.1326596517926244d), new NpgsqlTypes.NpgsqlPoint(x: 0.9195649199157311d, y: 0.7634729974276857d), new NpgsqlTypes.NpgsqlPoint(x: 0.495483635866235d, y: 0.2734675201076088d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.441098117831782d, y: 0.2169112303841093d), new NpgsqlTypes.NpgsqlPoint(x: 0.7674456666934046d, y: 0.328763117566077d), new NpgsqlTypes.NpgsqlPoint(x: 0.14522380040594274d, y: 0.9128672436552818d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8414926274863506d, y: 0.2486297028544835d), new NpgsqlTypes.NpgsqlPoint(x: 0.7304728176111411d, y: 0.6739285183669883d), new NpgsqlTypes.NpgsqlPoint(x: 0.0024583995778708623d, y: 0.47901917699038743d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7544305748761863d, y: 0.921888029549259d), new NpgsqlTypes.NpgsqlPoint(x: 0.8898460501068118d, y: 0.2573370102878457d), new NpgsqlTypes.NpgsqlPoint(x: 0.8829302194568905d, y: 0.5830663303915861d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24856756778517686d, y: 0.4463491677786826d), new NpgsqlTypes.NpgsqlPoint(x: 0.01222460019971372d, y: 0.5414073742676511d), new NpgsqlTypes.NpgsqlPoint(x: 0.3879596861304615d, y: 0.5291582486778668d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6271454992809748d, y: 0.2660870905075977d), new NpgsqlTypes.NpgsqlPoint(x: 0.6876145680534128d, y: 0.9645948202270671d), new NpgsqlTypes.NpgsqlPoint(x: 0.8316748629263495d, y: 0.6797815786155957d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6795229376922245d, y: 0.9482712115371502d), new NpgsqlTypes.NpgsqlPoint(x: 0.22014136666244444d, y: 0.828534289845433d), new NpgsqlTypes.NpgsqlPoint(x: 0.10064176099202093d, y: 0.9805594232596669d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02426401447242532d, y: 0.1479778979013756d), new NpgsqlTypes.NpgsqlPoint(x: 0.7324816998161069d, y: 0.1657786396200528d), new NpgsqlTypes.NpgsqlPoint(x: 0.5040239171506095d, y: 0.012731830353477247d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46097937288289514d, y: 0.9988085996724677d), new NpgsqlTypes.NpgsqlPoint(x: 0.5844490661743746d, y: 0.9870812042591627d), new NpgsqlTypes.NpgsqlPoint(x: 0.054631814160233105d, y: 0.572582733306584d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49302692692763994d, y: 0.6306539210954086d), new NpgsqlTypes.NpgsqlPoint(x: 0.8072629738399066d, y: 0.46387780399079337d), new NpgsqlTypes.NpgsqlPoint(x: 0.24573866347182027d, y: 0.4533373102548923d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6561609242176315d, y: 0.01516048266414205d), new NpgsqlTypes.NpgsqlPoint(x: 0.5668834385099616d, y: 0.3925002282313367d), new NpgsqlTypes.NpgsqlPoint(x: 0.9682760485844236d, y: 0.5088509043429627d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9241794971744539d, y: 0.68929608152349d), new NpgsqlTypes.NpgsqlPoint(x: 0.8082064797894726d, y: 0.4624895883904989d), new NpgsqlTypes.NpgsqlPoint(x: 0.2670351580640302d, y: 0.21139332821481305d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 119,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6588631035475307d, y: 0.36012813323164383d), new NpgsqlTypes.NpgsqlPoint(x: 0.9562285973540551d, y: 0.7040558445274826d), new NpgsqlTypes.NpgsqlPoint(x: 0.00030794974114733975d, y: 0.7587926142856463d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.682040436462471d, y: 0.103386426704979d), new NpgsqlTypes.NpgsqlPoint(x: 0.14378890075398498d, y: 0.9524336414059782d), new NpgsqlTypes.NpgsqlPoint(x: 0.2745398194769286d, y: 0.46916715738095416d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8843424684701076d, y: 0.13933820619394877d), new NpgsqlTypes.NpgsqlPoint(x: 0.7238442158856441d, y: 0.23142497523118344d), new NpgsqlTypes.NpgsqlPoint(x: 0.6475788752936958d, y: 0.40663181759129274d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24612040313835426d, y: 0.6071477603541452d), new NpgsqlTypes.NpgsqlPoint(x: 0.6997784141461165d, y: 0.14722100805395966d), new NpgsqlTypes.NpgsqlPoint(x: 0.018871488462219976d, y: 0.028668774109774864d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 124,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2721343125242017d, y: 0.624155533523907d), new NpgsqlTypes.NpgsqlPoint(x: 0.6464668563324596d, y: 0.6148697801484616d), new NpgsqlTypes.NpgsqlPoint(x: 0.3208067204211771d, y: 0.27702545732927364d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9345752442475646d, y: 0.07750200129722618d), new NpgsqlTypes.NpgsqlPoint(x: 0.803628931679822d, y: 0.3767985767387043d), new NpgsqlTypes.NpgsqlPoint(x: 0.6399681561837259d, y: 0.39510727791721345d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7595382344225778d, y: 0.7416596059180607d), new NpgsqlTypes.NpgsqlPoint(x: 0.9572427699118599d, y: 0.4365527106806196d), new NpgsqlTypes.NpgsqlPoint(x: 0.8703613663552278d, y: 0.28491405785062973d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12859152708268617d, y: 0.43966720374581025d), new NpgsqlTypes.NpgsqlPoint(x: 0.009401535036275055d, y: 0.5255976594580911d), new NpgsqlTypes.NpgsqlPoint(x: 0.023299553464273814d, y: 0.7089451306195016d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.392684246830029d, y: 0.6144235518762701d), new NpgsqlTypes.NpgsqlPoint(x: 0.032002914038743335d, y: 0.3936025387315798d), new NpgsqlTypes.NpgsqlPoint(x: 0.4017599174954619d, y: 0.17048810043839957d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04205840824274454d, y: 0.8587067719816661d), new NpgsqlTypes.NpgsqlPoint(x: 0.9192348294810135d, y: 0.9774439170973963d), new NpgsqlTypes.NpgsqlPoint(x: 0.26066327535619827d, y: 0.09609299492195778d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5431368712252369d, y: 0.7427969919918959d), new NpgsqlTypes.NpgsqlPoint(x: 0.9727763311073954d, y: 0.08545173431449726d), new NpgsqlTypes.NpgsqlPoint(x: 0.7431635067440188d, y: 0.21386418077097824d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2756056476929938d, y: 0.4263568247787528d), new NpgsqlTypes.NpgsqlPoint(x: 0.9659898026027945d, y: 0.7081760445346785d), new NpgsqlTypes.NpgsqlPoint(x: 0.545178789375389d, y: 0.611278741094606d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2320471493251749d, y: 0.014001274198804037d), new NpgsqlTypes.NpgsqlPoint(x: 0.15253764581648843d, y: 0.19995312669136023d), new NpgsqlTypes.NpgsqlPoint(x: 0.26272229680052916d, y: 0.39287003802820863d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1916978642144943d, y: 0.42747019105606865d), new NpgsqlTypes.NpgsqlPoint(x: 0.684214011897065d, y: 0.2675370998942085d), new NpgsqlTypes.NpgsqlPoint(x: 0.2611976112583956d, y: 0.9161791442934218d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 125,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40920740848858794d, y: 0.6513158909801496d), new NpgsqlTypes.NpgsqlPoint(x: 0.06689692565473038d, y: 0.7787182319651729d), new NpgsqlTypes.NpgsqlPoint(x: 0.7093892728252144d, y: 0.530178788831837d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37765216736059826d, y: 0.6183966030898358d), new NpgsqlTypes.NpgsqlPoint(x: 0.4687543292700882d, y: 0.5052232566155836d), new NpgsqlTypes.NpgsqlPoint(x: 0.7359434137796559d, y: 0.6188319075753078d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7459916800619549d, y: 0.3445358975231645d), new NpgsqlTypes.NpgsqlPoint(x: 0.3381322207034534d, y: 0.6270354827596356d), new NpgsqlTypes.NpgsqlPoint(x: 0.2779871415245274d, y: 0.5110715754800146d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3947685328223701d, y: 0.3175849499041111d), new NpgsqlTypes.NpgsqlPoint(x: 0.965039455898163d, y: 0.8600507893071263d), new NpgsqlTypes.NpgsqlPoint(x: 0.8446133841368578d, y: 0.5115187770156067d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8558175151494201d, y: 0.49785810704047306d), new NpgsqlTypes.NpgsqlPoint(x: 0.9251627435417724d, y: 0.9079019923528142d), new NpgsqlTypes.NpgsqlPoint(x: 0.8413121831559989d, y: 0.43498790519734787d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5156530340070916d, y: 0.7002907079268297d), new NpgsqlTypes.NpgsqlPoint(x: 0.6891365337572707d, y: 0.8892499647930523d), new NpgsqlTypes.NpgsqlPoint(x: 0.7637507780406546d, y: 0.3766320862430601d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8139618309092381d, y: 0.7554617091840244d), new NpgsqlTypes.NpgsqlPoint(x: 0.16728993732414166d, y: 0.39241491238781867d), new NpgsqlTypes.NpgsqlPoint(x: 0.9465344841647061d, y: 0.5461696694075832d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 130,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09785564510332345d, y: 0.49902282220158833d), new NpgsqlTypes.NpgsqlPoint(x: 0.11813109092460217d, y: 0.9201729469780983d), new NpgsqlTypes.NpgsqlPoint(x: 0.8397311000932671d, y: 0.8927164587387185d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05407870211717658d, y: 0.386432873577887d), new NpgsqlTypes.NpgsqlPoint(x: 0.4315873021242502d, y: 0.45976331552936245d), new NpgsqlTypes.NpgsqlPoint(x: 0.20624216762540237d, y: 0.692913739717914d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8086650319168037d, y: 0.9316995159762985d), new NpgsqlTypes.NpgsqlPoint(x: 0.5845723085331204d, y: 0.05960270563525094d), new NpgsqlTypes.NpgsqlPoint(x: 0.08812228456163274d, y: 0.8841293566973517d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3018359529979482d, y: 0.9585466771241341d), new NpgsqlTypes.NpgsqlPoint(x: 0.5633838180792797d, y: 0.7838067354024532d), new NpgsqlTypes.NpgsqlPoint(x: 0.17187401532285407d, y: 0.3188009661500395d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21869601501594826d, y: 0.20943489858009912d), new NpgsqlTypes.NpgsqlPoint(x: 0.08744580038718797d, y: 0.998482704592295d), new NpgsqlTypes.NpgsqlPoint(x: 0.245719704784929d, y: 0.360266455421855d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4228499830735504d, y: 0.5442028316571125d), new NpgsqlTypes.NpgsqlPoint(x: 0.6456784719037524d, y: 0.8709605023131929d), new NpgsqlTypes.NpgsqlPoint(x: 0.015590888154961124d, y: 0.9802487710434108d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7283820678329748d, y: 0.8828773802920304d), new NpgsqlTypes.NpgsqlPoint(x: 0.32820072157871105d, y: 0.9449798774628319d), new NpgsqlTypes.NpgsqlPoint(x: 0.5756006107906759d, y: 0.7702796397705309d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41915842682621673d, y: 0.23193399765742406d), new NpgsqlTypes.NpgsqlPoint(x: 0.675242596112915d, y: 0.6818406519530414d), new NpgsqlTypes.NpgsqlPoint(x: 0.9868959986267914d, y: 0.6925268839324129d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9762707168004755d, y: 0.04684437727695179d), new NpgsqlTypes.NpgsqlPoint(x: 0.5913886422124945d, y: 0.03395180617392102d), new NpgsqlTypes.NpgsqlPoint(x: 0.7872039201824406d, y: 0.18347529630026194d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12578192837169855d, y: 0.684412690223292d), new NpgsqlTypes.NpgsqlPoint(x: 0.5791261362629262d, y: 0.412993605183964d), new NpgsqlTypes.NpgsqlPoint(x: 0.6910730989663821d, y: 0.7354088897571563d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2906069074599712d, y: 0.8452283245543951d), new NpgsqlTypes.NpgsqlPoint(x: 0.24853533114493875d, y: 0.9829591866950835d), new NpgsqlTypes.NpgsqlPoint(x: 0.5567275059480834d, y: 0.5138583202120647d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6605085810939535d, y: 0.010410666647405642d), new NpgsqlTypes.NpgsqlPoint(x: 0.7410702088813254d, y: 0.2823709079871072d), new NpgsqlTypes.NpgsqlPoint(x: 0.1376118500773882d, y: 0.8058732232699306d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5319545332362973d, y: 0.0167719067620703d), new NpgsqlTypes.NpgsqlPoint(x: 0.5050413878572216d, y: 0.19370319732003316d), new NpgsqlTypes.NpgsqlPoint(x: 0.7206304766828767d, y: 0.9068284862852589d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 134,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05430840153249805d, y: 0.5588266544452498d), new NpgsqlTypes.NpgsqlPoint(x: 0.8685414640676202d, y: 0.15709455138928585d), new NpgsqlTypes.NpgsqlPoint(x: 0.7647370186198433d, y: 0.3613321030920037d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4539093952534208d, y: 0.1277845755010062d), new NpgsqlTypes.NpgsqlPoint(x: 0.640074235751939d, y: 0.1427374184434701d), new NpgsqlTypes.NpgsqlPoint(x: 0.8337459988744147d, y: 0.025416573070341508d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04124284579339488d, y: 0.9723659275574138d), new NpgsqlTypes.NpgsqlPoint(x: 0.7833677541974308d, y: 0.5481755193464414d), new NpgsqlTypes.NpgsqlPoint(x: 0.5978620013247071d, y: 0.5394932069735482d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07986518781055507d, y: 0.6275553131687188d), new NpgsqlTypes.NpgsqlPoint(x: 0.26377545198912267d, y: 0.9107541872558229d), new NpgsqlTypes.NpgsqlPoint(x: 0.4861339388199406d, y: 0.815949907672049d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18384396189263985d, y: 0.014129248171765307d), new NpgsqlTypes.NpgsqlPoint(x: 0.6864934726973425d, y: 0.14378523113954078d), new NpgsqlTypes.NpgsqlPoint(x: 0.09059742758107181d, y: 0.7647282298249805d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.004120815290793001d, y: 0.006747297217219672d), new NpgsqlTypes.NpgsqlPoint(x: 0.19414247657245853d, y: 0.935197781985094d), new NpgsqlTypes.NpgsqlPoint(x: 0.8924671039020413d, y: 0.5887986798911719d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 139,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36535325001054064d, y: 0.3743115184275946d), new NpgsqlTypes.NpgsqlPoint(x: 0.693035511178949d, y: 0.5312655576064619d), new NpgsqlTypes.NpgsqlPoint(x: 0.4361454889158234d, y: 0.7433445989979302d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24361403717456986d, y: 0.1671525616033277d), new NpgsqlTypes.NpgsqlPoint(x: 0.23495737963272711d, y: 0.8594190072189174d), new NpgsqlTypes.NpgsqlPoint(x: 0.7919361003705961d, y: 0.6967957221284096d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5263327964775626d, y: 0.6863441471894388d), new NpgsqlTypes.NpgsqlPoint(x: 0.4362658219542861d, y: 0.0349874081700523d), new NpgsqlTypes.NpgsqlPoint(x: 0.9241976946900899d, y: 0.8592842489119864d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9538200294555909d, y: 0.48426885014274934d), new NpgsqlTypes.NpgsqlPoint(x: 0.005177527510578428d, y: 0.3590419453079148d), new NpgsqlTypes.NpgsqlPoint(x: 0.5400445363478957d, y: 0.9289611183026406d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3531171744872179d, y: 0.8251124007708934d), new NpgsqlTypes.NpgsqlPoint(x: 0.8530081929884942d, y: 0.4539038996134718d), new NpgsqlTypes.NpgsqlPoint(x: 0.8699280319580853d, y: 0.2929034519282395d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8254036862133007d, y: 0.597240764066621d), new NpgsqlTypes.NpgsqlPoint(x: 0.030994036860750973d, y: 0.8221248650338352d), new NpgsqlTypes.NpgsqlPoint(x: 0.21507299629622212d, y: 0.8494071336656777d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44196275858440615d, y: 0.5959117782978863d), new NpgsqlTypes.NpgsqlPoint(x: 0.11439165991277989d, y: 0.21213325129336946d), new NpgsqlTypes.NpgsqlPoint(x: 0.35384129845706114d, y: 0.9410102907828622d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1596784643104059d, y: 0.8525220238054431d), new NpgsqlTypes.NpgsqlPoint(x: 0.30394453593673054d, y: 0.5458046819347265d), new NpgsqlTypes.NpgsqlPoint(x: 0.0420575814514389d, y: 0.9912640757056352d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06356502852046253d, y: 0.46868476327839004d), new NpgsqlTypes.NpgsqlPoint(x: 0.5931311151415719d, y: 0.23992832608770642d), new NpgsqlTypes.NpgsqlPoint(x: 0.5183222305135458d, y: 0.24384412592229798d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5421290520442297d, y: 0.03923995947191927d), new NpgsqlTypes.NpgsqlPoint(x: 0.7670921657014924d, y: 0.999702482167135d), new NpgsqlTypes.NpgsqlPoint(x: 0.3201243622949922d, y: 0.5558625634996922d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 144,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5653202215349438d, y: 0.5223396760497133d), new NpgsqlTypes.NpgsqlPoint(x: 0.21190772977446792d, y: 0.9884779109671342d), new NpgsqlTypes.NpgsqlPoint(x: 0.6451623632061534d, y: 0.9989723325590657d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4384494041417868d, y: 0.7421110211032752d), new NpgsqlTypes.NpgsqlPoint(x: 0.9040443244137797d, y: 0.8195426416031337d), new NpgsqlTypes.NpgsqlPoint(x: 0.006280468424585739d, y: 0.9932044026414817d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.049414448105188025d, y: 0.45782217917537893d), new NpgsqlTypes.NpgsqlPoint(x: 0.47865811411347703d, y: 0.9397650475501753d), new NpgsqlTypes.NpgsqlPoint(x: 0.47582515386744517d, y: 0.9886884132852345d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9732838022531478d, y: 0.09326736054746898d), new NpgsqlTypes.NpgsqlPoint(x: 0.5481753779820809d, y: 0.9936274548076315d), new NpgsqlTypes.NpgsqlPoint(x: 0.3672615865385509d, y: 0.19145990059777074d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3873479376175454d, y: 0.6778313576535362d), new NpgsqlTypes.NpgsqlPoint(x: 0.5832417855155194d, y: 0.6449373258102994d), new NpgsqlTypes.NpgsqlPoint(x: 0.8099161052305643d, y: 0.5682155978831225d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.881619557550107d, y: 0.4756116699587718d), new NpgsqlTypes.NpgsqlPoint(x: 0.8728874446364959d, y: 0.5630329218602806d), new NpgsqlTypes.NpgsqlPoint(x: 0.8889171443635625d, y: 0.0547605383798867d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2754932673222772d, y: 0.08997777082349434d), new NpgsqlTypes.NpgsqlPoint(x: 0.8730776174046722d, y: 0.35306613140619203d), new NpgsqlTypes.NpgsqlPoint(x: 0.7965313996199328d, y: 0.4327647451855442d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 148,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5563039008464148d, y: 0.655928141008249d), new NpgsqlTypes.NpgsqlPoint(x: 0.62812185478149d, y: 0.7892243375071476d), new NpgsqlTypes.NpgsqlPoint(x: 0.5533880261219297d, y: 0.4769709777609068d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8086884559531997d, y: 0.10834534124324358d), new NpgsqlTypes.NpgsqlPoint(x: 0.7444501254563406d, y: 0.059196082634748515d), new NpgsqlTypes.NpgsqlPoint(x: 0.7855542088249726d, y: 0.403112434908813d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21958193423034167d, y: 0.29918375718691403d), new NpgsqlTypes.NpgsqlPoint(x: 0.7447928892872046d, y: 0.2842824141013872d), new NpgsqlTypes.NpgsqlPoint(x: 0.19437981615816002d, y: 0.39078859282200784d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29327317641678263d, y: 0.9242486469466804d), new NpgsqlTypes.NpgsqlPoint(x: 0.7677671848700744d, y: 0.9338994588995084d), new NpgsqlTypes.NpgsqlPoint(x: 0.051287296025889884d, y: 0.21840949627995532d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8658938888449352d, y: 0.678434102179684d), new NpgsqlTypes.NpgsqlPoint(x: 0.341783523085458d, y: 0.004523540096645795d), new NpgsqlTypes.NpgsqlPoint(x: 0.5122063595096212d, y: 0.6104227691397686d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7964161086908161d, y: 0.8234318364831273d), new NpgsqlTypes.NpgsqlPoint(x: 0.2793099755125372d, y: 0.3210945785471181d), new NpgsqlTypes.NpgsqlPoint(x: 0.5313532406147483d, y: 0.1756008307225777d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8886480856720572d, y: 0.14595441450391444d), new NpgsqlTypes.NpgsqlPoint(x: 0.6303878135990024d, y: 0.9161468984814491d), new NpgsqlTypes.NpgsqlPoint(x: 0.7893638240082947d, y: 0.03868046363798394d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41087353360100165d, y: 0.7122395752582196d), new NpgsqlTypes.NpgsqlPoint(x: 0.871746219602723d, y: 0.6324114483541269d), new NpgsqlTypes.NpgsqlPoint(x: 0.6173465383027483d, y: 0.5386777218794786d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.041202933283664755d, y: 0.051363487688200204d), new NpgsqlTypes.NpgsqlPoint(x: 0.679068594189388d, y: 0.7418987887204899d), new NpgsqlTypes.NpgsqlPoint(x: 0.1740261750468387d, y: 0.418786668865919d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5963595360128713d, y: 0.9294413063053296d), new NpgsqlTypes.NpgsqlPoint(x: 0.4214651837167702d, y: 0.42949014833377785d), new NpgsqlTypes.NpgsqlPoint(x: 0.5143117015670657d, y: 0.48061431716020686d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3081918242662055d, y: 0.5589526104948239d), new NpgsqlTypes.NpgsqlPoint(x: 0.6081413714274232d, y: 0.820709900510267d), new NpgsqlTypes.NpgsqlPoint(x: 0.907355002022126d, y: 0.26453539583829744d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9724226250840075d, y: 0.04479914834195231d), new NpgsqlTypes.NpgsqlPoint(x: 0.7183359722740955d, y: 0.39997192059191244d), new NpgsqlTypes.NpgsqlPoint(x: 0.2549161563564164d, y: 0.902363776437709d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9976312544200837d, y: 0.11502199476409658d), new NpgsqlTypes.NpgsqlPoint(x: 0.8522625334155571d, y: 0.08563281612084972d), new NpgsqlTypes.NpgsqlPoint(x: 0.6411624108473427d, y: 0.25917342400717336d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5630407806370371d, y: 0.28506483941405125d), new NpgsqlTypes.NpgsqlPoint(x: 0.8799713191971105d, y: 0.335967294398241d), new NpgsqlTypes.NpgsqlPoint(x: 0.01222636324198878d, y: 0.4717169342578533d)),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray1mi(
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray1mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632))]
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

                changedRows =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray1mi_id
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonarray1mi_id", 
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
                changedRows =  ((INpgsqlPolygonArraypolygonArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPolygonArraypolygonArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray1mi_id
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
    npgsqlpolygonpolygonarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                NpgsqlTypes.NpgsqlPolygon[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
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

                    nullable =  ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
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

                    nullable =  ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlPolygon[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
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

                    nullable = await ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
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

                    nullable = await ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48172003272573216d, y: 0.3355743059216013d), new NpgsqlTypes.NpgsqlPoint(x: 0.37882385879871994d, y: 0.8465392185418141d), new NpgsqlTypes.NpgsqlPoint(x: 0.965203402687102d, y: 0.6659791475835035d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9112480136841232d, y: 0.4171734642338618d), new NpgsqlTypes.NpgsqlPoint(x: 0.7208491421350713d, y: 0.2997244457680498d), new NpgsqlTypes.NpgsqlPoint(x: 0.6367213157346474d, y: 0.9197290356082815d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4597377882966138d, y: 0.1523923704310136d), new NpgsqlTypes.NpgsqlPoint(x: 0.13222838491983913d, y: 0.43264682225906914d), new NpgsqlTypes.NpgsqlPoint(x: 0.5477431338557314d, y: 0.9408474893057429d)),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray1mi_id
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
    npgsqlpolygonpolygonarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonarray1mi_id", 
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
                NpgsqlTypes.NpgsqlPolygon[] nullable = null;
                nullable =  ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon[] nullable = null;
                nullable = await ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8776753336157411d, y: 0.4927013824864005d), new NpgsqlTypes.NpgsqlPoint(x: 0.07782286841043995d, y: 0.66751659815979d), new NpgsqlTypes.NpgsqlPoint(x: 0.02050163488378065d, y: 0.061843582832665556d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3625214610335894d, y: 0.7457363785513542d), new NpgsqlTypes.NpgsqlPoint(x: 0.5905369309783236d, y: 0.4943731895562974d), new NpgsqlTypes.NpgsqlPoint(x: 0.014316338017813512d, y: 0.9296536604825152d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.505236511741713d, y: 0.9262085941691393d), new NpgsqlTypes.NpgsqlPoint(x: 0.4312711670597482d, y: 0.22123113000964523d), new NpgsqlTypes.NpgsqlPoint(x: 0.8393481249947787d, y: 0.9637023347116218d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22004343529736592d, y: 0.942444226627895d), new NpgsqlTypes.NpgsqlPoint(x: 0.5196061496810703d, y: 0.2822867939675203d), new NpgsqlTypes.NpgsqlPoint(x: 0.5144029349306113d, y: 0.3678033184834396d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonArray1M> models = null;

                models =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonArray1M> models = null;

                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M), typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                ((INpgsqlPolygonArraypolygonArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPolygonArraypolygonArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPolygonArraypolygonArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                var models = await ((INpgsqlPolygonArraypolygonArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPolygonArraypolygonArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M), typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                ((INpgsqlPolygonArraypolygonArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonArraypolygonArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonArraypolygonArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                var models = await ((INpgsqlPolygonArraypolygonArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPolygonArraypolygonArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M), typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
                }
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                ((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 43;
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[9], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[10], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[11], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[12], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[13], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[14], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[15], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[16], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[17], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[18], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[19], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[20], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[21], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[22], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[23], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[24], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[25], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[26], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[27], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[28], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[7], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[8], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[9], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[10], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[11], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[12], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[13], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[14], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[15], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[16], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[17], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[18], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[19], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[20], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[21], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[22], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[23], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[24], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[25], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[26], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[27], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[28], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[4], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[5], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[6], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[7], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[8], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[9], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[10], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[11], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[12], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[13], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[14], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[15], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[16], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[17], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[18], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[19], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[20], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[21], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[22], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[23], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[24], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[25], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[26], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[27], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[28], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[4], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[5], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[6], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[7], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[8], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[9], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[10], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[11], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[12], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[13], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[14], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[15], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[16], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[17], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[18], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[19], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[20], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[21], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[22], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[23], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[24], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[25], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[26], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[27], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[28], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[25],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                var models = await((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[6], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[7], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[8], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[9], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[10], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[11], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[12], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[13], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[14], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[15], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[16], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[17], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[18], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[19], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[20], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[21], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[22], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[23], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[17], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[18], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[19], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[20], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[21], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[22], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[23], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[29], false);
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
                var models = ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M), typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionMMDynQuerySelectModelConfig()
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
                }
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                ((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 124, query1, 43, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[24], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[25], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[26], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[27], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[28], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[9], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[10], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[11], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[12], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[13], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[14], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[15], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[16], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[17], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[18], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[19], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[20], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[21], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[22], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[23], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[24], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[25], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[26], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[27], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[28], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelBatch(connection, 130, query1, 7, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[26], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[27], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[28], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[2], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[3], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[4], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[5], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[6], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[7], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[8], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[9], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[10], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[11], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[12], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[13], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[14], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[15], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[16], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[17], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[18], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[19], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[20], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[21], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[22], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[23], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[24], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[25], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[26], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[25],_testData[27], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[26],_testData[28], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[27],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                var models = await((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelBatchAsync(connection, 78, 40))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[16], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[17], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[18], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[19], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[20], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[21], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[22], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[23], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[8], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[9], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[10], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[11], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[12], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[13], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[14], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[15], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[16], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[17], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[18], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[19], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[20], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[21], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[22], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[23], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[29], false);
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
                var models = ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelBatch(connection, 125, 124))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPolygonArraypolygonArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPolygonArraypolygonArray)this).SetDbConnectionSelectModelParametrs(cmd, 139);
                var models = await ((INpgsqlPolygonArraypolygonArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(2));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonArraypolygonArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonArraypolygonArray)this).SetDbConnectionSelectModelParametrs(cmd, 98);
                var models =  ((INpgsqlPolygonArraypolygonArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(10));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[20], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[21], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[22], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[23], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
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
FROM public.binary_npgsqlpolygonpolygonarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPolygonpolygonArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPolygonArraypolygonArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonArraypolygonArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPolygonArraypolygonArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPolygonArraypolygonArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygonarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
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
FROM public.binary_npgsqlpolygonpolygonarray1m m
LEFT JOIN public.binary_npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPolygonpolygonArray1M>(15);

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
                ((INpgsqlPolygonArraypolygonArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonArraypolygonArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPolygonArraypolygonArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPolygonArraypolygonArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygonarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonArraypolygonArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonArraypolygonArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonArraypolygonArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonArraypolygonArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

