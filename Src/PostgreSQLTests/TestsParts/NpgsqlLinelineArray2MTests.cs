

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
    internal partial interface INpgsqlLineListlineArray
    {
    }
    
    internal partial class NpgsqlLineListlineArray : INpgsqlLineListlineArray
    {


#region TestData

        private readonly NpgsqlLinelineArray2M[] _testData = new NpgsqlLinelineArray2M[]
        {
            new NpgsqlLinelineArray2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2066657751309945d, b: 0.27443997688771704d, c: 0.34261370556508886d),

new NpgsqlTypes.NpgsqlLine(a: 0.3261285123910844d, b: 0.8155043086204444d, c: 0.6667672000677065d),

new NpgsqlTypes.NpgsqlLine(a: 0.3949395021143144d, b: 0.62492789723313d, c: 0.0950765614086424d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8446334637051708d, b: 0.8198871425242337d, c: 0.07953338992171588d),

new NpgsqlTypes.NpgsqlLine(a: 0.7361361559969632d, b: 0.8471170469344862d, c: 0.6884365921643552d),

new NpgsqlTypes.NpgsqlLine(a: 0.9648854340682097d, b: 0.6339064929783308d, c: 0.5591399537973475d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1284311457361913d, b: 0.5578216392768565d, c: 0.14298222637819247d),

new NpgsqlTypes.NpgsqlLine(a: 0.4567591363535395d, b: 0.7379749490719623d, c: 0.48988042753297334d),

new NpgsqlTypes.NpgsqlLine(a: 0.8694352393167054d, b: 0.8464308037606335d, c: 0.7799202088445077d),

new NpgsqlTypes.NpgsqlLine(a: 0.22156340393017537d, b: 0.21263783856056484d, c: 0.14717661847071906d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9311758932430914d, b: 0.5564794977301873d, c: 0.19173405240846986d),

new NpgsqlTypes.NpgsqlLine(a: 0.7360958962944307d, b: 0.8348619001179262d, c: 0.4506298027975658d),

new NpgsqlTypes.NpgsqlLine(a: 0.9092972430998144d, b: 0.6002637411418128d, c: 0.7834495079514524d),

new NpgsqlTypes.NpgsqlLine(a: 0.12567668960902d, b: 0.8913622989128369d, c: 0.6673588734538155d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.45490998983352604d, b: 0.314782442220389d, c: 0.10103250881623638d),

new NpgsqlTypes.NpgsqlLine(a: 0.5227102007134583d, b: 0.6964082369433946d, c: 0.3254901082739887d),

new NpgsqlTypes.NpgsqlLine(a: 0.7162114276523074d, b: 0.8628558016125821d, c: 0.3475536969121429d),

new NpgsqlTypes.NpgsqlLine(a: 0.574429391459957d, b: 0.5606011527606576d, c: 0.3076257624433646d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.13427821824480968d, b: 0.6876946160791292d, c: 0.9020195877144656d),

new NpgsqlTypes.NpgsqlLine(a: 0.3548634837640007d, b: 0.2942384657801206d, c: 0.07754756031227095d),

new NpgsqlTypes.NpgsqlLine(a: 0.08852301506211813d, b: 0.6761436156242048d, c: 0.673922139269077d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1662834363172424d, b: 0.7146386545776304d, c: 0.6200830225005949d),

new NpgsqlTypes.NpgsqlLine(a: 0.5410418307438859d, b: 0.6219566790469937d, c: 0.5076328038723399d),

new NpgsqlTypes.NpgsqlLine(a: 0.38363076574493205d, b: 0.05415670800420902d, c: 0.13856842099817057d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.14565601581246523d, b: 0.6113378762153908d, c: 0.6248857124508369d),

new NpgsqlTypes.NpgsqlLine(a: 0.6359505323087155d, b: 0.9800629098033926d, c: 0.39475004423017235d),

new NpgsqlTypes.NpgsqlLine(a: 0.29347336890601716d, b: 0.7797714151167293d, c: 0.2747651904296581d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4814111838819132d, b: 0.003532064486188591d, c: 0.35630736642965777d),

new NpgsqlTypes.NpgsqlLine(a: 0.580744799483178d, b: 0.1413553692976568d, c: 0.9385027097610177d),

new NpgsqlTypes.NpgsqlLine(a: 0.6823017185849278d, b: 0.9631537434719142d, c: 0.800292785238448d),

new NpgsqlTypes.NpgsqlLine(a: 0.8799940420136401d, b: 0.04078495973401264d, c: 0.1153058933076423d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.029901579096042297d, b: 0.03867954889351899d, c: 0.3204426074426453d),

new NpgsqlTypes.NpgsqlLine(a: 0.9348412889253148d, b: 0.2660928589245922d, c: 0.40739665712099615d),

new NpgsqlTypes.NpgsqlLine(a: 0.2087615167122998d, b: 0.7357377363525079d, c: 0.2258548418768901d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.14152060441124248d, b: 0.5716850276482106d, c: 0.753696097346014d),

new NpgsqlTypes.NpgsqlLine(a: 0.7770263267529843d, b: 0.6153341625782027d, c: 0.17862995286987715d),

new NpgsqlTypes.NpgsqlLine(a: 0.06505739204300565d, b: 0.7552045138283298d, c: 0.07785863445314378d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8993224043489538d, b: 0.48590758770848663d, c: 0.9779480298114763d),

new NpgsqlTypes.NpgsqlLine(a: 0.35133533036078024d, b: 0.1325373645660205d, c: 0.7281438649402937d),

new NpgsqlTypes.NpgsqlLine(a: 0.738048478283541d, b: 0.027381823236312774d, c: 0.07660748925977401d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.08697274568240676d, b: 0.2332001258350499d, c: 0.9704047715766001d),

new NpgsqlTypes.NpgsqlLine(a: 0.6116147977659702d, b: 0.6821369491287416d, c: 0.7049029931347511d),

new NpgsqlTypes.NpgsqlLine(a: 0.16826427110475983d, b: 0.7914239067659206d, c: 0.24111397837370563d),

new NpgsqlTypes.NpgsqlLine(a: 0.514419088886768d, b: 0.40413500849065753d, c: 0.4702768127650204d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6760418825236865d, b: 0.700226433631775d, c: 0.0005180953297064805d),

new NpgsqlTypes.NpgsqlLine(a: 0.511002017896735d, b: 0.1947128570338933d, c: 0.5726710029926164d),

new NpgsqlTypes.NpgsqlLine(a: 0.36439699280725046d, b: 0.22765180705299637d, c: 0.48206768803551736d),

new NpgsqlTypes.NpgsqlLine(a: 0.45503195424794995d, b: 0.7842233200316198d, c: 0.8862172776667572d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15359996454603253d, b: 0.7515762764039835d, c: 0.6488563435930966d),

new NpgsqlTypes.NpgsqlLine(a: 0.7030192087358677d, b: 0.6686796655298568d, c: 0.7542941779166389d),

new NpgsqlTypes.NpgsqlLine(a: 0.27998689275404187d, b: 0.4992924312498612d, c: 0.9942957451098837d),

new NpgsqlTypes.NpgsqlLine(a: 0.8624308315126346d, b: 0.9715646485035287d, c: 0.23057241386193372d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.46486745151484254d, b: 0.7938127911672115d, c: 0.7913861853071295d),

new NpgsqlTypes.NpgsqlLine(a: 0.20709956451574518d, b: 0.4946967853528256d, c: 0.1297240827434416d),

new NpgsqlTypes.NpgsqlLine(a: 0.3486223265420225d, b: 0.39961999273031357d, c: 0.025392749615131383d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9428368253312044d, b: 0.8758784762758248d, c: 0.5507918364380543d),

new NpgsqlTypes.NpgsqlLine(a: 0.19500001061480454d, b: 0.37613106501079685d, c: 0.361441773640637d),

new NpgsqlTypes.NpgsqlLine(a: 0.48187735385693864d, b: 0.3895031300450258d, c: 0.6659407383641088d),

new NpgsqlTypes.NpgsqlLine(a: 0.8196868862424814d, b: 0.3365118927762626d, c: 0.9470706534830584d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9597516426655512d, b: 0.065796005680134d, c: 0.5444426851968023d),

new NpgsqlTypes.NpgsqlLine(a: 0.3487786754109635d, b: 0.08357162777283433d, c: 0.7899836373548775d),

new NpgsqlTypes.NpgsqlLine(a: 0.9563060124873044d, b: 0.11623557977932009d, c: 0.291258218663775d),

new NpgsqlTypes.NpgsqlLine(a: 0.19304139456522662d, b: 0.44711089777125856d, c: 0.9973411546884773d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.347625531640007d, b: 0.36101088468013764d, c: 0.8518067201533354d),

new NpgsqlTypes.NpgsqlLine(a: 0.41314226588057246d, b: 0.7657384798023399d, c: 0.3305544009144269d),

new NpgsqlTypes.NpgsqlLine(a: 0.8758448244987067d, b: 0.16173747045491027d, c: 0.5726481852732804d),

new NpgsqlTypes.NpgsqlLine(a: 0.5810520912958067d, b: 0.750260480630523d, c: 0.9017736865078734d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7718217712387492d, b: 0.4679387644259475d, c: 0.05001837456487368d),

new NpgsqlTypes.NpgsqlLine(a: 0.335542551748617d, b: 0.02499339830269076d, c: 0.9799009337003934d),

new NpgsqlTypes.NpgsqlLine(a: 0.8387922011996956d, b: 0.37854493772634545d, c: 0.6484701025145686d),

new NpgsqlTypes.NpgsqlLine(a: 0.7281804503668139d, b: 0.2577394517154814d, c: 0.8162028919133514d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6843739431177126d, b: 0.7908186065821594d, c: 0.37103505243313095d),

new NpgsqlTypes.NpgsqlLine(a: 0.827251767351595d, b: 0.8054157041821663d, c: 0.019753077971415345d),

new NpgsqlTypes.NpgsqlLine(a: 0.8477155724041696d, b: 0.5694157572133622d, c: 0.12615204530393387d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.009285347276040246d, b: 0.7371535354372476d, c: 0.6427821197670244d),

new NpgsqlTypes.NpgsqlLine(a: 0.5596011547245364d, b: 0.8324138833530107d, c: 0.19566218826190096d),

new NpgsqlTypes.NpgsqlLine(a: 0.03678182081783521d, b: 0.3221204042869542d, c: 0.8482626748199301d),

new NpgsqlTypes.NpgsqlLine(a: 0.9101585234339237d, b: 0.0015294271909521706d, c: 0.5248158586201875d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7577714894895036d, b: 0.09691521317330043d, c: 0.0714502437251111d),

new NpgsqlTypes.NpgsqlLine(a: 0.3172933533549388d, b: 0.05928673136247842d, c: 0.6886615011819534d),

new NpgsqlTypes.NpgsqlLine(a: 0.1382791494347747d, b: 0.3839123236151286d, c: 0.9180704270194132d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4114185281958891d, b: 0.811337969952137d, c: 0.5537219267242833d),

new NpgsqlTypes.NpgsqlLine(a: 0.8117055355837746d, b: 0.7916779462852548d, c: 0.36971834843316564d),

new NpgsqlTypes.NpgsqlLine(a: 0.3229835909603016d, b: 0.8686864507191965d, c: 0.966912959118681d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1951424583933159d, b: 0.6247716147924383d, c: 0.7478383571127181d),

new NpgsqlTypes.NpgsqlLine(a: 0.5524953386600423d, b: 0.3056464553106514d, c: 0.9883033319454114d),

new NpgsqlTypes.NpgsqlLine(a: 0.3932563992841013d, b: 0.8676758735178098d, c: 0.36834382146136635d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8465456054363585d, b: 0.4474278489389417d, c: 0.7346941219081741d),

new NpgsqlTypes.NpgsqlLine(a: 0.21749435239243753d, b: 0.04148389811019326d, c: 0.486862842616957d),

new NpgsqlTypes.NpgsqlLine(a: 0.23727099689002284d, b: 0.5887482260969499d, c: 0.3979657584323001d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.41827146769780366d, b: 0.3811363131747456d, c: 0.24353686598351731d),

new NpgsqlTypes.NpgsqlLine(a: 0.5502339494038885d, b: 0.9553492151371268d, c: 0.5091656644762453d),

new NpgsqlTypes.NpgsqlLine(a: 0.5969200540638884d, b: 0.3570344886967557d, c: 0.27367611672622827d),

new NpgsqlTypes.NpgsqlLine(a: 0.49272647567479755d, b: 0.7395587993226651d, c: 0.061505732493100984d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9729295651300459d, b: 0.5679730443421849d, c: 0.5684917885390631d),

new NpgsqlTypes.NpgsqlLine(a: 0.1406116715215593d, b: 0.7205105951073363d, c: 0.4198978540347984d),

new NpgsqlTypes.NpgsqlLine(a: 0.21512460067270445d, b: 0.33158945797021355d, c: 0.3941256205997804d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.17908110805017807d, b: 0.7541464598031236d, c: 0.8534074463237313d),

new NpgsqlTypes.NpgsqlLine(a: 0.5649507919822493d, b: 0.027910146958578186d, c: 0.492594584091255d),

new NpgsqlTypes.NpgsqlLine(a: 0.3408471651367101d, b: 0.45475027812656044d, c: 0.7053154379043812d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7755422812832954d, b: 0.900677259267281d, c: 0.24287770141277343d),

new NpgsqlTypes.NpgsqlLine(a: 0.8502198427935095d, b: 0.24167386656710743d, c: 0.9415970904260859d),

new NpgsqlTypes.NpgsqlLine(a: 0.05596379003593566d, b: 0.06222705322362476d, c: 0.6354471119067556d),

new NpgsqlTypes.NpgsqlLine(a: 0.24762731441899233d, b: 0.9680947730175565d, c: 0.3307494999326548d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.10190202048865116d, b: 0.6293351404864305d, c: 0.6806867830704031d),

new NpgsqlTypes.NpgsqlLine(a: 0.9670588165352589d, b: 0.9804977025674194d, c: 0.6568269961060765d),

new NpgsqlTypes.NpgsqlLine(a: 0.1875998290792843d, b: 0.774470278548996d, c: 0.5320547287832966d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7487691496384374d, b: 0.4937687504403909d, c: 0.24038020383804404d),

new NpgsqlTypes.NpgsqlLine(a: 0.504920308590979d, b: 0.5332560298825698d, c: 0.6128058356563472d),

new NpgsqlTypes.NpgsqlLine(a: 0.13924808063076044d, b: 0.11597906525159984d, c: 0.8431473899683269d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7374053310472742d, b: 0.5606312396674051d, c: 0.2592793052387815d),

new NpgsqlTypes.NpgsqlLine(a: 0.6133641815231052d, b: 0.8510298136276854d, c: 0.8490716956400638d),

new NpgsqlTypes.NpgsqlLine(a: 0.9619054293246793d, b: 0.6556650300766005d, c: 0.8449298476408185d),

new NpgsqlTypes.NpgsqlLine(a: 0.7554663805191727d, b: 0.24832721069209096d, c: 0.9254927202543319d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4148707221093889d, b: 0.20956989947940385d, c: 0.37544965562921684d),

new NpgsqlTypes.NpgsqlLine(a: 0.30386918014120823d, b: 0.4843301493773017d, c: 0.05453495944170461d),

new NpgsqlTypes.NpgsqlLine(a: 0.02223004042397858d, b: 0.3147936564357676d, c: 0.07042884289926798d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3362182974994289d, b: 0.3158885083367585d, c: 0.4479267099473213d),

new NpgsqlTypes.NpgsqlLine(a: 0.41366720507110755d, b: 0.5964596488382914d, c: 0.769042328232494d),

new NpgsqlTypes.NpgsqlLine(a: 0.6843866989466508d, b: 0.3574854505995485d, c: 0.7032966438135231d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.523191215645376d, b: 0.4704706430426948d, c: 0.1649172966644542d),

new NpgsqlTypes.NpgsqlLine(a: 0.6364774497597397d, b: 0.7485917313225265d, c: 0.5583898883193255d),

new NpgsqlTypes.NpgsqlLine(a: 0.9786953604102645d, b: 0.4076158530415135d, c: 0.20203676052458908d),

new NpgsqlTypes.NpgsqlLine(a: 0.260282324651097d, b: 0.7520765761632481d, c: 0.5183527800184323d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.46542325471619006d, b: 0.6985384078915339d, c: 0.11173007036446081d),

new NpgsqlTypes.NpgsqlLine(a: 0.8852014414552943d, b: 0.9063477036609472d, c: 0.8371771272517958d),

new NpgsqlTypes.NpgsqlLine(a: 0.5705972368774545d, b: 0.8319956104914809d, c: 0.9649979927167294d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.41564765572703477d, b: 0.32159409849375287d, c: 0.4907650262352504d),

new NpgsqlTypes.NpgsqlLine(a: 0.3310221737605251d, b: 0.5840450635211296d, c: 0.8552580755184592d),

new NpgsqlTypes.NpgsqlLine(a: 0.32202758788950137d, b: 0.5319662668350026d, c: 0.7947395943946114d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.906746707044126d, b: 0.0575430131886967d, c: 0.5118787269911127d),

new NpgsqlTypes.NpgsqlLine(a: 0.6282930197779472d, b: 0.4344536131463015d, c: 0.2059961352339703d),

new NpgsqlTypes.NpgsqlLine(a: 0.9747890816973717d, b: 0.9183615192636535d, c: 0.8679259040793083d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.04467797635760207d, b: 0.1790039710421757d, c: 0.5912585164618722d),

new NpgsqlTypes.NpgsqlLine(a: 0.9793466670799664d, b: 0.9696744868459302d, c: 0.24294253218189854d),

new NpgsqlTypes.NpgsqlLine(a: 0.15733433328478796d, b: 0.8905897915825348d, c: 0.161996503560197d),

new NpgsqlTypes.NpgsqlLine(a: 0.6370772418905167d, b: 0.2966002789299821d, c: 0.0035639148654300623d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2850228390210874d, b: 0.4427185954557352d, c: 0.1261174803216658d),

new NpgsqlTypes.NpgsqlLine(a: 0.5894151969914841d, b: 0.8685131113607545d, c: 0.9870388637116977d),

new NpgsqlTypes.NpgsqlLine(a: 0.3240846540352469d, b: 0.4212874816402452d, c: 0.272987439849979d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9381879618555172d, b: 0.30336883945906745d, c: 0.5513579891589836d),

new NpgsqlTypes.NpgsqlLine(a: 0.5821116541433846d, b: 0.5223664506380149d, c: 0.4313726147358712d),

new NpgsqlTypes.NpgsqlLine(a: 0.5330713114811328d, b: 0.5803525883914884d, c: 0.22089435731367812d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6803345886212127d, b: 0.2795680283860795d, c: 0.005410757031185209d),

new NpgsqlTypes.NpgsqlLine(a: 0.4314087328594609d, b: 0.18752329058634265d, c: 0.6965872151474259d),

new NpgsqlTypes.NpgsqlLine(a: 0.8504689839623503d, b: 0.651279632943545d, c: 0.3155853242964135d),

new NpgsqlTypes.NpgsqlLine(a: 0.8271959712365429d, b: 0.5361074596013938d, c: 0.9468597759804394d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7112451892397234d, b: 0.3542798521484819d, c: 0.57219993467343d),

new NpgsqlTypes.NpgsqlLine(a: 0.3642365877202045d, b: 0.36745585565594574d, c: 0.41941536244550826d),

new NpgsqlTypes.NpgsqlLine(a: 0.899877331434166d, b: 0.012214538804328323d, c: 0.05473097360531165d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8204060965156454d, b: 0.4137965684483703d, c: 0.45697728911278557d),

new NpgsqlTypes.NpgsqlLine(a: 0.7974258902899821d, b: 0.8638354458249667d, c: 0.07330660350272022d),

new NpgsqlTypes.NpgsqlLine(a: 0.6207018486763156d, b: 0.19144325315348165d, c: 0.8392878887249936d),

new NpgsqlTypes.NpgsqlLine(a: 0.5389736475234086d, b: 0.48735125150295777d, c: 0.3465291640492999d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3726979988796504d, b: 0.4581761706236489d, c: 0.10601997209202307d),

new NpgsqlTypes.NpgsqlLine(a: 0.6677425858846465d, b: 0.6526927868333563d, c: 0.7622332649083582d),

new NpgsqlTypes.NpgsqlLine(a: 0.2092795055527472d, b: 0.7683301268066466d, c: 0.5344974920673417d),

new NpgsqlTypes.NpgsqlLine(a: 0.561314651811186d, b: 0.5127212512715829d, c: 0.2268883337183435d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9137889432928351d, b: 0.09094351416345758d, c: 0.00487078087223225d),

new NpgsqlTypes.NpgsqlLine(a: 0.1476807976886797d, b: 0.9908135072075107d, c: 0.8341311589255906d),

new NpgsqlTypes.NpgsqlLine(a: 0.32127109296364775d, b: 0.20502822020668288d, c: 0.4769997570927075d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.053830847870491305d, b: 0.4631929486342635d, c: 0.5318044055666125d),

new NpgsqlTypes.NpgsqlLine(a: 0.8161412273610467d, b: 0.2818934275249241d, c: 0.2873795652400476d),

new NpgsqlTypes.NpgsqlLine(a: 0.41798659629305435d, b: 0.5818897053501124d, c: 0.91732045917989d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2011574419557225d, b: 0.772905812657538d, c: 0.1942046143315228d),

new NpgsqlTypes.NpgsqlLine(a: 0.5103321487234522d, b: 0.7801228358526195d, c: 0.14576238370807482d),

new NpgsqlTypes.NpgsqlLine(a: 0.8244453060650175d, b: 0.48697663661287394d, c: 0.1561538029260634d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.42088271438119695d, b: 0.4322186320362704d, c: 0.2638704379262786d),

new NpgsqlTypes.NpgsqlLine(a: 0.17337788833429468d, b: 0.6039464967992428d, c: 0.40752134646983906d),

new NpgsqlTypes.NpgsqlLine(a: 0.1844931514277609d, b: 0.37797630970341267d, c: 0.8862306177462222d),

new NpgsqlTypes.NpgsqlLine(a: 0.9705296831865524d, b: 0.29123025591421714d, c: 0.1963344370011273d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7810077745328767d, b: 0.8818765264109175d, c: 0.2479183008283644d),

new NpgsqlTypes.NpgsqlLine(a: 0.686541463064802d, b: 0.735894235339717d, c: 0.4118418804724501d),

new NpgsqlTypes.NpgsqlLine(a: 0.9460939241888857d, b: 0.8986902316599547d, c: 0.06831832401883542d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2677471892197376d, b: 0.18504049869419592d, c: 0.5057682571376666d),

new NpgsqlTypes.NpgsqlLine(a: 0.5886759124269457d, b: 0.34323631026810897d, c: 0.5627511534767514d),

new NpgsqlTypes.NpgsqlLine(a: 0.7260481127662958d, b: 0.6389108768364702d, c: 0.3166467303987671d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.03147878889292621d, b: 0.9447519583308498d, c: 0.5677395119309074d),

new NpgsqlTypes.NpgsqlLine(a: 0.05501815058421067d, b: 0.43299846030768896d, c: 0.9416226593576141d),

new NpgsqlTypes.NpgsqlLine(a: 0.9534983720874869d, b: 0.2365095310388905d, c: 0.6281243302382801d),

new NpgsqlTypes.NpgsqlLine(a: 0.8780861839457965d, b: 0.6438240225444858d, c: 0.16654686849535327d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5155227734404628d, b: 0.0909283559699513d, c: 0.9227752189908331d),

new NpgsqlTypes.NpgsqlLine(a: 0.286142018648618d, b: 0.3009229716194799d, c: 0.11128586435627075d),

new NpgsqlTypes.NpgsqlLine(a: 0.20067242232794935d, b: 0.036398700537614626d, c: 0.4826324052570846d),

new NpgsqlTypes.NpgsqlLine(a: 0.40956100629314585d, b: 0.4678921307439261d, c: 0.9502785430857814d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.43768088682457484d, b: 0.12437323325952909d, c: 0.8303776521189589d),

new NpgsqlTypes.NpgsqlLine(a: 0.7660440276126493d, b: 0.49653464879333d, c: 0.8089502874709922d),

new NpgsqlTypes.NpgsqlLine(a: 0.14716157474416913d, b: 0.7383066608706588d, c: 0.7344354541350172d),

new NpgsqlTypes.NpgsqlLine(a: 0.19328660426161393d, b: 0.560566461520744d, c: 0.8576801353821886d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2259503911147024d, b: 0.16401198983427323d, c: 0.9337339751334978d),

new NpgsqlTypes.NpgsqlLine(a: 0.7961081273829927d, b: 0.6214793521954571d, c: 0.7097295146090101d),

new NpgsqlTypes.NpgsqlLine(a: 0.5763566880480633d, b: 0.46796126867968857d, c: 0.8410605617975124d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9875829983339888d, b: 0.26892411893214085d, c: 0.6441198086895903d),

new NpgsqlTypes.NpgsqlLine(a: 0.1345883158793325d, b: 0.7473921022759645d, c: 0.4056257451211849d),

new NpgsqlTypes.NpgsqlLine(a: 0.5102455445181372d, b: 0.4460425926971826d, c: 0.1676898516316887d),

new NpgsqlTypes.NpgsqlLine(a: 0.7432098891784854d, b: 0.6069288860384701d, c: 0.39371203431243273d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4879962580428864d, b: 0.6654711631192275d, c: 0.6638081281027873d),

new NpgsqlTypes.NpgsqlLine(a: 0.35524046020592825d, b: 0.7713791343266958d, c: 0.851561516079074d),

new NpgsqlTypes.NpgsqlLine(a: 0.7745794156846378d, b: 0.4230663830053071d, c: 0.2724090106947712d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3143160058255867d, b: 0.45486160609194926d, c: 0.204856961575287d),

new NpgsqlTypes.NpgsqlLine(a: 0.460884759719277d, b: 0.4908069753971963d, c: 0.5443608962716343d),

new NpgsqlTypes.NpgsqlLine(a: 0.6459088677131274d, b: 0.6813375164741905d, c: 0.711379737773321d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5063537600993717d, b: 0.09338540674020746d, c: 0.08996273091171547d),

new NpgsqlTypes.NpgsqlLine(a: 0.36191850979366513d, b: 0.8734892313991902d, c: 0.5095201607663634d),

new NpgsqlTypes.NpgsqlLine(a: 0.3305394971269777d, b: 0.19500263269105123d, c: 0.6806342636426468d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.23464277517818155d, b: 0.1525143035801848d, c: 0.3813469132084478d),

new NpgsqlTypes.NpgsqlLine(a: 0.06623370230895909d, b: 0.6239897879004d, c: 0.6771953862842572d),

new NpgsqlTypes.NpgsqlLine(a: 0.12737066693646293d, b: 0.5974386396283426d, c: 0.31746837992106935d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4971512818326469d, b: 0.44117282038316863d, c: 0.5428455611067005d),

new NpgsqlTypes.NpgsqlLine(a: 0.0009927983520672257d, b: 0.0733408698803365d, c: 0.20325168188589793d),

new NpgsqlTypes.NpgsqlLine(a: 0.9637759527260313d, b: 0.2528296292072635d, c: 0.16559938326959234d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.12163257062984179d, b: 0.11240628410920328d, c: 0.5863105963469725d),

new NpgsqlTypes.NpgsqlLine(a: 0.3700274939957655d, b: 0.9252238896967478d, c: 0.5820164246835123d),

new NpgsqlTypes.NpgsqlLine(a: 0.5240859387116082d, b: 0.048239843568855134d, c: 0.44923719791152406d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.35085054148298d, b: 0.868918698498554d, c: 0.5831142463403015d),

new NpgsqlTypes.NpgsqlLine(a: 0.11755694791867788d, b: 0.2616709532621616d, c: 0.37583135528427214d),

new NpgsqlTypes.NpgsqlLine(a: 0.36322137967531576d, b: 0.13659901015365938d, c: 0.47398268189065573d),

new NpgsqlTypes.NpgsqlLine(a: 0.47073897802455245d, b: 0.03302746240721821d, c: 0.42530131898006707d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5511138931696555d, b: 0.9832938138702788d, c: 0.1945383720249727d),

new NpgsqlTypes.NpgsqlLine(a: 0.6651909790074217d, b: 0.24197460721174757d, c: 0.688503952962793d),

new NpgsqlTypes.NpgsqlLine(a: 0.6261688405071878d, b: 0.9731056693592844d, c: 0.8643465756162735d),

new NpgsqlTypes.NpgsqlLine(a: 0.5100649541734398d, b: 0.13637537711398773d, c: 0.6668581529416687d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7792433057798333d, b: 0.4195466351145066d, c: 0.6473856720818295d),

new NpgsqlTypes.NpgsqlLine(a: 0.8093348025897786d, b: 0.666279463689243d, c: 0.7845488998381133d),

new NpgsqlTypes.NpgsqlLine(a: 0.8468113769304652d, b: 0.508536824786709d, c: 0.04513257121930869d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.24109709268777113d, b: 0.3420560623194644d, c: 0.6829606738805469d),

new NpgsqlTypes.NpgsqlLine(a: 0.8060094209799635d, b: 0.4274661582169107d, c: 0.5183469916457651d),

new NpgsqlTypes.NpgsqlLine(a: 0.8871278782768507d, b: 0.46188747777231376d, c: 0.527183012083769d),

new NpgsqlTypes.NpgsqlLine(a: 0.3065972686515215d, b: 0.21909536022057086d, c: 0.2503194527781666d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 161,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.24049054495580202d, b: 0.7608258670872501d, c: 0.5138434651869137d),

new NpgsqlTypes.NpgsqlLine(a: 0.7860183549416259d, b: 0.24003140693457847d, c: 0.21640546532245108d),

new NpgsqlTypes.NpgsqlLine(a: 0.2533830014648826d, b: 0.11564295672472413d, c: 0.18927656609263166d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.30599607018400077d, b: 0.2857598520549878d, c: 0.7878003745133425d),

new NpgsqlTypes.NpgsqlLine(a: 0.8764704092756695d, b: 0.9048061489742169d, c: 0.294004431251776d),

new NpgsqlTypes.NpgsqlLine(a: 0.372650115153913d, b: 0.3550092170791609d, c: 0.8531364381717341d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 170,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.17533638264845874d, b: 0.3275112041291204d, c: 0.6365030709929183d),

new NpgsqlTypes.NpgsqlLine(a: 0.465767554847225d, b: 0.8485380748421789d, c: 0.16415198003824893d),

new NpgsqlTypes.NpgsqlLine(a: 0.8510931206318123d, b: 0.23454878710260307d, c: 0.9891399226008929d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2254391137519709d, b: 0.11092713720053315d, c: 0.8450790523268132d),

new NpgsqlTypes.NpgsqlLine(a: 0.32057908255596357d, b: 0.439438534355725d, c: 0.5121328638668436d),

new NpgsqlTypes.NpgsqlLine(a: 0.36517505343966794d, b: 0.5972841215483489d, c: 0.7845793604617465d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.0068167070659216344d, b: 0.5319376039443717d, c: 0.6811348496557132d),

new NpgsqlTypes.NpgsqlLine(a: 0.37676718949482324d, b: 0.3804513211237899d, c: 0.33669045434277656d),

new NpgsqlTypes.NpgsqlLine(a: 0.48494931847037925d, b: 0.5215336396471673d, c: 0.10918528740987055d),

new NpgsqlTypes.NpgsqlLine(a: 0.1792457924656029d, b: 0.029824982815339407d, c: 0.561983418599428d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 178,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6671208735972561d, b: 0.6760393805375198d, c: 0.08628832096120143d),

new NpgsqlTypes.NpgsqlLine(a: 0.23139930882087467d, b: 0.3369890830353449d, c: 0.8443840661465472d),

new NpgsqlTypes.NpgsqlLine(a: 0.4166320180375487d, b: 0.537343454567678d, c: 0.5917157419909552d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.973357777226452d, b: 0.10370728038422072d, c: 0.4165969131988323d),

new NpgsqlTypes.NpgsqlLine(a: 0.5589486029581009d, b: 0.8363862023497003d, c: 0.8747050084467715d),

new NpgsqlTypes.NpgsqlLine(a: 0.44670760195481096d, b: 0.6344233297225599d, c: 0.5264073246530351d),

new NpgsqlTypes.NpgsqlLine(a: 0.5379055535513115d, b: 0.08872142292053675d, c: 0.5203381915831412d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 179,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.30738158408361393d, b: 0.7577433949340482d, c: 0.4615664094858509d),

new NpgsqlTypes.NpgsqlLine(a: 0.808015717237203d, b: 0.7433525519563206d, c: 0.011213973043390557d),

new NpgsqlTypes.NpgsqlLine(a: 0.5404800442825083d, b: 0.25798920124543623d, c: 0.8791356190054969d),

new NpgsqlTypes.NpgsqlLine(a: 0.6327743164528844d, b: 0.7596790742832208d, c: 0.6783414045325423d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.46753635758155865d, b: 0.3965105344821166d, c: 0.05002874314313577d),

new NpgsqlTypes.NpgsqlLine(a: 0.10918829744272096d, b: 0.9038850284820013d, c: 0.32599968198171836d),

new NpgsqlTypes.NpgsqlLine(a: 0.4441642019382358d, b: 0.40636367085130587d, c: 0.32393960217532924d),

new NpgsqlTypes.NpgsqlLine(a: 0.7325603237861523d, b: 0.6724693283458237d, c: 0.4189207078515135d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 187,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5205373876430338d, b: 0.21380217236917198d, c: 0.4714264919831197d),

new NpgsqlTypes.NpgsqlLine(a: 0.9081621860049311d, b: 0.3820464114393741d, c: 0.6676931176967674d),

new NpgsqlTypes.NpgsqlLine(a: 0.970398835471876d, b: 0.646817538772849d, c: 0.5380635075092537d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7437997814739861d, b: 0.588463843417561d, c: 0.7572100409237293d),

new NpgsqlTypes.NpgsqlLine(a: 0.3353624492411128d, b: 0.2973686257278466d, c: 0.3246895363169102d),

new NpgsqlTypes.NpgsqlLine(a: 0.007740360589647555d, b: 0.27673263983211915d, c: 0.7143742603031817d),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2mi(
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2mi(
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
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
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

                changedRows =  ((INpgsqlLineListlineArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineListlineArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineListlineArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineListlineArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray2mi_id
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
            asPartInterface: typeof(INpgsqlLineListlineArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinearray2mi_id", 
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
                changedRows =  ((INpgsqlLineListlineArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineListlineArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray2mi_id
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
    npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray2mi_id
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
    npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinearray2mi_id", 
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
                List<NpgsqlLinelineArray2M> models = null;

                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineArray2M> models = null;

                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M), typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                ((INpgsqlLineListlineArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlLineListlineArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineListlineArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await ((INpgsqlLineListlineArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlLineListlineArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M), typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                ((INpgsqlLineListlineArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineListlineArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineListlineArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await ((INpgsqlLineListlineArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlLineListlineArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M), typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                await((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 22;
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 148;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[28],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[32],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 161;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[34], false);
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
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 161;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[32],_testData[34], false);
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
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await((INpgsqlLineListlineArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[34], false);
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
                var models = ((INpgsqlLineListlineArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 16;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[3], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[4], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[5], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[6], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[7], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[8], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[9], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[10], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[21],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[22],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[23],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[24],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[25],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[26],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[27],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[28],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[29],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[30],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M), typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                await((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 55, query1, 145, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 55, query1, 119, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 112, query1, 46, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 14, query1, 141, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 108, query1, 57, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[24],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 83, query1, 63, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 170, query1, 152, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatch(connection, 92, query1, 113, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await((INpgsqlLineListlineArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelBatchAsync(connection, 70, 145))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[34], false);
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
                var models = ((INpgsqlLineListlineArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelBatch(connection, 152, 16))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[3], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[4], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[5], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[6], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[7], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[8], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[9], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[10], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[21],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[22],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[23],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[24],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[25],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[26],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[27],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[28],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[29],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[30],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[31],_testData[34], false);
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
                await using var cmd = await ((INpgsqlLineListlineArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 33);
                var models = await ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(29));

                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[6], false);
                NpgsqlLinelineArray2M.AssertModel(models[1],_testData[7], false);
                NpgsqlLinelineArray2M.AssertModel(models[2],_testData[8], false);
                NpgsqlLinelineArray2M.AssertModel(models[3],_testData[9], false);
                NpgsqlLinelineArray2M.AssertModel(models[4],_testData[10], false);
                NpgsqlLinelineArray2M.AssertModel(models[5],_testData[11], false);
                NpgsqlLinelineArray2M.AssertModel(models[6],_testData[12], false);
                NpgsqlLinelineArray2M.AssertModel(models[7],_testData[13], false);
                NpgsqlLinelineArray2M.AssertModel(models[8],_testData[14], false);
                NpgsqlLinelineArray2M.AssertModel(models[9],_testData[15], false);
                NpgsqlLinelineArray2M.AssertModel(models[10],_testData[16], false);
                NpgsqlLinelineArray2M.AssertModel(models[11],_testData[17], false);
                NpgsqlLinelineArray2M.AssertModel(models[12],_testData[18], false);
                NpgsqlLinelineArray2M.AssertModel(models[13],_testData[19], false);
                NpgsqlLinelineArray2M.AssertModel(models[14],_testData[20], false);
                NpgsqlLinelineArray2M.AssertModel(models[15],_testData[21], false);
                NpgsqlLinelineArray2M.AssertModel(models[16],_testData[22], false);
                NpgsqlLinelineArray2M.AssertModel(models[17],_testData[23], false);
                NpgsqlLinelineArray2M.AssertModel(models[18],_testData[24], false);
                NpgsqlLinelineArray2M.AssertModel(models[19],_testData[25], false);
                NpgsqlLinelineArray2M.AssertModel(models[20],_testData[26], false);
                NpgsqlLinelineArray2M.AssertModel(models[21],_testData[27], false);
                NpgsqlLinelineArray2M.AssertModel(models[22],_testData[28], false);
                NpgsqlLinelineArray2M.AssertModel(models[23],_testData[29], false);
                NpgsqlLinelineArray2M.AssertModel(models[24],_testData[30], false);
                NpgsqlLinelineArray2M.AssertModel(models[25],_testData[31], false);
                NpgsqlLinelineArray2M.AssertModel(models[26],_testData[32], false);
                NpgsqlLinelineArray2M.AssertModel(models[27],_testData[33], false);
                NpgsqlLinelineArray2M.AssertModel(models[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineListlineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 99);
                var models =  ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(17));

                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[18], false);
                NpgsqlLinelineArray2M.AssertModel(models[1],_testData[19], false);
                NpgsqlLinelineArray2M.AssertModel(models[2],_testData[20], false);
                NpgsqlLinelineArray2M.AssertModel(models[3],_testData[21], false);
                NpgsqlLinelineArray2M.AssertModel(models[4],_testData[22], false);
                NpgsqlLinelineArray2M.AssertModel(models[5],_testData[23], false);
                NpgsqlLinelineArray2M.AssertModel(models[6],_testData[24], false);
                NpgsqlLinelineArray2M.AssertModel(models[7],_testData[25], false);
                NpgsqlLinelineArray2M.AssertModel(models[8],_testData[26], false);
                NpgsqlLinelineArray2M.AssertModel(models[9],_testData[27], false);
                NpgsqlLinelineArray2M.AssertModel(models[10],_testData[28], false);
                NpgsqlLinelineArray2M.AssertModel(models[11],_testData[29], false);
                NpgsqlLinelineArray2M.AssertModel(models[12],_testData[30], false);
                NpgsqlLinelineArray2M.AssertModel(models[13],_testData[31], false);
                NpgsqlLinelineArray2M.AssertModel(models[14],_testData[32], false);
                NpgsqlLinelineArray2M.AssertModel(models[15],_testData[33], false);
                NpgsqlLinelineArray2M.AssertModel(models[16],_testData[34], false);
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
FROM public.binary_npgsqllinelinearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray2MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineListlineArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineListlineArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineListlineArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineListlineArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray2MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineListlineArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineListlineArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineListlineArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineListlineArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlLinelineArray2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
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
FROM public.binary_npgsqllinelinearray2m m
LEFT JOIN public.binary_npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineListlineArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlLineListlineArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineListlineArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models =  ((INpgsqlLineListlineArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineListlineArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA), typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                await ((INpgsqlLineListlineArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                ((INpgsqlLineListlineArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models = await ((INpgsqlLineListlineArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinearray2mi
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
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqllinelinearray2mi
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
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA), typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                await ((INpgsqlLineListlineArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                ((INpgsqlLineListlineArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
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
                var models = await ((INpgsqlLineListlineArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinearray2mi
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
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqllinelinearray2mi
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
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI), typeof(NpgsqlLinelineArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models1 = new List<NpgsqlLinelineArray2MI>();
                var models2 = new List<NpgsqlLinelineArray2MI>();
                await ((INpgsqlLineListlineArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray2MI>();
                var models2 = new List<NpgsqlLinelineArray2MI>();
                ((INpgsqlLineListlineArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models = await ((INpgsqlLineListlineArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA), typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                await ((INpgsqlLineListlineArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                ((INpgsqlLineListlineArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
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
                var models = await ((INpgsqlLineListlineArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

