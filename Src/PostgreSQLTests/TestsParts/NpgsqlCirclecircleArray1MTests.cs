

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
    internal partial interface INpgsqlCircleArraycircleArray
    {
    }
    
    internal partial class NpgsqlCircleArraycircleArray : INpgsqlCircleArraycircleArray
    {


#region TestData

        private readonly NpgsqlCirclecircleArray1M[] _testData = new NpgsqlCirclecircleArray1M[]
        {
            new NpgsqlCirclecircleArray1M
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6892235880303084d, y: 0.334019479499292d), radius: 0.9195438088217036d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8658067262467251d, y: 0.6503108691618243d), radius: 0.7360469626109059d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49060386653468924d, y: 0.7637770891975599d), radius: 0.6418794118547032d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06329399158168969d, y: 0.9645599432441057d), radius: 0.5707975969417174d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4372093019717015d, y: 0.30057252344592655d), radius: 0.9746214036886224d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23751219108531707d, y: 0.5462784185460142d), radius: 0.36453377836867007d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1582506814017306d, y: 0.9267014314743881d), radius: 0.6563775292297263d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4923973877948231d, y: 0.3830436791508307d), radius: 0.8890230156533804d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3984104885702472d, y: 0.31014335945446647d), radius: 0.11987046030879245d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27012145363763707d, y: 0.45696024681627656d), radius: 0.10373913495951714d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.030001733884333692d, y: 0.5963302750528542d), radius: 0.3961482789846388d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25603423008902293d, y: 0.5477846587978811d), radius: 0.09328244395595042d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33551654240179285d, y: 0.7162024585916065d), radius: 0.8508866566757541d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3060028848991402d, y: 0.9457652952744457d), radius: 0.9589038268428683d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9522768335353317d, y: 0.5158327080938979d), radius: 0.1347529579674266d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3914883976007144d, y: 0.43349466178230844d), radius: 0.21108082788306803d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6059837512261188d, y: 0.2196958445033378d), radius: 0.4325702565435574d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3398365755056644d, y: 0.37889212947235773d), radius: 0.29501412776496494d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40806485496850664d, y: 0.38141943420856894d), radius: 0.8128161914271415d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18144333230295173d, y: 0.24173410833999176d), radius: 0.6269000445334343d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5802921318075477d, y: 0.2284476303510654d), radius: 0.3380552676442261d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9303275340827499d, y: 0.42930800929898494d), radius: 0.49751533481334764d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23216296877048748d, y: 0.37317736447967065d), radius: 0.04320542822418849d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07818050856639336d, y: 0.20647918107394625d), radius: 0.7949380199109771d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7476078640312611d, y: 0.8357850850413006d), radius: 0.11689447563788158d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28380053860894683d, y: 0.49218673163853344d), radius: 0.2596385537536334d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7884050206557922d, y: 0.9181828952248582d), radius: 0.21338963430535385d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5254690993273589d, y: 0.7335067204126619d), radius: 0.3668240424471968d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25163498592250444d, y: 0.30255363586299666d), radius: 0.573458576774503d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9185171208255744d, y: 0.44124040074737236d), radius: 0.5688190611193257d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6547059659603454d, y: 0.19055661022806092d), radius: 0.1660795466184657d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6046730683617081d, y: 0.9318621786906705d), radius: 0.8036082069594349d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34265317910923665d, y: 0.767718827047818d), radius: 0.2592689185748246d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14150056568314096d, y: 0.12399009516774762d), radius: 0.0435213495645872d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6750471535367918d, y: 0.45838219134867175d), radius: 0.6291042572628528d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3314483522666196d, y: 0.7442698252542892d), radius: 0.4134183458765074d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7117996876699585d, y: 0.6815682024193765d), radius: 0.10266815388928974d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7052740385996674d, y: 0.4640309665299853d), radius: 0.14543160609123307d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26199553748559556d, y: 0.14915368648468108d), radius: 0.5269504472640691d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1176569179853888d, y: 0.6718930589457606d), radius: 0.5943998854456383d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8433605710201277d, y: 0.9654148351457527d), radius: 0.7657830967294371d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08947138196154358d, y: 0.8862092818675817d), radius: 0.4572509962557215d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.987081556165269d, y: 0.4041753896775334d), radius: 0.7132440183133332d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5697228331372577d, y: 0.9476114581233595d), radius: 0.1804735914434913d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4119974178607254d, y: 0.40681589573600674d), radius: 0.4878857178749465d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5360622392096249d, y: 0.43349282807327105d), radius: 0.7961874578584595d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1604038823379379d, y: 0.34831413422167956d), radius: 0.4751262035760552d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33461205840577424d, y: 0.31067750153233376d), radius: 0.10047242852236127d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3360431877466802d, y: 0.7538883458610537d), radius: 0.17328358597536464d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6304050447300893d, y: 0.5936540731655877d), radius: 0.04354641641747947d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.905203426858925d, y: 0.5991109864542663d), radius: 0.6171532644765796d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06207745212063476d, y: 0.30757224974236264d), radius: 0.5663060930371073d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3930964604057353d, y: 0.9986455555426061d), radius: 0.30272100341471486d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.732894819857719d, y: 0.5444081951990982d), radius: 0.20899005420647032d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.738306480485414d, y: 0.5497153454806127d), radius: 0.4973422444287413d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.603104183432048d, y: 0.4274311980107739d), radius: 0.05561760336695931d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5347772286029933d, y: 0.12145831553451147d), radius: 0.9236799260722757d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3114284175076849d, y: 0.8835778944242718d), radius: 0.04372393034227107d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7700622821101538d, y: 0.24064093327832126d), radius: 0.6533275478616499d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8829202326190514d, y: 0.8175416182381756d), radius: 0.02181341832485917d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6751074147242903d, y: 0.1518969696747432d), radius: 0.49406592477660216d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0566438856860092d, y: 0.22222150555924436d), radius: 0.6601373008832827d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2243539346315373d, y: 0.7120304705929706d), radius: 0.6900419442823739d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5644290208360347d, y: 0.38696140525167577d), radius: 0.18380449023724021d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6667660482480156d, y: 0.8160913165988161d), radius: 0.4684636541306636d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7259613080171935d, y: 0.5992908605164325d), radius: 0.9054902080078097d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.898679218363003d, y: 0.8487647827200452d), radius: 0.673583523430099d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6303430432574957d, y: 0.4456614679388833d), radius: 0.42204341650088506d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19119251081219524d, y: 0.28191024103333717d), radius: 0.09475087166355023d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6510139010507859d, y: 0.9258768846462426d), radius: 0.4793041813595722d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9049653221810078d, y: 0.8358820787222075d), radius: 0.8969000512901412d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.715706685230353d, y: 0.717542030344689d), radius: 0.07982099128031617d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.814886775512648d, y: 0.88642764763223d), radius: 0.04449325849985353d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2633926207558803d, y: 0.6230045088337676d), radius: 0.2044780818910007d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47136593653743d, y: 0.7950566836103015d), radius: 0.005899760070968485d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4885593387614049d, y: 0.19461011612519719d), radius: 0.04489254881357285d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19971417016227588d, y: 0.8355640886883245d), radius: 0.015151034512251749d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8066195126208378d, y: 0.3414423397751688d), radius: 0.5803006837607476d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26676702062397406d, y: 0.09277431465809349d), radius: 0.12826805896619675d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21228203271253088d, y: 0.7201585200550923d), radius: 0.49209580487551063d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09754788950280235d, y: 0.3530420019667061d), radius: 0.9906360832978351d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3129445403204383d, y: 0.16363680704613826d), radius: 0.04488632641887258d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7284028484022078d, y: 0.28816476458423346d), radius: 0.26688674837702964d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9541899375760245d, y: 0.9181819856579296d), radius: 0.5154266704461319d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8886719283350102d, y: 0.8853320392846182d), radius: 0.8858580125410205d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7855542159580864d, y: 0.9836421946036025d), radius: 0.7420997876158111d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9888223426110622d, y: 0.43878073115289384d), radius: 0.33484932560145986d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28956499761398513d, y: 0.05460214520489237d), radius: 0.693142976501886d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5376095930736391d, y: 0.20368953721352911d), radius: 0.39600388674422937d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04583262318217207d, y: 0.145186004374536d), radius: 0.5381089820353235d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6497028432619625d, y: 0.8153071167874765d), radius: 0.8673104092307371d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.058830930052649166d, y: 0.4300268743909096d), radius: 0.3613524290599436d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3096016873905827d, y: 0.6300263659909466d), radius: 0.8359705409382877d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9928620941976958d, y: 0.025010335641873715d), radius: 0.8088605168558364d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8405766683815498d, y: 0.2877250355901926d), radius: 0.4458561810466003d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1580523294113957d, y: 0.18111658154158639d), radius: 0.34387506535054635d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11328373330508579d, y: 0.06961072828481984d), radius: 0.7917635579642336d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5163060205697448d, y: 0.8434260870599826d), radius: 0.16678665672184068d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16462518473440702d, y: 0.10175873740716834d), radius: 0.0007126106804820065d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1658893380065305d, y: 0.25250999842911115d), radius: 0.18218395523788866d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6097571778892914d, y: 0.8446753692748252d), radius: 0.6387056461984472d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2370506687985302d, y: 0.18289481718607636d), radius: 0.5622837345571255d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6545051443520757d, y: 0.6386747743485741d), radius: 0.5974243901785694d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4108762567725359d, y: 0.7798091366070078d), radius: 0.6452362108452793d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42426811631081074d, y: 0.19717568787118667d), radius: 0.22185932558544275d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8169362354600241d, y: 0.24341626586943477d), radius: 0.10379679986267076d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3651181625441162d, y: 0.14320736105214404d), radius: 0.40576014165260843d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4026846898574654d, y: 0.1714191181573652d), radius: 0.34159361760656803d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5345340692946556d, y: 0.135684118120332d), radius: 0.123639865522843d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17865386037487085d, y: 0.11058085826512587d), radius: 0.44055688530089365d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8901173393682092d, y: 0.13939554144719624d), radius: 0.5941029179653503d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2571239670232284d, y: 0.4084452438018511d), radius: 0.9397050309919065d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.602823279753419d, y: 0.753051925499649d), radius: 0.8185320597975201d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.947376546530941d, y: 0.8736511877596248d), radius: 0.17616690373714672d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9732430102362261d, y: 0.48435000043542764d), radius: 0.16901234767248297d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3450047568019212d, y: 0.34450425494709325d), radius: 0.5223594602544865d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6529054871724118d, y: 0.9232051819528809d), radius: 0.8597881885215155d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10618090255556234d, y: 0.997076016838155d), radius: 0.3306905233380941d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5169092081752416d, y: 0.9646689144717452d), radius: 0.52610595580325d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23817650116228428d, y: 0.9027016933468918d), radius: 0.8532237472260619d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23639146057901106d, y: 0.2205584196537208d), radius: 0.578062845253637d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06798264968278056d, y: 0.6380926130860342d), radius: 0.5289185243394346d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22416119440072635d, y: 0.695410303784983d), radius: 0.22533593209748692d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9686911102670531d, y: 0.5592843402504648d), radius: 0.15531069028734112d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5505674655615426d, y: 0.7074256703933891d), radius: 0.30066530019966d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.758780839067041d, y: 0.29833921148378273d), radius: 0.9933674015313915d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7323514318746589d, y: 0.9004819255815025d), radius: 0.40012233400346564d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3656278335844333d, y: 0.5942463726538681d), radius: 0.2028092128493404d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9408075433823272d, y: 0.8180299452351661d), radius: 0.36411487803765386d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.568199869880367d, y: 0.11072764708774774d), radius: 0.04363406100110634d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8586070696382234d, y: 0.4316895303888595d), radius: 0.19350798663947166d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04457883815606101d, y: 0.21674582625950867d), radius: 0.802725609657966d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9077286894362389d, y: 0.9119606835575403d), radius: 0.2705438121348547d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2650233900400717d, y: 0.7874293663311551d), radius: 0.6997487462778867d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34144726791445823d, y: 0.17548332916101483d), radius: 0.7188469550529861d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6446417980409279d, y: 0.5916818445432598d), radius: 0.14904243812971818d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19013410581793533d, y: 0.09447296537039518d), radius: 0.6997516224801995d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.74422620281891d, y: 0.18282940188790464d), radius: 0.42552817374439855d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.647679033235722d, y: 0.7022711460043087d), radius: 0.8232838603632989d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4467777037516233d, y: 0.5901698100785472d), radius: 0.5741632102980584d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4391452201905467d, y: 0.9505345636692292d), radius: 0.8596864521040439d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8400864289521176d, y: 0.375763262882988d), radius: 0.060491778005784536d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10372446775945521d, y: 0.1795083200186426d), radius: 0.8129468496029985d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8903921901068057d, y: 0.12165927090906958d), radius: 0.8463451291432817d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3444598295866177d, y: 0.6962808958971989d), radius: 0.6757267398123061d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6187989622253037d, y: 0.44162041334008095d), radius: 0.06236489272276935d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3091645771903061d, y: 0.29797686171653137d), radius: 0.16110343672533134d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30303792097111515d, y: 0.4393462133272844d), radius: 0.10243341599041589d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4744241039329068d, y: 0.556225029071189d), radius: 0.4173503916088891d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5169299839270293d, y: 0.51982134181656d), radius: 0.922465281269972d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09978830200876787d, y: 0.30647753889934926d), radius: 0.8544922905076687d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7248322594475951d, y: 0.737230301411264d), radius: 0.03523016510617083d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4432267086630274d, y: 0.5575027652795769d), radius: 0.8726352713441621d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7449842214297023d, y: 0.7088317335444123d), radius: 0.21065875295986336d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09165974894170181d, y: 0.94186168731973d), radius: 0.27536197728338696d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7731891750619899d, y: 0.29117261468482836d), radius: 0.8690792367144609d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7903804069211288d, y: 0.054506742459328406d), radius: 0.5309639780153457d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5651987442930486d, y: 0.9200838160332774d), radius: 0.7509257141984529d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7629071174295874d, y: 0.22012020835362123d), radius: 0.1180639211514698d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0593353119140253d, y: 0.817126376122953d), radius: 0.660779248396972d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5298251873643051d, y: 0.8559697778386425d), radius: 0.5682763282103731d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9068802282747255d, y: 0.6812778210639071d), radius: 0.5957482794223606d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0008416527316618128d, y: 0.24210821018034456d), radius: 0.34810470138522587d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35974735766003874d, y: 0.18064530409723856d), radius: 0.021965663245652967d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8865870741818792d, y: 0.09806488883314324d), radius: 0.43899076493686184d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10838688644697902d, y: 0.7963079685668691d), radius: 0.628129347630434d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4135588670392052d, y: 0.24801056614052552d), radius: 0.2601821219052515d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9472273773681622d, y: 0.4476328830904981d), radius: 0.8080093281305056d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6331209099623571d, y: 0.4829366489502076d), radius: 0.21417671043994135d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05148084722916346d, y: 0.901043336323588d), radius: 0.07071085977444624d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7871010190421881d, y: 0.05578107327540982d), radius: 0.49857271161843575d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22792817168063162d, y: 0.865449237693405d), radius: 0.19805994277783168d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 103,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.545495524442798d, y: 0.9331197686750415d), radius: 0.07745191986722966d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08499958641829375d, y: 0.3707580877477674d), radius: 0.9197013340403014d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.465730560251712d, y: 0.07911331310018876d), radius: 0.08064535954263474d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8143401214505919d, y: 0.872440512978915d), radius: 0.4118368980989948d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5345831364686893d, y: 0.5579759000613553d), radius: 0.23792767013687088d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9351641383561142d, y: 0.3248571812114037d), radius: 0.1615345135110431d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5440181515933502d, y: 0.7504212509172098d), radius: 0.5723186922914313d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9722697051088347d, y: 0.39310361066091803d), radius: 0.8887115086757522d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.00798086127823161d, y: 0.1538252130016704d), radius: 0.6183249962295658d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6409154881279776d, y: 0.8305881441577788d), radius: 0.14807856611520642d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8383855911672146d, y: 0.21234711722175392d), radius: 0.9672809873127105d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7186342158656427d, y: 0.6760111822480294d), radius: 0.8580224597179457d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02345301185804638d, y: 0.2880716104473946d), radius: 0.8877670889841013d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 106,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30399047943544466d, y: 0.6123021994552973d), radius: 0.5459992464857517d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6517435823245631d, y: 0.7632268546375024d), radius: 0.680155645388773d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6709452283896915d, y: 0.8941650881676937d), radius: 0.781232653011872d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6642109362761638d, y: 0.4391342269612284d), radius: 0.9196953822158068d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5194195821893813d, y: 0.35755876794530006d), radius: 0.11311183959846038d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4912464420923357d, y: 0.3342334357010672d), radius: 0.1491294968059853d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10048911929293702d, y: 0.25725331484875313d), radius: 0.6226455364447051d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5068787367664033d, y: 0.8791870906423079d), radius: 0.08364275578923153d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9973597587665721d, y: 0.6390576730701739d), radius: 0.5295383068196872d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9147280954255143d, y: 0.22302383183712293d), radius: 0.47501925358640296d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9398775611906873d, y: 0.09574546760483249d), radius: 0.9100349952773479d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7835890155354808d, y: 0.7293341144602975d), radius: 0.7916849385370615d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5245860584702812d, y: 0.029124028185800177d), radius: 0.8091573449027213d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4203666470046551d, y: 0.1731919138076401d), radius: 0.6625146444051835d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 120,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.724001298531882d, y: 0.6176206877410467d), radius: 0.4166621093871459d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8057824458460097d, y: 0.41060089437880076d), radius: 0.6602771880758697d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17322769377942804d, y: 0.8635294568461561d), radius: 0.5260968463301361d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23665854661466446d, y: 0.585880636668298d), radius: 0.4941089331813193d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 129,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4194789996207142d, y: 0.12522439772834582d), radius: 0.8810123038849172d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22295486450980795d, y: 0.37301098164901125d), radius: 0.4484152024270628d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.012273080027187078d, y: 0.1555874559969198d), radius: 0.024162611899201658d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6082140574485848d, y: 0.5636263176609584d), radius: 0.892273548867148d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23243616149489543d, y: 0.3922131842548088d), radius: 0.5975395946880897d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07218358219450882d, y: 0.3555184694957845d), radius: 0.19327287288187323d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11182997679858364d, y: 0.7182511185920161d), radius: 0.886980695506263d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7323362381227297d, y: 0.3082767614272838d), radius: 0.6896876631052129d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05575907656418333d, y: 0.7340579871087811d), radius: 0.16590129913727047d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6298128166860645d, y: 0.6081858811204852d), radius: 0.38380902410145135d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 136,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31102980587182016d, y: 0.6738135903383434d), radius: 0.054248188333886116d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7330647222120082d, y: 0.5852993507483337d), radius: 0.9743920477856965d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6555227859708107d, y: 0.6060401800095497d), radius: 0.3062107485311142d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 142,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2766138141114648d, y: 0.11927482131895462d), radius: 0.38366045625696665d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4115450331506756d, y: 0.949361838457196d), radius: 0.7139021882660864d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8856809702497372d, y: 0.8040250657759785d), radius: 0.4456556742218526d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.016363328760661044d, y: 0.7433863880733261d), radius: 0.878344950379811d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3717488838413717d, y: 0.06887229078525459d), radius: 0.13827519458312643d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43271982606690806d, y: 0.5993669483276662d), radius: 0.27229485856505564d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9548654885561024d, y: 0.10976763363134412d), radius: 0.9041581895139923d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24932627108696337d, y: 0.9964097427285871d), radius: 0.08352113164589514d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4937003771836782d, y: 0.9429157569611609d), radius: 0.8842277098780708d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.536527043480291d, y: 0.7631199774354589d), radius: 0.1480606051612552d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8314746069877186d, y: 0.17355788092181224d), radius: 0.08559581016250317d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 143,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6773544662493107d, y: 0.3146310945885107d), radius: 0.6750386406381208d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17035623691005863d, y: 0.19495812370182597d), radius: 0.8272288086244975d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9222785304073607d, y: 0.7250265881540566d), radius: 0.7610505855363204d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9554497307092227d, y: 0.19730953893748893d), radius: 0.7594452128548527d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1574974495829493d, y: 0.8236699621038335d), radius: 0.24977069092496818d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7095202287690012d, y: 0.3752683398931117d), radius: 0.5373678864251695d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 147,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2117514158413396d, y: 0.1637086756443893d), radius: 0.5445177912496201d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21324538775518576d, y: 0.7264983991286649d), radius: 0.3219844132620924d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8017879304685351d, y: 0.4296918966983605d), radius: 0.5110760452290429d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4320206356807722d, y: 0.7043110274171155d), radius: 0.2668019537392542d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9042891624500453d, y: 0.22464446244965874d), radius: 0.963959090998272d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4654017342108977d, y: 0.5088628936765799d), radius: 0.8173405352221488d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8284268381244931d, y: 0.6390462463639847d), radius: 0.3972156427342145d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6349723641302701d, y: 0.8023991291341218d), radius: 0.7496261808293989d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25878557340890473d, y: 0.004945961949144095d), radius: 0.21786666368945096d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9844693773349189d, y: 0.04556622888368411d), radius: 0.4769494645682846d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09065232090705722d, y: 0.49388463127140003d), radius: 0.12973933479144517d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7499788614367859d, y: 0.6174736179898666d), radius: 0.7769635328687498d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5575338652877776d, y: 0.8790300201601087d), radius: 0.1819061629500497d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31952876532761565d, y: 0.1686328026909697d), radius: 0.2606370288219996d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1513203407938889d, y: 0.9018331687918835d), radius: 0.9203270904971795d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4809427817846109d, y: 0.29105040499404833d), radius: 0.6158793577977547d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 156,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.770502626273349d, y: 0.027892383770170448d), radius: 0.6073716721950041d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3556578406551437d, y: 0.2496185933427052d), radius: 0.4949297080221815d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7303637185553272d, y: 0.9207049862079105d), radius: 0.9521909907566791d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8315821015072742d, y: 0.8460908656985157d), radius: 0.9878566404931973d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10448854678757147d, y: 0.6826905643461844d), radius: 0.9963784453079538d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3309092448883657d, y: 0.09350314437094975d), radius: 0.8238352679145224d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27354399434531873d, y: 0.04469873923809664d), radius: 0.721111596220112d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 162,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1554015131531694d, y: 0.38263194188012284d), radius: 0.03209827252820041d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5252603699364689d, y: 0.4115756092175361d), radius: 0.6486535053167747d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8946015571672167d, y: 0.47505276616321923d), radius: 0.9502027526664939d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16091896472131273d, y: 0.8690559658218349d), radius: 0.707990005683644d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5770523230068773d, y: 0.15069868574600498d), radius: 0.5236049595312853d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6975485457986884d, y: 0.8528905509413455d), radius: 0.13919396577252463d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.047116328152546294d, y: 0.741807450161136d), radius: 0.3730424299341524d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6876925150054318d, y: 0.21152669956087056d), radius: 0.06849993704861679d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43859181017135285d, y: 0.19351701674419353d), radius: 0.6742654306346367d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20768017182444742d, y: 0.4995390895245243d), radius: 0.7049511317509698d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3999923747994937d, y: 0.04273105770582031d), radius: 0.14503326110131443d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7816481729125229d, y: 0.26754045955501193d), radius: 0.8590276191998412d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6949415298778295d, y: 0.3303996732633113d), radius: 0.6256791787658145d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8298723239549782d, y: 0.1501134146590647d), radius: 0.8860838100171419d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5337476974207124d, y: 0.925514621080042d), radius: 0.46802296823652556d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 171,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5885876468221342d, y: 0.8570583965223113d), radius: 0.9838474453403148d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.91887302851127d, y: 0.7310088635100391d), radius: 0.8180973115696546d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.021631643594312577d, y: 0.3668220182777817d), radius: 0.39163169609242887d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6454273203021407d, y: 0.9980160364553808d), radius: 0.314523914935781d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06201075398807265d, y: 0.23518684861016648d), radius: 0.34597306712215425d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5078322410887574d, y: 0.42626649058120436d), radius: 0.34487834929980166d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4491210844484912d, y: 0.9049672646466812d), radius: 0.9425692789557201d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 177,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2402438056491274d, y: 0.6776930172067887d), radius: 0.04287020225741767d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.056586150154496195d, y: 0.22734437031625498d), radius: 0.8696428668135268d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5572604988750248d, y: 0.9750244353855714d), radius: 0.7928588523740469d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8162505100432635d, y: 0.31396114274652964d), radius: 0.9966474401738359d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8827900028203933d, y: 0.18771971170104484d), radius: 0.4585603942832398d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9887742222298088d, y: 0.17013540199395227d), radius: 0.9138743444638103d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5450010158603493d, y: 0.8372771972099201d), radius: 0.8085333980310533d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6815903049885143d, y: 0.5315752292451204d), radius: 0.5420841335103688d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4029426802006155d, y: 0.4781856890486882d), radius: 0.772220365143067d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3576107674215938d, y: 0.7158424780247308d), radius: 0.02070368823586899d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6587196586230653d, y: 0.5696391674499189d), radius: 0.162238667163896d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 179,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5409534243796917d, y: 0.1616317688816985d), radius: 0.08298079939187064d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18122438774619842d, y: 0.9565112603749869d), radius: 0.6275085623011547d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08881746855914474d, y: 0.9199130437735112d), radius: 0.12222144438111737d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9623660157576959d, y: 0.8399355019822293d), radius: 0.632973185792769d),
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1mi(
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1mi(
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
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
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

                changedRows =  ((INpgsqlCircleArraycircleArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleArraycircleArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray1mi_id
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclearray1mi_id", 
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
                changedRows =  ((INpgsqlCircleArraycircleArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlCircleArraycircleArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlCircleArraycircleArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlCircleArraycircleArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray1mi_id
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
    npgsqlcirclecirclearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8433605710201277d, y: 0.9654148351457527d), radius: 0.7657830967294371d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08947138196154358d, y: 0.8862092818675817d), radius: 0.4572509962557215d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.987081556165269d, y: 0.4041753896775334d), radius: 0.7132440183133332d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5697228331372577d, y: 0.9476114581233595d), radius: 0.1804735914434913d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06207745212063476d, y: 0.30757224974236264d), radius: 0.5663060930371073d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3930964604057353d, y: 0.9986455555426061d), radius: 0.30272100341471486d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.732894819857719d, y: 0.5444081951990982d), radius: 0.20899005420647032d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.738306480485414d, y: 0.5497153454806127d), radius: 0.4973422444287413d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8829202326190514d, y: 0.8175416182381756d), radius: 0.02181341832485917d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6751074147242903d, y: 0.1518969696747432d), radius: 0.49406592477660216d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0566438856860092d, y: 0.22222150555924436d), radius: 0.6601373008832827d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2243539346315373d, y: 0.7120304705929706d), radius: 0.6900419442823739d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray1mi_id
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
    npgsqlcirclecirclearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclearray1mi_id", 
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
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26676702062397406d, y: 0.09277431465809349d), radius: 0.12826805896619675d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21228203271253088d, y: 0.7201585200550923d), radius: 0.49209580487551063d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09754788950280235d, y: 0.3530420019667061d), radius: 0.9906360832978351d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3129445403204383d, y: 0.16363680704613826d), radius: 0.04488632641887258d),
}));
                nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4026846898574654d, y: 0.1714191181573652d), radius: 0.34159361760656803d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5345340692946556d, y: 0.135684118120332d), radius: 0.123639865522843d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17865386037487085d, y: 0.11058085826512587d), radius: 0.44055688530089365d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8901173393682092d, y: 0.13939554144719624d), radius: 0.5941029179653503d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleArray1M> models = null;

                models =  ((INpgsqlCircleArraycircleArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlCircleArraycircleArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlCircleArraycircleArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlCircleArraycircleArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleArray1M> models = null;

                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M), typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                ((INpgsqlCircleArraycircleArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlCircleArraycircleArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await ((INpgsqlCircleArraycircleArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M), typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                ((INpgsqlCircleArraycircleArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleArraycircleArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await ((INpgsqlCircleArraycircleArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlCircleArraycircleArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M), typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 136;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 162;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 61;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 156;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 171;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 94;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 106;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[34], false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[10], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[11], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[12], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[11], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[12], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M), typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 98, query1, 7, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 61, query1, 129, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 3, query1, 42, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 156, query1, 103, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 47, query1, 120, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 120, query1, 156, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 143, query1, 47, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelBatch(connection, 42, query1, 143, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelBatchAsync(connection, 156, 106))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[34], false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelBatch(connection, 162, 171))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[34], false);
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
                await using var cmd = await ((INpgsqlCircleArraycircleArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlCircleArraycircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 80);
                var models = await ((INpgsqlCircleArraycircleArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(17));

                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[18], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[19], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[20], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[21], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[22], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[23], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[24], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[25], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[26], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[27], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[28], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[29], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[30], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[31], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[32], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[33], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleArraycircleArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleArraycircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 156);
                var models =  ((INpgsqlCircleArraycircleArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(4));

                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[31], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[32], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[33], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[34], false);
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
FROM public.binary_npgsqlcirclecirclearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray1MIWA),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleArraycircleArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleArraycircleArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleArraycircleArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleArraycircleArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleArraycircleArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleArraycircleArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray1MI),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleArraycircleArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleArraycircleArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleArraycircleArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleArraycircleArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleArraycircleArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleArraycircleArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleArraycircleArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleArraycircleArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlcirclecirclearray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlCirclecircleArray1M),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
FROM public.binary_npgsqlcirclecirclearray1m m
LEFT JOIN public.binary_npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleArraycircleArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlCircleArraycircleArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleArraycircleArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleArraycircleArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlcirclecirclearray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models =  ((INpgsqlCircleArraycircleArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleArraycircleArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA), typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models1 = new List<NpgsqlCirclecircleArray1MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray1MIWA>();
                await ((INpgsqlCircleArraycircleArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray1MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray1MIWA>();
                ((INpgsqlCircleArraycircleArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
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
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
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
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA), typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
                var models1 = new List<NpgsqlCirclecircleArray1MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray1MIWA>();
                await ((INpgsqlCircleArraycircleArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray1MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray1MIWA>();
                ((INpgsqlCircleArraycircleArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
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
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
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
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclearray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI), typeof(NpgsqlCirclecircleArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models1 = new List<NpgsqlCirclecircleArray1MI>();
                var models2 = new List<NpgsqlCirclecircleArray1MI>();
                await ((INpgsqlCircleArraycircleArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray1MI>();
                var models2 = new List<NpgsqlCirclecircleArray1MI>();
                ((INpgsqlCircleArraycircleArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await ((INpgsqlCircleArraycircleArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclearray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA), typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
                var models1 = new List<NpgsqlCirclecircleArray1MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray1MIWA>();
                await ((INpgsqlCircleArraycircleArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray1MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray1MIWA>();
                ((INpgsqlCircleArraycircleArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
                var models = await ((INpgsqlCircleArraycircleArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

