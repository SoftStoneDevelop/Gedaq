

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
    internal partial interface INpgsqlPolygonListpolygonArray
    {
    }
    
    internal partial class NpgsqlPolygonListpolygonArray : INpgsqlPolygonListpolygonArray
    {


#region TestData

        private readonly NpgsqlPolygonpolygonArray2M[] _testData = new NpgsqlPolygonpolygonArray2M[]
        {
            new NpgsqlPolygonpolygonArray2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8893012232779048d, y: 0.6224159625602864d), new NpgsqlTypes.NpgsqlPoint(x: 0.8360926623023462d, y: 0.12654715426548135d), new NpgsqlTypes.NpgsqlPoint(x: 0.5626670444710264d, y: 0.3476219822985598d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8457710930926823d, y: 0.1055156497794616d), new NpgsqlTypes.NpgsqlPoint(x: 0.681100032909339d, y: 0.1860795668561156d), new NpgsqlTypes.NpgsqlPoint(x: 0.7163506488549576d, y: 0.010169433722870491d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03062919042275347d, y: 0.4794682196363945d), new NpgsqlTypes.NpgsqlPoint(x: 0.8825701924858491d, y: 0.8511779753692609d), new NpgsqlTypes.NpgsqlPoint(x: 0.08823048363593655d, y: 0.797840451931384d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32787879167384226d, y: 0.20940858182307276d), new NpgsqlTypes.NpgsqlPoint(x: 0.1979395499961477d, y: 0.13549168869204198d), new NpgsqlTypes.NpgsqlPoint(x: 0.9738344480046965d, y: 0.9489843116084127d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.035957376126396046d, y: 0.3076898599492104d), new NpgsqlTypes.NpgsqlPoint(x: 0.058099164573496065d, y: 0.4937114311616443d), new NpgsqlTypes.NpgsqlPoint(x: 0.9961380278545777d, y: 0.80953258203934d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7745738514455793d, y: 0.8532178658087035d), new NpgsqlTypes.NpgsqlPoint(x: 0.6664734248404781d, y: 0.9661786715622632d), new NpgsqlTypes.NpgsqlPoint(x: 0.5942816340598687d, y: 0.09623324040651537d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6729937038634627d, y: 0.8239934304859181d), new NpgsqlTypes.NpgsqlPoint(x: 0.5805955701926874d, y: 0.9107614700803088d), new NpgsqlTypes.NpgsqlPoint(x: 0.5264976210307313d, y: 0.9208179613272169d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7088523073627471d, y: 0.0021904889487274204d), new NpgsqlTypes.NpgsqlPoint(x: 0.29881275016924713d, y: 0.2865555774298768d), new NpgsqlTypes.NpgsqlPoint(x: 0.4946031764058315d, y: 0.8419653630028325d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3156637511124306d, y: 0.503472677846776d), new NpgsqlTypes.NpgsqlPoint(x: 0.49182217830513963d, y: 0.5762191846677693d), new NpgsqlTypes.NpgsqlPoint(x: 0.4484475339641255d, y: 0.8472475212461203d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8291166960277283d, y: 0.0050292346788685105d), new NpgsqlTypes.NpgsqlPoint(x: 0.7570627734189964d, y: 0.8785078854960421d), new NpgsqlTypes.NpgsqlPoint(x: 0.808879610960358d, y: 0.4486943135118395d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9243137405563493d, y: 0.7562445240857275d), new NpgsqlTypes.NpgsqlPoint(x: 0.7915545422264313d, y: 0.9153085807214035d), new NpgsqlTypes.NpgsqlPoint(x: 0.39081496762470347d, y: 0.4282491139637974d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9525736433728362d, y: 0.981921284821784d), new NpgsqlTypes.NpgsqlPoint(x: 0.5581584403512392d, y: 0.5402956130081836d), new NpgsqlTypes.NpgsqlPoint(x: 0.31430359900297244d, y: 0.48940795289872474d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15103175587625228d, y: 0.02223484128297093d), new NpgsqlTypes.NpgsqlPoint(x: 0.40240706869194376d, y: 0.8202466204655587d), new NpgsqlTypes.NpgsqlPoint(x: 0.3148889008302663d, y: 0.1224074030249851d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.615402646832074d, y: 0.3311525639628281d), new NpgsqlTypes.NpgsqlPoint(x: 0.2506603573393964d, y: 0.8703052223566268d), new NpgsqlTypes.NpgsqlPoint(x: 0.3485001220422914d, y: 0.9504961550890603d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2478754304951304d, y: 0.13600771323764038d), new NpgsqlTypes.NpgsqlPoint(x: 0.7340273182053232d, y: 0.4129093289927548d), new NpgsqlTypes.NpgsqlPoint(x: 0.2928754860049543d, y: 0.6207895719085491d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7596942435211332d, y: 0.22891743691775557d), new NpgsqlTypes.NpgsqlPoint(x: 0.1936148414083546d, y: 0.8628950840318425d), new NpgsqlTypes.NpgsqlPoint(x: 0.35006374603501555d, y: 0.3636662329566932d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7316080343405703d, y: 0.729933686732999d), new NpgsqlTypes.NpgsqlPoint(x: 0.6953396427540123d, y: 0.46505348727994533d), new NpgsqlTypes.NpgsqlPoint(x: 0.7025893341174761d, y: 0.9265618321296807d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3932841382769313d, y: 0.8257022422312156d), new NpgsqlTypes.NpgsqlPoint(x: 0.4407366582798323d, y: 0.012233993275268418d), new NpgsqlTypes.NpgsqlPoint(x: 0.542872054851219d, y: 0.23687419926118336d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.659316216897737d, y: 0.40566546419037464d), new NpgsqlTypes.NpgsqlPoint(x: 0.6959214492425304d, y: 0.47563390490654256d), new NpgsqlTypes.NpgsqlPoint(x: 0.6133541964591094d, y: 0.21678483604298338d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6190378296125112d, y: 0.20458433183196134d), new NpgsqlTypes.NpgsqlPoint(x: 0.9969263007495902d, y: 0.4468098179351382d), new NpgsqlTypes.NpgsqlPoint(x: 0.3285314134490127d, y: 0.15072389898240346d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2675850715436048d, y: 0.4929686517076981d), new NpgsqlTypes.NpgsqlPoint(x: 0.7069305895485034d, y: 0.4399030864599063d), new NpgsqlTypes.NpgsqlPoint(x: 0.449009925691759d, y: 0.36921771343520204d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6366301836241739d, y: 0.7458907775467708d), new NpgsqlTypes.NpgsqlPoint(x: 0.3894605204095136d, y: 0.8394029528645813d), new NpgsqlTypes.NpgsqlPoint(x: 0.06753034525345292d, y: 0.5602269429949731d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8742785190283202d, y: 0.27416407363535755d), new NpgsqlTypes.NpgsqlPoint(x: 0.9704296319429164d, y: 0.767735780539253d), new NpgsqlTypes.NpgsqlPoint(x: 0.8681994236084667d, y: 0.6524826037229252d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9529972243554641d, y: 0.6252377964818235d), new NpgsqlTypes.NpgsqlPoint(x: 0.9116743046476146d, y: 0.14936997740985913d), new NpgsqlTypes.NpgsqlPoint(x: 0.36178153840988514d, y: 0.2078780608640326d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7725872097025672d, y: 0.9362016577707934d), new NpgsqlTypes.NpgsqlPoint(x: 0.5963663651382621d, y: 0.4594159611389981d), new NpgsqlTypes.NpgsqlPoint(x: 0.9437463671634518d, y: 0.9104113700733094d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6029694562473539d, y: 0.9244559654502267d), new NpgsqlTypes.NpgsqlPoint(x: 0.9158301091050295d, y: 0.24141962843562648d), new NpgsqlTypes.NpgsqlPoint(x: 0.09641965016234932d, y: 0.24832387027994496d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7569549397418254d, y: 0.05721570073184845d), new NpgsqlTypes.NpgsqlPoint(x: 0.44667061917146944d, y: 0.9476864403222119d), new NpgsqlTypes.NpgsqlPoint(x: 0.5173372245747542d, y: 0.9060905510023922d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10619473254178835d, y: 0.22816600522550223d), new NpgsqlTypes.NpgsqlPoint(x: 0.017506562734752262d, y: 0.83763877121559d), new NpgsqlTypes.NpgsqlPoint(x: 0.2501653283640667d, y: 0.5140388123249938d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16966247063148132d, y: 0.4093181604431567d), new NpgsqlTypes.NpgsqlPoint(x: 0.47645966929574624d, y: 0.41140334235757836d), new NpgsqlTypes.NpgsqlPoint(x: 0.8731058924907752d, y: 0.3560369057470375d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35425881297688944d, y: 0.8740195338191767d), new NpgsqlTypes.NpgsqlPoint(x: 0.5345765631627172d, y: 0.26649050214045344d), new NpgsqlTypes.NpgsqlPoint(x: 0.963141220169091d, y: 0.20794766474886128d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7229676843607805d, y: 0.6443232383356733d), new NpgsqlTypes.NpgsqlPoint(x: 0.09589243752946441d, y: 0.3990201264997102d), new NpgsqlTypes.NpgsqlPoint(x: 0.6597634897843188d, y: 0.5417979607017734d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2686367959730146d, y: 0.4167005030123223d), new NpgsqlTypes.NpgsqlPoint(x: 0.9978080177829404d, y: 0.334316727641111d), new NpgsqlTypes.NpgsqlPoint(x: 0.5114513529572534d, y: 0.9850589381885911d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22257373412075965d, y: 0.32160024152550337d), new NpgsqlTypes.NpgsqlPoint(x: 0.05023329022376177d, y: 0.15951449043470467d), new NpgsqlTypes.NpgsqlPoint(x: 0.20062943078322837d, y: 0.61708022927012d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1762118501216191d, y: 0.4623207543618514d), new NpgsqlTypes.NpgsqlPoint(x: 0.16209848233723456d, y: 0.10845314888309943d), new NpgsqlTypes.NpgsqlPoint(x: 0.37784920131016075d, y: 0.5374011452798377d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8216094415657174d, y: 0.35229811082591955d), new NpgsqlTypes.NpgsqlPoint(x: 0.14043627118216073d, y: 0.04229553349585269d), new NpgsqlTypes.NpgsqlPoint(x: 0.814051964159424d, y: 0.8574801745162786d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05722948981359077d, y: 0.7050816443831713d), new NpgsqlTypes.NpgsqlPoint(x: 0.41920381498005266d, y: 0.3425801836633847d), new NpgsqlTypes.NpgsqlPoint(x: 0.972080802089244d, y: 0.6366524141530723d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2607193975630717d, y: 0.42526161291645015d), new NpgsqlTypes.NpgsqlPoint(x: 0.05342071243980795d, y: 0.18139601781391246d), new NpgsqlTypes.NpgsqlPoint(x: 0.19060686874761945d, y: 0.1673031729683475d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6361705532839442d, y: 0.6012936557236586d), new NpgsqlTypes.NpgsqlPoint(x: 0.27022133917813196d, y: 0.19993722179477802d), new NpgsqlTypes.NpgsqlPoint(x: 0.005292621962787014d, y: 0.44359093790128445d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23487912069785621d, y: 0.2556681442909803d), new NpgsqlTypes.NpgsqlPoint(x: 0.004402810237710164d, y: 0.3758689327647955d), new NpgsqlTypes.NpgsqlPoint(x: 0.5551515267320869d, y: 0.9993592179705064d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9547293123456703d, y: 0.4862630044170789d), new NpgsqlTypes.NpgsqlPoint(x: 0.9802693554356541d, y: 0.6303188517388739d), new NpgsqlTypes.NpgsqlPoint(x: 0.7934799275842365d, y: 0.24305066768659767d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22319642522896255d, y: 0.22792546964477578d), new NpgsqlTypes.NpgsqlPoint(x: 0.207238959199876d, y: 0.7335255147548245d), new NpgsqlTypes.NpgsqlPoint(x: 0.11147720126636662d, y: 0.029245452411542194d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12775871319451282d, y: 0.06663234903322135d), new NpgsqlTypes.NpgsqlPoint(x: 0.7567026881732242d, y: 0.639668487080745d), new NpgsqlTypes.NpgsqlPoint(x: 0.033130318397567415d, y: 0.7487940008239132d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5171035838803716d, y: 0.46072613065530066d), new NpgsqlTypes.NpgsqlPoint(x: 0.3966457526077193d, y: 0.9961233539276966d), new NpgsqlTypes.NpgsqlPoint(x: 0.33332297428858515d, y: 0.9119473017417628d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3210407043063883d, y: 0.22434149827806882d), new NpgsqlTypes.NpgsqlPoint(x: 0.5626516755554465d, y: 0.4617051359225187d), new NpgsqlTypes.NpgsqlPoint(x: 0.6639125272963553d, y: 0.5153140289823291d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02505465943445262d, y: 0.08046166942251098d), new NpgsqlTypes.NpgsqlPoint(x: 0.7938197323893068d, y: 0.5364986761148779d), new NpgsqlTypes.NpgsqlPoint(x: 0.605311287729517d, y: 0.09621921055698945d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7285269946374132d, y: 0.2649488405953634d), new NpgsqlTypes.NpgsqlPoint(x: 0.15831399626702503d, y: 0.3783544256058591d), new NpgsqlTypes.NpgsqlPoint(x: 0.6844835419206332d, y: 0.6052894842898987d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30137304975559387d, y: 0.7944508520179073d), new NpgsqlTypes.NpgsqlPoint(x: 0.9976682353154648d, y: 0.7013605183257722d), new NpgsqlTypes.NpgsqlPoint(x: 0.748906950957729d, y: 0.028827456183609157d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22404302844675883d, y: 0.6093722869528437d), new NpgsqlTypes.NpgsqlPoint(x: 0.8098342694924346d, y: 0.17049954991064697d), new NpgsqlTypes.NpgsqlPoint(x: 0.42194735265520755d, y: 0.9679797510551863d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.92953703362933d, y: 0.16068518869832493d), new NpgsqlTypes.NpgsqlPoint(x: 0.6889050786266916d, y: 0.2981821411787381d), new NpgsqlTypes.NpgsqlPoint(x: 0.4717638220865302d, y: 0.37777414727515723d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24741421856313162d, y: 0.3003060170880989d), new NpgsqlTypes.NpgsqlPoint(x: 0.8496125300314391d, y: 0.5151179739389383d), new NpgsqlTypes.NpgsqlPoint(x: 0.5877020989140038d, y: 0.4787412292095742d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16799316841830936d, y: 0.36877196930274103d), new NpgsqlTypes.NpgsqlPoint(x: 0.1242981692290287d, y: 0.6276344137747449d), new NpgsqlTypes.NpgsqlPoint(x: 0.3415035772197107d, y: 0.17835151608649857d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11034123460563094d, y: 0.6542116164766271d), new NpgsqlTypes.NpgsqlPoint(x: 0.360350628493481d, y: 0.5472456931555247d), new NpgsqlTypes.NpgsqlPoint(x: 0.8614112982433834d, y: 0.9621919345169889d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19056678720392106d, y: 0.47091660789956424d), new NpgsqlTypes.NpgsqlPoint(x: 0.27218530536231467d, y: 0.1899881922223684d), new NpgsqlTypes.NpgsqlPoint(x: 0.5032233415631602d, y: 0.9614815969157405d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.873592820860224d, y: 0.9780637896083112d), new NpgsqlTypes.NpgsqlPoint(x: 0.6707670356069394d, y: 0.8535200190109118d), new NpgsqlTypes.NpgsqlPoint(x: 0.11903187254134007d, y: 0.013083156119927941d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17858022176059252d, y: 0.7547371894697646d), new NpgsqlTypes.NpgsqlPoint(x: 0.4751049809279968d, y: 0.03898630067036668d), new NpgsqlTypes.NpgsqlPoint(x: 0.20137473762119262d, y: 0.29325557992790086d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7599326647352994d, y: 0.8309630493487938d), new NpgsqlTypes.NpgsqlPoint(x: 0.7250896113295872d, y: 0.7529043800019238d), new NpgsqlTypes.NpgsqlPoint(x: 0.6452586207702969d, y: 0.30099862022178236d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7929605583520836d, y: 0.9171467838940172d), new NpgsqlTypes.NpgsqlPoint(x: 0.9034471757561915d, y: 0.8542596855091859d), new NpgsqlTypes.NpgsqlPoint(x: 0.38304662469756134d, y: 0.9331487839632825d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07279553653200399d, y: 0.4961583963555465d), new NpgsqlTypes.NpgsqlPoint(x: 0.18147022481592334d, y: 0.08974737213798356d), new NpgsqlTypes.NpgsqlPoint(x: 0.9484452756301235d, y: 0.007683185327428066d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.024449425464212582d, y: 0.28072969392004743d), new NpgsqlTypes.NpgsqlPoint(x: 0.8080797414455438d, y: 0.9132327905435255d), new NpgsqlTypes.NpgsqlPoint(x: 0.7277506574439118d, y: 0.93370305649482d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08297036868149343d, y: 0.6297659502269363d), new NpgsqlTypes.NpgsqlPoint(x: 0.14288105838700904d, y: 0.88367858733661d), new NpgsqlTypes.NpgsqlPoint(x: 0.18134856152540202d, y: 0.5334526197092208d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4379038705984255d, y: 0.49247351565315445d), new NpgsqlTypes.NpgsqlPoint(x: 0.852442453979689d, y: 0.02654774620038003d), new NpgsqlTypes.NpgsqlPoint(x: 0.9040544290580589d, y: 0.7567806307212311d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6595015834521665d, y: 0.3707506911427124d), new NpgsqlTypes.NpgsqlPoint(x: 0.5644561185138626d, y: 0.4431209132910914d), new NpgsqlTypes.NpgsqlPoint(x: 0.26545375705320773d, y: 0.7183013213573994d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.552781687652048d, y: 0.8869192865469392d), new NpgsqlTypes.NpgsqlPoint(x: 0.45866630398325337d, y: 0.6568132058705862d), new NpgsqlTypes.NpgsqlPoint(x: 0.19851338894111004d, y: 0.851003550080384d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3456833328568939d, y: 0.8797095842472719d), new NpgsqlTypes.NpgsqlPoint(x: 0.8948653353987297d, y: 0.32057405354041535d), new NpgsqlTypes.NpgsqlPoint(x: 0.9213448077495303d, y: 0.9664766932596612d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47425771553527474d, y: 0.3023752029193184d), new NpgsqlTypes.NpgsqlPoint(x: 0.3299109988502211d, y: 0.5893244850027529d), new NpgsqlTypes.NpgsqlPoint(x: 0.5960562171285424d, y: 0.6812586456347403d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7103319078017759d, y: 0.26522662155543697d), new NpgsqlTypes.NpgsqlPoint(x: 0.016096418160719828d, y: 0.2808895673546984d), new NpgsqlTypes.NpgsqlPoint(x: 0.15902654368938696d, y: 0.22280687670578858d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.768507940555295d, y: 0.22023191821773358d), new NpgsqlTypes.NpgsqlPoint(x: 0.5681821133662625d, y: 0.4152353362092056d), new NpgsqlTypes.NpgsqlPoint(x: 0.3921149839241327d, y: 0.7190084344474247d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28595866706656925d, y: 0.7371531149571197d), new NpgsqlTypes.NpgsqlPoint(x: 0.6989979535605538d, y: 0.5263067740093974d), new NpgsqlTypes.NpgsqlPoint(x: 0.1978940269463788d, y: 0.4957792950464933d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6438874334012937d, y: 0.6292219353920967d), new NpgsqlTypes.NpgsqlPoint(x: 0.8969558161377873d, y: 0.4797644911943323d), new NpgsqlTypes.NpgsqlPoint(x: 0.18436092590290354d, y: 0.028368696553235484d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9307572609489095d, y: 0.9474512971465608d), new NpgsqlTypes.NpgsqlPoint(x: 0.7850635626757602d, y: 0.1508144815393535d), new NpgsqlTypes.NpgsqlPoint(x: 0.465910506326879d, y: 0.5634836257753113d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5036354941335802d, y: 0.9096077622679183d), new NpgsqlTypes.NpgsqlPoint(x: 0.8561121646541363d, y: 0.22124390693325413d), new NpgsqlTypes.NpgsqlPoint(x: 0.9013658889425075d, y: 0.24742739361639832d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9568375922029261d, y: 0.5495497558534954d), new NpgsqlTypes.NpgsqlPoint(x: 0.9002540826893404d, y: 0.9315501006549597d), new NpgsqlTypes.NpgsqlPoint(x: 0.0695956754234841d, y: 0.06864875253045655d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3231876044754035d, y: 0.871925395043081d), new NpgsqlTypes.NpgsqlPoint(x: 0.8453110349433935d, y: 0.2660210601219445d), new NpgsqlTypes.NpgsqlPoint(x: 0.06206284770483461d, y: 0.4536209155249349d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35656707619211414d, y: 0.8788547614322851d), new NpgsqlTypes.NpgsqlPoint(x: 0.6523006072866936d, y: 0.5789674740818268d), new NpgsqlTypes.NpgsqlPoint(x: 0.8930571134673513d, y: 0.4040543286419984d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.783778089811579d, y: 0.4913819018397648d), new NpgsqlTypes.NpgsqlPoint(x: 0.5001864820727517d, y: 0.9495338963557661d), new NpgsqlTypes.NpgsqlPoint(x: 0.5267301668734476d, y: 0.608427114302743d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0279577696859018d, y: 0.35726414208495083d), new NpgsqlTypes.NpgsqlPoint(x: 0.599357053440009d, y: 0.4341263231209993d), new NpgsqlTypes.NpgsqlPoint(x: 0.36715823392533575d, y: 0.06662276497295139d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44428844550515256d, y: 0.8865489711958755d), new NpgsqlTypes.NpgsqlPoint(x: 0.9268503592939328d, y: 0.453643867628134d), new NpgsqlTypes.NpgsqlPoint(x: 0.5651072735910574d, y: 0.02611919678940222d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9804576453150945d, y: 0.639357384110273d), new NpgsqlTypes.NpgsqlPoint(x: 0.06786879951278701d, y: 0.8032301588287495d), new NpgsqlTypes.NpgsqlPoint(x: 0.23009815611847606d, y: 0.45893303350507153d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6064514567166813d, y: 0.12726814248953533d), new NpgsqlTypes.NpgsqlPoint(x: 0.0424035941214963d, y: 0.5643309551633786d), new NpgsqlTypes.NpgsqlPoint(x: 0.18524876243576838d, y: 0.18629470568647943d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.158929591061289d, y: 0.7318921865458982d), new NpgsqlTypes.NpgsqlPoint(x: 0.02360843117146616d, y: 0.5915463250327909d), new NpgsqlTypes.NpgsqlPoint(x: 0.5690155782019825d, y: 0.7781677174613597d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6478222264775806d, y: 0.6153277724456693d), new NpgsqlTypes.NpgsqlPoint(x: 0.2627687078268316d, y: 0.41504864406302977d), new NpgsqlTypes.NpgsqlPoint(x: 0.6620823598218418d, y: 0.6764457791834287d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06817789513088424d, y: 0.9877007814199583d), new NpgsqlTypes.NpgsqlPoint(x: 0.8426890501233497d, y: 0.5115159191860356d), new NpgsqlTypes.NpgsqlPoint(x: 0.8078444646661482d, y: 0.7038470887598754d)),

},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1025806957419183d, y: 0.09903812202954632d), new NpgsqlTypes.NpgsqlPoint(x: 0.001717099460790683d, y: 0.6571423799211604d), new NpgsqlTypes.NpgsqlPoint(x: 0.5656106721112117d, y: 0.19150827996429132d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32952513880210543d, y: 0.05886747712769158d), new NpgsqlTypes.NpgsqlPoint(x: 0.8337418593647624d, y: 0.5333055621375048d), new NpgsqlTypes.NpgsqlPoint(x: 0.03875872051588847d, y: 0.6956787376460533d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9225142840253867d, y: 0.9772310182898111d), new NpgsqlTypes.NpgsqlPoint(x: 0.4991104275214323d, y: 0.4494368756602388d), new NpgsqlTypes.NpgsqlPoint(x: 0.1337872211977249d, y: 0.8292165706392276d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3800536819581679d, y: 0.13644645738874395d), new NpgsqlTypes.NpgsqlPoint(x: 0.7415577718363747d, y: 0.661916587681158d), new NpgsqlTypes.NpgsqlPoint(x: 0.20125489636962401d, y: 0.5864046539543101d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09481992970121744d, y: 0.7092786420457963d), new NpgsqlTypes.NpgsqlPoint(x: 0.973718715927507d, y: 0.505478416000382d), new NpgsqlTypes.NpgsqlPoint(x: 0.8854427899206114d, y: 0.16621989082237232d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1246148373254794d, y: 0.106323451762384d), new NpgsqlTypes.NpgsqlPoint(x: 0.3102442593061494d, y: 0.8309547758015235d), new NpgsqlTypes.NpgsqlPoint(x: 0.9733841045401499d, y: 0.6677044142548655d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20575262612368905d, y: 0.8158181170004014d), new NpgsqlTypes.NpgsqlPoint(x: 0.7845534860802238d, y: 0.11291136043283434d), new NpgsqlTypes.NpgsqlPoint(x: 0.8344382659917351d, y: 0.6890917007938969d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3516977236614217d, y: 0.1987398442611612d), new NpgsqlTypes.NpgsqlPoint(x: 0.5054224056197886d, y: 0.7214147354347097d), new NpgsqlTypes.NpgsqlPoint(x: 0.27627540398121964d, y: 0.007560238279084142d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5101166132324371d, y: 0.38723639321617753d), new NpgsqlTypes.NpgsqlPoint(x: 0.403489314548788d, y: 0.5858347907607157d), new NpgsqlTypes.NpgsqlPoint(x: 0.07566234551464213d, y: 0.7855261888790949d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9519109821929372d, y: 0.9103693210665473d), new NpgsqlTypes.NpgsqlPoint(x: 0.06117414713825042d, y: 0.2852154449602623d), new NpgsqlTypes.NpgsqlPoint(x: 0.14792806880145848d, y: 0.2665100552174061d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1936205348210981d, y: 0.9939567157950864d), new NpgsqlTypes.NpgsqlPoint(x: 0.11435233502088205d, y: 0.9369599205420825d), new NpgsqlTypes.NpgsqlPoint(x: 0.20112407023230539d, y: 0.09806896398694243d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7550677110932786d, y: 0.7159117115723902d), new NpgsqlTypes.NpgsqlPoint(x: 0.6406642251759251d, y: 0.2199634522400744d), new NpgsqlTypes.NpgsqlPoint(x: 0.19239445276515055d, y: 0.9300729447982509d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.583415235163043d, y: 0.059913211483194284d), new NpgsqlTypes.NpgsqlPoint(x: 0.7834115666855356d, y: 0.8678184322518928d), new NpgsqlTypes.NpgsqlPoint(x: 0.858474360263698d, y: 0.6656743566369182d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09357913606924517d, y: 0.18008099699293056d), new NpgsqlTypes.NpgsqlPoint(x: 0.8393945932906435d, y: 0.14645715869925258d), new NpgsqlTypes.NpgsqlPoint(x: 0.15621507988284122d, y: 0.6508322253298328d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9818194182263856d, y: 0.5753845390595776d), new NpgsqlTypes.NpgsqlPoint(x: 0.13064304505946156d, y: 0.8040627187998941d), new NpgsqlTypes.NpgsqlPoint(x: 0.4695545755847972d, y: 0.847248911387278d)),

},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8151322011732273d, y: 0.10581303949813925d), new NpgsqlTypes.NpgsqlPoint(x: 0.09069304450137683d, y: 0.8850243985866125d), new NpgsqlTypes.NpgsqlPoint(x: 0.94707946660104d, y: 0.5527797965433346d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6339386499080848d, y: 0.8349581539334301d), new NpgsqlTypes.NpgsqlPoint(x: 0.3953620638370059d, y: 0.23601651267669133d), new NpgsqlTypes.NpgsqlPoint(x: 0.46771684968710925d, y: 0.938816516732568d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9777871568709949d, y: 0.4813907939589873d), new NpgsqlTypes.NpgsqlPoint(x: 0.8436335071464909d, y: 0.2662481426020329d), new NpgsqlTypes.NpgsqlPoint(x: 0.6860102445601418d, y: 0.2463723213601815d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48249764915167415d, y: 0.1450120609760106d), new NpgsqlTypes.NpgsqlPoint(x: 0.22082156552994747d, y: 0.6297057677852455d), new NpgsqlTypes.NpgsqlPoint(x: 0.4068820358312054d, y: 0.1452815362870954d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.882811299734974d, y: 0.17996716093973308d), new NpgsqlTypes.NpgsqlPoint(x: 0.9218772681788859d, y: 0.2342317329538891d), new NpgsqlTypes.NpgsqlPoint(x: 0.7265306448907385d, y: 0.9721739850465434d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.64298198688231d, y: 0.4369931613199438d), new NpgsqlTypes.NpgsqlPoint(x: 0.3747564062163815d, y: 0.87162827163562d), new NpgsqlTypes.NpgsqlPoint(x: 0.2285782294563533d, y: 0.9716575115636785d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17280190402422513d, y: 0.3282250279773429d), new NpgsqlTypes.NpgsqlPoint(x: 0.1494273456266243d, y: 0.9977123751601878d), new NpgsqlTypes.NpgsqlPoint(x: 0.9532753135278931d, y: 0.6223410379255422d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5585953810976085d, y: 0.6708593610391939d), new NpgsqlTypes.NpgsqlPoint(x: 0.9965745675366925d, y: 0.1241583718610656d), new NpgsqlTypes.NpgsqlPoint(x: 0.07752023186230417d, y: 0.4165267722393453d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06052831415871185d, y: 0.9306334547644507d), new NpgsqlTypes.NpgsqlPoint(x: 0.9377222402007163d, y: 0.13514791180497843d), new NpgsqlTypes.NpgsqlPoint(x: 0.5301030493961977d, y: 0.5274853127163613d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9666888168787633d, y: 0.8445915416690881d), new NpgsqlTypes.NpgsqlPoint(x: 0.0852398246227718d, y: 0.3620049084268463d), new NpgsqlTypes.NpgsqlPoint(x: 0.6497233342979527d, y: 0.6385007365352725d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9603298922421333d, y: 0.6073968794864304d), new NpgsqlTypes.NpgsqlPoint(x: 0.752451275447914d, y: 0.6386261938914479d), new NpgsqlTypes.NpgsqlPoint(x: 0.22027272407458265d, y: 0.9776030407309317d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22945300229048649d, y: 0.9969558779228688d), new NpgsqlTypes.NpgsqlPoint(x: 0.3497517141884021d, y: 0.8379133214941669d), new NpgsqlTypes.NpgsqlPoint(x: 0.051489595908601915d, y: 0.042339406297240645d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2666447462895106d, y: 0.11307746931453233d), new NpgsqlTypes.NpgsqlPoint(x: 0.5459637876668256d, y: 0.6858461139218688d), new NpgsqlTypes.NpgsqlPoint(x: 0.5897407025435575d, y: 0.3129949010013896d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5081005047236691d, y: 0.5049998060587646d), new NpgsqlTypes.NpgsqlPoint(x: 0.6980951317803041d, y: 0.61625010751124d), new NpgsqlTypes.NpgsqlPoint(x: 0.3559797102445853d, y: 0.02452291033476761d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5446558410163105d, y: 0.18256587549656444d), new NpgsqlTypes.NpgsqlPoint(x: 0.8370798196617433d, y: 0.36790694152514225d), new NpgsqlTypes.NpgsqlPoint(x: 0.19284246522695048d, y: 0.6427657007872442d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6895194526216891d, y: 0.8074582738783883d), new NpgsqlTypes.NpgsqlPoint(x: 0.4283742646676726d, y: 0.7862540361657252d), new NpgsqlTypes.NpgsqlPoint(x: 0.1989998427724543d, y: 0.4074576734245239d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44285181435488097d, y: 0.543018506426906d), new NpgsqlTypes.NpgsqlPoint(x: 0.42001369485420925d, y: 0.9914075683772524d), new NpgsqlTypes.NpgsqlPoint(x: 0.2143562982158005d, y: 0.9212110658401252d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03981808566866796d, y: 0.40277077259410154d), new NpgsqlTypes.NpgsqlPoint(x: 0.5714232988920503d, y: 0.942503080739274d), new NpgsqlTypes.NpgsqlPoint(x: 0.07509570426841183d, y: 0.6187352309018991d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10252168871855094d, y: 0.31916808170445565d), new NpgsqlTypes.NpgsqlPoint(x: 0.8913865502822514d, y: 0.5011961185882714d), new NpgsqlTypes.NpgsqlPoint(x: 0.1585550406639854d, y: 0.17903068132360267d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37858627084283203d, y: 0.5159068120962758d), new NpgsqlTypes.NpgsqlPoint(x: 0.35178549231967127d, y: 0.9631425150157471d), new NpgsqlTypes.NpgsqlPoint(x: 0.7446075675598198d, y: 0.22775787373021283d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46800128465574664d, y: 0.8260021709553467d), new NpgsqlTypes.NpgsqlPoint(x: 0.8384341761162952d, y: 0.2157354596948643d), new NpgsqlTypes.NpgsqlPoint(x: 0.41248162849236725d, y: 0.2396876523056859d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5069780629746837d, y: 0.8014066055673654d), new NpgsqlTypes.NpgsqlPoint(x: 0.16782094674586023d, y: 0.29991065046867715d), new NpgsqlTypes.NpgsqlPoint(x: 0.7789826448836569d, y: 0.4531927510080138d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4896944803808667d, y: 0.5198949387939805d), new NpgsqlTypes.NpgsqlPoint(x: 0.08588290723390957d, y: 0.6766547795625688d), new NpgsqlTypes.NpgsqlPoint(x: 0.35119735036217925d, y: 0.5946741642700469d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.814247705452564d, y: 0.014250833094388793d), new NpgsqlTypes.NpgsqlPoint(x: 0.2581365748000004d, y: 0.08178986237165053d), new NpgsqlTypes.NpgsqlPoint(x: 0.24351079882512183d, y: 0.9695219204672222d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12514588586975184d, y: 0.8570663667844894d), new NpgsqlTypes.NpgsqlPoint(x: 0.1519271126330931d, y: 0.05698314715577635d), new NpgsqlTypes.NpgsqlPoint(x: 0.761465082273689d, y: 0.48890875236449716d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44655397201487745d, y: 0.4738994257164174d), new NpgsqlTypes.NpgsqlPoint(x: 0.04523405636581512d, y: 0.3226328128797402d), new NpgsqlTypes.NpgsqlPoint(x: 0.9454769753948051d, y: 0.37256380361976815d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.848984259684204d, y: 0.14623324235315271d), new NpgsqlTypes.NpgsqlPoint(x: 0.805698265639632d, y: 0.6962195374790727d), new NpgsqlTypes.NpgsqlPoint(x: 0.3577924749100634d, y: 0.9109569298615952d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39056297237847026d, y: 0.45991819985641724d), new NpgsqlTypes.NpgsqlPoint(x: 0.5089652605119708d, y: 0.5488674470407429d), new NpgsqlTypes.NpgsqlPoint(x: 0.7274559554638199d, y: 0.5494446100351182d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28751338181924013d, y: 0.8847993479350813d), new NpgsqlTypes.NpgsqlPoint(x: 0.7108631955454223d, y: 0.15062645991073242d), new NpgsqlTypes.NpgsqlPoint(x: 0.1466842494824332d, y: 0.26838696924442385d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3629005923323012d, y: 0.9223247446369109d), new NpgsqlTypes.NpgsqlPoint(x: 0.663224588958111d, y: 0.4526112100069275d), new NpgsqlTypes.NpgsqlPoint(x: 0.5748581856122925d, y: 0.36739915434629755d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6774357266404116d, y: 0.08216374777680913d), new NpgsqlTypes.NpgsqlPoint(x: 0.3873139481251725d, y: 0.5900109577766165d), new NpgsqlTypes.NpgsqlPoint(x: 0.3563704899783021d, y: 0.43367999982055294d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7477720695773302d, y: 0.6782458918950682d), new NpgsqlTypes.NpgsqlPoint(x: 0.08098817682813186d, y: 0.5636229747841078d), new NpgsqlTypes.NpgsqlPoint(x: 0.4143799531746548d, y: 0.393586595101029d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.379982359162057d, y: 0.043904513297251646d), new NpgsqlTypes.NpgsqlPoint(x: 0.9415469458195728d, y: 0.5027308978756364d), new NpgsqlTypes.NpgsqlPoint(x: 0.5847347499522333d, y: 0.9941238387876138d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8255546964543534d, y: 0.453624252841763d), new NpgsqlTypes.NpgsqlPoint(x: 0.22849907282222703d, y: 0.40632961072489204d), new NpgsqlTypes.NpgsqlPoint(x: 0.5334487629954598d, y: 0.31431427598558603d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31204369723987624d, y: 0.5069066151252096d), new NpgsqlTypes.NpgsqlPoint(x: 0.6192723039482239d, y: 0.16841638727271357d), new NpgsqlTypes.NpgsqlPoint(x: 0.96649940550181d, y: 0.8783159784604303d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6159554099381191d, y: 0.3478294660911223d), new NpgsqlTypes.NpgsqlPoint(x: 0.8262058946386421d, y: 0.21189214233809306d), new NpgsqlTypes.NpgsqlPoint(x: 0.37444890369295836d, y: 0.15408072522473593d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2999884808924941d, y: 0.8690416717703089d), new NpgsqlTypes.NpgsqlPoint(x: 0.22949909376585786d, y: 0.9075485921600891d), new NpgsqlTypes.NpgsqlPoint(x: 0.5040250830856856d, y: 0.8042975396647422d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.015087728335417272d, y: 0.7701048217647285d), new NpgsqlTypes.NpgsqlPoint(x: 0.14973057527001488d, y: 0.9015049467455939d), new NpgsqlTypes.NpgsqlPoint(x: 0.07002543888158741d, y: 0.3800409633039562d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10454551837970016d, y: 0.3616516149438974d), new NpgsqlTypes.NpgsqlPoint(x: 0.6920886244783103d, y: 0.7558134890366605d), new NpgsqlTypes.NpgsqlPoint(x: 0.8030479864142731d, y: 0.04485770204584327d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5167054838236116d, y: 0.10876633361401056d), new NpgsqlTypes.NpgsqlPoint(x: 0.4151779934772445d, y: 0.4412547317372352d), new NpgsqlTypes.NpgsqlPoint(x: 0.050698148061354975d, y: 0.6039331845332743d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3801960112850741d, y: 0.13280392694385712d), new NpgsqlTypes.NpgsqlPoint(x: 0.866486224993995d, y: 0.9991749438930659d), new NpgsqlTypes.NpgsqlPoint(x: 0.8655125625680682d, y: 0.6945435611766121d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7589243011773342d, y: 0.7950788204551126d), new NpgsqlTypes.NpgsqlPoint(x: 0.9772040568101509d, y: 0.914555821382789d), new NpgsqlTypes.NpgsqlPoint(x: 0.27475008209865337d, y: 0.8904566992406069d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11600761872426879d, y: 0.3598494212747715d), new NpgsqlTypes.NpgsqlPoint(x: 0.7055704586275595d, y: 0.013868881005621558d), new NpgsqlTypes.NpgsqlPoint(x: 0.478890803590711d, y: 0.312141075851038d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03210946097632894d, y: 0.6120872404307408d), new NpgsqlTypes.NpgsqlPoint(x: 0.20412787871170968d, y: 0.6946588427914234d), new NpgsqlTypes.NpgsqlPoint(x: 0.6382327079149086d, y: 0.20118582283873065d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.053223810105852754d, y: 0.9470932049604825d), new NpgsqlTypes.NpgsqlPoint(x: 0.4553177286345357d, y: 0.5686520720041471d), new NpgsqlTypes.NpgsqlPoint(x: 0.47828662008303535d, y: 0.38595328838780363d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7020994150915477d, y: 0.5879313778216154d), new NpgsqlTypes.NpgsqlPoint(x: 0.8014805535537503d, y: 0.7740161887161562d), new NpgsqlTypes.NpgsqlPoint(x: 0.8080831826429583d, y: 0.0365030292850842d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9781112914171739d, y: 0.39977732567490953d), new NpgsqlTypes.NpgsqlPoint(x: 0.20174928216101407d, y: 0.20025019155649904d), new NpgsqlTypes.NpgsqlPoint(x: 0.25342950014006493d, y: 0.5259626483639759d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03999217267533872d, y: 0.7365823611036402d), new NpgsqlTypes.NpgsqlPoint(x: 0.5209567616816206d, y: 0.907178423385532d), new NpgsqlTypes.NpgsqlPoint(x: 0.8219829176482971d, y: 0.07096004353422991d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11721681446161158d, y: 0.379270098922751d), new NpgsqlTypes.NpgsqlPoint(x: 0.42311511633172927d, y: 0.6175448301819846d), new NpgsqlTypes.NpgsqlPoint(x: 0.4940012842334728d, y: 0.8626260216544268d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2623303437092869d, y: 0.8270527544406207d), new NpgsqlTypes.NpgsqlPoint(x: 0.11249622584430585d, y: 0.7293883462894329d), new NpgsqlTypes.NpgsqlPoint(x: 0.07333019418765385d, y: 0.6072838933440687d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3139984100676052d, y: 0.8469937339354225d), new NpgsqlTypes.NpgsqlPoint(x: 0.19276445296051747d, y: 0.9494317386405731d), new NpgsqlTypes.NpgsqlPoint(x: 0.24623364007644688d, y: 0.3224873689616853d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7060321132055477d, y: 0.8247062528735671d), new NpgsqlTypes.NpgsqlPoint(x: 0.8505589924600819d, y: 0.8820231406133141d), new NpgsqlTypes.NpgsqlPoint(x: 0.46071028027794403d, y: 0.3487412268955741d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.711039328392495d, y: 0.4399325630326626d), new NpgsqlTypes.NpgsqlPoint(x: 0.8066251415224105d, y: 0.2556783750720891d), new NpgsqlTypes.NpgsqlPoint(x: 0.015441735474757579d, y: 0.18649168617036693d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28950095572800427d, y: 0.17855513349426777d), new NpgsqlTypes.NpgsqlPoint(x: 0.08866040570191935d, y: 0.6582842555679901d), new NpgsqlTypes.NpgsqlPoint(x: 0.9174390552442377d, y: 0.22605432548052318d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.014150546113450235d, y: 0.8659179032589703d), new NpgsqlTypes.NpgsqlPoint(x: 0.5721274618229847d, y: 0.4803240873865434d), new NpgsqlTypes.NpgsqlPoint(x: 0.2723233798087529d, y: 0.07622622228235443d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9915346162829624d, y: 0.0480412506142045d), new NpgsqlTypes.NpgsqlPoint(x: 0.9845499760607437d, y: 0.6800309131232718d), new NpgsqlTypes.NpgsqlPoint(x: 0.15091973094719302d, y: 0.2989941791660221d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4141157426127705d, y: 0.7768029308842979d), new NpgsqlTypes.NpgsqlPoint(x: 0.2697525709455524d, y: 0.9154423996147846d), new NpgsqlTypes.NpgsqlPoint(x: 0.22377394803952755d, y: 0.36895856927015436d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8433673328504974d, y: 0.4961375240984549d), new NpgsqlTypes.NpgsqlPoint(x: 0.48337083226860666d, y: 0.6762968298098906d), new NpgsqlTypes.NpgsqlPoint(x: 0.1836392329346601d, y: 0.8280201021371718d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8871056501532741d, y: 0.930735450361704d), new NpgsqlTypes.NpgsqlPoint(x: 0.017994510997265012d, y: 0.7512934343582369d), new NpgsqlTypes.NpgsqlPoint(x: 0.587062951872934d, y: 0.8356797164302632d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6726891612901105d, y: 0.39644380595250617d), new NpgsqlTypes.NpgsqlPoint(x: 0.07602306912886769d, y: 0.8521505076441859d), new NpgsqlTypes.NpgsqlPoint(x: 0.9886195584709674d, y: 0.04678055648159929d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37315053759475003d, y: 0.9332703513965571d), new NpgsqlTypes.NpgsqlPoint(x: 0.16206331694563292d, y: 0.961498259929763d), new NpgsqlTypes.NpgsqlPoint(x: 0.3678132405789021d, y: 0.8799709464357894d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12506582213683404d, y: 0.20074369483173304d), new NpgsqlTypes.NpgsqlPoint(x: 0.9223490710432449d, y: 0.4200699769149717d), new NpgsqlTypes.NpgsqlPoint(x: 0.777509350240002d, y: 0.4032007930200108d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.053328102124526544d, y: 0.8955723902347956d), new NpgsqlTypes.NpgsqlPoint(x: 0.2749435618042191d, y: 0.9872304227487129d), new NpgsqlTypes.NpgsqlPoint(x: 0.5374562733982734d, y: 0.5019300808881724d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3826168975059502d, y: 0.6042480852394971d), new NpgsqlTypes.NpgsqlPoint(x: 0.2858374998775691d, y: 0.9770294660305732d), new NpgsqlTypes.NpgsqlPoint(x: 0.2977153670176418d, y: 0.8701337491777231d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19455669800464104d, y: 0.16478928942905857d), new NpgsqlTypes.NpgsqlPoint(x: 0.8924597123182934d, y: 0.3193242195555278d), new NpgsqlTypes.NpgsqlPoint(x: 0.27527095507947297d, y: 0.17725869874727473d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1534581255190285d, y: 0.0951397879559237d), new NpgsqlTypes.NpgsqlPoint(x: 0.1834086333277154d, y: 0.2869831827802164d), new NpgsqlTypes.NpgsqlPoint(x: 0.9411547296448938d, y: 0.46837299957805534d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.552958406773266d, y: 0.2193448151867864d), new NpgsqlTypes.NpgsqlPoint(x: 0.7970608973830774d, y: 0.05095186585602396d), new NpgsqlTypes.NpgsqlPoint(x: 0.1663639647539047d, y: 0.6753566086194974d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05031743453699489d, y: 0.5464658399827981d), new NpgsqlTypes.NpgsqlPoint(x: 0.4157298134255364d, y: 0.8406850979840864d), new NpgsqlTypes.NpgsqlPoint(x: 0.22076175091243933d, y: 0.5816556489386011d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.030573225727009934d, y: 0.1645271452844873d), new NpgsqlTypes.NpgsqlPoint(x: 0.6427311308911684d, y: 0.23212512468561575d), new NpgsqlTypes.NpgsqlPoint(x: 0.9391204652148012d, y: 0.8384381200978392d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11910431052126425d, y: 0.34288590094257365d), new NpgsqlTypes.NpgsqlPoint(x: 0.9463869969556714d, y: 0.4877609551606873d), new NpgsqlTypes.NpgsqlPoint(x: 0.5631023632697378d, y: 0.12507596464527704d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9298272347356876d, y: 0.3114228246474785d), new NpgsqlTypes.NpgsqlPoint(x: 0.3204206664761369d, y: 0.927641322910477d), new NpgsqlTypes.NpgsqlPoint(x: 0.7051375121886981d, y: 0.6874283567803412d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9990041389060003d, y: 0.16651785406729225d), new NpgsqlTypes.NpgsqlPoint(x: 0.30968878645591913d, y: 0.03702610780140125d), new NpgsqlTypes.NpgsqlPoint(x: 0.7535026911172538d, y: 0.3439349685144161d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2699334573913992d, y: 0.1418022390146113d), new NpgsqlTypes.NpgsqlPoint(x: 0.6623606828845912d, y: 0.45669332463481693d), new NpgsqlTypes.NpgsqlPoint(x: 0.4065391505106948d, y: 0.13398915634836583d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2893891547482391d, y: 0.8300611865304288d), new NpgsqlTypes.NpgsqlPoint(x: 0.7058231375346339d, y: 0.9092919343238847d), new NpgsqlTypes.NpgsqlPoint(x: 0.23405157382189767d, y: 0.8267445101536355d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8972390004197792d, y: 0.31247414589766465d), new NpgsqlTypes.NpgsqlPoint(x: 0.4520136607966416d, y: 0.431818662925329d), new NpgsqlTypes.NpgsqlPoint(x: 0.8888422065564613d, y: 0.967558328454881d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03565835280463725d, y: 0.9110445255464783d), new NpgsqlTypes.NpgsqlPoint(x: 0.6206584397358955d, y: 0.5040563111576393d), new NpgsqlTypes.NpgsqlPoint(x: 0.8487277451979142d, y: 0.4036456356098682d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5185372876135129d, y: 0.4507884903204835d), new NpgsqlTypes.NpgsqlPoint(x: 0.1756795300852818d, y: 0.09852713423214199d), new NpgsqlTypes.NpgsqlPoint(x: 0.8161338407590231d, y: 0.8107097089119337d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5532008194037183d, y: 0.90593811533781d), new NpgsqlTypes.NpgsqlPoint(x: 0.24631735137799993d, y: 0.8125603585101572d), new NpgsqlTypes.NpgsqlPoint(x: 0.5718572410784023d, y: 0.3231592525911112d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3914299222546629d, y: 0.12558708434103127d), new NpgsqlTypes.NpgsqlPoint(x: 0.4900626405034477d, y: 0.15149440232265166d), new NpgsqlTypes.NpgsqlPoint(x: 0.36635078512894914d, y: 0.3584850043286145d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7949540425214267d, y: 0.13143292875928236d), new NpgsqlTypes.NpgsqlPoint(x: 0.4711850963462352d, y: 0.23855268409390373d), new NpgsqlTypes.NpgsqlPoint(x: 0.49866531332567443d, y: 0.8050895471125871d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6643386986090971d, y: 0.7548084858433795d), new NpgsqlTypes.NpgsqlPoint(x: 0.9918394116400421d, y: 0.5528968333041623d), new NpgsqlTypes.NpgsqlPoint(x: 0.2621609177878915d, y: 0.4689530046926673d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.010627183115766492d, y: 0.865679235169763d), new NpgsqlTypes.NpgsqlPoint(x: 0.0866101105670346d, y: 0.5684285002751743d), new NpgsqlTypes.NpgsqlPoint(x: 0.34121153667607795d, y: 0.10570603259941269d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4844521376820137d, y: 0.0035299982214829217d), new NpgsqlTypes.NpgsqlPoint(x: 0.5889244089251949d, y: 0.48509168568773875d), new NpgsqlTypes.NpgsqlPoint(x: 0.691530719752533d, y: 0.7399771226879892d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5769910556637017d, y: 0.18735834667804108d), new NpgsqlTypes.NpgsqlPoint(x: 0.8244896425561926d, y: 0.5316874399378351d), new NpgsqlTypes.NpgsqlPoint(x: 0.6872411757548063d, y: 0.06154683793551374d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8136510898613354d, y: 0.89734440761499d), new NpgsqlTypes.NpgsqlPoint(x: 0.8636671266827549d, y: 0.19390659278277222d), new NpgsqlTypes.NpgsqlPoint(x: 0.0234026618166997d, y: 0.917348695378789d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4622862334134884d, y: 0.5830356163696926d), new NpgsqlTypes.NpgsqlPoint(x: 0.7564171954604865d, y: 0.8642185411341594d), new NpgsqlTypes.NpgsqlPoint(x: 0.6391892411080002d, y: 0.11879193909237462d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4344941116414861d, y: 0.8640596921703556d), new NpgsqlTypes.NpgsqlPoint(x: 0.5280800274770278d, y: 0.9481391278414772d), new NpgsqlTypes.NpgsqlPoint(x: 0.489931672779538d, y: 0.7920970223398818d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8582724008386348d, y: 0.4505563489134107d), new NpgsqlTypes.NpgsqlPoint(x: 0.017406509779926416d, y: 0.7405696310165251d), new NpgsqlTypes.NpgsqlPoint(x: 0.07020493715448117d, y: 0.009236326162613162d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6305857212900206d, y: 0.8344512808656814d), new NpgsqlTypes.NpgsqlPoint(x: 0.7974983834261493d, y: 0.537958282298473d), new NpgsqlTypes.NpgsqlPoint(x: 0.7152789161327673d, y: 0.9200302646028283d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1613963111544232d, y: 0.09674208765632197d), new NpgsqlTypes.NpgsqlPoint(x: 0.1214159234824077d, y: 0.40809927966247217d), new NpgsqlTypes.NpgsqlPoint(x: 0.9651912116929916d, y: 0.16440131211017672d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36259724250826497d, y: 0.6428250676636831d), new NpgsqlTypes.NpgsqlPoint(x: 0.79516150240174d, y: 0.06700725769195492d), new NpgsqlTypes.NpgsqlPoint(x: 0.3682221730219638d, y: 0.837920219365811d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7710844476171256d, y: 0.685944772402828d), new NpgsqlTypes.NpgsqlPoint(x: 0.6188058989734528d, y: 0.07944186582881418d), new NpgsqlTypes.NpgsqlPoint(x: 0.41037564574495944d, y: 0.28888940992705037d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45621688392420734d, y: 0.033968910173029276d), new NpgsqlTypes.NpgsqlPoint(x: 0.39372593947743284d, y: 0.1228365518317941d), new NpgsqlTypes.NpgsqlPoint(x: 0.30010919719202633d, y: 0.13917473015397241d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7051658236641081d, y: 0.7094536537708762d), new NpgsqlTypes.NpgsqlPoint(x: 0.8139113092656748d, y: 0.5624931021473372d), new NpgsqlTypes.NpgsqlPoint(x: 0.372101380990731d, y: 0.7210296021201186d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24731790638378115d, y: 0.9197097734226312d), new NpgsqlTypes.NpgsqlPoint(x: 0.7263027063904264d, y: 0.8799199140241416d), new NpgsqlTypes.NpgsqlPoint(x: 0.7326585896759006d, y: 0.396355676741573d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3266519962871691d, y: 0.29592187312308726d), new NpgsqlTypes.NpgsqlPoint(x: 0.7316535300241893d, y: 0.4006549777391488d), new NpgsqlTypes.NpgsqlPoint(x: 0.8734660118654811d, y: 0.21451393085087256d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20115414155515177d, y: 0.5940429073568203d), new NpgsqlTypes.NpgsqlPoint(x: 0.1965636412416838d, y: 0.6195347220849092d), new NpgsqlTypes.NpgsqlPoint(x: 0.660056760478066d, y: 0.6057854596964732d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.97009621492758d, y: 0.8724682862915984d), new NpgsqlTypes.NpgsqlPoint(x: 0.04203421966474308d, y: 0.8646665002413899d), new NpgsqlTypes.NpgsqlPoint(x: 0.37933470124057767d, y: 0.7934242956161263d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9405250787905824d, y: 0.902869080346826d), new NpgsqlTypes.NpgsqlPoint(x: 0.15493013583530324d, y: 0.7597906913383917d), new NpgsqlTypes.NpgsqlPoint(x: 0.8411502890276416d, y: 0.9294346384556118d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8985583118839414d, y: 0.4336081156997704d), new NpgsqlTypes.NpgsqlPoint(x: 0.06810791111901027d, y: 0.6081870932290597d), new NpgsqlTypes.NpgsqlPoint(x: 0.6437070306709956d, y: 0.5772977923955656d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4749158645547733d, y: 0.26984356627343165d), new NpgsqlTypes.NpgsqlPoint(x: 0.7350942793456927d, y: 0.6968018225002647d), new NpgsqlTypes.NpgsqlPoint(x: 0.4151799585140187d, y: 0.41490520149797117d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9536801875019789d, y: 0.7421298225758021d), new NpgsqlTypes.NpgsqlPoint(x: 0.38701513489390094d, y: 0.39610370412713614d), new NpgsqlTypes.NpgsqlPoint(x: 0.8250672148159672d, y: 0.8430053580342319d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5662169137414224d, y: 0.5083938342068675d), new NpgsqlTypes.NpgsqlPoint(x: 0.8859877839474061d, y: 0.6037804036194814d), new NpgsqlTypes.NpgsqlPoint(x: 0.08696022775761203d, y: 0.6193641149642601d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9709566564620353d, y: 0.6583153135972453d), new NpgsqlTypes.NpgsqlPoint(x: 0.5603259227699344d, y: 0.5134107435804144d), new NpgsqlTypes.NpgsqlPoint(x: 0.5193340486814872d, y: 0.984228337418663d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6843885018451842d, y: 0.30712820067712254d), new NpgsqlTypes.NpgsqlPoint(x: 0.38823971313370464d, y: 0.6725799900147899d), new NpgsqlTypes.NpgsqlPoint(x: 0.9198032758913637d, y: 0.9465605123165984d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10685358550435797d, y: 0.7019390289082473d), new NpgsqlTypes.NpgsqlPoint(x: 0.3719425521294599d, y: 0.17287207418907136d), new NpgsqlTypes.NpgsqlPoint(x: 0.1382414722839489d, y: 0.8441487495019786d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9340104355037492d, y: 0.6015377768465722d), new NpgsqlTypes.NpgsqlPoint(x: 0.13267278936347604d, y: 0.5362296594531953d), new NpgsqlTypes.NpgsqlPoint(x: 0.4114265695539443d, y: 0.24115721419855596d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.754750405843983d, y: 0.5960071357116705d), new NpgsqlTypes.NpgsqlPoint(x: 0.5093570303134429d, y: 0.865902444160371d), new NpgsqlTypes.NpgsqlPoint(x: 0.6932607190795586d, y: 0.9884775211541595d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7660796800806937d, y: 0.883722129961152d), new NpgsqlTypes.NpgsqlPoint(x: 0.9837034923006066d, y: 0.4646297851176675d), new NpgsqlTypes.NpgsqlPoint(x: 0.13122119489873718d, y: 0.41073358471897214d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09735495816157447d, y: 0.04189636401976449d), new NpgsqlTypes.NpgsqlPoint(x: 0.09646842267290545d, y: 0.7393918700792564d), new NpgsqlTypes.NpgsqlPoint(x: 0.3694555787797329d, y: 0.19798654536271565d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.901313386408918d, y: 0.3746317504654302d), new NpgsqlTypes.NpgsqlPoint(x: 0.8736594410135331d, y: 0.8742179472179759d), new NpgsqlTypes.NpgsqlPoint(x: 0.9369389908800354d, y: 0.7063732275652073d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9457745410872005d, y: 0.02498843281099017d), new NpgsqlTypes.NpgsqlPoint(x: 0.5662416322327567d, y: 0.5630239004610181d), new NpgsqlTypes.NpgsqlPoint(x: 0.16337450032188117d, y: 0.06809523034374287d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11679829598834524d, y: 0.6066429136880329d), new NpgsqlTypes.NpgsqlPoint(x: 0.5238476993873868d, y: 0.6252394393407419d), new NpgsqlTypes.NpgsqlPoint(x: 0.9957776106766512d, y: 0.9547220217051494d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7975598036542837d, y: 0.4086513348227485d), new NpgsqlTypes.NpgsqlPoint(x: 0.854206326216813d, y: 0.1227608751329835d), new NpgsqlTypes.NpgsqlPoint(x: 0.6055871796332781d, y: 0.19633416517323243d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13792462084757406d, y: 0.5311474045324841d), new NpgsqlTypes.NpgsqlPoint(x: 0.6510436654467978d, y: 0.9120048729463521d), new NpgsqlTypes.NpgsqlPoint(x: 0.9145470374384007d, y: 0.2584683852596197d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1861804266530287d, y: 0.9526476811071442d), new NpgsqlTypes.NpgsqlPoint(x: 0.8199620707341783d, y: 0.7825129684643936d), new NpgsqlTypes.NpgsqlPoint(x: 0.8858116924266716d, y: 0.3991272774368485d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5856895047019787d, y: 0.4941232130194614d), new NpgsqlTypes.NpgsqlPoint(x: 0.7551811480587942d, y: 0.5701805539516037d), new NpgsqlTypes.NpgsqlPoint(x: 0.8506930947538663d, y: 0.7843889453938313d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7554206274404364d, y: 0.8641497877216959d), new NpgsqlTypes.NpgsqlPoint(x: 0.2090092508260123d, y: 0.561403819447754d), new NpgsqlTypes.NpgsqlPoint(x: 0.2358803716137745d, y: 0.16687907032558036d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10344970789510843d, y: 0.3211072391447154d), new NpgsqlTypes.NpgsqlPoint(x: 0.7312408161740614d, y: 0.36855064042022634d), new NpgsqlTypes.NpgsqlPoint(x: 0.017065927306880058d, y: 0.418809620732827d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12299684017818224d, y: 0.5071738937604239d), new NpgsqlTypes.NpgsqlPoint(x: 0.6186355555770221d, y: 0.7148309309805161d), new NpgsqlTypes.NpgsqlPoint(x: 0.6256104566110502d, y: 0.012902606060347765d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5030074242586149d, y: 0.2918177159438389d), new NpgsqlTypes.NpgsqlPoint(x: 0.4089230693422906d, y: 0.8865863989711268d), new NpgsqlTypes.NpgsqlPoint(x: 0.4964933296419157d, y: 0.5201421293797369d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9522090483695927d, y: 0.5185854808561042d), new NpgsqlTypes.NpgsqlPoint(x: 0.6315876435213204d, y: 0.691203266025115d), new NpgsqlTypes.NpgsqlPoint(x: 0.0578382429947949d, y: 0.10216904539827143d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8921241552160338d, y: 0.9869697228384763d), new NpgsqlTypes.NpgsqlPoint(x: 0.36541029966282934d, y: 0.2997592145315622d), new NpgsqlTypes.NpgsqlPoint(x: 0.26152860445381954d, y: 0.6377873689103072d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3651796999844916d, y: 0.18919620223328326d), new NpgsqlTypes.NpgsqlPoint(x: 0.6130683369163387d, y: 0.6891382719169757d), new NpgsqlTypes.NpgsqlPoint(x: 0.3758822231252126d, y: 0.7448325831617927d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5720671724639389d, y: 0.31771882807994123d), new NpgsqlTypes.NpgsqlPoint(x: 0.7247173709482814d, y: 0.60601526627105d), new NpgsqlTypes.NpgsqlPoint(x: 0.36131498524269046d, y: 0.07181047878627622d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6099903053726099d, y: 0.41139468448168737d), new NpgsqlTypes.NpgsqlPoint(x: 0.8680838320292315d, y: 0.822654556980615d), new NpgsqlTypes.NpgsqlPoint(x: 0.8809797325729131d, y: 0.6814807173202698d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.915130299076319d, y: 0.3275401367100934d), new NpgsqlTypes.NpgsqlPoint(x: 0.18403868153246683d, y: 0.622731885083837d), new NpgsqlTypes.NpgsqlPoint(x: 0.6598285734708323d, y: 0.0901370469685705d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13113712547529155d, y: 0.19821603201909055d), new NpgsqlTypes.NpgsqlPoint(x: 0.0678732854530959d, y: 0.021289526393377667d), new NpgsqlTypes.NpgsqlPoint(x: 0.5355300017989454d, y: 0.5480544668925602d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.032310331271165005d, y: 0.4864553443662478d), new NpgsqlTypes.NpgsqlPoint(x: 0.5170921031959523d, y: 0.40924211570770885d), new NpgsqlTypes.NpgsqlPoint(x: 0.12754250621344088d, y: 0.20858583437097356d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7364840319833332d, y: 0.3074605141046186d), new NpgsqlTypes.NpgsqlPoint(x: 0.34172748782437423d, y: 0.7210479204225738d), new NpgsqlTypes.NpgsqlPoint(x: 0.24901659074440596d, y: 0.6620510623050588d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7375985596024306d, y: 0.11120443704739202d), new NpgsqlTypes.NpgsqlPoint(x: 0.06938311253360119d, y: 0.3550606589366839d), new NpgsqlTypes.NpgsqlPoint(x: 0.005291705532171398d, y: 0.6420381897912953d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44529362856567245d, y: 0.23765321397045014d), new NpgsqlTypes.NpgsqlPoint(x: 0.6900514716930605d, y: 0.8616040317835498d), new NpgsqlTypes.NpgsqlPoint(x: 0.07020560077037796d, y: 0.49910512148300423d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9539355191098822d, y: 0.03291717921231796d), new NpgsqlTypes.NpgsqlPoint(x: 0.1049609296095948d, y: 0.5966870541927642d), new NpgsqlTypes.NpgsqlPoint(x: 0.7668079573853277d, y: 0.554395365126339d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4809858010846212d, y: 0.039085721802331386d), new NpgsqlTypes.NpgsqlPoint(x: 0.5371337097097032d, y: 0.9421698635240514d), new NpgsqlTypes.NpgsqlPoint(x: 0.7990484232018499d, y: 0.9011098575014861d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5306385820810345d, y: 0.8647241087454319d), new NpgsqlTypes.NpgsqlPoint(x: 0.29323531390697777d, y: 0.36551194398655584d), new NpgsqlTypes.NpgsqlPoint(x: 0.9845844077800294d, y: 0.8311921187485932d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0014417537186971474d, y: 0.8236788048178065d), new NpgsqlTypes.NpgsqlPoint(x: 0.09093629894038491d, y: 0.13872552888265322d), new NpgsqlTypes.NpgsqlPoint(x: 0.7885908905292468d, y: 0.6110769049972833d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24752031108192596d, y: 0.4233276744220821d), new NpgsqlTypes.NpgsqlPoint(x: 0.5351236466306523d, y: 0.8546877019329719d), new NpgsqlTypes.NpgsqlPoint(x: 0.5166295500546859d, y: 0.8342500954436939d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07781947766290809d, y: 0.33041873218510975d), new NpgsqlTypes.NpgsqlPoint(x: 0.18640870139031285d, y: 0.10603824673497841d), new NpgsqlTypes.NpgsqlPoint(x: 0.9727625528153103d, y: 0.8403004089063131d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7962125500995223d, y: 0.08132255357798313d), new NpgsqlTypes.NpgsqlPoint(x: 0.8472565459635012d, y: 0.40897432660234434d), new NpgsqlTypes.NpgsqlPoint(x: 0.4792779256241325d, y: 0.7722022005987135d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5686293744056509d, y: 0.42471850209897966d), new NpgsqlTypes.NpgsqlPoint(x: 0.046218784607368724d, y: 0.7845850118751052d), new NpgsqlTypes.NpgsqlPoint(x: 0.12322990640364906d, y: 0.8419054849169626d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4010089315173928d, y: 0.15034049682086548d), new NpgsqlTypes.NpgsqlPoint(x: 0.23538177699098162d, y: 0.6068992623180784d), new NpgsqlTypes.NpgsqlPoint(x: 0.20937470678138514d, y: 0.3153016328299778d)),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray2mi(
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray2mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>), 
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

                changedRows =  ((INpgsqlPolygonListpolygonArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonListpolygonArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray2mi_id
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonarray2mi_id", 
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
                changedRows =  ((INpgsqlPolygonListpolygonArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPolygonListpolygonArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPolygonListpolygonArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPolygonListpolygonArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray2mi_id
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
    npgsqlpolygonpolygonarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray2mi_id
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
    npgsqlpolygonpolygonarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonarray2mi_id", 
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
                List<NpgsqlPolygonpolygonArray2M> models = null;

                models =  ((INpgsqlPolygonListpolygonArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPolygonListpolygonArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPolygonListpolygonArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPolygonListpolygonArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonArray2M> models = null;

                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M), typeof(FlatNpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await ((INpgsqlPolygonListpolygonArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                ((INpgsqlPolygonListpolygonArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPolygonListpolygonArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPolygonListpolygonArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
                var models = await ((INpgsqlPolygonListpolygonArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPolygonListpolygonArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M), typeof(FlatNpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await ((INpgsqlPolygonListpolygonArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                ((INpgsqlPolygonListpolygonArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonListpolygonArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonListpolygonArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
                var models = await ((INpgsqlPolygonListpolygonArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPolygonListpolygonArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M), typeof(FlatNpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await((INpgsqlPolygonListpolygonArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                ((INpgsqlPolygonListpolygonArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[26], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[27], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[28], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[3], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[4], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[5], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[6], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[7], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[8], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[9], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[10], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[11], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[12], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[13], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[14], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[15], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[16], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[17], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[18], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[19], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[20], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[21], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[22], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[23], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[24], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[25], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[23],_testData[26], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[24],_testData[27], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[25],_testData[28], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[26],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[11], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[12], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[13], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[14], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[15], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[16], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[17], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[18], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[19], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[20], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[21], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[22], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[23], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[24], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[25], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[26], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[27], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[28], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[20], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[21], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[22], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[23], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[24], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[25], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[26], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[27], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[28], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
                var models = await((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[16], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[17], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[18], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[19], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[20], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[21], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[22], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[6], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[7], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[8], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[9], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[10], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[11], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[12], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[13], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[14], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[15], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[16], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[17], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[18], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[19], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[20], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[21], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[22], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[23],_testData[29], false);
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
                var models = ((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[8], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[9], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[10], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[11], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[12], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[13], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[14], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[15], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[16], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[17], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[18], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[19], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[20], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[21], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[22], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M), typeof(FlatNpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await((INpgsqlPolygonListpolygonArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                ((INpgsqlPolygonListpolygonArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 76, query1, 54, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[15], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[16], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[17], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[18], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[19], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[20], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[21], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[22], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[23], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[24], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[25], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[26], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[27], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[28], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[11], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[12], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[13], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[14], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[15], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[16], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[17], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[18], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[19], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[20], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[21], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[22], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[23], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[24], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[25], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[26], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[27], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[28], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelBatch(connection, 139, query1, 114, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[27], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[28], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[23], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[24], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[25], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[26], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[27], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[28], false);FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
                var models = await((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelBatchAsync(connection, 15, 77))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[3], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[4], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[5], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[6], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[7], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[8], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[9], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[10], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[11], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[12], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[13], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[14], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[15], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[16], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[17], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[18], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[19], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[20], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[21], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[22], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[23],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[24],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[25],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[16], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[17], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[18], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[19], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[20], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[21], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[22], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[29], false);
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
                var models = ((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelBatch(connection, 54, 139))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[11], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[12], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[13], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[14], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[15], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[16], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[17], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[18], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[19], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[20], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[21], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[22], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPolygonListpolygonArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPolygonListpolygonArray)this).SetDbConnectionSelectModelParametrs(cmd, 142);
                var models = await ((INpgsqlPolygonListpolygonArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(2));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonListpolygonArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonListpolygonArray)this).SetDbConnectionSelectModelParametrs(cmd, 138);
                var models =  ((INpgsqlPolygonListpolygonArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(4));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2MI)],
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
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
FROM public.binary_npgsqlpolygonpolygonarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPolygonpolygonArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPolygonListpolygonArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonListpolygonArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPolygonListpolygonArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPolygonListpolygonArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygonarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
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
FROM public.binary_npgsqlpolygonpolygonarray2m m
LEFT JOIN public.binary_npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPolygonpolygonArray2M>(15);

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
                ((INpgsqlPolygonListpolygonArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonListpolygonArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPolygonListpolygonArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPolygonListpolygonArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[14], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[15], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[16], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[17], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[18], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[19], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[20], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[21], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[22], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[23],_testData[23], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[24],_testData[24], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[25],_testData[25], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[26],_testData[26], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[27],_testData[27], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[28],_testData[28], false);
                NpgsqlPolygonpolygonArray2M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygonarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonListpolygonArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonListpolygonArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2MI)],
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonListpolygonArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonListpolygonArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

