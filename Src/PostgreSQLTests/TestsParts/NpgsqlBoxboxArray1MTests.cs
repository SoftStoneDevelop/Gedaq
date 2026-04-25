

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
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7201260886768547d,right: 0.6737864886824229d,bottom: 0.41019470220741694d,left: 0.14537712256726665d),
new NpgsqlTypes.NpgsqlBox(top: 0.3030429156661427d,right: 0.9618086785046741d,bottom: 0.1739215396813576d,left: 0.2694717662254946d),
new NpgsqlTypes.NpgsqlBox(top: 0.8370793201958627d,right: 0.38678714003727155d,bottom: 0.3041103307631907d,left: 0.3290444952339505d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8622294815144664d,right: 0.44572284779451254d,bottom: 0.11565292412229067d,left: 0.05647665628816567d),
new NpgsqlTypes.NpgsqlBox(top: 0.9054453307692586d,right: 0.6463900905575606d,bottom: 0.14588571613913703d,left: 0.15587309388777348d),
new NpgsqlTypes.NpgsqlBox(top: 0.9767731992193668d,right: 0.800269787486409d,bottom: 0.4562485281141413d,left: 0.7436970263556655d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.44710273024570135d,right: 0.6839843243575737d,bottom: 0.23657909936194488d,left: 0.3099742329631776d),
new NpgsqlTypes.NpgsqlBox(top: 0.9308214347212668d,right: 0.7693172935629075d,bottom: 0.7536434514733424d,left: 0.7166145100819324d),
new NpgsqlTypes.NpgsqlBox(top: 0.8280770103089672d,right: 0.44523062210621533d,bottom: 0.211365777358273d,left: 0.3055460197786747d),
new NpgsqlTypes.NpgsqlBox(top: 0.7873906341254391d,right: 0.5098853025626578d,bottom: 0.6058323935701956d,left: 0.2893994200418829d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5594868372332024d,right: 0.6395100466513753d,bottom: 0.27375006538303914d,left: 0.4135148592564053d),
new NpgsqlTypes.NpgsqlBox(top: 0.78894253854048d,right: 0.5785069783887307d,bottom: 0.36367674036263387d,left: 0.25181723310417814d),
new NpgsqlTypes.NpgsqlBox(top: 0.12933312065873448d,right: 0.6353645367076826d,bottom: 0.03964994550129319d,left: 0.3426468529038941d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.10954721934144251d,right: 0.8415313305153463d,bottom: 0.02396207300077291d,left: 0.13220356600892946d),
new NpgsqlTypes.NpgsqlBox(top: 0.9066680027604357d,right: 0.9834118334821659d,bottom: 0.4313220523666488d,left: 0.806882406707702d),
new NpgsqlTypes.NpgsqlBox(top: 0.9948528627060071d,right: 0.5613290374522232d,bottom: 0.6792387837044436d,left: 0.14531452929468125d),
new NpgsqlTypes.NpgsqlBox(top: 0.5997405557067557d,right: 0.8710821528132d,bottom: 0.1436687383709605d,left: 0.823343489708421d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4881131280844656d,right: 0.8717696497072497d,bottom: 0.090797296027048d,left: 0.6770274259408898d),
new NpgsqlTypes.NpgsqlBox(top: 0.15133889758651564d,right: 0.9702468022384283d,bottom: 0.01613013817817388d,left: 0.7840477186082309d),
new NpgsqlTypes.NpgsqlBox(top: 0.9372095362335751d,right: 0.7494836393196361d,bottom: 0.6614587211553385d,left: 0.6313913016442075d),
new NpgsqlTypes.NpgsqlBox(top: 0.8419956966740924d,right: 0.9375376687554754d,bottom: 0.08908183363143007d,left: 0.8480318970683329d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8271879564808764d,right: 0.44473754499800355d,bottom: 0.09943657387206428d,left: 0.31061696188393473d),
new NpgsqlTypes.NpgsqlBox(top: 0.26592784722045204d,right: 0.8527053289290196d,bottom: 0.1276070363594245d,left: 0.7728974629193056d),
new NpgsqlTypes.NpgsqlBox(top: 0.48358073820922254d,right: 0.713312405977431d,bottom: 0.2006010381602501d,left: 0.22749536182725305d),
new NpgsqlTypes.NpgsqlBox(top: 0.6281733917086646d,right: 0.42458799898455024d,bottom: 0.37625682846484176d,left: 0.33942950550249695d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7685627640008036d,right: 0.9202910545361308d,bottom: 0.15514375464807062d,left: 0.8153584239091561d),
new NpgsqlTypes.NpgsqlBox(top: 0.9694430131530026d,right: 0.7542239429321875d,bottom: 0.10911072677179323d,left: 0.49343746290007673d),
new NpgsqlTypes.NpgsqlBox(top: 0.6569353288888454d,right: 0.4995922884026792d,bottom: 0.5438903989685783d,left: 0.4704887115774553d),
new NpgsqlTypes.NpgsqlBox(top: 0.818844437902646d,right: 0.4512961351349074d,bottom: 0.6372285912822033d,left: 0.10517431616979711d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7209161688899259d,right: 0.26502464245442214d,bottom: 0.4839402672874319d,left: 0.19442988712888531d),
new NpgsqlTypes.NpgsqlBox(top: 0.7372512176521331d,right: 0.9238987814941013d,bottom: 0.37489639293118193d,left: 0.5101588030246458d),
new NpgsqlTypes.NpgsqlBox(top: 0.723896369103013d,right: 0.7737293141700621d,bottom: 0.06590012309021098d,left: 0.7504760291121976d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5294376167909448d,right: 0.4665470655799845d,bottom: 0.3289816183990655d,left: 0.437983494223092d),
new NpgsqlTypes.NpgsqlBox(top: 0.27247864497358487d,right: 0.8783197540618306d,bottom: 0.22840013710672502d,left: 0.04313897687140644d),
new NpgsqlTypes.NpgsqlBox(top: 0.9099043941602142d,right: 0.721071226694828d,bottom: 0.2459259112294938d,left: 0.6497392667022175d),
new NpgsqlTypes.NpgsqlBox(top: 0.6484278112443922d,right: 0.9940719706184247d,bottom: 0.4762815792059888d,left: 0.9026180402082558d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9623633794636242d,right: 0.599462121151712d,bottom: 0.6144847930769025d,left: 0.296845417134581d),
new NpgsqlTypes.NpgsqlBox(top: 0.7802584076554531d,right: 0.3623717559900069d,bottom: 0.6516692574780691d,left: 0.1023688667296686d),
new NpgsqlTypes.NpgsqlBox(top: 0.7440081153327647d,right: 0.5737243166724667d,bottom: 0.5677996830615982d,left: 0.5399314986446608d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9776279200783599d,right: 0.9468600601758612d,bottom: 0.6945881002302234d,left: 0.5216617793854096d),
new NpgsqlTypes.NpgsqlBox(top: 0.18098696391779623d,right: 0.6889992386775129d,bottom: 0.027372130818144158d,left: 0.09471263806961872d),
new NpgsqlTypes.NpgsqlBox(top: 0.7553302618949854d,right: 0.6892788332176487d,bottom: 0.5139814040958331d,left: 0.5847115953158419d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5867839379169227d,right: 0.6498634200799357d,bottom: 0.18195781504997688d,left: 0.2923613445277443d),
new NpgsqlTypes.NpgsqlBox(top: 0.3763215570880244d,right: 0.18544060353121605d,bottom: 0.31465180277812177d,left: 0.018257303983140294d),
new NpgsqlTypes.NpgsqlBox(top: 0.5074661709410102d,right: 0.6304940180312818d,bottom: 0.3449753338097342d,left: 0.2224964193961384d),
new NpgsqlTypes.NpgsqlBox(top: 0.6112730633246102d,right: 0.945074147708596d,bottom: 0.14892755863161178d,left: 0.3458720244573462d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.965700959683687d,right: 0.664606949161966d,bottom: 0.04940279328255004d,left: 0.43840175368031d),
new NpgsqlTypes.NpgsqlBox(top: 0.4278377968674696d,right: 0.7729505422659335d,bottom: 0.4086624050791431d,left: 0.28837063974925947d),
new NpgsqlTypes.NpgsqlBox(top: 0.7484147206705315d,right: 0.8689300466681894d,bottom: 0.35985338717185356d,left: 0.6931291176408884d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8233508286356694d,right: 0.48866796319762884d,bottom: 0.13552508945216524d,left: 0.3437839412390994d),
new NpgsqlTypes.NpgsqlBox(top: 0.8750731988369266d,right: 0.6882306162964219d,bottom: 0.6430572646147003d,left: 0.3591766058326299d),
new NpgsqlTypes.NpgsqlBox(top: 0.9764191420483161d,right: 0.6070052580841336d,bottom: 0.45328317035846266d,left: 0.31487072023693463d),
new NpgsqlTypes.NpgsqlBox(top: 0.7072244173580416d,right: 0.6295898273379673d,bottom: 0.06592132467433054d,left: 0.3925167190561173d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8906150238231719d,right: 0.4830411037326704d,bottom: 0.340086447041407d,left: 0.4560935569685367d),
new NpgsqlTypes.NpgsqlBox(top: 0.6690974041419427d,right: 0.4642309194957266d,bottom: 0.23730518103746334d,left: 0.18972019441739274d),
new NpgsqlTypes.NpgsqlBox(top: 0.8150609723457487d,right: 0.8380914547165196d,bottom: 0.4270028324796048d,left: 0.2935995297508923d),
new NpgsqlTypes.NpgsqlBox(top: 0.8792115984284559d,right: 0.7250631132441189d,bottom: 0.010996149706570035d,left: 0.10433744242489751d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9173624332874131d,right: 0.6149274228197608d,bottom: 0.4945399299126799d,left: 0.28449469923531734d),
new NpgsqlTypes.NpgsqlBox(top: 0.8011909720156413d,right: 0.9479048477225167d,bottom: 0.6343695664784319d,left: 0.031281301903742675d),
new NpgsqlTypes.NpgsqlBox(top: 0.8121689011541239d,right: 0.6156556936041724d,bottom: 0.5240465190422116d,left: 0.22133192052636685d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7366105283542785d,right: 0.6278417723685427d,bottom: 0.26053514074023454d,left: 0.32721060378564226d),
new NpgsqlTypes.NpgsqlBox(top: 0.630994907465697d,right: 0.6334583253139898d,bottom: 0.2017871031335322d,left: 0.29247616867510706d),
new NpgsqlTypes.NpgsqlBox(top: 0.9107836388044652d,right: 0.44750607477129567d,bottom: 0.8248600939282039d,left: 0.07501162438898679d),
new NpgsqlTypes.NpgsqlBox(top: 0.5411393345589931d,right: 0.6159333094896238d,bottom: 0.35703453761969284d,left: 0.344114552052581d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5054588939352979d,right: 0.8342747746117892d,bottom: 0.009240198362257868d,left: 0.7592716707744415d),
new NpgsqlTypes.NpgsqlBox(top: 0.936361623267968d,right: 0.6554534060625132d,bottom: 0.20136121236728288d,left: 0.03636659390712571d),
new NpgsqlTypes.NpgsqlBox(top: 0.9015226104973734d,right: 0.7973210402929255d,bottom: 0.014265793620666933d,left: 0.06511826536319787d),
new NpgsqlTypes.NpgsqlBox(top: 0.7521114230713147d,right: 0.5038881683972954d,bottom: 0.7276599055026414d,left: 0.1571867486649009d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4125118743705839d,right: 0.5052833938109688d,bottom: 0.18525102116830416d,left: 0.43708693095579276d),
new NpgsqlTypes.NpgsqlBox(top: 0.6652699885252865d,right: 0.8767523374426901d,bottom: 0.15991660448390754d,left: 0.7614978670706889d),
new NpgsqlTypes.NpgsqlBox(top: 0.7650468774497451d,right: 0.7903535303471245d,bottom: 0.7416146447589697d,left: 0.6209712545894154d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.843008725928585d,right: 0.3778692468733943d,bottom: 0.7367642025039328d,left: 0.17818951183571896d),
new NpgsqlTypes.NpgsqlBox(top: 0.7619109499494038d,right: 0.7775325986950719d,bottom: 0.41029249329315853d,left: 0.357595497745995d),
new NpgsqlTypes.NpgsqlBox(top: 0.8293070198571878d,right: 0.9070798449792856d,bottom: 0.11079093396883322d,left: 0.8196034060244184d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8695703481773178d,right: 0.3172455849975555d,bottom: 0.3045482505244025d,left: 0.16687323410543753d),
new NpgsqlTypes.NpgsqlBox(top: 0.7308430939834861d,right: 0.7754873484669508d,bottom: 0.7154425319918241d,left: 0.3450893428306414d),
new NpgsqlTypes.NpgsqlBox(top: 0.4671644692148941d,right: 0.9954849693459237d,bottom: 0.04187232775430161d,left: 0.7839832632479627d),
new NpgsqlTypes.NpgsqlBox(top: 0.629341323083145d,right: 0.24931728379521967d,bottom: 0.18595422427928743d,left: 0.23371213580813854d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7485200409895525d,right: 0.15337196534438535d,bottom: 0.6026462093596627d,left: 0.012460262645627829d),
new NpgsqlTypes.NpgsqlBox(top: 0.6703216803520227d,right: 0.8052362879060048d,bottom: 0.46553561717444225d,left: 0.17360191646456702d),
new NpgsqlTypes.NpgsqlBox(top: 0.7797512739691654d,right: 0.893193992579554d,bottom: 0.18758714989979242d,left: 0.6854745587681842d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.1373486462771022d,right: 0.7705107787036928d,bottom: 0.0014890541469412266d,left: 0.04289131666855173d),
new NpgsqlTypes.NpgsqlBox(top: 0.6440841696915798d,right: 0.53744076348053d,bottom: 0.5867431703038192d,left: 0.5078976741014021d),
new NpgsqlTypes.NpgsqlBox(top: 0.6437936480632355d,right: 0.8954777426962848d,bottom: 0.492174216434877d,left: 0.6646010056986443d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.15837877258568078d,right: 0.5748216378862762d,bottom: 0.103346746269258d,left: 0.5406074773066208d),
new NpgsqlTypes.NpgsqlBox(top: 0.9326788407015751d,right: 0.5581803542581559d,bottom: 0.5001150400322469d,left: 0.39768924647586734d),
new NpgsqlTypes.NpgsqlBox(top: 0.9786931254688171d,right: 0.914360334204693d,bottom: 0.050310954050487355d,left: 0.3248072287813253d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6788933077641709d,right: 0.9314676205356925d,bottom: 0.3286333768496774d,left: 0.2748231732610096d),
new NpgsqlTypes.NpgsqlBox(top: 0.21184217431109398d,right: 0.4436639088329113d,bottom: 0.15339424789829992d,left: 0.3348123772766024d),
new NpgsqlTypes.NpgsqlBox(top: 0.7328956266233977d,right: 0.9886569171847741d,bottom: 0.5690747517880426d,left: 0.42188334906042435d),
new NpgsqlTypes.NpgsqlBox(top: 0.4579922568848971d,right: 0.7111878890949068d,bottom: 0.4064929382406529d,left: 0.38720690836246086d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4285125034932348d,right: 0.8007821743174879d,bottom: 0.2642198948574819d,left: 0.711742018135861d),
new NpgsqlTypes.NpgsqlBox(top: 0.9455827490446173d,right: 0.8294693278293953d,bottom: 0.47291452604113904d,left: 0.5145093321763343d),
new NpgsqlTypes.NpgsqlBox(top: 0.8260178553759031d,right: 0.6292064521733512d,bottom: 0.31991672083609035d,left: 0.18868532066751198d),
new NpgsqlTypes.NpgsqlBox(top: 0.9979094148501496d,right: 0.8011859265066948d,bottom: 0.15445942689625103d,left: 0.036795683735432294d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.537499593512508d,right: 0.8961872537747795d,bottom: 0.49093697516521106d,left: 0.42456681279050545d),
new NpgsqlTypes.NpgsqlBox(top: 0.3943772643377752d,right: 0.755928326391943d,bottom: 0.21160832389235762d,left: 0.18193854188533243d),
new NpgsqlTypes.NpgsqlBox(top: 0.5479442247045586d,right: 0.9778672189447913d,bottom: 0.09776069336514848d,left: 0.2728280953967164d),
new NpgsqlTypes.NpgsqlBox(top: 0.40861325321523356d,right: 0.2457413885099463d,bottom: 0.2662804827919282d,left: 0.14091924184536808d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9700210105319742d,right: 0.2690533892508584d,bottom: 0.5430949577898501d,left: 0.2354132939003789d),
new NpgsqlTypes.NpgsqlBox(top: 0.9540725191754602d,right: 0.5323864802454717d,bottom: 0.0451491782928366d,left: 0.20416820622588694d),
new NpgsqlTypes.NpgsqlBox(top: 0.6914409377734787d,right: 0.733343735740232d,bottom: 0.08352797507314624d,left: 0.4024570633328688d),
new NpgsqlTypes.NpgsqlBox(top: 0.985364407369462d,right: 0.2793003388576578d,bottom: 0.20446648843810056d,left: 0.2689931281282679d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7902334851119296d,right: 0.7428449426806945d,bottom: 0.13412541715498827d,left: 0.5067397736676442d),
new NpgsqlTypes.NpgsqlBox(top: 0.8850708765485301d,right: 0.5916432067003993d,bottom: 0.31121327507133767d,left: 0.524312011824063d),
new NpgsqlTypes.NpgsqlBox(top: 0.7030820347911385d,right: 0.5840245785482309d,bottom: 0.08378983585549549d,left: 0.33488245773745084d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.17431776444852254d,right: 0.2984377563281686d,bottom: 0.09951122902653775d,left: 0.10617583908425432d),
new NpgsqlTypes.NpgsqlBox(top: 0.6125755897443975d,right: 0.9590257124677011d,bottom: 0.39946327975755014d,left: 0.0009781672146798037d),
new NpgsqlTypes.NpgsqlBox(top: 0.28560193136457546d,right: 0.970558390059547d,bottom: 0.18361426276132653d,left: 0.19467143104857398d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.27787457169632435d,right: 0.4145639942900755d,bottom: 0.05302841460616958d,left: 0.1873064207464895d),
new NpgsqlTypes.NpgsqlBox(top: 0.9305347513384086d,right: 0.9898387497562627d,bottom: 0.7515738060976562d,left: 0.5415311284987021d),
new NpgsqlTypes.NpgsqlBox(top: 0.741801266575086d,right: 0.6452578007537457d,bottom: 0.5561501832647984d,left: 0.054915809153033734d),
new NpgsqlTypes.NpgsqlBox(top: 0.5241736833041395d,right: 0.8425657723410054d,bottom: 0.2437853045988322d,left: 0.7883384401413751d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5546342999428271d,right: 0.9134046530435449d,bottom: 0.34012639754975393d,left: 0.6878269386112842d),
new NpgsqlTypes.NpgsqlBox(top: 0.8922657713760263d,right: 0.387331672520531d,bottom: 0.24646117306641535d,left: 0.26152349582450685d),
new NpgsqlTypes.NpgsqlBox(top: 0.9870044970803341d,right: 0.7594430459305787d,bottom: 0.5330331619330744d,left: 0.35890647505092255d),
new NpgsqlTypes.NpgsqlBox(top: 0.6586071689125309d,right: 0.49799012053681735d,bottom: 0.021393877359835445d,left: 0.018839249716567252d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4779844954404183d,right: 0.6191203843738597d,bottom: 0.361073434310492d,left: 0.4372196597329293d),
new NpgsqlTypes.NpgsqlBox(top: 0.5617443415418159d,right: 0.9535639103976364d,bottom: 0.2686536736926335d,left: 0.7472523521591502d),
new NpgsqlTypes.NpgsqlBox(top: 0.3829813184362827d,right: 0.76764959037175d,bottom: 0.16901100188467444d,left: 0.3181762367309532d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9373458800961274d,right: 0.7400761468997958d,bottom: 0.06131257559802594d,left: 0.5270050236051659d),
new NpgsqlTypes.NpgsqlBox(top: 0.842441382622806d,right: 0.615476215888863d,bottom: 0.08181190570060481d,left: 0.3133651821135235d),
new NpgsqlTypes.NpgsqlBox(top: 0.7523429036418271d,right: 0.9925355124424255d,bottom: 0.523538731644302d,left: 0.6644997608493448d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8633352870250631d,right: 0.23959676640631344d,bottom: 0.5568312097746012d,left: 0.08705577438553735d),
new NpgsqlTypes.NpgsqlBox(top: 0.8166509656421131d,right: 0.9221558848797853d,bottom: 0.6633671643167041d,left: 0.2758580491506951d),
new NpgsqlTypes.NpgsqlBox(top: 0.2840573525179122d,right: 0.994661155688053d,bottom: 0.07955889079952738d,left: 0.8701069296099644d),
new NpgsqlTypes.NpgsqlBox(top: 0.8872309152736249d,right: 0.7009753416898495d,bottom: 0.7556149509452706d,left: 0.027886476262906523d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9977570362219662d,right: 0.9523157444520672d,bottom: 0.9914972787859407d,left: 0.048433971290382405d),
new NpgsqlTypes.NpgsqlBox(top: 0.6777431683287476d,right: 0.8416948370618967d,bottom: 0.45959415193369946d,left: 0.22993532207357725d),
new NpgsqlTypes.NpgsqlBox(top: 0.7175732478300654d,right: 0.6307430578078237d,bottom: 0.004851443442972947d,left: 0.28136632714598875d),
new NpgsqlTypes.NpgsqlBox(top: 0.6520808171966521d,right: 0.8968045776876375d,bottom: 0.6506323156472191d,left: 0.12287053490554734d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9345475450196638d,right: 0.6541996208943848d,bottom: 0.8621438800776525d,left: 0.039788032763665604d),
new NpgsqlTypes.NpgsqlBox(top: 0.9770442851944554d,right: 0.9764424043000598d,bottom: 0.2021540214992188d,left: 0.24893473509014874d),
new NpgsqlTypes.NpgsqlBox(top: 0.5894573089411845d,right: 0.8838639604929047d,bottom: 0.16444979308485075d,left: 0.03999164540251576d),
new NpgsqlTypes.NpgsqlBox(top: 0.8796253658182742d,right: 0.9955489768274448d,bottom: 0.7560037444397979d,left: 0.11570219911466839d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8627552677384418d,right: 0.6494986151853639d,bottom: 0.13570679906322003d,left: 0.52478790391333d),
new NpgsqlTypes.NpgsqlBox(top: 0.47581381287593805d,right: 0.6233273775839376d,bottom: 0.2856286767964754d,left: 0.2951568225917305d),
new NpgsqlTypes.NpgsqlBox(top: 0.22130508787952652d,right: 0.8741470694042038d,bottom: 0.18123098260644965d,left: 0.4835696048504342d),
new NpgsqlTypes.NpgsqlBox(top: 0.8039379155072124d,right: 0.7184205276167994d,bottom: 0.018579980193161205d,left: 0.696036376507779d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3276016620028702d,right: 0.42547421988857304d,bottom: 0.16725034714503972d,left: 0.39843169693213d),
new NpgsqlTypes.NpgsqlBox(top: 0.856173431002308d,right: 0.8878250424702073d,bottom: 0.4368551382316369d,left: 0.700750153663716d),
new NpgsqlTypes.NpgsqlBox(top: 0.7758827229858434d,right: 0.7123087368146285d,bottom: 0.5059848722095487d,left: 0.09875006935737973d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 92,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.44452113947938976d,right: 0.9400696273224348d,bottom: 0.1273967654674878d,left: 0.5295538634631379d),
new NpgsqlTypes.NpgsqlBox(top: 0.5806105509575552d,right: 0.10349306591363416d,bottom: 0.35792138746526736d,left: 0.1030215880640648d),
new NpgsqlTypes.NpgsqlBox(top: 0.5416066153749736d,right: 0.9249386029797042d,bottom: 0.15978573110120575d,left: 0.902538490945383d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4476467316578967d,right: 0.9613745376666315d,bottom: 0.3249207491051278d,left: 0.9579025086405335d),
new NpgsqlTypes.NpgsqlBox(top: 0.9680981802970406d,right: 0.5622598808232687d,bottom: 0.8571732544314785d,left: 0.5267683192710507d),
new NpgsqlTypes.NpgsqlBox(top: 0.6079316466346543d,right: 0.2402477468419688d,bottom: 0.46806802557623295d,left: 0.05636360104085436d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 101,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6164581412457447d,right: 0.7111169491505903d,bottom: 0.4686558866680851d,left: 0.15525163891918958d),
new NpgsqlTypes.NpgsqlBox(top: 0.6751260124958978d,right: 0.8534480193661682d,bottom: 0.07357056001606654d,left: 0.11888460695190517d),
new NpgsqlTypes.NpgsqlBox(top: 0.7833643525876198d,right: 0.5008559462443648d,bottom: 0.7373093423161285d,left: 0.31626452075590594d),
new NpgsqlTypes.NpgsqlBox(top: 0.6901874034239001d,right: 0.6452709092824768d,bottom: 0.3525050003714304d,left: 0.4957886284864287d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.18723858322741693d,right: 0.7102227755901712d,bottom: 0.0615469514461513d,left: 0.002255450962871164d),
new NpgsqlTypes.NpgsqlBox(top: 0.7868756535617728d,right: 0.5187922442271868d,bottom: 0.7109953068610475d,left: 0.02361999503951584d),
new NpgsqlTypes.NpgsqlBox(top: 0.8270164382153092d,right: 0.7230565994807282d,bottom: 0.2681141228050187d,left: 0.68981446350204d),
new NpgsqlTypes.NpgsqlBox(top: 0.9172408678887344d,right: 0.5699652913188782d,bottom: 0.591660692916799d,left: 0.2907771383704254d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9805009770568028d,right: 0.8090878820415003d,bottom: 0.9702417434789964d,left: 0.08890774627079079d),
new NpgsqlTypes.NpgsqlBox(top: 0.41526084235127314d,right: 0.9045772884771863d,bottom: 0.2301129422734116d,left: 0.6072509257622529d),
new NpgsqlTypes.NpgsqlBox(top: 0.33296865971399725d,right: 0.1589879855109031d,bottom: 0.3066796610785346d,left: 0.017291423433239417d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5750179413185791d,right: 0.30516991956225903d,bottom: 0.2728062765896856d,left: 0.30181268598599675d),
new NpgsqlTypes.NpgsqlBox(top: 0.4949992754495568d,right: 0.41563419397584833d,bottom: 0.2922960620341509d,left: 0.08288848138440774d),
new NpgsqlTypes.NpgsqlBox(top: 0.3009041036984029d,right: 0.6251949717709818d,bottom: 0.1887506802982084d,left: 0.3485527040814156d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6610986764426201d,right: 0.9943292638453799d,bottom: 0.5980900474382341d,left: 0.5083469153178822d),
new NpgsqlTypes.NpgsqlBox(top: 0.04023146932611743d,right: 0.6084109252523603d,bottom: 0.03325726259278583d,left: 0.48514924890638733d),
new NpgsqlTypes.NpgsqlBox(top: 0.9666835258316918d,right: 0.8224374295665494d,bottom: 0.4560492021181827d,left: 0.17395815357884403d),
new NpgsqlTypes.NpgsqlBox(top: 0.421049128745522d,right: 0.7909349367366241d,bottom: 0.1869404221777099d,left: 0.3907821945068014d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6767105119183752d,right: 0.6707946122383859d,bottom: 0.547449495163512d,left: 0.6603228182979025d),
new NpgsqlTypes.NpgsqlBox(top: 0.5561757702731877d,right: 0.6137070166899903d,bottom: 0.19905493188834167d,left: 0.07681137443414532d),
new NpgsqlTypes.NpgsqlBox(top: 0.3996556271698143d,right: 0.4382168983900684d,bottom: 0.10938145143138955d,left: 0.20544106471274803d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 112,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8409456919633039d,right: 0.9197951032035052d,bottom: 0.004555202193295749d,left: 0.6542495849817198d),
new NpgsqlTypes.NpgsqlBox(top: 0.6301691417029412d,right: 0.7881804072299732d,bottom: 0.3073370428240736d,left: 0.21166830907693257d),
new NpgsqlTypes.NpgsqlBox(top: 0.4692804729600061d,right: 0.6380209370443246d,bottom: 0.25071177293331504d,left: 0.13408424314352285d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7356412801681373d,right: 0.1277541334039085d,bottom: 0.4690604424824515d,left: 0.04389396973852033d),
new NpgsqlTypes.NpgsqlBox(top: 0.5369352606547971d,right: 0.11530146224761517d,bottom: 0.19929789525816544d,left: 0.022857717813291933d),
new NpgsqlTypes.NpgsqlBox(top: 0.8655394600188363d,right: 0.6295424664281544d,bottom: 0.21083379465822505d,left: 0.4225282699927594d),
new NpgsqlTypes.NpgsqlBox(top: 0.4867272176913331d,right: 0.46134912650548143d,bottom: 0.3369580450101619d,left: 0.005150031981198011d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5262669805958324d,right: 0.2133931977803274d,bottom: 0.1521254197335944d,left: 0.0779610565797545d),
new NpgsqlTypes.NpgsqlBox(top: 0.9001926448235197d,right: 0.6753299931587784d,bottom: 0.8424697907710835d,left: 0.21281562706762358d),
new NpgsqlTypes.NpgsqlBox(top: 0.896207223485748d,right: 0.9231993296566413d,bottom: 0.5180619170763036d,left: 0.9116398111329316d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9126795354331879d,right: 0.7007753014091791d,bottom: 0.2952798932727143d,left: 0.5610255632684484d),
new NpgsqlTypes.NpgsqlBox(top: 0.7296099706202376d,right: 0.5045881397697928d,bottom: 0.7166770609820385d,left: 0.5025423430111813d),
new NpgsqlTypes.NpgsqlBox(top: 0.9874002841367303d,right: 0.9777571481662223d,bottom: 0.31415996856289474d,left: 0.5177067523963488d),
new NpgsqlTypes.NpgsqlBox(top: 0.753835260064725d,right: 0.8247062341825204d,bottom: 0.28694584212704244d,left: 0.6403674598721634d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8723057176804621d,right: 0.4606458311835462d,bottom: 0.5609471115905438d,left: 0.3047105067964412d),
new NpgsqlTypes.NpgsqlBox(top: 0.6928886982921552d,right: 0.8498335902872631d,bottom: 0.15429519824814242d,left: 0.32507567995974995d),
new NpgsqlTypes.NpgsqlBox(top: 0.7090229976601718d,right: 0.11737704438305241d,bottom: 0.11209281783967096d,left: 0.0033683046369320513d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.21177472112957885d,right: 0.15866201934732393d,bottom: 0.04916429779976905d,left: 0.0751114908473951d),
new NpgsqlTypes.NpgsqlBox(top: 0.5234008147780593d,right: 0.8764923253130074d,bottom: 0.1477658657244485d,left: 0.7394960471501705d),
new NpgsqlTypes.NpgsqlBox(top: 0.16316364754729595d,right: 0.3705557317592054d,bottom: 0.04102773007535765d,left: 0.15437636628424456d),
new NpgsqlTypes.NpgsqlBox(top: 0.8133306474830657d,right: 0.9196823611962d,bottom: 0.6674302631592212d,left: 0.8101810990188044d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 120,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5693197745557469d,right: 0.5916648466439229d,bottom: 0.4432517504799903d,left: 0.48097764571201285d),
new NpgsqlTypes.NpgsqlBox(top: 0.8251719608603251d,right: 0.578409613829005d,bottom: 0.2894532654041274d,left: 0.2858138392752224d),
new NpgsqlTypes.NpgsqlBox(top: 0.9780309653372778d,right: 0.5931453888664048d,bottom: 0.38270868769744604d,left: 0.5798257028782552d),
new NpgsqlTypes.NpgsqlBox(top: 0.6572120776093219d,right: 0.2611654812428107d,bottom: 0.39645548414665d,left: 0.09921763193299638d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7830627676686134d,right: 0.9352123566387136d,bottom: 0.3301401988806747d,left: 0.5804695183823168d),
new NpgsqlTypes.NpgsqlBox(top: 0.9765778456898496d,right: 0.8439109422583345d,bottom: 0.2977502454919062d,left: 0.167122011202816d),
new NpgsqlTypes.NpgsqlBox(top: 0.6386675447680704d,right: 0.22393335266729653d,bottom: 0.5112952798659514d,left: 0.21452359883603545d),
new NpgsqlTypes.NpgsqlBox(top: 0.8465271639888216d,right: 0.370536015296724d,bottom: 0.35096663813082296d,left: 0.2777967904201206d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 129,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9172358456276429d,right: 0.9432515963904761d,bottom: 0.1534013145447899d,left: 0.8367396427475895d),
new NpgsqlTypes.NpgsqlBox(top: 0.541416425260474d,right: 0.7162838309167903d,bottom: 0.21433952005462775d,left: 0.643830661253474d),
new NpgsqlTypes.NpgsqlBox(top: 0.8315502103835731d,right: 0.9817459197268655d,bottom: 0.35685437281834786d,left: 0.9786362537539587d),
new NpgsqlTypes.NpgsqlBox(top: 0.7954820970393841d,right: 0.4702872039373338d,bottom: 0.2569672296037968d,left: 0.3691929680882655d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9355213737326392d,right: 0.5225654234032374d,bottom: 0.05938947638641767d,left: 0.48924914719483503d),
new NpgsqlTypes.NpgsqlBox(top: 0.9869596580248026d,right: 0.8233000373725615d,bottom: 0.010911210708190566d,left: 0.13412559650697298d),
new NpgsqlTypes.NpgsqlBox(top: 0.7097594788156314d,right: 0.41500059738972395d,bottom: 0.6193594035081907d,left: 0.31196749135018986d),
new NpgsqlTypes.NpgsqlBox(top: 0.6901713367522836d,right: 0.6979569722888114d,bottom: 0.47549115484736904d,left: 0.4746308295544588d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6011374390881339d,right: 0.8905089106360198d,bottom: 0.5118146350170616d,left: 0.4957163887288565d),
new NpgsqlTypes.NpgsqlBox(top: 0.7319880825787685d,right: 0.6743370625338305d,bottom: 0.4394630628293499d,left: 0.6499399613789089d),
new NpgsqlTypes.NpgsqlBox(top: 0.5681240792931113d,right: 0.545322334230921d,bottom: 0.028110942581579423d,left: 0.26914462326781896d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 130,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5200130197717597d,right: 0.9759784956299017d,bottom: 0.20776635056362036d,left: 0.29882490968455244d),
new NpgsqlTypes.NpgsqlBox(top: 0.39854164164008254d,right: 0.8665398275698135d,bottom: 0.06636703210652883d,left: 0.7013057063483842d),
new NpgsqlTypes.NpgsqlBox(top: 0.3756020216850756d,right: 0.9340121227327389d,bottom: 0.2456723061689411d,left: 0.5478403345305899d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8552674166408671d,right: 0.6942033163269218d,bottom: 0.8320121352596579d,left: 0.6288723102272618d),
new NpgsqlTypes.NpgsqlBox(top: 0.6298803125856942d,right: 0.3989015429963332d,bottom: 0.21407295835713014d,left: 0.23714299186676224d),
new NpgsqlTypes.NpgsqlBox(top: 0.9386831241545617d,right: 0.6969977212103926d,bottom: 0.5399524139507781d,left: 0.4217273637790868d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 137,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8969611421706286d,right: 0.8206622337178218d,bottom: 0.5037061353176094d,left: 0.23652746898771815d),
new NpgsqlTypes.NpgsqlBox(top: 0.28890490780256584d,right: 0.7243876930019167d,bottom: 0.1741599545515592d,left: 0.021644339256417955d),
new NpgsqlTypes.NpgsqlBox(top: 0.8830610098128863d,right: 0.5926977823666996d,bottom: 0.5341809894784555d,left: 0.3881064040445832d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8993476782568189d,right: 0.7943610783608742d,bottom: 0.7427209938350235d,left: 0.6256289936606317d),
new NpgsqlTypes.NpgsqlBox(top: 0.13130388353744082d,right: 0.799520191092025d,bottom: 0.09927710244241161d,left: 0.5192523206863553d),
new NpgsqlTypes.NpgsqlBox(top: 0.26676525216084435d,right: 0.8882299708072707d,bottom: 0.08304279110046231d,left: 0.40201645387412654d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.37936862715158637d,right: 0.5574563896593534d,bottom: 0.35820361707443904d,left: 0.4869216820413388d),
new NpgsqlTypes.NpgsqlBox(top: 0.9380688643546157d,right: 0.5915576098075517d,bottom: 0.013390859654942244d,left: 0.5198674760225587d),
new NpgsqlTypes.NpgsqlBox(top: 0.8970915366036665d,right: 0.8529734207910499d,bottom: 0.5001028781295073d,left: 0.35104773221835306d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7389601017665669d,right: 0.6772123569966543d,bottom: 0.18420443417312415d,left: 0.36297470792513453d),
new NpgsqlTypes.NpgsqlBox(top: 0.39933506857133305d,right: 0.7748980642135171d,bottom: 0.06005802880934341d,left: 0.03525453981288895d),
new NpgsqlTypes.NpgsqlBox(top: 0.7117588830559344d,right: 0.9406801461165112d,bottom: 0.09560151839750464d,left: 0.37572345738295043d),
new NpgsqlTypes.NpgsqlBox(top: 0.9989639359159934d,right: 0.6215881909612666d,bottom: 0.23362472122336897d,left: 0.30245782718950187d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 143,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8698169788401714d,right: 0.9990189702508319d,bottom: 0.8118727368001476d,left: 0.9707758344337349d),
new NpgsqlTypes.NpgsqlBox(top: 0.24424693858041446d,right: 0.18402081107284296d,bottom: 0.059188969897528754d,left: 0.1574017463074967d),
new NpgsqlTypes.NpgsqlBox(top: 0.6183567725835545d,right: 0.5714031941052787d,bottom: 0.45202404193662393d,left: 0.5311444147790912d),
new NpgsqlTypes.NpgsqlBox(top: 0.8434825243278106d,right: 0.9967850410305575d,bottom: 0.36252293183090134d,left: 0.10796651510013067d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9783488518878131d,right: 0.7519584130044887d,bottom: 0.649206607649728d,left: 0.35278276582076873d),
new NpgsqlTypes.NpgsqlBox(top: 0.6556279314111474d,right: 0.7378537558451356d,bottom: 0.2501718867674835d,left: 0.15849044578217286d),
new NpgsqlTypes.NpgsqlBox(top: 0.31612296699898645d,right: 0.9385336547329239d,bottom: 0.25158068317927296d,left: 0.5598339139190798d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 150,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.2615672269542244d,right: 0.36986090225832613d,bottom: 0.2460944370836422d,left: 0.3518014815964472d),
new NpgsqlTypes.NpgsqlBox(top: 0.9780053282842519d,right: 0.6046468431482342d,bottom: 0.2581980712346693d,left: 0.36387860076202216d),
new NpgsqlTypes.NpgsqlBox(top: 0.32221617457696405d,right: 0.877555144501839d,bottom: 0.19898968915891047d,left: 0.8544398176115829d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9281562940593886d,right: 0.20379548972841288d,bottom: 0.1022286306443797d,left: 0.05746633355982189d),
new NpgsqlTypes.NpgsqlBox(top: 0.9286367371586445d,right: 0.7346310712992161d,bottom: 0.1989727157254778d,left: 0.31902036287585556d),
new NpgsqlTypes.NpgsqlBox(top: 0.5103738753858215d,right: 0.6936694921622887d,bottom: 0.004881401595708712d,left: 0.3553005998132889d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.416827493035552d,right: 0.9113754770959054d,bottom: 0.0925487912612416d,left: 0.1414109684186856d),
new NpgsqlTypes.NpgsqlBox(top: 0.5140078929599445d,right: 0.9669525187783828d,bottom: 0.07244677408465261d,left: 0.6006161879819886d),
new NpgsqlTypes.NpgsqlBox(top: 0.8458027822582389d,right: 0.24366945508345117d,bottom: 0.5724136327276969d,left: 0.09487615883822298d),
new NpgsqlTypes.NpgsqlBox(top: 0.7415525708605996d,right: 0.07945968707651763d,bottom: 0.5275043303949786d,left: 0.01971291639913919d),
},
},
    NullableValue = null,
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
                Assert.That(nullable, Is.Null);
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
new NpgsqlTypes.NpgsqlBox(top: 0.5867839379169227d,right: 0.6498634200799357d,bottom: 0.18195781504997688d,left: 0.2923613445277443d),
new NpgsqlTypes.NpgsqlBox(top: 0.3763215570880244d,right: 0.18544060353121605d,bottom: 0.31465180277812177d,left: 0.018257303983140294d),
new NpgsqlTypes.NpgsqlBox(top: 0.5074661709410102d,right: 0.6304940180312818d,bottom: 0.3449753338097342d,left: 0.2224964193961384d),
new NpgsqlTypes.NpgsqlBox(top: 0.6112730633246102d,right: 0.945074147708596d,bottom: 0.14892755863161178d,left: 0.3458720244573462d),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9173624332874131d,right: 0.6149274228197608d,bottom: 0.4945399299126799d,left: 0.28449469923531734d),
new NpgsqlTypes.NpgsqlBox(top: 0.8011909720156413d,right: 0.9479048477225167d,bottom: 0.6343695664784319d,left: 0.031281301903742675d),
new NpgsqlTypes.NpgsqlBox(top: 0.8121689011541239d,right: 0.6156556936041724d,bottom: 0.5240465190422116d,left: 0.22133192052636685d),
}));
                nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7485200409895525d,right: 0.15337196534438535d,bottom: 0.6026462093596627d,left: 0.012460262645627829d),
new NpgsqlTypes.NpgsqlBox(top: 0.6703216803520227d,right: 0.8052362879060048d,bottom: 0.46553561717444225d,left: 0.17360191646456702d),
new NpgsqlTypes.NpgsqlBox(top: 0.7797512739691654d,right: 0.893193992579554d,bottom: 0.18758714989979242d,left: 0.6854745587681842d),
}));
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
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
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
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
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
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;

                var models =  ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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

                var models =  ((INpgsqlBoxArrayboxArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
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
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
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
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModel(connection,  query, 0);
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
                var models =  ((INpgsqlBoxArrayboxArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models = await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 92;
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
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
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[20], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[21], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[22], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[23], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[24], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[5], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[6], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[7], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[8], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[9], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[10], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[11], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[12], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[13], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[14], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[15], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[16], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[17], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[18], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[19], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[20], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[21], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[22], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[23], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[24], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[24],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var models =  ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 59;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
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
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[9], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[10], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[11], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[12], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[13], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[14], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[15], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[16], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[17], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[18], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[19], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[20], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[21], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[22], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[23], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[24], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[15], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[16], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[17], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[18], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[19], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[20], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[21], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[22], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[23], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[24], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[29], false);
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
            batchName: "DbConnectionSelectModelDynParBatch",
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

                var models = await ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[10], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[11], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[12], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[13], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[14], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[12], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[13], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[14], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[29], false);
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

                var models =  ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[10], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[11], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[12], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[13], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[14], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
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
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 8, query1, 130, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[2], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[3], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[4], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[5], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[6], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[7], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[8], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[9], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[10], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[11], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[12], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[13], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[14], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[15], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[16], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[17], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[18], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[19], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[20], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[21], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[22], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[23], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[24], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[24],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[25],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[26],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models =  ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
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
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 26, query1, 38, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[6], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[7], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[8], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[9], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[10], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[11], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[12], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[13], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[14], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[15], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[16], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[17], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[18], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[19], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[20], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[21], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[22], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[23], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[24], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[9], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[10], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[11], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[12], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[13], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[14], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[15], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[16], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[17], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[18], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[19], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[20], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[21], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[22], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[23], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[24], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[25], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[26], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[27], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[28], false);FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[29], false);
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelBatchAsync(connection, 130, 8))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[2], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[3], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[4], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[5], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[6], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[7], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[8], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[9], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[10], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[11], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[12], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[13], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[14], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[27],_testData[29], false);
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
                var models =  ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelBatch(connection, 59, 113))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[29], false);
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
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 20);
                var models = await ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(25));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[5], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[6], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[7], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[8], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[9], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[10], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[11], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[12], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[13], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[14], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxArrayboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 57);
                var models =  ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(16));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[14], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

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

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlBoxboxArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlBoxArrayboxArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlBoxArrayboxArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlBoxArrayboxArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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

        [Test, Order(1)]
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

        [Test, Order(2)]
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

        [Test, Order(2)]
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

        [Test, Order(2)]
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

        [Test, Order(2)]
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

