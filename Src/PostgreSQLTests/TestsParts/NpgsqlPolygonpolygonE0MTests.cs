

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
    internal partial interface INpgsqlPolygonSingleTypepolygon
    {
    }
    
    internal partial class NpgsqlPolygonSingleTypepolygon : INpgsqlPolygonSingleTypepolygon
    {


#region TestData

        private readonly NpgsqlPolygonpolygonE0M[] _testData = new NpgsqlPolygonpolygonE0M[]
        {
            new NpgsqlPolygonpolygonE0M
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11744116522456216d, y: 0.8080292074630436d), new NpgsqlTypes.NpgsqlPoint(x: 0.26297427464203615d, y: 0.9122659143715751d), new NpgsqlTypes.NpgsqlPoint(x: 0.7678089982416562d, y: 0.0409360432680379d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37204150550427295d, y: 0.4823851451376092d), new NpgsqlTypes.NpgsqlPoint(x: 0.8422364893541612d, y: 0.33845253860720226d), new NpgsqlTypes.NpgsqlPoint(x: 0.7771559223757499d, y: 0.2616719016051241d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8137097932743937d, y: 0.3165235588135562d), new NpgsqlTypes.NpgsqlPoint(x: 0.5298255095161585d, y: 0.9365119165305731d), new NpgsqlTypes.NpgsqlPoint(x: 0.3017816692221529d, y: 0.3543543579584756d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26411753125429227d, y: 0.11998443814254522d), new NpgsqlTypes.NpgsqlPoint(x: 0.7221700029288811d, y: 0.7772844228379054d), new NpgsqlTypes.NpgsqlPoint(x: 0.4180710888046508d, y: 0.03376997191951514d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2893243687519965d, y: 0.5654654310552499d), new NpgsqlTypes.NpgsqlPoint(x: 0.744547518379859d, y: 0.96072697884504d), new NpgsqlTypes.NpgsqlPoint(x: 0.05123555956908177d, y: 0.6418186968783319d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8036466363048586d, y: 0.5465964241621563d), new NpgsqlTypes.NpgsqlPoint(x: 0.8027375164715889d, y: 0.3216319165916741d), new NpgsqlTypes.NpgsqlPoint(x: 0.993092604144047d, y: 0.31889345559084104d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36889227641057765d, y: 0.16995207627320286d), new NpgsqlTypes.NpgsqlPoint(x: 0.2528617151494159d, y: 0.09576771363063252d), new NpgsqlTypes.NpgsqlPoint(x: 0.23723381171396984d, y: 0.5838108901641144d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49416485053197134d, y: 0.9129812148104237d), new NpgsqlTypes.NpgsqlPoint(x: 0.28516609965959416d, y: 0.6181006993677551d), new NpgsqlTypes.NpgsqlPoint(x: 0.9194388281928451d, y: 0.8991243809592162d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6173442884802274d, y: 0.1753395582331344d), new NpgsqlTypes.NpgsqlPoint(x: 0.24729687612667628d, y: 0.7863970688607469d), new NpgsqlTypes.NpgsqlPoint(x: 0.156921628988146d, y: 0.38138002625440326d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07763152148082131d, y: 0.3948912675369408d), new NpgsqlTypes.NpgsqlPoint(x: 0.29504837166719666d, y: 0.6168028106266379d), new NpgsqlTypes.NpgsqlPoint(x: 0.4666380176411591d, y: 0.09564606492961447d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8005867328985076d, y: 0.08678133726398152d), new NpgsqlTypes.NpgsqlPoint(x: 0.39477493773722405d, y: 0.9073305766466921d), new NpgsqlTypes.NpgsqlPoint(x: 0.6934414590623912d, y: 0.20768159738334346d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09726790042555644d, y: 0.7456752692395532d), new NpgsqlTypes.NpgsqlPoint(x: 0.8944235502068905d, y: 0.3578467942280542d), new NpgsqlTypes.NpgsqlPoint(x: 0.6567215243084218d, y: 0.362290955045099d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08416180868428669d, y: 0.9159391299888091d), new NpgsqlTypes.NpgsqlPoint(x: 0.6885947419781565d, y: 0.09652736243698634d), new NpgsqlTypes.NpgsqlPoint(x: 0.5076150043953697d, y: 0.5599043957623961d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6876683867902811d, y: 0.4136984241094829d), new NpgsqlTypes.NpgsqlPoint(x: 0.1480751167060229d, y: 0.756123213322278d), new NpgsqlTypes.NpgsqlPoint(x: 0.9059810670623957d, y: 0.6988323440481766d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 23,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46009843262405004d, y: 0.4128498708891488d), new NpgsqlTypes.NpgsqlPoint(x: 0.8513026562883999d, y: 0.5194171209323957d), new NpgsqlTypes.NpgsqlPoint(x: 0.6480801969555081d, y: 0.9864611740034808d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6817539159949695d, y: 0.6577557702398262d), new NpgsqlTypes.NpgsqlPoint(x: 0.7962068117532322d, y: 0.2236535637811442d), new NpgsqlTypes.NpgsqlPoint(x: 0.2605423421172198d, y: 0.6777897449137255d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4402030098326507d, y: 0.40429927981458036d), new NpgsqlTypes.NpgsqlPoint(x: 0.4636776693725475d, y: 0.5366373968089634d), new NpgsqlTypes.NpgsqlPoint(x: 0.07761622645187827d, y: 0.5004872596739022d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 32,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9309617031248556d, y: 0.3662541954784956d), new NpgsqlTypes.NpgsqlPoint(x: 0.44952289090570097d, y: 0.05713229922883356d), new NpgsqlTypes.NpgsqlPoint(x: 0.6367514968606197d, y: 0.373707353850532d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3885517981604488d, y: 0.648029711179966d), new NpgsqlTypes.NpgsqlPoint(x: 0.07558698501323824d, y: 0.9165111466564242d), new NpgsqlTypes.NpgsqlPoint(x: 0.8226178218801861d, y: 0.0064548729110668335d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4005707471511124d, y: 0.48524492135756103d), new NpgsqlTypes.NpgsqlPoint(x: 0.7127731161293489d, y: 0.1941075380065882d), new NpgsqlTypes.NpgsqlPoint(x: 0.6380323444791629d, y: 0.04721331325995248d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8672940923528757d, y: 0.44315851342596313d), new NpgsqlTypes.NpgsqlPoint(x: 0.7319798876368305d, y: 0.1833381342671102d), new NpgsqlTypes.NpgsqlPoint(x: 0.7431915968087887d, y: 0.11176403681655989d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 55,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5424941470432981d, y: 0.787532173212718d), new NpgsqlTypes.NpgsqlPoint(x: 0.6869608081331918d, y: 0.7040126205341468d), new NpgsqlTypes.NpgsqlPoint(x: 0.23659149266470392d, y: 0.5202386923380911d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 33,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.930534069927414d, y: 0.49612771877691575d), new NpgsqlTypes.NpgsqlPoint(x: 0.5774382881949913d, y: 0.02022377221747307d), new NpgsqlTypes.NpgsqlPoint(x: 0.4972425122508942d, y: 0.7556727920269157d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.801570104621146d, y: 0.6940442497431853d), new NpgsqlTypes.NpgsqlPoint(x: 0.9364744813133307d, y: 0.6631582053367492d), new NpgsqlTypes.NpgsqlPoint(x: 0.16381737493519577d, y: 0.6216885647322588d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4207677929944226d, y: 0.9319280702694366d), new NpgsqlTypes.NpgsqlPoint(x: 0.09380541601799419d, y: 0.08341727699678081d), new NpgsqlTypes.NpgsqlPoint(x: 0.9652955776904004d, y: 0.9171741373709297d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8088001073354774d, y: 0.679685561825214d), new NpgsqlTypes.NpgsqlPoint(x: 0.5846673454208797d, y: 0.4945626588173574d), new NpgsqlTypes.NpgsqlPoint(x: 0.49535212301440323d, y: 0.6583006354238327d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 38,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6347561683456207d, y: 0.9478918108992118d), new NpgsqlTypes.NpgsqlPoint(x: 0.1688154786353825d, y: 0.7890845649539903d), new NpgsqlTypes.NpgsqlPoint(x: 0.25748213411013d, y: 0.5195562146231794d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4921680784318516d, y: 0.31247579208487775d), new NpgsqlTypes.NpgsqlPoint(x: 0.2249215334547664d, y: 0.4210439100817015d), new NpgsqlTypes.NpgsqlPoint(x: 0.7025199075109024d, y: 0.1744525207294565d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6811652168762848d, y: 0.9591284177257816d), new NpgsqlTypes.NpgsqlPoint(x: 0.3192168253924009d, y: 0.15784132490199554d), new NpgsqlTypes.NpgsqlPoint(x: 0.7824249070665993d, y: 0.6228314758641585d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 69,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17906816973840978d, y: 0.1633048202009223d), new NpgsqlTypes.NpgsqlPoint(x: 0.8216844624805967d, y: 0.8674355326112697d), new NpgsqlTypes.NpgsqlPoint(x: 0.6305446014048083d, y: 0.43662357854563927d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3105215369100073d, y: 0.2531699710407568d), new NpgsqlTypes.NpgsqlPoint(x: 0.5910625595344048d, y: 0.7768416894315913d), new NpgsqlTypes.NpgsqlPoint(x: 0.0513867584286799d, y: 0.2862049558780051d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6224213828486846d, y: 0.7592490434757979d), new NpgsqlTypes.NpgsqlPoint(x: 0.11471440304385783d, y: 0.6089843384457247d), new NpgsqlTypes.NpgsqlPoint(x: 0.06317585320605079d, y: 0.38223333604429144d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 45,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5980562725096651d, y: 0.5800056499743034d), new NpgsqlTypes.NpgsqlPoint(x: 0.6128131858708696d, y: 0.5989199741089791d), new NpgsqlTypes.NpgsqlPoint(x: 0.05629479026092188d, y: 0.4120361417896027d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6055814645068255d, y: 0.6705832043859066d), new NpgsqlTypes.NpgsqlPoint(x: 0.5111159952071609d, y: 0.8586660249237027d), new NpgsqlTypes.NpgsqlPoint(x: 0.6203609428140293d, y: 0.5837330197811291d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 84,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24633304211062246d, y: 0.5312064043655454d), new NpgsqlTypes.NpgsqlPoint(x: 0.3182875709726545d, y: 0.892750671856647d), new NpgsqlTypes.NpgsqlPoint(x: 0.42810728416500154d, y: 0.7679002676248425d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.957435915110089d, y: 0.7132442835089249d), new NpgsqlTypes.NpgsqlPoint(x: 0.8906299384392043d, y: 0.1946674177347133d), new NpgsqlTypes.NpgsqlPoint(x: 0.4361124989562897d, y: 0.798314327992721d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3703330551115728d, y: 0.2829530102832811d), new NpgsqlTypes.NpgsqlPoint(x: 0.5849156797053499d, y: 0.341614177435263d), new NpgsqlTypes.NpgsqlPoint(x: 0.14347870993345802d, y: 0.7550531464183213d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 86,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8594683743944733d, y: 0.6625389901633929d), new NpgsqlTypes.NpgsqlPoint(x: 0.5873827172831034d, y: 0.17272500251428113d), new NpgsqlTypes.NpgsqlPoint(x: 0.807110613951904d, y: 0.11435477917289105d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 92,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.267607153944338d, y: 0.9872383718044287d), new NpgsqlTypes.NpgsqlPoint(x: 0.3493795508088755d, y: 0.6637767928899361d), new NpgsqlTypes.NpgsqlPoint(x: 0.5384710747758226d, y: 0.24912707177408844d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8479945567716112d, y: 0.03702137007410877d), new NpgsqlTypes.NpgsqlPoint(x: 0.1732743684778203d, y: 0.8136599195964629d), new NpgsqlTypes.NpgsqlPoint(x: 0.7704846735383413d, y: 0.913432864663654d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1659401892139013d, y: 0.0339264365626194d), new NpgsqlTypes.NpgsqlPoint(x: 0.3114145263225886d, y: 0.774460261730912d), new NpgsqlTypes.NpgsqlPoint(x: 0.6285132807831189d, y: 0.1006060410882964d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2742030520599775d, y: 0.6843858470259879d), new NpgsqlTypes.NpgsqlPoint(x: 0.35074233200242355d, y: 0.20097352416707237d), new NpgsqlTypes.NpgsqlPoint(x: 0.005756957630341564d, y: 0.7370786306194561d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 94,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7568355232020736d, y: 0.30370717628789123d), new NpgsqlTypes.NpgsqlPoint(x: 0.6890469671943414d, y: 0.0739971068115175d), new NpgsqlTypes.NpgsqlPoint(x: 0.3463793280119525d, y: 0.6585850646551492d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 103,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9316225141114967d, y: 0.6434494756204737d), new NpgsqlTypes.NpgsqlPoint(x: 0.25760216627420285d, y: 0.9412367678354755d), new NpgsqlTypes.NpgsqlPoint(x: 0.27645565798143157d, y: 0.8791234148759219d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.648658026450837d, y: 0.7648860738751331d), new NpgsqlTypes.NpgsqlPoint(x: 0.3466712819408605d, y: 0.5396931293266067d), new NpgsqlTypes.NpgsqlPoint(x: 0.24938325752051038d, y: 0.4704365402638465d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37240782656033866d, y: 0.28641560486101525d), new NpgsqlTypes.NpgsqlPoint(x: 0.659518039526747d, y: 0.6291607422818101d), new NpgsqlTypes.NpgsqlPoint(x: 0.5859514955763284d, y: 0.4104716323090387d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 109,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2498524368984414d, y: 0.7271752912883135d), new NpgsqlTypes.NpgsqlPoint(x: 0.27142125722921884d, y: 0.8616237940475655d), new NpgsqlTypes.NpgsqlPoint(x: 0.09780877159537793d, y: 0.9908342692836339d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 115,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.585649392407402d, y: 0.5330104696868752d), new NpgsqlTypes.NpgsqlPoint(x: 0.3681982996048432d, y: 0.28330928253410803d), new NpgsqlTypes.NpgsqlPoint(x: 0.05871904581430465d, y: 0.2771272020851371d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5721460467773629d, y: 0.6949587785926449d), new NpgsqlTypes.NpgsqlPoint(x: 0.2565467833218378d, y: 0.9093765156631648d), new NpgsqlTypes.NpgsqlPoint(x: 0.10381930983524446d, y: 0.9640751657289774d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32910808085129795d, y: 0.1502831026198087d), new NpgsqlTypes.NpgsqlPoint(x: 0.43536519011429875d, y: 0.676438863203158d), new NpgsqlTypes.NpgsqlPoint(x: 0.8557728763769086d, y: 0.5981619811864382d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 121,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04041920739046401d, y: 0.9743868906213419d), new NpgsqlTypes.NpgsqlPoint(x: 0.3263708760011601d, y: 0.5142180700835731d), new NpgsqlTypes.NpgsqlPoint(x: 0.5246467654268528d, y: 0.24995722055155367d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5865525950861209d, y: 0.7438692038855318d), new NpgsqlTypes.NpgsqlPoint(x: 0.7999101641440779d, y: 0.48002632279883883d), new NpgsqlTypes.NpgsqlPoint(x: 0.9268892629523803d, y: 0.10079355059622441d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 128,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7899535019918573d, y: 0.9452267253254162d), new NpgsqlTypes.NpgsqlPoint(x: 0.8722164661276328d, y: 0.34768289665454466d), new NpgsqlTypes.NpgsqlPoint(x: 0.5781531125318417d, y: 0.9125007054892716d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 67,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23992633438949573d, y: 0.9057257764662182d), new NpgsqlTypes.NpgsqlPoint(x: 0.6459389448532546d, y: 0.587350532933259d), new NpgsqlTypes.NpgsqlPoint(x: 0.019775452978905927d, y: 0.8483247032952146d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8953734628620403d, y: 0.8569880451675662d), new NpgsqlTypes.NpgsqlPoint(x: 0.16274734382621459d, y: 0.13675694113379622d), new NpgsqlTypes.NpgsqlPoint(x: 0.4317183954492072d, y: 0.7193114446039137d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 132,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0473829832596071d, y: 0.42727458751410163d), new NpgsqlTypes.NpgsqlPoint(x: 0.9211130123593599d, y: 0.03397934031513716d), new NpgsqlTypes.NpgsqlPoint(x: 0.5122832710054699d, y: 0.06284811826688153d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 139,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.361259205243573d, y: 0.6503022368041134d), new NpgsqlTypes.NpgsqlPoint(x: 0.4815586803908477d, y: 0.48297127705264153d), new NpgsqlTypes.NpgsqlPoint(x: 0.3234349141681395d, y: 0.051329410528775155d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6858944936799658d, y: 0.11568926104058119d), new NpgsqlTypes.NpgsqlPoint(x: 0.9229945930540254d, y: 0.10514030040581246d), new NpgsqlTypes.NpgsqlPoint(x: 0.2518814619804973d, y: 0.37014567906759654d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 143,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6805289315883503d, y: 0.40703474217123325d), new NpgsqlTypes.NpgsqlPoint(x: 0.33499651324480684d, y: 0.10957153252573504d), new NpgsqlTypes.NpgsqlPoint(x: 0.5063439539401062d, y: 0.6240619083801667d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.014829946594323129d, y: 0.4210486009319908d), new NpgsqlTypes.NpgsqlPoint(x: 0.5987090856594539d, y: 0.6938437562770255d), new NpgsqlTypes.NpgsqlPoint(x: 0.5958133367004497d, y: 0.40422693486328665d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 146,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3393702447213197d, y: 0.30600484954452956d), new NpgsqlTypes.NpgsqlPoint(x: 0.9552672378008559d, y: 0.6437288620814756d), new NpgsqlTypes.NpgsqlPoint(x: 0.3469120222934713d, y: 0.4322135032664176d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 81,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9151172469131114d, y: 0.47845998737946116d), new NpgsqlTypes.NpgsqlPoint(x: 0.27865540667420896d, y: 0.979926793004106d), new NpgsqlTypes.NpgsqlPoint(x: 0.6533387424668993d, y: 0.5950177000379671d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4624885076228301d, y: 0.9284246248953058d), new NpgsqlTypes.NpgsqlPoint(x: 0.8154676914615885d, y: 0.4824958107583439d), new NpgsqlTypes.NpgsqlPoint(x: 0.37464969268090587d, y: 0.8052768878279666d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 153,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.012493758705959035d, y: 0.6493531714019971d), new NpgsqlTypes.NpgsqlPoint(x: 0.24471302941239903d, y: 0.5560082796213602d), new NpgsqlTypes.NpgsqlPoint(x: 0.22294653249180485d, y: 0.9629362097061859d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 155,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36649369334420534d, y: 0.6340216648516539d), new NpgsqlTypes.NpgsqlPoint(x: 0.994949518246426d, y: 0.36578081757982206d), new NpgsqlTypes.NpgsqlPoint(x: 0.40441141984117224d, y: 0.09030767812253193d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 87,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6364774035768856d, y: 0.19882193341614562d), new NpgsqlTypes.NpgsqlPoint(x: 0.6526889398222924d, y: 0.24918894967266836d), new NpgsqlTypes.NpgsqlPoint(x: 0.6869884817460409d, y: 0.1137825465649136d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8528025876222897d, y: 0.28521372012766766d), new NpgsqlTypes.NpgsqlPoint(x: 0.269633994634461d, y: 0.27447968911136067d), new NpgsqlTypes.NpgsqlPoint(x: 0.04270370535520729d, y: 0.9811983110081067d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 159,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9526975412524353d, y: 0.6363573490083531d), new NpgsqlTypes.NpgsqlPoint(x: 0.9276809673082593d, y: 0.8540843487938552d), new NpgsqlTypes.NpgsqlPoint(x: 0.578920397236465d, y: 0.45570211857049847d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19131814165158234d, y: 0.344589136273333d), new NpgsqlTypes.NpgsqlPoint(x: 0.42368207378951206d, y: 0.12449586974756466d), new NpgsqlTypes.NpgsqlPoint(x: 0.6973913075251269d, y: 0.4051478635822826d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 163,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1482428180107903d, y: 0.717761937467726d), new NpgsqlTypes.NpgsqlPoint(x: 0.5374533716819831d, y: 0.4255842287337902d), new NpgsqlTypes.NpgsqlPoint(x: 0.9204091136935705d, y: 0.9629949866564589d)),
    ModelInner = new NpgsqlPolygonpolygonE0MI
{
    Id = 92,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.639885449814617d, y: 0.9078601582049366d), new NpgsqlTypes.NpgsqlPoint(x: 0.2711153502806255d, y: 0.7119964312088698d), new NpgsqlTypes.NpgsqlPoint(x: 0.4429661822612012d, y: 0.5215704493399559d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6338954458935542d, y: 0.3185782363408445d), new NpgsqlTypes.NpgsqlPoint(x: 0.519781002684801d, y: 0.4438869726982938d), new NpgsqlTypes.NpgsqlPoint(x: 0.15065044386489113d, y: 0.21007641985042003d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7807382084848022d, y: 0.027319073852224096d), new NpgsqlTypes.NpgsqlPoint(x: 0.6387747471865666d, y: 0.9916550396406069d), new NpgsqlTypes.NpgsqlPoint(x: 0.16958577356534887d, y: 0.6877805051160859d)),
},
            new NpgsqlPolygonpolygonE0M
{
    Id = 167,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12511195852630708d, y: 0.3220007317025293d), new NpgsqlTypes.NpgsqlPoint(x: 0.8951582876626288d, y: 0.32031608386009647d), new NpgsqlTypes.NpgsqlPoint(x: 0.9739876885575891d, y: 0.06836645255136298d)),
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygone0mi(
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygone0mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(16))]
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

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygone0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    @id,
    @value, 
    @nullablevalue
)
",
            methodName:"DbConnectionInsertInnerModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13), 
                nullable: true)]
        public void DbConnectionInsertInnerModelConfig()
        {
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygone0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygone0mi_id
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygone0mi_id", 
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
                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygone0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygone0mi_id
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
    npgsqlpolygonpolygone0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                NpgsqlTypes.NpgsqlPolygon? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
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

                    nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49416485053197134d, y: 0.9129812148104237d), new NpgsqlTypes.NpgsqlPoint(x: 0.28516609965959416d, y: 0.6181006993677551d), new NpgsqlTypes.NpgsqlPoint(x: 0.9194388281928451d, y: 0.8991243809592162d))));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
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

                    nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlPolygon? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
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

                    nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08416180868428669d, y: 0.9159391299888091d), new NpgsqlTypes.NpgsqlPoint(x: 0.6885947419781565d, y: 0.09652736243698634d), new NpgsqlTypes.NpgsqlPoint(x: 0.5076150043953697d, y: 0.5599043957623961d))));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
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

                    nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygone0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygone0mi_id
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
    npgsqlpolygonpolygone0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygone0mi_id", 
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
                NpgsqlTypes.NpgsqlPolygon? nullable = null;
                nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon? nullable = null;
                nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8672940923528757d, y: 0.44315851342596313d), new NpgsqlTypes.NpgsqlPoint(x: 0.7319798876368305d, y: 0.1833381342671102d), new NpgsqlTypes.NpgsqlPoint(x: 0.7431915968087887d, y: 0.11176403681655989d))));
                nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.801570104621146d, y: 0.6940442497431853d), new NpgsqlTypes.NpgsqlPoint(x: 0.9364744813133307d, y: 0.6631582053367492d), new NpgsqlTypes.NpgsqlPoint(x: 0.16381737493519577d, y: 0.6216885647322588d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonE0M> models = null;

                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonE0M> models = null;

                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygone0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygone0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlpolygonpolygone0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlPolygon), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlpolygonpolygone0mi_id", 
                methodParametrName: "npgsqlpolygonpolygone0mi_id", 
                dbType: (System.Data.DbType)(11),
                nullable: true)]
        public void DbConnectionInsertModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonE0M), typeof(FlatNpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
LEFT JOIN public.npgsqlpolygonpolygone0mi mi ON mi.id = m.npgsqlpolygonpolygone0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonE0M), typeof(FlatNpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
LEFT JOIN public.npgsqlpolygonpolygone0mi mi ON mi.id = m.npgsqlpolygonpolygone0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonE0M), typeof(FlatNpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr2.Value = 80;
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 155;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 143;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[21],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 55;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 109;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 8;
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 109;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 25;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 84;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
LEFT JOIN public.npgsqlpolygonpolygone0mi mi ON mi.id = m.npgsqlpolygonpolygone0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 94;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[29], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[30], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[31], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[32], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[33], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[28],_testData[29], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[29],_testData[30], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[30],_testData[31], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[31],_testData[32], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[32],_testData[33], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[33],_testData[34], false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 159;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[29], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[30], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[31], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[32], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[33], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonE0M), typeof(FlatNpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 43, query1, 17, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 8, query1, 80, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[17],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 48, query1, 21, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelBatch(connection, 84, query1, 92, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[14],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 143, query1, 69, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[19],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 84, query1, 143, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTDynQuerySelectModelBatch(connection, 17, query1, 17, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(models[30],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
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
FROM public.npgsqlpolygonpolygone0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonE0M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonE0M>();
                 ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatch(connection, 8, query1, 155, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlPolygonpolygonE0M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
LEFT JOIN public.npgsqlpolygonpolygone0mi mi ON mi.id = m.npgsqlpolygonpolygone0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelBatchAsync(connection, 8, 56))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[27],_testData[29], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[28],_testData[30], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[29],_testData[31], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[30],_testData[32], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[31],_testData[33], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[13], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[14], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[15], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[16], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[17], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[18], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[19], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[20], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[21], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[22], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[23], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[24], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[25], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[26], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[27], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[28], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[29], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[30], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[18],_testData[31], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[19],_testData[32], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[20],_testData[33], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[21],_testData[34], false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonE0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSTSelectModelBatch(connection, 47, 47))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[10], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[11], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[12], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[13], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[14], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[15], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[16], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[17], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[18], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[19], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[20], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[21], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[22], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[23], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[24], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[25], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[26], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[27], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[18],_testData[28], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[19],_testData[29], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[20],_testData[30], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[21],_testData[31], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[22],_testData[32], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[23],_testData[33], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[10], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[11], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[12], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[13], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[14], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[15], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[16], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[17], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[18], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[19], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[20], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[21], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[22], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[23], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[24], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[25], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[26], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[27], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[18],_testData[28], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[19],_testData[29], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[20],_testData[30], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[21],_testData[31], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[22],_testData[32], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[23],_testData[33], false);
                        NpgsqlPolygonpolygonE0M.AssertModel(models[24],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPolygonSingleTypepolygon)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 115);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(11));

                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[24], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[25], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[26], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[27], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[28], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[29], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[30], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[31], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[32], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[33], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonSingleTypepolygon)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 80);
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));

                NpgsqlPolygonpolygonE0M.AssertModel(models[0],_testData[17], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[1],_testData[18], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[2],_testData[19], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[3],_testData[20], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[4],_testData[21], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[5],_testData[22], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[6],_testData[23], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[7],_testData[24], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[8],_testData[25], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[9],_testData[26], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[10],_testData[27], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[11],_testData[28], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[12],_testData[29], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[13],_testData[30], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[14],_testData[31], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[15],_testData[32], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[16],_testData[33], false);
                NpgsqlPolygonpolygonE0M.AssertModel(models[17],_testData[34], false);
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
FROM public.npgsqlpolygonpolygone0m m
LEFT JOIN public.npgsqlpolygonpolygone0mi mi ON mi.id = m.npgsqlpolygonpolygone0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelToObjArr",
            queryMapTypes: [typeof(object[])],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11744116522456216d, y: 0.8080292074630436d), new NpgsqlTypes.NpgsqlPoint(x: 0.26297427464203615d, y: 0.9122659143715751d), new NpgsqlTypes.NpgsqlPoint(x: 0.7678089982416562d, y: 0.0409360432680379d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37204150550427295d, y: 0.4823851451376092d), new NpgsqlTypes.NpgsqlPoint(x: 0.8422364893541612d, y: 0.33845253860720226d), new NpgsqlTypes.NpgsqlPoint(x: 0.7771559223757499d, y: 0.2616719016051241d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8137097932743937d, y: 0.3165235588135562d), new NpgsqlTypes.NpgsqlPoint(x: 0.5298255095161585d, y: 0.9365119165305731d), new NpgsqlTypes.NpgsqlPoint(x: 0.3017816692221529d, y: 0.3543543579584756d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26411753125429227d, y: 0.11998443814254522d), new NpgsqlTypes.NpgsqlPoint(x: 0.7221700029288811d, y: 0.7772844228379054d), new NpgsqlTypes.NpgsqlPoint(x: 0.4180710888046508d, y: 0.03376997191951514d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2893243687519965d, y: 0.5654654310552499d), new NpgsqlTypes.NpgsqlPoint(x: 0.744547518379859d, y: 0.96072697884504d), new NpgsqlTypes.NpgsqlPoint(x: 0.05123555956908177d, y: 0.6418186968783319d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8036466363048586d, y: 0.5465964241621563d), new NpgsqlTypes.NpgsqlPoint(x: 0.8027375164715889d, y: 0.3216319165916741d), new NpgsqlTypes.NpgsqlPoint(x: 0.993092604144047d, y: 0.31889345559084104d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36889227641057765d, y: 0.16995207627320286d), new NpgsqlTypes.NpgsqlPoint(x: 0.2528617151494159d, y: 0.09576771363063252d), new NpgsqlTypes.NpgsqlPoint(x: 0.23723381171396984d, y: 0.5838108901641144d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49416485053197134d, y: 0.9129812148104237d), new NpgsqlTypes.NpgsqlPoint(x: 0.28516609965959416d, y: 0.6181006993677551d), new NpgsqlTypes.NpgsqlPoint(x: 0.9194388281928451d, y: 0.8991243809592162d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6173442884802274d, y: 0.1753395582331344d), new NpgsqlTypes.NpgsqlPoint(x: 0.24729687612667628d, y: 0.7863970688607469d), new NpgsqlTypes.NpgsqlPoint(x: 0.156921628988146d, y: 0.38138002625440326d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07763152148082131d, y: 0.3948912675369408d), new NpgsqlTypes.NpgsqlPoint(x: 0.29504837166719666d, y: 0.6168028106266379d), new NpgsqlTypes.NpgsqlPoint(x: 0.4666380176411591d, y: 0.09564606492961447d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8005867328985076d, y: 0.08678133726398152d), new NpgsqlTypes.NpgsqlPoint(x: 0.39477493773722405d, y: 0.9073305766466921d), new NpgsqlTypes.NpgsqlPoint(x: 0.6934414590623912d, y: 0.20768159738334346d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09726790042555644d, y: 0.7456752692395532d), new NpgsqlTypes.NpgsqlPoint(x: 0.8944235502068905d, y: 0.3578467942280542d), new NpgsqlTypes.NpgsqlPoint(x: 0.6567215243084218d, y: 0.362290955045099d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08416180868428669d, y: 0.9159391299888091d), new NpgsqlTypes.NpgsqlPoint(x: 0.6885947419781565d, y: 0.09652736243698634d), new NpgsqlTypes.NpgsqlPoint(x: 0.5076150043953697d, y: 0.5599043957623961d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6876683867902811d, y: 0.4136984241094829d), new NpgsqlTypes.NpgsqlPoint(x: 0.1480751167060229d, y: 0.756123213322278d), new NpgsqlTypes.NpgsqlPoint(x: 0.9059810670623957d, y: 0.6988323440481766d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46009843262405004d, y: 0.4128498708891488d), new NpgsqlTypes.NpgsqlPoint(x: 0.8513026562883999d, y: 0.5194171209323957d), new NpgsqlTypes.NpgsqlPoint(x: 0.6480801969555081d, y: 0.9864611740034808d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6817539159949695d, y: 0.6577557702398262d), new NpgsqlTypes.NpgsqlPoint(x: 0.7962068117532322d, y: 0.2236535637811442d), new NpgsqlTypes.NpgsqlPoint(x: 0.2605423421172198d, y: 0.6777897449137255d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4402030098326507d, y: 0.40429927981458036d), new NpgsqlTypes.NpgsqlPoint(x: 0.4636776693725475d, y: 0.5366373968089634d), new NpgsqlTypes.NpgsqlPoint(x: 0.07761622645187827d, y: 0.5004872596739022d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9309617031248556d, y: 0.3662541954784956d), new NpgsqlTypes.NpgsqlPoint(x: 0.44952289090570097d, y: 0.05713229922883356d), new NpgsqlTypes.NpgsqlPoint(x: 0.6367514968606197d, y: 0.373707353850532d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3885517981604488d, y: 0.648029711179966d), new NpgsqlTypes.NpgsqlPoint(x: 0.07558698501323824d, y: 0.9165111466564242d), new NpgsqlTypes.NpgsqlPoint(x: 0.8226178218801861d, y: 0.0064548729110668335d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4005707471511124d, y: 0.48524492135756103d), new NpgsqlTypes.NpgsqlPoint(x: 0.7127731161293489d, y: 0.1941075380065882d), new NpgsqlTypes.NpgsqlPoint(x: 0.6380323444791629d, y: 0.04721331325995248d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8672940923528757d, y: 0.44315851342596313d), new NpgsqlTypes.NpgsqlPoint(x: 0.7319798876368305d, y: 0.1833381342671102d), new NpgsqlTypes.NpgsqlPoint(x: 0.7431915968087887d, y: 0.11176403681655989d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5424941470432981d, y: 0.787532173212718d), new NpgsqlTypes.NpgsqlPoint(x: 0.6869608081331918d, y: 0.7040126205341468d), new NpgsqlTypes.NpgsqlPoint(x: 0.23659149266470392d, y: 0.5202386923380911d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.930534069927414d, y: 0.49612771877691575d), new NpgsqlTypes.NpgsqlPoint(x: 0.5774382881949913d, y: 0.02022377221747307d), new NpgsqlTypes.NpgsqlPoint(x: 0.4972425122508942d, y: 0.7556727920269157d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.801570104621146d, y: 0.6940442497431853d), new NpgsqlTypes.NpgsqlPoint(x: 0.9364744813133307d, y: 0.6631582053367492d), new NpgsqlTypes.NpgsqlPoint(x: 0.16381737493519577d, y: 0.6216885647322588d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4207677929944226d, y: 0.9319280702694366d), new NpgsqlTypes.NpgsqlPoint(x: 0.09380541601799419d, y: 0.08341727699678081d), new NpgsqlTypes.NpgsqlPoint(x: 0.9652955776904004d, y: 0.9171741373709297d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8088001073354774d, y: 0.679685561825214d), new NpgsqlTypes.NpgsqlPoint(x: 0.5846673454208797d, y: 0.4945626588173574d), new NpgsqlTypes.NpgsqlPoint(x: 0.49535212301440323d, y: 0.6583006354238327d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6347561683456207d, y: 0.9478918108992118d), new NpgsqlTypes.NpgsqlPoint(x: 0.1688154786353825d, y: 0.7890845649539903d), new NpgsqlTypes.NpgsqlPoint(x: 0.25748213411013d, y: 0.5195562146231794d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4921680784318516d, y: 0.31247579208487775d), new NpgsqlTypes.NpgsqlPoint(x: 0.2249215334547664d, y: 0.4210439100817015d), new NpgsqlTypes.NpgsqlPoint(x: 0.7025199075109024d, y: 0.1744525207294565d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6811652168762848d, y: 0.9591284177257816d), new NpgsqlTypes.NpgsqlPoint(x: 0.3192168253924009d, y: 0.15784132490199554d), new NpgsqlTypes.NpgsqlPoint(x: 0.7824249070665993d, y: 0.6228314758641585d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17906816973840978d, y: 0.1633048202009223d), new NpgsqlTypes.NpgsqlPoint(x: 0.8216844624805967d, y: 0.8674355326112697d), new NpgsqlTypes.NpgsqlPoint(x: 0.6305446014048083d, y: 0.43662357854563927d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3105215369100073d, y: 0.2531699710407568d), new NpgsqlTypes.NpgsqlPoint(x: 0.5910625595344048d, y: 0.7768416894315913d), new NpgsqlTypes.NpgsqlPoint(x: 0.0513867584286799d, y: 0.2862049558780051d)))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6224213828486846d, y: 0.7592490434757979d), new NpgsqlTypes.NpgsqlPoint(x: 0.11471440304385783d, y: 0.6089843384457247d), new NpgsqlTypes.NpgsqlPoint(x: 0.06317585320605079d, y: 0.38223333604429144d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5980562725096651d, y: 0.5800056499743034d), new NpgsqlTypes.NpgsqlPoint(x: 0.6128131858708696d, y: 0.5989199741089791d), new NpgsqlTypes.NpgsqlPoint(x: 0.05629479026092188d, y: 0.4120361417896027d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6055814645068255d, y: 0.6705832043859066d), new NpgsqlTypes.NpgsqlPoint(x: 0.5111159952071609d, y: 0.8586660249237027d), new NpgsqlTypes.NpgsqlPoint(x: 0.6203609428140293d, y: 0.5837330197811291d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24633304211062246d, y: 0.5312064043655454d), new NpgsqlTypes.NpgsqlPoint(x: 0.3182875709726545d, y: 0.892750671856647d), new NpgsqlTypes.NpgsqlPoint(x: 0.42810728416500154d, y: 0.7679002676248425d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.957435915110089d, y: 0.7132442835089249d), new NpgsqlTypes.NpgsqlPoint(x: 0.8906299384392043d, y: 0.1946674177347133d), new NpgsqlTypes.NpgsqlPoint(x: 0.4361124989562897d, y: 0.798314327992721d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3703330551115728d, y: 0.2829530102832811d), new NpgsqlTypes.NpgsqlPoint(x: 0.5849156797053499d, y: 0.341614177435263d), new NpgsqlTypes.NpgsqlPoint(x: 0.14347870993345802d, y: 0.7550531464183213d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8594683743944733d, y: 0.6625389901633929d), new NpgsqlTypes.NpgsqlPoint(x: 0.5873827172831034d, y: 0.17272500251428113d), new NpgsqlTypes.NpgsqlPoint(x: 0.807110613951904d, y: 0.11435477917289105d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.267607153944338d, y: 0.9872383718044287d), new NpgsqlTypes.NpgsqlPoint(x: 0.3493795508088755d, y: 0.6637767928899361d), new NpgsqlTypes.NpgsqlPoint(x: 0.5384710747758226d, y: 0.24912707177408844d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8479945567716112d, y: 0.03702137007410877d), new NpgsqlTypes.NpgsqlPoint(x: 0.1732743684778203d, y: 0.8136599195964629d), new NpgsqlTypes.NpgsqlPoint(x: 0.7704846735383413d, y: 0.913432864663654d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1659401892139013d, y: 0.0339264365626194d), new NpgsqlTypes.NpgsqlPoint(x: 0.3114145263225886d, y: 0.774460261730912d), new NpgsqlTypes.NpgsqlPoint(x: 0.6285132807831189d, y: 0.1006060410882964d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2742030520599775d, y: 0.6843858470259879d), new NpgsqlTypes.NpgsqlPoint(x: 0.35074233200242355d, y: 0.20097352416707237d), new NpgsqlTypes.NpgsqlPoint(x: 0.005756957630341564d, y: 0.7370786306194561d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7568355232020736d, y: 0.30370717628789123d), new NpgsqlTypes.NpgsqlPoint(x: 0.6890469671943414d, y: 0.0739971068115175d), new NpgsqlTypes.NpgsqlPoint(x: 0.3463793280119525d, y: 0.6585850646551492d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9316225141114967d, y: 0.6434494756204737d), new NpgsqlTypes.NpgsqlPoint(x: 0.25760216627420285d, y: 0.9412367678354755d), new NpgsqlTypes.NpgsqlPoint(x: 0.27645565798143157d, y: 0.8791234148759219d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.648658026450837d, y: 0.7648860738751331d), new NpgsqlTypes.NpgsqlPoint(x: 0.3466712819408605d, y: 0.5396931293266067d), new NpgsqlTypes.NpgsqlPoint(x: 0.24938325752051038d, y: 0.4704365402638465d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37240782656033866d, y: 0.28641560486101525d), new NpgsqlTypes.NpgsqlPoint(x: 0.659518039526747d, y: 0.6291607422818101d), new NpgsqlTypes.NpgsqlPoint(x: 0.5859514955763284d, y: 0.4104716323090387d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2498524368984414d, y: 0.7271752912883135d), new NpgsqlTypes.NpgsqlPoint(x: 0.27142125722921884d, y: 0.8616237940475655d), new NpgsqlTypes.NpgsqlPoint(x: 0.09780877159537793d, y: 0.9908342692836339d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.585649392407402d, y: 0.5330104696868752d), new NpgsqlTypes.NpgsqlPoint(x: 0.3681982996048432d, y: 0.28330928253410803d), new NpgsqlTypes.NpgsqlPoint(x: 0.05871904581430465d, y: 0.2771272020851371d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5721460467773629d, y: 0.6949587785926449d), new NpgsqlTypes.NpgsqlPoint(x: 0.2565467833218378d, y: 0.9093765156631648d), new NpgsqlTypes.NpgsqlPoint(x: 0.10381930983524446d, y: 0.9640751657289774d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32910808085129795d, y: 0.1502831026198087d), new NpgsqlTypes.NpgsqlPoint(x: 0.43536519011429875d, y: 0.676438863203158d), new NpgsqlTypes.NpgsqlPoint(x: 0.8557728763769086d, y: 0.5981619811864382d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04041920739046401d, y: 0.9743868906213419d), new NpgsqlTypes.NpgsqlPoint(x: 0.3263708760011601d, y: 0.5142180700835731d), new NpgsqlTypes.NpgsqlPoint(x: 0.5246467654268528d, y: 0.24995722055155367d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5865525950861209d, y: 0.7438692038855318d), new NpgsqlTypes.NpgsqlPoint(x: 0.7999101641440779d, y: 0.48002632279883883d), new NpgsqlTypes.NpgsqlPoint(x: 0.9268892629523803d, y: 0.10079355059622441d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7899535019918573d, y: 0.9452267253254162d), new NpgsqlTypes.NpgsqlPoint(x: 0.8722164661276328d, y: 0.34768289665454466d), new NpgsqlTypes.NpgsqlPoint(x: 0.5781531125318417d, y: 0.9125007054892716d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23992633438949573d, y: 0.9057257764662182d), new NpgsqlTypes.NpgsqlPoint(x: 0.6459389448532546d, y: 0.587350532933259d), new NpgsqlTypes.NpgsqlPoint(x: 0.019775452978905927d, y: 0.8483247032952146d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8953734628620403d, y: 0.8569880451675662d), new NpgsqlTypes.NpgsqlPoint(x: 0.16274734382621459d, y: 0.13675694113379622d), new NpgsqlTypes.NpgsqlPoint(x: 0.4317183954492072d, y: 0.7193114446039137d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0473829832596071d, y: 0.42727458751410163d), new NpgsqlTypes.NpgsqlPoint(x: 0.9211130123593599d, y: 0.03397934031513716d), new NpgsqlTypes.NpgsqlPoint(x: 0.5122832710054699d, y: 0.06284811826688153d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.361259205243573d, y: 0.6503022368041134d), new NpgsqlTypes.NpgsqlPoint(x: 0.4815586803908477d, y: 0.48297127705264153d), new NpgsqlTypes.NpgsqlPoint(x: 0.3234349141681395d, y: 0.051329410528775155d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6858944936799658d, y: 0.11568926104058119d), new NpgsqlTypes.NpgsqlPoint(x: 0.9229945930540254d, y: 0.10514030040581246d), new NpgsqlTypes.NpgsqlPoint(x: 0.2518814619804973d, y: 0.37014567906759654d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6805289315883503d, y: 0.40703474217123325d), new NpgsqlTypes.NpgsqlPoint(x: 0.33499651324480684d, y: 0.10957153252573504d), new NpgsqlTypes.NpgsqlPoint(x: 0.5063439539401062d, y: 0.6240619083801667d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.014829946594323129d, y: 0.4210486009319908d), new NpgsqlTypes.NpgsqlPoint(x: 0.5987090856594539d, y: 0.6938437562770255d), new NpgsqlTypes.NpgsqlPoint(x: 0.5958133367004497d, y: 0.40422693486328665d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3393702447213197d, y: 0.30600484954452956d), new NpgsqlTypes.NpgsqlPoint(x: 0.9552672378008559d, y: 0.6437288620814756d), new NpgsqlTypes.NpgsqlPoint(x: 0.3469120222934713d, y: 0.4322135032664176d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9151172469131114d, y: 0.47845998737946116d), new NpgsqlTypes.NpgsqlPoint(x: 0.27865540667420896d, y: 0.979926793004106d), new NpgsqlTypes.NpgsqlPoint(x: 0.6533387424668993d, y: 0.5950177000379671d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4624885076228301d, y: 0.9284246248953058d), new NpgsqlTypes.NpgsqlPoint(x: 0.8154676914615885d, y: 0.4824958107583439d), new NpgsqlTypes.NpgsqlPoint(x: 0.37464969268090587d, y: 0.8052768878279666d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.012493758705959035d, y: 0.6493531714019971d), new NpgsqlTypes.NpgsqlPoint(x: 0.24471302941239903d, y: 0.5560082796213602d), new NpgsqlTypes.NpgsqlPoint(x: 0.22294653249180485d, y: 0.9629362097061859d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36649369334420534d, y: 0.6340216648516539d), new NpgsqlTypes.NpgsqlPoint(x: 0.994949518246426d, y: 0.36578081757982206d), new NpgsqlTypes.NpgsqlPoint(x: 0.40441141984117224d, y: 0.09030767812253193d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6364774035768856d, y: 0.19882193341614562d), new NpgsqlTypes.NpgsqlPoint(x: 0.6526889398222924d, y: 0.24918894967266836d), new NpgsqlTypes.NpgsqlPoint(x: 0.6869884817460409d, y: 0.1137825465649136d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8528025876222897d, y: 0.28521372012766766d), new NpgsqlTypes.NpgsqlPoint(x: 0.269633994634461d, y: 0.27447968911136067d), new NpgsqlTypes.NpgsqlPoint(x: 0.04270370535520729d, y: 0.9811983110081067d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9526975412524353d, y: 0.6363573490083531d), new NpgsqlTypes.NpgsqlPoint(x: 0.9276809673082593d, y: 0.8540843487938552d), new NpgsqlTypes.NpgsqlPoint(x: 0.578920397236465d, y: 0.45570211857049847d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19131814165158234d, y: 0.344589136273333d), new NpgsqlTypes.NpgsqlPoint(x: 0.42368207378951206d, y: 0.12449586974756466d), new NpgsqlTypes.NpgsqlPoint(x: 0.6973913075251269d, y: 0.4051478635822826d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1482428180107903d, y: 0.717761937467726d), new NpgsqlTypes.NpgsqlPoint(x: 0.5374533716819831d, y: 0.4255842287337902d), new NpgsqlTypes.NpgsqlPoint(x: 0.9204091136935705d, y: 0.9629949866564589d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((92)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.639885449814617d, y: 0.9078601582049366d), new NpgsqlTypes.NpgsqlPoint(x: 0.2711153502806255d, y: 0.7119964312088698d), new NpgsqlTypes.NpgsqlPoint(x: 0.4429661822612012d, y: 0.5215704493399559d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6338954458935542d, y: 0.3185782363408445d), new NpgsqlTypes.NpgsqlPoint(x: 0.519781002684801d, y: 0.4438869726982938d), new NpgsqlTypes.NpgsqlPoint(x: 0.15065044386489113d, y: 0.21007641985042003d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7807382084848022d, y: 0.027319073852224096d), new NpgsqlTypes.NpgsqlPoint(x: 0.6387747471865666d, y: 0.9916550396406069d), new NpgsqlTypes.NpgsqlPoint(x: 0.16958577356534887d, y: 0.6877805051160859d)))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12511195852630708d, y: 0.3220007317025293d), new NpgsqlTypes.NpgsqlPoint(x: 0.8951582876626288d, y: 0.32031608386009647d), new NpgsqlTypes.NpgsqlPoint(x: 0.9739876885575891d, y: 0.06836645255136298d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11744116522456216d, y: 0.8080292074630436d), new NpgsqlTypes.NpgsqlPoint(x: 0.26297427464203615d, y: 0.9122659143715751d), new NpgsqlTypes.NpgsqlPoint(x: 0.7678089982416562d, y: 0.0409360432680379d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37204150550427295d, y: 0.4823851451376092d), new NpgsqlTypes.NpgsqlPoint(x: 0.8422364893541612d, y: 0.33845253860720226d), new NpgsqlTypes.NpgsqlPoint(x: 0.7771559223757499d, y: 0.2616719016051241d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((6)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8137097932743937d, y: 0.3165235588135562d), new NpgsqlTypes.NpgsqlPoint(x: 0.5298255095161585d, y: 0.9365119165305731d), new NpgsqlTypes.NpgsqlPoint(x: 0.3017816692221529d, y: 0.3543543579584756d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((12)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26411753125429227d, y: 0.11998443814254522d), new NpgsqlTypes.NpgsqlPoint(x: 0.7221700029288811d, y: 0.7772844228379054d), new NpgsqlTypes.NpgsqlPoint(x: 0.4180710888046508d, y: 0.03376997191951514d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2893243687519965d, y: 0.5654654310552499d), new NpgsqlTypes.NpgsqlPoint(x: 0.744547518379859d, y: 0.96072697884504d), new NpgsqlTypes.NpgsqlPoint(x: 0.05123555956908177d, y: 0.6418186968783319d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8036466363048586d, y: 0.5465964241621563d), new NpgsqlTypes.NpgsqlPoint(x: 0.8027375164715889d, y: 0.3216319165916741d), new NpgsqlTypes.NpgsqlPoint(x: 0.993092604144047d, y: 0.31889345559084104d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36889227641057765d, y: 0.16995207627320286d), new NpgsqlTypes.NpgsqlPoint(x: 0.2528617151494159d, y: 0.09576771363063252d), new NpgsqlTypes.NpgsqlPoint(x: 0.23723381171396984d, y: 0.5838108901641144d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49416485053197134d, y: 0.9129812148104237d), new NpgsqlTypes.NpgsqlPoint(x: 0.28516609965959416d, y: 0.6181006993677551d), new NpgsqlTypes.NpgsqlPoint(x: 0.9194388281928451d, y: 0.8991243809592162d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6173442884802274d, y: 0.1753395582331344d), new NpgsqlTypes.NpgsqlPoint(x: 0.24729687612667628d, y: 0.7863970688607469d), new NpgsqlTypes.NpgsqlPoint(x: 0.156921628988146d, y: 0.38138002625440326d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07763152148082131d, y: 0.3948912675369408d), new NpgsqlTypes.NpgsqlPoint(x: 0.29504837166719666d, y: 0.6168028106266379d), new NpgsqlTypes.NpgsqlPoint(x: 0.4666380176411591d, y: 0.09564606492961447d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8005867328985076d, y: 0.08678133726398152d), new NpgsqlTypes.NpgsqlPoint(x: 0.39477493773722405d, y: 0.9073305766466921d), new NpgsqlTypes.NpgsqlPoint(x: 0.6934414590623912d, y: 0.20768159738334346d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09726790042555644d, y: 0.7456752692395532d), new NpgsqlTypes.NpgsqlPoint(x: 0.8944235502068905d, y: 0.3578467942280542d), new NpgsqlTypes.NpgsqlPoint(x: 0.6567215243084218d, y: 0.362290955045099d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08416180868428669d, y: 0.9159391299888091d), new NpgsqlTypes.NpgsqlPoint(x: 0.6885947419781565d, y: 0.09652736243698634d), new NpgsqlTypes.NpgsqlPoint(x: 0.5076150043953697d, y: 0.5599043957623961d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6876683867902811d, y: 0.4136984241094829d), new NpgsqlTypes.NpgsqlPoint(x: 0.1480751167060229d, y: 0.756123213322278d), new NpgsqlTypes.NpgsqlPoint(x: 0.9059810670623957d, y: 0.6988323440481766d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46009843262405004d, y: 0.4128498708891488d), new NpgsqlTypes.NpgsqlPoint(x: 0.8513026562883999d, y: 0.5194171209323957d), new NpgsqlTypes.NpgsqlPoint(x: 0.6480801969555081d, y: 0.9864611740034808d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6817539159949695d, y: 0.6577557702398262d), new NpgsqlTypes.NpgsqlPoint(x: 0.7962068117532322d, y: 0.2236535637811442d), new NpgsqlTypes.NpgsqlPoint(x: 0.2605423421172198d, y: 0.6777897449137255d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4402030098326507d, y: 0.40429927981458036d), new NpgsqlTypes.NpgsqlPoint(x: 0.4636776693725475d, y: 0.5366373968089634d), new NpgsqlTypes.NpgsqlPoint(x: 0.07761622645187827d, y: 0.5004872596739022d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9309617031248556d, y: 0.3662541954784956d), new NpgsqlTypes.NpgsqlPoint(x: 0.44952289090570097d, y: 0.05713229922883356d), new NpgsqlTypes.NpgsqlPoint(x: 0.6367514968606197d, y: 0.373707353850532d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3885517981604488d, y: 0.648029711179966d), new NpgsqlTypes.NpgsqlPoint(x: 0.07558698501323824d, y: 0.9165111466564242d), new NpgsqlTypes.NpgsqlPoint(x: 0.8226178218801861d, y: 0.0064548729110668335d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4005707471511124d, y: 0.48524492135756103d), new NpgsqlTypes.NpgsqlPoint(x: 0.7127731161293489d, y: 0.1941075380065882d), new NpgsqlTypes.NpgsqlPoint(x: 0.6380323444791629d, y: 0.04721331325995248d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8672940923528757d, y: 0.44315851342596313d), new NpgsqlTypes.NpgsqlPoint(x: 0.7319798876368305d, y: 0.1833381342671102d), new NpgsqlTypes.NpgsqlPoint(x: 0.7431915968087887d, y: 0.11176403681655989d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5424941470432981d, y: 0.787532173212718d), new NpgsqlTypes.NpgsqlPoint(x: 0.6869608081331918d, y: 0.7040126205341468d), new NpgsqlTypes.NpgsqlPoint(x: 0.23659149266470392d, y: 0.5202386923380911d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((33)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.930534069927414d, y: 0.49612771877691575d), new NpgsqlTypes.NpgsqlPoint(x: 0.5774382881949913d, y: 0.02022377221747307d), new NpgsqlTypes.NpgsqlPoint(x: 0.4972425122508942d, y: 0.7556727920269157d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.801570104621146d, y: 0.6940442497431853d), new NpgsqlTypes.NpgsqlPoint(x: 0.9364744813133307d, y: 0.6631582053367492d), new NpgsqlTypes.NpgsqlPoint(x: 0.16381737493519577d, y: 0.6216885647322588d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4207677929944226d, y: 0.9319280702694366d), new NpgsqlTypes.NpgsqlPoint(x: 0.09380541601799419d, y: 0.08341727699678081d), new NpgsqlTypes.NpgsqlPoint(x: 0.9652955776904004d, y: 0.9171741373709297d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8088001073354774d, y: 0.679685561825214d), new NpgsqlTypes.NpgsqlPoint(x: 0.5846673454208797d, y: 0.4945626588173574d), new NpgsqlTypes.NpgsqlPoint(x: 0.49535212301440323d, y: 0.6583006354238327d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((38)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6347561683456207d, y: 0.9478918108992118d), new NpgsqlTypes.NpgsqlPoint(x: 0.1688154786353825d, y: 0.7890845649539903d), new NpgsqlTypes.NpgsqlPoint(x: 0.25748213411013d, y: 0.5195562146231794d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4921680784318516d, y: 0.31247579208487775d), new NpgsqlTypes.NpgsqlPoint(x: 0.2249215334547664d, y: 0.4210439100817015d), new NpgsqlTypes.NpgsqlPoint(x: 0.7025199075109024d, y: 0.1744525207294565d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6811652168762848d, y: 0.9591284177257816d), new NpgsqlTypes.NpgsqlPoint(x: 0.3192168253924009d, y: 0.15784132490199554d), new NpgsqlTypes.NpgsqlPoint(x: 0.7824249070665993d, y: 0.6228314758641585d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17906816973840978d, y: 0.1633048202009223d), new NpgsqlTypes.NpgsqlPoint(x: 0.8216844624805967d, y: 0.8674355326112697d), new NpgsqlTypes.NpgsqlPoint(x: 0.6305446014048083d, y: 0.43662357854563927d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3105215369100073d, y: 0.2531699710407568d), new NpgsqlTypes.NpgsqlPoint(x: 0.5910625595344048d, y: 0.7768416894315913d), new NpgsqlTypes.NpgsqlPoint(x: 0.0513867584286799d, y: 0.2862049558780051d)))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6224213828486846d, y: 0.7592490434757979d), new NpgsqlTypes.NpgsqlPoint(x: 0.11471440304385783d, y: 0.6089843384457247d), new NpgsqlTypes.NpgsqlPoint(x: 0.06317585320605079d, y: 0.38223333604429144d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5980562725096651d, y: 0.5800056499743034d), new NpgsqlTypes.NpgsqlPoint(x: 0.6128131858708696d, y: 0.5989199741089791d), new NpgsqlTypes.NpgsqlPoint(x: 0.05629479026092188d, y: 0.4120361417896027d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6055814645068255d, y: 0.6705832043859066d), new NpgsqlTypes.NpgsqlPoint(x: 0.5111159952071609d, y: 0.8586660249237027d), new NpgsqlTypes.NpgsqlPoint(x: 0.6203609428140293d, y: 0.5837330197811291d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((84)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24633304211062246d, y: 0.5312064043655454d), new NpgsqlTypes.NpgsqlPoint(x: 0.3182875709726545d, y: 0.892750671856647d), new NpgsqlTypes.NpgsqlPoint(x: 0.42810728416500154d, y: 0.7679002676248425d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.957435915110089d, y: 0.7132442835089249d), new NpgsqlTypes.NpgsqlPoint(x: 0.8906299384392043d, y: 0.1946674177347133d), new NpgsqlTypes.NpgsqlPoint(x: 0.4361124989562897d, y: 0.798314327992721d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3703330551115728d, y: 0.2829530102832811d), new NpgsqlTypes.NpgsqlPoint(x: 0.5849156797053499d, y: 0.341614177435263d), new NpgsqlTypes.NpgsqlPoint(x: 0.14347870993345802d, y: 0.7550531464183213d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8594683743944733d, y: 0.6625389901633929d), new NpgsqlTypes.NpgsqlPoint(x: 0.5873827172831034d, y: 0.17272500251428113d), new NpgsqlTypes.NpgsqlPoint(x: 0.807110613951904d, y: 0.11435477917289105d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.267607153944338d, y: 0.9872383718044287d), new NpgsqlTypes.NpgsqlPoint(x: 0.3493795508088755d, y: 0.6637767928899361d), new NpgsqlTypes.NpgsqlPoint(x: 0.5384710747758226d, y: 0.24912707177408844d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8479945567716112d, y: 0.03702137007410877d), new NpgsqlTypes.NpgsqlPoint(x: 0.1732743684778203d, y: 0.8136599195964629d), new NpgsqlTypes.NpgsqlPoint(x: 0.7704846735383413d, y: 0.913432864663654d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1659401892139013d, y: 0.0339264365626194d), new NpgsqlTypes.NpgsqlPoint(x: 0.3114145263225886d, y: 0.774460261730912d), new NpgsqlTypes.NpgsqlPoint(x: 0.6285132807831189d, y: 0.1006060410882964d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2742030520599775d, y: 0.6843858470259879d), new NpgsqlTypes.NpgsqlPoint(x: 0.35074233200242355d, y: 0.20097352416707237d), new NpgsqlTypes.NpgsqlPoint(x: 0.005756957630341564d, y: 0.7370786306194561d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7568355232020736d, y: 0.30370717628789123d), new NpgsqlTypes.NpgsqlPoint(x: 0.6890469671943414d, y: 0.0739971068115175d), new NpgsqlTypes.NpgsqlPoint(x: 0.3463793280119525d, y: 0.6585850646551492d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9316225141114967d, y: 0.6434494756204737d), new NpgsqlTypes.NpgsqlPoint(x: 0.25760216627420285d, y: 0.9412367678354755d), new NpgsqlTypes.NpgsqlPoint(x: 0.27645565798143157d, y: 0.8791234148759219d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((59)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.648658026450837d, y: 0.7648860738751331d), new NpgsqlTypes.NpgsqlPoint(x: 0.3466712819408605d, y: 0.5396931293266067d), new NpgsqlTypes.NpgsqlPoint(x: 0.24938325752051038d, y: 0.4704365402638465d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37240782656033866d, y: 0.28641560486101525d), new NpgsqlTypes.NpgsqlPoint(x: 0.659518039526747d, y: 0.6291607422818101d), new NpgsqlTypes.NpgsqlPoint(x: 0.5859514955763284d, y: 0.4104716323090387d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((109)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2498524368984414d, y: 0.7271752912883135d), new NpgsqlTypes.NpgsqlPoint(x: 0.27142125722921884d, y: 0.8616237940475655d), new NpgsqlTypes.NpgsqlPoint(x: 0.09780877159537793d, y: 0.9908342692836339d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((115)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.585649392407402d, y: 0.5330104696868752d), new NpgsqlTypes.NpgsqlPoint(x: 0.3681982996048432d, y: 0.28330928253410803d), new NpgsqlTypes.NpgsqlPoint(x: 0.05871904581430465d, y: 0.2771272020851371d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5721460467773629d, y: 0.6949587785926449d), new NpgsqlTypes.NpgsqlPoint(x: 0.2565467833218378d, y: 0.9093765156631648d), new NpgsqlTypes.NpgsqlPoint(x: 0.10381930983524446d, y: 0.9640751657289774d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32910808085129795d, y: 0.1502831026198087d), new NpgsqlTypes.NpgsqlPoint(x: 0.43536519011429875d, y: 0.676438863203158d), new NpgsqlTypes.NpgsqlPoint(x: 0.8557728763769086d, y: 0.5981619811864382d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04041920739046401d, y: 0.9743868906213419d), new NpgsqlTypes.NpgsqlPoint(x: 0.3263708760011601d, y: 0.5142180700835731d), new NpgsqlTypes.NpgsqlPoint(x: 0.5246467654268528d, y: 0.24995722055155367d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5865525950861209d, y: 0.7438692038855318d), new NpgsqlTypes.NpgsqlPoint(x: 0.7999101641440779d, y: 0.48002632279883883d), new NpgsqlTypes.NpgsqlPoint(x: 0.9268892629523803d, y: 0.10079355059622441d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7899535019918573d, y: 0.9452267253254162d), new NpgsqlTypes.NpgsqlPoint(x: 0.8722164661276328d, y: 0.34768289665454466d), new NpgsqlTypes.NpgsqlPoint(x: 0.5781531125318417d, y: 0.9125007054892716d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((67)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23992633438949573d, y: 0.9057257764662182d), new NpgsqlTypes.NpgsqlPoint(x: 0.6459389448532546d, y: 0.587350532933259d), new NpgsqlTypes.NpgsqlPoint(x: 0.019775452978905927d, y: 0.8483247032952146d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8953734628620403d, y: 0.8569880451675662d), new NpgsqlTypes.NpgsqlPoint(x: 0.16274734382621459d, y: 0.13675694113379622d), new NpgsqlTypes.NpgsqlPoint(x: 0.4317183954492072d, y: 0.7193114446039137d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0473829832596071d, y: 0.42727458751410163d), new NpgsqlTypes.NpgsqlPoint(x: 0.9211130123593599d, y: 0.03397934031513716d), new NpgsqlTypes.NpgsqlPoint(x: 0.5122832710054699d, y: 0.06284811826688153d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.361259205243573d, y: 0.6503022368041134d), new NpgsqlTypes.NpgsqlPoint(x: 0.4815586803908477d, y: 0.48297127705264153d), new NpgsqlTypes.NpgsqlPoint(x: 0.3234349141681395d, y: 0.051329410528775155d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6858944936799658d, y: 0.11568926104058119d), new NpgsqlTypes.NpgsqlPoint(x: 0.9229945930540254d, y: 0.10514030040581246d), new NpgsqlTypes.NpgsqlPoint(x: 0.2518814619804973d, y: 0.37014567906759654d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((143)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6805289315883503d, y: 0.40703474217123325d), new NpgsqlTypes.NpgsqlPoint(x: 0.33499651324480684d, y: 0.10957153252573504d), new NpgsqlTypes.NpgsqlPoint(x: 0.5063439539401062d, y: 0.6240619083801667d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.014829946594323129d, y: 0.4210486009319908d), new NpgsqlTypes.NpgsqlPoint(x: 0.5987090856594539d, y: 0.6938437562770255d), new NpgsqlTypes.NpgsqlPoint(x: 0.5958133367004497d, y: 0.40422693486328665d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((146)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3393702447213197d, y: 0.30600484954452956d), new NpgsqlTypes.NpgsqlPoint(x: 0.9552672378008559d, y: 0.6437288620814756d), new NpgsqlTypes.NpgsqlPoint(x: 0.3469120222934713d, y: 0.4322135032664176d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((81)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9151172469131114d, y: 0.47845998737946116d), new NpgsqlTypes.NpgsqlPoint(x: 0.27865540667420896d, y: 0.979926793004106d), new NpgsqlTypes.NpgsqlPoint(x: 0.6533387424668993d, y: 0.5950177000379671d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4624885076228301d, y: 0.9284246248953058d), new NpgsqlTypes.NpgsqlPoint(x: 0.8154676914615885d, y: 0.4824958107583439d), new NpgsqlTypes.NpgsqlPoint(x: 0.37464969268090587d, y: 0.8052768878279666d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.012493758705959035d, y: 0.6493531714019971d), new NpgsqlTypes.NpgsqlPoint(x: 0.24471302941239903d, y: 0.5560082796213602d), new NpgsqlTypes.NpgsqlPoint(x: 0.22294653249180485d, y: 0.9629362097061859d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((155)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36649369334420534d, y: 0.6340216648516539d), new NpgsqlTypes.NpgsqlPoint(x: 0.994949518246426d, y: 0.36578081757982206d), new NpgsqlTypes.NpgsqlPoint(x: 0.40441141984117224d, y: 0.09030767812253193d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((87)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6364774035768856d, y: 0.19882193341614562d), new NpgsqlTypes.NpgsqlPoint(x: 0.6526889398222924d, y: 0.24918894967266836d), new NpgsqlTypes.NpgsqlPoint(x: 0.6869884817460409d, y: 0.1137825465649136d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8528025876222897d, y: 0.28521372012766766d), new NpgsqlTypes.NpgsqlPoint(x: 0.269633994634461d, y: 0.27447968911136067d), new NpgsqlTypes.NpgsqlPoint(x: 0.04270370535520729d, y: 0.9811983110081067d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((159)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9526975412524353d, y: 0.6363573490083531d), new NpgsqlTypes.NpgsqlPoint(x: 0.9276809673082593d, y: 0.8540843487938552d), new NpgsqlTypes.NpgsqlPoint(x: 0.578920397236465d, y: 0.45570211857049847d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19131814165158234d, y: 0.344589136273333d), new NpgsqlTypes.NpgsqlPoint(x: 0.42368207378951206d, y: 0.12449586974756466d), new NpgsqlTypes.NpgsqlPoint(x: 0.6973913075251269d, y: 0.4051478635822826d)))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((163)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1482428180107903d, y: 0.717761937467726d), new NpgsqlTypes.NpgsqlPoint(x: 0.5374533716819831d, y: 0.4255842287337902d), new NpgsqlTypes.NpgsqlPoint(x: 0.9204091136935705d, y: 0.9629949866564589d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((92)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.639885449814617d, y: 0.9078601582049366d), new NpgsqlTypes.NpgsqlPoint(x: 0.2711153502806255d, y: 0.7119964312088698d), new NpgsqlTypes.NpgsqlPoint(x: 0.4429661822612012d, y: 0.5215704493399559d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6338954458935542d, y: 0.3185782363408445d), new NpgsqlTypes.NpgsqlPoint(x: 0.519781002684801d, y: 0.4438869726982938d), new NpgsqlTypes.NpgsqlPoint(x: 0.15065044386489113d, y: 0.21007641985042003d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7807382084848022d, y: 0.027319073852224096d), new NpgsqlTypes.NpgsqlPoint(x: 0.6387747471865666d, y: 0.9916550396406069d), new NpgsqlTypes.NpgsqlPoint(x: 0.16958577356534887d, y: 0.6877805051160859d)))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12511195852630708d, y: 0.3220007317025293d), new NpgsqlTypes.NpgsqlPoint(x: 0.8951582876626288d, y: 0.32031608386009647d), new NpgsqlTypes.NpgsqlPoint(x: 0.9739876885575891d, y: 0.06836645255136298d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

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
FROM public.binary_npgsqlpolygonpolygone0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonE0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonE0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygone0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonE0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygone0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygone0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonE0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygone0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonE0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonSingleTypepolygon)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygone0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygone0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygone0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonE0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonE0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonE0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonSingleTypepolygon)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygone0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygone0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonE0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonE0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonE0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonE0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonSingleTypepolygon)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygone0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygone0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPolygonpolygonE0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
FROM public.binary_npgsqlpolygonpolygone0m m
LEFT JOIN public.binary_npgsqlpolygonpolygone0mi mi ON mi.id = m.npgsqlpolygonpolygone0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonE0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonSingleTypepolygon)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonE0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonE0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonSingleTypepolygon)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonE0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygone0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygone0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonE0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MIWA), typeof(NpgsqlPolygonpolygonE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models1 = new List<NpgsqlPolygonpolygonE0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonE0MIWA>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygone0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonE0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonE0MIWA>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygone0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygone0mi
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
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygone0mi
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
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MIWA), typeof(NpgsqlPolygonpolygonE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models1 = new List<NpgsqlPolygonpolygonE0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonE0MIWA>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygone0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonE0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonE0MIWA>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygone0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygone0mi
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
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygone0mi
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
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygone0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MI), typeof(NpgsqlPolygonpolygonE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models1 = new List<NpgsqlPolygonpolygonE0MI>();
                var models2 = new List<NpgsqlPolygonpolygonE0MI>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonE0MI>();
                var models2 = new List<NpgsqlPolygonpolygonE0MI>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygone0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygone0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MIWA), typeof(NpgsqlPolygonpolygonE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models1 = new List<NpgsqlPolygonpolygonE0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonE0MIWA>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonE0MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonE0MIWA>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygone0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonE0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonE0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

