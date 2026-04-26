

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
    internal partial interface INpgsqlPointArraypointArray
    {
    }
    
    internal partial class NpgsqlPointArraypointArray : INpgsqlPointArraypointArray
    {


#region TestData

        private readonly NpgsqlPointpointArray1M[] _testData = new NpgsqlPointpointArray1M[]
        {
            new NpgsqlPointpointArray1M
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3507612544219155d, y: 0.7703157032038955d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6444788175664079d, y: 0.14194301885888982d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3207916007135764d, y: 0.10835171985262726d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8476077559113754d, y: 0.5023793519444596d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9333547704860482d, y: 0.20549151938796462d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8816579611241817d, y: 0.8711743387329479d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7213192514943388d, y: 0.3341788566055275d),
new NpgsqlTypes.NpgsqlPoint(x: 0.927122411755731d, y: 0.6054696218733344d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5103493340706307d, y: 0.8982664059869884d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3608439907971078d, y: 0.49343645328457475d),
new NpgsqlTypes.NpgsqlPoint(x: 0.808174760628743d, y: 0.005967779300965814d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1978674795097921d, y: 0.8712500525587077d),
new NpgsqlTypes.NpgsqlPoint(x: 0.32172740126344124d, y: 0.8899745555836296d),
new NpgsqlTypes.NpgsqlPoint(x: 0.043280078131427424d, y: 0.6994249157922844d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6422183755858982d, y: 0.1418621892482781d),
new NpgsqlTypes.NpgsqlPoint(x: 0.004872559258762843d, y: 0.08094340655785048d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6727298980906737d, y: 0.3820999348456984d),
new NpgsqlTypes.NpgsqlPoint(x: 0.02934641574576513d, y: 0.8795731346930975d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8650716518349986d, y: 0.0013318759215575904d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7199312295169006d, y: 0.6364763952016789d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9343409544411905d, y: 0.8970840059284939d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.949693770674709d, y: 0.7301812593428867d),
new NpgsqlTypes.NpgsqlPoint(x: 0.16878598693733304d, y: 0.995407074221536d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9773474906883814d, y: 0.513011335426237d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5960234917898929d, y: 0.5447626663103434d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.049403251524524516d, y: 0.6249338527797753d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2088731331891298d, y: 0.5858525234141331d),
new NpgsqlTypes.NpgsqlPoint(x: 0.17145404572431966d, y: 0.3864063783008054d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3126680944603525d, y: 0.20303083266191557d),
new NpgsqlTypes.NpgsqlPoint(x: 0.19361781691427737d, y: 0.9482742938049328d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2519043861670671d, y: 0.8111563493243398d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7052325518893111d, y: 0.4063908113774345d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9649147286627151d, y: 0.6503771103525502d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5042324978464324d, y: 0.6893414318115217d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3122803905844592d, y: 0.017200852034722436d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2591068140885944d, y: 0.22622620838144747d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8816239418219592d, y: 0.6723222275387297d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4103689128414645d, y: 0.4004047488442741d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7470961389777703d, y: 0.2634252480657202d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8148437342997896d, y: 0.3761665229072685d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.56786038746098d, y: 0.935487305950925d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5873719573377614d, y: 0.24305992743973504d),
new NpgsqlTypes.NpgsqlPoint(x: 0.32234910875029155d, y: 0.11223706790477472d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10118596576869876d, y: 0.17787252634211392d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3912333882884589d, y: 0.9145294951089629d),
new NpgsqlTypes.NpgsqlPoint(x: 0.005047870751056616d, y: 0.3136933415166969d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7619427098611531d, y: 0.1982454515361689d),
new NpgsqlTypes.NpgsqlPoint(x: 0.480587963808057d, y: 0.3249856845577035d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6489461110129333d, y: 0.21081837534147985d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7831057926986235d, y: 0.06920178847305802d),
new NpgsqlTypes.NpgsqlPoint(x: 0.22382525557400845d, y: 0.16295803452105573d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6357315125108249d, y: 0.3339978784157037d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.07229301474543826d, y: 0.47669162608920834d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8607700763552627d, y: 0.49166308360148825d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4652805126445977d, y: 0.31363556829157946d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2937445397282964d, y: 0.005438207123961258d),
new NpgsqlTypes.NpgsqlPoint(x: 0.28875845451432725d, y: 0.37466806545819376d),
new NpgsqlTypes.NpgsqlPoint(x: 0.46137382127841486d, y: 0.2775281838077569d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6526875878439777d, y: 0.9603763190170486d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6375323863636695d, y: 0.08327507195768924d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5777499872178548d, y: 0.06935474414692d),
new NpgsqlTypes.NpgsqlPoint(x: 0.321218453996704d, y: 0.8372038403078232d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8041100488495478d, y: 0.6243516206053892d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5423072188651671d, y: 0.7827316117452658d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8730355880472005d, y: 0.01323378480790749d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.31574285584400263d, y: 0.3299030559670434d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8296252203460284d, y: 0.29180263199610634d),
new NpgsqlTypes.NpgsqlPoint(x: 0.22705600196935571d, y: 0.5937850159013923d),
new NpgsqlTypes.NpgsqlPoint(x: 0.13495055795885658d, y: 0.9960758833874713d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8396199032021361d, y: 0.9112432511620215d),
new NpgsqlTypes.NpgsqlPoint(x: 0.12458905879918836d, y: 0.3235163685744423d),
new NpgsqlTypes.NpgsqlPoint(x: 0.32538404423140166d, y: 0.046662072988532866d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5461384005024293d, y: 0.8910422820970983d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4996157953263093d, y: 0.9194014978415206d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4881587737955976d, y: 0.8941813622620874d),
new NpgsqlTypes.NpgsqlPoint(x: 0.09972000620669341d, y: 0.9550658786707318d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9415585226649257d, y: 0.44764424210677667d),
new NpgsqlTypes.NpgsqlPoint(x: 0.21541664614600375d, y: 0.6945727974546273d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8698048980333108d, y: 0.7452105456123503d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7890495985859222d, y: 0.518613115542341d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4218006141586429d, y: 0.7737308200612332d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6900142822004023d, y: 0.7652033961629615d),
new NpgsqlTypes.NpgsqlPoint(x: 0.14678923956926004d, y: 0.5409404521295829d),
new NpgsqlTypes.NpgsqlPoint(x: 0.49049236927428086d, y: 0.7197799309299061d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19630032474653203d, y: 0.8772521618084792d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3189079233981337d, y: 0.7189663358279775d),
new NpgsqlTypes.NpgsqlPoint(x: 0.45229735246905656d, y: 0.9052743732428367d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5327239244865968d, y: 0.461432870492517d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8189962705558601d, y: 0.4338947631677109d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6299781072463735d, y: 0.0326125767956309d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4131396094352683d, y: 0.6678540990749697d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0031701023988717214d, y: 0.9867890199525394d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6921375356387492d, y: 0.48968566579779627d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6192545881674403d, y: 0.9912379558268173d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5519615256209545d, y: 0.8653637191126708d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.048141146680020896d, y: 0.4943740289779557d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1513432507676552d, y: 0.5132456317308653d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7410290885322275d, y: 0.9306117993735579d),
new NpgsqlTypes.NpgsqlPoint(x: 0.41614181651145965d, y: 0.016718637278380077d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.11029885798189865d, y: 0.07504833373469844d),
new NpgsqlTypes.NpgsqlPoint(x: 0.022267531505975047d, y: 0.4347133912592498d),
new NpgsqlTypes.NpgsqlPoint(x: 0.06118114446925249d, y: 0.6408533471490719d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.015036303402774731d, y: 0.3917521571162138d),
new NpgsqlTypes.NpgsqlPoint(x: 0.713900485008058d, y: 0.9061862030031954d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2035149480454066d, y: 0.5572190732717038d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.04515945351247219d, y: 0.865405864172846d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6431709644003452d, y: 0.8455126895600013d),
new NpgsqlTypes.NpgsqlPoint(x: 0.13684778826387944d, y: 0.7427673484806441d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19562509257532157d, y: 0.7967273400740935d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9621600111631377d, y: 0.47817922388574874d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8032120433513061d, y: 0.8804375420341883d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7608380361147612d, y: 0.4786373086158152d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5098393306715958d, y: 0.937061769408578d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9976046663224807d, y: 0.5887215828249732d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14654039328685486d, y: 0.30669559927807455d),
new NpgsqlTypes.NpgsqlPoint(x: 0.26277785654412755d, y: 0.5289336646636474d),
new NpgsqlTypes.NpgsqlPoint(x: 0.12216413597836706d, y: 0.14817194016211355d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9075277693232348d, y: 0.26633227503844303d),
new NpgsqlTypes.NpgsqlPoint(x: 0.09106687088587806d, y: 0.6184061818642911d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5498895060216091d, y: 0.6927703849446182d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8810761119792009d, y: 0.5603727227704723d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5294217011977906d, y: 0.6126671551094658d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7128607060863924d, y: 0.6961614828064085d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4297813452780065d, y: 0.434870341569247d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10486056893847784d, y: 0.736762270317314d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5383022907982595d, y: 0.1965606603828315d),
new NpgsqlTypes.NpgsqlPoint(x: 0.09223239476191503d, y: 0.7132866432979087d),
new NpgsqlTypes.NpgsqlPoint(x: 0.17914934276682337d, y: 0.9887311175605683d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9221026176269349d, y: 0.44929297875089214d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7881483558732125d, y: 0.029229000690912166d),
new NpgsqlTypes.NpgsqlPoint(x: 0.30887069453733984d, y: 0.685438958311353d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.29847278723281156d, y: 0.16304482087899907d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8877757643693988d, y: 0.20096936512027708d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9591305452584715d, y: 0.5099229468967628d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 103,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.343401888751413d, y: 0.755339545637901d),
new NpgsqlTypes.NpgsqlPoint(x: 0.16492098393800592d, y: 0.6987149062167853d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3809230718529665d, y: 0.2154344389509013d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3460346489258689d, y: 0.0360987420823764d),
new NpgsqlTypes.NpgsqlPoint(x: 0.46937343404876564d, y: 0.38547398462956084d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3963267572337974d, y: 0.48603262908461264d),
new NpgsqlTypes.NpgsqlPoint(x: 0.15702083076342277d, y: 0.09752087690869427d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 106,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5886988277194967d, y: 0.0016706606262991697d),
new NpgsqlTypes.NpgsqlPoint(x: 0.15214873294684128d, y: 0.9412401583076822d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2767050746849783d, y: 0.7011673589851646d),
new NpgsqlTypes.NpgsqlPoint(x: 0.15306713771675695d, y: 0.08993771861701272d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9913912006496636d, y: 0.5473900398742823d),
new NpgsqlTypes.NpgsqlPoint(x: 0.05780046064096733d, y: 0.5238318280210924d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8453399755775596d, y: 0.28066965837168667d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9705882350473924d, y: 0.4875578739074272d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.023637969077187848d, y: 0.378670735754683d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6887230949995659d, y: 0.46833315270384546d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4564533283762303d, y: 0.9637634429796643d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9093694538864922d, y: 0.9212564790186141d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8760860562374947d, y: 0.31132979601481925d),
new NpgsqlTypes.NpgsqlPoint(x: 0.34531720672159716d, y: 0.3271448161111037d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9870931274752627d, y: 0.6381870639571542d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 107,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09317400042413893d, y: 0.7835345025464263d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5234472767187132d, y: 0.8830226154305276d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7398351592238132d, y: 0.6161919278064414d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 115,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9183273271916557d, y: 0.619939828932359d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6139878282777234d, y: 0.8121984275353844d),
new NpgsqlTypes.NpgsqlPoint(x: 0.24232960236431256d, y: 0.5855208816607347d),
new NpgsqlTypes.NpgsqlPoint(x: 0.24324080167149242d, y: 0.23577542893502135d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.13020079443021504d, y: 0.6554474063789412d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1948940051507464d, y: 0.03151105716273683d),
new NpgsqlTypes.NpgsqlPoint(x: 0.15623503051231347d, y: 0.019892149894827793d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3932911409835027d, y: 0.4758342562081055d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3977744082160318d, y: 0.5652126918624832d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4390765190347464d, y: 0.24940173081873152d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7316537738136242d, y: 0.014393705026272352d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9219554083118584d, y: 0.33718568884062117d),
new NpgsqlTypes.NpgsqlPoint(x: 0.03950084372672702d, y: 0.30457132008982857d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6304355196225977d, y: 0.23275517358103404d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5981453097007342d, y: 0.7352941585540925d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 124,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.39045503781681234d, y: 0.1723087010589317d),
new NpgsqlTypes.NpgsqlPoint(x: 0.20121456050138442d, y: 0.5132071961487159d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5236634239016754d, y: 0.6327778054280718d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 127,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2126747109539079d, y: 0.3578364752103744d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6710852014619274d, y: 0.025636399413162425d),
new NpgsqlTypes.NpgsqlPoint(x: 0.39312600544610665d, y: 0.3415104343111769d),
new NpgsqlTypes.NpgsqlPoint(x: 0.022869392299663338d, y: 0.8227879557427727d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8054994346558471d, y: 0.9736517776617175d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2821497577255475d, y: 0.3430085845490892d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5170570676997279d, y: 0.8346031923018933d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5899456361824955d, y: 0.8073519407307107d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8121489768452209d, y: 0.8796283003400255d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2332892813906574d, y: 0.0544772777534589d),
new NpgsqlTypes.NpgsqlPoint(x: 0.25029036934888027d, y: 0.8692340232180142d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.32692478156512583d, y: 0.85370019677313d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7072355602611508d, y: 0.4920324795943538d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5893936871638065d, y: 0.5458708917601364d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 134,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4285659151528586d, y: 0.395296294087491d),
new NpgsqlTypes.NpgsqlPoint(x: 0.20345857352040708d, y: 0.41890176779971533d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5045273248963199d, y: 0.9395343056003399d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4014790123829032d, y: 0.285245060803194d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.23567883847303184d, y: 0.11469259624664985d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8788026888690553d, y: 0.008379660606344763d),
new NpgsqlTypes.NpgsqlPoint(x: 0.793474024781448d, y: 0.9515420115608644d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7173423458756479d, y: 0.08130180151803779d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 142,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2072503030813535d, y: 0.741662305696249d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9520890441931025d, y: 0.048021795068935114d),
new NpgsqlTypes.NpgsqlPoint(x: 0.719634354638652d, y: 0.4181104096642002d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.150713877828485d, y: 0.7962649078650808d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8418534633162368d, y: 0.5448772613407273d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3816640160568816d, y: 0.04514444375470783d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5302102249948688d, y: 0.6069564947948112d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9330015003805777d, y: 0.7418554853324542d),
new NpgsqlTypes.NpgsqlPoint(x: 0.11059736428150646d, y: 0.6491534006153611d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 143,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.529211429338196d, y: 0.49358982125580697d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4927397095211381d, y: 0.8664255582244434d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5177617469055819d, y: 0.7876245167253924d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 146,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8137580190278588d, y: 0.478326133526617d),
new NpgsqlTypes.NpgsqlPoint(x: 0.03199883109444501d, y: 0.24120827718468663d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8803784759672324d, y: 0.6773134136390575d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.02753955935713659d, y: 0.22286032113789755d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5788658196311777d, y: 0.04582566578766556d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9338768157146705d, y: 0.7670077115141739d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8668300222829796d, y: 0.38690623807963875d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8165337324684142d, y: 0.5791680390628849d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8664934080602137d, y: 0.06071531961262844d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8583506816828624d, y: 0.7968884438184188d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 148,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9606012564261894d, y: 0.10455068293693459d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6879898295175427d, y: 0.3082034576635214d),
new NpgsqlTypes.NpgsqlPoint(x: 0.20981248978948652d, y: 0.30756805093063666d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5999167692337025d, y: 0.7363087926894156d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 154,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7787419910502437d, y: 0.8327460713143303d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7451855342566789d, y: 0.8365044497421444d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7802552388407881d, y: 0.22221815503445952d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5597120412525898d, y: 0.06588479408179226d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2699966713942108d, y: 0.15887794707070846d),
new NpgsqlTypes.NpgsqlPoint(x: 0.31339762863487575d, y: 0.9473232013057269d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2984834904418624d, y: 0.9752853609884206d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.11041159877190698d, y: 0.4251927767723477d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8141297973896069d, y: 0.055667969957843844d),
new NpgsqlTypes.NpgsqlPoint(x: 0.11896706587917572d, y: 0.18258854563525762d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5447515680436622d, y: 0.6593310201401898d),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1mi(
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1mi(
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
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
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

                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPointArraypointArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPointArraypointArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray1mi_id
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointarray1mi_id", 
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
                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray1mi_id
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
    npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray1mi_id
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
    npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointarray1mi_id", 
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
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2937445397282964d, y: 0.005438207123961258d),
new NpgsqlTypes.NpgsqlPoint(x: 0.28875845451432725d, y: 0.37466806545819376d),
new NpgsqlTypes.NpgsqlPoint(x: 0.46137382127841486d, y: 0.2775281838077569d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6526875878439777d, y: 0.9603763190170486d),
}));
                nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8396199032021361d, y: 0.9112432511620215d),
new NpgsqlTypes.NpgsqlPoint(x: 0.12458905879918836d, y: 0.3235163685744423d),
new NpgsqlTypes.NpgsqlPoint(x: 0.32538404423140166d, y: 0.046662072988532866d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5461384005024293d, y: 0.8910422820970983d),
}));
                nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointArray1M> models = null;

                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointArray1M> models = null;

                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M), typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                ((INpgsqlPointArraypointArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPointArraypointArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPointArraypointArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await ((INpgsqlPointArraypointArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPointArraypointArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M), typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                ((INpgsqlPointArraypointArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointArraypointArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointArraypointArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await ((INpgsqlPointArraypointArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPointArraypointArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M), typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                await((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 35;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[7], false);FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[8], false);FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[9], false);FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[10], false);FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[11], false);FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[12], false);FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[13], false);FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[14], false);FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[15], false);FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[16], false);FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[17], false);FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[18], false);FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[19], false);FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[20], false);FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[21], false);FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[22], false);FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[23], false);FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[24], false);FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[25], false);FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[26], false);FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[27], false);FlatNpgsqlPointpointArray1M.AssertModel(models[21],_testData[28], false);FlatNpgsqlPointpointArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[10], false);FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[11], false);FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[12], false);FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[13], false);FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[14], false);FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[15], false);FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[16], false);FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[17], false);FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[18], false);FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[19], false);FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[20], false);FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[21], false);FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[22], false);FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[23], false);FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[24], false);FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[25], false);FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[26], false);FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[27], false);FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[28], false);FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[21], false);FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[22], false);FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[23], false);FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[24], false);FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[25], false);FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[26], false);FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[27], false);FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[28], false);FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[11], false);FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[12], false);FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[13], false);FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[14], false);FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[15], false);FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[16], false);FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[17], false);FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[18], false);FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[19], false);FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[20], false);FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[21], false);FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[22], false);FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[23], false);FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[24], false);FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[25], false);FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[26], false);FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[27], false);FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[28], false);FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await((INpgsqlPointArraypointArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[15], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[16], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[17], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[18], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[19], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[10],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[11],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[12],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[13],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[11], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[12], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[13], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[14], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[15], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[16], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[17], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[18], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[19], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[10],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[11],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[12],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[13],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[14],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[15],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[16],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[17],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[18],_testData[29], false);
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
                var models = ((INpgsqlPointArraypointArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 58;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 85;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[10], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[11], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[12], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[13], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[14], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[15], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[16], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[17], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[18], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[19], false);NpgsqlPointpointArray1M.AssertModel(models[10],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[11],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[12],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[13],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[14],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[15],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[16],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[17],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[18],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[16], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[17], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[18], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[19], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[10],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[11],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[12],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M), typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                await((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 107, query1, 68, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[21], false);FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[22], false);FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[23], false);FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[24], false);FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[25], false);FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[26], false);FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[27], false);FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[28], false);FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[12], false);FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[13], false);FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[14], false);FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[15], false);FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[16], false);FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[17], false);FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[18], false);FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[19], false);FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[20], false);FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[21], false);FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[22], false);FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[23], false);FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[24], false);FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[25], false);FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[26], false);FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[27], false);FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[28], false);FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelBatch(connection, 127, query1, 134, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[24], false);FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[25], false);FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[26], false);FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[27], false);FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[28], false);FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[25], false);FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[26], false);FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[27], false);FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[28], false);FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await((INpgsqlPointArraypointArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSelectModelBatchAsync(connection, 58, 66))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[10], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[11], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[12], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[13], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[14], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[15], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[16], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[17], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[18], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[19], false);NpgsqlPointpointArray1M.AssertModel(models[10],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[11],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[12],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[13],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[14],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[15],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[16],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[17],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[18],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[11], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[12], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[13], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[14], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[15], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[16], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[17], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[18], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[19], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[10],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[11],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[12],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[13],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[14],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[15],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[16],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[17],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[18],_testData[29], false);
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
                var models = ((INpgsqlPointArraypointArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSelectModelBatch(connection, 49, 35))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[9], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[10], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[11], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[12], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[13], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[14], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[15], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[16], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[17], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[18], false);NpgsqlPointpointArray1M.AssertModel(models[10],_testData[19], false);NpgsqlPointpointArray1M.AssertModel(models[11],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[12],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[13],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[14],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[15],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[16],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[17],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[18],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[19],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[7], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[8], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[9], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[10], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[11], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[12], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[13], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[14], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[15], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[16], false);NpgsqlPointpointArray1M.AssertModel(models[10],_testData[17], false);NpgsqlPointpointArray1M.AssertModel(models[11],_testData[18], false);NpgsqlPointpointArray1M.AssertModel(models[12],_testData[19], false);NpgsqlPointpointArray1M.AssertModel(models[13],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[14],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[15],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[16],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[17],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[18],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[19],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[20],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[21],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[22],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPointArraypointArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPointArraypointArray)this).SetDbConnectionSelectModelParametrs(cmd, 4);
                var models = await ((INpgsqlPointArraypointArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(29));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[1], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[2], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[3], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[4], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[5], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[6], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[7], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[8], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[9], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[10], false);NpgsqlPointpointArray1M.AssertModel(models[10],_testData[11], false);NpgsqlPointpointArray1M.AssertModel(models[11],_testData[12], false);NpgsqlPointpointArray1M.AssertModel(models[12],_testData[13], false);NpgsqlPointpointArray1M.AssertModel(models[13],_testData[14], false);NpgsqlPointpointArray1M.AssertModel(models[14],_testData[15], false);NpgsqlPointpointArray1M.AssertModel(models[15],_testData[16], false);NpgsqlPointpointArray1M.AssertModel(models[16],_testData[17], false);NpgsqlPointpointArray1M.AssertModel(models[17],_testData[18], false);NpgsqlPointpointArray1M.AssertModel(models[18],_testData[19], false);NpgsqlPointpointArray1M.AssertModel(models[19],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[20],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[21],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[22],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[23],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[24],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[25],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[26],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[27],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[28],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointArraypointArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointArraypointArray)this).SetDbConnectionSelectModelParametrs(cmd, 146);
                var models =  ((INpgsqlPointArraypointArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(2));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
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
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
FROM public.binary_npgsqlpointpointarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPointpointArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPointArraypointArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointArraypointArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPointArraypointArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPointArraypointArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
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
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
FROM public.binary_npgsqlpointpointarray1m m
LEFT JOIN public.binary_npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPointpointArray1M>(15);

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
                ((INpgsqlPointArraypointArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointArraypointArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPointpointArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPointpointArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPointpointArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPointpointArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPointpointArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPointpointArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPointpointArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPointpointArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPointpointArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPointpointArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPointpointArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPointpointArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPointpointArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPointpointArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPointArraypointArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPointArraypointArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPointpointArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPointpointArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPointpointArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPointpointArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPointpointArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPointpointArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPointpointArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPointpointArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPointpointArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPointpointArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPointpointArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPointpointArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPointpointArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPointpointArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlPointpointArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlPointpointArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlPointpointArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlPointpointArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlPointpointArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlPointpointArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlPointpointArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlPointpointArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlPointpointArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlPointpointArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlPointpointArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlPointpointArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlPointpointArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlPointpointArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlPointpointArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
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
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPointArraypointArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointArraypointArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
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
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPointArraypointArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointArraypointArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

