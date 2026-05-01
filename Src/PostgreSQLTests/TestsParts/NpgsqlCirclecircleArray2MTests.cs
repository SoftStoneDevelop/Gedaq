

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
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15557542936809643d, y: 0.3231551382052773d), radius: 0.07246600422267613d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4809142164473713d, y: 0.8447302880029952d), radius: 0.7394129756088267d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5857338337323225d, y: 0.14962595212192797d), radius: 0.9165948692968883d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8663472876137269d, y: 0.7849954552105167d), radius: 0.46938295597075574d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2192729216434841d, y: 0.28362233710198226d), radius: 0.5176229196758331d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22662369873899768d, y: 0.45489850779858565d), radius: 0.7280770878349613d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06856732794772269d, y: 0.929034869375047d), radius: 0.2453816993054273d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5767742151970227d, y: 0.8967049591076381d), radius: 0.2640024241554607d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08952851487073887d, y: 0.5312147940765644d), radius: 0.46352105297278456d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21322400525728447d, y: 0.8062095299573172d), radius: 0.3729577936949635d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4223468418954418d, y: 0.3389242322547513d), radius: 0.7037383917243692d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6039684748890687d, y: 0.03777351662454953d), radius: 0.7263108877665876d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7570684765209514d, y: 0.8581174556197134d), radius: 0.6124443737300893d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5712085099478444d, y: 0.5258934826046884d), radius: 0.46250165298024626d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10186157332851953d, y: 0.13665432885033812d), radius: 0.23340610364748748d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07528658139609967d, y: 0.3095897413080154d), radius: 0.6273070548097156d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.964972846195097d, y: 0.9143219988313204d), radius: 0.5277744327540608d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8168342032365026d, y: 0.5783276095416716d), radius: 0.2524738452697347d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1053558363865803d, y: 0.14597347302047126d), radius: 0.8247745955946011d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4560167618603962d, y: 0.7921358672255162d), radius: 0.9656637847902284d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7828502036185281d, y: 0.35875438745197064d), radius: 0.4026128696001011d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7640124086510168d, y: 0.48709105983427925d), radius: 0.8748488516114369d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.849428615269198d, y: 0.9427698255048617d), radius: 0.7149206910432786d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2546914896453868d, y: 0.39779537080129745d), radius: 0.656910043269846d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.958496073153821d, y: 0.7382139698938994d), radius: 0.06065126588002645d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7656299611398221d, y: 0.4569843455547996d), radius: 0.7049366355267073d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5040268703747666d, y: 0.40566392155755926d), radius: 0.935110092888982d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04538245233552396d, y: 0.08150827904165292d), radius: 0.8218421649792972d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21220936148615166d, y: 0.7955935341211702d), radius: 0.4933562818427685d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8213767529859131d, y: 0.9150897846375453d), radius: 0.9034399756041076d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7639624503788045d, y: 0.20366395320518305d), radius: 0.9219537870872672d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3051598592556606d, y: 0.9879055751684148d), radius: 0.8008483931988936d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2594719991887846d, y: 0.014791337420908213d), radius: 0.5122929043353281d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24257424186521637d, y: 0.4173461866815116d), radius: 0.860808989504054d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9375069380992116d, y: 0.047743628422242224d), radius: 0.2120025718892682d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15932291940351562d, y: 0.8406485986413557d), radius: 0.6618771283012427d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0192247896742479d, y: 0.35232175957223866d), radius: 0.852362036173172d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3292266496731794d, y: 0.770195895605273d), radius: 0.19438412369429714d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7154036921296271d, y: 0.5512015650317719d), radius: 0.5649537962059215d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9760095380138681d, y: 0.8307529591681744d), radius: 0.8868105067470285d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48767671342102714d, y: 0.9520655513708305d), radius: 0.3481192083121557d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9563672987534926d, y: 0.12006375561045912d), radius: 0.7348574342272688d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48089577868824707d, y: 0.26597148604490883d), radius: 0.5654142421844088d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40456049977574227d, y: 0.07999892503347661d), radius: 0.011910338096274065d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10820818991648873d, y: 0.48177350541106523d), radius: 0.5001423381057079d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09585568735335881d, y: 0.4909165294156457d), radius: 0.8265413071088795d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5759543786617394d, y: 0.2799285628945518d), radius: 0.5771015991756355d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2772675288422273d, y: 0.575311606391325d), radius: 0.2549761332172349d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42856733809969594d, y: 0.3716324042119272d), radius: 0.3867830588076976d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13979361923202094d, y: 0.2559318451321426d), radius: 0.577792873482789d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5723499869760472d, y: 0.458851114627021d), radius: 0.22943194428816016d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5212540903642738d, y: 0.21105302302786055d), radius: 0.6311623166834875d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3885688961682001d, y: 0.7023627449376454d), radius: 0.16707860843986722d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4203759275187051d, y: 0.25911658486744304d), radius: 0.5860376782055121d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4988369324725149d, y: 0.6563841926335676d), radius: 0.16786368596904033d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05747444927825107d, y: 0.3267691136472187d), radius: 0.06129781435871684d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6971873192080005d, y: 0.8197876603356032d), radius: 0.7760737938454856d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49278503358217884d, y: 0.15689317769501798d), radius: 0.33876579239461335d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9355399449735374d, y: 0.6180692328738886d), radius: 0.7501851132449159d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15792165820849235d, y: 0.7981701500162928d), radius: 0.4551660700230574d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0505928802917891d, y: 0.7925222249761246d), radius: 0.04231193765514163d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8707694480363748d, y: 0.4627017363791053d), radius: 0.565045286988976d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9679936928809315d, y: 0.05365619037365321d), radius: 0.8359798745052133d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07404451907826826d, y: 0.3095007867210038d), radius: 0.5116831505807315d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9783026585438306d, y: 0.2209835334630299d), radius: 0.08671128106540671d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40643673414149906d, y: 0.7248242971305706d), radius: 0.13902022041834527d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4549097753439594d, y: 0.4131508287076995d), radius: 0.16851189859531968d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38591494877951094d, y: 0.6231351441896748d), radius: 0.47359310243435315d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8432806165006325d, y: 0.7648534516900578d), radius: 0.6178736067465974d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6920872351661659d, y: 0.08818093687728079d), radius: 0.9612861602142616d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7917812389658687d, y: 0.5108698615233407d), radius: 0.7728056551028145d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9512164003980335d, y: 0.5973640576780204d), radius: 0.7721362163483536d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28791645773472707d, y: 0.45342660415215985d), radius: 0.2044215801335718d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5647129148098481d, y: 0.19528296872025785d), radius: 0.10602438431567873d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6143969138222837d, y: 0.7202497182332362d), radius: 0.561772271331025d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.602441223422624d, y: 0.8580831529995595d), radius: 0.05349095268369919d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9586720504829145d, y: 0.14556296272529812d), radius: 0.5880170963855068d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37159021564424544d, y: 0.03112153052599631d), radius: 0.8533717855913318d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4058096846296678d, y: 0.6260134179980791d), radius: 0.27270778359714376d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2311866145053375d, y: 0.27553913549025655d), radius: 0.32307365637739005d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6279433202794031d, y: 0.20415569111207188d), radius: 0.6761940486259342d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2561663802280021d, y: 0.13293914889819536d), radius: 0.038625838996647066d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39547330578881246d, y: 0.5774764937074534d), radius: 0.9608300384777317d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.698053152913859d, y: 0.7775217914691515d), radius: 0.5983029750424651d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09191777891807551d, y: 0.5688869493093451d), radius: 0.2888860891286279d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5220218644595358d, y: 0.012386499476883528d), radius: 0.08971404168307962d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07339579571283195d, y: 0.003011692092354634d), radius: 0.9457241110534008d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9414590292803016d, y: 0.7775979558393803d), radius: 0.07270084004125099d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0456291553632151d, y: 0.4220010533008375d), radius: 0.6339121727614607d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4240068026555819d, y: 0.1495442045276042d), radius: 0.5280265758207978d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42786936093631556d, y: 0.119315225212415d), radius: 0.7340880844824973d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09317325570656887d, y: 0.3187365765145096d), radius: 0.3577994175741738d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33379303833448404d, y: 0.11389600004688405d), radius: 0.19067185616041027d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8274119420027908d, y: 0.14235389234391016d), radius: 0.20798751267327265d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09476567102320266d, y: 0.887272712856862d), radius: 0.8336169243924514d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8889843381091059d, y: 0.33313926453714304d), radius: 0.8667319275918967d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3184599198751794d, y: 0.20238316952064206d), radius: 0.7753283006300412d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2994962711181186d, y: 0.48097117834512526d), radius: 0.9017237956486214d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07808799910883646d, y: 0.6697021241733895d), radius: 0.8053792127707738d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12318459434175244d, y: 0.5804115381764615d), radius: 0.9566821303582504d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11616587771662934d, y: 0.9607892687921499d), radius: 0.1740676347393335d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9845793756372498d, y: 0.9869912457935014d), radius: 0.5501981250590149d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.062312682190445834d, y: 0.9054602646056241d), radius: 0.02631333051957785d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07547819204663031d, y: 0.9096799854003805d), radius: 0.6922174458541778d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27585833033052876d, y: 0.5015540903076182d), radius: 0.6768986858107424d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29080586163450073d, y: 0.18419038284419276d), radius: 0.12437610299344692d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6306557304838208d, y: 0.937695948711109d), radius: 0.3175046894225034d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03223108517146944d, y: 0.07642144630489911d), radius: 0.1525964508218497d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7034088533009712d, y: 0.10922440340657003d), radius: 0.6963162568997483d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.017154759979963186d, y: 0.9349089460034625d), radius: 0.580947868866246d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3899989173064832d, y: 0.5090291809134525d), radius: 0.44882258073416637d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.924663960193174d, y: 0.05687837106600413d), radius: 0.695473563386831d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0838544975938268d, y: 0.36487654854461693d), radius: 0.4783728033304183d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29889945642158033d, y: 0.40319642037071957d), radius: 0.21907578695433516d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9729315211332522d, y: 0.33248552767071005d), radius: 0.45718248961819874d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37674448638372926d, y: 0.8696401127232356d), radius: 0.21693232947651808d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18238800657983156d, y: 0.3201315651854024d), radius: 0.6914821214590728d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1490304873385655d, y: 0.6070739500654593d), radius: 0.41230345712353644d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7239929528095257d, y: 0.2617449106392622d), radius: 0.8729257165614018d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6133599225002342d, y: 0.5253085877431617d), radius: 0.8739504928954621d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43184996388876773d, y: 0.29451879567027917d), radius: 0.29701021013773066d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3156383141921255d, y: 0.5420896669915687d), radius: 0.9220871162549923d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.515416321876874d, y: 0.7709658786672124d), radius: 0.9904968627078145d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3546272718312692d, y: 0.6586962642717299d), radius: 0.614130279646261d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9593891877381144d, y: 0.9877072924939565d), radius: 0.36019448189970726d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18251339838974712d, y: 0.9553054661822813d), radius: 0.39158532257816125d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19119810343089327d, y: 0.060858112931309605d), radius: 0.34912693016855034d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4730743778010167d, y: 0.35652639649820284d), radius: 0.3951982467080145d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.020378335824161153d, y: 0.591399691221949d), radius: 0.3262941098020483d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7129954985000279d, y: 0.223310252824251d), radius: 0.8640888208732194d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29579816318163854d, y: 0.19542567552497858d), radius: 0.6645412046910457d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3674068640552052d, y: 0.7516764738082623d), radius: 0.09233845557489362d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.429988014549579d, y: 0.847937914792494d), radius: 0.38476279935948354d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5480873718578644d, y: 0.42944942588823476d), radius: 0.43486856980235233d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6149984766579211d, y: 0.7565941344886306d), radius: 0.4765800108008694d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6819747136531946d, y: 0.5676719342384906d), radius: 0.23247573146388878d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4221741726960633d, y: 0.10405186012523115d), radius: 0.09490917897169493d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8049879042180524d, y: 0.47041461901799d), radius: 0.4059719205214629d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1877687092184276d, y: 0.6476497368937644d), radius: 0.5656124467052558d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2849452370125565d, y: 0.26301307982368693d), radius: 0.06937594712867423d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5770757177598586d, y: 0.4516544428044984d), radius: 0.01744457021296575d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17935027570685258d, y: 0.9524754578275147d), radius: 0.3284335997280212d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06980999298882351d, y: 0.7564051707469405d), radius: 0.6924678965250052d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03657821934922734d, y: 0.6984650080467742d), radius: 0.5740447340025275d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4141094367865734d, y: 0.21651796040778537d), radius: 0.2567228096743801d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16106233951887228d, y: 0.47770953102804237d), radius: 0.6374323856683365d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9478420017014367d, y: 0.3079865250449888d), radius: 0.8013246634287133d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.666521310173275d, y: 0.09201871120423066d), radius: 0.8176111517087158d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8700758448739856d, y: 0.41536480187004343d), radius: 0.7153986416820789d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28107178581705083d, y: 0.8619346747383302d), radius: 0.09109374626989686d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47769812125683253d, y: 0.34811771752613474d), radius: 0.275579795177437d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4814147798584739d, y: 0.3597891562207082d), radius: 0.5732964696796975d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8800305503959943d, y: 0.07088874719156901d), radius: 0.08188618468992581d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2273718796944344d, y: 0.7492429548620423d), radius: 0.6284606384213262d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7142880905540202d, y: 0.6922858598933123d), radius: 0.16474441037281218d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7576915821481774d, y: 0.36587263234383705d), radius: 0.9068999890268715d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8691242291573531d, y: 0.210925602885208d), radius: 0.09119570918804332d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41398905386435847d, y: 0.6218396933874547d), radius: 0.9866175504146626d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.037058675464854196d, y: 0.9489478711909459d), radius: 0.6119843535473555d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48868037520027063d, y: 0.17540549385537774d), radius: 0.2756864079519564d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29343233934051616d, y: 0.2659651591072121d), radius: 0.20841565959477404d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9601661593233166d, y: 0.8248196304996146d), radius: 0.5450800087417361d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08831190048026616d, y: 0.13432511337222208d), radius: 0.5295815885236023d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5465138783900553d, y: 0.6234087524891138d), radius: 0.8051147863927274d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.739792157748918d, y: 0.22037499301438812d), radius: 0.2907647237930243d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08267222474155833d, y: 0.7732590554159481d), radius: 0.15441491486435655d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.849436075165657d, y: 0.24830469770264474d), radius: 0.7769762600427316d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2150541651361617d, y: 0.30888443791783315d), radius: 0.4314345947501196d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11499914818351753d, y: 0.692747962342669d), radius: 0.1512463735858277d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7514054995905934d, y: 0.5177853647802466d), radius: 0.8256309734719303d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2712302333051857d, y: 0.16765555151572287d), radius: 0.1669123876280444d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2582092980263917d, y: 0.006828658684771116d), radius: 0.7667262929569483d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09231882089690613d, y: 0.23327534330358568d), radius: 0.7252934917982569d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.027278637135321304d, y: 0.7367303491002604d), radius: 0.8076376542738475d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5225364034898402d, y: 0.8505740595289746d), radius: 0.4645267731667888d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12601800274787522d, y: 0.6262326943973058d), radius: 0.8575526512081451d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2811110845537991d, y: 0.1989408632104882d), radius: 0.6125522931800622d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08781832279127233d, y: 0.2797155001137498d), radius: 0.7559106553160604d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2908327734004539d, y: 0.9000398778651039d), radius: 0.37355903119654366d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7230029693347866d, y: 0.3010555346018611d), radius: 0.7741568425200327d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.927703684070016d, y: 0.2052013655988053d), radius: 0.49834742528122633d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03955064468382463d, y: 0.10066768810618643d), radius: 0.9390615746291286d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6291492696136741d, y: 0.09495312359150199d), radius: 0.31267876752264634d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08132276520289738d, y: 0.97796963405274d), radius: 0.9269510568163738d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3001985922191106d, y: 0.42543540406993163d), radius: 0.3510191306455641d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3765905292241084d, y: 0.9724456297908546d), radius: 0.7832198445702657d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7155950161709611d, y: 0.2002832371033092d), radius: 0.6730637819843852d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2352295365694984d, y: 0.48387827810595985d), radius: 0.8650269020291165d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5573353771519818d, y: 0.9350134706724567d), radius: 0.2692513706382643d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12826738949137562d, y: 0.9789925457501993d), radius: 0.7921410225528557d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9955588000349048d, y: 0.3581295871084056d), radius: 0.7609505334469847d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12390224791707549d, y: 0.2385586507372386d), radius: 0.851491813110821d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9365578862464998d, y: 0.41265265952875885d), radius: 0.8992855093595172d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.679810188120047d, y: 0.14914505381738408d), radius: 0.6121958284579643d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9040050791126428d, y: 0.32317940591101557d), radius: 0.18147276274743196d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8907420226443116d, y: 0.3732777443837467d), radius: 0.529153355194998d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8224677469497547d, y: 0.20226404843620627d), radius: 0.850855196113372d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08903916695877945d, y: 0.684242472927987d), radius: 0.3165710122765887d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8774805059828249d, y: 0.9479844676745752d), radius: 0.1952442629286616d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2728819464289237d, y: 0.9890382920441533d), radius: 0.19653719766214361d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7372780155778295d, y: 0.015821806219248002d), radius: 0.6573004309483914d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03538310404495704d, y: 0.6063896857501287d), radius: 0.09080061865048672d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5927532451066064d, y: 0.3298173720927047d), radius: 0.504853581449057d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09329946072110706d, y: 0.9370403278220053d), radius: 0.8214936101911327d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6492378251029325d, y: 0.6709403912761414d), radius: 0.9927438061115091d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5250339722687452d, y: 0.5913648188543809d), radius: 0.8115025342429367d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12021135467396604d, y: 0.6741142675549173d), radius: 0.6036843325027146d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8662288806077665d, y: 0.4875077654251654d), radius: 0.0336940343834814d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.519753514777824d, y: 0.5627990770721865d), radius: 0.4722163945291197d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4120093424228165d, y: 0.05157009756290176d), radius: 0.0431001921009776d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6285491046433132d, y: 0.34203926148667285d), radius: 0.3990528637913998d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.558365127125867d, y: 0.9713266834989224d), radius: 0.8376940170414507d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7770985509632095d, y: 0.8605185765665077d), radius: 0.7550667755544664d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7681596407921317d, y: 0.6225536050078031d), radius: 0.5049221449119029d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6420702449361518d, y: 0.7325876344879615d), radius: 0.9612857305485923d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1253597296910548d, y: 0.4548849558063942d), radius: 0.5318244509881012d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5135098239229701d, y: 0.8464780873581302d), radius: 0.18508449400690796d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5608523947622385d, y: 0.7526492743346309d), radius: 0.9723370887545364d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6075083548472675d, y: 0.02374936142995454d), radius: 0.4495124606474059d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3415767206638928d, y: 0.4503969252686676d), radius: 0.8302212885870981d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9269622617844614d, y: 0.5870840480233595d), radius: 0.29289968781242837d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3968311762803509d, y: 0.035461158992800446d), radius: 0.45504023795193693d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8377919922881975d, y: 0.24259394304780157d), radius: 0.25349111981299377d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14753517728145238d, y: 0.5529162669244686d), radius: 0.407570283835311d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03343847038591541d, y: 0.10962448016213133d), radius: 0.9435505462157339d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5602064331075578d, y: 0.4931425175678553d), radius: 0.31014232533512853d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.666703787877583d, y: 0.22255613246523687d), radius: 0.9239475162837018d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9707368081540897d, y: 0.7968689696479271d), radius: 0.3711384673639817d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02954440309980033d, y: 0.9595988208937347d), radius: 0.9340445758523839d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47996580444842374d, y: 0.6059487040270284d), radius: 0.5336657053134076d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4797545493802702d, y: 0.44645813170982396d), radius: 0.7429858580873991d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5343925669775169d, y: 0.02658156171855841d), radius: 0.9827784960646607d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5713138869252882d, y: 0.09644022216968984d), radius: 0.7562193783048966d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6484196690604883d, y: 0.05775574030276642d), radius: 0.42687763839781956d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6074164274095388d, y: 0.3846005354783554d), radius: 0.8107030677519449d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48982460299311215d, y: 0.5788921309597707d), radius: 0.4926614424396456d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9911880113112975d, y: 0.18438218541485074d), radius: 0.8374400456785718d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14310050232211102d, y: 0.9304346147742818d), radius: 0.7658495431025485d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5357200701798606d, y: 0.684872855366425d), radius: 0.13881900817502424d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 161,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9466646203054471d, y: 0.49873516891131764d), radius: 0.5899766479553779d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3006669770970123d, y: 0.12099639508576432d), radius: 0.7376761235434824d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5933093256284431d, y: 0.34384706166633827d), radius: 0.8510832067725764d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9914133081595301d, y: 0.06631278024536658d), radius: 0.9124165913809005d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.58403034038551d, y: 0.31729604507486886d), radius: 0.9090626528675425d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9076044547506228d, y: 0.1651085716260694d), radius: 0.7771394484217296d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.025272932946416526d, y: 0.03046176694218905d), radius: 0.15337102415718784d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 165,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5246663901866873d, y: 0.5332331090921055d), radius: 0.5621273762388191d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9908484202878153d, y: 0.09050458494661784d), radius: 0.804085547071065d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5653496451549742d, y: 0.6228445493291712d), radius: 0.17657246900008783d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7852937128930119d, y: 0.716205593719123d), radius: 0.7085258538952145d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7975737135839622d, y: 0.8047164891647064d), radius: 0.5492742421383092d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6267867525249784d, y: 0.6541821200867464d), radius: 0.8032771778301364d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9232942780418816d, y: 0.11467457244552093d), radius: 0.4112000925957684d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7845889336843326d, y: 0.37617043745977496d), radius: 0.1269862970808011d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3415019461806683d, y: 0.22667514112316456d), radius: 0.9067805251337363d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06289946217599252d, y: 0.46194641302240347d), radius: 0.9042730569392999d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 173,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15388016939801297d, y: 0.5954802040695302d), radius: 0.27101403594481543d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48943725053688614d, y: 0.6265787070065107d), radius: 0.8114473922167847d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2498047950722243d, y: 0.718022038931162d), radius: 0.8838182634444243d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7924783717128886d, y: 0.005041390968400727d), radius: 0.2809782696919537d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0004382773707504173d, y: 0.8588217330852155d), radius: 0.7103026183488976d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26850442877386516d, y: 0.6914919069474299d), radius: 0.7358332173820715d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.023934457586475055d, y: 0.5015940500613085d), radius: 0.16581572645920062d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7382898580391967d, y: 0.2325188018836114d), radius: 0.08030642157586187d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 177,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2423270812436782d, y: 0.4892314756135435d), radius: 0.5217827813757174d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8007461344958524d, y: 0.10484971855492675d), radius: 0.1194685864387699d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7780106196916164d, y: 0.6260164691005252d), radius: 0.031770195382856414d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09802525560209008d, y: 0.6515562021934168d), radius: 0.9578485449142673d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9269064176189877d, y: 0.7406165441182715d), radius: 0.05219798583594282d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12875239069367073d, y: 0.086031162899736d), radius: 0.9030717334291299d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.004935018970879335d, y: 0.1149359594797934d), radius: 0.3018975159496603d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7266370141345851d, y: 0.14684914863989584d), radius: 0.5924991561157515d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 179,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6899868833247065d, y: 0.8034295536057496d), radius: 0.648222897249124d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5948303374210339d, y: 0.36010048085727697d), radius: 0.5410241405744801d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5864260093040685d, y: 0.7486858772427795d), radius: 0.4188639463612942d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17235561543971223d, y: 0.6790328119426039d), radius: 0.9639370544819297d),

},
    ModelInner = null,
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

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M), typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                ((INpgsqlCircleListcircleArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlCircleListcircleArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlCircleListcircleArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
            overrideAliasPrefixs: null,
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var models = ((INpgsqlCircleListcircleArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M), typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                ((INpgsqlCircleListcircleArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleListcircleArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleListcircleArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
            overrideAliasPrefixs: null,
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                var models = ((INpgsqlCircleListcircleArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M), typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 5;
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
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
FROM public.npgsqlcirclecirclearray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
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
FROM public.npgsqlcirclecirclearray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[32],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
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
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[34], false);
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 48;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[23],_testData[34], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[34], false);
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
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[31],_testData[34], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelDynParBatch",
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
                var models = await((INpgsqlCircleListcircleArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[7], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[8], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[9], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[10], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[11], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[12], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[13], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[14], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[27],_testData[34], false);
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
                var models = ((INpgsqlCircleListcircleArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M), typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 140, query1, 7, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 99, query1, 72, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 131, query1, 173, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 143, query1, 90, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
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
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 48, query1, 85, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 72, query1, 44, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[26],_testData[34], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 79, query1, 131, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelBatch(connection, 31, query1, 45, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[25],_testData[34], false);
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
            overrideAliasPrefixs: null,
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
            batchName: "DbConnectionSTSelectModelBatch",
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
        private void DbConnectionSTSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((INpgsqlCircleListcircleArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelBatchAsync(connection, 7, 116))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[2], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[3], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[4], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[5], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[6], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[7], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[8], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[9], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[10], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[11], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[12], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[13], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[14], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[27],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[28],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[29],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[30],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[31],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[34], false);
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
                var models = ((INpgsqlCircleListcircleArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelBatch(connection, 173, 31))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[6], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[7], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[8], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[9], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[10], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[11], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[12], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[13], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[14], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[27],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[28],_testData[34], false);
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
                ((INpgsqlCircleListcircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 63);
                var models = await ((INpgsqlCircleListcircleArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(21));

                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[14], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[15], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[16], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[17], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[18], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[19], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[20], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[21], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[22], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[23], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[24], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[25], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[26], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[27], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[28], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[29], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[30], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[31], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[32], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[33], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleListcircleArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleListcircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 65);
                var models =  ((INpgsqlCircleListcircleArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(20));

                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[15], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[16], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[17], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[18], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[19], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[20], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[21], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[22], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[23], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[24], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[25], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[26], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[27], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[28], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[29], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[30], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[31], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[32], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[33], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[34], false);
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
FROM public.binary_npgsqlcirclecirclearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray2MIWA),
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleListcircleArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleListcircleArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleListcircleArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleListcircleArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleListcircleArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleListcircleArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleListcircleArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleListcircleArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

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
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray2MI),
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleListcircleArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleListcircleArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleListcircleArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleListcircleArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleListcircleArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleListcircleArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleListcircleArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleListcircleArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            queryMapType: typeof(NpgsqlCirclecircleArray2M),
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleListcircleArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlCircleListcircleArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleListcircleArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleListcircleArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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

        [Test, Order(13)]
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
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA), typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models1 = new List<NpgsqlCirclecircleArray2MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray2MIWA>();
                await ((INpgsqlCircleListcircleArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray2MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray2MIWA>();
                ((INpgsqlCircleListcircleArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models = await ((INpgsqlCircleListcircleArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
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
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleListcircleArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
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
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA), typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
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
                var models1 = new List<NpgsqlCirclecircleArray2MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray2MIWA>();
                await ((INpgsqlCircleListcircleArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray2MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray2MIWA>();
                ((INpgsqlCircleListcircleArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
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
                var models = await ((INpgsqlCircleListcircleArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
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
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleListcircleArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
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
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclearray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MI), typeof(NpgsqlCirclecircleArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models1 = new List<NpgsqlCirclecircleArray2MI>();
                var models2 = new List<NpgsqlCirclecircleArray2MI>();
                await ((INpgsqlCircleListcircleArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray2MI>();
                var models2 = new List<NpgsqlCirclecircleArray2MI>();
                ((INpgsqlCircleListcircleArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models = await ((INpgsqlCircleListcircleArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleListcircleArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclearray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA), typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
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
                var models1 = new List<NpgsqlCirclecircleArray2MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray2MIWA>();
                await ((INpgsqlCircleListcircleArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray2MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray2MIWA>();
                ((INpgsqlCircleListcircleArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
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
                var models = await ((INpgsqlCircleListcircleArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleListcircleArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

