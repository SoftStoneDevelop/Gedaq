

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
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7202477867219754d, y: 0.8644018965012721d), radius: 0.06210513890270941d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05080089870651905d, y: 0.8925553094565528d), radius: 0.7789991906216358d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8474837784436131d, y: 0.7310276341999818d), radius: 0.6372134540281938d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.004608549071311918d, y: 0.013494108097291457d), radius: 0.06832993773927343d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03295263334365339d, y: 0.9831800337509483d), radius: 0.9807419504573648d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8765258663119946d, y: 0.8300403288945363d), radius: 0.7368573354789074d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7145120618261129d, y: 0.5639633811663687d), radius: 0.7463185430298004d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8614302658178046d, y: 0.6629339921678602d), radius: 0.3592166151852796d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6937999728207538d, y: 0.24776544676419432d), radius: 0.37152226183503645d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7353335511144276d, y: 0.14779705911213414d), radius: 0.5230897269206761d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9723518278248388d, y: 0.06701866497236753d), radius: 0.4575899677075669d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41228486915222373d, y: 0.8650369891124483d), radius: 0.7123027178594802d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5183191554224322d, y: 0.6386228630464705d), radius: 0.6027042209082352d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7075774371579693d, y: 0.400903561694669d), radius: 0.19133832619970426d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41046456198233827d, y: 0.733957140596076d), radius: 0.04370284809948122d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2948565877894246d, y: 0.893212889831223d), radius: 0.8321254223523377d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5142794841475711d, y: 0.1572852365659385d), radius: 0.4232056963009617d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5431489205130681d, y: 0.5374231951767499d), radius: 0.033460103490995485d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16559217444002283d, y: 0.29694725242141917d), radius: 0.9269204602770856d),

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
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9349377752530104d, y: 0.04994354284509339d), radius: 0.03246481333973639d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7672893593257203d, y: 0.39099930389189774d), radius: 0.6752205304570299d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37566762975788226d, y: 0.3412285031738963d), radius: 0.022245982121078867d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8481370431273592d, y: 0.5721780073971857d), radius: 0.7285721802616152d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9664196467566603d, y: 0.47668136517312687d), radius: 0.23957944860347358d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6565139511461341d, y: 0.34824949506518654d), radius: 0.5917914979092882d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1311984802064733d, y: 0.15245592056472512d), radius: 0.3166770062394446d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6889491607233839d, y: 0.08802558110396941d), radius: 0.7641023558979163d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21505994027735875d, y: 0.5242708349745806d), radius: 0.5868145813246523d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4873978442149022d, y: 0.7378585559790127d), radius: 0.27269152387772755d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9861819352155342d, y: 0.8896950818866974d), radius: 0.5887157966605113d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.648984182460407d, y: 0.5215150014824166d), radius: 0.9171945645873274d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6898213526520564d, y: 0.7296378373164879d), radius: 0.6345200269709862d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6780358544123762d, y: 0.10054161555710595d), radius: 0.40581498444997466d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0719862925097906d, y: 0.006182195868901341d), radius: 0.5735831205246915d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14168066429399195d, y: 0.1530664694955407d), radius: 0.15439501079571116d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4491830376769843d, y: 0.999569754970118d), radius: 0.47218315483275763d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.416355054833365d, y: 0.9498119948544783d), radius: 0.7842714623228333d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36969536522754065d, y: 0.7353216136810922d), radius: 0.34281219400770824d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5254720690471455d, y: 0.2712020031994563d), radius: 0.7299646106761407d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33027583133753047d, y: 0.3625758226899737d), radius: 0.8210015759291441d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9743860866664003d, y: 0.7832796015934123d), radius: 0.32010400072575174d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.038391334321003834d, y: 0.5336849899458442d), radius: 0.07289479679281363d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21865677000240458d, y: 0.986927672003817d), radius: 0.6885200785686839d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.437506810265765d, y: 0.6745062250402769d), radius: 0.6700084449779496d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20232020816384666d, y: 0.16287503711306928d), radius: 0.9581032606245526d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24303138509960864d, y: 0.49635465713998406d), radius: 0.04362496191770249d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45704464770707265d, y: 0.6623446729583177d), radius: 0.06019762282921326d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9359987272739625d, y: 0.08309718886957729d), radius: 0.7823212313006468d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44411965420679644d, y: 0.7269474620010212d), radius: 0.38631107707857026d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.023536453212727904d, y: 0.8540943695976565d), radius: 0.5469165582894966d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3106795227605669d, y: 0.43977258209061276d), radius: 0.4265777452944276d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5661603989316516d, y: 0.9567318445517484d), radius: 0.5565192383426326d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06363389550879028d, y: 0.9665377486929004d), radius: 0.13195138079811985d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4204523136836329d, y: 0.13482248927374918d), radius: 0.8394471906289792d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7117569080786172d, y: 0.3713480667674114d), radius: 0.5615550833727073d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8579343598060604d, y: 0.42598273199340775d), radius: 0.837700505650625d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13830902472169826d, y: 0.4422592102245063d), radius: 0.04489174421095543d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.01604844679218176d, y: 0.0528465027897691d), radius: 0.6523225579965802d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7842992532998103d, y: 0.6595754689334584d), radius: 0.8145243126474928d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7412592158940886d, y: 0.12068268815221495d), radius: 0.6842199417391593d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03939683640798197d, y: 0.09020243340846756d), radius: 0.4164450130436268d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8598397533428225d, y: 0.28042956056252955d), radius: 0.732784235269342d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9196671608199842d, y: 0.6170755278643975d), radius: 0.2420987839091212d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8952527001542279d, y: 0.5727901042722524d), radius: 0.5258295931486314d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8390867138460995d, y: 0.8999213188510455d), radius: 0.1175199403796019d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10177801413633136d, y: 0.10173392305620566d), radius: 0.7614916415169447d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1492805774707927d, y: 0.6018755647768511d), radius: 0.9821009845011335d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3265110965680865d, y: 0.008399531455180353d), radius: 0.5743623861899121d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1377206183448888d, y: 0.6348274164164135d), radius: 0.31192749630795047d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4538349938176477d, y: 0.5096835035367728d), radius: 0.6663211382367652d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3141996733065061d, y: 0.5290717097770926d), radius: 0.7373403460357033d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2909665309485464d, y: 0.19751375420302353d), radius: 0.11428802732149479d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8331884023091567d, y: 0.7909338776579771d), radius: 0.9864315919727582d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9604156562754271d, y: 0.4256559383577957d), radius: 0.8908215185661842d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09500886935636343d, y: 0.9318099780058515d), radius: 0.49511759044366144d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24673837455594605d, y: 0.1390125395455969d), radius: 0.5044040347980415d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29737870226174556d, y: 0.008534508665487106d), radius: 0.8076564242838545d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3445221975819954d, y: 0.5079924556069008d), radius: 0.9600716847371972d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28017212026565774d, y: 0.6443703179833233d), radius: 0.01805990130446322d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6666767998037154d, y: 0.6897914235778801d), radius: 0.5440936050059466d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6935691355523863d, y: 0.5009393712483731d), radius: 0.17545816391091773d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02427086362327935d, y: 0.23451728457201737d), radius: 0.994728370673684d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15691702561426668d, y: 0.23954860711261983d), radius: 0.2930090569173396d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4881441513896113d, y: 0.2277126249402207d), radius: 0.8287357202907225d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9839840414850134d, y: 0.015533052889413312d), radius: 0.584820422326271d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8888717354458748d, y: 0.7006814669055782d), radius: 0.9101293666396081d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8712777596185499d, y: 0.1367000215117058d), radius: 0.23460521435994863d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7867845736551925d, y: 0.4026316303657653d), radius: 0.11453044832883474d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5667831598595552d, y: 0.12742046603558765d), radius: 0.6566235550953399d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7253095942591542d, y: 0.4684777122585181d), radius: 0.09388838420049272d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8928264648201618d, y: 0.4535010730925817d), radius: 0.8895122888833258d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.840831313304618d, y: 0.595114240318112d), radius: 0.4207955171619304d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0351269052017934d, y: 0.5861005466914148d), radius: 0.6382278690501381d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8900024034767386d, y: 0.9840537179361065d), radius: 0.9262758652444377d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20866255828313385d, y: 0.6324829617394802d), radius: 0.22581342568237373d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39183149462759215d, y: 0.6319239705484593d), radius: 0.7547712024827492d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.006983245832314244d, y: 0.8505354311745598d), radius: 0.2275398074910986d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5019583515640803d, y: 0.9386530596120244d), radius: 0.732916467286639d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.679630416514567d, y: 0.2857968760316222d), radius: 0.47931616883959505d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08172062871000108d, y: 0.8806423888662653d), radius: 0.604479355819489d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5551636136093022d, y: 0.46279721461892387d), radius: 0.6617489615341723d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5949096112534741d, y: 0.02918866738703718d), radius: 0.40899087407350243d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6330260583065215d, y: 0.8199380504366406d), radius: 0.5926813234776382d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.700051161884683d, y: 0.3958122375466384d), radius: 0.42869786299560086d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3272643129535573d, y: 0.3949039940919168d), radius: 0.3921390737122784d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39429319270790175d, y: 0.19666070194555485d), radius: 0.3906019719752103d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1462594905017457d, y: 0.102984011606858d), radius: 0.8174895923095565d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.004138694435898205d, y: 0.9376006441972877d), radius: 0.6650124761588716d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9780005268401041d, y: 0.01574709560809584d), radius: 0.9656181284958859d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15537118607550426d, y: 0.5640098734305037d), radius: 0.5186100175906749d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5664918411019695d, y: 0.2316724391917182d), radius: 0.31009534198703403d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5115115002948228d, y: 0.08472009762890231d), radius: 0.0673823469436251d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40754731473666606d, y: 0.41304592129705187d), radius: 0.4188542782779541d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8283257565790979d, y: 0.2536622831557026d), radius: 0.9170488740308546d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25407587649453167d, y: 0.37190495626167663d), radius: 0.30985761323040517d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5216521361292893d, y: 0.060070478133914085d), radius: 0.8747203629641398d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0227563201946841d, y: 0.8442865742685346d), radius: 0.019118527122677587d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9477346205507314d, y: 0.8108966365019417d), radius: 0.4832254426872332d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5343385480327026d, y: 0.42403673773304307d), radius: 0.6839315870192263d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2639753053385895d, y: 0.05832961213357701d), radius: 0.48730736146891385d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7694694847019738d, y: 0.4090598711505482d), radius: 0.9212984418429928d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7985020767828633d, y: 0.46572167974103473d), radius: 0.5130097148517547d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6586814037827255d, y: 0.9892676640187565d), radius: 0.5788120275891778d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34740043393002806d, y: 0.37378288223928713d), radius: 0.2620965378625777d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09371056578766401d, y: 0.9361275278371475d), radius: 0.26505711695677203d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3098297611481774d, y: 0.35382507312430655d), radius: 0.2957770050360006d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8690061650757619d, y: 0.7111629365669636d), radius: 0.6777172430331939d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9891866838238237d, y: 0.5304537869204263d), radius: 0.26525017214712376d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2095191237553503d, y: 0.7209585457135907d), radius: 0.2052865715593104d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4118883356193852d, y: 0.8490200712123556d), radius: 0.08524597733539074d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9174118517335043d, y: 0.06028362819755373d), radius: 0.9737662006024258d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8216677294554521d, y: 0.5316461855467594d), radius: 0.7864144497225553d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5457097891207724d, y: 0.08312897577635481d), radius: 0.20550488864740857d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1304558353209022d, y: 0.23901423272977584d), radius: 0.9409468143121784d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8213599012953894d, y: 0.49126598677986366d), radius: 0.5254853746148578d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8960171207119529d, y: 0.08475858825694416d), radius: 0.8423364998100998d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4945136210682676d, y: 0.8707874702268998d), radius: 0.4329497318059602d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41552832012217067d, y: 0.2534281282175045d), radius: 0.8002438087181549d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.01722819169774148d, y: 0.6638169889174739d), radius: 0.5924313813996851d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.590242429726951d, y: 0.5355756889758753d), radius: 0.4807716675534992d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7879211624418515d, y: 0.3801560920475443d), radius: 0.42128345964910285d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5371959284806868d, y: 0.52014316950072d), radius: 0.2187373405865416d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8389520085349155d, y: 0.27879573200344154d), radius: 0.720246932148158d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.022181897946399687d, y: 0.468500550723117d), radius: 0.61605655009518d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11590041421241948d, y: 0.18646430922605373d), radius: 0.2960571673876973d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4451573660253054d, y: 0.35850921909900635d), radius: 0.5437595693030797d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6277050668092548d, y: 0.9324492363027646d), radius: 0.4838707690066397d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7177380269366511d, y: 0.31629107080365415d), radius: 0.5169582745857165d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21702464816702904d, y: 0.7142157156249406d), radius: 0.06518023427027031d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7432870167029969d, y: 0.3205961122272093d), radius: 0.12466348613271783d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8279383573063933d, y: 0.9779628245988502d), radius: 0.13149144766152976d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4119745552387084d, y: 0.6156573945452649d), radius: 0.4288034066473897d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5890275310481596d, y: 0.4135618189528121d), radius: 0.11310954152304586d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.989357667370635d, y: 0.6459449966431101d), radius: 0.38551833214986997d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23278551893738153d, y: 0.5817542458532472d), radius: 0.13348005408569463d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5110030933955723d, y: 0.33745789542258886d), radius: 0.05731994834280574d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9223152548195274d, y: 0.652939671681127d), radius: 0.04170760629204506d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3640670595100871d, y: 0.26351132152594336d), radius: 0.1397873963400451d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7556414829686487d, y: 0.10113665790176818d), radius: 0.6070147083678972d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7601565794087829d, y: 0.09151580416417293d), radius: 0.3558403606612356d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12913120511543752d, y: 0.39834413250427725d), radius: 0.49664946768027973d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9630916708306579d, y: 0.09544240611409749d), radius: 0.9544007894722354d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12034354109146683d, y: 0.7191584532630114d), radius: 0.7850455130106284d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8851215563653728d, y: 0.5554593110380273d), radius: 0.9368091030727634d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5243792476689308d, y: 0.5687080386776725d), radius: 0.5048726763597653d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14780870934354695d, y: 0.2311264687485548d), radius: 0.4029538176769287d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1648092733068831d, y: 0.05967044763680551d), radius: 0.24761142010099657d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8046357504961184d, y: 0.43288538780849206d), radius: 0.6175614932861858d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8212748648224152d, y: 0.20149277121312525d), radius: 0.012686883303556717d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.355717074929482d, y: 0.3888191486976881d), radius: 0.4863172477461214d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.482254713055537d, y: 0.5604714913155535d), radius: 0.3119347728554972d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7505683676509226d, y: 0.33530398968592534d), radius: 0.3529364056798202d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4627584334952958d, y: 0.9697276226067708d), radius: 0.055886091076354893d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.01237538603563737d, y: 0.4636638033786652d), radius: 0.09847747119347183d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5438014822912327d, y: 0.11110745376009457d), radius: 0.8839622711162434d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5438140508379932d, y: 0.2531872200062769d), radius: 0.9110360265421839d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5309332250296415d, y: 0.33143708934699667d), radius: 0.346481887938076d),

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
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.020406672213283406d, y: 0.5790975080008235d), radius: 0.22673355982103194d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09105785583334192d, y: 0.9660364339027261d), radius: 0.7930714917721723d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2411001195329655d, y: 0.47919873169986194d), radius: 0.7189569012621321d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40091210169693736d, y: 0.4352968656834034d), radius: 0.8029067689843562d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8198567995956157d, y: 0.7542139059786123d), radius: 0.04255795972798504d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9437600936664029d, y: 0.5230164971757078d), radius: 0.8340775451199683d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46549190030732046d, y: 0.3997047546674689d), radius: 0.4704768072073213d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09938107894919002d, y: 0.9526660079343904d), radius: 0.18290303289040177d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17943872046438403d, y: 0.3635244765347414d), radius: 0.974589464958185d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8515845975165033d, y: 0.4030916646650181d), radius: 0.266376907824876d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2915144363537703d, y: 0.4880607378799303d), radius: 0.5481391105980922d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.282039933625167d, y: 0.2448685199065348d), radius: 0.321318107855163d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0398807184845803d, y: 0.46103557614435764d), radius: 0.7423570660316068d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7812733816372138d, y: 0.2484997919822246d), radius: 0.666091513702007d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.012152635022761205d, y: 0.8771984812634905d), radius: 0.9117721669312251d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 150,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6709551778765315d, y: 0.7628684682252084d), radius: 0.09238044386114919d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4614426871979884d, y: 0.11158188430636917d), radius: 0.5354065691125911d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.015456672800212679d, y: 0.8347713310762206d), radius: 0.16357818744930075d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5375012929923371d, y: 0.9487272181608409d), radius: 0.9207422853286065d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3894872065038858d, y: 0.9985283881801337d), radius: 0.4122018202698793d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6031064501667355d, y: 0.2283381087337888d), radius: 0.6183995006765904d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7868345178141566d, y: 0.7154946906059526d), radius: 0.4357400105647623d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6749910764704509d, y: 0.9262436253273718d), radius: 0.699611306267964d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7462577232497161d, y: 0.26673668432819064d), radius: 0.612209021699178d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6277618741140419d, y: 0.23146486400384259d), radius: 0.8432349708844449d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4985080299103136d, y: 0.9150569830465873d), radius: 0.7489247476141984d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3977561179580994d, y: 0.6514690063679928d), radius: 0.2730253096750809d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0252531903457488d, y: 0.9644773354768313d), radius: 0.5075085396749229d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48127338205001247d, y: 0.9953150098063736d), radius: 0.1521979577892968d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 165,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19063496561757276d, y: 0.9240358000636668d), radius: 0.8779224447607193d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7006767900570376d, y: 0.784136538470901d), radius: 0.886557726216082d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6225965293763777d, y: 0.5927548398628407d), radius: 0.21943603898406028d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5018803425831114d, y: 0.6711021990669783d), radius: 0.6181716952922844d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08302161877405911d, y: 0.03810605142951318d), radius: 0.41982016316548776d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37699907961228263d, y: 0.9859027230424989d), radius: 0.2879182391248958d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16984646407586945d, y: 0.9694606035683275d), radius: 0.49803169881013776d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 173,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49391118906418796d, y: 0.7293606194311293d), radius: 0.2875851736476439d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17211995493560261d, y: 0.8928125324450328d), radius: 0.6094338579057477d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4576999825222108d, y: 0.4238077211278519d), radius: 0.9090652951756114d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 174,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6431917551739935d, y: 0.4842450651238934d), radius: 0.9486556670886939d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3431129967284049d, y: 0.09761851259620802d), radius: 0.24283731397618202d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19939393819156237d, y: 0.27644975323845344d), radius: 0.6118973824647461d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09879664317707049d, y: 0.416664988137035d), radius: 0.03148150499421287d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11411545058908312d, y: 0.06745623574083948d), radius: 0.049339135580748095d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.012353296591781193d, y: 0.9978211302982495d), radius: 0.697179419666823d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 177,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9615853285114789d, y: 0.7379508770202126d), radius: 0.9356343730546954d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.057962816324367616d, y: 0.09017920583437256d), radius: 0.24885022355122766d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3790046365998435d, y: 0.10371636089662861d), radius: 0.8568583912443536d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6771633679788904d, y: 0.23064334855532864d), radius: 0.09380999256777467d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5365455356883875d, y: 0.07557687540959579d), radius: 0.4075788713542181d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6771268702806537d, y: 0.2333609978454303d), radius: 0.11576383844177873d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 181,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41206071767408536d, y: 0.3654179839039713d), radius: 0.11129213574366781d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11322486531449394d, y: 0.9986460643006693d), radius: 0.4958706194616346d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2621288215632407d, y: 0.044735155186306d), radius: 0.5646197175530654d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12212209982910305d, y: 0.8746791922523817d), radius: 0.5796800975220052d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40576888295358715d, y: 0.5824245088035787d), radius: 0.6636025956421878d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7355321243739396d, y: 0.5294679857688392d), radius: 0.7876646588548964d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8016598551762424d, y: 0.7165919516753626d), radius: 0.08087355364940418d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 185,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6901188544230036d, y: 0.7927792178189643d), radius: 0.3933975394948498d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3165867902118953d, y: 0.43932903230719955d), radius: 0.8642507970723762d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8591252748206427d, y: 0.7407603140273404d), radius: 0.008646077107916317d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46495328762859855d, y: 0.5536399440618157d), radius: 0.27231265587845666d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17417148061588117d, y: 0.6082279092852524d), radius: 0.892508662635265d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2487571785211956d, y: 0.8617785339769346d), radius: 0.9917739723837371d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.717855061458098d, y: 0.6733544034963534d), radius: 0.1871587456549425d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 193,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6245152846950224d, y: 0.5705855103175419d), radius: 0.7211064953911838d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12047898857743466d, y: 0.967989811607476d), radius: 0.9230920332899193d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0030653569245576717d, y: 0.6716394875438588d), radius: 0.5294780053382557d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20177836601659915d, y: 0.5193884681248202d), radius: 0.2896309649574672d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8593099612110674d, y: 0.4113661252221087d), radius: 0.17104305530822406d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5274659492103985d, y: 0.3309138443059464d), radius: 0.22022642177114737d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42609671712554664d, y: 0.8409579805229763d), radius: 0.04565902970577329d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5195014213643737d, y: 0.506147826228294d), radius: 0.2915440643175149d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31980333171933917d, y: 0.6530393925927105d), radius: 0.8194482475472037d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8092127219736686d, y: 0.8375611853630559d), radius: 0.08815436488935191d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2610886584855042d, y: 0.9035274658067635d), radius: 0.759117021675842d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8217825833533791d, y: 0.2943087742310052d), radius: 0.37033718098797297d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 197,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.337676707395693d, y: 0.048160945527308874d), radius: 0.01369518417299942d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5040539452335928d, y: 0.359555494647974d), radius: 0.3500772001645437d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5031454149707164d, y: 0.5335656574050258d), radius: 0.3544044692675361d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3336444640695969d, y: 0.4326360018274277d), radius: 0.3135796968978163d),

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
                parametr1.Value = 136;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 76;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 119;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 185;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[34], false);
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
                parametr1.Value = 185;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[34], false);
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
                parametr1.Value = 181;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 36;
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
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[28],_testData[34], false);
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
                parametr1.Value = 112;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[34], false);
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
                parametr1.Value = 59;
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
                parametr1.Value = 174;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[34], false);
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
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 159;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 21;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[3], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[4], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[5], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[6], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[7], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[8], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[9], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[10], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[11], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[12], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[13], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[14], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[27],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[28],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[29],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[30],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[31],_testData[34], false);
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
                await ((INpgsqlCircleListcircleArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 45, query1, 129, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[34], false);
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
                await ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 76, query1, 112, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[34], false);
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
                 ((INpgsqlCircleListcircleArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 185, query1, 129, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[34], false);
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
                 ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 136, query1, 7, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[33],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 181, query1, 54, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[34], false);
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
                await ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 66, query1, 45, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 165, query1, 21, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[31],_testData[34], false);
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
                 ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelBatch(connection, 150, query1, 120, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelBatchAsync(connection, 85, 76))
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
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelBatch(connection, 26, 159))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[4], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[5], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[6], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[7], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[8], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[9], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[10], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[11], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[12], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[13], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[14], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[27],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[28],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[29],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[30],_testData[34], false);
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

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((INpgsqlCircleListcircleArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlCircleListcircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 41);
                var models = await ((INpgsqlCircleListcircleArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

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
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleListcircleArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleListcircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 94);
                var models =  ((INpgsqlCircleListcircleArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(17));

                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[18], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[19], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[20], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[21], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[22], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[23], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[24], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[25], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[26], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[27], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[28], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[29], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[30], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[31], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[32], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[33], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[34], false);
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

