

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
    internal partial interface INpgsqlPolygonMArraypolygonMArrayD1
    {
    }
    
    internal partial class NpgsqlPolygonMArraypolygonMArrayD1 : INpgsqlPolygonMArraypolygonMArrayD1
    {


#region TestData

        private readonly NpgsqlPolygonpolygonMArrayD1E1M[] _testData = new NpgsqlPolygonpolygonMArrayD1E1M[]
        {
            new NpgsqlPolygonpolygonMArrayD1E1M
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5306973920263471d, y: 0.6967904658230584d), new NpgsqlTypes.NpgsqlPoint(x: 0.3491953498983774d, y: 0.5074458436440197d), new NpgsqlTypes.NpgsqlPoint(x: 0.7978865635933631d, y: 0.6903077014455943d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.83184151949581d, y: 0.5176133809757315d), new NpgsqlTypes.NpgsqlPoint(x: 0.4821841780908972d, y: 0.9939179855782789d), new NpgsqlTypes.NpgsqlPoint(x: 0.4083948794092199d, y: 0.3780891910156444d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.900265561593773d, y: 0.8025915227786751d), new NpgsqlTypes.NpgsqlPoint(x: 0.3130654698901624d, y: 0.7668649937808232d), new NpgsqlTypes.NpgsqlPoint(x: 0.36162025886614124d, y: 0.6114195340783837d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9180509861873624d, y: 0.2038589982180884d), new NpgsqlTypes.NpgsqlPoint(x: 0.17855537564822888d, y: 0.6426646033813362d), new NpgsqlTypes.NpgsqlPoint(x: 0.37086896878906184d, y: 0.03289334151312706d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMArrayD1E1M
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23608687339921697d, y: 0.6372349047010661d), new NpgsqlTypes.NpgsqlPoint(x: 0.25441308299665255d, y: 0.6849760257604779d), new NpgsqlTypes.NpgsqlPoint(x: 0.5823647282440886d, y: 0.9165916375294596d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13620864725201542d, y: 0.6377908489432274d), new NpgsqlTypes.NpgsqlPoint(x: 0.9774261805762589d, y: 0.9514263130678329d), new NpgsqlTypes.NpgsqlPoint(x: 0.4505480979419122d, y: 0.443577554899775d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42003451035807327d, y: 0.5883348572873819d), new NpgsqlTypes.NpgsqlPoint(x: 0.11734215297265849d, y: 0.9501391943318104d), new NpgsqlTypes.NpgsqlPoint(x: 0.4738516850623964d, y: 0.948505762040207d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.611822531419328d, y: 0.2374388019398509d), new NpgsqlTypes.NpgsqlPoint(x: 0.8842770012877076d, y: 0.6141526234412772d), new NpgsqlTypes.NpgsqlPoint(x: 0.6547313688631418d, y: 0.2477059038529451d)),
},
    ModelInner = new NpgsqlPolygonpolygonMArrayD11MI
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4108500050685123d, y: 0.5926435625872759d), new NpgsqlTypes.NpgsqlPoint(x: 0.3844109762602057d, y: 0.5879642584387836d), new NpgsqlTypes.NpgsqlPoint(x: 0.7192447591427968d, y: 0.6632631227965635d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7630164679180692d, y: 0.198035827907716d), new NpgsqlTypes.NpgsqlPoint(x: 0.885268807299587d, y: 0.38123632677512664d), new NpgsqlTypes.NpgsqlPoint(x: 0.18231030845236174d, y: 0.2076150770254963d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7419220435838537d, y: 0.16823450252302097d), new NpgsqlTypes.NpgsqlPoint(x: 0.9064703442058305d, y: 0.4101308423930521d), new NpgsqlTypes.NpgsqlPoint(x: 0.7058418616790344d, y: 0.03405757650153729d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9564387092130181d, y: 0.748778370198995d), new NpgsqlTypes.NpgsqlPoint(x: 0.9310114448233705d, y: 0.13500505076602254d), new NpgsqlTypes.NpgsqlPoint(x: 0.6420984917323844d, y: 0.5886666695588386d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4624682750512016d, y: 0.5783802980056753d), new NpgsqlTypes.NpgsqlPoint(x: 0.7283212532890943d, y: 0.6477429113535019d), new NpgsqlTypes.NpgsqlPoint(x: 0.22803383447445946d, y: 0.41955781002950543d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8883454535851245d, y: 0.7480865100419153d), new NpgsqlTypes.NpgsqlPoint(x: 0.3637278807569809d, y: 0.20217265994311207d), new NpgsqlTypes.NpgsqlPoint(x: 0.8875932215438384d, y: 0.21197942112094437d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.911036126874144d, y: 0.5509001045922731d), new NpgsqlTypes.NpgsqlPoint(x: 0.21280106871195137d, y: 0.15027362436872582d), new NpgsqlTypes.NpgsqlPoint(x: 0.03644314440325891d, y: 0.7059106786411123d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18502458456275006d, y: 0.4182795822969254d), new NpgsqlTypes.NpgsqlPoint(x: 0.7423484998717393d, y: 0.6334114312351158d), new NpgsqlTypes.NpgsqlPoint(x: 0.6817300626609003d, y: 0.5393927600147413d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9062567942801167d, y: 0.38327712285230686d), new NpgsqlTypes.NpgsqlPoint(x: 0.8619276862988714d, y: 0.6779044318087881d), new NpgsqlTypes.NpgsqlPoint(x: 0.6113674979976781d, y: 0.37364344265140725d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4486357063727585d, y: 0.47934448945942076d), new NpgsqlTypes.NpgsqlPoint(x: 0.4371326630945629d, y: 0.9184492038735147d), new NpgsqlTypes.NpgsqlPoint(x: 0.5859659439610833d, y: 0.6403355064955064d)),
},
},
            new NpgsqlPolygonpolygonMArrayD1E1M
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6152832030257213d, y: 0.18189236749413795d), new NpgsqlTypes.NpgsqlPoint(x: 0.46592648063018316d, y: 0.25567283529675244d), new NpgsqlTypes.NpgsqlPoint(x: 0.3644759178701944d, y: 0.8043189832757915d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38808571327749275d, y: 0.39155014247814224d), new NpgsqlTypes.NpgsqlPoint(x: 0.522034835498684d, y: 0.8909405832715271d), new NpgsqlTypes.NpgsqlPoint(x: 0.9893226950472191d, y: 0.36139144629955944d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8263199208813399d, y: 0.7428534673176685d), new NpgsqlTypes.NpgsqlPoint(x: 0.7221091852012056d, y: 0.5592683146477079d), new NpgsqlTypes.NpgsqlPoint(x: 0.9090889308383128d, y: 0.1738652816891465d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47285234337482884d, y: 0.9640372675959884d), new NpgsqlTypes.NpgsqlPoint(x: 0.684064246694508d, y: 0.6468364916376892d), new NpgsqlTypes.NpgsqlPoint(x: 0.15012168771630596d, y: 0.9041051719365159d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5684842733485409d, y: 0.14732052366314374d), new NpgsqlTypes.NpgsqlPoint(x: 0.014062783715674154d, y: 0.919395188338759d), new NpgsqlTypes.NpgsqlPoint(x: 0.7325844434817396d, y: 0.4838834902027246d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36786301387757636d, y: 0.6626003902277628d), new NpgsqlTypes.NpgsqlPoint(x: 0.3335924312867705d, y: 0.7414523956431556d), new NpgsqlTypes.NpgsqlPoint(x: 0.30421928029044165d, y: 0.5588602374375893d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16535497173699343d, y: 0.4602498592773505d), new NpgsqlTypes.NpgsqlPoint(x: 0.5969729665554888d, y: 0.11412828872150127d), new NpgsqlTypes.NpgsqlPoint(x: 0.5529845733386987d, y: 0.8249002448553764d)),
},
},
            new NpgsqlPolygonpolygonMArrayD1E1M
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6670977743459408d, y: 0.9061145082062263d), new NpgsqlTypes.NpgsqlPoint(x: 0.24375726470650583d, y: 0.0643005444534055d), new NpgsqlTypes.NpgsqlPoint(x: 0.4061546629523183d, y: 0.09459652874530267d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8165532371859865d, y: 0.661763106648282d), new NpgsqlTypes.NpgsqlPoint(x: 0.15526443964626502d, y: 0.5092706894193793d), new NpgsqlTypes.NpgsqlPoint(x: 0.7424541874300293d, y: 0.4416168368254988d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14058271826908564d, y: 0.36499582736623026d), new NpgsqlTypes.NpgsqlPoint(x: 0.061343681075980316d, y: 0.9844309148678289d), new NpgsqlTypes.NpgsqlPoint(x: 0.7830081907274948d, y: 0.8021465941492559d)),
},
    ModelInner = new NpgsqlPolygonpolygonMArrayD11MI
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8658462885234626d, y: 0.6902477563105754d), new NpgsqlTypes.NpgsqlPoint(x: 0.7858029076259166d, y: 0.005739614428810436d), new NpgsqlTypes.NpgsqlPoint(x: 0.4722641223470828d, y: 0.7086082467068906d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.716909400348844d, y: 0.14705313033406164d), new NpgsqlTypes.NpgsqlPoint(x: 0.7106352805710296d, y: 0.6469067648826554d), new NpgsqlTypes.NpgsqlPoint(x: 0.503235367138332d, y: 0.2939354941980541d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5696126925806629d, y: 0.7399871176306274d), new NpgsqlTypes.NpgsqlPoint(x: 0.6900338421707102d, y: 0.030571195263317308d), new NpgsqlTypes.NpgsqlPoint(x: 0.7104472870949152d, y: 0.8957419784728151d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.65723131546065d, y: 0.15324550879861099d), new NpgsqlTypes.NpgsqlPoint(x: 0.8698140055766923d, y: 0.44101574879888605d), new NpgsqlTypes.NpgsqlPoint(x: 0.8406599002728845d, y: 0.37175384202142203d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09525938501525999d, y: 0.6779176134346635d), new NpgsqlTypes.NpgsqlPoint(x: 0.7243313909982573d, y: 0.34567672235748903d), new NpgsqlTypes.NpgsqlPoint(x: 0.9755001573877616d, y: 0.5705642601784077d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5961749415717711d, y: 0.14240444178033063d), new NpgsqlTypes.NpgsqlPoint(x: 0.6926653299589636d, y: 0.6274208564122112d), new NpgsqlTypes.NpgsqlPoint(x: 0.08198628435477573d, y: 0.15267420269098841d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6598152209204134d, y: 0.0017127801882489413d), new NpgsqlTypes.NpgsqlPoint(x: 0.17483375897857256d, y: 0.48154383425281366d), new NpgsqlTypes.NpgsqlPoint(x: 0.016375867841670444d, y: 0.8234439736905818d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMArrayD1E1M
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.992806119769955d, y: 0.03063733410632319d), new NpgsqlTypes.NpgsqlPoint(x: 0.4121321261458959d, y: 0.898151089005415d), new NpgsqlTypes.NpgsqlPoint(x: 0.49546959455553186d, y: 0.06534356750681003d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1685567120312793d, y: 0.67368486564195d), new NpgsqlTypes.NpgsqlPoint(x: 0.09588104170209377d, y: 0.5386366102407203d), new NpgsqlTypes.NpgsqlPoint(x: 0.5749499163327542d, y: 0.8606043823136911d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06903600068186522d, y: 0.9440686579713049d), new NpgsqlTypes.NpgsqlPoint(x: 0.11829894053969403d, y: 0.3565251990499375d), new NpgsqlTypes.NpgsqlPoint(x: 0.47679654617391043d, y: 0.3564043935821025d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04540556829311082d, y: 0.22803976370118184d), new NpgsqlTypes.NpgsqlPoint(x: 0.9223482370107665d, y: 0.1763792191361916d), new NpgsqlTypes.NpgsqlPoint(x: 0.5800010978452346d, y: 0.20554531423891897d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26939083380843376d, y: 0.7852588624606227d), new NpgsqlTypes.NpgsqlPoint(x: 0.9735108845222175d, y: 0.5823361901126708d), new NpgsqlTypes.NpgsqlPoint(x: 0.49286956003139626d, y: 0.6087614907326485d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03444549696976451d, y: 0.6867345890491554d), new NpgsqlTypes.NpgsqlPoint(x: 0.48762554579615136d, y: 0.528050954371456d), new NpgsqlTypes.NpgsqlPoint(x: 0.11018364970769146d, y: 0.2524754630891901d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6766964793133998d, y: 0.04881141754988216d), new NpgsqlTypes.NpgsqlPoint(x: 0.24640248026105838d, y: 0.4943483979705262d), new NpgsqlTypes.NpgsqlPoint(x: 0.8224525482580913d, y: 0.5384935200492709d)),
},
},
            new NpgsqlPolygonpolygonMArrayD1E1M
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7918378594162367d, y: 0.3639322945097041d), new NpgsqlTypes.NpgsqlPoint(x: 0.9721391606454469d, y: 0.48922509301674866d), new NpgsqlTypes.NpgsqlPoint(x: 0.5264135305835006d, y: 0.93202655239588d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11261620855549681d, y: 0.7671750969533618d), new NpgsqlTypes.NpgsqlPoint(x: 0.47765213014928076d, y: 0.7748044821525801d), new NpgsqlTypes.NpgsqlPoint(x: 0.23359674010696407d, y: 0.17369914824768817d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7489166182254554d, y: 0.17910566215327217d), new NpgsqlTypes.NpgsqlPoint(x: 0.4529860878842904d, y: 0.20238772429747254d), new NpgsqlTypes.NpgsqlPoint(x: 0.9556149064725022d, y: 0.5525747306443533d)),
},
    ModelInner = new NpgsqlPolygonpolygonMArrayD11MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8190168817297281d, y: 0.4646221660531291d), new NpgsqlTypes.NpgsqlPoint(x: 0.48173030017706964d, y: 0.6927151939229509d), new NpgsqlTypes.NpgsqlPoint(x: 0.7254204139869959d, y: 0.5490487815835885d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5111384074967851d, y: 0.14785237535416618d), new NpgsqlTypes.NpgsqlPoint(x: 0.054618898702941565d, y: 0.22925933856874658d), new NpgsqlTypes.NpgsqlPoint(x: 0.9919984061868095d, y: 0.9837470096048888d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6373168633749826d, y: 0.5823787405562454d), new NpgsqlTypes.NpgsqlPoint(x: 0.5174621900400298d, y: 0.12156234463316318d), new NpgsqlTypes.NpgsqlPoint(x: 0.0756241656979717d, y: 0.9615678143961817d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9176065289135882d, y: 0.3218604774471495d), new NpgsqlTypes.NpgsqlPoint(x: 0.5566043601398449d, y: 0.41042993119440363d), new NpgsqlTypes.NpgsqlPoint(x: 0.7112125117631891d, y: 0.7046735147050928d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMArrayD1E1M
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8582349388036257d, y: 0.5342121261484086d), new NpgsqlTypes.NpgsqlPoint(x: 0.435406192371812d, y: 0.822320846749673d), new NpgsqlTypes.NpgsqlPoint(x: 0.008951591673906023d, y: 0.2560802534039449d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.525201548653494d, y: 0.0321597189295606d), new NpgsqlTypes.NpgsqlPoint(x: 0.04203341174710218d, y: 0.9503863950279892d), new NpgsqlTypes.NpgsqlPoint(x: 0.2579153952047929d, y: 0.9008661127664314d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7619982004015202d, y: 0.2287075528583059d), new NpgsqlTypes.NpgsqlPoint(x: 0.06146167212227571d, y: 0.6705118684353295d), new NpgsqlTypes.NpgsqlPoint(x: 0.31029093111803563d, y: 0.06603980104410156d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMArrayD1E1M
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6011922061354158d, y: 0.01996353303564924d), new NpgsqlTypes.NpgsqlPoint(x: 0.6318992319858143d, y: 0.5143415680564078d), new NpgsqlTypes.NpgsqlPoint(x: 0.14883327266258073d, y: 0.33853516815954343d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4975496109582517d, y: 0.008776820246964467d), new NpgsqlTypes.NpgsqlPoint(x: 0.5924854447988639d, y: 0.9937697688479388d), new NpgsqlTypes.NpgsqlPoint(x: 0.18695998527849278d, y: 0.33547051338797973d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09900721558135461d, y: 0.2147271358819407d), new NpgsqlTypes.NpgsqlPoint(x: 0.4964079655568647d, y: 0.2167105537798667d), new NpgsqlTypes.NpgsqlPoint(x: 0.9456667714042355d, y: 0.03571932807633971d)),
},
    ModelInner = new NpgsqlPolygonpolygonMArrayD11MI
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3306634853881538d, y: 0.8211788590027737d), new NpgsqlTypes.NpgsqlPoint(x: 0.1545677019507442d, y: 0.984940998472972d), new NpgsqlTypes.NpgsqlPoint(x: 0.5443264474701656d, y: 0.9090545384837945d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6894679065418626d, y: 0.18628886488412233d), new NpgsqlTypes.NpgsqlPoint(x: 0.9224004592552686d, y: 0.996851992468423d), new NpgsqlTypes.NpgsqlPoint(x: 0.46747943046430096d, y: 0.09452652495803404d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5049998240235894d, y: 0.7163543434200409d), new NpgsqlTypes.NpgsqlPoint(x: 0.9690505342107547d, y: 0.830875185892002d), new NpgsqlTypes.NpgsqlPoint(x: 0.2003791639235537d, y: 0.9491699415986344d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.040856907616768856d, y: 0.6342787181168387d), new NpgsqlTypes.NpgsqlPoint(x: 0.4130448787872196d, y: 0.9978347589457048d), new NpgsqlTypes.NpgsqlPoint(x: 0.47836074427624686d, y: 0.21360746628269733d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9304728784575631d, y: 0.41129770879287464d), new NpgsqlTypes.NpgsqlPoint(x: 0.2983256585506764d, y: 0.12072897393724769d), new NpgsqlTypes.NpgsqlPoint(x: 0.7194464690050373d, y: 0.4006319955863441d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6718600079765497d, y: 0.5901390756464053d), new NpgsqlTypes.NpgsqlPoint(x: 0.4721383028920052d, y: 0.1797271547595587d), new NpgsqlTypes.NpgsqlPoint(x: 0.5051232850443973d, y: 0.6564136507805372d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3192081463501226d, y: 0.3179606761569068d), new NpgsqlTypes.NpgsqlPoint(x: 0.7804975687278014d, y: 0.17651107752872497d), new NpgsqlTypes.NpgsqlPoint(x: 0.030349471257704597d, y: 0.14259519529775755d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3716395496545004d, y: 0.3228375290734544d), new NpgsqlTypes.NpgsqlPoint(x: 0.050145969358092346d, y: 0.19741817602175216d), new NpgsqlTypes.NpgsqlPoint(x: 0.9025486213101969d, y: 0.608321594651818d)),
},
},
            new NpgsqlPolygonpolygonMArrayD1E1M
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1994535637948659d, y: 0.7175172721065667d), new NpgsqlTypes.NpgsqlPoint(x: 0.3947211661243375d, y: 0.9419328233187361d), new NpgsqlTypes.NpgsqlPoint(x: 0.9883383162809293d, y: 0.7899207172316977d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8501672843126393d, y: 0.8026915180044684d), new NpgsqlTypes.NpgsqlPoint(x: 0.9123372401638461d, y: 0.25623072930681967d), new NpgsqlTypes.NpgsqlPoint(x: 0.9560113490702061d, y: 0.14687899197869458d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6235210944764662d, y: 0.46872723562033636d), new NpgsqlTypes.NpgsqlPoint(x: 0.8168282647835052d, y: 0.9192527242770209d), new NpgsqlTypes.NpgsqlPoint(x: 0.24600393660598552d, y: 0.023421923839400116d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39568125844089974d, y: 0.9729268177546215d), new NpgsqlTypes.NpgsqlPoint(x: 0.5806489312217933d, y: 0.9013639226978956d), new NpgsqlTypes.NpgsqlPoint(x: 0.8238453199575417d, y: 0.37961412674211403d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9264555944645565d, y: 0.37787028423352653d), new NpgsqlTypes.NpgsqlPoint(x: 0.9706401704715109d, y: 0.15258875894840207d), new NpgsqlTypes.NpgsqlPoint(x: 0.4997674807133433d, y: 0.3125929980642015d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.771194239113924d, y: 0.7986259309775978d), new NpgsqlTypes.NpgsqlPoint(x: 0.2766226908474354d, y: 0.2563157300900354d), new NpgsqlTypes.NpgsqlPoint(x: 0.8237608110163238d, y: 0.6144602605731551d)),
},
},
            new NpgsqlPolygonpolygonMArrayD1E1M
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6205841860577966d, y: 0.2840778707950895d), new NpgsqlTypes.NpgsqlPoint(x: 0.5843764850415726d, y: 0.39954401127237416d), new NpgsqlTypes.NpgsqlPoint(x: 0.8970410138479151d, y: 0.9451965443788607d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.775376190822842d, y: 0.8228596750865413d), new NpgsqlTypes.NpgsqlPoint(x: 0.8615889337811551d, y: 0.6307651253089488d), new NpgsqlTypes.NpgsqlPoint(x: 0.8162142668657416d, y: 0.6081914582885031d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21654766376443824d, y: 0.8823430123642754d), new NpgsqlTypes.NpgsqlPoint(x: 0.019307683815260934d, y: 0.18364783943916196d), new NpgsqlTypes.NpgsqlPoint(x: 0.8918607712920646d, y: 0.0287158829880364d)),
},
    ModelInner = new NpgsqlPolygonpolygonMArrayD11MI
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1607859327257718d, y: 0.19171422871751953d), new NpgsqlTypes.NpgsqlPoint(x: 0.1461273012657457d, y: 0.5259562499163302d), new NpgsqlTypes.NpgsqlPoint(x: 0.9093298138503054d, y: 0.0314085096195269d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0790439287655561d, y: 0.09775731212275363d), new NpgsqlTypes.NpgsqlPoint(x: 0.5586496829926962d, y: 0.9781434655371072d), new NpgsqlTypes.NpgsqlPoint(x: 0.08194103865766078d, y: 0.5102416782758868d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5355733436232084d, y: 0.4262562507679064d), new NpgsqlTypes.NpgsqlPoint(x: 0.9689791990643523d, y: 0.2913047324244795d), new NpgsqlTypes.NpgsqlPoint(x: 0.7910311471951885d, y: 0.6987364406518729d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.714222214504556d, y: 0.8227714182287514d), new NpgsqlTypes.NpgsqlPoint(x: 0.010138586864356314d, y: 0.5460590865317476d), new NpgsqlTypes.NpgsqlPoint(x: 0.9746406829784422d, y: 0.36300032734625776d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2774825616670987d, y: 0.33096736546431216d), new NpgsqlTypes.NpgsqlPoint(x: 0.17689415452271584d, y: 0.043252243976282245d), new NpgsqlTypes.NpgsqlPoint(x: 0.3828250200138791d, y: 0.16031871873871595d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7880051918190256d, y: 0.5017292758837052d), new NpgsqlTypes.NpgsqlPoint(x: 0.18584581003910305d, y: 0.2841263974950258d), new NpgsqlTypes.NpgsqlPoint(x: 0.9191529967915784d, y: 0.5490928769995786d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9173550264288794d, y: 0.9010598710558505d), new NpgsqlTypes.NpgsqlPoint(x: 0.7881444543635945d, y: 0.36146323286765325d), new NpgsqlTypes.NpgsqlPoint(x: 0.06887102268499457d, y: 0.15156557754477185d)),
},
},
            new NpgsqlPolygonpolygonMArrayD1E1M
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07910595650434382d, y: 0.6073718647039618d), new NpgsqlTypes.NpgsqlPoint(x: 0.2935905234774113d, y: 0.4901945426514267d), new NpgsqlTypes.NpgsqlPoint(x: 0.2428551893835188d, y: 0.535974460980085d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8261696563290633d, y: 0.27529479117516087d), new NpgsqlTypes.NpgsqlPoint(x: 0.04163434259737253d, y: 0.10336697040621623d), new NpgsqlTypes.NpgsqlPoint(x: 0.29590620666448697d, y: 0.6096436155603775d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8603682368017924d, y: 0.16438848034841114d), new NpgsqlTypes.NpgsqlPoint(x: 0.382735637001933d, y: 0.21359374008328602d), new NpgsqlTypes.NpgsqlPoint(x: 0.3546719821374571d, y: 0.29895651328307726d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9585776216872766d, y: 0.7555991774625007d), new NpgsqlTypes.NpgsqlPoint(x: 0.7395321041736356d, y: 0.9767185184340371d), new NpgsqlTypes.NpgsqlPoint(x: 0.271711445367959d, y: 0.05549354120035499d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07003998677758949d, y: 0.6634440129964758d), new NpgsqlTypes.NpgsqlPoint(x: 0.09989410390791631d, y: 0.25061929351861933d), new NpgsqlTypes.NpgsqlPoint(x: 0.12657302188504638d, y: 0.542908689985019d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5695338664970735d, y: 0.9085184288106385d), new NpgsqlTypes.NpgsqlPoint(x: 0.016926823234156174d, y: 0.9058368367390207d), new NpgsqlTypes.NpgsqlPoint(x: 0.3545087687993096d, y: 0.1988217667139487d)),
},
},
            new NpgsqlPolygonpolygonMArrayD1E1M
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9257580792475184d, y: 0.8147580598306887d), new NpgsqlTypes.NpgsqlPoint(x: 0.4476341492080532d, y: 0.4442560463244013d), new NpgsqlTypes.NpgsqlPoint(x: 0.5833989146640698d, y: 0.4667184356529436d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9993406102249547d, y: 0.4558412334969322d), new NpgsqlTypes.NpgsqlPoint(x: 0.3075267901842862d, y: 0.0047231206480441434d), new NpgsqlTypes.NpgsqlPoint(x: 0.7630597393009481d, y: 0.5698959259000759d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6151217843253897d, y: 0.9881046447767727d), new NpgsqlTypes.NpgsqlPoint(x: 0.9070029261269474d, y: 0.802138447667864d), new NpgsqlTypes.NpgsqlPoint(x: 0.6048294217477632d, y: 0.6853683715181479d)),
},
    ModelInner = new NpgsqlPolygonpolygonMArrayD11MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7414637277858331d, y: 0.7796960501456169d), new NpgsqlTypes.NpgsqlPoint(x: 0.1145927694972706d, y: 0.9823413463251993d), new NpgsqlTypes.NpgsqlPoint(x: 0.4058733505927984d, y: 0.2649996644009367d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09628512018204027d, y: 0.4847189765291623d), new NpgsqlTypes.NpgsqlPoint(x: 0.33631557869883355d, y: 0.15889222368041045d), new NpgsqlTypes.NpgsqlPoint(x: 0.8125179599861789d, y: 0.8052498416113913d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21374318959685767d, y: 0.7871774620122747d), new NpgsqlTypes.NpgsqlPoint(x: 0.6976308223765149d, y: 0.8536199962991442d), new NpgsqlTypes.NpgsqlPoint(x: 0.047452734504181304d, y: 0.3347623742446407d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1409185077104802d, y: 0.8585343136244902d), new NpgsqlTypes.NpgsqlPoint(x: 0.0021596599469436706d, y: 0.08481028737105856d), new NpgsqlTypes.NpgsqlPoint(x: 0.7792944875217852d, y: 0.9275636973858241d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4820877145486073d, y: 0.8754983517845143d), new NpgsqlTypes.NpgsqlPoint(x: 0.7198838061301915d, y: 0.9633136445301923d), new NpgsqlTypes.NpgsqlPoint(x: 0.3009508646789584d, y: 0.8312998325397905d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6297563231863125d, y: 0.7815957060234581d), new NpgsqlTypes.NpgsqlPoint(x: 0.8864252250776381d, y: 0.4793301886867032d), new NpgsqlTypes.NpgsqlPoint(x: 0.9049961235048539d, y: 0.8198359858280209d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9687406484259413d, y: 0.20918266291452803d), new NpgsqlTypes.NpgsqlPoint(x: 0.7899586771064839d, y: 0.5181828283937687d), new NpgsqlTypes.NpgsqlPoint(x: 0.8031886019002339d, y: 0.8268677244533759d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5629457972182124d, y: 0.7156781333044652d), new NpgsqlTypes.NpgsqlPoint(x: 0.14532419576631683d, y: 0.555988517196821d), new NpgsqlTypes.NpgsqlPoint(x: 0.045357725622319545d, y: 0.11788263790541764d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4293629848859294d, y: 0.9583692829576811d), new NpgsqlTypes.NpgsqlPoint(x: 0.9791978954622641d, y: 0.6377581298533392d), new NpgsqlTypes.NpgsqlPoint(x: 0.4159482743445153d, y: 0.0851986358978768d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8953412941092067d, y: 0.9822407072251549d), new NpgsqlTypes.NpgsqlPoint(x: 0.2722999492047623d, y: 0.4193446899106301d), new NpgsqlTypes.NpgsqlPoint(x: 0.992114252971793d, y: 0.3851646346260944d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5378417149833519d, y: 0.2312058799571367d), new NpgsqlTypes.NpgsqlPoint(x: 0.8162433483800888d, y: 0.17292469207490524d), new NpgsqlTypes.NpgsqlPoint(x: 0.3327690427693588d, y: 0.7955010868373336d)),
},
},
            new NpgsqlPolygonpolygonMArrayD1E1M
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33852181550471816d, y: 0.5910567252396098d), new NpgsqlTypes.NpgsqlPoint(x: 0.561519142176013d, y: 0.12269745185574876d), new NpgsqlTypes.NpgsqlPoint(x: 0.046760069680524596d, y: 0.005485468993157716d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3403517869343412d, y: 0.6230227929945282d), new NpgsqlTypes.NpgsqlPoint(x: 0.7218839622586333d, y: 0.4850157291886865d), new NpgsqlTypes.NpgsqlPoint(x: 0.10711605046608874d, y: 0.28011793805153506d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5317847995381443d, y: 0.3048155489106513d), new NpgsqlTypes.NpgsqlPoint(x: 0.4629005264355742d, y: 0.875143602077277d), new NpgsqlTypes.NpgsqlPoint(x: 0.0653016351910406d, y: 0.17920550543140568d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.578634587834326d, y: 0.04090948117302584d), new NpgsqlTypes.NpgsqlPoint(x: 0.9905573732502142d, y: 0.9811219220904641d), new NpgsqlTypes.NpgsqlPoint(x: 0.944457314401563d, y: 0.7298186055784192d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3491693048101502d, y: 0.970200773488219d), new NpgsqlTypes.NpgsqlPoint(x: 0.4044935674777935d, y: 0.9585198928912727d), new NpgsqlTypes.NpgsqlPoint(x: 0.9009979290650049d, y: 0.8098385161890084d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7148182555871399d, y: 0.9521468137043771d), new NpgsqlTypes.NpgsqlPoint(x: 0.4152708697745193d, y: 0.0951663561181556d), new NpgsqlTypes.NpgsqlPoint(x: 0.4503690556196793d, y: 0.513179392403208d)),
},
},
            new NpgsqlPolygonpolygonMArrayD1E1M
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7391472393434001d, y: 0.824397908222605d), new NpgsqlTypes.NpgsqlPoint(x: 0.5929297017696913d, y: 0.03634232775926882d), new NpgsqlTypes.NpgsqlPoint(x: 0.6801071882796608d, y: 0.41706729806621723d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6748656730235563d, y: 0.23485816226150746d), new NpgsqlTypes.NpgsqlPoint(x: 0.505300539647822d, y: 0.6667596018502132d), new NpgsqlTypes.NpgsqlPoint(x: 0.13758529241875483d, y: 0.6675128380180735d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6583746280646956d, y: 0.907292194831082d), new NpgsqlTypes.NpgsqlPoint(x: 0.06430773650510668d, y: 0.6696722194182206d), new NpgsqlTypes.NpgsqlPoint(x: 0.13534518898820525d, y: 0.6815168763514429d)),
},
    ModelInner = new NpgsqlPolygonpolygonMArrayD11MI
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.747002748908989d, y: 0.15608563802690278d), new NpgsqlTypes.NpgsqlPoint(x: 0.03270257462205284d, y: 0.43680428769223345d), new NpgsqlTypes.NpgsqlPoint(x: 0.3125713704945696d, y: 0.9609846453572636d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6874263804012382d, y: 0.569952461636004d), new NpgsqlTypes.NpgsqlPoint(x: 0.5303240795488171d, y: 0.18914027520946664d), new NpgsqlTypes.NpgsqlPoint(x: 0.19897671964659247d, y: 0.9194678839250612d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.057115167326789895d, y: 0.015949344348053174d), new NpgsqlTypes.NpgsqlPoint(x: 0.0712333398196695d, y: 0.6354162079614606d), new NpgsqlTypes.NpgsqlPoint(x: 0.10162554690117576d, y: 0.07387133580150773d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7037031590424895d, y: 0.10623386718508798d), new NpgsqlTypes.NpgsqlPoint(x: 0.22250956233314945d, y: 0.46815402925244953d), new NpgsqlTypes.NpgsqlPoint(x: 0.039654362166700596d, y: 0.6349637419762603d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.022965944895629864d, y: 0.23290016909901667d), new NpgsqlTypes.NpgsqlPoint(x: 0.15925317207073286d, y: 0.5528912366019081d), new NpgsqlTypes.NpgsqlPoint(x: 0.21186215392950036d, y: 0.8140554683961644d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9308439676171102d, y: 0.43660099170856614d), new NpgsqlTypes.NpgsqlPoint(x: 0.40661617373059d, y: 0.27010814647577375d), new NpgsqlTypes.NpgsqlPoint(x: 0.7643749563586765d, y: 0.42855603929967656d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8088650980863125d, y: 0.17337858823414476d), new NpgsqlTypes.NpgsqlPoint(x: 0.29281825743586487d, y: 0.22052415380950674d), new NpgsqlTypes.NpgsqlPoint(x: 0.9003042557930183d, y: 0.39435307402901676d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMArrayD1E1M
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9783756021253083d, y: 0.9974697401222933d), new NpgsqlTypes.NpgsqlPoint(x: 0.4325390010020794d, y: 0.352966056186244d), new NpgsqlTypes.NpgsqlPoint(x: 0.7661503404716191d, y: 0.41430930882489325d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.999269639551896d, y: 0.3691506024918212d), new NpgsqlTypes.NpgsqlPoint(x: 0.009816060162990192d, y: 0.6938135851539584d), new NpgsqlTypes.NpgsqlPoint(x: 0.6206665846452353d, y: 0.314176982700082d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7104438976343971d, y: 0.38841803203979d), new NpgsqlTypes.NpgsqlPoint(x: 0.4453999074625101d, y: 0.45172623526995304d), new NpgsqlTypes.NpgsqlPoint(x: 0.7465247014599509d, y: 0.26150151962407053d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8446484920624994d, y: 0.7908978691367587d), new NpgsqlTypes.NpgsqlPoint(x: 0.10482148507964983d, y: 0.9416366348524298d), new NpgsqlTypes.NpgsqlPoint(x: 0.5574097141536604d, y: 0.5118044532288573d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMArrayD1E1M
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2891864512033001d, y: 0.18254621558728612d), new NpgsqlTypes.NpgsqlPoint(x: 0.8512112912883376d, y: 0.3930170397693836d), new NpgsqlTypes.NpgsqlPoint(x: 0.6258845574503892d, y: 0.6999914940592427d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.217987628066028d, y: 0.8343898220307967d), new NpgsqlTypes.NpgsqlPoint(x: 0.30279075271786027d, y: 0.20871289818243877d), new NpgsqlTypes.NpgsqlPoint(x: 0.28787886794094275d, y: 0.5490010082389954d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6900091613096508d, y: 0.23277167248714759d), new NpgsqlTypes.NpgsqlPoint(x: 0.45973076312961714d, y: 0.18292696857670565d), new NpgsqlTypes.NpgsqlPoint(x: 0.5394174654407325d, y: 0.9327159882978966d)),
},
    ModelInner = new NpgsqlPolygonpolygonMArrayD11MI
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13776862629765096d, y: 0.9846737745307765d), new NpgsqlTypes.NpgsqlPoint(x: 0.12112035712435143d, y: 0.27347084325651905d), new NpgsqlTypes.NpgsqlPoint(x: 0.025529271502549467d, y: 0.6168938368782223d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.008320560045320002d, y: 0.8736560263029314d), new NpgsqlTypes.NpgsqlPoint(x: 0.19122979685632835d, y: 0.9598175709112884d), new NpgsqlTypes.NpgsqlPoint(x: 0.12035237230223761d, y: 0.32344269576205464d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6621123376700765d, y: 0.7397708426107901d), new NpgsqlTypes.NpgsqlPoint(x: 0.09515501328636589d, y: 0.61767205109408d), new NpgsqlTypes.NpgsqlPoint(x: 0.6387114746219742d, y: 0.8180144934929684d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMArrayD1E1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46865102358269073d, y: 0.2840239608142514d), new NpgsqlTypes.NpgsqlPoint(x: 0.2236671469659678d, y: 0.5483061775501537d), new NpgsqlTypes.NpgsqlPoint(x: 0.5205081220218697d, y: 0.20138697816616336d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9964514833310075d, y: 0.7650781110135023d), new NpgsqlTypes.NpgsqlPoint(x: 0.05980904577014634d, y: 0.4011441689290498d), new NpgsqlTypes.NpgsqlPoint(x: 0.31181062826476214d, y: 0.7033233953919893d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7903672351708014d, y: 0.688353647840593d), new NpgsqlTypes.NpgsqlPoint(x: 0.6055769027425615d, y: 0.22947032648980592d), new NpgsqlTypes.NpgsqlPoint(x: 0.15149222791661487d, y: 0.07617052122139645d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9456815993107809d, y: 0.0632398972635616d), new NpgsqlTypes.NpgsqlPoint(x: 0.3068782297734166d, y: 0.8814498294428383d), new NpgsqlTypes.NpgsqlPoint(x: 0.9274494624515403d, y: 0.13486581276523768d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24280887700987996d, y: 0.3686885828086539d), new NpgsqlTypes.NpgsqlPoint(x: 0.30864148383298073d, y: 0.7837500400590439d), new NpgsqlTypes.NpgsqlPoint(x: 0.18885941872903833d, y: 0.8537090754409441d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7738088972111212d, y: 0.0424413955321713d), new NpgsqlTypes.NpgsqlPoint(x: 0.9412161971683353d, y: 0.5050050594533219d), new NpgsqlTypes.NpgsqlPoint(x: 0.8983848491909971d, y: 0.942889544700622d)),
},
},
            new NpgsqlPolygonpolygonMArrayD1E1M
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22960142536838035d, y: 0.8259765550942222d), new NpgsqlTypes.NpgsqlPoint(x: 0.6419589621861559d, y: 0.41634319724777d), new NpgsqlTypes.NpgsqlPoint(x: 0.3543532692884491d, y: 0.04571884365838197d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21260689282327772d, y: 0.6543858584902773d), new NpgsqlTypes.NpgsqlPoint(x: 0.5615397390801053d, y: 0.6582425621038623d), new NpgsqlTypes.NpgsqlPoint(x: 0.2808965644071205d, y: 0.6025057405080047d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2756265668654664d, y: 0.061816176344358875d), new NpgsqlTypes.NpgsqlPoint(x: 0.3423591707367002d, y: 0.2155924406798554d), new NpgsqlTypes.NpgsqlPoint(x: 0.9477142974011372d, y: 0.6617085348970638d)),
},
    ModelInner = new NpgsqlPolygonpolygonMArrayD11MI
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8473321713272479d, y: 0.15360402662919492d), new NpgsqlTypes.NpgsqlPoint(x: 0.46122427679531386d, y: 0.011518563165447637d), new NpgsqlTypes.NpgsqlPoint(x: 0.4189238623037306d, y: 0.8446907988190455d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7440501315518514d, y: 0.3014661106737003d), new NpgsqlTypes.NpgsqlPoint(x: 0.05068500844333779d, y: 0.7016304195011152d), new NpgsqlTypes.NpgsqlPoint(x: 0.10520942660865196d, y: 0.30521183833696386d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.975817463927265d, y: 0.9346185795403935d), new NpgsqlTypes.NpgsqlPoint(x: 0.9149138028806246d, y: 0.6270486834492519d), new NpgsqlTypes.NpgsqlPoint(x: 0.5601565120954407d, y: 0.5124467567182155d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5029154131404457d, y: 0.28780743665017794d), new NpgsqlTypes.NpgsqlPoint(x: 0.004777282133437755d, y: 0.8860826307769563d), new NpgsqlTypes.NpgsqlPoint(x: 0.39684667339430835d, y: 0.392661173035584d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6971494014187543d, y: 0.7292784454604244d), new NpgsqlTypes.NpgsqlPoint(x: 0.5037249128738228d, y: 0.3013477051656479d), new NpgsqlTypes.NpgsqlPoint(x: 0.17275140623161223d, y: 0.4354760389528354d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3097389075639192d, y: 0.03964319756332513d), new NpgsqlTypes.NpgsqlPoint(x: 0.31617641187376755d, y: 0.38974468971461873d), new NpgsqlTypes.NpgsqlPoint(x: 0.9661519890348877d, y: 0.7313517357925347d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40401369021605316d, y: 0.8581074437970834d), new NpgsqlTypes.NpgsqlPoint(x: 0.5365373819316644d, y: 0.5549057698247565d), new NpgsqlTypes.NpgsqlPoint(x: 0.3939650918472378d, y: 0.9516719600577875d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14861224504663006d, y: 0.32745093782822443d), new NpgsqlTypes.NpgsqlPoint(x: 0.758690039040881d, y: 0.6722734121697171d), new NpgsqlTypes.NpgsqlPoint(x: 0.977660811144534d, y: 0.8939618167847811d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMArrayD1E1M
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6700454122409383d, y: 0.6923618202326143d), new NpgsqlTypes.NpgsqlPoint(x: 0.9310921882513089d, y: 0.43915620498062313d), new NpgsqlTypes.NpgsqlPoint(x: 0.4025538870094041d, y: 0.668402332350472d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7599545408571111d, y: 0.14760325357009496d), new NpgsqlTypes.NpgsqlPoint(x: 0.26062348371124067d, y: 0.2548949376581998d), new NpgsqlTypes.NpgsqlPoint(x: 0.4663647512111122d, y: 0.012240739337699535d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28596931973342854d, y: 0.49916166719923327d), new NpgsqlTypes.NpgsqlPoint(x: 0.5011211381086675d, y: 0.324502357825865d), new NpgsqlTypes.NpgsqlPoint(x: 0.5597243146847241d, y: 0.7263341137014023d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6873939963467146d, y: 0.42090072140039114d), new NpgsqlTypes.NpgsqlPoint(x: 0.0020257190772359213d, y: 0.5183448548052405d), new NpgsqlTypes.NpgsqlPoint(x: 0.6699971633785131d, y: 0.8860366311778541d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMArrayD1E1M
{
    Id = 92,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8932895648917475d, y: 0.838396390773807d), new NpgsqlTypes.NpgsqlPoint(x: 0.13040762302385334d, y: 0.7438608258645376d), new NpgsqlTypes.NpgsqlPoint(x: 0.026066156292736453d, y: 0.45169947870042315d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5691240953750961d, y: 0.8506983306734198d), new NpgsqlTypes.NpgsqlPoint(x: 0.9281519527482452d, y: 0.4683244258658744d), new NpgsqlTypes.NpgsqlPoint(x: 0.5314419313118263d, y: 0.7212141976122038d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8333295139552251d, y: 0.874847290973853d), new NpgsqlTypes.NpgsqlPoint(x: 0.7795414848146596d, y: 0.522983007499475d), new NpgsqlTypes.NpgsqlPoint(x: 0.4189260145925251d, y: 0.27809324519987577d)),
},
    ModelInner = new NpgsqlPolygonpolygonMArrayD11MI
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6114412143476403d, y: 0.897274629424439d), new NpgsqlTypes.NpgsqlPoint(x: 0.9262886802619688d, y: 0.7195659525802373d), new NpgsqlTypes.NpgsqlPoint(x: 0.6932227196026992d, y: 0.814304247207812d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3973420570887862d, y: 0.1875918852464179d), new NpgsqlTypes.NpgsqlPoint(x: 0.6613433345387933d, y: 0.7896583899295915d), new NpgsqlTypes.NpgsqlPoint(x: 0.2262150125087583d, y: 0.47315643099017723d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6375914583612236d, y: 0.6418570150994218d), new NpgsqlTypes.NpgsqlPoint(x: 0.49872991678426015d, y: 0.11662685183279498d), new NpgsqlTypes.NpgsqlPoint(x: 0.6975931261920054d, y: 0.5386550518681233d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7350771915844987d, y: 0.4094911218567724d), new NpgsqlTypes.NpgsqlPoint(x: 0.12535886303844168d, y: 0.2907255854176998d), new NpgsqlTypes.NpgsqlPoint(x: 0.35677474392536745d, y: 0.022584990735345145d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15010750409334894d, y: 0.0017018631087961644d), new NpgsqlTypes.NpgsqlPoint(x: 0.6598725905145336d, y: 0.23975476626568504d), new NpgsqlTypes.NpgsqlPoint(x: 0.9394959051297915d, y: 0.9267142675210092d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24924776767494627d, y: 0.7927233156030934d), new NpgsqlTypes.NpgsqlPoint(x: 0.26389220156270343d, y: 0.6039729094630989d), new NpgsqlTypes.NpgsqlPoint(x: 0.7752300091416439d, y: 0.6567798580798829d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7919263752071247d, y: 0.20977266088979862d), new NpgsqlTypes.NpgsqlPoint(x: 0.16573396131675977d, y: 0.47998856162027304d), new NpgsqlTypes.NpgsqlPoint(x: 0.9176437339689755d, y: 0.21149804638497494d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6664393827116368d, y: 0.784654574270841d), new NpgsqlTypes.NpgsqlPoint(x: 0.8039399972574501d, y: 0.5756769089994105d), new NpgsqlTypes.NpgsqlPoint(x: 0.04680096063424699d, y: 0.23683509234171807d)),
},
},
            new NpgsqlPolygonpolygonMArrayD1E1M
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1884902555446475d, y: 0.7465209588041031d), new NpgsqlTypes.NpgsqlPoint(x: 0.8098923758433998d, y: 0.4676975328800552d), new NpgsqlTypes.NpgsqlPoint(x: 0.5910781872234515d, y: 0.4116082872026712d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47439657053997564d, y: 0.8141906884027004d), new NpgsqlTypes.NpgsqlPoint(x: 0.8911165189244629d, y: 0.9782203772347674d), new NpgsqlTypes.NpgsqlPoint(x: 0.777415415944314d, y: 0.21495174101904468d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28539098214313696d, y: 0.5461734101064333d), new NpgsqlTypes.NpgsqlPoint(x: 0.7996301814256338d, y: 0.8934936428317417d), new NpgsqlTypes.NpgsqlPoint(x: 0.05036888452587618d, y: 0.840248614960485d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMArrayD1E1M
{
    Id = 97,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3276987463510639d, y: 0.4711672696546704d), new NpgsqlTypes.NpgsqlPoint(x: 0.2537480547466132d, y: 0.3899716459651945d), new NpgsqlTypes.NpgsqlPoint(x: 0.4010667997530214d, y: 0.8545553824972274d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25876318455236846d, y: 0.8766509098540567d), new NpgsqlTypes.NpgsqlPoint(x: 0.4890308000974063d, y: 0.24247328494579434d), new NpgsqlTypes.NpgsqlPoint(x: 0.5260586280802825d, y: 0.7725197084054489d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5658683649353347d, y: 0.13921379385240107d), new NpgsqlTypes.NpgsqlPoint(x: 0.68261181171174d, y: 0.1127345574788271d), new NpgsqlTypes.NpgsqlPoint(x: 0.24578862844642058d, y: 0.489653587182421d)),
},
    ModelInner = new NpgsqlPolygonpolygonMArrayD11MI
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9926195308005641d, y: 0.3938995797565935d), new NpgsqlTypes.NpgsqlPoint(x: 0.4122783608023991d, y: 0.5797448439313334d), new NpgsqlTypes.NpgsqlPoint(x: 0.29335694600724227d, y: 0.15204782368895986d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09604834567078113d, y: 0.5113770262143872d), new NpgsqlTypes.NpgsqlPoint(x: 0.5151696892464173d, y: 0.646494550000904d), new NpgsqlTypes.NpgsqlPoint(x: 0.14804932459560294d, y: 0.5534968599926295d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.584925889461656d, y: 0.8467762761678713d), new NpgsqlTypes.NpgsqlPoint(x: 0.18490827013653055d, y: 0.3015585238313475d), new NpgsqlTypes.NpgsqlPoint(x: 0.9484971501715171d, y: 0.5509518892672887d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6767685889489377d, y: 0.5875386970629279d), new NpgsqlTypes.NpgsqlPoint(x: 0.6722207589486255d, y: 0.6687496794996725d), new NpgsqlTypes.NpgsqlPoint(x: 0.4622780932110099d, y: 0.22435099832978778d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04850557702636704d, y: 0.9828597933297013d), new NpgsqlTypes.NpgsqlPoint(x: 0.04574948863596262d, y: 0.023499976459497196d), new NpgsqlTypes.NpgsqlPoint(x: 0.954276982373005d, y: 0.5111334155263646d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7104568869037299d, y: 0.4606315914419592d), new NpgsqlTypes.NpgsqlPoint(x: 0.8543579312041126d, y: 0.675594432740497d), new NpgsqlTypes.NpgsqlPoint(x: 0.9808560225163472d, y: 0.1572920049883091d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMArrayD1E1M
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8776403125926043d, y: 0.7274493499407486d), new NpgsqlTypes.NpgsqlPoint(x: 0.8695929038955518d, y: 0.409270910606936d), new NpgsqlTypes.NpgsqlPoint(x: 0.5826205644912922d, y: 0.13294227303772221d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6380234274752206d, y: 0.8019062073692689d), new NpgsqlTypes.NpgsqlPoint(x: 0.47167092218510664d, y: 0.0043856163075000065d), new NpgsqlTypes.NpgsqlPoint(x: 0.3210112508777204d, y: 0.21088114024176907d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20455507485241864d, y: 0.04064436820356243d), new NpgsqlTypes.NpgsqlPoint(x: 0.7157026424387045d, y: 0.6248952889054543d), new NpgsqlTypes.NpgsqlPoint(x: 0.36159889054661054d, y: 0.5816871781477219d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26934388433316203d, y: 0.2354025083456881d), new NpgsqlTypes.NpgsqlPoint(x: 0.7468453899849897d, y: 0.22266588072800375d), new NpgsqlTypes.NpgsqlPoint(x: 0.074247718104831d, y: 0.002663910232417299d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMArrayD1E1M
{
    Id = 101,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5226475901533622d, y: 0.6943643033172315d), new NpgsqlTypes.NpgsqlPoint(x: 0.1652468480931477d, y: 0.3134007651904508d), new NpgsqlTypes.NpgsqlPoint(x: 0.8780958169383606d, y: 0.673663184168212d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7018229463939523d, y: 0.10636496176453702d), new NpgsqlTypes.NpgsqlPoint(x: 0.9697107356556766d, y: 0.014574338174831447d), new NpgsqlTypes.NpgsqlPoint(x: 0.4928708851688828d, y: 0.2149053734859805d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1254773309235463d, y: 0.5000634408538639d), new NpgsqlTypes.NpgsqlPoint(x: 0.2672262348676291d, y: 0.2189078743105871d), new NpgsqlTypes.NpgsqlPoint(x: 0.8824761107800329d, y: 0.1579356691724022d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.989297133863862d, y: 0.26731230800835826d), new NpgsqlTypes.NpgsqlPoint(x: 0.3181483283835237d, y: 0.23492419673196985d), new NpgsqlTypes.NpgsqlPoint(x: 0.2826302303610073d, y: 0.25018540161172187d)),
},
    ModelInner = new NpgsqlPolygonpolygonMArrayD11MI
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3103760815490654d, y: 0.7833159456170924d), new NpgsqlTypes.NpgsqlPoint(x: 0.37157119426835583d, y: 0.9043213154073023d), new NpgsqlTypes.NpgsqlPoint(x: 0.49375741134632534d, y: 0.7751154610868329d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6196122882796697d, y: 0.04144179494172662d), new NpgsqlTypes.NpgsqlPoint(x: 0.9746367722302174d, y: 0.044412841461198616d), new NpgsqlTypes.NpgsqlPoint(x: 0.10783570909282802d, y: 0.7600096607255374d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9434144400774174d, y: 0.675271511052209d), new NpgsqlTypes.NpgsqlPoint(x: 0.8737202037175223d, y: 0.8895482667146296d), new NpgsqlTypes.NpgsqlPoint(x: 0.3219168769789833d, y: 0.9286886381743353d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46964150131307836d, y: 0.31561390032236036d), new NpgsqlTypes.NpgsqlPoint(x: 0.5031207217539316d, y: 0.3185739585868851d), new NpgsqlTypes.NpgsqlPoint(x: 0.44554957166278575d, y: 0.4055804239932067d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9071356220659386d, y: 0.10330057433668449d), new NpgsqlTypes.NpgsqlPoint(x: 0.3434238001783243d, y: 0.17819035606302613d), new NpgsqlTypes.NpgsqlPoint(x: 0.5293439243498677d, y: 0.8377717890917389d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21769957915160787d, y: 0.5352422733787463d), new NpgsqlTypes.NpgsqlPoint(x: 0.22816196346347206d, y: 0.7910925603723561d), new NpgsqlTypes.NpgsqlPoint(x: 0.24817486823097856d, y: 0.6292298172324547d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3482671242497598d, y: 0.9732071758693768d), new NpgsqlTypes.NpgsqlPoint(x: 0.6212113322040683d, y: 0.11072310189624623d), new NpgsqlTypes.NpgsqlPoint(x: 0.83463237455355d, y: 0.441069802926466d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMArrayD1E1M
{
    Id = 110,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4283822937976217d, y: 0.007415892007661573d), new NpgsqlTypes.NpgsqlPoint(x: 0.056709661032542935d, y: 0.6936901853808748d), new NpgsqlTypes.NpgsqlPoint(x: 0.04067831413995282d, y: 0.12113719166933967d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05940940154458407d, y: 0.5378631048203669d), new NpgsqlTypes.NpgsqlPoint(x: 0.9820154108354762d, y: 0.6470087607200656d), new NpgsqlTypes.NpgsqlPoint(x: 0.1680169313540234d, y: 0.032070707345192684d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2333989452292502d, y: 0.14617616764662944d), new NpgsqlTypes.NpgsqlPoint(x: 0.5520838221039726d, y: 0.3142647072712843d), new NpgsqlTypes.NpgsqlPoint(x: 0.6677542055460357d, y: 0.6687764327232353d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6614251782812086d, y: 0.15965579412277542d), new NpgsqlTypes.NpgsqlPoint(x: 0.4802354504822596d, y: 0.8158585712124397d), new NpgsqlTypes.NpgsqlPoint(x: 0.09046695879454991d, y: 0.9534902537049792d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8373965932902155d, y: 0.9373223467408248d), new NpgsqlTypes.NpgsqlPoint(x: 0.1367037515451458d, y: 0.6209355600039353d), new NpgsqlTypes.NpgsqlPoint(x: 0.12138917589317844d, y: 0.9702629710999869d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7680648913970635d, y: 0.7083995240650973d), new NpgsqlTypes.NpgsqlPoint(x: 0.4426218857687252d, y: 0.6794236745225014d), new NpgsqlTypes.NpgsqlPoint(x: 0.8919044050981405d, y: 0.6493527997588708d)),
},
},
            new NpgsqlPolygonpolygonMArrayD1E1M
{
    Id = 118,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7276583711864594d, y: 0.6108206451867204d), new NpgsqlTypes.NpgsqlPoint(x: 0.46287041579714827d, y: 0.7442696029531675d), new NpgsqlTypes.NpgsqlPoint(x: 0.1841753257109262d, y: 0.30710630862806854d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7937783446143397d, y: 0.5398674091129602d), new NpgsqlTypes.NpgsqlPoint(x: 0.9974489419075345d, y: 0.7764467108366351d), new NpgsqlTypes.NpgsqlPoint(x: 0.8579939254881395d, y: 0.04699385806157752d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8121405620917709d, y: 0.9058649952888218d), new NpgsqlTypes.NpgsqlPoint(x: 0.06308412733469448d, y: 0.46237357571139437d), new NpgsqlTypes.NpgsqlPoint(x: 0.47492461499703553d, y: 0.4717112415622867d)),
},
    ModelInner = new NpgsqlPolygonpolygonMArrayD11MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.019966800744055213d, y: 0.43621375969083465d), new NpgsqlTypes.NpgsqlPoint(x: 0.2648313556467289d, y: 0.7534102477163452d), new NpgsqlTypes.NpgsqlPoint(x: 0.8583958967578759d, y: 0.7889723515587703d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9551166509320194d, y: 0.5970136677197827d), new NpgsqlTypes.NpgsqlPoint(x: 0.29747602679985197d, y: 0.5773584503076d), new NpgsqlTypes.NpgsqlPoint(x: 0.20689655962638243d, y: 0.1466914264486069d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6305549922227938d, y: 0.42743829614232476d), new NpgsqlTypes.NpgsqlPoint(x: 0.04875169017755898d, y: 0.5736178738083735d), new NpgsqlTypes.NpgsqlPoint(x: 0.48743275066336056d, y: 0.9101900949521988d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMArrayD1E1M
{
    Id = 123,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24261376934552237d, y: 0.3191098442998912d), new NpgsqlTypes.NpgsqlPoint(x: 0.004960213615089359d, y: 0.9585027938439813d), new NpgsqlTypes.NpgsqlPoint(x: 0.7753923255402293d, y: 0.48427221329144765d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.749066453447974d, y: 0.7624924053653692d), new NpgsqlTypes.NpgsqlPoint(x: 0.23519279055185938d, y: 0.17863968053597523d), new NpgsqlTypes.NpgsqlPoint(x: 0.038021028440521465d, y: 0.7389742249122674d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17090503688402336d, y: 0.9269831801946701d), new NpgsqlTypes.NpgsqlPoint(x: 0.26820171444084606d, y: 0.3325886523634649d), new NpgsqlTypes.NpgsqlPoint(x: 0.13944343735504794d, y: 0.42455846450060386d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3583286986830698d, y: 0.2185693559692572d), new NpgsqlTypes.NpgsqlPoint(x: 0.6923212356649049d, y: 0.039076196222155524d), new NpgsqlTypes.NpgsqlPoint(x: 0.22764497131480654d, y: 0.0028020775398988063d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18518160689810448d, y: 0.29176017230982587d), new NpgsqlTypes.NpgsqlPoint(x: 0.5166034590059556d, y: 0.8211816949700845d), new NpgsqlTypes.NpgsqlPoint(x: 0.3110920286486396d, y: 0.22561523937301753d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2622723342176918d, y: 0.7043216150155881d), new NpgsqlTypes.NpgsqlPoint(x: 0.9277126061861615d, y: 0.5371643092115749d), new NpgsqlTypes.NpgsqlPoint(x: 0.8299256566022322d, y: 0.4825263540346827d)),
},
},
            new NpgsqlPolygonpolygonMArrayD1E1M
{
    Id = 126,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40181184610460985d, y: 0.4678014623454003d), new NpgsqlTypes.NpgsqlPoint(x: 0.5666181153342323d, y: 0.5407040699116955d), new NpgsqlTypes.NpgsqlPoint(x: 0.8600806871329888d, y: 0.2837148046439292d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18712641811813446d, y: 0.4041413181352487d), new NpgsqlTypes.NpgsqlPoint(x: 0.2908228247488629d, y: 0.18637166157152285d), new NpgsqlTypes.NpgsqlPoint(x: 0.42655376908495646d, y: 0.9681939824791658d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6793170222701681d, y: 0.2191243944473047d), new NpgsqlTypes.NpgsqlPoint(x: 0.98189106416779d, y: 0.31030976574261937d), new NpgsqlTypes.NpgsqlPoint(x: 0.6888668277756307d, y: 0.5854522020994585d)),
},
    ModelInner = new NpgsqlPolygonpolygonMArrayD11MI
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7609518743388196d, y: 0.09458482955216652d), new NpgsqlTypes.NpgsqlPoint(x: 0.2973973283868069d, y: 0.2320166374827255d), new NpgsqlTypes.NpgsqlPoint(x: 0.15753159936323602d, y: 0.44855802818658663d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9508115233817361d, y: 0.928343131670533d), new NpgsqlTypes.NpgsqlPoint(x: 0.2599956850135856d, y: 0.7732158911559756d), new NpgsqlTypes.NpgsqlPoint(x: 0.5209857458296591d, y: 0.18393320216990383d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7710496455468909d, y: 0.18618543746981397d), new NpgsqlTypes.NpgsqlPoint(x: 0.20981924715077027d, y: 0.8925164745936728d), new NpgsqlTypes.NpgsqlPoint(x: 0.9872615127368276d, y: 0.232666322949992d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9419166017805353d, y: 0.6068318404896151d), new NpgsqlTypes.NpgsqlPoint(x: 0.20377544499685984d, y: 0.8014782134773667d), new NpgsqlTypes.NpgsqlPoint(x: 0.0616302982794531d, y: 0.7647573408037271d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9005956210544144d, y: 0.7535009943498548d), new NpgsqlTypes.NpgsqlPoint(x: 0.131224200870238d, y: 0.34050256540391177d), new NpgsqlTypes.NpgsqlPoint(x: 0.2994463801699665d, y: 0.24925077724850375d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39545330364923503d, y: 0.226836718726513d), new NpgsqlTypes.NpgsqlPoint(x: 0.3669917971249915d, y: 0.8630190548291139d), new NpgsqlTypes.NpgsqlPoint(x: 0.3599428927829841d, y: 0.05164371153135927d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7894930577617054d, y: 0.9986709741787936d), new NpgsqlTypes.NpgsqlPoint(x: 0.8550511046835956d, y: 0.18354272493555646d), new NpgsqlTypes.NpgsqlPoint(x: 0.9745652537451849d, y: 0.7027785473745966d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1684972415356859d, y: 0.13258431663891357d), new NpgsqlTypes.NpgsqlPoint(x: 0.8144401914038611d, y: 0.3810277876328625d), new NpgsqlTypes.NpgsqlPoint(x: 0.5148868660707491d, y: 0.006974514577236746d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMArrayD1E1M
{
    Id = 130,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35004997445694197d, y: 0.2849626226187584d), new NpgsqlTypes.NpgsqlPoint(x: 0.017706071132528978d, y: 0.6452628679928597d), new NpgsqlTypes.NpgsqlPoint(x: 0.09304483813246522d, y: 0.477006463397072d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25141664492571014d, y: 0.6286066110767327d), new NpgsqlTypes.NpgsqlPoint(x: 0.07660673908965476d, y: 0.09371634490971492d), new NpgsqlTypes.NpgsqlPoint(x: 0.7794671502767525d, y: 0.6699606231707868d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5153085942025785d, y: 0.40592508385649606d), new NpgsqlTypes.NpgsqlPoint(x: 0.79311872262799d, y: 0.792746910350266d), new NpgsqlTypes.NpgsqlPoint(x: 0.288348824622492d, y: 0.12750057228410316d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06343897649436514d, y: 0.6527935627325313d), new NpgsqlTypes.NpgsqlPoint(x: 0.5161987646635681d, y: 0.5131414426004671d), new NpgsqlTypes.NpgsqlPoint(x: 0.11730771620495484d, y: 0.07737289898972288d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33929119754991677d, y: 0.5810929770911339d), new NpgsqlTypes.NpgsqlPoint(x: 0.7077563963485739d, y: 0.07566842401647789d), new NpgsqlTypes.NpgsqlPoint(x: 0.978937590961568d, y: 0.9920179859566571d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3267188292239631d, y: 0.8703049774570322d), new NpgsqlTypes.NpgsqlPoint(x: 0.5134605109415323d, y: 0.7764457300226134d), new NpgsqlTypes.NpgsqlPoint(x: 0.7557285885534921d, y: 0.6189302515783046d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7282610711879854d, y: 0.01584223844284305d), new NpgsqlTypes.NpgsqlPoint(x: 0.6755350885005555d, y: 0.19087539272157794d), new NpgsqlTypes.NpgsqlPoint(x: 0.43527941627116584d, y: 0.9846643371639061d)),
},
},
            new NpgsqlPolygonpolygonMArrayD1E1M
{
    Id = 138,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04602640276296022d, y: 0.8647615085623112d), new NpgsqlTypes.NpgsqlPoint(x: 0.8451004810951815d, y: 0.9963035859643784d), new NpgsqlTypes.NpgsqlPoint(x: 0.7271605185039945d, y: 0.581500009402528d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5404710277952117d, y: 0.7548425757949033d), new NpgsqlTypes.NpgsqlPoint(x: 0.754231414232097d, y: 0.15310835533428313d), new NpgsqlTypes.NpgsqlPoint(x: 0.2738621003916418d, y: 0.9531038364182538d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7217907372162707d, y: 0.7192721430009408d), new NpgsqlTypes.NpgsqlPoint(x: 0.18470375197883493d, y: 0.7211151617887139d), new NpgsqlTypes.NpgsqlPoint(x: 0.011180597718889351d, y: 0.15169731233640582d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7169518534311086d, y: 0.09184808512766973d), new NpgsqlTypes.NpgsqlPoint(x: 0.22801022887698308d, y: 0.05640277277858918d), new NpgsqlTypes.NpgsqlPoint(x: 0.835303196320656d, y: 0.07715173411547604d)),
},
    ModelInner = new NpgsqlPolygonpolygonMArrayD11MI
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5986543737115511d, y: 0.9686382447980756d), new NpgsqlTypes.NpgsqlPoint(x: 0.899833442850827d, y: 0.3058121716911617d), new NpgsqlTypes.NpgsqlPoint(x: 0.10264480704012613d, y: 0.8050693865783415d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37825341077209573d, y: 0.4246942706252106d), new NpgsqlTypes.NpgsqlPoint(x: 0.6111373185019949d, y: 0.9939234348184679d), new NpgsqlTypes.NpgsqlPoint(x: 0.2612479154231392d, y: 0.22768919343485172d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9652701131043792d, y: 0.4967992539977599d), new NpgsqlTypes.NpgsqlPoint(x: 0.8695929648026763d, y: 0.04868491056570612d), new NpgsqlTypes.NpgsqlPoint(x: 0.24869611107179868d, y: 0.6074871610983658d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMArrayD1E1M
{
    Id = 142,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5737040740755943d, y: 0.26591414032936067d), new NpgsqlTypes.NpgsqlPoint(x: 0.33276307661790216d, y: 0.002561192737064122d), new NpgsqlTypes.NpgsqlPoint(x: 0.6437265947285891d, y: 0.6486225838308175d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8442905854522437d, y: 0.012890112561751321d), new NpgsqlTypes.NpgsqlPoint(x: 0.5623708794850266d, y: 0.3069496128031495d), new NpgsqlTypes.NpgsqlPoint(x: 0.6184465406353045d, y: 0.9586717843452902d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30271047698128517d, y: 0.884296519447073d), new NpgsqlTypes.NpgsqlPoint(x: 0.31218049521869684d, y: 0.032200104147566466d), new NpgsqlTypes.NpgsqlPoint(x: 0.28055987280969186d, y: 0.7780426168827256d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6268071339649d, y: 0.387370166995211d), new NpgsqlTypes.NpgsqlPoint(x: 0.4103810215378674d, y: 0.7763654874470551d), new NpgsqlTypes.NpgsqlPoint(x: 0.5428793062421614d, y: 0.2738655742464181d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMArrayD1E1M
{
    Id = 146,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15523589779507097d, y: 0.790253722251174d), new NpgsqlTypes.NpgsqlPoint(x: 0.965156563502403d, y: 0.9630182121036261d), new NpgsqlTypes.NpgsqlPoint(x: 0.7978771841053657d, y: 0.8262176108693696d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39361781131830376d, y: 0.08857586188338207d), new NpgsqlTypes.NpgsqlPoint(x: 0.8293939869885513d, y: 0.6227629669419106d), new NpgsqlTypes.NpgsqlPoint(x: 0.6592000875792202d, y: 0.9265797502705098d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.005534740289310447d, y: 0.6532861825552714d), new NpgsqlTypes.NpgsqlPoint(x: 0.48945767816321917d, y: 0.7690998505157994d), new NpgsqlTypes.NpgsqlPoint(x: 0.5555033665030864d, y: 0.1453424218063486d)),
},
    ModelInner = new NpgsqlPolygonpolygonMArrayD11MI
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44461199684397557d, y: 0.29062787472100415d), new NpgsqlTypes.NpgsqlPoint(x: 0.30216969929861137d, y: 0.7074071753279081d), new NpgsqlTypes.NpgsqlPoint(x: 0.6315230696362302d, y: 0.5512760922533011d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34442134723707585d, y: 0.20328659333684473d), new NpgsqlTypes.NpgsqlPoint(x: 0.9748101184709317d, y: 0.16354059456377967d), new NpgsqlTypes.NpgsqlPoint(x: 0.64352202277561d, y: 0.9891669002911996d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9107379337916097d, y: 0.13880101022657965d), new NpgsqlTypes.NpgsqlPoint(x: 0.1212433037652032d, y: 0.6810028667116123d), new NpgsqlTypes.NpgsqlPoint(x: 0.005539409591887479d, y: 0.14902551877582448d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9847722156428516d, y: 0.872322629448976d), new NpgsqlTypes.NpgsqlPoint(x: 0.9440497928845363d, y: 0.6298526073790335d), new NpgsqlTypes.NpgsqlPoint(x: 0.21676246406060706d, y: 0.908743626060497d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23044687735626523d, y: 0.24422392420936334d), new NpgsqlTypes.NpgsqlPoint(x: 0.15931476164204994d, y: 0.8298932656917273d), new NpgsqlTypes.NpgsqlPoint(x: 0.85453778077663d, y: 0.34936654842893833d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1879375594472854d, y: 0.17866163842810345d), new NpgsqlTypes.NpgsqlPoint(x: 0.29035164358192667d, y: 0.9954612225734785d), new NpgsqlTypes.NpgsqlPoint(x: 0.850430731476266d, y: 0.8830552070155283d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7225392978110144d, y: 0.92542885680988d), new NpgsqlTypes.NpgsqlPoint(x: 0.4058959938386272d, y: 0.03867949432486606d), new NpgsqlTypes.NpgsqlPoint(x: 0.16591155032910376d, y: 0.7653532204413943d)),
},
},
            new NpgsqlPolygonpolygonMArrayD1E1M
{
    Id = 155,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7758340809318374d, y: 0.8275687766831695d), new NpgsqlTypes.NpgsqlPoint(x: 0.4453513051603425d, y: 0.16297647816624383d), new NpgsqlTypes.NpgsqlPoint(x: 0.17243678186414668d, y: 0.26807465942791586d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26597730667134556d, y: 0.002965363030050794d), new NpgsqlTypes.NpgsqlPoint(x: 0.8043667794587723d, y: 0.6089682263725766d), new NpgsqlTypes.NpgsqlPoint(x: 0.7462361002288795d, y: 0.06954240266395861d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6311441204067494d, y: 0.9659685178859396d), new NpgsqlTypes.NpgsqlPoint(x: 0.03892097417171325d, y: 0.6116638098668358d), new NpgsqlTypes.NpgsqlPoint(x: 0.8673354232873114d, y: 0.9619243909368336d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMArrayD1E1M
{
    Id = 159,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23354441274182802d, y: 0.7590267466674739d), new NpgsqlTypes.NpgsqlPoint(x: 0.17782047732145856d, y: 0.32833354894909195d), new NpgsqlTypes.NpgsqlPoint(x: 0.24014689020634505d, y: 0.8901437977471285d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.061790763995859366d, y: 0.6385844183347474d), new NpgsqlTypes.NpgsqlPoint(x: 0.3562633834834791d, y: 0.17175799056658703d), new NpgsqlTypes.NpgsqlPoint(x: 0.14650373200489875d, y: 0.7323451634634991d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.00820499902812366d, y: 0.04679745681245595d), new NpgsqlTypes.NpgsqlPoint(x: 0.7904368924209325d, y: 0.1706874587836168d), new NpgsqlTypes.NpgsqlPoint(x: 0.8249652867341475d, y: 0.12579515198932678d)),
},
    ModelInner = new NpgsqlPolygonpolygonMArrayD11MI
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10936363340229871d, y: 0.6521550668788321d), new NpgsqlTypes.NpgsqlPoint(x: 0.42321673402033166d, y: 0.1287985105453534d), new NpgsqlTypes.NpgsqlPoint(x: 0.9084171108358492d, y: 0.6791666837923575d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5704411216952555d, y: 0.32805430061748686d), new NpgsqlTypes.NpgsqlPoint(x: 0.5692260887510978d, y: 0.2098184947264795d), new NpgsqlTypes.NpgsqlPoint(x: 0.452831908802966d, y: 0.18919920454577566d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18166359356469963d, y: 0.6049055843773936d), new NpgsqlTypes.NpgsqlPoint(x: 0.9208995084655985d, y: 0.21989001870137026d), new NpgsqlTypes.NpgsqlPoint(x: 0.7420661827947156d, y: 0.6323836508213785d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22940863146699375d, y: 0.35364463184003514d), new NpgsqlTypes.NpgsqlPoint(x: 0.9789428176203029d, y: 0.1113527251263774d), new NpgsqlTypes.NpgsqlPoint(x: 0.365582954347208d, y: 0.19458692459117766d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9568571622917579d, y: 0.7145982751261374d), new NpgsqlTypes.NpgsqlPoint(x: 0.16405956130988752d, y: 0.21492494494968195d), new NpgsqlTypes.NpgsqlPoint(x: 0.4342933399466786d, y: 0.24470016916572768d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.470856360977316d, y: 0.649010749869777d), new NpgsqlTypes.NpgsqlPoint(x: 0.8558666617204475d, y: 0.06961015447429442d), new NpgsqlTypes.NpgsqlPoint(x: 0.2683392573160588d, y: 0.8663079916296178d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4597692657675797d, y: 0.2895700654932072d), new NpgsqlTypes.NpgsqlPoint(x: 0.05844407002436669d, y: 0.1997231171679954d), new NpgsqlTypes.NpgsqlPoint(x: 0.7147422837689993d, y: 0.39483832156011955d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5277899853719635d, y: 0.4525570877354016d), new NpgsqlTypes.NpgsqlPoint(x: 0.8391904128740327d, y: 0.632206690867266d), new NpgsqlTypes.NpgsqlPoint(x: 0.23239559391054398d, y: 0.41790919249274117d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.765849788024246d, y: 0.7511994048451245d), new NpgsqlTypes.NpgsqlPoint(x: 0.5727076828709037d, y: 0.6046708329879502d), new NpgsqlTypes.NpgsqlPoint(x: 0.9180125363250833d, y: 0.5728781224792525d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9474375550885356d, y: 0.45652615229161175d), new NpgsqlTypes.NpgsqlPoint(x: 0.031078598670531643d, y: 0.14475994487649935d), new NpgsqlTypes.NpgsqlPoint(x: 0.04451797758440845d, y: 0.1664181806838163d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3734982301392862d, y: 0.2211791048932118d), new NpgsqlTypes.NpgsqlPoint(x: 0.4473403302422906d, y: 0.19951345512515595d), new NpgsqlTypes.NpgsqlPoint(x: 0.8494007033309123d, y: 0.3449922201495086d)),
},
},
            new NpgsqlPolygonpolygonMArrayD1E1M
{
    Id = 163,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7153707596417929d, y: 0.4348774804242461d), new NpgsqlTypes.NpgsqlPoint(x: 0.043855170123212495d, y: 0.8935426622309083d), new NpgsqlTypes.NpgsqlPoint(x: 0.487715709409004d, y: 0.8837883895736658d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5890903793051392d, y: 0.07040722760266993d), new NpgsqlTypes.NpgsqlPoint(x: 0.514637423213172d, y: 0.5155532515098261d), new NpgsqlTypes.NpgsqlPoint(x: 0.13330081869253962d, y: 0.022923563819796766d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34929804118287056d, y: 0.5297482271134036d), new NpgsqlTypes.NpgsqlPoint(x: 0.43112347069311685d, y: 0.16346256651383873d), new NpgsqlTypes.NpgsqlPoint(x: 0.6863021539610621d, y: 0.38356670360357303d)),
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmarrayd11mi(
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1)),
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
INSERT INTO public.npgsqlpolygonpolygonmarrayd11mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1)),
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

                changedRows =  ((INpgsqlPolygonMArraypolygonMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonMArraypolygonMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPolygonMArraypolygonMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPolygonMArraypolygonMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonmarrayd11mi_id
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1)), 
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
                methodParametrName: "npgsqlpolygonpolygonmarrayd11mi_id", 
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
                changedRows =  ((INpgsqlPolygonMArraypolygonMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPolygonMArraypolygonMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonmarrayd11mi_id
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
    npgsqlpolygonpolygonmarrayd11mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1)),
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

                    nullable =  ((INpgsqlPolygonMArraypolygonMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04540556829311082d, y: 0.22803976370118184d), new NpgsqlTypes.NpgsqlPoint(x: 0.9223482370107665d, y: 0.1763792191361916d), new NpgsqlTypes.NpgsqlPoint(x: 0.5800010978452346d, y: 0.20554531423891897d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26939083380843376d, y: 0.7852588624606227d), new NpgsqlTypes.NpgsqlPoint(x: 0.9735108845222175d, y: 0.5823361901126708d), new NpgsqlTypes.NpgsqlPoint(x: 0.49286956003139626d, y: 0.6087614907326485d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03444549696976451d, y: 0.6867345890491554d), new NpgsqlTypes.NpgsqlPoint(x: 0.48762554579615136d, y: 0.528050954371456d), new NpgsqlTypes.NpgsqlPoint(x: 0.11018364970769146d, y: 0.2524754630891901d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6766964793133998d, y: 0.04881141754988216d), new NpgsqlTypes.NpgsqlPoint(x: 0.24640248026105838d, y: 0.4943483979705262d), new NpgsqlTypes.NpgsqlPoint(x: 0.8224525482580913d, y: 0.5384935200492709d)),
}));
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

                    nullable =  ((INpgsqlPolygonMArraypolygonMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
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

                    nullable = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
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

                    nullable = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9304728784575631d, y: 0.41129770879287464d), new NpgsqlTypes.NpgsqlPoint(x: 0.2983256585506764d, y: 0.12072897393724769d), new NpgsqlTypes.NpgsqlPoint(x: 0.7194464690050373d, y: 0.4006319955863441d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6718600079765497d, y: 0.5901390756464053d), new NpgsqlTypes.NpgsqlPoint(x: 0.4721383028920052d, y: 0.1797271547595587d), new NpgsqlTypes.NpgsqlPoint(x: 0.5051232850443973d, y: 0.6564136507805372d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3192081463501226d, y: 0.3179606761569068d), new NpgsqlTypes.NpgsqlPoint(x: 0.7804975687278014d, y: 0.17651107752872497d), new NpgsqlTypes.NpgsqlPoint(x: 0.030349471257704597d, y: 0.14259519529775755d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3716395496545004d, y: 0.3228375290734544d), new NpgsqlTypes.NpgsqlPoint(x: 0.050145969358092346d, y: 0.19741817602175216d), new NpgsqlTypes.NpgsqlPoint(x: 0.9025486213101969d, y: 0.608321594651818d)),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonmarrayd11mi_id
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
    npgsqlpolygonpolygonmarrayd11mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1)),
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
                methodParametrName: "npgsqlpolygonpolygonmarrayd11mi_id", 
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
                nullable =  ((INpgsqlPolygonMArraypolygonMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39568125844089974d, y: 0.9729268177546215d), new NpgsqlTypes.NpgsqlPoint(x: 0.5806489312217933d, y: 0.9013639226978956d), new NpgsqlTypes.NpgsqlPoint(x: 0.8238453199575417d, y: 0.37961412674211403d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9264555944645565d, y: 0.37787028423352653d), new NpgsqlTypes.NpgsqlPoint(x: 0.9706401704715109d, y: 0.15258875894840207d), new NpgsqlTypes.NpgsqlPoint(x: 0.4997674807133433d, y: 0.3125929980642015d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.771194239113924d, y: 0.7986259309775978d), new NpgsqlTypes.NpgsqlPoint(x: 0.2766226908474354d, y: 0.2563157300900354d), new NpgsqlTypes.NpgsqlPoint(x: 0.8237608110163238d, y: 0.6144602605731551d)),
}));
                nullable =  ((INpgsqlPolygonMArraypolygonMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2774825616670987d, y: 0.33096736546431216d), new NpgsqlTypes.NpgsqlPoint(x: 0.17689415452271584d, y: 0.043252243976282245d), new NpgsqlTypes.NpgsqlPoint(x: 0.3828250200138791d, y: 0.16031871873871595d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7880051918190256d, y: 0.5017292758837052d), new NpgsqlTypes.NpgsqlPoint(x: 0.18584581003910305d, y: 0.2841263974950258d), new NpgsqlTypes.NpgsqlPoint(x: 0.9191529967915784d, y: 0.5490928769995786d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9173550264288794d, y: 0.9010598710558505d), new NpgsqlTypes.NpgsqlPoint(x: 0.7881444543635945d, y: 0.36146323286765325d), new NpgsqlTypes.NpgsqlPoint(x: 0.06887102268499457d, y: 0.15156557754477185d)),
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
                nullable = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9585776216872766d, y: 0.7555991774625007d), new NpgsqlTypes.NpgsqlPoint(x: 0.7395321041736356d, y: 0.9767185184340371d), new NpgsqlTypes.NpgsqlPoint(x: 0.271711445367959d, y: 0.05549354120035499d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07003998677758949d, y: 0.6634440129964758d), new NpgsqlTypes.NpgsqlPoint(x: 0.09989410390791631d, y: 0.25061929351861933d), new NpgsqlTypes.NpgsqlPoint(x: 0.12657302188504638d, y: 0.542908689985019d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5695338664970735d, y: 0.9085184288106385d), new NpgsqlTypes.NpgsqlPoint(x: 0.016926823234156174d, y: 0.9058368367390207d), new NpgsqlTypes.NpgsqlPoint(x: 0.3545087687993096d, y: 0.1988217667139487d)),
}));
                nullable = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5629457972182124d, y: 0.7156781333044652d), new NpgsqlTypes.NpgsqlPoint(x: 0.14532419576631683d, y: 0.555988517196821d), new NpgsqlTypes.NpgsqlPoint(x: 0.045357725622319545d, y: 0.11788263790541764d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4293629848859294d, y: 0.9583692829576811d), new NpgsqlTypes.NpgsqlPoint(x: 0.9791978954622641d, y: 0.6377581298533392d), new NpgsqlTypes.NpgsqlPoint(x: 0.4159482743445153d, y: 0.0851986358978768d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8953412941092067d, y: 0.9822407072251549d), new NpgsqlTypes.NpgsqlPoint(x: 0.2722999492047623d, y: 0.4193446899106301d), new NpgsqlTypes.NpgsqlPoint(x: 0.992114252971793d, y: 0.3851646346260944d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5378417149833519d, y: 0.2312058799571367d), new NpgsqlTypes.NpgsqlPoint(x: 0.8162433483800888d, y: 0.17292469207490524d), new NpgsqlTypes.NpgsqlPoint(x: 0.3327690427693588d, y: 0.7955010868373336d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonMArrayD1E1M> models = null;

                models =  ((INpgsqlPolygonMArraypolygonMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPolygonMArraypolygonMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPolygonMArraypolygonMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPolygonMArraypolygonMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonMArrayD1E1M> models = null;

                models = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMArrayD1E1M), typeof(FlatNpgsqlPolygonpolygonMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1)),
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                await ((INpgsqlPolygonMArraypolygonMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                ((INpgsqlPolygonMArraypolygonMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1)),
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPolygonMArraypolygonMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
LEFT JOIN public.npgsqlpolygonpolygonmarrayd11mi mi ON mi.id = m.npgsqlpolygonpolygonmarrayd11mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1)),
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
                var models = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPolygonMArraypolygonMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMArrayD1E1M), typeof(FlatNpgsqlPolygonpolygonMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1)),
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                await ((INpgsqlPolygonMArraypolygonMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                ((INpgsqlPolygonMArraypolygonMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1)),
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonMArraypolygonMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
LEFT JOIN public.npgsqlpolygonpolygonmarrayd11mi mi ON mi.id = m.npgsqlpolygonpolygonmarrayd11mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1)),
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
                var models = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPolygonMArraypolygonMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMArrayD1E1M), typeof(FlatNpgsqlPolygonpolygonMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1)),
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                await((INpgsqlPolygonMArraypolygonMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                await ((INpgsqlPolygonMArraypolygonMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                await ((INpgsqlPolygonMArraypolygonMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[28],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                ((INpgsqlPolygonMArraypolygonMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 146;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                 ((INpgsqlPolygonMArraypolygonMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[28],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                 ((INpgsqlPolygonMArraypolygonMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[17],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1)),
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPolygonMArraypolygonMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 44;
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonMArraypolygonMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[24],_testData[34], false);
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                await ((INpgsqlPolygonMArraypolygonMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPolygonMArraypolygonMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonMArraypolygonMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                 ((INpgsqlPolygonMArraypolygonMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
LEFT JOIN public.npgsqlpolygonpolygonmarrayd11mi mi ON mi.id = m.npgsqlpolygonpolygonmarrayd11mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1)),
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
                var models = await((INpgsqlPolygonMArraypolygonMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 101;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonMArraypolygonMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[5],_testData[29], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[6],_testData[30], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[7],_testData[31], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[8],_testData[32], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[9],_testData[33], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[8],_testData[29], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[9],_testData[30], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[10],_testData[31], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[11],_testData[32], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[12],_testData[33], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[13],_testData[34], false);
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
                var models = ((INpgsqlPolygonMArraypolygonMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 2;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonMArraypolygonMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[28],_testData[29], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[29],_testData[30], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[30],_testData[31], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[31],_testData[32], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[32],_testData[33], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMArrayD1E1M), typeof(FlatNpgsqlPolygonpolygonMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1)),
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                await((INpgsqlPolygonMArraypolygonMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                await ((INpgsqlPolygonMArraypolygonMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 56, query1, 52, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                await ((INpgsqlPolygonMArraypolygonMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 2, query1, 68, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[19],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                ((INpgsqlPolygonMArraypolygonMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                 ((INpgsqlPolygonMArraypolygonMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 101, query1, 14, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                 ((INpgsqlPolygonMArraypolygonMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 88, query1, 81, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[17],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1)),
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPolygonMArraypolygonMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonMArraypolygonMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 76, query1, 118, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[8],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                await ((INpgsqlPolygonMArraypolygonMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 99, query1, 60, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonMArraypolygonMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonMArraypolygonMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 14, query1, 21, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[30],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMArrayD1E1M>();
                 ((INpgsqlPolygonMArraypolygonMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 32, query1, 60, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMArrayD1E1M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmarrayd1e1m m
LEFT JOIN public.npgsqlpolygonpolygonmarrayd11mi mi ON mi.id = m.npgsqlpolygonpolygonmarrayd11mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1)),
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
                var models = await((INpgsqlPolygonMArraypolygonMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonMArraypolygonMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 118, 14))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[0],_testData[3], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[1],_testData[4], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[2],_testData[5], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[3],_testData[6], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[4],_testData[7], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[5],_testData[8], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[6],_testData[9], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[7],_testData[10], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[8],_testData[11], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[9],_testData[12], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[10],_testData[13], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[11],_testData[14], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[12],_testData[15], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[13],_testData[16], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[14],_testData[17], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[15],_testData[18], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[16],_testData[19], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[17],_testData[20], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[18],_testData[21], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[19],_testData[22], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[20],_testData[23], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[21],_testData[24], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[22],_testData[25], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[23],_testData[26], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[24],_testData[27], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[25],_testData[28], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[26],_testData[29], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[27],_testData[30], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[28],_testData[31], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[29],_testData[32], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[30],_testData[33], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[31],_testData[34], false);
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
                var models = ((INpgsqlPolygonMArraypolygonMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonMArraypolygonMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 94, 118))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[8],_testData[29], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[9],_testData[30], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[10],_testData[31], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[11],_testData[32], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[12],_testData[33], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[8],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPolygonMArraypolygonMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 7);
                var models = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(33));

                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[0],_testData[2], false);
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[1],_testData[3], false);
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[2],_testData[4], false);
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[3],_testData[5], false);
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[4],_testData[6], false);
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[5],_testData[7], false);
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[6],_testData[8], false);
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[7],_testData[9], false);
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[8],_testData[10], false);
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[9],_testData[11], false);
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[10],_testData[12], false);
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[11],_testData[13], false);
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[12],_testData[14], false);
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[13],_testData[15], false);
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[14],_testData[16], false);
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[15],_testData[17], false);
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[16],_testData[18], false);
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[17],_testData[19], false);
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[18],_testData[20], false);
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[19],_testData[21], false);
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[20],_testData[22], false);
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[21],_testData[23], false);
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[22],_testData[24], false);
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[23],_testData[25], false);
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[24],_testData[26], false);
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[25],_testData[27], false);
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[26],_testData[28], false);
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[27],_testData[29], false);
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[28],_testData[30], false);
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[29],_testData[31], false);
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[30],_testData[32], false);
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[31],_testData[33], false);
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonMArraypolygonMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonMArraypolygonMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 130);
                var models =  ((INpgsqlPolygonMArraypolygonMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(6));

                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[0],_testData[29], false);
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[1],_testData[30], false);
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[2],_testData[31], false);
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[3],_testData[32], false);
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[4],_testData[33], false);
                NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(models[5],_testData[34], false);
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
FROM public.binary_npgsqlpolygonpolygonmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonMArrayD11MIWA),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMArrayD11MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonMArraypolygonMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMArrayD11MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonMArraypolygonMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonMArraypolygonMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD11MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonMArrayD11MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMArrayD11MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonMArraypolygonMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMArrayD11MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonMArraypolygonMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonMArraypolygonMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD11MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmarrayd11mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonMArrayD11MI),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMArrayD11MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonMArraypolygonMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD11MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMArrayD11MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonMArraypolygonMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonMArraypolygonMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD11MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonmarrayd11mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmarrayd11mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonMArrayD11MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMArrayD11MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonMArraypolygonMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD11MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMArrayD11MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMArrayD11MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonMArraypolygonMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonMArraypolygonMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD11MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygonmarrayd11mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPolygonpolygonMArrayD1E1M),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1))]
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
FROM public.binary_npgsqlpolygonpolygonmarrayd1e1m m
LEFT JOIN public.binary_npgsqlpolygonpolygonmarrayd11mi mi ON mi.id = m.npgsqlpolygonpolygonmarrayd11mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonMArraypolygonMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonMArraypolygonMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonMArraypolygonMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygonmarrayd11mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models =  ((INpgsqlPolygonMArraypolygonMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMArrayD11MIWA), typeof(NpgsqlPolygonpolygonMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models1 = new List<NpgsqlPolygonpolygonMArrayD11MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMArrayD11MIWA>();
                await ((INpgsqlPolygonMArraypolygonMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonMArrayD11MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMArrayD11MIWA>();
                ((INpgsqlPolygonMArraypolygonMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygonmarrayd11mi
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
                    NpgsqlPolygonpolygonMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonMArraypolygonMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygonmarrayd11mi
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
                    NpgsqlPolygonpolygonMArrayD11MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMArrayD11MIWA), typeof(NpgsqlPolygonpolygonMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1))]
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
                var models1 = new List<NpgsqlPolygonpolygonMArrayD11MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMArrayD11MIWA>();
                await ((INpgsqlPolygonMArraypolygonMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonMArrayD11MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMArrayD11MIWA>();
                ((INpgsqlPolygonMArraypolygonMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonmarrayd11mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1))]
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
                var models = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygonmarrayd11mi
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
                    NpgsqlPolygonpolygonMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonMArraypolygonMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygonmarrayd11mi
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
                    NpgsqlPolygonpolygonMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygonmarrayd11mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMArrayD11MI), typeof(NpgsqlPolygonpolygonMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models1 = new List<NpgsqlPolygonpolygonMArrayD11MI>();
                var models2 = new List<NpgsqlPolygonpolygonMArrayD11MI>();
                await ((INpgsqlPolygonMArraypolygonMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD11MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD11MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonMArrayD11MI>();
                var models2 = new List<NpgsqlPolygonpolygonMArrayD11MI>();
                ((INpgsqlPolygonMArraypolygonMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD11MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD11MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmarrayd11mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMArrayD11MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD11MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonMArraypolygonMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD11MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygonmarrayd11mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMArrayD11MIWA), typeof(NpgsqlPolygonpolygonMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1))]
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
                var models1 = new List<NpgsqlPolygonpolygonMArrayD11MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMArrayD11MIWA>();
                await ((INpgsqlPolygonMArraypolygonMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD11MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonMArrayD11MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMArrayD11MIWA>();
                ((INpgsqlPolygonMArraypolygonMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD11MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD11MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmarrayd11mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMArrayD11MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMArrayD1))]
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
                var models = await ((INpgsqlPolygonMArraypolygonMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD11MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonMArraypolygonMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonMArrayD11MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

