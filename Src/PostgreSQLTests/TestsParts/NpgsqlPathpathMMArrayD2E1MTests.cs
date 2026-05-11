

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
    internal partial interface INpgsqlPathMArraypathMMArrayD2
    {
    }
    
    internal partial class NpgsqlPathMArraypathMMArrayD2 : INpgsqlPathMArraypathMMArrayD2
    {


#region TestData

        private readonly NpgsqlPathpathMMArrayD2E1M[] _testData = new NpgsqlPathpathMMArrayD2E1M[]
        {
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3443644976436374d, y: 0.29928804581205204d), new NpgsqlTypes.NpgsqlPoint(x: 0.6865105341314536d, y: 0.9618420205403684d), new NpgsqlTypes.NpgsqlPoint(x: 0.9778819281314365d, y: 0.5936714210523606d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8982324052135536d, y: 0.016485131917865048d), new NpgsqlTypes.NpgsqlPoint(x: 0.4541680460145159d, y: 0.9394351749750183d), new NpgsqlTypes.NpgsqlPoint(x: 0.9757656553688024d, y: 0.581271079141095d)), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31617833563022535d, y: 0.795140886341718d), new NpgsqlTypes.NpgsqlPoint(x: 0.9462013253564728d, y: 0.6731906219284812d), new NpgsqlTypes.NpgsqlPoint(x: 0.371924570026852d, y: 0.5219037342281073d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24046430697379761d, y: 0.64656787646974d), new NpgsqlTypes.NpgsqlPoint(x: 0.6880078518588458d, y: 0.7813765105032981d), new NpgsqlTypes.NpgsqlPoint(x: 0.36467859111845635d, y: 0.25619926948778127d)), } },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7230972296145554d, y: 0.8720706322166594d), new NpgsqlTypes.NpgsqlPoint(x: 0.45347426471923324d, y: 0.33792319673345583d), new NpgsqlTypes.NpgsqlPoint(x: 0.492956098116624d, y: 0.3296737297693807d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6689683251376312d, y: 0.30773704941602575d), new NpgsqlTypes.NpgsqlPoint(x: 0.25954640237890225d, y: 0.2598249830764865d), new NpgsqlTypes.NpgsqlPoint(x: 0.6194422698925675d, y: 0.6955584090020299d)), } },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2831739897861629d, y: 0.7639199073655303d), new NpgsqlTypes.NpgsqlPoint(x: 0.621552048457688d, y: 0.7645880465128443d), new NpgsqlTypes.NpgsqlPoint(x: 0.607546938516275d, y: 0.6282010387768806d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5573792754574884d, y: 0.9510426897034371d), new NpgsqlTypes.NpgsqlPoint(x: 0.3264999264280066d, y: 0.31432345119767147d), new NpgsqlTypes.NpgsqlPoint(x: 0.09760416751238443d, y: 0.15472905758218747d)), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8641100627873417d, y: 0.036637976115745374d), new NpgsqlTypes.NpgsqlPoint(x: 0.8407497763269157d, y: 0.7543871439486739d), new NpgsqlTypes.NpgsqlPoint(x: 0.8597821870634327d, y: 0.4247237584066482d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2070515057603315d, y: 0.894245618351406d), new NpgsqlTypes.NpgsqlPoint(x: 0.5276850489949461d, y: 0.16333539130549135d), new NpgsqlTypes.NpgsqlPoint(x: 0.18071289289382064d, y: 0.8079728717611401d)), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9476966844504767d, y: 0.6496499588339957d), new NpgsqlTypes.NpgsqlPoint(x: 0.9045304561070151d, y: 0.17207753000089265d), new NpgsqlTypes.NpgsqlPoint(x: 0.187154817676903d, y: 0.2559623388185467d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23512082242447685d, y: 0.8035598258366612d), new NpgsqlTypes.NpgsqlPoint(x: 0.4930386923141348d, y: 0.20985116857339292d), new NpgsqlTypes.NpgsqlPoint(x: 0.2829594558715348d, y: 0.01573735612251015d)), } },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2003512630905968d, y: 0.29627602254483054d), new NpgsqlTypes.NpgsqlPoint(x: 0.11968197964891747d, y: 0.6245530833245532d), new NpgsqlTypes.NpgsqlPoint(x: 0.4410418910845306d, y: 0.369433711320416d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33868097910269856d, y: 0.3190400147186706d), new NpgsqlTypes.NpgsqlPoint(x: 0.8961287499084012d, y: 0.22900006572154363d), new NpgsqlTypes.NpgsqlPoint(x: 0.2880598262233962d, y: 0.08164997433190047d)), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4720257160950554d, y: 0.7412184450676401d), new NpgsqlTypes.NpgsqlPoint(x: 0.7749219856357435d, y: 0.9491700173736027d), new NpgsqlTypes.NpgsqlPoint(x: 0.6187296573448607d, y: 0.5847092787129998d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6746207066298512d, y: 0.0030831234486567993d), new NpgsqlTypes.NpgsqlPoint(x: 0.19663283264466558d, y: 0.9014216790127162d), new NpgsqlTypes.NpgsqlPoint(x: 0.33470728148907003d, y: 0.10951416783585333d)), } },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0037920736388319387d, y: 0.6103334248030503d), new NpgsqlTypes.NpgsqlPoint(x: 0.2797848934933299d, y: 0.049762628441346934d), new NpgsqlTypes.NpgsqlPoint(x: 0.14058065917567508d, y: 0.3278968068416769d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07575306589150499d, y: 0.5514814884881492d), new NpgsqlTypes.NpgsqlPoint(x: 0.043398084894245015d, y: 0.17878064246273173d), new NpgsqlTypes.NpgsqlPoint(x: 0.8941776331853835d, y: 0.6800196770230783d)), } },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4959447700720011d, y: 0.3135007056403776d), new NpgsqlTypes.NpgsqlPoint(x: 0.42551975284383126d, y: 0.987694499121603d), new NpgsqlTypes.NpgsqlPoint(x: 0.44815271167281223d, y: 0.9528747535268617d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6453227827589612d, y: 0.11206053505171587d), new NpgsqlTypes.NpgsqlPoint(x: 0.4581715257184391d, y: 0.755632782378334d), new NpgsqlTypes.NpgsqlPoint(x: 0.18523160634423175d, y: 0.5103696901203517d)), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6267737203446341d, y: 0.5311213176521019d), new NpgsqlTypes.NpgsqlPoint(x: 0.4444123459261988d, y: 0.8450174065542652d), new NpgsqlTypes.NpgsqlPoint(x: 0.437817822225842d, y: 0.8139246202288178d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6905074191818202d, y: 0.6178979133235303d), new NpgsqlTypes.NpgsqlPoint(x: 0.5567950840178033d, y: 0.8451651142380072d), new NpgsqlTypes.NpgsqlPoint(x: 0.07746350940641977d, y: 0.5407751914307489d)), } },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4794844991558843d, y: 0.28677465874025254d), new NpgsqlTypes.NpgsqlPoint(x: 0.33239905678540227d, y: 0.9950808298390944d), new NpgsqlTypes.NpgsqlPoint(x: 0.6319466654969184d, y: 0.4497380506988464d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1704147897329471d, y: 0.7908880741697083d), new NpgsqlTypes.NpgsqlPoint(x: 0.34215498379265963d, y: 0.08081311614329167d), new NpgsqlTypes.NpgsqlPoint(x: 0.6037395122914706d, y: 0.6613031444236581d)), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7238675917981316d, y: 0.6908962200806387d), new NpgsqlTypes.NpgsqlPoint(x: 0.16040808372281778d, y: 0.3389693498677343d), new NpgsqlTypes.NpgsqlPoint(x: 0.9986916271690462d, y: 0.3318064800066658d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6168850579470941d, y: 0.9375389321793569d), new NpgsqlTypes.NpgsqlPoint(x: 0.9094720903958213d, y: 0.5118414974419209d), new NpgsqlTypes.NpgsqlPoint(x: 0.14822384363029717d, y: 0.12495869474464205d)), } },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9885540589865204d, y: 0.41520171121185245d), new NpgsqlTypes.NpgsqlPoint(x: 0.051439033063517825d, y: 0.4280924128510559d), new NpgsqlTypes.NpgsqlPoint(x: 0.7332983825619889d, y: 0.698889464546911d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12688806650132d, y: 0.553659853452372d), new NpgsqlTypes.NpgsqlPoint(x: 0.32566916240465504d, y: 0.39151058366071767d), new NpgsqlTypes.NpgsqlPoint(x: 0.45964112335237217d, y: 0.6466185322122662d)), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.917759881865375d, y: 0.11208625299657227d), new NpgsqlTypes.NpgsqlPoint(x: 0.4871958838464784d, y: 0.13254277457400765d), new NpgsqlTypes.NpgsqlPoint(x: 0.7366538705785367d, y: 0.9321676995093043d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.325873770159683d, y: 0.0520205624402893d), new NpgsqlTypes.NpgsqlPoint(x: 0.853255698737242d, y: 0.6924955223767514d), new NpgsqlTypes.NpgsqlPoint(x: 0.35366595535170375d, y: 0.575512346802371d)), } },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20609100708031125d, y: 0.1373175549550847d), new NpgsqlTypes.NpgsqlPoint(x: 0.26955480673522536d, y: 0.432519603280092d), new NpgsqlTypes.NpgsqlPoint(x: 0.5630810632034493d, y: 0.4133272617829816d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13265682276539603d, y: 0.2545392699136382d), new NpgsqlTypes.NpgsqlPoint(x: 0.14962087306679706d, y: 0.48827089945413193d), new NpgsqlTypes.NpgsqlPoint(x: 0.7567848256596349d, y: 0.39009136320436644d)), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16510788816039246d, y: 0.9467817257307081d), new NpgsqlTypes.NpgsqlPoint(x: 0.6199696823362326d, y: 0.3660094049001873d), new NpgsqlTypes.NpgsqlPoint(x: 0.6220635515741064d, y: 0.1465654085349436d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8286974882713869d, y: 0.5859477436068754d), new NpgsqlTypes.NpgsqlPoint(x: 0.30536153034758373d, y: 0.2848132611587849d), new NpgsqlTypes.NpgsqlPoint(x: 0.40180943352738896d, y: 0.11522082270522649d)), } },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.522662702857383d, y: 0.8291677320623504d), new NpgsqlTypes.NpgsqlPoint(x: 0.41798715296438615d, y: 0.8798217147917347d), new NpgsqlTypes.NpgsqlPoint(x: 0.6957761188666312d, y: 0.41979815065329473d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25661807080386156d, y: 0.019336055545921327d), new NpgsqlTypes.NpgsqlPoint(x: 0.12381663696603906d, y: 0.5834752174318633d), new NpgsqlTypes.NpgsqlPoint(x: 0.9659537547072454d, y: 0.838811506481294d)), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24202114867083468d, y: 0.35241098238072266d), new NpgsqlTypes.NpgsqlPoint(x: 0.5605670691927382d, y: 0.6145178423220867d), new NpgsqlTypes.NpgsqlPoint(x: 0.8301647209513646d, y: 0.6256209704787549d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.737503941530163d, y: 0.42014471500970996d), new NpgsqlTypes.NpgsqlPoint(x: 0.15510983364176933d, y: 0.1605390710872283d), new NpgsqlTypes.NpgsqlPoint(x: 0.0919033230184283d, y: 0.04981136402522601d)), } },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10265741301198739d, y: 0.9008949609461671d), new NpgsqlTypes.NpgsqlPoint(x: 0.35699480903411374d, y: 0.9157224190698546d), new NpgsqlTypes.NpgsqlPoint(x: 0.5754538058389601d, y: 0.6906838350076637d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.776378310179287d, y: 0.9200695980134318d), new NpgsqlTypes.NpgsqlPoint(x: 0.4362705726000736d, y: 0.1399554101871897d), new NpgsqlTypes.NpgsqlPoint(x: 0.035138747986923735d, y: 0.8476319084120375d)), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2513280589604726d, y: 0.1625429867284509d), new NpgsqlTypes.NpgsqlPoint(x: 0.04646621853801547d, y: 0.1486503274538008d), new NpgsqlTypes.NpgsqlPoint(x: 0.45989934391986476d, y: 0.796745404835701d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6391224905502195d, y: 0.003287218560676375d), new NpgsqlTypes.NpgsqlPoint(x: 0.824231383836137d, y: 0.8234934999475326d), new NpgsqlTypes.NpgsqlPoint(x: 0.7508526484502827d, y: 0.5013232550435368d)), } },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21242416516963925d, y: 0.14473598390819908d), new NpgsqlTypes.NpgsqlPoint(x: 0.19288603464196252d, y: 0.9560917721413318d), new NpgsqlTypes.NpgsqlPoint(x: 0.09256613451162765d, y: 0.9929592121733986d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5715211298074863d, y: 0.8215987071007317d), new NpgsqlTypes.NpgsqlPoint(x: 0.491210674912129d, y: 0.528778866195666d), new NpgsqlTypes.NpgsqlPoint(x: 0.5417347017657181d, y: 0.06005942788235452d)), } },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6280087333109735d, y: 0.7484642161334875d), new NpgsqlTypes.NpgsqlPoint(x: 0.4562844862534454d, y: 0.8621307723103143d), new NpgsqlTypes.NpgsqlPoint(x: 0.2020828421024332d, y: 0.6024814268915959d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39464933318854756d, y: 0.4713083767762991d), new NpgsqlTypes.NpgsqlPoint(x: 0.3046271549156965d, y: 0.93854067313149d), new NpgsqlTypes.NpgsqlPoint(x: 0.9025819535098166d, y: 0.7315890758814272d)), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20968599523846487d, y: 0.6713972251034228d), new NpgsqlTypes.NpgsqlPoint(x: 0.3951714073602903d, y: 0.6934991979844051d), new NpgsqlTypes.NpgsqlPoint(x: 0.26240060574708857d, y: 0.22615800629778027d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20304981544481104d, y: 0.22903436601625893d), new NpgsqlTypes.NpgsqlPoint(x: 0.06941541954258912d, y: 0.19778381510409282d), new NpgsqlTypes.NpgsqlPoint(x: 0.9622098792815275d, y: 0.06483344573058425d)), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9395605175468182d, y: 0.0680383307789646d), new NpgsqlTypes.NpgsqlPoint(x: 0.48270116629178217d, y: 0.8675452478406535d), new NpgsqlTypes.NpgsqlPoint(x: 0.3018649198991412d, y: 0.12296727551917441d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3208458026070705d, y: 0.7809829619931173d), new NpgsqlTypes.NpgsqlPoint(x: 0.8013598538176966d, y: 0.3355862869179942d), new NpgsqlTypes.NpgsqlPoint(x: 0.07744442013732267d, y: 0.9680117870763209d)), } },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26577908132312345d, y: 0.965801335753013d), new NpgsqlTypes.NpgsqlPoint(x: 0.0037134814710404473d, y: 0.4220417357876919d), new NpgsqlTypes.NpgsqlPoint(x: 0.5143346197110417d, y: 0.22169681616494663d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.896802236731233d, y: 0.7113872454440197d), new NpgsqlTypes.NpgsqlPoint(x: 0.05077370746360599d, y: 0.7549203334621418d), new NpgsqlTypes.NpgsqlPoint(x: 0.2832135146204563d, y: 0.8055990345612508d)), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3775204688729462d, y: 0.9441655370779655d), new NpgsqlTypes.NpgsqlPoint(x: 0.7961750601473532d, y: 0.7477071310411877d), new NpgsqlTypes.NpgsqlPoint(x: 0.608507890285754d, y: 0.4689564647604161d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14858967287823133d, y: 0.25394936340525653d), new NpgsqlTypes.NpgsqlPoint(x: 0.7237679620377527d, y: 0.8746676817471497d), new NpgsqlTypes.NpgsqlPoint(x: 0.8204566217479279d, y: 0.05897705369813566d)), } },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9339413239946757d, y: 0.4914883705040026d), new NpgsqlTypes.NpgsqlPoint(x: 0.9952033649605387d, y: 0.14199941329319887d), new NpgsqlTypes.NpgsqlPoint(x: 0.589254329534778d, y: 0.2611408357539241d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9841810710910602d, y: 0.8189667840441084d), new NpgsqlTypes.NpgsqlPoint(x: 0.33384073209816045d, y: 0.5797350253819352d), new NpgsqlTypes.NpgsqlPoint(x: 0.16607576578292493d, y: 0.29317515745470957d)), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9894654288912995d, y: 0.09294213962685305d), new NpgsqlTypes.NpgsqlPoint(x: 0.6497396325171272d, y: 0.7506067357096011d), new NpgsqlTypes.NpgsqlPoint(x: 0.13467788824444338d, y: 0.5238437732015524d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6332000600143121d, y: 0.06384234243275033d), new NpgsqlTypes.NpgsqlPoint(x: 0.05059851970394491d, y: 0.7398045889402903d), new NpgsqlTypes.NpgsqlPoint(x: 0.9377779569150323d, y: 0.022998414182955007d)), } },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6144242881373267d, y: 0.8165633710018353d), new NpgsqlTypes.NpgsqlPoint(x: 0.37575965608200723d, y: 0.5886697894002251d), new NpgsqlTypes.NpgsqlPoint(x: 0.625779954311363d, y: 0.7258984021136771d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23484489147774334d, y: 0.7031937060754008d), new NpgsqlTypes.NpgsqlPoint(x: 0.9053899542927154d, y: 0.8144901176901007d), new NpgsqlTypes.NpgsqlPoint(x: 0.33272629878178195d, y: 0.18550722124785324d)), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4145922482791544d, y: 0.2296765842614754d), new NpgsqlTypes.NpgsqlPoint(x: 0.5677290478394355d, y: 0.6344580491468088d), new NpgsqlTypes.NpgsqlPoint(x: 0.2610609649208715d, y: 0.6056540061016427d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49335908852710486d, y: 0.09826770989733657d), new NpgsqlTypes.NpgsqlPoint(x: 0.3940880657125545d, y: 0.09896461387223976d), new NpgsqlTypes.NpgsqlPoint(x: 0.993753655913672d, y: 0.6973178592199015d)), } },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30935392473620926d, y: 0.03518951861820441d), new NpgsqlTypes.NpgsqlPoint(x: 0.7127568237249271d, y: 0.9331119331532588d), new NpgsqlTypes.NpgsqlPoint(x: 0.41153537005876506d, y: 0.030923192159681423d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41482998188287046d, y: 0.9342331980808823d), new NpgsqlTypes.NpgsqlPoint(x: 0.8728620268930399d, y: 0.3808849927297252d), new NpgsqlTypes.NpgsqlPoint(x: 0.7847299807258102d, y: 0.9603625712413816d)), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08370466161289603d, y: 0.8247484503912045d), new NpgsqlTypes.NpgsqlPoint(x: 0.4239450111553499d, y: 0.46432928816944374d), new NpgsqlTypes.NpgsqlPoint(x: 0.8981506875017407d, y: 0.2853690941447199d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48876297589472495d, y: 0.053542036492233436d), new NpgsqlTypes.NpgsqlPoint(x: 0.19737313589979366d, y: 0.7411958552147737d), new NpgsqlTypes.NpgsqlPoint(x: 0.2222043728258647d, y: 0.5738901587231438d)), } },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9712371148665379d, y: 0.7655291864979332d), new NpgsqlTypes.NpgsqlPoint(x: 0.47638929130806484d, y: 0.8116540488999506d), new NpgsqlTypes.NpgsqlPoint(x: 0.4407361888841268d, y: 0.9412484355554726d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8425357259946832d, y: 0.5003436998600446d), new NpgsqlTypes.NpgsqlPoint(x: 0.8243047833097852d, y: 0.4224774879655795d), new NpgsqlTypes.NpgsqlPoint(x: 0.056379593394812244d, y: 0.13835547466877696d)), } },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5275771157058126d, y: 0.9284040960359352d), new NpgsqlTypes.NpgsqlPoint(x: 0.009007397159400132d, y: 0.3731373282157091d), new NpgsqlTypes.NpgsqlPoint(x: 0.0012378216761079752d, y: 0.8098107083679219d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3131567560550075d, y: 0.7076143394046144d), new NpgsqlTypes.NpgsqlPoint(x: 0.41980128909082925d, y: 0.16169763364821776d), new NpgsqlTypes.NpgsqlPoint(x: 0.6825695192500341d, y: 0.9092504457661181d)), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4899875544588417d, y: 0.6245808465433103d), new NpgsqlTypes.NpgsqlPoint(x: 0.5441225338206103d, y: 0.37362485059653794d), new NpgsqlTypes.NpgsqlPoint(x: 0.03755117525328877d, y: 0.10698784672293993d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5259401367734821d, y: 0.32896747237714696d), new NpgsqlTypes.NpgsqlPoint(x: 0.5373294002575789d, y: 0.9804540669202242d), new NpgsqlTypes.NpgsqlPoint(x: 0.45457836626599435d, y: 0.4066527399280785d)), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8025433751023403d, y: 0.5436192794966475d), new NpgsqlTypes.NpgsqlPoint(x: 0.001520779534965766d, y: 0.6533461451271892d), new NpgsqlTypes.NpgsqlPoint(x: 0.6624315484204698d, y: 0.27070059908651456d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41633883273270844d, y: 0.21987330480613088d), new NpgsqlTypes.NpgsqlPoint(x: 0.8551467785887633d, y: 0.4900253945719384d), new NpgsqlTypes.NpgsqlPoint(x: 0.7317886422232625d, y: 0.20818121096021314d)), } },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09689701866659572d, y: 0.5898260560185756d), new NpgsqlTypes.NpgsqlPoint(x: 0.8811364693799985d, y: 0.37643540960467237d), new NpgsqlTypes.NpgsqlPoint(x: 0.6520371217504454d, y: 0.30231391815933495d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8506227327595858d, y: 0.05026251328838305d), new NpgsqlTypes.NpgsqlPoint(x: 0.914915333337371d, y: 0.5926579872662613d), new NpgsqlTypes.NpgsqlPoint(x: 0.4504769144963573d, y: 0.3319735322180013d)), } },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0856845496099653d, y: 0.4769343136020038d), new NpgsqlTypes.NpgsqlPoint(x: 0.9644117055917024d, y: 0.770530144052081d), new NpgsqlTypes.NpgsqlPoint(x: 0.15026102631017668d, y: 0.3831656428545124d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40068638295931724d, y: 0.7147954282232563d), new NpgsqlTypes.NpgsqlPoint(x: 0.585879495347287d, y: 0.9860973530055029d), new NpgsqlTypes.NpgsqlPoint(x: 0.16698118778851034d, y: 0.31968070218317723d)), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43364562151603236d, y: 0.4307136219409481d), new NpgsqlTypes.NpgsqlPoint(x: 0.9501713170436381d, y: 0.8466009820217374d), new NpgsqlTypes.NpgsqlPoint(x: 0.7698991601783477d, y: 0.0722993510198292d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.668991067075007d, y: 0.0009371526042837308d), new NpgsqlTypes.NpgsqlPoint(x: 0.6446213263411091d, y: 0.11443556775870256d), new NpgsqlTypes.NpgsqlPoint(x: 0.8072372401148018d, y: 0.3776710457941568d)), } },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9743885028405179d, y: 0.20523137671129377d), new NpgsqlTypes.NpgsqlPoint(x: 0.4293794168709433d, y: 0.4007605513859672d), new NpgsqlTypes.NpgsqlPoint(x: 0.40774667063491843d, y: 0.23933976698732773d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0288377829343478d, y: 0.6656418244911628d), new NpgsqlTypes.NpgsqlPoint(x: 0.12710918647814506d, y: 0.29764181118551913d), new NpgsqlTypes.NpgsqlPoint(x: 0.5672790325717599d, y: 0.40075402751448963d)), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3782140307374421d, y: 0.9164503433302098d), new NpgsqlTypes.NpgsqlPoint(x: 0.35649348429375705d, y: 0.2862166240294086d), new NpgsqlTypes.NpgsqlPoint(x: 0.012750069564182565d, y: 0.828286116018087d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.569976886988524d, y: 0.963948662684729d), new NpgsqlTypes.NpgsqlPoint(x: 0.8452040366099736d, y: 0.26532796314335094d), new NpgsqlTypes.NpgsqlPoint(x: 0.7375943201776362d, y: 0.08789203644795485d)), } },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6805232082004445d, y: 0.8242543204547201d), new NpgsqlTypes.NpgsqlPoint(x: 0.5272180340132863d, y: 0.4398945732896964d), new NpgsqlTypes.NpgsqlPoint(x: 0.4028475361222772d, y: 0.6090438533507508d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9497633513653814d, y: 0.9423417231668221d), new NpgsqlTypes.NpgsqlPoint(x: 0.08074383324316703d, y: 0.4049302765880659d), new NpgsqlTypes.NpgsqlPoint(x: 0.8155335160423157d, y: 0.23003917415550434d)), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48138288841226895d, y: 0.6632643129540017d), new NpgsqlTypes.NpgsqlPoint(x: 0.3835219916493049d, y: 0.28282047969967794d), new NpgsqlTypes.NpgsqlPoint(x: 0.6399837419023053d, y: 0.8789406412012057d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6008136134675953d, y: 0.9022205320975273d), new NpgsqlTypes.NpgsqlPoint(x: 0.871234536497913d, y: 0.4023305841068565d), new NpgsqlTypes.NpgsqlPoint(x: 0.7404106546268543d, y: 0.8721541932828223d)), } },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 92,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6227484304980826d, y: 0.7338424740882452d), new NpgsqlTypes.NpgsqlPoint(x: 0.016194711096815584d, y: 0.010609186156463335d), new NpgsqlTypes.NpgsqlPoint(x: 0.6102673326289783d, y: 0.8810238153210396d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3599797513893972d, y: 0.43761887208152817d), new NpgsqlTypes.NpgsqlPoint(x: 0.5894780620535238d, y: 0.17270833456696644d), new NpgsqlTypes.NpgsqlPoint(x: 0.8976104601850071d, y: 0.8459779176840637d)), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8029859597607522d, y: 0.48832559838909106d), new NpgsqlTypes.NpgsqlPoint(x: 0.2680179546712159d, y: 0.34675829587239315d), new NpgsqlTypes.NpgsqlPoint(x: 0.9410443516677106d, y: 0.9522736338229272d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4334045054817943d, y: 0.8574550039433839d), new NpgsqlTypes.NpgsqlPoint(x: 0.015738464022536425d, y: 0.15220930354827866d), new NpgsqlTypes.NpgsqlPoint(x: 0.9480161300969665d, y: 0.23134136509368697d)), } },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 95,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10819334893405574d, y: 0.7967270261958792d), new NpgsqlTypes.NpgsqlPoint(x: 0.3861402896826934d, y: 0.7833957018255868d), new NpgsqlTypes.NpgsqlPoint(x: 0.4526225521939162d, y: 0.49928181706328534d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9551566838571198d, y: 0.7549760996490325d), new NpgsqlTypes.NpgsqlPoint(x: 0.390772659983988d, y: 0.7503743782294834d), new NpgsqlTypes.NpgsqlPoint(x: 0.2837234032934347d, y: 0.8345821303883328d)), } },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40104784261605897d, y: 0.2160296368756327d), new NpgsqlTypes.NpgsqlPoint(x: 0.6159492979231003d, y: 0.7137451448730305d), new NpgsqlTypes.NpgsqlPoint(x: 0.3942700661979669d, y: 0.1545768206033803d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09831672178404938d, y: 0.49894189260506905d), new NpgsqlTypes.NpgsqlPoint(x: 0.7611240715945523d, y: 0.9458440371143331d), new NpgsqlTypes.NpgsqlPoint(x: 0.5325551873215616d, y: 0.3419182985170083d)), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7166443726291197d, y: 0.1732168869677011d), new NpgsqlTypes.NpgsqlPoint(x: 0.7294249800488923d, y: 0.8078830779489131d), new NpgsqlTypes.NpgsqlPoint(x: 0.6437826444814736d, y: 0.6283976213585246d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38146563105430054d, y: 0.6711684333948017d), new NpgsqlTypes.NpgsqlPoint(x: 0.19793289818055793d, y: 0.15467629148910955d), new NpgsqlTypes.NpgsqlPoint(x: 0.3005369485288526d, y: 0.6172928014829326d)), } },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15348460199223157d, y: 0.939821464621198d), new NpgsqlTypes.NpgsqlPoint(x: 0.21504466921882048d, y: 0.03095094164814327d), new NpgsqlTypes.NpgsqlPoint(x: 0.4683123850817136d, y: 0.27586909971704154d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9243891445820271d, y: 0.026371367346866736d), new NpgsqlTypes.NpgsqlPoint(x: 0.295623851596749d, y: 0.26525684888146117d), new NpgsqlTypes.NpgsqlPoint(x: 0.83120854156691d, y: 0.920142048560684d)), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 109,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2879810293885289d, y: 0.32317248747376015d), new NpgsqlTypes.NpgsqlPoint(x: 0.7491721290650054d, y: 0.6959403048376271d), new NpgsqlTypes.NpgsqlPoint(x: 0.4638046083207853d, y: 0.9656714996942019d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15817247670385914d, y: 0.48048071412933036d), new NpgsqlTypes.NpgsqlPoint(x: 0.005111400625339768d, y: 0.13082856551834932d), new NpgsqlTypes.NpgsqlPoint(x: 0.18303337596157931d, y: 0.06236104055232128d)), } },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2431848681533254d, y: 0.9043861506757198d), new NpgsqlTypes.NpgsqlPoint(x: 0.6929196130778347d, y: 0.9056895700281408d), new NpgsqlTypes.NpgsqlPoint(x: 0.9500669658693557d, y: 0.4965420432319354d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6296936702640784d, y: 0.8649656252815712d), new NpgsqlTypes.NpgsqlPoint(x: 0.28441253145599354d, y: 0.4614275764127177d), new NpgsqlTypes.NpgsqlPoint(x: 0.42668453972634623d, y: 0.26589594232194735d)), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 111,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47342416827410405d, y: 0.542645366151319d), new NpgsqlTypes.NpgsqlPoint(x: 0.6053284909570116d, y: 0.6639030454800853d), new NpgsqlTypes.NpgsqlPoint(x: 0.8746286035125913d, y: 0.29157678952150023d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6520400712797839d, y: 0.703380257895938d), new NpgsqlTypes.NpgsqlPoint(x: 0.3676927135133943d, y: 0.05924049466205572d), new NpgsqlTypes.NpgsqlPoint(x: 0.5060818235160811d, y: 0.8252955416519326d)), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21855507633501614d, y: 0.7096417002993074d), new NpgsqlTypes.NpgsqlPoint(x: 0.24256779968847553d, y: 0.17347154193318848d), new NpgsqlTypes.NpgsqlPoint(x: 0.7554137797287134d, y: 0.3061997674502813d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7125138331091011d, y: 0.989854130170806d), new NpgsqlTypes.NpgsqlPoint(x: 0.5500874523867981d, y: 0.3352815388332313d), new NpgsqlTypes.NpgsqlPoint(x: 0.46329953016925174d, y: 0.12956476258764138d)), } },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3984404731440577d, y: 0.7730278823128527d), new NpgsqlTypes.NpgsqlPoint(x: 0.2822288943372433d, y: 0.8988856861101425d), new NpgsqlTypes.NpgsqlPoint(x: 0.3760142647936654d, y: 0.2142475701648382d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.475895859328464d, y: 0.9713785324090377d), new NpgsqlTypes.NpgsqlPoint(x: 0.026093642776582437d, y: 0.22177330416881735d), new NpgsqlTypes.NpgsqlPoint(x: 0.6385000135826983d, y: 0.36653509221814007d)), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 119,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6431107165227814d, y: 0.4285106766170197d), new NpgsqlTypes.NpgsqlPoint(x: 0.12371963044444911d, y: 0.9904009399257055d), new NpgsqlTypes.NpgsqlPoint(x: 0.7038751635968863d, y: 0.791163066586016d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9908596044062548d, y: 0.8565510878546085d), new NpgsqlTypes.NpgsqlPoint(x: 0.12428661359923987d, y: 0.35912796023522486d), new NpgsqlTypes.NpgsqlPoint(x: 0.46752325523686666d, y: 0.6114666617848259d)), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9640136631305387d, y: 0.4719658776317348d), new NpgsqlTypes.NpgsqlPoint(x: 0.20410008597791385d, y: 0.23012811131809818d), new NpgsqlTypes.NpgsqlPoint(x: 0.042628441014129215d, y: 0.6439944874366083d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5482120437627391d, y: 0.18179815838813573d), new NpgsqlTypes.NpgsqlPoint(x: 0.5087546054206054d, y: 0.9017010706291236d), new NpgsqlTypes.NpgsqlPoint(x: 0.2047799599001069d, y: 0.5406615169614797d)), } },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 124,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.937903545375571d, y: 0.8974646386275387d), new NpgsqlTypes.NpgsqlPoint(x: 0.2837428366667185d, y: 0.6047154131701298d), new NpgsqlTypes.NpgsqlPoint(x: 0.21637108218013845d, y: 0.6606223201142812d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.023587193352863856d, y: 0.16776985099159714d), new NpgsqlTypes.NpgsqlPoint(x: 0.13760096714880876d, y: 0.9343813143151168d), new NpgsqlTypes.NpgsqlPoint(x: 0.11715259491286745d, y: 0.2740485683572029d)), } },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49999656494741485d, y: 0.6583655330408783d), new NpgsqlTypes.NpgsqlPoint(x: 0.4066517186970561d, y: 0.027972330571357285d), new NpgsqlTypes.NpgsqlPoint(x: 0.9551313916810982d, y: 0.48911891626980664d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24799109229123084d, y: 0.5037752121381819d), new NpgsqlTypes.NpgsqlPoint(x: 0.1359381511173221d, y: 0.07815197881132563d), new NpgsqlTypes.NpgsqlPoint(x: 0.21169623199672716d, y: 0.820293817170615d)), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3603359251251199d, y: 0.9710395221027494d), new NpgsqlTypes.NpgsqlPoint(x: 0.7464159216567897d, y: 0.7338071486203805d), new NpgsqlTypes.NpgsqlPoint(x: 0.5142516397430299d, y: 0.6340050399429754d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5802077877314036d, y: 0.9557791773393924d), new NpgsqlTypes.NpgsqlPoint(x: 0.7408979372727414d, y: 0.9380278202121256d), new NpgsqlTypes.NpgsqlPoint(x: 0.8911396797955218d, y: 0.18644285916529613d)), } },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 130,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39536629641677035d, y: 0.5611844282226095d), new NpgsqlTypes.NpgsqlPoint(x: 0.510963983697296d, y: 0.9982019380958586d), new NpgsqlTypes.NpgsqlPoint(x: 0.7048101896629186d, y: 0.003454222126842099d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4864913012687453d, y: 0.42719958747234144d), new NpgsqlTypes.NpgsqlPoint(x: 0.17270639975746072d, y: 0.15481138254313742d), new NpgsqlTypes.NpgsqlPoint(x: 0.2885271282444434d, y: 0.1669471360249618d)), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 135,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8916805666722405d, y: 0.1807915040311775d), new NpgsqlTypes.NpgsqlPoint(x: 0.825505115212968d, y: 0.35902666147404605d), new NpgsqlTypes.NpgsqlPoint(x: 0.4409766079375197d, y: 0.32508308778301087d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13109609783817855d, y: 0.765678185339297d), new NpgsqlTypes.NpgsqlPoint(x: 0.3588822123163714d, y: 0.7861893270200174d), new NpgsqlTypes.NpgsqlPoint(x: 0.2384216394939771d, y: 0.8910981224274434d)), } },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1401654197770693d, y: 0.6604501894582138d), new NpgsqlTypes.NpgsqlPoint(x: 0.0870423500251788d, y: 0.48524456920189474d), new NpgsqlTypes.NpgsqlPoint(x: 0.6900444335431442d, y: 0.0991389542391663d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7697933934743679d, y: 0.07591256257810419d), new NpgsqlTypes.NpgsqlPoint(x: 0.6580515394261947d, y: 0.6759064754736034d), new NpgsqlTypes.NpgsqlPoint(x: 0.3924679881729052d, y: 0.9864787523070375d)), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.929876442005684d, y: 0.30433792374872726d), new NpgsqlTypes.NpgsqlPoint(x: 0.5255881824107654d, y: 0.26340099582986887d), new NpgsqlTypes.NpgsqlPoint(x: 0.9150334784288069d, y: 0.6932867212827978d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6960558364522265d, y: 0.2961490781947086d), new NpgsqlTypes.NpgsqlPoint(x: 0.5742555685629507d, y: 0.5119191380325215d), new NpgsqlTypes.NpgsqlPoint(x: 0.9205313336505763d, y: 0.39292688776453744d)), } },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 138,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.157188100496241d, y: 0.8082312880485937d), new NpgsqlTypes.NpgsqlPoint(x: 0.7411397854802598d, y: 0.06507388368523415d), new NpgsqlTypes.NpgsqlPoint(x: 0.8481508849985023d, y: 0.12789929136529665d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28716869566825454d, y: 0.7321494588162163d), new NpgsqlTypes.NpgsqlPoint(x: 0.4567451716026567d, y: 0.9233923481527012d), new NpgsqlTypes.NpgsqlPoint(x: 0.005933352600934749d, y: 0.14229564716536403d)), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 147,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04425993045909604d, y: 0.07043629230134907d), new NpgsqlTypes.NpgsqlPoint(x: 0.1929163886755284d, y: 0.12286670869715466d), new NpgsqlTypes.NpgsqlPoint(x: 0.9085528121338223d, y: 0.10991394465109883d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5256631737240407d, y: 0.8445501431519447d), new NpgsqlTypes.NpgsqlPoint(x: 0.06513990395657931d, y: 0.38580789175520713d), new NpgsqlTypes.NpgsqlPoint(x: 0.1410709233249411d, y: 0.8996781376711619d)), } },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3737156567365748d, y: 0.9187756913789716d), new NpgsqlTypes.NpgsqlPoint(x: 0.5514908088653702d, y: 0.7817601499171899d), new NpgsqlTypes.NpgsqlPoint(x: 0.4225995705637865d, y: 0.019926200700535635d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47437869160109436d, y: 0.6151395758876661d), new NpgsqlTypes.NpgsqlPoint(x: 0.7034696869508831d, y: 0.46578909282319325d), new NpgsqlTypes.NpgsqlPoint(x: 0.055265318510755446d, y: 0.14984418658511d)), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2906171666549753d, y: 0.7338420293147054d), new NpgsqlTypes.NpgsqlPoint(x: 0.5649693093628189d, y: 0.8271239316747361d), new NpgsqlTypes.NpgsqlPoint(x: 0.8975081324982637d, y: 0.9722817484297099d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5567535876275036d, y: 0.5707411524564909d), new NpgsqlTypes.NpgsqlPoint(x: 0.16406010248648706d, y: 0.3540562195465591d), new NpgsqlTypes.NpgsqlPoint(x: 0.3592863830981886d, y: 0.197311606265d)), } },
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 154,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8575201763872301d, y: 0.7522932233004777d), new NpgsqlTypes.NpgsqlPoint(x: 0.1492987384202028d, y: 0.5037661709443493d), new NpgsqlTypes.NpgsqlPoint(x: 0.44218967105172124d, y: 0.0778432256242858d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3965515138488499d, y: 0.11064109576248193d), new NpgsqlTypes.NpgsqlPoint(x: 0.8279172722779612d, y: 0.9063105732478373d), new NpgsqlTypes.NpgsqlPoint(x: 0.39518431364820117d, y: 0.48486929066869733d)), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 162,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8336654618189946d, y: 0.5929734431251816d), new NpgsqlTypes.NpgsqlPoint(x: 0.2813669830123904d, y: 0.8126778067423257d), new NpgsqlTypes.NpgsqlPoint(x: 0.6000728714897462d, y: 0.7938930118720777d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7727668117116401d, y: 0.28443852769794153d), new NpgsqlTypes.NpgsqlPoint(x: 0.722643485222963d, y: 0.19399106120611564d), new NpgsqlTypes.NpgsqlPoint(x: 0.7639702589234235d, y: 0.16617050773059705d)), } },
    ModelInner = new NpgsqlPathpathMMArrayD2E1MI
{
    Id = 95,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2909740078679969d, y: 0.35855333315156723d), new NpgsqlTypes.NpgsqlPoint(x: 0.21122588941999942d, y: 0.5129184213551714d), new NpgsqlTypes.NpgsqlPoint(x: 0.5098675111375679d, y: 0.8985418417244713d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21182489902180546d, y: 0.15783491868985577d), new NpgsqlTypes.NpgsqlPoint(x: 0.6996508134338891d, y: 0.7001783969257421d), new NpgsqlTypes.NpgsqlPoint(x: 0.03535504358813657d, y: 0.4774336895500615d)), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6671685809005748d, y: 0.9786634412516593d), new NpgsqlTypes.NpgsqlPoint(x: 0.7348582270337568d, y: 0.5829048122369519d), new NpgsqlTypes.NpgsqlPoint(x: 0.2841714842802693d, y: 0.028161389418230764d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7812281688605888d, y: 0.7973267733767682d), new NpgsqlTypes.NpgsqlPoint(x: 0.573290252733467d, y: 0.8010302915296694d), new NpgsqlTypes.NpgsqlPoint(x: 0.44266941019452566d, y: 0.8149468523737098d)), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9091475888063565d, y: 0.9182423861270507d), new NpgsqlTypes.NpgsqlPoint(x: 0.06075142713322401d, y: 0.6790953236174069d), new NpgsqlTypes.NpgsqlPoint(x: 0.8574185030112642d, y: 0.24973632530072976d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2456576136277654d, y: 0.7317155405974186d), new NpgsqlTypes.NpgsqlPoint(x: 0.437714874877814d, y: 0.8282479348889152d), new NpgsqlTypes.NpgsqlPoint(x: 0.1877493191320535d, y: 0.3761922325377792d)), } },
},
            new NpgsqlPathpathMMArrayD2E1M
{
    Id = 170,
    Value = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9498105607938541d, y: 0.22866255390624035d), new NpgsqlTypes.NpgsqlPoint(x: 0.5591782156879208d, y: 0.8409891822755724d), new NpgsqlTypes.NpgsqlPoint(x: 0.6330390187116218d, y: 0.21126384570265633d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5330247658990864d, y: 0.8244076204489758d), new NpgsqlTypes.NpgsqlPoint(x: 0.113172229896632d, y: 0.28377041454023877d), new NpgsqlTypes.NpgsqlPoint(x: 0.5560352783297741d, y: 0.31416960723845655d)), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5760509885317576d, y: 0.9566569368752559d), new NpgsqlTypes.NpgsqlPoint(x: 0.46606393193905504d, y: 0.4649258854899454d), new NpgsqlTypes.NpgsqlPoint(x: 0.7217240935997256d, y: 0.7832281362929372d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49168893561239035d, y: 0.24224113525689528d), new NpgsqlTypes.NpgsqlPoint(x: 0.3187631087113467d, y: 0.1972744593914847d), new NpgsqlTypes.NpgsqlPoint(x: 0.4449379165066878d, y: 0.9548155828921703d)), } },
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd2e1mi(
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd2e1mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
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

                changedRows =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmmarrayd2e1mi_id
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpathmmarrayd2e1mi_id", 
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
                changedRows =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmmarrayd2e1mi_id
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
    npgsqlpathpathmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                NpgsqlTypes.NpgsqlPath[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable =  ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable =  ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlPath[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable = await ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[,]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable = await ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmmarrayd2e1mi_id
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
    npgsqlpathpathmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpathmmarrayd2e1mi_id", 
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
                NpgsqlTypes.NpgsqlPath[,] nullable = null;
                nullable =  ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2513280589604726d, y: 0.1625429867284509d), new NpgsqlTypes.NpgsqlPoint(x: 0.04646621853801547d, y: 0.1486503274538008d), new NpgsqlTypes.NpgsqlPoint(x: 0.45989934391986476d, y: 0.796745404835701d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6391224905502195d, y: 0.003287218560676375d), new NpgsqlTypes.NpgsqlPoint(x: 0.824231383836137d, y: 0.8234934999475326d), new NpgsqlTypes.NpgsqlPoint(x: 0.7508526484502827d, y: 0.5013232550435368d)), } }));
                nullable =  ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath[,] nullable = null;
                nullable = await ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPathMArraypathMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[,] { {
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3775204688729462d, y: 0.9441655370779655d), new NpgsqlTypes.NpgsqlPoint(x: 0.7961750601473532d, y: 0.7477071310411877d), new NpgsqlTypes.NpgsqlPoint(x: 0.608507890285754d, y: 0.4689564647604161d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14858967287823133d, y: 0.25394936340525653d), new NpgsqlTypes.NpgsqlPoint(x: 0.7237679620377527d, y: 0.8746676817471497d), new NpgsqlTypes.NpgsqlPoint(x: 0.8204566217479279d, y: 0.05897705369813566d)), } }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathMMArrayD2E1M> models = null;

                models =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathMMArrayD2E1M> models = null;

                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPathMArraypathMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M), typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd2e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M), typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd2e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M), typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[19],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 10;
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[34], false);
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
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 71;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd2e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                var models = await((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[14], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[15], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[16], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[17], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[18], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[19], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[20], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[21], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[22], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[23], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[34], false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[25],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[25],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[26],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[27],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M), typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 51, query1, 10, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 31, query1, 71, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 109, query1, 109, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 124, query1, 31, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[25],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 26, query1, 92, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 26, query1, 26, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 30, query1, 5, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(models[33],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
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
FROM public.npgsqlpathpathmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD2E1M>();
                 ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 124, query1, 83, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD2E1M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd2e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd2e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
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
                var models = await((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 109, 31))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 12, 5))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[25],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[26],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[27],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[28],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[28],_testData[29], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[29],_testData[30], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[30],_testData[31], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[31],_testData[32], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[32],_testData[33], false);
                        NpgsqlPathpathMMArrayD2E1M.AssertModel(models[33],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPathMArraypathMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathMArraypathMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 26);
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(28));

                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathMArraypathMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathMArraypathMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 9);
                var models =  ((INpgsqlPathMArraypathMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(32));

                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                NpgsqlPathpathMMArrayD2E1M.AssertModel(models[31],_testData[34], false);
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
FROM public.binary_npgsqlpathpathmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD2E1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD2E1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathMArraypathMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathMArraypathMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpathmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathMMArrayD2E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
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
FROM public.binary_npgsqlpathpathmmarrayd2e1m m
LEFT JOIN public.binary_npgsqlpathpathmmarrayd2e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathMArraypathMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathMArraypathMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpathmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models =  ((INpgsqlPathMArraypathMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA), typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
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
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
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
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA), typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                ((INpgsqlPathMArraypathMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
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
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
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
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
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
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MI), typeof(NpgsqlPathpathMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MI>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MI>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MI>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MI>();
                ((INpgsqlPathMArraypathMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA), typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                await ((INpgsqlPathMArraypathMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD2E1MIWA>();
                ((INpgsqlPathMArraypathMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD2))]
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
                var models = await ((INpgsqlPathMArraypathMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

