

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
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7148326904588088d, y: 0.626896403984852d), radius: 0.16310359755898396d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.874614813804793d, y: 0.7400832264611117d), radius: 0.4497631783454772d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14686684153098595d, y: 0.2724160434352023d), radius: 0.8554892183257788d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9581658452797688d, y: 0.8496576418045854d), radius: 0.7093726414675556d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28236100844587797d, y: 0.23995074161407082d), radius: 0.5636463222800824d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8396516354378615d, y: 0.6666387068055651d), radius: 0.06977883963775089d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8866290614341424d, y: 0.7755452857736117d), radius: 0.2575546782663122d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15038201843316812d, y: 0.345586133584897d), radius: 0.08907629783997029d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6461081797779893d, y: 0.09726555884902788d), radius: 0.5601335562896684d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1622695750876817d, y: 0.7534119042038455d), radius: 0.5963992233074418d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3182993583451773d, y: 0.8822008582898447d), radius: 0.4936525551712827d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6447353623888961d, y: 0.6463167818253667d), radius: 0.8355384067289015d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7166349175919963d, y: 0.6943905136544907d), radius: 0.3077602299405282d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5318221065735372d, y: 0.9178160756227827d), radius: 0.8379106665743814d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28535621714301396d, y: 0.6754596954810735d), radius: 0.6947739703765138d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19004303526900734d, y: 0.6270391968025695d), radius: 0.29297637223888506d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.01003122400902956d, y: 0.3027239962923649d), radius: 0.6700252255264726d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9168639882110796d, y: 0.2946662584533838d), radius: 0.3243998032243032d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8893631340913041d, y: 0.3863836736266897d), radius: 0.403959339717583d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5648056978643826d, y: 0.90009073077417d), radius: 0.03222777238952579d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6106572338689091d, y: 0.4966111043141238d), radius: 0.17380716438040678d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7985905018808919d, y: 0.2480983802340152d), radius: 0.5534656205083377d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.058931851712836436d, y: 0.6711005690041764d), radius: 0.683035214733044d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1258230673305496d, y: 0.6428656996808582d), radius: 0.031109200810439663d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6988428865182353d, y: 0.6337942679044096d), radius: 0.9009410058802819d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5193557790722215d, y: 0.9720269436427162d), radius: 0.632623951545111d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9874872007348018d, y: 0.9514831989559194d), radius: 0.9489611861446876d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4359015671669433d, y: 0.3204336827040619d), radius: 0.9660009232487403d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38587994449426566d, y: 0.38512193399796735d), radius: 0.014770894759195907d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07644980669638757d, y: 0.12616051957225438d), radius: 0.6113323997700061d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9831219355820988d, y: 0.8235870349816841d), radius: 0.18349064045785735d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6473849311413243d, y: 0.4485752688219363d), radius: 0.7725904605536666d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20404364035202227d, y: 0.9104959538681731d), radius: 0.039744952290616586d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9185452752393779d, y: 0.0296717840008629d), radius: 0.3945744319095932d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3715972733773466d, y: 0.5843049439544445d), radius: 0.8103935690458254d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43678389022867703d, y: 0.23026562549056873d), radius: 0.06584365663859415d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25844694491934717d, y: 0.6826342970687609d), radius: 0.741889816051547d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8354855111725286d, y: 0.2680676063426939d), radius: 0.12286076985741434d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7416009612165801d, y: 0.8439472427277369d), radius: 0.7013243490087221d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8586970154182793d, y: 0.07463678762197556d), radius: 0.056354405294984256d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6765503596721856d, y: 0.013129286740243273d), radius: 0.4312258934662325d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3504746307454395d, y: 0.5023707096876636d), radius: 0.426184641886429d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6209230072305205d, y: 0.5627293074034498d), radius: 0.6167247263810669d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6128863665133347d, y: 0.05881060434208152d), radius: 0.5380869648843827d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20645660272837285d, y: 0.7561602527655038d), radius: 0.7568486038385392d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6050901841577604d, y: 0.13720751934474773d), radius: 0.8957253238240176d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6349981018881523d, y: 0.276502449869775d), radius: 0.36983106291115353d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9349934628434426d, y: 0.08754420337483171d), radius: 0.20518282192190096d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2545944261490346d, y: 0.648820444611795d), radius: 0.4469500094718618d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0012333357953985269d, y: 0.9212259216522203d), radius: 0.8642623901234563d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6737166945460672d, y: 0.8293482124625151d), radius: 0.6460693409943369d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.061162523762727905d, y: 0.7612321604777427d), radius: 0.5018068869955833d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9654460188025151d, y: 0.551613700241585d), radius: 0.33113958002032606d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02144821457938384d, y: 0.9280373905523679d), radius: 0.5533548674785485d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3709729011680939d, y: 0.4902981170744515d), radius: 0.25695511551703054d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6875991106817434d, y: 0.3707231650221161d), radius: 0.8029291711705535d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5942906356816149d, y: 0.97162587705736d), radius: 0.9223002087894875d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42104736950036126d, y: 0.8021441313460979d), radius: 0.05826630224723239d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8628366850007578d, y: 0.7331100232311343d), radius: 0.49953964428233255d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.031435003097376235d, y: 0.1867831517386257d), radius: 0.2054771583718661d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27096587329040556d, y: 0.9274640318141605d), radius: 0.2630253276366423d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6276071994091658d, y: 0.6391480165900394d), radius: 0.33569508450540986d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6401247598151039d, y: 0.8419372829878065d), radius: 0.8036725535826651d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48003110250745673d, y: 0.31574261407979165d), radius: 0.8640632916878234d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14490686514914775d, y: 0.587085926574195d), radius: 0.771386207680084d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18065661539041045d, y: 0.043451833375651394d), radius: 0.9393209177560428d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4736651171975128d, y: 0.14838088100248947d), radius: 0.6030869043990099d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9005069694039153d, y: 0.14712020318796193d), radius: 0.6689285661317678d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3257407734541896d, y: 0.41335497511608543d), radius: 0.9377903721871144d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12567026720512686d, y: 0.36392883851466873d), radius: 0.4352513401757472d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7422733633397078d, y: 0.6977798342357233d), radius: 0.1718981281171511d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18465275623249666d, y: 0.33478493171837587d), radius: 0.08680066611439041d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.660161071309031d, y: 0.25181711811212204d), radius: 0.8747591241354893d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.866902687724083d, y: 0.6104340210581604d), radius: 0.2940574995955403d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6213482107404809d, y: 0.8641043524244982d), radius: 0.9720974453384214d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.880727468712631d, y: 0.672266962601802d), radius: 0.778725083645632d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8564296538866412d, y: 0.7395332767672765d), radius: 0.9548699024913213d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13570579251267123d, y: 0.8606819976563483d), radius: 0.8461213554221862d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8874960851262713d, y: 0.4664419448519608d), radius: 0.31443021548680616d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2540996581010774d, y: 0.9560569773610935d), radius: 0.30204783151871817d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.668296508667998d, y: 0.857805525541828d), radius: 0.6922803527464315d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13899412942773637d, y: 0.2275680432126438d), radius: 0.9978759046220318d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4440779622834353d, y: 0.5739229000434025d), radius: 0.5147298591766531d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8995122407049819d, y: 0.5639854590681822d), radius: 0.652543712796021d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33341861351664326d, y: 0.023932160644808076d), radius: 0.2625709694840678d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6857270036451043d, y: 0.42703812415025577d), radius: 0.7048424270556463d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08626798986139661d, y: 0.1843274509466225d), radius: 0.12850505480502672d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40884173376407706d, y: 0.18649179210539468d), radius: 0.6024453881178974d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36271215847454497d, y: 0.3127120723741975d), radius: 0.3850735142345645d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9550953439279892d, y: 0.8045836160454288d), radius: 0.42859383342315127d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0015470923465862318d, y: 0.8792857988475891d), radius: 0.4362190355429405d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7254485169719521d, y: 0.1983011049037401d), radius: 0.35783403327596d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07471544486697534d, y: 0.3159486120148616d), radius: 0.011017536504176029d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23475692616223764d, y: 0.3930107826265531d), radius: 0.3153726946907456d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31372872900719495d, y: 0.5036923385529956d), radius: 0.3223267276010151d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9334020350270185d, y: 0.06593079105724808d), radius: 0.8497298389227091d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2583833017229833d, y: 0.8629883659083721d), radius: 0.8489631907554548d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1092654691613143d, y: 0.1461487223935849d), radius: 0.5671751511405502d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5354496406162691d, y: 0.8102007692406481d), radius: 0.7363970380107128d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18368905448776263d, y: 0.16365429568331746d), radius: 0.742117477397074d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8815109686562166d, y: 0.3084938031737299d), radius: 0.6647789447313447d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23603746374064405d, y: 0.8884473972482878d), radius: 0.4179301587011576d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21120601696154773d, y: 0.3071169400497118d), radius: 0.20939330185647986d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4166993604401418d, y: 0.6794604559976182d), radius: 0.6718247670578449d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7876211853502306d, y: 0.8762954037922246d), radius: 0.9808098346264693d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1868013036132925d, y: 0.9053330891051984d), radius: 0.6485199954927957d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5589052290054579d, y: 0.6828727683939857d), radius: 0.4443002470499622d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9090388204848933d, y: 0.7608247213954504d), radius: 0.7543342164316963d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33680993381055635d, y: 0.8557671208454646d), radius: 0.5286664344457159d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3049821301774006d, y: 0.8819703232406536d), radius: 0.18124394921804277d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26883988452608243d, y: 0.06974347800052016d), radius: 0.9630507822804308d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04423563107472761d, y: 0.29834560852518d), radius: 0.13224235920916405d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.461228764020826d, y: 0.1831720750574315d), radius: 0.1974722674284778d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3162320333483396d, y: 0.4967980681010181d), radius: 0.0850303619565822d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5346277003972727d, y: 0.14592757785871735d), radius: 0.29164692051878427d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5066231622549388d, y: 0.26618383179314464d), radius: 0.37817660325185276d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7426137404856961d, y: 0.586265466911976d), radius: 0.7610916096452272d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33195578088085476d, y: 0.4532831408837108d), radius: 0.9483131565215227d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23997445965143083d, y: 0.3460952049645637d), radius: 0.4888157305417221d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3335248545084789d, y: 0.4166307991007907d), radius: 0.652577620220749d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9646780061942299d, y: 0.04289547711760433d), radius: 0.9681740335127629d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.949937334384065d, y: 0.08299964609878308d), radius: 0.4986994263040445d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03574955775551969d, y: 0.23847929574869253d), radius: 0.5582868069660235d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06695600634787435d, y: 0.1184615433212336d), radius: 0.4644805824350928d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8061949590798719d, y: 0.727853261485455d), radius: 0.7576672238061487d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7661256435085632d, y: 0.05054772155983178d), radius: 0.4713868753268936d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3295093151086824d, y: 0.14412248695240737d), radius: 0.5949660340468125d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05333477387833252d, y: 0.9543611181789895d), radius: 0.5324448641501931d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0855211885973457d, y: 0.25438561647176006d), radius: 0.15262328219454957d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9300536537787178d, y: 0.13291729149889353d), radius: 0.36331977214522837d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5336364714370387d, y: 0.9155837520949075d), radius: 0.13675364621703512d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9276483323413708d, y: 0.07313137691850258d), radius: 0.5908555837028634d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17384387773815313d, y: 0.7264513703957761d), radius: 0.4620001399264446d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21095063469416475d, y: 0.3462838373598863d), radius: 0.5872697636827315d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19325979781878644d, y: 0.08513413577779805d), radius: 0.14610316589820094d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23201590602065691d, y: 0.8742810771544938d), radius: 0.6408729654239351d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.411366106864427d, y: 0.4308883098329367d), radius: 0.7103946583899364d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32618609466005466d, y: 0.7343410982834218d), radius: 0.1511779738436565d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4903863679252072d, y: 0.726513180694748d), radius: 0.19680398376585184d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6574843360469929d, y: 0.8511205629216931d), radius: 0.06932822191219756d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3169794609937049d, y: 0.8635507218244568d), radius: 0.39278367469147824d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9544381788005625d, y: 0.6427369746873214d), radius: 0.4136552182177874d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8479276875361513d, y: 0.5394449661944298d), radius: 0.2580340171609089d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44013444420509795d, y: 0.0729231147558056d), radius: 0.2346212798371332d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7857141382326397d, y: 0.26046898831598553d), radius: 0.9713952138316017d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7444348224340193d, y: 0.7975681857485801d), radius: 0.8828654580994107d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8437561219055401d, y: 0.016215226700149188d), radius: 0.14925142694946525d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34699977598612486d, y: 0.9244860839945226d), radius: 0.3925148648289314d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36258783799814087d, y: 0.057886263999709864d), radius: 0.6506770765623674d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8533009653176287d, y: 0.6301170882194026d), radius: 0.8542925339704998d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36356160133828364d, y: 0.34721817646155595d), radius: 0.6133912044062731d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38098193719669327d, y: 0.06643542922819579d), radius: 0.09761224362380994d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0945425568440812d, y: 0.3963246048323874d), radius: 0.4610732607516672d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41926139735181644d, y: 0.610273356601987d), radius: 0.486453905969052d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.686561530058771d, y: 0.5087351769969382d), radius: 0.6333310763259389d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29048750549293156d, y: 0.6161309108418411d), radius: 0.07436127756757249d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5137775795088328d, y: 0.8123680587700872d), radius: 0.4633315941944579d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11080092980065681d, y: 0.7968165125389766d), radius: 0.11113680384484015d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5959053511997997d, y: 0.19493518841382884d), radius: 0.3066726863140473d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13114789949337746d, y: 0.7261581553681559d), radius: 0.03877128065410307d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9420079681533172d, y: 0.8570045029740199d), radius: 0.2887040454366945d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.896454874258751d, y: 0.7203734526652568d), radius: 0.7115877676547722d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5714856386361292d, y: 0.4003852463583951d), radius: 0.8604372757018894d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9797065028623244d, y: 0.792102945620384d), radius: 0.595178073386741d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8582304447833017d, y: 0.39819538525926934d), radius: 0.07149241413286744d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4784489642029006d, y: 0.693794595410252d), radius: 0.8090268514861233d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9074858738226991d, y: 0.2428230922010094d), radius: 0.39737127159747476d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9854486474133661d, y: 0.8805525092283091d), radius: 0.7724254517885313d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7122490033464385d, y: 0.843458182688767d), radius: 0.3156791067030089d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6745851998705343d, y: 0.3044620134372368d), radius: 0.15912067431221177d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5271366151258573d, y: 0.5347476982533058d), radius: 0.6829691528259955d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 101,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3263215370286444d, y: 0.44780120950979607d), radius: 0.1023696321586628d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.568269285114878d, y: 0.4638561785625963d), radius: 0.9999655354449425d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8058203241395412d, y: 0.5876652852347075d), radius: 0.8440615643620659d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5360931234143198d, y: 0.3027631477813566d), radius: 0.585574837530598d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48063748417864405d, y: 0.20266206866199477d), radius: 0.7406145686901444d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5924189644072921d, y: 0.6458529750185019d), radius: 0.875496494540679d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.020834522898196317d, y: 0.49828788484196507d), radius: 0.68670416804149d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44855616096871587d, y: 0.2396556059763415d), radius: 0.5340706574405115d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29141122065000336d, y: 0.6279828364032973d), radius: 0.06250697573131314d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10692463108456107d, y: 0.6910954711881852d), radius: 0.8722683441601374d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.012911928175232568d, y: 0.10003738309289589d), radius: 0.16431674392997297d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9852273963137308d, y: 0.11513579523594042d), radius: 0.7624901452992556d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6563341103383803d, y: 0.5007675970745761d), radius: 0.35425641509492944d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0043842751914944245d, y: 0.45093970082845436d), radius: 0.9213184703465224d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.383923781837627d, y: 0.6680999545156083d), radius: 0.8059717595011907d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.798588955909105d, y: 0.1764559801140968d), radius: 0.29819408484829235d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 106,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3579875329590727d, y: 0.2725884204252311d), radius: 0.35164864909417437d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14117107802022555d, y: 0.7033635883772512d), radius: 0.8533367145245258d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9083869111420192d, y: 0.22751058687364267d), radius: 0.6066718868543907d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6487776842691128d, y: 0.10392456809879691d), radius: 0.626575153271872d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8750399896371858d, y: 0.6825868616183874d), radius: 0.7806835685025769d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9599548348462336d, y: 0.27650377531274606d), radius: 0.049998291659427374d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19453157417660316d, y: 0.6936761754122978d), radius: 0.8538639821982253d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 112,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8750391158078997d, y: 0.9499632822907605d), radius: 0.3672762826923981d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8572588801029133d, y: 0.08808086183311092d), radius: 0.5259936101479753d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.059432554161225504d, y: 0.45238285404611733d), radius: 0.5013495775921463d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7503058911271578d, y: 0.5999345502612544d), radius: 0.556170659305838d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5534465480595947d, y: 0.3140769860885936d), radius: 0.7099292581885107d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9024864001807004d, y: 0.5121034024757568d), radius: 0.40318452884633815d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8371360026184768d, y: 0.13225132644199744d), radius: 0.663978538121341d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28788459792125665d, y: 0.3354487782805001d), radius: 0.35342033528299577d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4559098372333893d, y: 0.025040027466007198d), radius: 0.45944509522385446d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3254050699792027d, y: 0.9842957808961185d), radius: 0.6616517644398333d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 120,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5725128408723381d, y: 0.3245080241517663d), radius: 0.5933131804892339d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.589320554166398d, y: 0.6643694776638406d), radius: 0.5201953031031621d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7084835224919305d, y: 0.7519122053222864d), radius: 0.8198943189156713d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9496620154703345d, y: 0.5252480430688936d), radius: 0.571069939631704d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5538672577340037d, y: 0.8284590007661942d), radius: 0.38915351424840217d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7876935331512546d, y: 0.8786004919407929d), radius: 0.2153661317995642d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 129,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2489250731497088d, y: 0.14065746910221077d), radius: 0.8096258106868041d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2955354579626468d, y: 0.029102947034184923d), radius: 0.8421273194172967d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24075855766647647d, y: 0.25805607487752313d), radius: 0.27504964740256266d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7409753145177955d, y: 0.5332308089054829d), radius: 0.2725397639846666d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6443447198564844d, y: 0.6372282827805528d), radius: 0.8205569985269406d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4708289420602856d, y: 0.2660566054828437d), radius: 0.16889201652132668d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.011043938418045407d, y: 0.08830761963578437d), radius: 0.7997622430941904d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6891618837486186d, y: 0.7099554015606495d), radius: 0.10586145178002793d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5446001403695461d, y: 0.36973290057066543d), radius: 0.5132781341021033d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6488600711375037d, y: 0.7851317027457383d), radius: 0.303439330426017d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9554483801848498d, y: 0.5293587109445922d), radius: 0.31651132238889457d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43961479902043565d, y: 0.16990828774247324d), radius: 0.7343736902560699d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9763241644868197d, y: 0.9652765862365762d), radius: 0.1882854288032968d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42053067795499455d, y: 0.7625916105492964d), radius: 0.07297519988127676d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 134,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9879648961853419d, y: 0.7483696029285393d), radius: 0.9014258395112391d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15842291046209445d, y: 0.7218796489794892d), radius: 0.14753220082978347d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09241709764569284d, y: 0.7085106545885751d), radius: 0.5821128220242312d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9856721851960916d, y: 0.5685961811150746d), radius: 0.03064753992778424d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.783515657708024d, y: 0.4970507553206288d), radius: 0.6197487368807213d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5392931924142668d, y: 0.55732698678873d), radius: 0.7758090654044966d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27718047597558104d, y: 0.6544336433740423d), radius: 0.6386200406286612d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18141439316672892d, y: 0.34685552278729104d), radius: 0.8953756305020081d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 139,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34261884437018997d, y: 0.2877835904116032d), radius: 0.4672376919036175d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6533462930010694d, y: 0.049735389722064594d), radius: 0.6228410507958777d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.822309523012372d, y: 0.22447493027422216d), radius: 0.6995904895089238d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35135123709776395d, y: 0.7963126794477975d), radius: 0.2228344031552566d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4852188148132115d, y: 0.211431085192899d), radius: 0.5770415826742741d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7540960139796844d, y: 0.8965097582151116d), radius: 0.3051468051172407d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3196533961620631d, y: 0.9898359202799234d), radius: 0.11089127244958019d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12400490672413245d, y: 0.015433159731156554d), radius: 0.6710783915631806d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3945505859181928d, y: 0.05749634200792997d), radius: 0.14411609658392766d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8427757939457421d, y: 0.9702216948351879d), radius: 0.029966472154090762d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28555108751370495d, y: 0.09198068161745376d), radius: 0.15262379896350053d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2735340643644014d, y: 0.8154710882975741d), radius: 0.11209394810223183d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 147,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3495832734564578d, y: 0.18053042899174743d), radius: 0.43961427154860255d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40327636510136267d, y: 0.5892306888499d), radius: 0.8577052782450495d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5737229381429009d, y: 0.928312612273742d), radius: 0.6986661818985049d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 155,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0023747741480383278d, y: 0.011571343796219047d), radius: 0.6817183367358869d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6341867798434079d, y: 0.3696731567018605d), radius: 0.28824413101325974d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5686970489630603d, y: 0.09807689378969375d), radius: 0.1373650445678174d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07314900752286568d, y: 0.10347216028339434d), radius: 0.7292748073190696d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1649806618729841d, y: 0.9550286192247023d), radius: 0.2695943246206811d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8400715875892106d, y: 0.11907739753012203d), radius: 0.14227379490739434d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6995072141340691d, y: 0.2585946132732997d), radius: 0.43946728430946735d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24927887349618372d, y: 0.18946712999506454d), radius: 0.6043837347434817d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9694337447000564d, y: 0.8215910553370078d), radius: 0.7291744902177604d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13132474711394337d, y: 0.9331577922996855d), radius: 0.6463914954683323d),
},
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
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07644980669638757d, y: 0.12616051957225438d), radius: 0.6113323997700061d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9831219355820988d, y: 0.8235870349816841d), radius: 0.18349064045785735d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6473849311413243d, y: 0.4485752688219363d), radius: 0.7725904605536666d),
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
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7416009612165801d, y: 0.8439472427277369d), radius: 0.7013243490087221d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8586970154182793d, y: 0.07463678762197556d), radius: 0.056354405294984256d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6765503596721856d, y: 0.013129286740243273d), radius: 0.4312258934662325d),
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
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6050901841577604d, y: 0.13720751934474773d), radius: 0.8957253238240176d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6349981018881523d, y: 0.276502449869775d), radius: 0.36983106291115353d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9349934628434426d, y: 0.08754420337483171d), radius: 0.20518282192190096d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2545944261490346d, y: 0.648820444611795d), radius: 0.4469500094718618d),
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
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48003110250745673d, y: 0.31574261407979165d), radius: 0.8640632916878234d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14490686514914775d, y: 0.587085926574195d), radius: 0.771386207680084d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18065661539041045d, y: 0.043451833375651394d), radius: 0.9393209177560428d),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2540996581010774d, y: 0.9560569773610935d), radius: 0.30204783151871817d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.668296508667998d, y: 0.857805525541828d), radius: 0.6922803527464315d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13899412942773637d, y: 0.2275680432126438d), radius: 0.9978759046220318d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4440779622834353d, y: 0.5739229000434025d), radius: 0.5147298591766531d),
}));
                nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7254485169719521d, y: 0.1983011049037401d), radius: 0.35783403327596d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07471544486697534d, y: 0.3159486120148616d), radius: 0.011017536504176029d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23475692616223764d, y: 0.3930107826265531d), radius: 0.3153726946907456d),
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
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
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[28],_testData[29], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[29], false);
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
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 52;
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
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[29], false);
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
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
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
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[21],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 112;
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
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[27],_testData[29], false);
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
                parametr1.Value = 76;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[18],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 101;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                int resultIndex = 0;
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
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 112, query1, 67, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[29], false);
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
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 78, query1, 52, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                int resultIndex = 0;
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
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 19, query1, 23, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[25],_testData[29], false);
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
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 48, query1, 39, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 76, query1, 52, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[29], false);
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
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 86, query1, 39, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[21],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                int resultIndex = 0;
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
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 44, query1, 93, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[29], false);
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
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelBatch(connection, 31, query1, 63, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelBatchAsync(connection, 7, 101))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[1], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[2], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[3], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[4], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[5], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[6], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[7], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[8], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[9], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[10], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[11], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[12], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[26],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[27],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelBatch(connection, 101, 23))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[4], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[5], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[6], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[7], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[8], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[9], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[10], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[11], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[12], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[29], false);
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
                ((INpgsqlCircleArraycircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 19);
                var models = await ((INpgsqlCircleArraycircleArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[3], false);NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[4], false);NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[5], false);NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[6], false);NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[7], false);NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[8], false);NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[9], false);NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[10], false);NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[11], false);NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[12], false);NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[13], false);NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[14], false);NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[15], false);NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[16], false);NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[17], false);NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[18], false);NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[19], false);NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[20], false);NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[21], false);NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[22], false);NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[23], false);NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[24], false);NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[25], false);NpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[26], false);NpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[27], false);NpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[28], false);NpgsqlCirclecircleArray1M.AssertModel(models[26],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleArraycircleArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleArraycircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 67);
                var models =  ((INpgsqlCircleArraycircleArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(15));
NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[15], false);NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[16], false);NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[17], false);NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[18], false);NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[19], false);NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[20], false);NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[21], false);NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[22], false);NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[23], false);NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[24], false);NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[25], false);NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[26], false);NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[27], false);NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[28], false);NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

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
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI)],
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
FROM public.binary_npgsqlcirclecirclearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlCirclecircleArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlCircleArraycircleArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleArraycircleArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlCircleArraycircleArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlCircleArraycircleArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlCirclecircleArray1M>(15);

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
                ((INpgsqlCircleArraycircleArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleArraycircleArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlCircleArraycircleArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlCircleArraycircleArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlCirclecircleArray1M.AssertModel(models[29],_testData[29], false);
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlCircleArraycircleArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleArraycircleArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

