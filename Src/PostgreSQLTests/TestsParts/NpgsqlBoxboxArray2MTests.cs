

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
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.486250347121186d,right: 0.9164087352559087d,bottom: 0.39170802108575575d,left: 0.8836499467668407d),

new NpgsqlTypes.NpgsqlBox(top: 0.45158429593368643d,right: 0.337906748008436d,bottom: 0.4180609123195679d,left: 0.2955416719499565d),

new NpgsqlTypes.NpgsqlBox(top: 0.4714539283617405d,right: 0.09016071021819516d,bottom: 0.05644185648482469d,left: 0.05408235904476122d),

new NpgsqlTypes.NpgsqlBox(top: 0.4296048650321438d,right: 0.859410233431591d,bottom: 0.2586945902138774d,left: 0.05012783475527105d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6568675503008191d,right: 0.8340359701601021d,bottom: 0.6114482233414984d,left: 0.03787859017113393d),

new NpgsqlTypes.NpgsqlBox(top: 0.8876641261682557d,right: 0.7859465346764651d,bottom: 0.14437420144352886d,left: 0.579557769144279d),

new NpgsqlTypes.NpgsqlBox(top: 0.3688091177009257d,right: 0.9302129825912304d,bottom: 0.2787784030416314d,left: 0.5690538738921564d),

new NpgsqlTypes.NpgsqlBox(top: 0.6428975350744025d,right: 0.5487344800647689d,bottom: 0.6047020618953506d,left: 0.47429034530444003d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.62947379072697d,right: 0.23004869195390332d,bottom: 0.6129555411089309d,left: 0.05357239537089209d),

new NpgsqlTypes.NpgsqlBox(top: 0.17709002934865814d,right: 0.8029420357673169d,bottom: 0.029812840887367797d,left: 0.4948487247263368d),

new NpgsqlTypes.NpgsqlBox(top: 0.7306192583180763d,right: 0.6181549602881359d,bottom: 0.48463240621924264d,left: 0.10228903929125954d),

new NpgsqlTypes.NpgsqlBox(top: 0.6803125224402932d,right: 0.6720016608899906d,bottom: 0.26106426965204443d,left: 0.019744103963165838d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9361313405609154d,right: 0.4347798080931323d,bottom: 0.5830448365189268d,left: 0.38917119259350463d),

new NpgsqlTypes.NpgsqlBox(top: 0.809046703948069d,right: 0.5748525790055358d,bottom: 0.47518627200997976d,left: 0.13919570257066938d),

new NpgsqlTypes.NpgsqlBox(top: 0.3122485670036572d,right: 0.5012605236664759d,bottom: 0.10986329181781962d,left: 0.3295407901581059d),

new NpgsqlTypes.NpgsqlBox(top: 0.7673651216770546d,right: 0.8009140033650668d,bottom: 0.01981227449667322d,left: 0.030245782436534863d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7663224962582588d,right: 0.706161237476181d,bottom: 0.522958215527896d,left: 0.1840154001371015d),

new NpgsqlTypes.NpgsqlBox(top: 0.8719602755904649d,right: 0.7264490891020557d,bottom: 0.6015794281688327d,left: 0.13547657854286033d),

new NpgsqlTypes.NpgsqlBox(top: 0.960016864798391d,right: 0.5057789233844285d,bottom: 0.3191395673091686d,left: 0.42435000067196116d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6165338310291343d,right: 0.8665604483050293d,bottom: 0.5012179257049031d,left: 0.25145766428255834d),

new NpgsqlTypes.NpgsqlBox(top: 0.91017704511145d,right: 0.7436561042189471d,bottom: 0.8491416088840835d,left: 0.7134236561809123d),

new NpgsqlTypes.NpgsqlBox(top: 0.9005598163900714d,right: 0.6377856999871041d,bottom: 0.7132444832183903d,left: 0.5729833560349845d),

new NpgsqlTypes.NpgsqlBox(top: 0.6076548230460245d,right: 0.7348350516531694d,bottom: 0.24970334242403114d,left: 0.5533375272630693d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8307776182545763d,right: 0.8050612531371075d,bottom: 0.49982468344276176d,left: 0.20055208572544714d),

new NpgsqlTypes.NpgsqlBox(top: 0.44150983102176267d,right: 0.7230924121563026d,bottom: 0.3389254853189394d,left: 0.6616872324373338d),

new NpgsqlTypes.NpgsqlBox(top: 0.5423994699804567d,right: 0.9198750460054992d,bottom: 0.3547141858855345d,left: 0.5526023268200826d),

new NpgsqlTypes.NpgsqlBox(top: 0.9433612180906286d,right: 0.8432024345272799d,bottom: 0.26043471143433006d,left: 0.32499875858717675d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.32375465319979524d,right: 0.7766610037219414d,bottom: 0.03798194078236572d,left: 0.7747924596116401d),

new NpgsqlTypes.NpgsqlBox(top: 0.7679397438015884d,right: 0.38718603749327685d,bottom: 0.331510042217672d,left: 0.163443065517497d),

new NpgsqlTypes.NpgsqlBox(top: 0.9268441736529449d,right: 0.2743326471660278d,bottom: 0.4253673915426681d,left: 0.15228534427718932d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4180156752514348d,right: 0.4885369161079862d,bottom: 0.19533740500617713d,left: 0.45115225913153056d),

new NpgsqlTypes.NpgsqlBox(top: 0.6267561418101182d,right: 0.3719913456381393d,bottom: 0.03996308090368528d,left: 0.21680773743594794d),

new NpgsqlTypes.NpgsqlBox(top: 0.4923810962941315d,right: 0.7467729103240834d,bottom: 0.4447104534205394d,left: 0.08874677658588392d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9993067928964905d,right: 0.41699151163037684d,bottom: 0.6302499816458819d,left: 0.15342513551915127d),

new NpgsqlTypes.NpgsqlBox(top: 0.7621112205801592d,right: 0.3940026276205071d,bottom: 0.09189015311698168d,left: 0.09525144723647938d),

new NpgsqlTypes.NpgsqlBox(top: 0.820643234532805d,right: 0.6182853922721945d,bottom: 0.027803574331215164d,left: 0.5018313590034836d),

new NpgsqlTypes.NpgsqlBox(top: 0.8194350712529175d,right: 0.8986759485544695d,bottom: 0.5699777053109641d,left: 0.8863279764720661d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9804876898317801d,right: 0.3590928099746935d,bottom: 0.7853829367397847d,left: 0.030661677854976532d),

new NpgsqlTypes.NpgsqlBox(top: 0.9178637038546853d,right: 0.7611381706474154d,bottom: 0.1865084041153071d,left: 0.3965069490082408d),

new NpgsqlTypes.NpgsqlBox(top: 0.718190417962839d,right: 0.8310380139524073d,bottom: 0.16754761611547164d,left: 0.1833417554453992d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.872342326040692d,right: 0.25643618487153275d,bottom: 0.6060388629131515d,left: 0.10574903083602527d),

new NpgsqlTypes.NpgsqlBox(top: 0.49089950993428055d,right: 0.9692482698323884d,bottom: 0.027890556338931005d,left: 0.914760158843414d),

new NpgsqlTypes.NpgsqlBox(top: 0.778613727794483d,right: 0.36812988007547787d,bottom: 0.05533244095169143d,left: 0.0628007277920527d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6088948812356484d,right: 0.8725936870796525d,bottom: 0.09931001053850075d,left: 0.8317228421570724d),

new NpgsqlTypes.NpgsqlBox(top: 0.506943705729075d,right: 0.8703214239869211d,bottom: 0.3835976828410098d,left: 0.49564214406022944d),

new NpgsqlTypes.NpgsqlBox(top: 0.5820255135156575d,right: 0.6560895150992787d,bottom: 0.09783970365363504d,left: 0.32435507242587547d),

new NpgsqlTypes.NpgsqlBox(top: 0.9446762777522931d,right: 0.9969837443856258d,bottom: 0.32320113095959735d,left: 0.2679132266049288d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6812620435068261d,right: 0.9507901039499103d,bottom: 0.3009389555325537d,left: 0.7435112048742988d),

new NpgsqlTypes.NpgsqlBox(top: 0.33506788991606495d,right: 0.812137362169719d,bottom: 0.30507719196306093d,left: 0.04421079819576079d),

new NpgsqlTypes.NpgsqlBox(top: 0.7805571780390994d,right: 0.7878855075354717d,bottom: 0.4931950741900075d,left: 0.16820736800902347d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3719586194026072d,right: 0.6943917376448908d,bottom: 0.06120411134058423d,left: 0.38849523752978476d),

new NpgsqlTypes.NpgsqlBox(top: 0.5967155467552717d,right: 0.5396997714506979d,bottom: 0.13149165834994614d,left: 0.4283221221772854d),

new NpgsqlTypes.NpgsqlBox(top: 0.9284697596723536d,right: 0.3807221827194849d,bottom: 0.1513449350162922d,left: 0.27966106718006367d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.4578288739127959d,right: 0.8636703664301989d,bottom: 0.4335258804469274d,left: 0.010832921215200408d),

new NpgsqlTypes.NpgsqlBox(top: 0.9644818050471473d,right: 0.19194930289186163d,bottom: 0.5545622916399235d,left: 0.010804601155663174d),

new NpgsqlTypes.NpgsqlBox(top: 0.9929979995225406d,right: 0.3745618745127772d,bottom: 0.0069488520251222985d,left: 0.12199264227935558d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9005325366085914d,right: 0.5494852917407878d,bottom: 0.681667389352821d,left: 0.28296174920022954d),

new NpgsqlTypes.NpgsqlBox(top: 0.5732989183432784d,right: 0.5364363399084625d,bottom: 0.24834246970963825d,left: 0.5053723428614546d),

new NpgsqlTypes.NpgsqlBox(top: 0.8997695657854565d,right: 0.5421604298608999d,bottom: 0.8862786260312184d,left: 0.26145247730404286d),

new NpgsqlTypes.NpgsqlBox(top: 0.3299605564840068d,right: 0.9302937847341995d,bottom: 0.15601209238893599d,left: 0.41462698484337634d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6501755830545816d,right: 0.3252172057185002d,bottom: 0.14946090277907254d,left: 0.2887281522312395d),

new NpgsqlTypes.NpgsqlBox(top: 0.31743468697366095d,right: 0.8737231839229961d,bottom: 0.20479940553711318d,left: 0.5827711175764851d),

new NpgsqlTypes.NpgsqlBox(top: 0.29148353044664954d,right: 0.5509887046948173d,bottom: 0.24008423385874123d,left: 0.5386564714476058d),

new NpgsqlTypes.NpgsqlBox(top: 0.7837653928713534d,right: 0.31737052859130177d,bottom: 0.4896102993311614d,left: 0.2973244577306887d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.22205348837545513d,right: 0.9192325607923598d,bottom: 0.1833696728842017d,left: 0.7478066135430387d),

new NpgsqlTypes.NpgsqlBox(top: 0.6003802938273793d,right: 0.18591297887004343d,bottom: 0.023001056625853944d,left: 0.07550673835003019d),

new NpgsqlTypes.NpgsqlBox(top: 0.8544934440211537d,right: 0.5244061068819952d,bottom: 0.2745700498206788d,left: 0.3257330969777392d),

new NpgsqlTypes.NpgsqlBox(top: 0.9633141442682432d,right: 0.8939517593119359d,bottom: 0.270257915930629d,left: 0.8297325999882094d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9231010690456269d,right: 0.47238502112504455d,bottom: 0.725469016372317d,left: 0.23796230803304352d),

new NpgsqlTypes.NpgsqlBox(top: 0.8831339241291245d,right: 0.9037161404206594d,bottom: 0.8370264674422002d,left: 0.3646624639812496d),

new NpgsqlTypes.NpgsqlBox(top: 0.605129821563634d,right: 0.574770428410988d,bottom: 0.41993390847183654d,left: 0.5130922535935284d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.16898328612037028d,right: 0.4098783378563319d,bottom: 0.15167434844025562d,left: 0.12073926652804501d),

new NpgsqlTypes.NpgsqlBox(top: 0.532082997499969d,right: 0.9753612966228615d,bottom: 0.3104830364523028d,left: 0.8081945889089609d),

new NpgsqlTypes.NpgsqlBox(top: 0.3611530028111053d,right: 0.849836563923883d,bottom: 0.22606871101484727d,left: 0.5213720702502903d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9369907340173687d,right: 0.7664130723273915d,bottom: 0.5282345402523707d,left: 0.655821980825324d),

new NpgsqlTypes.NpgsqlBox(top: 0.8858830334831932d,right: 0.6693704740519821d,bottom: 0.6433699108961359d,left: 0.4735748015095249d),

new NpgsqlTypes.NpgsqlBox(top: 0.5760037273579038d,right: 0.37604774356417925d,bottom: 0.3213746517260738d,left: 0.16783903322012317d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.22426894349993587d,right: 0.9448589113776528d,bottom: 0.09524731921108331d,left: 0.3758534323449052d),

new NpgsqlTypes.NpgsqlBox(top: 0.5589744806703288d,right: 0.9160631901516205d,bottom: 0.2589114037094976d,left: 0.41672970874586124d),

new NpgsqlTypes.NpgsqlBox(top: 0.9940938905709328d,right: 0.472479626291607d,bottom: 0.7246095629841093d,left: 0.41508265883327333d),

new NpgsqlTypes.NpgsqlBox(top: 0.42904927390824676d,right: 0.7958305946385196d,bottom: 0.08698156779885524d,left: 0.14827026119930686d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.46696266718237267d,right: 0.6152335597773483d,bottom: 0.4536195551806773d,left: 0.39185700320894623d),

new NpgsqlTypes.NpgsqlBox(top: 0.7820612054908396d,right: 0.8243361371436251d,bottom: 0.4977832694924915d,left: 0.553991995973206d),

new NpgsqlTypes.NpgsqlBox(top: 0.8268911030786984d,right: 0.8976626497023942d,bottom: 0.38622744288117905d,left: 0.5729247820946614d),

new NpgsqlTypes.NpgsqlBox(top: 0.6124713503165709d,right: 0.6728094110538636d,bottom: 0.2331549848296458d,left: 0.4107168972654205d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.47357745621420777d,right: 0.42463580804205836d,bottom: 0.3496858794001949d,left: 0.28503808748704973d),

new NpgsqlTypes.NpgsqlBox(top: 0.28196297280227733d,right: 0.9201977478958103d,bottom: 0.25112701516051983d,left: 0.21304939831238823d),

new NpgsqlTypes.NpgsqlBox(top: 0.946654093137456d,right: 0.2557408244099344d,bottom: 0.1853191208147682d,left: 0.06478003162751544d),

new NpgsqlTypes.NpgsqlBox(top: 0.3749444535263895d,right: 0.9907041349612608d,bottom: 0.3464636800867352d,left: 0.20169453499103251d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9730622773390206d,right: 0.6242235735731927d,bottom: 0.2597003186408756d,left: 0.30491983538006595d),

new NpgsqlTypes.NpgsqlBox(top: 0.727019162936492d,right: 0.6404171144136831d,bottom: 0.10852284888256802d,left: 0.13021266046068636d),

new NpgsqlTypes.NpgsqlBox(top: 0.614281105169304d,right: 0.14443675254544186d,bottom: 0.15104947942136304d,left: 0.020099160902634416d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5283796077020366d,right: 0.9330429342581663d,bottom: 0.036485092316798196d,left: 0.44950492223947114d),

new NpgsqlTypes.NpgsqlBox(top: 0.8410982246267383d,right: 0.9967200028558593d,bottom: 0.790253662077692d,left: 0.5559092623825365d),

new NpgsqlTypes.NpgsqlBox(top: 0.7266581523479303d,right: 0.8160096836159285d,bottom: 0.0026801568027154943d,left: 0.5109104949436805d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8382276916656881d,right: 0.9734907545603304d,bottom: 0.38134329249138144d,left: 0.7878535436900524d),

new NpgsqlTypes.NpgsqlBox(top: 0.5947223226987304d,right: 0.8572585612202654d,bottom: 0.055795061756969244d,left: 0.3753138578659523d),

new NpgsqlTypes.NpgsqlBox(top: 0.9467136180369858d,right: 0.7471579042444038d,bottom: 0.6402080566234337d,left: 0.0666300090201678d),

new NpgsqlTypes.NpgsqlBox(top: 0.48080589040682886d,right: 0.7369577113132592d,bottom: 0.08452942359476867d,left: 0.5983471020000627d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9570045456052243d,right: 0.16217123380006881d,bottom: 0.26916933981066016d,left: 0.14374599365407859d),

new NpgsqlTypes.NpgsqlBox(top: 0.4836984467286355d,right: 0.7381375447861563d,bottom: 0.2534907366732113d,left: 0.06437523204382356d),

new NpgsqlTypes.NpgsqlBox(top: 0.6406380934930678d,right: 0.44362151523635085d,bottom: 0.5848089822511916d,left: 0.04429127642726771d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.421447008356734d,right: 0.9288294281035182d,bottom: 0.2705608771995176d,left: 0.8964977803085563d),

new NpgsqlTypes.NpgsqlBox(top: 0.385219076473605d,right: 0.6004426178760627d,bottom: 0.129462739348864d,left: 0.024723589488887976d),

new NpgsqlTypes.NpgsqlBox(top: 0.8521069040698163d,right: 0.5674673966737978d,bottom: 0.6019513045865766d,left: 0.23395127938586147d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8032979621779733d,right: 0.9371873107902664d,bottom: 0.49542517320595747d,left: 0.8122205281079267d),

new NpgsqlTypes.NpgsqlBox(top: 0.9825454268472815d,right: 0.9455153097312126d,bottom: 0.8115356089602536d,left: 0.040672397456737897d),

new NpgsqlTypes.NpgsqlBox(top: 0.6790900526802001d,right: 0.9265422415857816d,bottom: 0.2732720699196879d,left: 0.4101542742902047d),

new NpgsqlTypes.NpgsqlBox(top: 0.745790461570199d,right: 0.9677444368059837d,bottom: 0.22039976117672222d,left: 0.41001240407704487d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6230906811896653d,right: 0.6453761669383716d,bottom: 0.13261925329866797d,left: 0.32260102747487784d),

new NpgsqlTypes.NpgsqlBox(top: 0.7348948688092773d,right: 0.7265385339073211d,bottom: 0.5433019493612249d,left: 0.10653122679813809d),

new NpgsqlTypes.NpgsqlBox(top: 0.42626225864817124d,right: 0.7076362487245509d,bottom: 0.027657324004845774d,left: 0.6462132362761863d),

new NpgsqlTypes.NpgsqlBox(top: 0.38706945267820414d,right: 0.6758360159121437d,bottom: 0.16136865835067948d,left: 0.26065200157725354d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6145568001690993d,right: 0.8456107652481218d,bottom: 0.1549536437979102d,left: 0.34587596129586184d),

new NpgsqlTypes.NpgsqlBox(top: 0.1553249997820646d,right: 0.8053145182713419d,bottom: 0.07169164686603247d,left: 0.16503682191501012d),

new NpgsqlTypes.NpgsqlBox(top: 0.4461606307272933d,right: 0.9386857838431061d,bottom: 0.0717045731907413d,left: 0.09597072293711029d),

new NpgsqlTypes.NpgsqlBox(top: 0.9346707571469484d,right: 0.9994159434648148d,bottom: 0.8669215319958872d,left: 0.7659785951571896d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.43591130389553034d,right: 0.9969625892111021d,bottom: 0.12159298841038946d,left: 0.010570281415423821d),

new NpgsqlTypes.NpgsqlBox(top: 0.8224159423164296d,right: 0.6177143991968379d,bottom: 0.4393038482715118d,left: 0.34873825792830393d),

new NpgsqlTypes.NpgsqlBox(top: 0.7589821469587582d,right: 0.3585711332337779d,bottom: 0.5761056751421628d,left: 0.1862230154004637d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9524958249594884d,right: 0.36647828650945735d,bottom: 0.8777752703554508d,left: 0.3332044612109004d),

new NpgsqlTypes.NpgsqlBox(top: 0.8701966404273656d,right: 0.41720248968200146d,bottom: 0.3780753386395176d,left: 0.36428685378449854d),

new NpgsqlTypes.NpgsqlBox(top: 0.7892426887179081d,right: 0.6085117706839012d,bottom: 0.754892768395077d,left: 0.18289220538498163d),

new NpgsqlTypes.NpgsqlBox(top: 0.8000400854216164d,right: 0.900885547785995d,bottom: 0.12803357661893433d,left: 0.42183391067627096d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5734718484733347d,right: 0.9552692655260435d,bottom: 0.15828447397314793d,left: 0.15905462063097797d),

new NpgsqlTypes.NpgsqlBox(top: 0.856007649862735d,right: 0.9228568598127582d,bottom: 0.03508176056356094d,left: 0.42844410518449294d),

new NpgsqlTypes.NpgsqlBox(top: 0.6343840286570885d,right: 0.738542340174163d,bottom: 0.2066260678617532d,left: 0.3201590350539837d),

new NpgsqlTypes.NpgsqlBox(top: 0.6278307264125003d,right: 0.6202108249632647d,bottom: 0.01923668656775801d,left: 0.21942221219583347d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5504291397723272d,right: 0.5400593623759777d,bottom: 0.4578148467179479d,left: 0.5247844256141546d),

new NpgsqlTypes.NpgsqlBox(top: 0.5978024172430376d,right: 0.6694223933367666d,bottom: 0.537155110310645d,left: 0.05897237023377533d),

new NpgsqlTypes.NpgsqlBox(top: 0.9276895075664712d,right: 0.5875765351944453d,bottom: 0.2529863259911741d,left: 0.5562702376628565d),

new NpgsqlTypes.NpgsqlBox(top: 0.8474237303835271d,right: 0.7104526100348989d,bottom: 0.28312907890051675d,left: 0.6753509843414284d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.33649328162329795d,right: 0.9638451795454723d,bottom: 0.27006140477526797d,left: 0.04146158805191802d),

new NpgsqlTypes.NpgsqlBox(top: 0.8726132880776077d,right: 0.5987977124769007d,bottom: 0.2733515624336845d,left: 0.04868650857863843d),

new NpgsqlTypes.NpgsqlBox(top: 0.9207403013316382d,right: 0.9681533396227718d,bottom: 0.4795748911177591d,left: 0.945254481626835d),

new NpgsqlTypes.NpgsqlBox(top: 0.8764864079200152d,right: 0.6102873443452158d,bottom: 0.6949514039674766d,left: 0.22374460606520663d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5179786339689433d,right: 0.9650967285592008d,bottom: 0.2352655107394579d,left: 0.5595794621449195d),

new NpgsqlTypes.NpgsqlBox(top: 0.7572366708960596d,right: 0.6574224573995314d,bottom: 0.6484593140465579d,left: 0.1631607033200274d),

new NpgsqlTypes.NpgsqlBox(top: 0.9708966613066562d,right: 0.38179157798336305d,bottom: 0.9096414613386429d,left: 0.06353677055773155d),

new NpgsqlTypes.NpgsqlBox(top: 0.5525180706541656d,right: 0.5906840702858902d,bottom: 0.4930579185247822d,left: 0.4172892029872787d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.74042461246234d,right: 0.6496228010427032d,bottom: 0.5280548587008884d,left: 0.49001470459639385d),

new NpgsqlTypes.NpgsqlBox(top: 0.8788118433840397d,right: 0.3642253645341602d,bottom: 0.5215885253188471d,left: 0.3150046871462029d),

new NpgsqlTypes.NpgsqlBox(top: 0.9140395628995862d,right: 0.791786167515876d,bottom: 0.7374201843228974d,left: 0.6858005096149385d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7335772866961248d,right: 0.6663200816389986d,bottom: 0.37217871500555844d,left: 0.34024838470937213d),

new NpgsqlTypes.NpgsqlBox(top: 0.8393286123500476d,right: 0.46966709577946697d,bottom: 0.34466918046100714d,left: 0.43826610926821485d),

new NpgsqlTypes.NpgsqlBox(top: 0.3092144614539648d,right: 0.8663682668795727d,bottom: 0.1557085141495972d,left: 0.04467244075096766d),

new NpgsqlTypes.NpgsqlBox(top: 0.5792158406317219d,right: 0.5778760053838454d,bottom: 0.33462204628475867d,left: 0.029966155262154293d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6440406396374284d,right: 0.9854594883367779d,bottom: 0.5929546602642519d,left: 0.9417319139719581d),

new NpgsqlTypes.NpgsqlBox(top: 0.7472692574233182d,right: 0.7096861189466753d,bottom: 0.6535796642146597d,left: 0.355297949817149d),

new NpgsqlTypes.NpgsqlBox(top: 0.3426559698418836d,right: 0.9679841471040065d,bottom: 0.01936488930399838d,left: 0.6528668483153418d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8696996847164669d,right: 0.8962605945035637d,bottom: 0.5572594797124624d,left: 0.10264350243043618d),

new NpgsqlTypes.NpgsqlBox(top: 0.6770728518771166d,right: 0.3396884863394162d,bottom: 0.03188965662495791d,left: 0.1344934206335917d),

new NpgsqlTypes.NpgsqlBox(top: 0.40118693755414325d,right: 0.8487348959962698d,bottom: 0.14548570891796575d,left: 0.29866967230588715d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9167145674411069d,right: 0.8046373409034798d,bottom: 0.9027690479716153d,left: 0.0005448328498255384d),

new NpgsqlTypes.NpgsqlBox(top: 0.4824365111058142d,right: 0.7639498920424092d,bottom: 0.3383579639604487d,left: 0.3450251855347396d),

new NpgsqlTypes.NpgsqlBox(top: 0.29126776369819884d,right: 0.4830611962557495d,bottom: 0.23157918036403158d,left: 0.02815333353245464d),

new NpgsqlTypes.NpgsqlBox(top: 0.3502207338543949d,right: 0.7067747603014537d,bottom: 0.08428183680455648d,left: 0.6237345678560186d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7944015267918667d,right: 0.8190578830291213d,bottom: 0.4744745027970452d,left: 0.7913500439322254d),

new NpgsqlTypes.NpgsqlBox(top: 0.5755334287801547d,right: 0.662606162830456d,bottom: 0.46300575826811796d,left: 0.5077146456457671d),

new NpgsqlTypes.NpgsqlBox(top: 0.29429575502158034d,right: 0.5499203864699744d,bottom: 0.06656512240906587d,left: 0.32593834096670926d),

new NpgsqlTypes.NpgsqlBox(top: 0.4488047621899771d,right: 0.04781847858796784d,bottom: 0.387748410492081d,left: 0.030470564855534454d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5598218995082257d,right: 0.8812075623781085d,bottom: 0.261565300530226d,left: 0.4795904703636441d),

new NpgsqlTypes.NpgsqlBox(top: 0.7744538957397196d,right: 0.5109807321065131d,bottom: 0.3958470147452665d,left: 0.3328512293812428d),

new NpgsqlTypes.NpgsqlBox(top: 0.5053684923567269d,right: 0.5567351891975042d,bottom: 0.32888878553924616d,left: 0.07409033010929855d),

new NpgsqlTypes.NpgsqlBox(top: 0.582670709641812d,right: 0.9000135844149918d,bottom: 0.18452004087131701d,left: 0.20079925213378913d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3084886012330217d,right: 0.44871026669839176d,bottom: 0.03931281727194891d,left: 0.3030753879445862d),

new NpgsqlTypes.NpgsqlBox(top: 0.761693092899714d,right: 0.8002194594687776d,bottom: 0.17619938615914865d,left: 0.20394367612955266d),

new NpgsqlTypes.NpgsqlBox(top: 0.23468134905103588d,right: 0.36232261304111635d,bottom: 0.14361086267430812d,left: 0.03576969489702009d),

new NpgsqlTypes.NpgsqlBox(top: 0.7270289061635721d,right: 0.9761343866626226d,bottom: 0.42487865134045755d,left: 0.5106188904471195d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.34752846809469096d,right: 0.7288315756325137d,bottom: 0.2394675602058367d,left: 0.6134287784526745d),

new NpgsqlTypes.NpgsqlBox(top: 0.5906895398519814d,right: 0.5940137039911453d,bottom: 0.5778865987239817d,left: 0.5061363382869203d),

new NpgsqlTypes.NpgsqlBox(top: 0.4872189451361032d,right: 0.17142868612107198d,bottom: 0.0349096628646649d,left: 0.0033919601447540693d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6160365205382504d,right: 0.4890651912299361d,bottom: 0.6072070196782444d,left: 0.48509702564490254d),

new NpgsqlTypes.NpgsqlBox(top: 0.9041290986794849d,right: 0.825409722616981d,bottom: 0.13387966608650237d,left: 0.6943710723065347d),

new NpgsqlTypes.NpgsqlBox(top: 0.9075453366702031d,right: 0.9901826386450477d,bottom: 0.6358863131477058d,left: 0.3238110871288645d),

new NpgsqlTypes.NpgsqlBox(top: 0.6564372703070672d,right: 0.5395721461103453d,bottom: 0.5511466867612951d,left: 0.3350474890716826d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.2937030480303886d,right: 0.1735702914360282d,bottom: 0.27966361765384173d,left: 0.12838978450439154d),

new NpgsqlTypes.NpgsqlBox(top: 0.9393634174623d,right: 0.654904582075531d,bottom: 0.29569463937805995d,left: 0.6442280192471787d),

new NpgsqlTypes.NpgsqlBox(top: 0.747338037191073d,right: 0.618292415708981d,bottom: 0.5479847044142379d,left: 0.22978097911481477d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5459716689866514d,right: 0.49941399827548827d,bottom: 0.2908209771935448d,left: 0.36523571508275166d),

new NpgsqlTypes.NpgsqlBox(top: 0.8919369251085345d,right: 0.7793076851579334d,bottom: 0.11308461769199751d,left: 0.0560432397279117d),

new NpgsqlTypes.NpgsqlBox(top: 0.6199689598413902d,right: 0.3088721583582982d,bottom: 0.5326129984361336d,left: 0.05036682736435005d),

new NpgsqlTypes.NpgsqlBox(top: 0.8507085752321509d,right: 0.20040772921119565d,bottom: 0.5391431797424538d,left: 0.1962163915804902d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.7044817843228253d,right: 0.6092553466832015d,bottom: 0.4717616428191812d,left: 0.4808165751197627d),

new NpgsqlTypes.NpgsqlBox(top: 0.6739937815938652d,right: 0.49873498038093034d,bottom: 0.45794455385197697d,left: 0.41076748427588294d),

new NpgsqlTypes.NpgsqlBox(top: 0.948685394526807d,right: 0.894339693368505d,bottom: 0.009542525173481198d,left: 0.8574513682870547d),

new NpgsqlTypes.NpgsqlBox(top: 0.7828026357868083d,right: 0.9550111362688408d,bottom: 0.4740096465160637d,left: 0.6074057260819106d),

},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5022635459339815d,right: 0.9461839333447761d,bottom: 0.029085897135712413d,left: 0.2232633305033298d),

new NpgsqlTypes.NpgsqlBox(top: 0.8978309217422259d,right: 0.6365024927230354d,bottom: 0.12534120265200765d,left: 0.417657236308994d),

new NpgsqlTypes.NpgsqlBox(top: 0.9102003251635413d,right: 0.29301902776582245d,bottom: 0.8810898583796702d,left: 0.0912075268571515d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.061722991836026475d,right: 0.46216189468153657d,bottom: 0.03438566642758645d,left: 0.2770651495695744d),

new NpgsqlTypes.NpgsqlBox(top: 0.13679766896479095d,right: 0.34266893966923306d,bottom: 0.11506267403665282d,left: 0.23755274440407137d),

new NpgsqlTypes.NpgsqlBox(top: 0.3730896256845868d,right: 0.8648320919749546d,bottom: 0.30360875111799024d,left: 0.8497761667909137d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.33139831301526246d,right: 0.8136442286386468d,bottom: 0.18453460415085077d,left: 0.5921195178937668d),

new NpgsqlTypes.NpgsqlBox(top: 0.9425381228409073d,right: 0.6062528259447226d,bottom: 0.45824835283213516d,left: 0.2505139512952167d),

new NpgsqlTypes.NpgsqlBox(top: 0.20625513744245583d,right: 0.41842149666222583d,bottom: 0.1024405929438128d,left: 0.04710521867260786d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.3095256036611673d,right: 0.8736382239386233d,bottom: 0.3023292573504345d,left: 0.18645004856746272d),

new NpgsqlTypes.NpgsqlBox(top: 0.926344960934059d,right: 0.7592584588736554d,bottom: 0.21369796125624718d,left: 0.6789632502879492d),

new NpgsqlTypes.NpgsqlBox(top: 0.10296149496112994d,right: 0.5773043057831462d,bottom: 0.014379636720945d,left: 0.38308578697932427d),

new NpgsqlTypes.NpgsqlBox(top: 0.9252777164089097d,right: 0.9785719292906488d,bottom: 0.14276597094294718d,left: 0.5745111055571444d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.9512008558028656d,right: 0.18071240445921177d,bottom: 0.6683247233620611d,left: 0.13340665306767951d),

new NpgsqlTypes.NpgsqlBox(top: 0.4934819094201305d,right: 0.32867427345274514d,bottom: 0.4666499727182237d,left: 0.13358502797792904d),

new NpgsqlTypes.NpgsqlBox(top: 0.2740117729521079d,right: 0.9192109065937004d,bottom: 0.26797508203003306d,left: 0.5875729982857779d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6909334338424737d,right: 0.7145989249492926d,bottom: 0.22655962132126184d,left: 0.44989245000102895d),

new NpgsqlTypes.NpgsqlBox(top: 0.7633256463388929d,right: 0.8899076425213881d,bottom: 0.6519422086846967d,left: 0.2818263713384873d),

new NpgsqlTypes.NpgsqlBox(top: 0.6314270700581035d,right: 0.4022400038231144d,bottom: 0.20284461257028907d,left: 0.04045517434850743d),

new NpgsqlTypes.NpgsqlBox(top: 0.5729133522438031d,right: 0.6816162141741395d,bottom: 0.513835926378538d,left: 0.1098285313956272d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.19474695316221047d,right: 0.78209942342458d,bottom: 0.08323966797754612d,left: 0.20573666629809806d),

new NpgsqlTypes.NpgsqlBox(top: 0.32019664336342835d,right: 0.9305020865383771d,bottom: 0.2839163892526855d,left: 0.3445471127893721d),

new NpgsqlTypes.NpgsqlBox(top: 0.9831479651383916d,right: 0.9659254928114038d,bottom: 0.18404516774395674d,left: 0.5853087920935982d),

new NpgsqlTypes.NpgsqlBox(top: 0.852031733428555d,right: 0.4265449091822403d,bottom: 0.45444545952901527d,left: 0.038340284132094005d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.8484583788303255d,right: 0.7741089674359006d,bottom: 0.20109046015735155d,left: 0.19336908998655578d),

new NpgsqlTypes.NpgsqlBox(top: 0.73116924548194d,right: 0.9397772572532664d,bottom: 0.7292570542010559d,left: 0.39178390870638524d),

new NpgsqlTypes.NpgsqlBox(top: 0.27303523709491495d,right: 0.7533604708450897d,bottom: 0.20221315653733862d,left: 0.3253768990074828d),

new NpgsqlTypes.NpgsqlBox(top: 0.5948501646937883d,right: 0.8380489085510213d,bottom: 0.2956099788759192d,left: 0.7572719375137322d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.32754331918502855d,right: 0.9656945279266252d,bottom: 0.0011330611222630793d,left: 0.95377356615842d),

new NpgsqlTypes.NpgsqlBox(top: 0.7174695417099977d,right: 0.9404642587949501d,bottom: 0.5920005491165181d,left: 0.12853786062090478d),

new NpgsqlTypes.NpgsqlBox(top: 0.8212508909635986d,right: 0.5193984482737505d,bottom: 0.08515159818073503d,left: 0.3126287237177253d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6050550937432235d,right: 0.37230828571510055d,bottom: 0.41059756153665594d,left: 0.10144080903522668d),

new NpgsqlTypes.NpgsqlBox(top: 0.8391434818949743d,right: 0.48654760906536065d,bottom: 0.4092079225984082d,left: 0.03953056139975786d),

new NpgsqlTypes.NpgsqlBox(top: 0.18171028935217803d,right: 0.7223280168744788d,bottom: 0.12161395522111862d,left: 0.21939568821644062d),

new NpgsqlTypes.NpgsqlBox(top: 0.8122413836862296d,right: 0.37218055601408906d,bottom: 0.09649733271324457d,left: 0.27625234527862097d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6784078038933539d,right: 0.5397853958754117d,bottom: 0.07907654630379335d,left: 0.3177440756415689d),

new NpgsqlTypes.NpgsqlBox(top: 0.7285728390149213d,right: 0.29705786584835925d,bottom: 0.6023533688037735d,left: 0.09151202458839924d),

new NpgsqlTypes.NpgsqlBox(top: 0.9400490725164461d,right: 0.5487869770602918d,bottom: 0.5858178171413965d,left: 0.5278801183557155d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.5460201798632018d,right: 0.6733272339054556d,bottom: 0.16724252191079303d,left: 0.2916828752160536d),

new NpgsqlTypes.NpgsqlBox(top: 0.8102092507172285d,right: 0.9791852440484909d,bottom: 0.6558920886004707d,left: 0.17236207977808193d),

new NpgsqlTypes.NpgsqlBox(top: 0.4327510875773063d,right: 0.8195857869361506d,bottom: 0.3861028752204183d,left: 0.13553375414416213d),

new NpgsqlTypes.NpgsqlBox(top: 0.30480959034528743d,right: 0.9167598823475299d,bottom: 0.25946349529817025d,left: 0.02238235160227675d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.2861057865139476d,right: 0.6686679631981264d,bottom: 0.060061128784702045d,left: 0.6524593190250184d),

new NpgsqlTypes.NpgsqlBox(top: 0.39708470278985075d,right: 0.4711024160460452d,bottom: 0.13991827187162187d,left: 0.16572172223909343d),

new NpgsqlTypes.NpgsqlBox(top: 0.7261327267993498d,right: 0.5703353636029512d,bottom: 0.46386144440522803d,left: 0.024463724043861323d),

new NpgsqlTypes.NpgsqlBox(top: 0.4428887764070999d,right: 0.5177265946316635d,bottom: 0.2905551653855326d,left: 0.13174962418340663d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.38910760728474625d,right: 0.9360347482747892d,bottom: 0.07741728689563765d,left: 0.8071817535416876d),

new NpgsqlTypes.NpgsqlBox(top: 0.5835286111613254d,right: 0.45063818546759893d,bottom: 0.33456098156069636d,left: 0.0692100190498075d),

new NpgsqlTypes.NpgsqlBox(top: 0.4876604470843833d,right: 0.9470753060871545d,bottom: 0.1760766543001978d,left: 0.2075488946033015d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.41586669939954557d,right: 0.5427948602797401d,bottom: 0.18389539601443872d,left: 0.1793623709622364d),

new NpgsqlTypes.NpgsqlBox(top: 0.8606697430529429d,right: 0.5348463818891995d,bottom: 0.07711928188906925d,left: 0.36713373094852997d),

new NpgsqlTypes.NpgsqlBox(top: 0.7550033838343851d,right: 0.4895631106800308d,bottom: 0.5684903484350916d,left: 0.2772738738830681d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.15459082600320562d,right: 0.4104417872504864d,bottom: 0.06441397961276674d,left: 0.05906505043709831d),

new NpgsqlTypes.NpgsqlBox(top: 0.92873502682368d,right: 0.8425812150625027d,bottom: 0.6268877529448197d,left: 0.15551184319996159d),

new NpgsqlTypes.NpgsqlBox(top: 0.896827090530031d,right: 0.9674720325649526d,bottom: 0.05857600941910113d,left: 0.24309023250925488d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.20834009362894756d,right: 0.678489462786081d,bottom: 0.1377532937003837d,left: 0.5933682609855274d),

new NpgsqlTypes.NpgsqlBox(top: 0.1213960541107525d,right: 0.9991629127058796d,bottom: 0.05200905028037606d,left: 0.12158038746226041d),

new NpgsqlTypes.NpgsqlBox(top: 0.7714586626038774d,right: 0.5259353605088253d,bottom: 0.22321091219722922d,left: 0.21661469457957971d),

new NpgsqlTypes.NpgsqlBox(top: 0.9959233661542953d,right: 0.20048803207418464d,bottom: 0.5576951411763102d,left: 0.04416016539832812d),

},
},
            new NpgsqlBoxboxArray2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.2063205144130532d,right: 0.7769257189197167d,bottom: 0.01192469886055525d,left: 0.025112793033303937d),

new NpgsqlTypes.NpgsqlBox(top: 0.25932548251315113d,right: 0.6685008370690948d,bottom: 0.2273200901585697d,left: 0.4450622262976255d),

new NpgsqlTypes.NpgsqlBox(top: 0.5236015113468045d,right: 0.08733930709775617d,bottom: 0.304235911059628d,left: 0.05337915763466927d),

},
    ModelInner = new NpgsqlBoxboxArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(4)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6219194218741712d,right: 0.8066237358463283d,bottom: 0.40677863716561524d,left: 0.0563948537865564d),

new NpgsqlTypes.NpgsqlBox(top: 0.38467064081801605d,right: 0.888118635868326d,bottom: 0.24354861052989774d,left: 0.18419962832060433d),

new NpgsqlTypes.NpgsqlBox(top: 0.19997104215080563d,right: 0.9211059805172358d,bottom: 0.14619035163333138d,left: 0.6666600714083449d),

new NpgsqlTypes.NpgsqlBox(top: 0.8857876792438071d,right: 0.18861705728944134d,bottom: 0.26515787015347214d,left: 0.023195757035342934d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlBox>(3)
{
new NpgsqlTypes.NpgsqlBox(top: 0.6918136294411977d,right: 0.40416115803469865d,bottom: 0.5618649858896259d,left: 0.12390733928396847d),

new NpgsqlTypes.NpgsqlBox(top: 0.7414687914213788d,right: 0.9190667745127076d,bottom: 0.28609815152958473d,left: 0.8352900922282405d),

new NpgsqlTypes.NpgsqlBox(top: 0.7031201280962533d,right: 0.9086535159645637d,bottom: 0.5258737033277698d,left: 0.07452072526380671d),

},
},
    NullableValue = null,
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
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxListboxArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
            overrideAliasPrefixs: null,
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
                var models = ((INpgsqlBoxListboxArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
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
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxListboxArray)this).DynQuerySelectModel(connection,  query, 0);
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
            overrideAliasPrefixs: null,
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
                var models = ((INpgsqlBoxListboxArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxListboxArray)),
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
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
                parametr1.Value = 64;
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
FROM public.npgsqlboxboxarray2m m
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
                        Assert.That(models, Has.Count.EqualTo(19));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[11], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[12], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[13], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[14], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[15], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[16], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[17], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[18], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[19], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[20], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[21], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[22], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[23], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[24], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[25], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[26], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[26], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[29], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
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
                parametr1.Value = 111;
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
                        Assert.That(models, Has.Count.EqualTo(9));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[21], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[22], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[23], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[24], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[25], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[26], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[29], false);
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
            overrideAliasPrefixs: null,
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
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
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
                parametr1.Value = 11;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 151;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[2], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[3], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[4], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[5], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[6], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[7], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[8], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[9], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[10], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[11], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[12], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[13], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[14], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[25],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[26],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[29], false);
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
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M), typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                await((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray2M>();
                var models2 = new List<FlatNpgsqlBoxboxArray2M>();
                ((INpgsqlBoxListboxArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray2M)],
            overrideAliasPrefixs: null,
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 67, query1, 140, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[12], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[13], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[14], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[15], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[16], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[17], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[18], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[19], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[20], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[21], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[22], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[23], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[24], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[25], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[26], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[26], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[29], false);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
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
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 113, query1, 28, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[22], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[23], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[24], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[25], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[26], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
FlatNpgsqlBoxboxArray2M.AssertModel(models[0],_testData[6], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[1],_testData[7], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[2],_testData[8], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[3],_testData[9], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[4],_testData[10], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[5],_testData[11], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[6],_testData[12], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[7],_testData[13], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[8],_testData[14], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[9],_testData[15], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[10],_testData[16], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[11],_testData[17], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[12],_testData[18], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[13],_testData[19], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[14],_testData[20], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[15],_testData[21], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[16],_testData[22], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[17],_testData[23], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[18],_testData[24], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[19],_testData[25], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[20],_testData[26], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[21],_testData[27], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[22],_testData[28], false);FlatNpgsqlBoxboxArray2M.AssertModel(models[23],_testData[29], false);
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
            overrideAliasPrefixs: null,
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
                var models = await((INpgsqlBoxListboxArray)this).DbConnectionSelectModelAsync(connection, 0);
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
                foreach(var batchResult in await ((INpgsqlBoxListboxArray)this).DbConnectionSelectModelBatchAsync(connection, 72, 98))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[13], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[14], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[29], false);
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
                var models = ((INpgsqlBoxListboxArray)this).DbConnectionSelectModel(connection, 0);
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
                foreach(var batchResult in  ((INpgsqlBoxListboxArray)this).DbConnectionSelectModelBatch(connection, 122, 18))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[4], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[5], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[6], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[7], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[8], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[9], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[10], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[11], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[12], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[13], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[14], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[25],_testData[29], false);
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
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 15);
                var models = await ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[3], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[4], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[5], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[6], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[7], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[8], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[9], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[10], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[11], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[12], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[13], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[14], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[15], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[14],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[15],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[16],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[17],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[18],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[19],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[20],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[21],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[22],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[23],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[24],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[25],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[26],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxListboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxListboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 87);
                var models =  ((INpgsqlBoxListboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(14));
NpgsqlBoxboxArray2M.AssertModel(models[0],_testData[16], false);NpgsqlBoxboxArray2M.AssertModel(models[1],_testData[17], false);NpgsqlBoxboxArray2M.AssertModel(models[2],_testData[18], false);NpgsqlBoxboxArray2M.AssertModel(models[3],_testData[19], false);NpgsqlBoxboxArray2M.AssertModel(models[4],_testData[20], false);NpgsqlBoxboxArray2M.AssertModel(models[5],_testData[21], false);NpgsqlBoxboxArray2M.AssertModel(models[6],_testData[22], false);NpgsqlBoxboxArray2M.AssertModel(models[7],_testData[23], false);NpgsqlBoxboxArray2M.AssertModel(models[8],_testData[24], false);NpgsqlBoxboxArray2M.AssertModel(models[9],_testData[25], false);NpgsqlBoxboxArray2M.AssertModel(models[10],_testData[26], false);NpgsqlBoxboxArray2M.AssertModel(models[11],_testData[27], false);NpgsqlBoxboxArray2M.AssertModel(models[12],_testData[28], false);NpgsqlBoxboxArray2M.AssertModel(models[13],_testData[29], false);
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

