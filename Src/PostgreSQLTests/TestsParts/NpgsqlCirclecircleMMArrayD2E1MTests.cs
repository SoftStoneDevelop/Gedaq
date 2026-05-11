

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
    internal partial interface INpgsqlCircleMArraycircleMMArrayD2
    {
    }
    
    internal partial class NpgsqlCircleMArraycircleMMArrayD2 : INpgsqlCircleMArraycircleMMArrayD2
    {


#region TestData

        private readonly NpgsqlCirclecircleMMArrayD2E1M[] _testData = new NpgsqlCirclecircleMMArrayD2E1M[]
        {
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4152489295950432d, y: 0.663505108649604d), radius: 0.6250752359232201d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10535054277095524d, y: 0.9555397316060328d), radius: 0.162356944486009d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17987825181581474d, y: 0.13088716216317742d), radius: 0.7345533958157063d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4530406379296601d, y: 0.3442248508431801d), radius: 0.03815524800702175d), } },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03161109437992904d, y: 0.1438277956922669d), radius: 0.7241605363907241d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.509504686445312d, y: 0.5247250390006349d), radius: 0.8339471740273274d), } },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35548072711123824d, y: 0.18268083078414443d), radius: 0.4422311104148734d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0592084586226147d, y: 0.4265489410886575d), radius: 0.9994597170710781d), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6080698866147619d, y: 0.611375957961321d), radius: 0.8309215434493614d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6662523551017935d, y: 0.9722059449713732d), radius: 0.2272929313506421d), } },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02436109052627211d, y: 0.6358078008552805d), radius: 0.811308648821907d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7799958051968793d, y: 0.5930862223179314d), radius: 0.7713484599996009d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4597943670174285d, y: 0.41797705029418264d), radius: 0.7160054974440608d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7760912711815378d, y: 0.4090030063251686d), radius: 0.6715052870146415d), } },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2595351766224774d, y: 0.41269401817516094d), radius: 0.5455048184113677d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9729601683845739d, y: 0.4997703589561945d), radius: 0.591650646423246d), } },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21215792954761892d, y: 0.5713235406821395d), radius: 0.228398230448685d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8041407554534161d, y: 0.792157960694224d), radius: 0.45605535014447973d), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5327292063302386d, y: 0.12713240642975265d), radius: 0.6164022073411342d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18497446301513043d, y: 0.3121437060626553d), radius: 0.6112402429454077d), } },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7629652072338393d, y: 0.11611750963951561d), radius: 0.9416989522128176d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.048308515297201704d, y: 0.7365974567649866d), radius: 0.18857003246308301d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14098801914978454d, y: 0.36045870405388547d), radius: 0.5780448445658294d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9518351160970139d, y: 0.3059201109147657d), radius: 0.44964002764994604d), } },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.049018622854541394d, y: 0.13937628848130224d), radius: 0.2923798005575705d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09242069485958904d, y: 0.7711335047009933d), radius: 0.6399860284273894d), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9814593963600291d, y: 0.679635162300224d), radius: 0.23805675121922465d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5526429698178351d, y: 0.8807751248511207d), radius: 0.8393536650073222d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9434859731869838d, y: 0.3975402961067753d), radius: 0.36614341301148423d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8859207306020443d, y: 0.947729235211401d), radius: 0.21165429838355876d), } },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6805857332731703d, y: 0.5158825207731466d), radius: 0.15062579696442013d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7556056358453129d, y: 0.9775369742676794d), radius: 0.5375560436485989d), } },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.502831781935346d, y: 0.7833418422921345d), radius: 0.5005455650068711d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6200453685894748d, y: 0.6253524402070249d), radius: 0.20325502588136812d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27627177861226093d, y: 0.6473516159802728d), radius: 0.24001975082677318d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8754207993813181d, y: 0.635940118012718d), radius: 0.18249580647727603d), } },
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5910878998132405d, y: 0.7756164682077009d), radius: 0.7099207362995922d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9223461555196278d, y: 0.7649182033002517d), radius: 0.9069183964226236d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31514645513274275d, y: 0.05957344456856939d), radius: 0.28445332305049364d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5860570340881731d, y: 0.22539278660367834d), radius: 0.6063001473928378d), } },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4513620994816482d, y: 0.20443707511149567d), radius: 0.18952493333946085d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5283886277569729d, y: 0.19105152778718737d), radius: 0.5621640775008478d), } },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8329233916074499d, y: 0.8854213648876245d), radius: 0.6499529860205059d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4807972891431701d, y: 0.1775423580994694d), radius: 0.7381421408803959d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9212289864504442d, y: 0.6987006999537742d), radius: 0.2619530473060272d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8640295217688229d, y: 0.14136552811689296d), radius: 0.13345767654540897d), } },
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2945049110495265d, y: 0.01593266617344069d), radius: 0.859345593624251d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20697295239265223d, y: 0.24275463947883957d), radius: 0.0978450396255508d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6296928472439585d, y: 0.7276014659162369d), radius: 0.9170320650924907d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7573178473706426d, y: 0.5099764775416105d), radius: 0.901964502028419d), } },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10234912056103307d, y: 0.2999327677666558d), radius: 0.49596663949146536d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08269688612708759d, y: 0.19396157132417635d), radius: 0.7798842828962395d), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16703509329769906d, y: 0.8327938897748569d), radius: 0.4989963812323639d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15603366709567057d, y: 0.5062041723006924d), radius: 0.41863588767470905d), } },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8500857837573826d, y: 0.5579352897675584d), radius: 0.5523662399266682d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.012872800806151052d, y: 0.3280090177409223d), radius: 0.09233324014251132d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16810658979579107d, y: 0.4941987048125923d), radius: 0.36156896485583967d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5032164099293026d, y: 0.8753778695946184d), radius: 0.1878560919143487d), } },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48373973039645535d, y: 0.892968166099062d), radius: 0.3328678611977016d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48657547806751034d, y: 0.10938679116566064d), radius: 0.19608785459389855d), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6772774673181383d, y: 0.9761394010024238d), radius: 0.8286069558173246d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8744567927938433d, y: 0.746393157695925d), radius: 0.13978427178933395d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9489899534206444d, y: 0.17534886165255847d), radius: 0.2224386120466454d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48795752934257997d, y: 0.22175528022934887d), radius: 0.38999785708719537d), } },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.837806296676136d, y: 0.27220094431375563d), radius: 0.48741206560013695d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16333892452327925d, y: 0.6120394218738037d), radius: 0.5570605860670808d), } },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5483493955912381d, y: 0.6534328804888406d), radius: 0.2400890344637172d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6411155885980204d, y: 0.5745493176778587d), radius: 0.7192496807183648d), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16938100158935554d, y: 0.2990569868726256d), radius: 0.7572178652414372d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6939901107177328d, y: 0.7112072173536683d), radius: 0.2529315860358685d), } },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30242926116988644d, y: 0.25673989469088165d), radius: 0.40510291744554994d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.005994650036086457d, y: 0.7691555764955575d), radius: 0.9036483231655971d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5536759364511552d, y: 0.034405709912132654d), radius: 0.15032718229701514d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9248389930909542d, y: 0.5080700508430654d), radius: 0.769836148919318d), } },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9760969832484078d, y: 0.46254854670318735d), radius: 0.9927500450128748d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30323230414695745d, y: 0.37235387756427674d), radius: 0.990018171099091d), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6613520677764627d, y: 0.7244495892029506d), radius: 0.48849898573720985d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.921201503299895d, y: 0.3636074618539229d), radius: 0.05718635789053128d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9109232737757691d, y: 0.9968359717496551d), radius: 0.4974242000513873d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5525363333995031d, y: 0.6925617814299627d), radius: 0.0557274476688413d), } },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.57465161224245d, y: 0.01864302162638587d), radius: 0.9089793432759656d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5828435826525721d, y: 0.42435676944440837d), radius: 0.9747836018346174d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7067139068114746d, y: 0.447880237093062d), radius: 0.0762151151904148d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8260965510722824d, y: 0.054313777871429325d), radius: 0.3077780675741364d), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9314453788682903d, y: 0.6872910967196528d), radius: 0.5714125697851952d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8620992075767969d, y: 0.2216686155976928d), radius: 0.9709884176392732d), } },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9624307132002741d, y: 0.9020106950143959d), radius: 0.03370047341804139d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3323874555615308d, y: 0.6288383383267336d), radius: 0.14473912799632482d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8643609668154802d, y: 0.6439524833136717d), radius: 0.7075763336628348d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9621416026247119d, y: 0.46445621348827437d), radius: 0.941373920167421d), } },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2760059900743401d, y: 0.0006122688192736758d), radius: 0.11811441714120385d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3658532475168459d, y: 0.1751607866407009d), radius: 0.1331486233192022d), } },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49266321888446274d, y: 0.8883443515012025d), radius: 0.4348968179900712d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8174985939316218d, y: 0.22361861128900618d), radius: 0.25233138638447694d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3799652005902333d, y: 0.754121831904389d), radius: 0.17222179817936167d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6633385705793482d, y: 0.9243492403231783d), radius: 0.6859876876116549d), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8307733214461561d, y: 0.18958928509741102d), radius: 0.018382844198534976d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16096917481928497d, y: 0.1944837412649727d), radius: 0.7490752772506818d), } },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.655943574407386d, y: 0.9760450169239335d), radius: 0.808377428431943d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8704569556225468d, y: 0.02890279606953783d), radius: 0.9829748134245736d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5177712044635752d, y: 0.051179696294799015d), radius: 0.3636107835996304d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8417895832014594d, y: 0.7945626814165505d), radius: 0.00873464403323998d), } },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31254492501347964d, y: 0.04528715312437692d), radius: 0.2997412195202722d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.51365394098801d, y: 0.25271593327029584d), radius: 0.7371643623915489d), } },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1511056574478442d, y: 0.6218491598651799d), radius: 0.5416527163428106d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.570046948978209d, y: 0.6198979678214052d), radius: 0.5164772337503645d), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17690614419363515d, y: 0.02682043178741267d), radius: 0.9710845726616597d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7204034344507325d, y: 0.28174130806436504d), radius: 0.998381489108141d), } },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 110,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1791435913159406d, y: 0.29792652766297745d), radius: 0.9882199801298879d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7017329910263419d, y: 0.834744310017792d), radius: 0.6321120793246905d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 114,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9393211792783364d, y: 0.30314799670970116d), radius: 0.44629150569841736d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3472725877605237d, y: 0.018895772930977883d), radius: 0.3289532724960643d), } },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28760821471463216d, y: 0.04463244084014284d), radius: 0.751678961976619d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4340768039016105d, y: 0.8484689354060684d), radius: 0.9460893428118708d), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 115,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9171808216172187d, y: 0.17687957056013892d), radius: 0.9833221027913737d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6149242496984303d, y: 0.9735119782436866d), radius: 0.6855564828654341d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 119,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6174452744365966d, y: 0.8182434503704291d), radius: 0.06080005520579568d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41156242718903213d, y: 0.3919420110421522d), radius: 0.10816191580201373d), } },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9522078649938756d, y: 0.7931867267386123d), radius: 0.30399981007378674d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.048109465722953715d, y: 0.3274481048662178d), radius: 0.03512048774081733d), } },
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19268157820747833d, y: 0.2673667636284095d), radius: 0.06152680606177552d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5986694905935128d, y: 0.07593966201448099d), radius: 0.9578356679487084d), } },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8492256529702541d, y: 0.7316728291396543d), radius: 0.2725671060187246d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11380403035755915d, y: 0.2754391579531912d), radius: 0.7605133655480162d), } },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 120,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.782054473761006d, y: 0.8228013106631693d), radius: 0.8874380117446306d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9034234135050234d, y: 0.21660580222023196d), radius: 0.5445516671562742d), } },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 129,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26275548800539317d, y: 0.3243061174264492d), radius: 0.07194945182716517d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5968358741924343d, y: 0.5572459424911433d), radius: 0.13017868693313228d), } },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5979193184987933d, y: 0.9681590979019421d), radius: 0.4129500039750358d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8070580059902848d, y: 0.4653654447392024d), radius: 0.8292929344564436d), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3775323027968792d, y: 0.7866468561140805d), radius: 0.030093741962515352d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7865105613778807d, y: 0.11078054291949102d), radius: 0.6079010316074173d), } },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 138,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5562803629020907d, y: 0.9697484188243197d), radius: 0.2765378219381026d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8471461430617158d, y: 0.3794859155746557d), radius: 0.26977381639461917d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30372921271922715d, y: 0.18253341019585478d), radius: 0.4349857174491102d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10390417968725563d, y: 0.5076302244693661d), radius: 0.4670006549011545d), } },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 139,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9804357006830045d, y: 0.4301382261187323d), radius: 0.4928604591882386d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05070478672272738d, y: 0.4856951249864613d), radius: 0.4036921979940621d), } },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0828490032521213d, y: 0.8351475042800126d), radius: 0.5606653249599185d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03328278874357815d, y: 0.5772071733384229d), radius: 0.15824121815355918d), } },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8498267834246943d, y: 0.7191835479899077d), radius: 0.5137473989120731d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2952883334612736d, y: 0.7238583518250655d), radius: 0.2633153186894335d), } },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 145,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49268318665502153d, y: 0.8681432946973698d), radius: 0.7414383583758964d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6798921870997728d, y: 0.373818681653284d), radius: 0.20227891907545725d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8857317107727762d, y: 0.5453700478500154d), radius: 0.555187796946422d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25922433572729664d, y: 0.06409386747738621d), radius: 0.8754960120287778d), } },
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 150,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7620236899042202d, y: 0.9907713675536809d), radius: 0.7211694731015348d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6517160309431906d, y: 0.9015534106712343d), radius: 0.6892750752174752d), } },
    ModelInner = new NpgsqlCirclecircleMMArrayD2E1MI
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22756789737390093d, y: 0.49781352744744667d), radius: 0.3212728240485191d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17348889820486224d, y: 0.6101488133899483d), radius: 0.4746616870800042d), } },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD2E1M
{
    Id = 158,
    Value = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8073295732536214d, y: 0.531323298601952d), radius: 0.2533848806125638d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6945163045392653d, y: 0.2078938707316762d), radius: 0.03672887860948959d), } },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6688556079715187d, y: 0.5716384925249897d), radius: 0.754461044083274d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1905176917499991d, y: 0.7551015798592423d), radius: 0.37835713701419016d), } },
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclemmarrayd2e1mi(
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclemmarrayd2e1mi(
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
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[,]), 
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

                changedRows =  ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclemmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclemmarrayd2e1mi_id
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclemmarrayd2e1mi_id", 
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
                changedRows =  ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclemmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclemmarrayd2e1mi_id
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
    npgsqlcirclecirclemmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
                NpgsqlTypes.NpgsqlCircle[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((INpgsqlCircleMArraycircleMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((INpgsqlCircleMArraycircleMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlCircle[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((INpgsqlCircleMArraycircleMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9434859731869838d, y: 0.3975402961067753d), radius: 0.36614341301148423d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8859207306020443d, y: 0.947729235211401d), radius: 0.21165429838355876d), } }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[,]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((INpgsqlCircleMArraycircleMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclemmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclemmarrayd2e1mi_id
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
    npgsqlcirclecirclemmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclemmarrayd2e1mi_id", 
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
                NpgsqlTypes.NpgsqlCircle[,] nullable = null;
                nullable =  ((INpgsqlCircleMArraycircleMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31514645513274275d, y: 0.05957344456856939d), radius: 0.28445332305049364d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5860570340881731d, y: 0.22539278660367834d), radius: 0.6063001473928378d), } }));
                nullable =  ((INpgsqlCircleMArraycircleMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlCircle[,] nullable = null;
                nullable = await ((INpgsqlCircleMArraycircleMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlCircleMArraycircleMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[,] { {
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16703509329769906d, y: 0.8327938897748569d), radius: 0.4989963812323639d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15603366709567057d, y: 0.5062041723006924d), radius: 0.41863588767470905d), } }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleMMArrayD2E1M> models = null;

                models =  ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleMMArrayD2E1M> models = null;

                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD2E1M), typeof(FlatNpgsqlCirclecircleMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                ((INpgsqlCircleMArraycircleMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
LEFT JOIN public.npgsqlcirclecirclemmarrayd2e1mi mi ON mi.id = m.npgsqlcirclecirclemmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD2E1M), typeof(FlatNpgsqlCirclecircleMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                ((INpgsqlCircleMArraycircleMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
LEFT JOIN public.npgsqlcirclecirclemmarrayd2e1mi mi ON mi.id = m.npgsqlcirclecirclemmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD2E1M), typeof(FlatNpgsqlCirclecircleMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                await((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 85;
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[12],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 139;
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                 ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[2],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                 ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[20],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 114;
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 99;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                 ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
LEFT JOIN public.npgsqlcirclecirclemmarrayd2e1mi mi ON mi.id = m.npgsqlcirclecirclemmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
                var models = await((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[18],_testData[34], false);
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
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[19], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[20], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[21], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[22], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[23], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[24], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[25], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[26], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[11],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[12],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[13],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[14],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD2E1M), typeof(FlatNpgsqlCirclecircleMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                await((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 37, query1, 120, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 43, query1, 114, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[8],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                 ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 60, query1, 2, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                 ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 83, query1, 110, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[9],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 37, query1, 145, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 37, query1, 138, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 15, query1, 105, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD2E1M>();
                 ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 75, query1, 145, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD2E1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd2e1m m
LEFT JOIN public.npgsqlcirclecirclemmarrayd2e1mi mi ON mi.id = m.npgsqlcirclecirclemmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
                var models = await((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 79, 98))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[18], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[19], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[20], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[21], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[22], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[23], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[24], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[25], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[26], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[11],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[12],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[13],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[14],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[15],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[11],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[12],_testData[34], false);
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
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlCircleMArraycircleMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 37, 15))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[7], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[8], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[9], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[10], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[11], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[12], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[13], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[14], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[15], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[16], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[17], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[11],_testData[18], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[12],_testData[19], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[13],_testData[20], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[14],_testData[21], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[15],_testData[22], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[16],_testData[23], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[17],_testData[24], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[18],_testData[25], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[19],_testData[26], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[20],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[21],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[22],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[23],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[24],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[25],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[26],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[31],_testData[34], false);
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
                await using var cmd = await ((INpgsqlCircleMArraycircleMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlCircleMArraycircleMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 119);
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(7));

                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[28], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[29], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[30], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[31], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[32], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[33], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleMArraycircleMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleMArraycircleMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 46);
                var models =  ((INpgsqlCircleMArraycircleMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(25));

                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                NpgsqlCirclecircleMMArrayD2E1M.AssertModel(models[24],_testData[34], false);
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
FROM public.binary_npgsqlcirclecirclemmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleMMArrayD2E1MIWA),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclemmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclemmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclemmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleMMArrayD2E1MI),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleMArraycircleMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleMArraycircleMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclemmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclemmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleMArraycircleMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleMArraycircleMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclemmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlcirclecirclemmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlCirclecircleMMArrayD2E1M),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2))]
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
FROM public.binary_npgsqlcirclecirclemmarrayd2e1m m
LEFT JOIN public.binary_npgsqlcirclecirclemmarrayd2e1mi mi ON mi.id = m.npgsqlcirclecirclemmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleMArraycircleMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleMArraycircleMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclemmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlcirclecirclemmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
                var models =  ((INpgsqlCircleMArraycircleMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1MIWA), typeof(NpgsqlCirclecircleMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>();
                await ((INpgsqlCircleMArraycircleMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>();
                ((INpgsqlCircleMArraycircleMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd2e1mi
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
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd2e1mi
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
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1MIWA), typeof(NpgsqlCirclecircleMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2))]
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>();
                await ((INpgsqlCircleMArraycircleMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>();
                ((INpgsqlCircleMArraycircleMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2))]
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
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd2e1mi
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
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd2e1mi
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
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1MI), typeof(NpgsqlCirclecircleMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD2E1MI>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD2E1MI>();
                await ((INpgsqlCircleMArraycircleMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD2E1MI>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD2E1MI>();
                ((INpgsqlCircleMArraycircleMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclemmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2)),
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
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclemmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1MIWA), typeof(NpgsqlCirclecircleMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2))]
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>();
                await ((INpgsqlCircleMArraycircleMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD2E1MIWA>();
                ((INpgsqlCircleMArraycircleMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclemmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD2))]
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
                var models = await ((INpgsqlCircleMArraycircleMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleMArraycircleMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

