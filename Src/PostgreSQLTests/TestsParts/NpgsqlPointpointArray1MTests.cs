

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
    internal partial interface INpgsqlPointArraypointArray
    {
    }
    
    internal partial class NpgsqlPointArraypointArray : INpgsqlPointArraypointArray
    {


#region TestData

        private readonly NpgsqlPointpointArray1M[] _testData = new NpgsqlPointpointArray1M[]
        {
            new NpgsqlPointpointArray1M
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6914220531527533d, y: 0.908103751987973d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7109743230177559d, y: 0.6615567193521843d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7409659314341431d, y: 0.5711064641880498d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4988752664754722d, y: 0.8465464998092891d),
new NpgsqlTypes.NpgsqlPoint(x: 0.09760837052429594d, y: 0.35947822777813265d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3685394061071229d, y: 0.02321152535970883d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9990426721046032d, y: 0.5926888598370278d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8259417153366005d, y: 0.8047602943647075d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10464569398223211d, y: 0.10848307987474282d),
new NpgsqlTypes.NpgsqlPoint(x: 0.29246656752721023d, y: 0.7581535487566731d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.993771235741384d, y: 0.44053034500942123d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6649785853287282d, y: 0.4591985219659984d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1719885976749047d, y: 0.16347030358576398d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3816219765243575d, y: 0.22026506405205004d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9825148207668705d, y: 0.7035485229304259d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3551498064917067d, y: 0.968978656624352d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5993704307125798d, y: 0.6885623930235856d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5527421669223254d, y: 0.7422250051582686d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3899961916730078d, y: 0.5377885175386389d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5923069948840702d, y: 0.518829238876747d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6730955930039568d, y: 0.34997846642634134d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0741685452429981d, y: 0.6458598294023273d),
new NpgsqlTypes.NpgsqlPoint(x: 0.17149630383416192d, y: 0.614180839620096d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6172705922036091d, y: 0.5782859642358434d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.313622523997955d, y: 0.578713398040933d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7186197187640898d, y: 0.710169719261171d),
new NpgsqlTypes.NpgsqlPoint(x: 0.520340309460303d, y: 0.13852178569221596d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9053744929968632d, y: 0.3168547612119621d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7992620588689268d, y: 0.6003359663666171d),
new NpgsqlTypes.NpgsqlPoint(x: 0.459236732831132d, y: 0.4473953556393705d),
new NpgsqlTypes.NpgsqlPoint(x: 0.08736317848415176d, y: 0.6098848319656295d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.38337833176533953d, y: 0.07397982115436641d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6432766222146064d, y: 0.48712244127585547d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10259677870292228d, y: 0.07327614737267563d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6419133088075595d, y: 0.29030074527696825d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.865865501058977d, y: 0.06052060022329986d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5093792925369209d, y: 0.12332750338707787d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7829397877227029d, y: 0.4962118467377242d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.23471982381805834d, y: 0.5428159459992695d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9461286460005678d, y: 0.468589122259891d),
new NpgsqlTypes.NpgsqlPoint(x: 0.09736368705549081d, y: 0.45011289489736217d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.012206068967923867d, y: 0.8896937808890563d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4864642357009228d, y: 0.08427808472238718d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0717668108129913d, y: 0.9818013083069312d),
new NpgsqlTypes.NpgsqlPoint(x: 0.017825521388971755d, y: 0.31670339266720426d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12031040574552476d, y: 0.7631592073467612d),
new NpgsqlTypes.NpgsqlPoint(x: 0.45440113699988616d, y: 0.1060958061866818d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3215891548747971d, y: 0.4837169012312523d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6559767347958562d, y: 0.02893781426718678d),
new NpgsqlTypes.NpgsqlPoint(x: 0.30068775892448174d, y: 0.5816426624466288d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2553434239983148d, y: 0.09993061362893552d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6283943030816311d, y: 0.27413088383754447d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3221837135068619d, y: 0.6079173724274968d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3827724853055122d, y: 0.6499608788511845d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5259303827730744d, y: 0.2910504094151981d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5111124142278807d, y: 0.3699898428772933d),
new NpgsqlTypes.NpgsqlPoint(x: 0.36589071760127523d, y: 0.41042772534077476d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6564635318012635d, y: 0.001992727893869395d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3661923720885555d, y: 0.460540841369362d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8381629549833021d, y: 0.23160548235454537d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7448319538947963d, y: 0.27296144311162496d),
new NpgsqlTypes.NpgsqlPoint(x: 0.02644054323883016d, y: 0.12393291802476114d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6591278944433823d, y: 0.807973608565417d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9055336459186093d, y: 0.20451563812513063d),
new NpgsqlTypes.NpgsqlPoint(x: 0.33615768850951866d, y: 0.8196861338324605d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3788151586544568d, y: 0.4991188637928017d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0813852793248423d, y: 0.11957367942323494d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2916312117546416d, y: 0.17463729307926035d),
new NpgsqlTypes.NpgsqlPoint(x: 0.028604718373589577d, y: 0.6847885729304244d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3788740802300441d, y: 0.27900056702590204d),
new NpgsqlTypes.NpgsqlPoint(x: 0.870774621497266d, y: 0.6186040418684579d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7733264042944887d, y: 0.4977506416293229d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7133330753057138d, y: 0.8371984821577674d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6230749345457439d, y: 0.16005430079800542d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3653852390762401d, y: 0.8029960463284218d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9601664472829506d, y: 0.6161964953614602d),
new NpgsqlTypes.NpgsqlPoint(x: 0.31457617932692883d, y: 0.23570637415079698d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7534893590456562d, y: 0.6557692230498916d),
new NpgsqlTypes.NpgsqlPoint(x: 0.25016281045403654d, y: 0.5436009025927162d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5935784468500173d, y: 0.8830691120944033d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5143407737743729d, y: 0.10412346135294148d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7962252674629404d, y: 0.15001348881829235d),
new NpgsqlTypes.NpgsqlPoint(x: 0.331590822077074d, y: 0.6546735067983448d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3803364160275826d, y: 0.8800996502127584d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6954675863922511d, y: 0.12739531753422306d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0013513164670270195d, y: 0.6093749972216762d),
new NpgsqlTypes.NpgsqlPoint(x: 0.08724099960776688d, y: 0.8432377939642541d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7894326393232696d, y: 0.3505937205676056d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09769943230438882d, y: 0.9002787225988101d),
new NpgsqlTypes.NpgsqlPoint(x: 0.973120510453227d, y: 0.5708703525370729d),
new NpgsqlTypes.NpgsqlPoint(x: 0.31951435519206983d, y: 0.7569594336383697d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7738825997154133d, y: 0.9930293435121649d),
new NpgsqlTypes.NpgsqlPoint(x: 0.14232122810153336d, y: 0.8714471624099374d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10981555251334785d, y: 0.05521713123732863d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2940540265202347d, y: 0.9390548917458097d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.30857657005732086d, y: 0.6324235540493024d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6053489848903887d, y: 0.7330414541073558d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5693236514781683d, y: 0.2665130610348112d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7184066832091714d, y: 0.3402081603147804d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5829864953509267d, y: 0.4335420208576978d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2487271961004084d, y: 0.24668499509898556d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5868978546806234d, y: 0.9235145796938559d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1433168393385168d, y: 0.7845745277393179d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5238621893114039d, y: 0.8311722556526777d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4110998695947087d, y: 0.3274140888776026d),
new NpgsqlTypes.NpgsqlPoint(x: 5.958173483022744E-05d, y: 0.30287000805460385d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7009305803602828d, y: 0.4334077848374679d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7709006047017176d, y: 0.35860703862794674d),
new NpgsqlTypes.NpgsqlPoint(x: 0.06274831594799546d, y: 0.9274914205014465d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5464421495908043d, y: 0.1706390899239716d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7683018901069595d, y: 0.7926407949211047d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6323818465148812d, y: 0.2759941871357028d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3543940792410616d, y: 0.41855623064438496d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3368249157699076d, y: 0.8837553763538124d),
new NpgsqlTypes.NpgsqlPoint(x: 0.25233323618799675d, y: 0.475623101685104d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6223224686768816d, y: 0.4431137424373781d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 92,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4379370852167068d, y: 0.1975216030378606d),
new NpgsqlTypes.NpgsqlPoint(x: 0.679892637963122d, y: 0.3246756510238795d),
new NpgsqlTypes.NpgsqlPoint(x: 0.45316376165958216d, y: 0.5314026368636122d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.07552786547593204d, y: 0.20925157606238431d),
new NpgsqlTypes.NpgsqlPoint(x: 0.41927710654536887d, y: 0.07458927336691168d),
new NpgsqlTypes.NpgsqlPoint(x: 0.46532638591119524d, y: 0.8322562968378048d),
new NpgsqlTypes.NpgsqlPoint(x: 0.26685341652153693d, y: 0.64324995590367d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6769559452304841d, y: 0.3667970571378366d),
new NpgsqlTypes.NpgsqlPoint(x: 0.46245608033512886d, y: 0.6781250086463982d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7871582171792777d, y: 0.6913308978903824d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7734979184125723d, y: 0.2915485141979516d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 106,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.814868023551182d, y: 0.941145576938794d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5891094577105119d, y: 0.18840493692261595d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6894011082038788d, y: 0.214445450344955d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2196100521315727d, y: 0.5352090129112784d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.03950553602640061d, y: 0.13649294804566203d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3496289281668131d, y: 0.6402985041334931d),
new NpgsqlTypes.NpgsqlPoint(x: 0.060600743940212976d, y: 0.07571444898862645d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6323077489004276d, y: 0.8306958667322439d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6557575071353686d, y: 0.21988444513809524d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3284871564807256d, y: 0.425905441349653d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8697432016427625d, y: 0.7156192749896754d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 117,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1339662168353779d, y: 0.0477845679102914d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9783688251058672d, y: 0.15020769749812823d),
new NpgsqlTypes.NpgsqlPoint(x: 0.700888457977185d, y: 0.6559102203360093d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 124,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3566602602755796d, y: 0.6033621111731066d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1997992943483694d, y: 0.7089083744529445d),
new NpgsqlTypes.NpgsqlPoint(x: 0.896306522070865d, y: 0.1707584896411357d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1313594850590314d, y: 0.022621602545806363d),
new NpgsqlTypes.NpgsqlPoint(x: 0.47862108158867445d, y: 0.06845617338184962d),
new NpgsqlTypes.NpgsqlPoint(x: 0.42622932993505735d, y: 0.35010343192341686d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 128,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5905308404690605d, y: 0.975414630862883d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6942932201978045d, y: 0.49995943269021703d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07267798295482342d, y: 0.8303082278114816d),
new NpgsqlTypes.NpgsqlPoint(x: 0.857381861938243d, y: 0.035280265095271934d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3549545105596613d, y: 0.7839819870898488d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5001398764411483d, y: 0.015686471315493944d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4841577917762715d, y: 0.12320473542079013d),
new NpgsqlTypes.NpgsqlPoint(x: 0.40508871577869277d, y: 0.6156690195461838d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 135,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7751873957701501d, y: 0.3073012332514047d),
new NpgsqlTypes.NpgsqlPoint(x: 0.48550300374275934d, y: 0.633491791787501d),
new NpgsqlTypes.NpgsqlPoint(x: 0.20070888558330047d, y: 0.06563325324251845d),
new NpgsqlTypes.NpgsqlPoint(x: 0.557652472069377d, y: 0.16520638266553633d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9232116461214434d, y: 0.4212180608502841d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4633759980119113d, y: 0.5231112724460979d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9429530133037194d, y: 0.9337020638434671d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6928477255342523d, y: 0.5427892421397096d),
new NpgsqlTypes.NpgsqlPoint(x: 0.715372806845823d, y: 0.060550147272780075d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9563654043523443d, y: 0.6386155769585105d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.47379028418212d, y: 0.6944436450782792d),
new NpgsqlTypes.NpgsqlPoint(x: 0.42131857837163966d, y: 0.17113414020640694d),
new NpgsqlTypes.NpgsqlPoint(x: 0.34172642367049755d, y: 0.21065389285524805d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 140,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5947454529424909d, y: 0.576664790441225d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9807616897429153d, y: 0.2820244075889773d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9629706824503079d, y: 0.40047212515627073d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5840664910460486d, y: 0.7503256980774613d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4013865243210494d, y: 0.6702966144690302d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7310502052373364d, y: 0.9510480325851374d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07806647317145254d, y: 0.7544108342811477d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 141,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4506730063626109d, y: 0.5855816333572935d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8174530275141352d, y: 0.8317489599104837d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9822012896389648d, y: 0.41512599718456955d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9941361528056889d, y: 0.7534991317572851d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6275011447636398d, y: 0.939570751608743d),
new NpgsqlTypes.NpgsqlPoint(x: 0.29743837980317167d, y: 0.11735552050887643d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.27122492895665795d, y: 0.4565705346805835d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5786995496083066d, y: 0.6473321233759715d),
new NpgsqlTypes.NpgsqlPoint(x: 0.13459112518619998d, y: 0.21200816744177542d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 146,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9740639402816452d, y: 0.1065725276060826d),
new NpgsqlTypes.NpgsqlPoint(x: 0.874485253935991d, y: 0.3972649285819201d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7975392619194673d, y: 0.36477822445112473d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.18216027972909565d, y: 0.10501716249942761d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5356582091977882d, y: 0.950855251298007d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6176200357413217d, y: 0.7388055169349247d),
new NpgsqlTypes.NpgsqlPoint(x: 0.21828256425860681d, y: 0.38655296736968203d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 149,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4503883325611787d, y: 0.5195681532515914d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2020128638982286d, y: 0.7018007460456078d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7441168550580536d, y: 0.543812505116506d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5487656525520098d, y: 0.7077029657530364d),
new NpgsqlTypes.NpgsqlPoint(x: 0.31706521576612445d, y: 0.05415143050835569d),
new NpgsqlTypes.NpgsqlPoint(x: 0.940278324183207d, y: 0.9220383504080605d),
new NpgsqlTypes.NpgsqlPoint(x: 0.42999084446347424d, y: 0.7663264719958501d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7352778323142682d, y: 0.5926834099283488d),
new NpgsqlTypes.NpgsqlPoint(x: 0.20854622603585793d, y: 0.19270835032488254d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4668835106639947d, y: 0.49450234304672824d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.489451681923755d, y: 0.06940687748396035d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5609950335357461d, y: 0.9138988779139927d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7648351266119043d, y: 0.9620316805303474d),
new NpgsqlTypes.NpgsqlPoint(x: 0.21299219186639895d, y: 0.6056844265166808d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 151,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4426607884325502d, y: 0.23542443439251104d),
new NpgsqlTypes.NpgsqlPoint(x: 0.25949590273096934d, y: 0.9176218864307066d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8882675245636545d, y: 0.7529169938010063d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7672256460252455d, y: 0.89834366099827d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8365405594213748d, y: 0.03900375912392795d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9929555332008645d, y: 0.4230700421790735d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6317522659595195d, y: 0.8843145979456956d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5224996851179428d, y: 0.9708679301851451d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 152,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9397522765044372d, y: 0.2246224161811089d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8952215053610008d, y: 0.8590651120863019d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9118739886934696d, y: 0.15122636796291677d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.25058051749547283d, y: 0.4197087105764131d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9552015167009074d, y: 0.07876770190637394d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5333729591298811d, y: 0.7499325865638705d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17490059592936258d, y: 0.6570690511018252d),
new NpgsqlTypes.NpgsqlPoint(x: 0.020883255688525226d, y: 0.6646634522732807d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0419408187018494d, y: 0.6568445582811115d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4605645715952281d, y: 0.28647148140107437d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2256693840851921d, y: 0.7382998496583835d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7672630809883381d, y: 0.6401613633019803d),
new NpgsqlTypes.NpgsqlPoint(x: 0.07942171004482268d, y: 0.026349797677041265d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 154,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9890407204176004d, y: 0.5679125090152632d),
new NpgsqlTypes.NpgsqlPoint(x: 0.807204057911408d, y: 0.4017202286248377d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9672583913545602d, y: 0.3223621766547483d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4540536085907635d, y: 0.0334227245407569d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6486677051537495d, y: 0.9552289350613647d),
new NpgsqlTypes.NpgsqlPoint(x: 0.34329195623668496d, y: 0.9004865867165649d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5309278965427979d, y: 0.006351425433046454d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 162,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9531246216831404d, y: 0.87928635610338d),
new NpgsqlTypes.NpgsqlPoint(x: 0.40765095352862635d, y: 0.5404433832866224d),
new NpgsqlTypes.NpgsqlPoint(x: 0.34465747120597d, y: 0.7329898580207986d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.27598977059510466d, y: 0.4466924359826092d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9750642380302544d, y: 0.666497095008555d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5520822176856495d, y: 0.1465188548914257d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24318938626707387d, y: 0.5417139182962912d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6783532640483032d, y: 0.8461220322297275d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8776529854013747d, y: 0.482194513019808d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8531187441973719d, y: 0.5157812903960681d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9097547631868392d, y: 0.674145254485257d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9175515022445548d, y: 0.2995371388339302d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4294361547827914d, y: 0.02123862004669097d),
new NpgsqlTypes.NpgsqlPoint(x: 0.10023550012352778d, y: 0.11991703778054186d),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1mi(
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1mi(
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
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633))]
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

                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPointArraypointArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPointArraypointArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray1mi_id
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointarray1mi_id", 
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
                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray1mi_id
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
    npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
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

                    nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
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

                    nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.012206068967923867d, y: 0.8896937808890563d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4864642357009228d, y: 0.08427808472238718d),
new NpgsqlTypes.NpgsqlPoint(x: 0.0717668108129913d, y: 0.9818013083069312d),
new NpgsqlTypes.NpgsqlPoint(x: 0.017825521388971755d, y: 0.31670339266720426d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
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

                    nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6559767347958562d, y: 0.02893781426718678d),
new NpgsqlTypes.NpgsqlPoint(x: 0.30068775892448174d, y: 0.5816426624466288d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2553434239983148d, y: 0.09993061362893552d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
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

                    nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6591278944433823d, y: 0.807973608565417d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9055336459186093d, y: 0.20451563812513063d),
new NpgsqlTypes.NpgsqlPoint(x: 0.33615768850951866d, y: 0.8196861338324605d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3788151586544568d, y: 0.4991188637928017d),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray1mi_id
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
    npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointarray1mi_id", 
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
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7534893590456562d, y: 0.6557692230498916d),
new NpgsqlTypes.NpgsqlPoint(x: 0.25016281045403654d, y: 0.5436009025927162d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5935784468500173d, y: 0.8830691120944033d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5143407737743729d, y: 0.10412346135294148d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0013513164670270195d, y: 0.6093749972216762d),
new NpgsqlTypes.NpgsqlPoint(x: 0.08724099960776688d, y: 0.8432377939642541d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7894326393232696d, y: 0.3505937205676056d),
}));
                nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointArray1M> models = null;

                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointArray1M> models = null;

                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M), typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                ((INpgsqlPointArraypointArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPointArraypointArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPointArraypointArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await ((INpgsqlPointArraypointArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPointArraypointArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M), typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                ((INpgsqlPointArraypointArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointArraypointArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointArraypointArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await ((INpgsqlPointArraypointArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPointArraypointArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M), typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                await((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[22],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[25],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 152;
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[22],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[24],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 113;
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await((INpgsqlPointArraypointArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 149;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[29], false);
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
                var models = ((INpgsqlPointArraypointArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[10], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[11], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M), typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                await((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 83, query1, 12, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[27],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 135, query1, 128, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 83, query1, 90, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 146, query1, 67, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTestAsync()
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 128, query1, 113, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[29], false);
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
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 92, query1, 83, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTest()
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 149, query1, 59, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[29], false);
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
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelBatch(connection, 53, query1, 37, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[24],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await((INpgsqlPointArraypointArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelBatchAsync(connection, 141, 106))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[29], false);
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
                var models = ((INpgsqlPointArraypointArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelBatch(connection, 19, 28))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[3], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[4], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[5], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[6], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[7], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[8], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[9], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[10], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[11], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[20],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[21],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[22],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[23],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[24],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[25],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[4], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[5], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[6], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[7], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[8], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[9], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[10], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[11], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[19],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[20],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[21],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[22],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[23],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[24],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[25],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPointArraypointArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPointArraypointArray)this).SetDbConnectionSelectModelParametrs(cmd, 146);
                var models = await ((INpgsqlPointArraypointArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointArraypointArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointArraypointArray)this).SetDbConnectionSelectModelParametrs(cmd, 124);
                var models =  ((INpgsqlPointArraypointArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(10));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
FROM public.binary_npgsqlpointpointarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPointpointArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPointArraypointArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointArraypointArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPointArraypointArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPointArraypointArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
FROM public.binary_npgsqlpointpointarray1m m
LEFT JOIN public.binary_npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPointpointArray1M>(15);

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
                ((INpgsqlPointArraypointArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointArraypointArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPointpointArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPointpointArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPointpointArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPointpointArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPointpointArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPointpointArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPointpointArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPointpointArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPointpointArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPointpointArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPointpointArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPointpointArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPointpointArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPointpointArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPointArraypointArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPointArraypointArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPointpointArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPointpointArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPointpointArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPointpointArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPointpointArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPointpointArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPointpointArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPointpointArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPointpointArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPointpointArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPointpointArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPointpointArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPointpointArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPointpointArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlPointpointArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlPointpointArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlPointpointArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlPointpointArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlPointpointArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlPointpointArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlPointpointArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlPointpointArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlPointpointArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlPointpointArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlPointpointArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlPointpointArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlPointpointArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlPointpointArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlPointpointArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPointArraypointArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointArraypointArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPointArraypointArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointArraypointArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

