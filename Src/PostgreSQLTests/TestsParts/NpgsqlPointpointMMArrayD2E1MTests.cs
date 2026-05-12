

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
    internal partial interface INpgsqlPointMArraypointMMArrayD2
    {
    }
    
    internal partial class NpgsqlPointMArraypointMMArrayD2 : INpgsqlPointMArraypointMMArrayD2
    {


#region TestData

        private readonly NpgsqlPointpointMMArrayD2E1M[] _testData = new NpgsqlPointpointMMArrayD2E1M[]
        {
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.4257334578160119d, y: 0.6641831661553284d), new NpgsqlTypes.NpgsqlPoint(x: 0.22841074924019011d, y: 0.7111515872838713d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8216793847236148d, y: 0.2708610936517528d), new NpgsqlTypes.NpgsqlPoint(x: 0.921029346268055d, y: 0.17421205903301984d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.41537455981901494d, y: 0.29373478777025896d), new NpgsqlTypes.NpgsqlPoint(x: 0.700645759800045d, y: 0.3838590687642286d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7531240501540651d, y: 0.056076625429475446d), new NpgsqlTypes.NpgsqlPoint(x: 0.8307646569437991d, y: 0.284231057406634d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.20702736335457206d, y: 0.028269505890049063d), new NpgsqlTypes.NpgsqlPoint(x: 0.08316980937286511d, y: 0.8263073754109128d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.4707776984804585d, y: 0.39982166509781314d), new NpgsqlTypes.NpgsqlPoint(x: 0.9933023090523706d, y: 0.8072060443182879d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.2731532013480633d, y: 0.507998837902658d), new NpgsqlTypes.NpgsqlPoint(x: 0.7303704267092037d, y: 0.6906429200207466d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9463080319910178d, y: 0.5636211262424721d), new NpgsqlTypes.NpgsqlPoint(x: 0.6971101582357433d, y: 0.4203572128983363d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.905227422371794d, y: 0.43914175110292375d), new NpgsqlTypes.NpgsqlPoint(x: 0.8052839287282835d, y: 0.5428826628778348d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7233657127751584d, y: 0.0318903575715801d), new NpgsqlTypes.NpgsqlPoint(x: 0.5515396484678529d, y: 0.2319796818938905d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.13027131498609734d, y: 0.038077482015195896d), new NpgsqlTypes.NpgsqlPoint(x: 0.8236134013309089d, y: 0.8432477845450872d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7349961613217048d, y: 0.9031881053902505d), new NpgsqlTypes.NpgsqlPoint(x: 0.11146597114321566d, y: 0.5655042352806852d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.7451711783791141d, y: 0.07285241958016009d), new NpgsqlTypes.NpgsqlPoint(x: 0.6118164116610167d, y: 0.5120313544346802d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.17125418047946017d, y: 0.2284863288646124d), new NpgsqlTypes.NpgsqlPoint(x: 0.062220322126913086d, y: 0.9348403002076905d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.04414280555859185d, y: 0.28258376649891037d), new NpgsqlTypes.NpgsqlPoint(x: 0.9046300272990567d, y: 0.38819960443665724d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9760108721330301d, y: 0.051690123537618815d), new NpgsqlTypes.NpgsqlPoint(x: 0.7980157228242306d, y: 0.8133489141843482d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.7420676750456078d, y: 0.8001491369766112d), new NpgsqlTypes.NpgsqlPoint(x: 0.1392601249199531d, y: 0.8886951857401588d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3256234816464333d, y: 0.7765973076217887d), new NpgsqlTypes.NpgsqlPoint(x: 0.9603103262022099d, y: 0.16379807558769677d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.7940770022296066d, y: 0.5647374307278387d), new NpgsqlTypes.NpgsqlPoint(x: 0.3384511622722306d, y: 0.3986885175377578d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3999657635563818d, y: 0.3922048182060779d), new NpgsqlTypes.NpgsqlPoint(x: 0.17103479191487592d, y: 0.3492007659305001d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.756870571597217d, y: 0.7997674642949534d), new NpgsqlTypes.NpgsqlPoint(x: 0.5368050170201922d, y: 0.5433077898119254d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8489160439721503d, y: 0.688639603609956d), new NpgsqlTypes.NpgsqlPoint(x: 0.8351951847910266d, y: 0.6116620041989788d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.43444306367149965d, y: 0.3574263404536405d), new NpgsqlTypes.NpgsqlPoint(x: 0.978829238317098d, y: 0.060266889287856396d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9858378363050349d, y: 0.16182064615381875d), new NpgsqlTypes.NpgsqlPoint(x: 0.36802707905115095d, y: 0.9672002424478938d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.6395647065984953d, y: 0.09782501651788877d), new NpgsqlTypes.NpgsqlPoint(x: 0.30001775848998524d, y: 0.8144196484750468d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6908495418916274d, y: 0.3858288321892219d), new NpgsqlTypes.NpgsqlPoint(x: 0.7167135692096984d, y: 0.6738819228523705d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.18880767642334206d, y: 0.49486440601471793d), new NpgsqlTypes.NpgsqlPoint(x: 0.8929906140444077d, y: 0.07751564342896478d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3133802764981376d, y: 0.6869854548758579d), new NpgsqlTypes.NpgsqlPoint(x: 0.06604674078615169d, y: 0.18149781430726164d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.7730188101381719d, y: 0.415465631319639d), new NpgsqlTypes.NpgsqlPoint(x: 0.7558564455423493d, y: 0.8781956527148754d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7349552711382707d, y: 0.7778990710502097d), new NpgsqlTypes.NpgsqlPoint(x: 0.11990522393192349d, y: 0.04591245847708858d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.5414997780054965d, y: 0.31373513960933497d), new NpgsqlTypes.NpgsqlPoint(x: 0.14793748123222794d, y: 0.21424820015128165d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6682825939510897d, y: 0.15574754403720614d), new NpgsqlTypes.NpgsqlPoint(x: 0.29492853809268127d, y: 0.9567602997218895d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.9865788892457068d, y: 0.5801682492003661d), new NpgsqlTypes.NpgsqlPoint(x: 0.8639847738459758d, y: 0.15994951042307137d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.023617720680872423d, y: 0.6722769081194809d), new NpgsqlTypes.NpgsqlPoint(x: 0.4469068550041728d, y: 0.9703991983244841d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.6621446956420391d, y: 0.7072440201015453d), new NpgsqlTypes.NpgsqlPoint(x: 0.6958324406396605d, y: 0.48206927534927313d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.10756890543546072d, y: 0.5117036841323856d), new NpgsqlTypes.NpgsqlPoint(x: 0.7998931810431827d, y: 0.8254702546773294d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.031373221407672736d, y: 0.1283349212421101d), new NpgsqlTypes.NpgsqlPoint(x: 0.4945142608690255d, y: 0.3221208200914274d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.600429190868179d, y: 0.8004827523022452d), new NpgsqlTypes.NpgsqlPoint(x: 0.26348799378728227d, y: 0.6537103269408888d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.20572006106122365d, y: 0.7963594377443137d), new NpgsqlTypes.NpgsqlPoint(x: 0.4951234845733683d, y: 0.10234517420761102d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.4065342915532819d, y: 0.10803684752373954d), new NpgsqlTypes.NpgsqlPoint(x: 0.8901015890509368d, y: 0.5705384849774436d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.34254457556874773d, y: 0.2571483124956997d), new NpgsqlTypes.NpgsqlPoint(x: 0.8531773205444254d, y: 0.0698813927787445d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.08204228940972236d, y: 0.5252073075085933d), new NpgsqlTypes.NpgsqlPoint(x: 0.8141878518070331d, y: 0.7333028050830419d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.9203446537119965d, y: 0.0484961571128657d), new NpgsqlTypes.NpgsqlPoint(x: 0.09528884425651496d, y: 0.09362643607154708d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6326430352132587d, y: 0.8191533136556876d), new NpgsqlTypes.NpgsqlPoint(x: 0.8741472108702245d, y: 0.3528926758419031d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.6102231310375363d, y: 0.20908001474908688d), new NpgsqlTypes.NpgsqlPoint(x: 0.7970035786526962d, y: 0.7619788383492628d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.38841503773845176d, y: 0.4226634854693523d), new NpgsqlTypes.NpgsqlPoint(x: 0.6465128581236398d, y: 0.7725470522411588d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.6595071373738438d, y: 0.38336731939678814d), new NpgsqlTypes.NpgsqlPoint(x: 0.9541109518018138d, y: 0.2626681133775659d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.018221613358579303d, y: 0.9687725445122504d), new NpgsqlTypes.NpgsqlPoint(x: 0.4097307126526891d, y: 0.7419082121532954d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.5481990579490563d, y: 0.9901500426074183d), new NpgsqlTypes.NpgsqlPoint(x: 0.5730753569683287d, y: 0.5830312809463056d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.30692976111273207d, y: 0.4043303594864639d), new NpgsqlTypes.NpgsqlPoint(x: 0.5029675684377136d, y: 0.7860783659988027d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.3039115932375902d, y: 0.4555976124682445d), new NpgsqlTypes.NpgsqlPoint(x: 0.2846694044757626d, y: 0.9980130478686484d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.43037683702508367d, y: 0.8462035620369706d), new NpgsqlTypes.NpgsqlPoint(x: 0.5146270132880528d, y: 0.49305288574113637d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.2986821380172553d, y: 0.29211225714086264d), new NpgsqlTypes.NpgsqlPoint(x: 0.9127171140072621d, y: 0.8583164144535432d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.030146544543661835d, y: 0.11093032292854144d), new NpgsqlTypes.NpgsqlPoint(x: 0.9624336707237837d, y: 0.8305485752612157d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.03127700421319135d, y: 0.6296502269914852d), new NpgsqlTypes.NpgsqlPoint(x: 0.23483486892534033d, y: 0.5706331872622348d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9446641550372029d, y: 0.26278269978258506d), new NpgsqlTypes.NpgsqlPoint(x: 0.08590425077941444d, y: 0.5603170276579671d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.10168641301061343d, y: 0.745599417528751d), new NpgsqlTypes.NpgsqlPoint(x: 0.9810216751628663d, y: 0.66967246384506d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6553241983757383d, y: 0.6580135406026016d), new NpgsqlTypes.NpgsqlPoint(x: 0.4531011383623571d, y: 0.4238906835311482d), }, },
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.10373281795788147d, y: 0.7335507002660471d), new NpgsqlTypes.NpgsqlPoint(x: 0.3325004592151236d, y: 0.9098903700483125d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.16901066388971198d, y: 0.265250158793473d), new NpgsqlTypes.NpgsqlPoint(x: 0.700227000688242d, y: 0.1647920960735958d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.7449140938750622d, y: 0.418711378350794d), new NpgsqlTypes.NpgsqlPoint(x: 0.39403066924799546d, y: 0.2491079778671269d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9353891521668923d, y: 0.0845248454290426d), new NpgsqlTypes.NpgsqlPoint(x: 0.9081734302053549d, y: 0.07668391982404932d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.06555587718187106d, y: 0.859639649092951d), new NpgsqlTypes.NpgsqlPoint(x: 0.5202438701128179d, y: 0.6176861916362548d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8119388825409692d, y: 0.8284206046212795d), new NpgsqlTypes.NpgsqlPoint(x: 0.1669589231499059d, y: 0.9958525326789084d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.33059640561380155d, y: 0.5874947900897493d), new NpgsqlTypes.NpgsqlPoint(x: 0.3670946201226657d, y: 0.3705389996477161d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.015199713644103885d, y: 0.8752122269213695d), new NpgsqlTypes.NpgsqlPoint(x: 0.37904971303841295d, y: 0.483575870562183d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.532768283411663d, y: 0.07744413995317934d), new NpgsqlTypes.NpgsqlPoint(x: 0.34054806564423223d, y: 0.17343874027862716d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8501342928439585d, y: 0.25560329121911307d), new NpgsqlTypes.NpgsqlPoint(x: 0.44290381882750973d, y: 0.7960499198005058d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.8539203553558956d, y: 0.8526429612562547d), new NpgsqlTypes.NpgsqlPoint(x: 0.6285512647754521d, y: 0.263547611134738d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3022211568869707d, y: 0.17541272281300113d), new NpgsqlTypes.NpgsqlPoint(x: 0.7024882516509631d, y: 0.15905577078997346d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.20432758657204186d, y: 0.31372746511965255d), new NpgsqlTypes.NpgsqlPoint(x: 0.4704372937789859d, y: 0.16889120473881103d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6924749050027429d, y: 0.44353640551679485d), new NpgsqlTypes.NpgsqlPoint(x: 0.030750941787340613d, y: 0.134079462442373d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.12309435852581929d, y: 0.9278393140826144d), new NpgsqlTypes.NpgsqlPoint(x: 0.46677236642294484d, y: 0.8592101682795349d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8483195938176283d, y: 0.09178998701888641d), new NpgsqlTypes.NpgsqlPoint(x: 0.36196627943935333d, y: 0.6349047002812521d), }, },
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.9144354459300429d, y: 0.22872870743194673d), new NpgsqlTypes.NpgsqlPoint(x: 0.9315276650467536d, y: 0.7851233585128703d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9145882204436484d, y: 0.414740177106407d), new NpgsqlTypes.NpgsqlPoint(x: 0.45721674843436677d, y: 0.9731416561585811d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.40021896000326784d, y: 0.9363411335134436d), new NpgsqlTypes.NpgsqlPoint(x: 0.015036311720237783d, y: 0.7529625452258811d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7697262312603533d, y: 0.9829295737626095d), new NpgsqlTypes.NpgsqlPoint(x: 0.47181912277523785d, y: 0.4943353750355509d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.3979447669293098d, y: 0.7148983631179515d), new NpgsqlTypes.NpgsqlPoint(x: 0.1600580420265365d, y: 0.2522585103209922d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7318352424826425d, y: 0.47752829866450963d), new NpgsqlTypes.NpgsqlPoint(x: 0.8526478253007591d, y: 0.6938365503406378d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.9942867941837806d, y: 0.0005374601149072955d), new NpgsqlTypes.NpgsqlPoint(x: 0.2501223180817048d, y: 0.8048563595550835d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.2410720326217678d, y: 0.7086288164267077d), new NpgsqlTypes.NpgsqlPoint(x: 0.8230033509110101d, y: 0.01601977495348128d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 92,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.3111342875044576d, y: 0.6988444557723519d), new NpgsqlTypes.NpgsqlPoint(x: 0.2600161622902798d, y: 0.13367602790456978d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.20448343959571336d, y: 0.8989007810596422d), new NpgsqlTypes.NpgsqlPoint(x: 0.10115106258374484d, y: 0.11666089129739277d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.6641027864693079d, y: 0.6182580022282507d), new NpgsqlTypes.NpgsqlPoint(x: 0.9434286179630456d, y: 0.06809511899895337d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.49342973523826283d, y: 0.7987100999539294d), new NpgsqlTypes.NpgsqlPoint(x: 0.453484025825892d, y: 0.3226794630676041d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.21420135398468176d, y: 0.5004824790495426d), new NpgsqlTypes.NpgsqlPoint(x: 0.9548472005783928d, y: 0.035066986355824836d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.07547389250303416d, y: 0.2431556249816057d), new NpgsqlTypes.NpgsqlPoint(x: 0.2368541292560915d, y: 0.04551187319954386d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.2566409418970832d, y: 0.3766260984766998d), new NpgsqlTypes.NpgsqlPoint(x: 0.6517506001749734d, y: 0.06483383567628687d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.4657775057267446d, y: 0.0325094361600784d), new NpgsqlTypes.NpgsqlPoint(x: 0.02856655828135679d, y: 0.09560692421440709d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.41955317381259283d, y: 0.031218224550730977d), new NpgsqlTypes.NpgsqlPoint(x: 0.6761680917572498d, y: 0.23571300483907365d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.37435734395082165d, y: 0.7251768777328478d), new NpgsqlTypes.NpgsqlPoint(x: 0.8470827055372379d, y: 0.91158808557381d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.5777717225740713d, y: 0.04333268512111177d), new NpgsqlTypes.NpgsqlPoint(x: 0.34904404178411386d, y: 0.5310445842004093d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3893634585362915d, y: 0.739695945043034d), new NpgsqlTypes.NpgsqlPoint(x: 0.056130733080999806d, y: 0.41161807753665836d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.3054898978874958d, y: 0.7462844199396387d), new NpgsqlTypes.NpgsqlPoint(x: 0.4526839161654641d, y: 0.09317125012750138d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.014661268274163808d, y: 0.3944567405591578d), new NpgsqlTypes.NpgsqlPoint(x: 0.0736250905754362d, y: 0.6887614310604222d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 108,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.3784600032878621d, y: 0.5619395267140289d), new NpgsqlTypes.NpgsqlPoint(x: 0.23483982035174056d, y: 0.42406191391198444d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5802627053877877d, y: 0.39574420527682574d), new NpgsqlTypes.NpgsqlPoint(x: 0.452217863162919d, y: 0.956294415629584d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.15358492217733066d, y: 0.015108233566773932d), new NpgsqlTypes.NpgsqlPoint(x: 0.11582903027530744d, y: 0.5393982336559813d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.737926754161654d, y: 0.5499317432705935d), new NpgsqlTypes.NpgsqlPoint(x: 0.783566325531858d, y: 0.04520308212311264d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 110,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.9302630268036911d, y: 0.45583166445254164d), new NpgsqlTypes.NpgsqlPoint(x: 0.5289656171653822d, y: 0.0760885337113042d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.4845478988214762d, y: 0.033524403840342165d), new NpgsqlTypes.NpgsqlPoint(x: 0.8411262872116634d, y: 0.9539293758106498d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.6776505204008701d, y: 0.7591403759154366d), new NpgsqlTypes.NpgsqlPoint(x: 0.9248781234594282d, y: 0.308421561550248d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.12226364091956654d, y: 0.16907786522760315d), new NpgsqlTypes.NpgsqlPoint(x: 0.7930780092332557d, y: 0.033619828287960285d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.975704242302211d, y: 0.59964444444051d), new NpgsqlTypes.NpgsqlPoint(x: 0.5841959128057702d, y: 0.13321557626501446d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.2688402140585334d, y: 0.4373961585593831d), new NpgsqlTypes.NpgsqlPoint(x: 0.0899759041796091d, y: 0.4406410382905539d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.3379626517194362d, y: 0.05834051072668589d), new NpgsqlTypes.NpgsqlPoint(x: 0.6799450746597344d, y: 0.7520403757924944d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.003240002484611648d, y: 0.20015800723497867d), new NpgsqlTypes.NpgsqlPoint(x: 0.3566675932939225d, y: 0.2567856002002784d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.46284866699480287d, y: 0.9613172055634732d), new NpgsqlTypes.NpgsqlPoint(x: 0.5667224612459371d, y: 0.24684211075554086d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.08774515940704364d, y: 0.8102986571284548d), new NpgsqlTypes.NpgsqlPoint(x: 0.6301057826299521d, y: 0.575722097902045d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 122,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.8575119678073735d, y: 0.1447329881827475d), new NpgsqlTypes.NpgsqlPoint(x: 0.6404300717992712d, y: 0.9573024080553837d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.39812096476527403d, y: 0.7802980597995262d), new NpgsqlTypes.NpgsqlPoint(x: 0.2166124170847592d, y: 0.5952733538093473d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.4306625769768637d, y: 0.875301351163033d), new NpgsqlTypes.NpgsqlPoint(x: 0.9504842402144633d, y: 0.2536979186548389d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.4546409357462333d, y: 0.9177285553325719d), new NpgsqlTypes.NpgsqlPoint(x: 0.1780073396667302d, y: 0.3035893937134392d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 128,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.038840711893283864d, y: 0.10353842327358354d), new NpgsqlTypes.NpgsqlPoint(x: 0.6129713790111708d, y: 0.9703244785314872d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.27797098747151894d, y: 0.8799810111562943d), new NpgsqlTypes.NpgsqlPoint(x: 0.8882207365455154d, y: 0.29017334860088617d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.13344575404715908d, y: 0.4716548731239453d), new NpgsqlTypes.NpgsqlPoint(x: 0.2569028436876999d, y: 0.4310871399966886d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.29636438826987355d, y: 0.09037037910894508d), new NpgsqlTypes.NpgsqlPoint(x: 0.9613412713364988d, y: 0.7188308697046848d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.33314879587204793d, y: 0.02062024307642385d), new NpgsqlTypes.NpgsqlPoint(x: 0.7850985864326765d, y: 0.8649892248971395d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.04885678840830354d, y: 0.8369251520590186d), new NpgsqlTypes.NpgsqlPoint(x: 0.8633541874071949d, y: 0.236578370960705d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 135,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.35973377372713167d, y: 0.6872114605927568d), new NpgsqlTypes.NpgsqlPoint(x: 0.7022751900899465d, y: 0.9837361807888939d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.057906801189590795d, y: 0.6956168202248035d), new NpgsqlTypes.NpgsqlPoint(x: 0.07969260301736425d, y: 0.9051648675427448d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 137,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.6622089249863595d, y: 0.2392149084246027d), new NpgsqlTypes.NpgsqlPoint(x: 0.19709195232179622d, y: 0.7762717742907486d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9408215242765587d, y: 0.31963851194685355d), new NpgsqlTypes.NpgsqlPoint(x: 0.7475117798893762d, y: 0.663069487826386d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 103,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.5907198780594186d, y: 0.1613857328178796d), new NpgsqlTypes.NpgsqlPoint(x: 0.9821618015978659d, y: 0.500093717830111d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.47966695102393697d, y: 0.8081381929773329d), new NpgsqlTypes.NpgsqlPoint(x: 0.7780801373720417d, y: 0.24714355704163027d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.5083922421936304d, y: 0.4750889611993284d), new NpgsqlTypes.NpgsqlPoint(x: 0.5110047180115602d, y: 0.781176713016784d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8666759004062885d, y: 0.3616049701300077d), new NpgsqlTypes.NpgsqlPoint(x: 0.8216198511034524d, y: 0.8009268697254516d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 139,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.43192139995622125d, y: 0.8725991229261011d), new NpgsqlTypes.NpgsqlPoint(x: 0.6708102098712122d, y: 0.0022981334488835214d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.45954449188485613d, y: 0.14721410679390035d), new NpgsqlTypes.NpgsqlPoint(x: 0.984587847035714d, y: 0.4670819162079354d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.993689380739914d, y: 0.7449918822680578d), new NpgsqlTypes.NpgsqlPoint(x: 0.2543838671045784d, y: 0.06029424574981945d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.24199669538462398d, y: 0.46961369807522035d), new NpgsqlTypes.NpgsqlPoint(x: 0.5248743407460793d, y: 0.38278045319453713d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 148,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.5898622780370244d, y: 0.8285697053232882d), new NpgsqlTypes.NpgsqlPoint(x: 0.6807847993935322d, y: 0.735432096558679d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.27292372935730225d, y: 0.7713066680963896d), new NpgsqlTypes.NpgsqlPoint(x: 0.7395482314674157d, y: 0.3641050393258404d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 110,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.9196890404728169d, y: 0.7655872613836195d), new NpgsqlTypes.NpgsqlPoint(x: 0.21193420355479586d, y: 0.41402830022004034d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.4135404760346848d, y: 0.6470212277045688d), new NpgsqlTypes.NpgsqlPoint(x: 0.9788877269161266d, y: 0.09808790588299787d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.4427884643171248d, y: 0.5060056120532843d), new NpgsqlTypes.NpgsqlPoint(x: 0.045013306018785726d, y: 0.5976170498021008d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.029346877316813957d, y: 0.8367345524676264d), new NpgsqlTypes.NpgsqlPoint(x: 0.3306312281129953d, y: 0.8767006418187944d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 155,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.578155402884494d, y: 0.16549457679667845d), new NpgsqlTypes.NpgsqlPoint(x: 0.5463922694666313d, y: 0.02878565683918355d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6073254964967315d, y: 0.3260600980887822d), new NpgsqlTypes.NpgsqlPoint(x: 0.11696696385913186d, y: 0.8864816678643856d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.41376700672182887d, y: 0.48354842819014476d), new NpgsqlTypes.NpgsqlPoint(x: 0.48281936205879505d, y: 0.4273839874666049d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.644537723186694d, y: 0.062200639865182095d), new NpgsqlTypes.NpgsqlPoint(x: 0.5012115255488203d, y: 0.17047459638789408d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 164,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.8675355871888351d, y: 0.509519951325748d), new NpgsqlTypes.NpgsqlPoint(x: 0.9466841657528079d, y: 0.015959675977372134d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8977813964651119d, y: 0.2863735150499708d), new NpgsqlTypes.NpgsqlPoint(x: 0.4837472040958948d, y: 0.11362793431829876d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.10775345432221872d, y: 0.0285826893699348d), new NpgsqlTypes.NpgsqlPoint(x: 0.9173835255833378d, y: 0.12818564397196064d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.33938822415382597d, y: 0.9935439817164315d), new NpgsqlTypes.NpgsqlPoint(x: 0.6974675623759439d, y: 0.5423125195736616d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.7141911680651053d, y: 0.7558099350557997d), new NpgsqlTypes.NpgsqlPoint(x: 0.018269305043450812d, y: 0.3948464799885273d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.2820756278176235d, y: 0.5506732467600115d), new NpgsqlTypes.NpgsqlPoint(x: 0.051803444190245296d, y: 0.8986210928538532d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.807222590073524d, y: 0.6323221385082535d), new NpgsqlTypes.NpgsqlPoint(x: 0.678877106663977d, y: 0.5729915589289715d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.27575412123651677d, y: 0.21800901135135164d), new NpgsqlTypes.NpgsqlPoint(x: 0.835938114817231d, y: 0.9915661597363598d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 173,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.29623160374772795d, y: 0.10408937089950088d), new NpgsqlTypes.NpgsqlPoint(x: 0.07192852298013619d, y: 0.796789873876427d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.0783887131780917d, y: 0.9962055886909869d), new NpgsqlTypes.NpgsqlPoint(x: 0.1628528420180233d, y: 0.402020326623603d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.5562086045936224d, y: 0.49545895794155925d), new NpgsqlTypes.NpgsqlPoint(x: 0.4807782860013996d, y: 0.30478351249956337d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.10741963481374328d, y: 0.31535988878124743d), new NpgsqlTypes.NpgsqlPoint(x: 0.006394755711791045d, y: 0.7533479031715117d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 176,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.6112295892623889d, y: 0.21464066083912536d), new NpgsqlTypes.NpgsqlPoint(x: 0.7306736693180059d, y: 0.4605511987146945d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.06543467883393805d, y: 0.4825140562192053d), new NpgsqlTypes.NpgsqlPoint(x: 0.4739535868746766d, y: 0.2132261179896957d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 117,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.6703603535930618d, y: 0.5867414658697506d), new NpgsqlTypes.NpgsqlPoint(x: 0.1023441789770414d, y: 0.8463040852876619d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.48412586277664804d, y: 0.3725405963428582d), new NpgsqlTypes.NpgsqlPoint(x: 0.20000442674051777d, y: 0.1374917090077551d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.8288836027423621d, y: 0.649597206693799d), new NpgsqlTypes.NpgsqlPoint(x: 0.6425187574287854d, y: 0.08249578564310545d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6940790837835736d, y: 0.6466238146925957d), new NpgsqlTypes.NpgsqlPoint(x: 0.08265494557243991d, y: 0.08865911792906656d), }, },
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 183,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.5812024667817463d, y: 0.044882863314883115d), new NpgsqlTypes.NpgsqlPoint(x: 0.2432207543944892d, y: 0.758954156786078d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9843307013787714d, y: 0.3530232660709596d), new NpgsqlTypes.NpgsqlPoint(x: 0.3165313888600143d, y: 0.8862424917371641d), }, },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointmmarrayd2e1mi(
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointmmarrayd2e1mi(
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
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[,]), 
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

                changedRows =  ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointmmarrayd2e1mi_id
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointmmarrayd2e1mi_id", 
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
                changedRows =  ((INpgsqlPointMArraypointMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPointMArraypointMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointmmarrayd2e1mi_id
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
    npgsqlpointpointmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
                NpgsqlTypes.NpgsqlPoint[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((INpgsqlPointMArraypointMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.756870571597217d, y: 0.7997674642949534d), new NpgsqlTypes.NpgsqlPoint(x: 0.5368050170201922d, y: 0.5433077898119254d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8489160439721503d, y: 0.688639603609956d), new NpgsqlTypes.NpgsqlPoint(x: 0.8351951847910266d, y: 0.6116620041989788d), }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((INpgsqlPointMArraypointMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.18880767642334206d, y: 0.49486440601471793d), new NpgsqlTypes.NpgsqlPoint(x: 0.8929906140444077d, y: 0.07751564342896478d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3133802764981376d, y: 0.6869854548758579d), new NpgsqlTypes.NpgsqlPoint(x: 0.06604674078615169d, y: 0.18149781430726164d), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPoint[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((INpgsqlPointMArraypointMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((INpgsqlPointMArraypointMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.031373221407672736d, y: 0.1283349212421101d), new NpgsqlTypes.NpgsqlPoint(x: 0.4945142608690255d, y: 0.3221208200914274d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.600429190868179d, y: 0.8004827523022452d), new NpgsqlTypes.NpgsqlPoint(x: 0.26348799378728227d, y: 0.6537103269408888d), }, }));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointmmarrayd2e1mi_id
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
    npgsqlpointpointmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointmmarrayd2e1mi_id", 
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
                NpgsqlTypes.NpgsqlPoint[,] nullable = null;
                nullable =  ((INpgsqlPointMArraypointMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPointMArraypointMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.6595071373738438d, y: 0.38336731939678814d), new NpgsqlTypes.NpgsqlPoint(x: 0.9541109518018138d, y: 0.2626681133775659d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.018221613358579303d, y: 0.9687725445122504d), new NpgsqlTypes.NpgsqlPoint(x: 0.4097307126526891d, y: 0.7419082121532954d), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPoint[,] nullable = null;
                nullable = await ((INpgsqlPointMArraypointMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.3039115932375902d, y: 0.4555976124682445d), new NpgsqlTypes.NpgsqlPoint(x: 0.2846694044757626d, y: 0.9980130478686484d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.43037683702508367d, y: 0.8462035620369706d), new NpgsqlTypes.NpgsqlPoint(x: 0.5146270132880528d, y: 0.49305288574113637d), }, }));
                nullable = await ((INpgsqlPointMArraypointMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointMMArrayD2E1M> models = null;

                models =  ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointMMArrayD2E1M> models = null;

                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD2E1M), typeof(FlatNpgsqlPointpointMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                await ((INpgsqlPointMArraypointMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                ((INpgsqlPointMArraypointMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
LEFT JOIN public.npgsqlpointpointmmarrayd2e1mi mi ON mi.id = m.npgsqlpointpointmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD2E1M), typeof(FlatNpgsqlPointpointMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                await ((INpgsqlPointMArraypointMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                ((INpgsqlPointMArraypointMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
LEFT JOIN public.npgsqlpointpointmmarrayd2e1mi mi ON mi.id = m.npgsqlpointpointmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD2E1M), typeof(FlatNpgsqlPointpointMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                await((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
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
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                await ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[21],_testData[34], false);
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
                parametr2.Value = 100;
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
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                await ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[13],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
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
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                 ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 173;
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
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                 ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[19],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 139;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                await ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 5;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[14],_testData[34], false);
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
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                 ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
LEFT JOIN public.npgsqlpointpointmmarrayd2e1mi mi ON mi.id = m.npgsqlpointpointmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
                var models = await((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[29], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[30], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[31], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[32], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[7],_testData[33], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[13],_testData[34], false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 137;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[7],_testData[29], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[8],_testData[30], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[9],_testData[31], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[10],_testData[32], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[11],_testData[33], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[28], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[29], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[30], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[31], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[32], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[33], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD2E1M), typeof(FlatNpgsqlPointpointMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                await((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                await ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 11, query1, 24, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                await ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 55, query1, 155, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[3],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                 ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 69, query1, 34, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                 ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 113, query1, 98, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[14],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 155, query1, 113, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[10],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                await ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 11, query1, 11, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 139, query1, 18, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[31],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                 ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 69, query1, 110, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
LEFT JOIN public.npgsqlpointpointmmarrayd2e1mi mi ON mi.id = m.npgsqlpointpointmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
                var models = await((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 56, 110))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[29], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[7],_testData[30], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[8],_testData[31], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[9],_testData[32], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[10],_testData[33], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[11],_testData[34], false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 139, 113))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[10],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPointMArraypointMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPointMArraypointMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 55);
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(24));

                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointMArraypointMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointMArraypointMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 42);
                var models =  ((INpgsqlPointMArraypointMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(26));

                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[9], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[10], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[11], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[12], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[13], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[14], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[15], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[7],_testData[16], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[8],_testData[17], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[9],_testData[18], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[10],_testData[19], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[11],_testData[20], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[12],_testData[21], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[13],_testData[22], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[14],_testData[23], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[15],_testData[24], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[16],_testData[25], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[17],_testData[26], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[18],_testData[27], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[19],_testData[28], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[20],_testData[29], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[21],_testData[30], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[22],_testData[31], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[23],_testData[32], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[24],_testData[33], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[25],_testData[34], false);
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
FROM public.binary_npgsqlpointpointmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointMMArrayD2E1MIWA),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointMArraypointMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointMArraypointMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPointpointMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointMArraypointMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointMArraypointMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointMMArrayD2E1MI),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointMArraypointMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPointMArraypointMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPointpointMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointMArraypointMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointMArraypointMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpointpointmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPointpointMMArrayD2E1M),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2))]
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
FROM public.binary_npgsqlpointpointmmarrayd2e1m m
LEFT JOIN public.binary_npgsqlpointpointmmarrayd2e1mi mi ON mi.id = m.npgsqlpointpointmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointMArraypointMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPointMArraypointMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpointpointmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models =  ((INpgsqlPointMArraypointMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1MIWA), typeof(NpgsqlPointpointMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models1 = new List<NpgsqlPointpointMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPointpointMMArrayD2E1MIWA>();
                await ((INpgsqlPointMArraypointMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPointpointMMArrayD2E1MIWA>();
                ((INpgsqlPointMArraypointMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointmmarrayd2e1mi
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
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointmmarrayd2e1mi
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
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1MIWA), typeof(NpgsqlPointpointMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2))]
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
                var models1 = new List<NpgsqlPointpointMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPointpointMMArrayD2E1MIWA>();
                await ((INpgsqlPointMArraypointMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPointpointMMArrayD2E1MIWA>();
                ((INpgsqlPointMArraypointMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2))]
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
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointmmarrayd2e1mi
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
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointmmarrayd2e1mi
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
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1MI), typeof(NpgsqlPointpointMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models1 = new List<NpgsqlPointpointMMArrayD2E1MI>();
                var models2 = new List<NpgsqlPointpointMMArrayD2E1MI>();
                await ((INpgsqlPointMArraypointMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointMMArrayD2E1MI>();
                var models2 = new List<NpgsqlPointpointMMArrayD2E1MI>();
                ((INpgsqlPointMArraypointMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1MIWA), typeof(NpgsqlPointpointMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2))]
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
                var models1 = new List<NpgsqlPointpointMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPointpointMMArrayD2E1MIWA>();
                await ((INpgsqlPointMArraypointMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPointpointMMArrayD2E1MIWA>();
                ((INpgsqlPointMArraypointMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2))]
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
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

