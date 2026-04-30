

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
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5495944119406885d, y: 0.024679887532815914d), new NpgsqlTypes.NpgsqlPoint(x: 0.9022945837829174d, y: 0.6152733538650543d), new NpgsqlTypes.NpgsqlPoint(x: 0.6104795900546003d, y: 0.6189756507350913d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6119245270345232d, y: 0.6245874610397155d), new NpgsqlTypes.NpgsqlPoint(x: 0.13612868938838596d, y: 0.6232665660941091d), new NpgsqlTypes.NpgsqlPoint(x: 0.9323101244994877d, y: 0.2684194584063764d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2907539122060041d, y: 0.18047740899774334d), new NpgsqlTypes.NpgsqlPoint(x: 0.880168857908973d, y: 0.544577366903238d), new NpgsqlTypes.NpgsqlPoint(x: 0.8198583965084771d, y: 0.3654631924982108d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16867140658337365d, y: 0.13325991856997343d), new NpgsqlTypes.NpgsqlPoint(x: 0.5063292452428543d, y: 0.6912949760421783d), new NpgsqlTypes.NpgsqlPoint(x: 0.04512504396862149d, y: 0.38976647192559966d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7670859459601743d, y: 0.595435871827672d), new NpgsqlTypes.NpgsqlPoint(x: 0.43280026173486896d, y: 0.7309336361810574d), new NpgsqlTypes.NpgsqlPoint(x: 0.005757410401133423d, y: 0.42408424405700496d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09667123824324997d, y: 0.4323356287628499d), new NpgsqlTypes.NpgsqlPoint(x: 0.13637053075329286d, y: 0.8067445975567739d), new NpgsqlTypes.NpgsqlPoint(x: 0.6163282078999066d, y: 0.045026665520302545d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7710674403150198d, y: 0.8174924027795668d), new NpgsqlTypes.NpgsqlPoint(x: 0.11678632279716028d, y: 0.6696997813453919d), new NpgsqlTypes.NpgsqlPoint(x: 0.37206540669420296d, y: 0.6958671962311526d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9673898350036001d, y: 0.7466306125951754d), new NpgsqlTypes.NpgsqlPoint(x: 0.5616038521610932d, y: 0.3161316551383806d), new NpgsqlTypes.NpgsqlPoint(x: 0.2874452863890362d, y: 0.002077222137217838d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13317064945204027d, y: 0.14745375452012655d), new NpgsqlTypes.NpgsqlPoint(x: 0.7316100483858458d, y: 0.7788503168355598d), new NpgsqlTypes.NpgsqlPoint(x: 0.13230525806841875d, y: 0.874081048923591d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9830956879285613d, y: 0.3113980707264207d), new NpgsqlTypes.NpgsqlPoint(x: 0.5054444647770446d, y: 0.06876431611774125d), new NpgsqlTypes.NpgsqlPoint(x: 0.3549457938348466d, y: 0.6970466502056077d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9889497555790294d, y: 0.3612450874558827d), new NpgsqlTypes.NpgsqlPoint(x: 0.25001147485087205d, y: 0.5763429156280251d), new NpgsqlTypes.NpgsqlPoint(x: 0.8289482800532065d, y: 0.13604668399542108d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3056063534566983d, y: 0.3623324308268323d), new NpgsqlTypes.NpgsqlPoint(x: 0.7587501776667136d, y: 0.23450331682767278d), new NpgsqlTypes.NpgsqlPoint(x: 0.017324545063368113d, y: 0.941649484070864d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.001066685659951605d, y: 0.8810764824774374d), new NpgsqlTypes.NpgsqlPoint(x: 0.42682850352837365d, y: 0.3320785298736364d), new NpgsqlTypes.NpgsqlPoint(x: 0.8947229397969468d, y: 0.07043498013027738d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5853511003927835d, y: 0.5012067761653154d), new NpgsqlTypes.NpgsqlPoint(x: 0.17105244045780688d, y: 0.6789564986980771d), new NpgsqlTypes.NpgsqlPoint(x: 0.640432004638233d, y: 0.7192640705485818d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5848678060381629d, y: 0.7846501738983581d), new NpgsqlTypes.NpgsqlPoint(x: 0.06309363527437784d, y: 0.2705717677187559d), new NpgsqlTypes.NpgsqlPoint(x: 0.21311237078851597d, y: 0.5930143623308687d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05793690187002798d, y: 0.1924586956793113d), new NpgsqlTypes.NpgsqlPoint(x: 0.7712599119465151d, y: 0.3092542466628756d), new NpgsqlTypes.NpgsqlPoint(x: 0.5868766697930559d, y: 0.1185441645212798d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.529084311043315d, y: 0.002701827318146832d), new NpgsqlTypes.NpgsqlPoint(x: 0.8582127759016022d, y: 0.31162045740991884d), new NpgsqlTypes.NpgsqlPoint(x: 0.7282178464416201d, y: 0.8788038882200531d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21322132363675195d, y: 0.655628108897731d), new NpgsqlTypes.NpgsqlPoint(x: 0.2633933916171727d, y: 0.24033319158162703d), new NpgsqlTypes.NpgsqlPoint(x: 0.9916600735530392d, y: 0.5840009106076337d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6069266092906882d, y: 0.40133148055152157d), new NpgsqlTypes.NpgsqlPoint(x: 0.23389680374529886d, y: 0.06122580960147783d), new NpgsqlTypes.NpgsqlPoint(x: 0.9630590480166593d, y: 0.50066389751209d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3167150149943947d, y: 0.9914810159400587d), new NpgsqlTypes.NpgsqlPoint(x: 0.13427733120367447d, y: 0.2354801942192717d), new NpgsqlTypes.NpgsqlPoint(x: 0.9479186817339337d, y: 0.034138364824013334d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26184084573965427d, y: 0.08501563582871652d), new NpgsqlTypes.NpgsqlPoint(x: 0.26428428342122245d, y: 0.8029092141872122d), new NpgsqlTypes.NpgsqlPoint(x: 0.02676272246461886d, y: 0.0077833117582982725d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9854384730655138d, y: 0.6239577391694633d), new NpgsqlTypes.NpgsqlPoint(x: 0.5332307666616142d, y: 0.25865085573147817d), new NpgsqlTypes.NpgsqlPoint(x: 0.3247672455817009d, y: 0.3265023273356531d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3677710180574032d, y: 0.34107806299681254d), new NpgsqlTypes.NpgsqlPoint(x: 0.36467921185861707d, y: 0.7330570706534373d), new NpgsqlTypes.NpgsqlPoint(x: 0.009554429834105704d, y: 0.30528915211582697d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33261926815960186d, y: 0.27567725791924746d), new NpgsqlTypes.NpgsqlPoint(x: 0.7981745905215314d, y: 0.5585145488386976d), new NpgsqlTypes.NpgsqlPoint(x: 0.26399680736131603d, y: 0.3959162846206806d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1266896559878521d, y: 0.36408984817529144d), new NpgsqlTypes.NpgsqlPoint(x: 0.034425801392003574d, y: 0.2611574734507728d), new NpgsqlTypes.NpgsqlPoint(x: 0.5790352935134568d, y: 0.7134598075179334d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2516126804455292d, y: 0.985344165327225d), new NpgsqlTypes.NpgsqlPoint(x: 0.2377894808437797d, y: 0.9835107568085592d), new NpgsqlTypes.NpgsqlPoint(x: 0.9520455729134484d, y: 0.8813314785432431d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3217824383288639d, y: 0.07542916628833318d), new NpgsqlTypes.NpgsqlPoint(x: 0.34416143721747405d, y: 0.6755378183489857d), new NpgsqlTypes.NpgsqlPoint(x: 0.1495136771834722d, y: 0.5675121407992174d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04763145023316406d, y: 0.6424312344820947d), new NpgsqlTypes.NpgsqlPoint(x: 0.37699493841484544d, y: 0.8988580707249012d), new NpgsqlTypes.NpgsqlPoint(x: 0.9120841479801001d, y: 0.8017798963424597d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42598403303044874d, y: 0.044459883563437d), new NpgsqlTypes.NpgsqlPoint(x: 0.3259482168196697d, y: 0.3220383454488005d), new NpgsqlTypes.NpgsqlPoint(x: 0.42255717521722214d, y: 0.8571051613937912d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.982749933479565d, y: 0.6060995242448605d), new NpgsqlTypes.NpgsqlPoint(x: 0.34037871053287827d, y: 0.17482794976600968d), new NpgsqlTypes.NpgsqlPoint(x: 0.14853076715909586d, y: 0.3410585561987969d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45693350523997744d, y: 0.10816493727772558d), new NpgsqlTypes.NpgsqlPoint(x: 0.8800617772091242d, y: 0.050728238772528966d), new NpgsqlTypes.NpgsqlPoint(x: 0.215095526504281d, y: 0.595206087735252d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5881265516624135d, y: 0.5228384089370597d), new NpgsqlTypes.NpgsqlPoint(x: 0.5622383349457442d, y: 0.23846654832366943d), new NpgsqlTypes.NpgsqlPoint(x: 0.4329094608614663d, y: 0.6001813953781819d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5925566575981499d, y: 0.004586049311189888d), new NpgsqlTypes.NpgsqlPoint(x: 0.8454939190370964d, y: 0.45435777625241025d), new NpgsqlTypes.NpgsqlPoint(x: 0.03169131233393907d, y: 0.16621849051232473d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6082783248551534d, y: 0.3480874720052416d), new NpgsqlTypes.NpgsqlPoint(x: 0.2092424160362688d, y: 0.36490813430938074d), new NpgsqlTypes.NpgsqlPoint(x: 0.08134922602638062d, y: 0.8331087014187892d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.712491456320505d, y: 0.8164633213424843d), new NpgsqlTypes.NpgsqlPoint(x: 0.3214132969328727d, y: 0.8118937169093061d), new NpgsqlTypes.NpgsqlPoint(x: 0.5850710907060972d, y: 0.4952303049409721d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06962475266323742d, y: 0.935250512421291d), new NpgsqlTypes.NpgsqlPoint(x: 0.43149125555981716d, y: 0.30500759926256327d), new NpgsqlTypes.NpgsqlPoint(x: 0.9686990623499979d, y: 0.2587206857191062d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7877632672235244d, y: 0.41479095696125845d), new NpgsqlTypes.NpgsqlPoint(x: 0.5544628815126879d, y: 0.6274959317162678d), new NpgsqlTypes.NpgsqlPoint(x: 0.8637428617754254d, y: 0.8559008451701298d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48523430978227167d, y: 0.5547619395111004d), new NpgsqlTypes.NpgsqlPoint(x: 0.8539320691147951d, y: 0.7966268306985819d), new NpgsqlTypes.NpgsqlPoint(x: 0.40140186239302944d, y: 0.4029147073246364d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9616188807256193d, y: 0.7809494476796237d), new NpgsqlTypes.NpgsqlPoint(x: 0.10773603573339863d, y: 0.1439686587363984d), new NpgsqlTypes.NpgsqlPoint(x: 0.8722933474529037d, y: 0.2706814828529551d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8148245476355809d, y: 0.3826697683127117d), new NpgsqlTypes.NpgsqlPoint(x: 0.1806295430373306d, y: 0.8493114430162909d), new NpgsqlTypes.NpgsqlPoint(x: 0.1347566539191407d, y: 0.38598690917173306d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42783859396612156d, y: 0.6536467776277765d), new NpgsqlTypes.NpgsqlPoint(x: 0.5689402436759338d, y: 0.9157164529858589d), new NpgsqlTypes.NpgsqlPoint(x: 0.36908232715809763d, y: 0.35498920248862087d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36664487029588333d, y: 0.10001380069421573d), new NpgsqlTypes.NpgsqlPoint(x: 0.16201068623188208d, y: 0.7170230568859246d), new NpgsqlTypes.NpgsqlPoint(x: 0.4706076509091669d, y: 0.017253168345734315d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.485266264982953d, y: 0.37013478801906585d), new NpgsqlTypes.NpgsqlPoint(x: 0.28419458780262674d, y: 0.2751340062565808d), new NpgsqlTypes.NpgsqlPoint(x: 0.8140099667102613d, y: 0.5297268433530766d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8578240535632474d, y: 0.5179020944720072d), new NpgsqlTypes.NpgsqlPoint(x: 0.7732573100347557d, y: 0.5071782872864555d), new NpgsqlTypes.NpgsqlPoint(x: 0.0971760916612675d, y: 0.7270077223712309d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49432482689884694d, y: 0.23297300083371675d), new NpgsqlTypes.NpgsqlPoint(x: 0.32689543438621416d, y: 0.03411829503112873d), new NpgsqlTypes.NpgsqlPoint(x: 0.9579271750538668d, y: 0.7433559978230443d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6880035464084228d, y: 0.7532730138734617d), new NpgsqlTypes.NpgsqlPoint(x: 0.38440005120682574d, y: 0.8506634003528282d), new NpgsqlTypes.NpgsqlPoint(x: 0.3220953561926323d, y: 0.04223248594360307d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28862653621847645d, y: 0.11879918651405408d), new NpgsqlTypes.NpgsqlPoint(x: 0.13753900258007468d, y: 0.4948774937729393d), new NpgsqlTypes.NpgsqlPoint(x: 0.846820890926571d, y: 0.04061979749639555d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5304851540033111d, y: 0.5336843518503352d), new NpgsqlTypes.NpgsqlPoint(x: 0.34128178464655334d, y: 0.6399285682438886d), new NpgsqlTypes.NpgsqlPoint(x: 0.014913006919098803d, y: 0.8595788877559488d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9486201369825094d, y: 0.22051078988801287d), new NpgsqlTypes.NpgsqlPoint(x: 0.25241900213811497d, y: 0.7433689738049561d), new NpgsqlTypes.NpgsqlPoint(x: 0.5640377043004248d, y: 0.8361500143705791d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3729039119444364d, y: 0.04032181705052562d), new NpgsqlTypes.NpgsqlPoint(x: 0.3758006955587895d, y: 0.9175241574355315d), new NpgsqlTypes.NpgsqlPoint(x: 0.8226695195479261d, y: 0.08667469591327215d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3264767539260349d, y: 0.7731752751268246d), new NpgsqlTypes.NpgsqlPoint(x: 0.8544483468953974d, y: 0.2934546604581296d), new NpgsqlTypes.NpgsqlPoint(x: 0.9051558141014457d, y: 0.6814693654555514d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6064374370578466d, y: 0.575076642837502d), new NpgsqlTypes.NpgsqlPoint(x: 0.17985140734569338d, y: 0.7593266512698741d), new NpgsqlTypes.NpgsqlPoint(x: 0.7502480920248772d, y: 0.16311224829264503d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18168922380490837d, y: 0.023584353833935978d), new NpgsqlTypes.NpgsqlPoint(x: 0.5475481437148753d, y: 0.6936764554159716d), new NpgsqlTypes.NpgsqlPoint(x: 0.6347947696833509d, y: 0.5239285166033616d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7350285218835679d, y: 0.6338060431231355d), new NpgsqlTypes.NpgsqlPoint(x: 0.650542600338948d, y: 0.1564805814209299d), new NpgsqlTypes.NpgsqlPoint(x: 0.3614222685288433d, y: 0.32069171550242925d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9373654765181825d, y: 0.18649768493685215d), new NpgsqlTypes.NpgsqlPoint(x: 0.6022725383672606d, y: 0.5074835272342558d), new NpgsqlTypes.NpgsqlPoint(x: 0.9661988891233654d, y: 0.09594473834454242d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6650221615453862d, y: 0.5768307581677063d), new NpgsqlTypes.NpgsqlPoint(x: 0.34428445140178d, y: 0.7133777400445396d), new NpgsqlTypes.NpgsqlPoint(x: 0.4296926092407076d, y: 0.9012675639672322d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7538908730370593d, y: 0.5117349288704274d), new NpgsqlTypes.NpgsqlPoint(x: 0.6905398979710718d, y: 0.6858295032142022d), new NpgsqlTypes.NpgsqlPoint(x: 0.9436188491945998d, y: 0.2007595985250591d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5739154027033663d, y: 0.8713514009187531d), new NpgsqlTypes.NpgsqlPoint(x: 0.23181467171228398d, y: 0.22557211386174225d), new NpgsqlTypes.NpgsqlPoint(x: 0.23796696014731888d, y: 0.2762015711075896d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1453561320202038d, y: 0.8067997239808582d), new NpgsqlTypes.NpgsqlPoint(x: 0.8026725342708572d, y: 0.32633622048835853d), new NpgsqlTypes.NpgsqlPoint(x: 0.7259131982121612d, y: 0.9361366668494571d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7667640361847218d, y: 0.6938780070238308d), new NpgsqlTypes.NpgsqlPoint(x: 0.43432717243775276d, y: 0.2522286336130839d), new NpgsqlTypes.NpgsqlPoint(x: 0.9591411419489304d, y: 0.38788332609823784d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40488322924545694d, y: 0.8284619591487967d), new NpgsqlTypes.NpgsqlPoint(x: 0.4608344188463438d, y: 0.9060919765739004d), new NpgsqlTypes.NpgsqlPoint(x: 0.6785732653217996d, y: 0.7760133470323467d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9830689910437093d, y: 0.31397980559097727d), new NpgsqlTypes.NpgsqlPoint(x: 0.5157420807970344d, y: 0.04228473504872898d), new NpgsqlTypes.NpgsqlPoint(x: 0.8126679164353698d, y: 0.43258055257720907d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6860867988010224d, y: 0.16709821083101906d), new NpgsqlTypes.NpgsqlPoint(x: 0.31153039002908123d, y: 0.8696458324406608d), new NpgsqlTypes.NpgsqlPoint(x: 0.8209144401722067d, y: 0.8509777574783417d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1587806180028417d, y: 0.9957936070621707d), new NpgsqlTypes.NpgsqlPoint(x: 0.1589010227337202d, y: 0.006545463095058879d), new NpgsqlTypes.NpgsqlPoint(x: 0.4484891985950108d, y: 0.11138255261882946d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30602683570525513d, y: 0.6692290194843286d), new NpgsqlTypes.NpgsqlPoint(x: 0.9339839960714219d, y: 0.3937580678880832d), new NpgsqlTypes.NpgsqlPoint(x: 0.7545965378564831d, y: 0.05442928473006914d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1416352116776638d, y: 0.8070427554925678d), new NpgsqlTypes.NpgsqlPoint(x: 0.5358714196738469d, y: 0.10784339927664832d), new NpgsqlTypes.NpgsqlPoint(x: 0.48071657538809154d, y: 0.2627503068951078d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9860127679136661d, y: 0.8977417468651059d), new NpgsqlTypes.NpgsqlPoint(x: 0.3615901374362117d, y: 0.25306150682000794d), new NpgsqlTypes.NpgsqlPoint(x: 0.06542280812977208d, y: 0.21390332198910267d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.874261575901092d, y: 0.616195552585246d), new NpgsqlTypes.NpgsqlPoint(x: 0.7327613398294612d, y: 0.42809175430602775d), new NpgsqlTypes.NpgsqlPoint(x: 0.9827277805164492d, y: 0.8905675294717417d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18265721338863972d, y: 0.01597826516918044d), new NpgsqlTypes.NpgsqlPoint(x: 0.02404384906821022d, y: 0.21429852151072204d), new NpgsqlTypes.NpgsqlPoint(x: 0.8668418448304175d, y: 0.9964338712883212d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6805057001182077d, y: 0.027504568918331862d), new NpgsqlTypes.NpgsqlPoint(x: 0.6543543473818524d, y: 0.8327549745383791d), new NpgsqlTypes.NpgsqlPoint(x: 0.3455591955187467d, y: 0.4779987266314094d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9286954551371478d, y: 0.9776529623009415d), new NpgsqlTypes.NpgsqlPoint(x: 0.4206809965670343d, y: 0.7550514267095306d), new NpgsqlTypes.NpgsqlPoint(x: 0.2726607544139622d, y: 0.3506682688869789d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6052603375591565d, y: 0.08521421703708687d), new NpgsqlTypes.NpgsqlPoint(x: 0.07926243548638745d, y: 0.9226229655331445d), new NpgsqlTypes.NpgsqlPoint(x: 0.5144005220696746d, y: 0.6979484554872031d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8097851051288201d, y: 0.7730731954446536d), new NpgsqlTypes.NpgsqlPoint(x: 0.13838796961134525d, y: 0.9619462575736101d), new NpgsqlTypes.NpgsqlPoint(x: 0.8175059467495993d, y: 0.47392388927604867d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08406757529693065d, y: 0.7446698456113048d), new NpgsqlTypes.NpgsqlPoint(x: 0.35856264240155256d, y: 0.48247163797210935d), new NpgsqlTypes.NpgsqlPoint(x: 0.5864877549172631d, y: 0.9462453067050813d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04543585649369575d, y: 0.5814181346369369d), new NpgsqlTypes.NpgsqlPoint(x: 0.060845088898349164d, y: 0.7770404747326752d), new NpgsqlTypes.NpgsqlPoint(x: 0.52053388586306d, y: 0.30039287733111286d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8994717009842551d, y: 0.9982846082866892d), new NpgsqlTypes.NpgsqlPoint(x: 0.2841384932878661d, y: 0.4674660968129537d), new NpgsqlTypes.NpgsqlPoint(x: 0.5837076140520051d, y: 0.6159094389957217d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7289222287856599d, y: 0.6511560230568276d), new NpgsqlTypes.NpgsqlPoint(x: 0.7837197697646856d, y: 0.34985208239067267d), new NpgsqlTypes.NpgsqlPoint(x: 0.2626101984439462d, y: 0.9767156266094017d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2743882821122452d, y: 0.41106142967721526d), new NpgsqlTypes.NpgsqlPoint(x: 0.708061074747016d, y: 0.06587701360985643d), new NpgsqlTypes.NpgsqlPoint(x: 0.012361996136110776d, y: 0.2888991085697723d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8401758405716454d, y: 0.10332631116883484d), new NpgsqlTypes.NpgsqlPoint(x: 0.9248470435033491d, y: 0.41630560203736433d), new NpgsqlTypes.NpgsqlPoint(x: 0.4393221023101991d, y: 0.23853864574871197d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21174649376511656d, y: 0.7291409246939123d), new NpgsqlTypes.NpgsqlPoint(x: 0.025255780927127325d, y: 0.774389177083048d), new NpgsqlTypes.NpgsqlPoint(x: 0.6874513225019362d, y: 0.3817074723864664d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3453458681865973d, y: 0.28233215855263705d), new NpgsqlTypes.NpgsqlPoint(x: 0.007503930519951907d, y: 0.01324974460863082d), new NpgsqlTypes.NpgsqlPoint(x: 0.34061329245453154d, y: 0.007099473347792373d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5417809853579767d, y: 0.3747243284471923d), new NpgsqlTypes.NpgsqlPoint(x: 0.5348876397636899d, y: 0.6944150719347212d), new NpgsqlTypes.NpgsqlPoint(x: 0.8325972935192876d, y: 0.02477361301881753d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30598280075689244d, y: 0.9077007418458484d), new NpgsqlTypes.NpgsqlPoint(x: 0.6121053505439635d, y: 0.9912902606648597d), new NpgsqlTypes.NpgsqlPoint(x: 0.8110835419456833d, y: 0.057329661783663166d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4344111930420924d, y: 0.34702228549525893d), new NpgsqlTypes.NpgsqlPoint(x: 0.9609228879220219d, y: 0.8783288674278548d), new NpgsqlTypes.NpgsqlPoint(x: 0.1258492043421381d, y: 0.355371027912217d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.811243927342798d, y: 0.07161525816676517d), new NpgsqlTypes.NpgsqlPoint(x: 0.9514328275971372d, y: 0.31052698410239077d), new NpgsqlTypes.NpgsqlPoint(x: 0.3464535679356481d, y: 0.18923362341289585d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3061179854302962d, y: 0.9330965115147126d), new NpgsqlTypes.NpgsqlPoint(x: 0.15621668653422127d, y: 0.35990492442203315d), new NpgsqlTypes.NpgsqlPoint(x: 0.23150823161944922d, y: 0.9417381681492142d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4149412568342249d, y: 0.213986721097158d), new NpgsqlTypes.NpgsqlPoint(x: 0.19027858370595208d, y: 0.3253403357225595d), new NpgsqlTypes.NpgsqlPoint(x: 0.21001309422225722d, y: 0.6647608061694118d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6040486596779284d, y: 0.41533483236681823d), new NpgsqlTypes.NpgsqlPoint(x: 0.8297967079253713d, y: 0.41349268836745723d), new NpgsqlTypes.NpgsqlPoint(x: 0.041296202369534685d, y: 0.4389175852840935d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7919292452692713d, y: 0.061611759806095234d), new NpgsqlTypes.NpgsqlPoint(x: 0.9365037193687614d, y: 0.24598132521148186d), new NpgsqlTypes.NpgsqlPoint(x: 0.18168650752148252d, y: 0.3817015077089033d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13156141747447714d, y: 0.40435780554289424d), new NpgsqlTypes.NpgsqlPoint(x: 0.6634154299977899d, y: 0.7453961963684628d), new NpgsqlTypes.NpgsqlPoint(x: 0.8738206543766303d, y: 0.708571701527087d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19208038420932405d, y: 0.01666843229854642d), new NpgsqlTypes.NpgsqlPoint(x: 0.21310310916667485d, y: 0.29703813164473925d), new NpgsqlTypes.NpgsqlPoint(x: 0.6112496056167146d, y: 0.9625626388122926d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1953852044792792d, y: 0.5349036160349891d), new NpgsqlTypes.NpgsqlPoint(x: 0.15163030497546037d, y: 0.07076697250492381d), new NpgsqlTypes.NpgsqlPoint(x: 0.6324454208060829d, y: 0.6930161404426533d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6897240846049384d, y: 0.6564632328824248d), new NpgsqlTypes.NpgsqlPoint(x: 0.8547423654442345d, y: 0.9033120383948215d), new NpgsqlTypes.NpgsqlPoint(x: 0.9964913839035776d, y: 0.5934469084803163d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09867763621245296d, y: 0.3277414010725034d), new NpgsqlTypes.NpgsqlPoint(x: 0.8131500664894741d, y: 0.9070134807405053d), new NpgsqlTypes.NpgsqlPoint(x: 0.6154585919814088d, y: 0.7718659770926003d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8980728237875548d, y: 0.9853096886279646d), new NpgsqlTypes.NpgsqlPoint(x: 0.49200038140689495d, y: 0.014609281068204805d), new NpgsqlTypes.NpgsqlPoint(x: 0.07966358126832485d, y: 0.0017361797636107346d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4166253974365096d, y: 0.6612280074898091d), new NpgsqlTypes.NpgsqlPoint(x: 0.3829528250217974d, y: 0.19488794163904877d), new NpgsqlTypes.NpgsqlPoint(x: 0.7241878514971748d, y: 0.8122391716931348d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6246489920629207d, y: 0.46771806692683127d), new NpgsqlTypes.NpgsqlPoint(x: 0.20818765976654452d, y: 0.4374642820374681d), new NpgsqlTypes.NpgsqlPoint(x: 0.044535918081981096d, y: 0.5486370250123566d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5437724402275871d, y: 0.4102966522413575d), new NpgsqlTypes.NpgsqlPoint(x: 0.06095518728073779d, y: 0.8032102218378669d), new NpgsqlTypes.NpgsqlPoint(x: 0.5701652717209764d, y: 0.9503352950058566d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3094094324761547d, y: 0.2769921286632122d), new NpgsqlTypes.NpgsqlPoint(x: 0.5068458935546444d, y: 0.5322330010926775d), new NpgsqlTypes.NpgsqlPoint(x: 0.06801829285567096d, y: 0.5902405711182054d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1029659726240324d, y: 0.09314740274590771d), new NpgsqlTypes.NpgsqlPoint(x: 0.6819326321644724d, y: 0.29227545525133247d), new NpgsqlTypes.NpgsqlPoint(x: 0.6479354801322134d, y: 0.8679619396302042d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9447224639623739d, y: 0.968880084117953d), new NpgsqlTypes.NpgsqlPoint(x: 0.5906542441311552d, y: 0.5426521626286884d), new NpgsqlTypes.NpgsqlPoint(x: 0.5325539366077395d, y: 0.23375413104804343d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.010244296846227408d, y: 0.44780946346500816d), new NpgsqlTypes.NpgsqlPoint(x: 0.9776653688760317d, y: 0.06268065143499058d), new NpgsqlTypes.NpgsqlPoint(x: 0.03593635913375892d, y: 0.5271040840667511d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4941049385953573d, y: 0.607916244793304d), new NpgsqlTypes.NpgsqlPoint(x: 0.9723484239816531d, y: 0.6846773082636834d), new NpgsqlTypes.NpgsqlPoint(x: 0.7807224709213813d, y: 0.21728596845838954d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6838245984795479d, y: 0.5491276289384213d), new NpgsqlTypes.NpgsqlPoint(x: 0.5575624986860959d, y: 0.7344567657386436d), new NpgsqlTypes.NpgsqlPoint(x: 0.7117877459901485d, y: 0.6266947668229822d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30354123744269756d, y: 0.01825192855158153d), new NpgsqlTypes.NpgsqlPoint(x: 0.9929122607005781d, y: 0.2080884639585937d), new NpgsqlTypes.NpgsqlPoint(x: 0.001974993803250835d, y: 0.27162375175976505d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1784218848338881d, y: 0.7436763282551172d), new NpgsqlTypes.NpgsqlPoint(x: 0.19061038423210253d, y: 0.14801912360260527d), new NpgsqlTypes.NpgsqlPoint(x: 0.5360371743589937d, y: 0.7108925997760595d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30597182769854514d, y: 0.1357118389683022d), new NpgsqlTypes.NpgsqlPoint(x: 0.7425824519876482d, y: 0.8058202249206868d), new NpgsqlTypes.NpgsqlPoint(x: 0.5823888869305327d, y: 0.7739984357301285d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15618576210843815d, y: 0.2279145071614691d), new NpgsqlTypes.NpgsqlPoint(x: 0.2965465186996553d, y: 0.7994952056702049d), new NpgsqlTypes.NpgsqlPoint(x: 0.6055859150719073d, y: 0.3109747638748398d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.649775022595198d, y: 0.10206156359898477d), new NpgsqlTypes.NpgsqlPoint(x: 0.8017055685921523d, y: 0.07253982051638874d), new NpgsqlTypes.NpgsqlPoint(x: 0.2678317098608669d, y: 0.5382510330436882d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9134873151054043d, y: 0.1822469764621949d), new NpgsqlTypes.NpgsqlPoint(x: 0.409221839746287d, y: 0.8846035381982319d), new NpgsqlTypes.NpgsqlPoint(x: 0.23073480979109373d, y: 0.5032273367237718d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8053584674361132d, y: 0.6933116874541997d), new NpgsqlTypes.NpgsqlPoint(x: 0.5051857959545203d, y: 0.22231015203798443d), new NpgsqlTypes.NpgsqlPoint(x: 0.7581591550312381d, y: 0.6351917951914628d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24653790501295036d, y: 0.17768660858853524d), new NpgsqlTypes.NpgsqlPoint(x: 0.6768621072238211d, y: 0.9618876849522459d), new NpgsqlTypes.NpgsqlPoint(x: 0.905865072506871d, y: 0.3425911429705719d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22772652972283702d, y: 0.7101579112058679d), new NpgsqlTypes.NpgsqlPoint(x: 0.17260729657796026d, y: 0.3799358408160166d), new NpgsqlTypes.NpgsqlPoint(x: 0.07427631758011899d, y: 0.7812710774320888d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12177575226730086d, y: 0.019139158102912668d), new NpgsqlTypes.NpgsqlPoint(x: 0.36661238960129716d, y: 0.9630869868273134d), new NpgsqlTypes.NpgsqlPoint(x: 0.35168458651616263d, y: 0.855354844965345d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08447253379004172d, y: 0.5165403635493266d), new NpgsqlTypes.NpgsqlPoint(x: 0.049744134929844974d, y: 0.13486456390570034d), new NpgsqlTypes.NpgsqlPoint(x: 0.6338435395545197d, y: 0.25433425448308256d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5811884541852719d, y: 0.6008844864861358d), new NpgsqlTypes.NpgsqlPoint(x: 0.7413356437641113d, y: 0.19833932887647943d), new NpgsqlTypes.NpgsqlPoint(x: 0.7601756176986137d, y: 0.32791469628679815d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20510882728959634d, y: 0.07535647519696476d), new NpgsqlTypes.NpgsqlPoint(x: 0.7630196837095947d, y: 0.4180140409722637d), new NpgsqlTypes.NpgsqlPoint(x: 0.1575382766282838d, y: 0.19967874750054337d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4079877820041058d, y: 0.9248378037372511d), new NpgsqlTypes.NpgsqlPoint(x: 0.4694945852854142d, y: 0.44347062568692164d), new NpgsqlTypes.NpgsqlPoint(x: 0.20068924516363917d, y: 0.5317865489412094d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3535391614154255d, y: 0.4570074974030759d), new NpgsqlTypes.NpgsqlPoint(x: 0.6694237734726909d, y: 0.04894231364329238d), new NpgsqlTypes.NpgsqlPoint(x: 0.09663985080495718d, y: 0.7059914274895447d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07359846413718152d, y: 0.7705111599604794d), new NpgsqlTypes.NpgsqlPoint(x: 0.17381737368653716d, y: 0.0440925141507712d), new NpgsqlTypes.NpgsqlPoint(x: 0.8423205402291368d, y: 0.7991532159038982d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 95,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3022049478802966d, y: 0.500929865121019d), new NpgsqlTypes.NpgsqlPoint(x: 0.5301699248831243d, y: 0.5425389188945212d), new NpgsqlTypes.NpgsqlPoint(x: 0.3449087294351142d, y: 0.8615619493912429d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.796810859069251d, y: 0.7595338059295275d), new NpgsqlTypes.NpgsqlPoint(x: 0.830836242776779d, y: 0.27599586772871143d), new NpgsqlTypes.NpgsqlPoint(x: 0.21698928775479565d, y: 0.44501426232089725d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9790880643995432d, y: 0.4267588504054609d), new NpgsqlTypes.NpgsqlPoint(x: 0.14456076126978856d, y: 0.4744364729604327d), new NpgsqlTypes.NpgsqlPoint(x: 0.0865034753655336d, y: 0.5312616719885808d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5591745100266785d, y: 0.9070446738038875d), new NpgsqlTypes.NpgsqlPoint(x: 0.6929003590585774d, y: 0.2692413710499977d), new NpgsqlTypes.NpgsqlPoint(x: 0.2252557306631191d, y: 0.3378825501751702d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3638260766574929d, y: 0.659052642272281d), new NpgsqlTypes.NpgsqlPoint(x: 0.23270878903513315d, y: 0.8613359382785603d), new NpgsqlTypes.NpgsqlPoint(x: 0.46388342736584576d, y: 0.8820720110508582d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7108026134172493d, y: 0.3011700502127187d), new NpgsqlTypes.NpgsqlPoint(x: 0.22675244729705268d, y: 0.8863974160808319d), new NpgsqlTypes.NpgsqlPoint(x: 0.7306103862051696d, y: 0.8955958549564285d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5577248891000117d, y: 0.3364577753754354d), new NpgsqlTypes.NpgsqlPoint(x: 0.03778273326410442d, y: 0.7941807278786339d), new NpgsqlTypes.NpgsqlPoint(x: 0.6979228114961132d, y: 0.25694580826612623d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7751093392361164d, y: 0.9736869572132512d), new NpgsqlTypes.NpgsqlPoint(x: 0.13330128274345232d, y: 0.37763164494238766d), new NpgsqlTypes.NpgsqlPoint(x: 0.6365535672792166d, y: 0.5244978341932363d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6436732683676245d, y: 0.31164766036585545d), new NpgsqlTypes.NpgsqlPoint(x: 0.3673026502889871d, y: 0.015433457959146857d), new NpgsqlTypes.NpgsqlPoint(x: 0.5775368186517635d, y: 0.546181774441277d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12589874298107928d, y: 0.9825558709948873d), new NpgsqlTypes.NpgsqlPoint(x: 0.776684450288448d, y: 0.6298943661909449d), new NpgsqlTypes.NpgsqlPoint(x: 0.08310695593176876d, y: 0.9979123977541465d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9437932600285555d, y: 0.053526659394793175d), new NpgsqlTypes.NpgsqlPoint(x: 0.8140417302995276d, y: 0.3084694785105241d), new NpgsqlTypes.NpgsqlPoint(x: 0.5057566165571713d, y: 0.6914753200889154d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 104,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22100396187204285d, y: 0.175725412130058d), new NpgsqlTypes.NpgsqlPoint(x: 0.4991976413298853d, y: 0.32497744001182494d), new NpgsqlTypes.NpgsqlPoint(x: 0.794788070553786d, y: 0.026060994460395337d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6031837581942507d, y: 0.16387943074380917d), new NpgsqlTypes.NpgsqlPoint(x: 0.6849904969567072d, y: 0.6223169140590186d), new NpgsqlTypes.NpgsqlPoint(x: 0.04494141699158627d, y: 0.5821061632754664d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4874057354837369d, y: 0.509102786238773d), new NpgsqlTypes.NpgsqlPoint(x: 0.7436401351681466d, y: 0.37246576403109866d), new NpgsqlTypes.NpgsqlPoint(x: 0.3707793821430888d, y: 0.9417590617406739d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3377980952519348d, y: 0.8701295531932095d), new NpgsqlTypes.NpgsqlPoint(x: 0.40945737999238496d, y: 0.08696170276197823d), new NpgsqlTypes.NpgsqlPoint(x: 0.9629723725487688d, y: 0.7369364103302033d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 111,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6533384383629706d, y: 0.882933592704042d), new NpgsqlTypes.NpgsqlPoint(x: 0.9775885400022958d, y: 0.9881030501560552d), new NpgsqlTypes.NpgsqlPoint(x: 0.8875141069895504d, y: 0.1815970630543179d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04973886893556079d, y: 0.18509255600995267d), new NpgsqlTypes.NpgsqlPoint(x: 0.23662235221264616d, y: 0.8158280086519972d), new NpgsqlTypes.NpgsqlPoint(x: 0.9930353259609261d, y: 0.7418993910347175d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5657954010220564d, y: 0.5114092651354638d), new NpgsqlTypes.NpgsqlPoint(x: 0.7075391931488684d, y: 0.42862087813157346d), new NpgsqlTypes.NpgsqlPoint(x: 0.44957159286057d, y: 0.09571268732849503d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8172950653850807d, y: 0.33378875739589353d), new NpgsqlTypes.NpgsqlPoint(x: 0.9353327396364743d, y: 0.42878085024579726d), new NpgsqlTypes.NpgsqlPoint(x: 0.015143238355265431d, y: 0.06155408746539137d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43602984523365795d, y: 0.27051312196890076d), new NpgsqlTypes.NpgsqlPoint(x: 0.29245454158262163d, y: 0.8060077616376603d), new NpgsqlTypes.NpgsqlPoint(x: 0.7621615719658624d, y: 0.10227207620717882d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1422137087831532d, y: 0.1324584832712803d), new NpgsqlTypes.NpgsqlPoint(x: 0.5442110195529481d, y: 0.3341898687977092d), new NpgsqlTypes.NpgsqlPoint(x: 0.18438382611375026d, y: 0.6555598441995346d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 119,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6309015937372655d, y: 0.39853879294937267d), new NpgsqlTypes.NpgsqlPoint(x: 0.9697920297200382d, y: 0.16528630066548955d), new NpgsqlTypes.NpgsqlPoint(x: 0.8216386607638857d, y: 0.0874580713957035d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11438536039013636d, y: 0.9831695239528105d), new NpgsqlTypes.NpgsqlPoint(x: 0.5077059576078277d, y: 0.43832010865494575d), new NpgsqlTypes.NpgsqlPoint(x: 0.06061045840648105d, y: 0.75832313667725d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7522575353818353d, y: 0.006099515011632639d), new NpgsqlTypes.NpgsqlPoint(x: 0.3901401098426831d, y: 0.5315443838373999d), new NpgsqlTypes.NpgsqlPoint(x: 0.8507107309491242d, y: 0.942255760958335d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 126,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8553079559028556d, y: 0.035387942397809624d), new NpgsqlTypes.NpgsqlPoint(x: 0.5425971883339439d, y: 0.7128147822148022d), new NpgsqlTypes.NpgsqlPoint(x: 0.2693140673895722d, y: 0.9610306550272806d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8824022020230173d, y: 0.5755223256239212d), new NpgsqlTypes.NpgsqlPoint(x: 0.5445376912107469d, y: 0.956553201383534d), new NpgsqlTypes.NpgsqlPoint(x: 0.6196546149284191d, y: 0.2478491556452581d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8969846252528403d, y: 0.6332725264633898d), new NpgsqlTypes.NpgsqlPoint(x: 0.19353306959592742d, y: 0.14360729569584174d), new NpgsqlTypes.NpgsqlPoint(x: 0.4392780669616644d, y: 0.9263801694193938d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0435855282515456d, y: 0.28090270056908617d), new NpgsqlTypes.NpgsqlPoint(x: 0.7750556360639342d, y: 0.7796783257710381d), new NpgsqlTypes.NpgsqlPoint(x: 0.24394159281078054d, y: 0.14971046380511366d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7158571068390918d, y: 0.9190745520348597d), new NpgsqlTypes.NpgsqlPoint(x: 0.3730570579146423d, y: 0.7049643623523346d), new NpgsqlTypes.NpgsqlPoint(x: 0.9483673127981068d, y: 0.4995219552713507d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8906956321129355d, y: 0.426661568013996d), new NpgsqlTypes.NpgsqlPoint(x: 0.9040589797970672d, y: 0.19778775437460216d), new NpgsqlTypes.NpgsqlPoint(x: 0.17062600952934204d, y: 0.8562341597443649d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 128,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8908772700012562d, y: 0.9311051814246025d), new NpgsqlTypes.NpgsqlPoint(x: 0.23550603065929476d, y: 0.4196411875605284d), new NpgsqlTypes.NpgsqlPoint(x: 0.4636000576618361d, y: 0.23340758780058435d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.394757913029127d, y: 0.4603124528649768d), new NpgsqlTypes.NpgsqlPoint(x: 0.9672397332368786d, y: 0.966266975201903d), new NpgsqlTypes.NpgsqlPoint(x: 0.8938951518537552d, y: 0.6303866200088407d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9276531125094998d, y: 0.1205022541644849d), new NpgsqlTypes.NpgsqlPoint(x: 0.06515561438193584d, y: 0.06423377147731357d), new NpgsqlTypes.NpgsqlPoint(x: 0.6060728153284597d, y: 0.04596935393301904d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8336103583567471d, y: 0.7510375433750782d), new NpgsqlTypes.NpgsqlPoint(x: 0.02427584954674633d, y: 0.2777837739540945d), new NpgsqlTypes.NpgsqlPoint(x: 0.15638783470952133d, y: 0.560960677349195d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 132,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09342651255550816d, y: 0.6366012558600413d), new NpgsqlTypes.NpgsqlPoint(x: 0.1999992647339437d, y: 0.6744905836742527d), new NpgsqlTypes.NpgsqlPoint(x: 0.17451729593026022d, y: 0.7415740489593696d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3754138029712637d, y: 0.3657672062283115d), new NpgsqlTypes.NpgsqlPoint(x: 0.8213917003921652d, y: 0.056637022037372975d), new NpgsqlTypes.NpgsqlPoint(x: 0.9154781604772367d, y: 0.34351798013313994d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3051839660051532d, y: 0.47908332477880033d), new NpgsqlTypes.NpgsqlPoint(x: 0.1775290924993942d, y: 0.6886241098396054d), new NpgsqlTypes.NpgsqlPoint(x: 0.3071764876263241d, y: 0.29913736061582163d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39552378403595756d, y: 0.02288934621329608d), new NpgsqlTypes.NpgsqlPoint(x: 0.9325040271831427d, y: 0.8819753377290089d), new NpgsqlTypes.NpgsqlPoint(x: 0.5733754478876926d, y: 0.8593271171946083d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19988698324677456d, y: 0.6247999930138987d), new NpgsqlTypes.NpgsqlPoint(x: 0.42344786888844843d, y: 0.26038094514261256d), new NpgsqlTypes.NpgsqlPoint(x: 0.9805682305091651d, y: 0.044910519484133604d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.849092618350204d, y: 0.08358131066438679d), new NpgsqlTypes.NpgsqlPoint(x: 0.03938419855228725d, y: 0.44710166424396813d), new NpgsqlTypes.NpgsqlPoint(x: 0.825842540333959d, y: 0.5457129291498369d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6424390089316724d, y: 0.1076162826375342d), new NpgsqlTypes.NpgsqlPoint(x: 0.6748911577694792d, y: 0.5802281381255312d), new NpgsqlTypes.NpgsqlPoint(x: 0.94149256315756d, y: 0.06213104646994572d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6428788728613528d, y: 0.5866525705596743d), new NpgsqlTypes.NpgsqlPoint(x: 0.2158121214357257d, y: 0.9794583757728326d), new NpgsqlTypes.NpgsqlPoint(x: 0.6526053124503338d, y: 0.5044193945479437d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 133,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6250880634158096d, y: 0.8325215715547516d), new NpgsqlTypes.NpgsqlPoint(x: 0.1455685570123586d, y: 0.9563301961980574d), new NpgsqlTypes.NpgsqlPoint(x: 0.44024257864214156d, y: 0.2940880237994945d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43320561319277884d, y: 0.5339663019178802d), new NpgsqlTypes.NpgsqlPoint(x: 0.11644682592203437d, y: 0.3825269562410857d), new NpgsqlTypes.NpgsqlPoint(x: 0.34208204739538484d, y: 0.8724881997543279d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6252913316724993d, y: 0.9998009268092984d), new NpgsqlTypes.NpgsqlPoint(x: 0.10869932163861051d, y: 0.9831952758829946d), new NpgsqlTypes.NpgsqlPoint(x: 0.5152298804730647d, y: 0.4512969103173614d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4850752092973154d, y: 0.6040439815936566d), new NpgsqlTypes.NpgsqlPoint(x: 0.8268800447573351d, y: 0.10059829445436497d), new NpgsqlTypes.NpgsqlPoint(x: 0.4066620129779216d, y: 0.39810314511349d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7121834147288647d, y: 0.2457432067332329d), new NpgsqlTypes.NpgsqlPoint(x: 0.9973255897029791d, y: 0.6594206115709194d), new NpgsqlTypes.NpgsqlPoint(x: 0.8330178188324262d, y: 0.9326868641184939d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9420608562266052d, y: 0.618586950309236d), new NpgsqlTypes.NpgsqlPoint(x: 0.09272332774043579d, y: 0.7137615723488421d), new NpgsqlTypes.NpgsqlPoint(x: 0.6663692051303747d, y: 0.8511991478618279d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 140,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6600271193477342d, y: 0.6482751725079519d), new NpgsqlTypes.NpgsqlPoint(x: 0.3635162322303991d, y: 0.6150198570295413d), new NpgsqlTypes.NpgsqlPoint(x: 0.7606520506690282d, y: 0.22741719862884835d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9893242430332825d, y: 0.2591541068851194d), new NpgsqlTypes.NpgsqlPoint(x: 0.7116643884311349d, y: 0.9732531192630488d), new NpgsqlTypes.NpgsqlPoint(x: 0.9081101192918383d, y: 0.9221155028188555d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7491741397264932d, y: 0.9612355341020548d), new NpgsqlTypes.NpgsqlPoint(x: 0.9841486066866478d, y: 0.763440245360158d), new NpgsqlTypes.NpgsqlPoint(x: 0.7059039088557443d, y: 0.7647522959334291d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8523660423637897d, y: 0.7650514784652896d), new NpgsqlTypes.NpgsqlPoint(x: 0.32950304216887805d, y: 0.5732898094895367d), new NpgsqlTypes.NpgsqlPoint(x: 0.13686712116018918d, y: 0.27058966798463646d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19380578045564623d, y: 0.18407209535785984d), new NpgsqlTypes.NpgsqlPoint(x: 0.44741207596590127d, y: 0.5163845916349072d), new NpgsqlTypes.NpgsqlPoint(x: 0.5299886462836987d, y: 0.6947635994686148d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.041183279725148125d, y: 0.6947556022132598d), new NpgsqlTypes.NpgsqlPoint(x: 0.9312103851802123d, y: 0.23099716680385907d), new NpgsqlTypes.NpgsqlPoint(x: 0.5606386493776894d, y: 0.6972667508339716d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22603057204500154d, y: 0.18033128136029863d), new NpgsqlTypes.NpgsqlPoint(x: 0.10882040642594404d, y: 0.744335774485939d), new NpgsqlTypes.NpgsqlPoint(x: 0.6505975427051599d, y: 0.8982559395267503d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5686295906970075d, y: 0.34799395648466547d), new NpgsqlTypes.NpgsqlPoint(x: 0.8528104400518158d, y: 0.2742911634904922d), new NpgsqlTypes.NpgsqlPoint(x: 0.11730448121036319d, y: 0.8165050260363651d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08212196276810013d, y: 0.8780288866035753d), new NpgsqlTypes.NpgsqlPoint(x: 0.36291673362956156d, y: 0.9826035302081189d), new NpgsqlTypes.NpgsqlPoint(x: 0.43930212721400586d, y: 0.4224014617594214d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0884262013445537d, y: 0.7188320003034786d), new NpgsqlTypes.NpgsqlPoint(x: 0.23867494310295d, y: 0.6898988173210787d), new NpgsqlTypes.NpgsqlPoint(x: 0.9923132855029583d, y: 0.31299939717276903d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8304467194872935d, y: 0.9125206168292783d), new NpgsqlTypes.NpgsqlPoint(x: 0.02445033013225384d, y: 0.17356807202426083d), new NpgsqlTypes.NpgsqlPoint(x: 0.9682232404519443d, y: 0.26238226357201433d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39234423672141094d, y: 0.1414323584905065d), new NpgsqlTypes.NpgsqlPoint(x: 0.09081952833514295d, y: 0.3266718894209909d), new NpgsqlTypes.NpgsqlPoint(x: 0.6502339820903652d, y: 0.9193652621758845d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32182807792732304d, y: 0.7700094885134277d), new NpgsqlTypes.NpgsqlPoint(x: 0.7324399193168653d, y: 0.2476942666883477d), new NpgsqlTypes.NpgsqlPoint(x: 0.4745082762899021d, y: 0.8414492860597781d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16040719142546256d, y: 0.06460241788138221d), new NpgsqlTypes.NpgsqlPoint(x: 0.6939463779289794d, y: 0.7280084673147512d), new NpgsqlTypes.NpgsqlPoint(x: 0.5102166204395301d, y: 0.8583309180735573d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7398591394819214d, y: 0.9446372636847659d), new NpgsqlTypes.NpgsqlPoint(x: 0.35484208301766107d, y: 0.32950633141121655d), new NpgsqlTypes.NpgsqlPoint(x: 0.05563789312179801d, y: 0.9922690779782757d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 148,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6876668296683106d, y: 0.5504157262033506d), new NpgsqlTypes.NpgsqlPoint(x: 0.812208575633844d, y: 0.5413963351860452d), new NpgsqlTypes.NpgsqlPoint(x: 0.24142592462804535d, y: 0.44436558321145714d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12463665257662826d, y: 0.376347719472632d), new NpgsqlTypes.NpgsqlPoint(x: 0.7707083051999448d, y: 0.2984426450718085d), new NpgsqlTypes.NpgsqlPoint(x: 0.6737278857568004d, y: 0.6485145964972893d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32485544799102906d, y: 0.8862850454895452d), new NpgsqlTypes.NpgsqlPoint(x: 0.26524481373464803d, y: 0.5363437756715163d), new NpgsqlTypes.NpgsqlPoint(x: 0.22600924278315415d, y: 0.27783321636555025d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6784555441869113d, y: 0.9510261802043715d), new NpgsqlTypes.NpgsqlPoint(x: 0.9264832734060757d, y: 0.5871708661866298d), new NpgsqlTypes.NpgsqlPoint(x: 0.21171721477268746d, y: 0.5854507432001318d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8922770759994445d, y: 0.7861132136383475d), new NpgsqlTypes.NpgsqlPoint(x: 0.9118331710556115d, y: 0.37332416117847755d), new NpgsqlTypes.NpgsqlPoint(x: 0.8405774203524476d, y: 0.11903603908415994d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4859589017806776d, y: 0.15705108932273903d), new NpgsqlTypes.NpgsqlPoint(x: 0.33080109177538874d, y: 0.83459944465703d), new NpgsqlTypes.NpgsqlPoint(x: 0.09440663974380192d, y: 0.16238490880675205d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 156,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37905442048092586d, y: 0.08818102218908053d), new NpgsqlTypes.NpgsqlPoint(x: 0.06100135428831566d, y: 0.2890368074440759d), new NpgsqlTypes.NpgsqlPoint(x: 0.484009571460182d, y: 0.5733496695442376d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8071807915255019d, y: 0.2346242214876515d), new NpgsqlTypes.NpgsqlPoint(x: 0.7498601412274501d, y: 0.5422579151395726d), new NpgsqlTypes.NpgsqlPoint(x: 0.37065690728736533d, y: 0.877424816332932d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30228940268922033d, y: 0.10200354068697015d), new NpgsqlTypes.NpgsqlPoint(x: 0.5940829752536193d, y: 0.36375484775262923d), new NpgsqlTypes.NpgsqlPoint(x: 0.5010164857099151d, y: 0.5075983414439926d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5086386347479022d, y: 0.5924241512467229d), new NpgsqlTypes.NpgsqlPoint(x: 0.5815175052921414d, y: 0.4357431408703044d), new NpgsqlTypes.NpgsqlPoint(x: 0.6683142184400205d, y: 0.007878346016719995d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.086775527923175d, y: 0.015223015591862121d), new NpgsqlTypes.NpgsqlPoint(x: 0.9871588293451415d, y: 0.8624135556868101d), new NpgsqlTypes.NpgsqlPoint(x: 0.6379189980310501d, y: 0.04277658433589848d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24039276924628838d, y: 0.6339664400712536d), new NpgsqlTypes.NpgsqlPoint(x: 0.5150941235006851d, y: 0.03338084494556559d), new NpgsqlTypes.NpgsqlPoint(x: 0.8897374952260239d, y: 0.8356261487653434d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3832694176353052d, y: 0.2941594460357214d), new NpgsqlTypes.NpgsqlPoint(x: 0.004620801816285769d, y: 0.4664645109205122d), new NpgsqlTypes.NpgsqlPoint(x: 0.15482581234697357d, y: 0.20335389311114438d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7875829111360515d, y: 0.47196263385786685d), new NpgsqlTypes.NpgsqlPoint(x: 0.18694442286148105d, y: 0.5509715280853907d), new NpgsqlTypes.NpgsqlPoint(x: 0.23616559991454988d, y: 0.35536087343150424d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9861471785986697d, y: 0.6595882634196115d), new NpgsqlTypes.NpgsqlPoint(x: 0.4680287683852816d, y: 0.5199847589462641d), new NpgsqlTypes.NpgsqlPoint(x: 0.5729427838790023d, y: 0.4250402039428668d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38361322934092945d, y: 0.8932647405837467d), new NpgsqlTypes.NpgsqlPoint(x: 0.2935810887475271d, y: 0.3867566318130028d), new NpgsqlTypes.NpgsqlPoint(x: 0.5025631405528367d, y: 0.7557990655654856d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22952499255480652d, y: 0.9901395647999082d), new NpgsqlTypes.NpgsqlPoint(x: 0.5333734809283003d, y: 0.072563184278985d), new NpgsqlTypes.NpgsqlPoint(x: 0.4661328782987013d, y: 0.4407783356843826d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 157,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6804430205964213d, y: 0.5019338768035995d), new NpgsqlTypes.NpgsqlPoint(x: 0.22806980036840785d, y: 0.926560333399097d), new NpgsqlTypes.NpgsqlPoint(x: 0.38657773496305803d, y: 0.25093959386908415d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2513095692881485d, y: 0.8016023070156031d), new NpgsqlTypes.NpgsqlPoint(x: 0.3557433873732597d, y: 0.1546251209156645d), new NpgsqlTypes.NpgsqlPoint(x: 0.2325554051754437d, y: 0.28070565697284877d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1490131016515165d, y: 0.4746248219692041d), new NpgsqlTypes.NpgsqlPoint(x: 0.19892258090235337d, y: 0.747674229373771d), new NpgsqlTypes.NpgsqlPoint(x: 0.9353571818478403d, y: 0.6403916977401793d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.530278806745645d, y: 0.9238816876318763d), new NpgsqlTypes.NpgsqlPoint(x: 0.13872079536889947d, y: 0.11069196978738549d), new NpgsqlTypes.NpgsqlPoint(x: 0.0940561666546732d, y: 0.5869530040088717d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 163,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8045878994511149d, y: 0.9785439606319667d), new NpgsqlTypes.NpgsqlPoint(x: 0.2245965267423533d, y: 0.2836466709644373d), new NpgsqlTypes.NpgsqlPoint(x: 0.15363141530315516d, y: 0.5095221095744034d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8193802686563071d, y: 0.9953191412332808d), new NpgsqlTypes.NpgsqlPoint(x: 0.4625510796997573d, y: 0.9169062482458901d), new NpgsqlTypes.NpgsqlPoint(x: 0.6879989685995123d, y: 0.2544700333897514d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18580355351549172d, y: 0.3328652687179148d), new NpgsqlTypes.NpgsqlPoint(x: 0.3244556784114607d, y: 0.07058351281111142d), new NpgsqlTypes.NpgsqlPoint(x: 0.4656932922306176d, y: 0.5408563537944152d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09600975227808994d, y: 0.46257591700956846d), new NpgsqlTypes.NpgsqlPoint(x: 0.9694775108520537d, y: 0.9237741582176003d), new NpgsqlTypes.NpgsqlPoint(x: 0.3180794353723868d, y: 0.4719896706542094d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3944301279705825d, y: 0.0904939060810156d), new NpgsqlTypes.NpgsqlPoint(x: 0.9828404193788848d, y: 0.5543272432040326d), new NpgsqlTypes.NpgsqlPoint(x: 0.8432709377543397d, y: 0.5609697689544606d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.012174293965426575d, y: 0.13678633632245008d), new NpgsqlTypes.NpgsqlPoint(x: 0.0467931885131746d, y: 0.5702507795680711d), new NpgsqlTypes.NpgsqlPoint(x: 0.30174068953367195d, y: 0.7952484901674586d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5356880507971602d, y: 0.49977216037516237d), new NpgsqlTypes.NpgsqlPoint(x: 0.6102570987543008d, y: 0.6877382548890156d), new NpgsqlTypes.NpgsqlPoint(x: 0.8608244442580563d, y: 0.9935501462353865d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.604988612763187d, y: 0.2531168734989496d), new NpgsqlTypes.NpgsqlPoint(x: 0.8456995136669794d, y: 0.7516253146940058d), new NpgsqlTypes.NpgsqlPoint(x: 0.028929736552777308d, y: 0.36821704999925864d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5535373696728898d, y: 0.6143451455841993d), new NpgsqlTypes.NpgsqlPoint(x: 0.9845197532298224d, y: 0.09496125072757333d), new NpgsqlTypes.NpgsqlPoint(x: 0.7021070454159128d, y: 0.1988559510653638d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.004950951384520952d, y: 0.643852717963414d), new NpgsqlTypes.NpgsqlPoint(x: 0.11697015294391722d, y: 0.5528333430247968d), new NpgsqlTypes.NpgsqlPoint(x: 0.37590659504491253d, y: 0.18826937112483844d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11388048628077307d, y: 0.5850516915526357d), new NpgsqlTypes.NpgsqlPoint(x: 0.3192633216202534d, y: 0.9853241808343518d), new NpgsqlTypes.NpgsqlPoint(x: 0.3401017150201133d, y: 0.5192757989267849d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31692405722939776d, y: 0.4808970445022819d), new NpgsqlTypes.NpgsqlPoint(x: 0.8275460091697482d, y: 0.8958567044346198d), new NpgsqlTypes.NpgsqlPoint(x: 0.7253960900033547d, y: 0.7481957642676006d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5637521146991533d, y: 0.13056526263647938d), new NpgsqlTypes.NpgsqlPoint(x: 0.647099011522434d, y: 0.6521265262775884d), new NpgsqlTypes.NpgsqlPoint(x: 0.5235727601357671d, y: 0.6016665355922053d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9489134578653575d, y: 0.4000889602478198d), new NpgsqlTypes.NpgsqlPoint(x: 0.29283215390674233d, y: 0.15959568961704462d), new NpgsqlTypes.NpgsqlPoint(x: 0.19259584037199373d, y: 0.22491908099353475d)),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48523430978227167d, y: 0.5547619395111004d), new NpgsqlTypes.NpgsqlPoint(x: 0.8539320691147951d, y: 0.7966268306985819d), new NpgsqlTypes.NpgsqlPoint(x: 0.40140186239302944d, y: 0.4029147073246364d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9616188807256193d, y: 0.7809494476796237d), new NpgsqlTypes.NpgsqlPoint(x: 0.10773603573339863d, y: 0.1439686587363984d), new NpgsqlTypes.NpgsqlPoint(x: 0.8722933474529037d, y: 0.2706814828529551d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8148245476355809d, y: 0.3826697683127117d), new NpgsqlTypes.NpgsqlPoint(x: 0.1806295430373306d, y: 0.8493114430162909d), new NpgsqlTypes.NpgsqlPoint(x: 0.1347566539191407d, y: 0.38598690917173306d)),
}));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49432482689884694d, y: 0.23297300083371675d), new NpgsqlTypes.NpgsqlPoint(x: 0.32689543438621416d, y: 0.03411829503112873d), new NpgsqlTypes.NpgsqlPoint(x: 0.9579271750538668d, y: 0.7433559978230443d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6880035464084228d, y: 0.7532730138734617d), new NpgsqlTypes.NpgsqlPoint(x: 0.38440005120682574d, y: 0.8506634003528282d), new NpgsqlTypes.NpgsqlPoint(x: 0.3220953561926323d, y: 0.04223248594360307d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28862653621847645d, y: 0.11879918651405408d), new NpgsqlTypes.NpgsqlPoint(x: 0.13753900258007468d, y: 0.4948774937729393d), new NpgsqlTypes.NpgsqlPoint(x: 0.846820890926571d, y: 0.04061979749639555d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5304851540033111d, y: 0.5336843518503352d), new NpgsqlTypes.NpgsqlPoint(x: 0.34128178464655334d, y: 0.6399285682438886d), new NpgsqlTypes.NpgsqlPoint(x: 0.014913006919098803d, y: 0.8595788877559488d)),
}));
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
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1453561320202038d, y: 0.8067997239808582d), new NpgsqlTypes.NpgsqlPoint(x: 0.8026725342708572d, y: 0.32633622048835853d), new NpgsqlTypes.NpgsqlPoint(x: 0.7259131982121612d, y: 0.9361366668494571d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7667640361847218d, y: 0.6938780070238308d), new NpgsqlTypes.NpgsqlPoint(x: 0.43432717243775276d, y: 0.2522286336130839d), new NpgsqlTypes.NpgsqlPoint(x: 0.9591411419489304d, y: 0.38788332609823784d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40488322924545694d, y: 0.8284619591487967d), new NpgsqlTypes.NpgsqlPoint(x: 0.4608344188463438d, y: 0.9060919765739004d), new NpgsqlTypes.NpgsqlPoint(x: 0.6785732653217996d, y: 0.7760133470323467d)),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8097851051288201d, y: 0.7730731954446536d), new NpgsqlTypes.NpgsqlPoint(x: 0.13838796961134525d, y: 0.9619462575736101d), new NpgsqlTypes.NpgsqlPoint(x: 0.8175059467495993d, y: 0.47392388927604867d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08406757529693065d, y: 0.7446698456113048d), new NpgsqlTypes.NpgsqlPoint(x: 0.35856264240155256d, y: 0.48247163797210935d), new NpgsqlTypes.NpgsqlPoint(x: 0.5864877549172631d, y: 0.9462453067050813d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04543585649369575d, y: 0.5814181346369369d), new NpgsqlTypes.NpgsqlPoint(x: 0.060845088898349164d, y: 0.7770404747326752d), new NpgsqlTypes.NpgsqlPoint(x: 0.52053388586306d, y: 0.30039287733111286d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8994717009842551d, y: 0.9982846082866892d), new NpgsqlTypes.NpgsqlPoint(x: 0.2841384932878661d, y: 0.4674660968129537d), new NpgsqlTypes.NpgsqlPoint(x: 0.5837076140520051d, y: 0.6159094389957217d)),
}));
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
                Assert.That(nullable, Is.Null);
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

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[22],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 156;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 86;
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
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[29], false);
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

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 132;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                 ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[23],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 36;
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
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                 ((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[24],_testData[29], false);
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
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
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
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
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
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
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
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[29], false);
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
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
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
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[4],_testData[29], false);
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
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
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
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[29], false);
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
                parametr1.Value = 126;
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                 ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[29], false);
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
            batchName: "DbConnectionSTSelectModelDynParBatch",
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
                var models = await((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[15], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[16], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[17], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[18], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[19], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[20], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[21], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[22], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[23], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[24], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[25], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[26], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[27], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[7], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[8], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[9], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[10], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[11], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[12], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[13], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[14], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[15], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[16], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[17], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[18], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[19], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[20], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[21], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[22], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[23], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[24], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[25], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[26], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[27], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[29], false);
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
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[29], false);
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

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 132, query1, 41, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[22],_testData[29], false);
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
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 53, query1, 36, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[23],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                 ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 65, query1, 128, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[6],_testData[29], false);
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
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                 ((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 156, query1, 20, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[25],_testData[29], false);
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
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
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
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
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
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 36, query1, 140, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 148, query1, 12, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[26],_testData[29], false);
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
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 91, query1, 11, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[27],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                 ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelBatch(connection, 65, query1, 8, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[28],_testData[29], false);
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
            batchName: "DbConnectionSTSelectModelBatch",
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
        private void DbConnectionSTSelectModelBatchConfig()
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
        public async Task DbConnectionSTSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTSelectModelBatchAsync(connection, 104, 74))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[19], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[20], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[21], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[22], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[23], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[24], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[25], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[26], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[27], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[29], false);
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
        public async Task DbConnectionSTSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTSelectModelBatch(connection, 12, 86))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[3], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[4], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[5], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[6], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[7], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[8], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[9], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[10], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[11], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[12], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[13], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[14], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[15], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[16], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[17], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[18], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[19], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[20], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[21], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[22], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[23], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[24], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[25], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[26], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[27], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[25],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[29], false);
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
                ((INpgsqlPolygonArraypolygonArray)this).SetDbConnectionSelectModelParametrs(cmd, 140);
                var models = await ((INpgsqlPolygonArraypolygonArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonArraypolygonArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonArraypolygonArray)this).SetDbConnectionSelectModelParametrs(cmd, 28);
                var models =  ((INpgsqlPolygonArraypolygonArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(25));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[5], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[6], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[7], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[8], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[9], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[10], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[11], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[12], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[13], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[14], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[15], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[16], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[17], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[18], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[19], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[20], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[21], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[22], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[23], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[29], false);
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
FROM public.binary_npgsqlpolygonpolygonarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonArray1MIWA),
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonArraypolygonArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonArraypolygonArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPolygonpolygonArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonArraypolygonArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonArraypolygonArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MIWA.AssertModel(actual, expect, false);
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
            queryMapType: typeof(NpgsqlPolygonpolygonArray1MI),
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

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonArray1MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonArraypolygonArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonArraypolygonArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPolygonpolygonArray1MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonArraypolygonArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonArraypolygonArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            queryMapType: typeof(NpgsqlPolygonpolygonArray1M),
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

        [Test, Order(5)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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

