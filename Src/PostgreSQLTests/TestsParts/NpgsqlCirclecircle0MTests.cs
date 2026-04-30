

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
    internal partial interface INpgsqlCircleSingleTypecircle
    {
    }
    
    internal partial class NpgsqlCircleSingleTypecircle : INpgsqlCircleSingleTypecircle
    {


#region TestData

        private readonly NpgsqlCirclecircle0M[] _testData = new NpgsqlCirclecircle0M[]
        {
            new NpgsqlCirclecircle0M
{
    Id = 6,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07697092162894692d, y: 0.3101547039332643d), radius: 0.6327128923928644d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 10,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6802300890335996d, y: 0.12070759966709865d), radius: 0.7550031036535414d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4643223205474005d, y: 0.6076394869992406d), radius: 0.7473477990041172d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9901986131252176d, y: 0.7177677125366059d), radius: 0.17630420870849706d),
},
            new NpgsqlCirclecircle0M
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5180270185390338d, y: 0.7158502516093128d), radius: 0.7081111778355096d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7885832677434828d, y: 0.4565184597716082d), radius: 0.19632074329840865d),
},
            new NpgsqlCirclecircle0M
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.188495526145098d, y: 0.23712456546955996d), radius: 0.1826051454897475d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 14,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6865853618397699d, y: 0.7656291292911964d), radius: 0.8026960831337145d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13588483384680605d, y: 0.5218674317796783d), radius: 0.9233747585954827d),
},
            new NpgsqlCirclecircle0M
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09669917680826623d, y: 0.44575612692787403d), radius: 0.8533156112912159d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22238061595833325d, y: 0.028196365883743524d), radius: 0.8034579687810965d),
},
            new NpgsqlCirclecircle0M
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7042739903771772d, y: 0.31687558305036356d), radius: 0.5232531335551837d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 23,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.174026604568711d, y: 0.3678497961872642d), radius: 0.5284717773784796d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12144162934940739d, y: 0.3534735030399747d), radius: 0.1988420652599785d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9467715693836091d, y: 0.09717515244162045d), radius: 0.12375728205081749d),
},
            new NpgsqlCirclecircle0M
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7238155144759517d, y: 0.10657422859411225d), radius: 0.7910791518224775d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7176660240270306d, y: 0.7500754455522132d), radius: 0.5412487618339633d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5475694567029884d, y: 0.4829513984910857d), radius: 0.8455069857367171d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7046017504274418d, y: 0.6467690302912367d), radius: 0.6920118303020438d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.806558928075919d, y: 0.5982498031930317d), radius: 0.30223382027029966d),
},
            new NpgsqlCirclecircle0M
{
    Id = 46,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9907578314571646d, y: 0.5147437790010618d), radius: 0.8017849958843055d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4692820548010319d, y: 0.7317561273386306d), radius: 0.001818896610282894d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.803266282930993d, y: 0.8646461258116812d), radius: 0.41106898901088007d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4781866476877853d, y: 0.2624135216675949d), radius: 0.048750086376801116d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 60,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8215443768126169d, y: 0.44968831637680595d), radius: 0.9740806570672972d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 62,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7614931237608122d, y: 0.35561143544149787d), radius: 0.9132729856917363d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 45,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39685328839566103d, y: 0.8353911611227143d), radius: 0.32061418245009365d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5339428353473834d, y: 0.6526634388820837d), radius: 0.21246236771340465d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08579170210011322d, y: 0.18587485681772753d), radius: 0.2563749488972069d),
},
            new NpgsqlCirclecircle0M
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22724253372099257d, y: 0.850386293860891d), radius: 0.7668002830887083d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2258850513466173d, y: 0.24327288888592102d), radius: 0.3765561177050193d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 46,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9009613930476825d, y: 0.42856611588239046d), radius: 0.020369898327448288d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7896893056697202d, y: 0.025024874153546706d), radius: 0.9386612634969644d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5531856486365925d, y: 0.5622958468467288d), radius: 0.8496085236780081d),
},
            new NpgsqlCirclecircle0M
{
    Id = 74,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30978042733300126d, y: 3.348954386517278E-05d), radius: 0.8931625183824198d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6711506742463565d, y: 0.9372763955145387d), radius: 0.9980661089994964d),
},
            new NpgsqlCirclecircle0M
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7612210607723292d, y: 0.17296040903669163d), radius: 0.32271754830935007d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 54,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7280236330495486d, y: 0.7024697851505461d), radius: 0.457509687477732d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.025336319503895144d, y: 0.27563779484596473d), radius: 0.79719680833661d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6859912205877641d, y: 0.04794831071676797d), radius: 0.142945764973628d),
},
            new NpgsqlCirclecircle0M
{
    Id = 83,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5982350977919321d, y: 0.06881473392039239d), radius: 0.40990507050880365d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43988603416451444d, y: 0.43876320957483406d), radius: 0.840105365399732d),
},
            new NpgsqlCirclecircle0M
{
    Id = 90,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9698910721069375d, y: 0.320246505368293d), radius: 0.45835787853047283d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37021523833225933d, y: 0.27700217303220265d), radius: 0.14715154870415836d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5789415876841397d, y: 0.8081982817767152d), radius: 0.803513592829625d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3517397685238831d, y: 0.6747027451294726d), radius: 0.3719783774641664d),
},
            new NpgsqlCirclecircle0M
{
    Id = 92,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12953137388992841d, y: 0.27235211160463446d), radius: 0.9182292618726555d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 99,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08881733358373411d, y: 0.7609065970621592d), radius: 0.6136990275550348d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4431428533477224d, y: 0.12612560833052222d), radius: 0.931915396251958d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8391638790045886d, y: 0.873784957541542d), radius: 0.8706359971546835d),
},
            new NpgsqlCirclecircle0M
{
    Id = 105,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25289228314651246d, y: 0.14981855567083768d), radius: 0.7778497830118646d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 114,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2933662024469391d, y: 0.7390619422945346d), radius: 0.5404107925836232d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5945959099677391d, y: 0.7713454481513491d), radius: 0.1089309087060738d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.179690604313262d, y: 0.8530967572282478d), radius: 0.352553960216313d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 123,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2897369480027776d, y: 0.1855629477546542d), radius: 0.8696006811981329d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 130,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04802438370412088d, y: 0.9879236735881503d), radius: 0.8299498391018942d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40957721971126837d, y: 0.860331341808918d), radius: 0.49248095113798107d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14545240573527085d, y: 0.4938833778322178d), radius: 0.6738661763643373d),
},
            new NpgsqlCirclecircle0M
{
    Id = 134,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7028420433883503d, y: 0.646806896923636d), radius: 0.7151079718851142d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5359398966762807d, y: 0.807798608184348d), radius: 0.945419149579203d),
},
            new NpgsqlCirclecircle0M
{
    Id = 142,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18729875915818917d, y: 0.6510231493313761d), radius: 0.6926783088461316d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 84,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2861892157325311d, y: 0.079308839020378d), radius: 0.9001973816870845d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5599036916410814d, y: 0.5261389100675335d), radius: 0.4836846266902859d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5292334444606536d, y: 0.9281273475009032d), radius: 0.7587137723511065d),
},
            new NpgsqlCirclecircle0M
{
    Id = 150,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7319112702996944d, y: 0.0441625910973491d), radius: 0.15141604459147873d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 152,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7928478402503845d, y: 0.7801433931925521d), radius: 0.08051575714504144d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 92,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10144781448892426d, y: 0.7948431327207104d), radius: 0.2503742973893588d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7763397192018018d, y: 0.8823220045488479d), radius: 0.4874716158278354d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 154,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4098070650010861d, y: 0.6460442891064143d), radius: 0.9759252415615627d),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 158,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6255352334818176d, y: 0.36187583090368003d), radius: 0.2278077035771744d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 98,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12015860735255979d, y: 0.023588384294333742d), radius: 0.8256583834664278d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7693113767022249d, y: 0.5103349102048784d), radius: 0.18192869848375526d),
},
    NullableValue = null,
},
            new NpgsqlCirclecircle0M
{
    Id = 167,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5863260482763035d, y: 0.5113703424864564d), radius: 0.018118500689013106d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6211703745263496d, y: 0.08083687511769921d), radius: 0.7963415063096048d),
},
            new NpgsqlCirclecircle0M
{
    Id = 170,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37611808456850104d, y: 0.8612176661887414d), radius: 0.25444616129328357d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 106,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8232918469100755d, y: 0.41906373585445544d), radius: 0.18002052340541774d),
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8120643692577163d, y: 0.7912420347045946d), radius: 0.1020130810198644d),
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32389724886995075d, y: 0.4808130936041808d), radius: 0.3641674907133111d),
},
            new NpgsqlCirclecircle0M
{
    Id = 172,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11075703725911101d, y: 0.6894842608370148d), radius: 0.241901572601963d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3932613479082201d, y: 0.40663350082435945d), radius: 0.5161542715154083d),
},
            new NpgsqlCirclecircle0M
{
    Id = 179,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31284917350296293d, y: 0.7538911739765398d), radius: 0.10322247267131501d),
    ModelInner = new NpgsqlCirclecircle0MI
{
    Id = 113,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9516482549214003d, y: 0.671166610801806d), radius: 0.4582629470527768d),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5309268445270698d, y: 0.8209431132558641d), radius: 0.2052049993114171d),
},
            new NpgsqlCirclecircle0M
{
    Id = 188,
    Value = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24161305803937572d, y: 0.6740724197384678d), radius: 0.6541201662416886d),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5954514090594026d, y: 0.6704647276577541d), radius: 0.6636338622660041d),
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0mi(
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0mi(
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
            queryMapTypes: [typeof(NpgsqlCirclecircle0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(5))]
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

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlCircleSingleTypecircle)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0mi(
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
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

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertInnerModelAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecircle0mi_id
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecircle0mi_id", 
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
                changedRows =  ((INpgsqlCircleSingleTypecircle)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlCircleSingleTypecircle)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlCircleSingleTypecircle)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlCircleSingleTypecircle)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecircle0mi_id
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
    npgsqlcirclecircle0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
                NpgsqlTypes.NpgsqlCircle? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
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

                    nullable =  ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22238061595833325d, y: 0.028196365883743524d), radius: 0.8034579687810965d)));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
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

                    nullable =  ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9467715693836091d, y: 0.09717515244162045d), radius: 0.12375728205081749d)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlCircle? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
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

                    nullable = await ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(5);
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

                    nullable = await ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.806558928075919d, y: 0.5982498031930317d), radius: 0.30223382027029966d)));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecircle0mi_id
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
    npgsqlcirclecircle0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(5)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecircle0mi_id", 
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
                NpgsqlTypes.NpgsqlCircle? nullable = null;
                nullable =  ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlCircle? nullable = null;
                nullable = await ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlCircleSingleTypecircle)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08579170210011322d, y: 0.18587485681772753d), radius: 0.2563749488972069d)));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircle0M> models = null;

                models =  ((INpgsqlCircleSingleTypecircle)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlCircleSingleTypecircle)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlCircleSingleTypecircle)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlCircleSingleTypecircle)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircle0M> models = null;

                models = await ((INpgsqlCircleSingleTypecircle)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlCircleSingleTypecircle)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlCircleSingleTypecircle)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlCircleSingleTypecircle)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircle0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecircle0m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecircle0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlcirclecircle0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlCircle), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlcirclecircle0mi_id", 
                methodParametrName: "npgsqlcirclecircle0mi_id", 
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

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionInsertModelAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M), typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                ((INpgsqlCircleSingleTypecircle)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
                var models = await ((INpgsqlCircleSingleTypecircle)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlCircleSingleTypecircle)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M), typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                ((INpgsqlCircleSingleTypecircle)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
                var models = await ((INpgsqlCircleSingleTypecircle)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlCircleSingleTypecircle)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M), typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                await((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 154;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 134;
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[22],_testData[34], false);
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
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
                parametr2.Value = 154;
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 77;
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[21],_testData[34], false);
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
                parametr1.Value = 105;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 158;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 19;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
                var models = await((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 142;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[29], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[30], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[31], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[32], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[33], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[29], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[30], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[31], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[32], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[33], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[34], false);
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
                var models = ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 29;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[6], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[7], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[8], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[9], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[10], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[11], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[12], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[13], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[14], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[15], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[16], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[17], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[14],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[15],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[16],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[17],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[18],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[19],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[20],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[21],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[22],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[23],_testData[29], false);
                        NpgsqlCirclecircle0M.AssertModel(models[24],_testData[30], false);
                        NpgsqlCirclecircle0M.AssertModel(models[25],_testData[31], false);
                        NpgsqlCirclecircle0M.AssertModel(models[26],_testData[32], false);
                        NpgsqlCirclecircle0M.AssertModel(models[27],_testData[33], false);
                        NpgsqlCirclecircle0M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[29], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[30], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[31], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[32], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[33], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M), typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                await((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 10, query1, 99, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 150, query1, 25, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[29],_testData[34], false);
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircle0M>();
                var models2 = new List<FlatNpgsqlCirclecircle0M>();
                ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 134, query1, 134, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionMMDynQuerySelectModelBatch(connection, 90, query1, 6, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[33],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 158, query1, 46, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[25],_testData[34], false);
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                await ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 154, query1, 19, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTDynQuerySelectModelBatch(connection, 170, query1, 172, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlCirclecircle0M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(models[1],_testData[34], false);
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
FROM public.npgsqlcirclecircle0m m
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
FROM public.npgsqlcirclecircle0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircle0M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircle0M>();
                 ((INpgsqlCircleSingleTypecircle)this).DbConnectionDynQuerySelectModelBatch(connection, 10, query1, 105, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlCirclecircle0M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle)),
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
                var models = await((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelBatchAsync(connection, 19, 83))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[3], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[4], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[5], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[6], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[7], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[8], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[9], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[10], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[11], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[12], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[13], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[14], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[15], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[16], false);
                        NpgsqlCirclecircle0M.AssertModel(models[14],_testData[17], false);
                        NpgsqlCirclecircle0M.AssertModel(models[15],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[16],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[17],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[18],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[19],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[20],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[21],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[22],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[23],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[24],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[25],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[26],_testData[29], false);
                        NpgsqlCirclecircle0M.AssertModel(models[27],_testData[30], false);
                        NpgsqlCirclecircle0M.AssertModel(models[28],_testData[31], false);
                        NpgsqlCirclecircle0M.AssertModel(models[29],_testData[32], false);
                        NpgsqlCirclecircle0M.AssertModel(models[30],_testData[33], false);
                        NpgsqlCirclecircle0M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[17], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[29], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[30], false);
                        NpgsqlCirclecircle0M.AssertModel(models[14],_testData[31], false);
                        NpgsqlCirclecircle0M.AssertModel(models[15],_testData[32], false);
                        NpgsqlCirclecircle0M.AssertModel(models[16],_testData[33], false);
                        NpgsqlCirclecircle0M.AssertModel(models[17],_testData[34], false);
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
                var models = ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircle0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSTSelectModelBatch(connection, 77, 134))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[16], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[17], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[18], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[19], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[20], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[21], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[22], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[23], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[24], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[10],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[11],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[12],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[13],_testData[29], false);
                        NpgsqlCirclecircle0M.AssertModel(models[14],_testData[30], false);
                        NpgsqlCirclecircle0M.AssertModel(models[15],_testData[31], false);
                        NpgsqlCirclecircle0M.AssertModel(models[16],_testData[32], false);
                        NpgsqlCirclecircle0M.AssertModel(models[17],_testData[33], false);
                        NpgsqlCirclecircle0M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlCirclecircle0M.AssertModel(models[0],_testData[25], false);
                        NpgsqlCirclecircle0M.AssertModel(models[1],_testData[26], false);
                        NpgsqlCirclecircle0M.AssertModel(models[2],_testData[27], false);
                        NpgsqlCirclecircle0M.AssertModel(models[3],_testData[28], false);
                        NpgsqlCirclecircle0M.AssertModel(models[4],_testData[29], false);
                        NpgsqlCirclecircle0M.AssertModel(models[5],_testData[30], false);
                        NpgsqlCirclecircle0M.AssertModel(models[6],_testData[31], false);
                        NpgsqlCirclecircle0M.AssertModel(models[7],_testData[32], false);
                        NpgsqlCirclecircle0M.AssertModel(models[8],_testData[33], false);
                        NpgsqlCirclecircle0M.AssertModel(models[9],_testData[34], false);
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
                await using var cmd = await ((INpgsqlCircleSingleTypecircle)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlCircleSingleTypecircle)this).SetDbConnectionSelectModelParametrs(cmd, 130);
                var models = await ((INpgsqlCircleSingleTypecircle)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(11));
NpgsqlCirclecircle0M.AssertModel(models[0],_testData[24], false);NpgsqlCirclecircle0M.AssertModel(models[1],_testData[25], false);NpgsqlCirclecircle0M.AssertModel(models[2],_testData[26], false);NpgsqlCirclecircle0M.AssertModel(models[3],_testData[27], false);NpgsqlCirclecircle0M.AssertModel(models[4],_testData[28], false);NpgsqlCirclecircle0M.AssertModel(models[5],_testData[29], false);NpgsqlCirclecircle0M.AssertModel(models[6],_testData[30], false);NpgsqlCirclecircle0M.AssertModel(models[7],_testData[31], false);NpgsqlCirclecircle0M.AssertModel(models[8],_testData[32], false);NpgsqlCirclecircle0M.AssertModel(models[9],_testData[33], false);NpgsqlCirclecircle0M.AssertModel(models[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleSingleTypecircle)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleSingleTypecircle)this).SetDbConnectionSelectModelParametrs(cmd, 142);
                var models =  ((INpgsqlCircleSingleTypecircle)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(9));
NpgsqlCirclecircle0M.AssertModel(models[0],_testData[26], false);NpgsqlCirclecircle0M.AssertModel(models[1],_testData[27], false);NpgsqlCirclecircle0M.AssertModel(models[2],_testData[28], false);NpgsqlCirclecircle0M.AssertModel(models[3],_testData[29], false);NpgsqlCirclecircle0M.AssertModel(models[4],_testData[30], false);NpgsqlCirclecircle0M.AssertModel(models[5],_testData[31], false);NpgsqlCirclecircle0M.AssertModel(models[6],_testData[32], false);NpgsqlCirclecircle0M.AssertModel(models[7],_testData[33], false);NpgsqlCirclecircle0M.AssertModel(models[8],_testData[34], false);
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
FROM public.npgsqlcirclecircle0m m
LEFT JOIN public.npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
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
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07697092162894692d, y: 0.3101547039332643d), radius: 0.6327128923928644d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6802300890335996d, y: 0.12070759966709865d), radius: 0.7550031036535414d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4643223205474005d, y: 0.6076394869992406d), radius: 0.7473477990041172d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9901986131252176d, y: 0.7177677125366059d), radius: 0.17630420870849706d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5180270185390338d, y: 0.7158502516093128d), radius: 0.7081111778355096d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7885832677434828d, y: 0.4565184597716082d), radius: 0.19632074329840865d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.188495526145098d, y: 0.23712456546955996d), radius: 0.1826051454897475d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6865853618397699d, y: 0.7656291292911964d), radius: 0.8026960831337145d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13588483384680605d, y: 0.5218674317796783d), radius: 0.9233747585954827d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09669917680826623d, y: 0.44575612692787403d), radius: 0.8533156112912159d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22238061595833325d, y: 0.028196365883743524d), radius: 0.8034579687810965d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7042739903771772d, y: 0.31687558305036356d), radius: 0.5232531335551837d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.174026604568711d, y: 0.3678497961872642d), radius: 0.5284717773784796d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12144162934940739d, y: 0.3534735030399747d), radius: 0.1988420652599785d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9467715693836091d, y: 0.09717515244162045d), radius: 0.12375728205081749d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7238155144759517d, y: 0.10657422859411225d), radius: 0.7910791518224775d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7176660240270306d, y: 0.7500754455522132d), radius: 0.5412487618339633d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5475694567029884d, y: 0.4829513984910857d), radius: 0.8455069857367171d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7046017504274418d, y: 0.6467690302912367d), radius: 0.6920118303020438d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.806558928075919d, y: 0.5982498031930317d), radius: 0.30223382027029966d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9907578314571646d, y: 0.5147437790010618d), radius: 0.8017849958843055d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4692820548010319d, y: 0.7317561273386306d), radius: 0.001818896610282894d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.803266282930993d, y: 0.8646461258116812d), radius: 0.41106898901088007d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4781866476877853d, y: 0.2624135216675949d), radius: 0.048750086376801116d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8215443768126169d, y: 0.44968831637680595d), radius: 0.9740806570672972d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7614931237608122d, y: 0.35561143544149787d), radius: 0.9132729856917363d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39685328839566103d, y: 0.8353911611227143d), radius: 0.32061418245009365d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5339428353473834d, y: 0.6526634388820837d), radius: 0.21246236771340465d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08579170210011322d, y: 0.18587485681772753d), radius: 0.2563749488972069d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22724253372099257d, y: 0.850386293860891d), radius: 0.7668002830887083d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2258850513466173d, y: 0.24327288888592102d), radius: 0.3765561177050193d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9009613930476825d, y: 0.42856611588239046d), radius: 0.020369898327448288d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7896893056697202d, y: 0.025024874153546706d), radius: 0.9386612634969644d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5531856486365925d, y: 0.5622958468467288d), radius: 0.8496085236780081d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30978042733300126d, y: 3.348954386517278E-05d), radius: 0.8931625183824198d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6711506742463565d, y: 0.9372763955145387d), radius: 0.9980661089994964d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7612210607723292d, y: 0.17296040903669163d), radius: 0.32271754830935007d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7280236330495486d, y: 0.7024697851505461d), radius: 0.457509687477732d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.025336319503895144d, y: 0.27563779484596473d), radius: 0.79719680833661d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6859912205877641d, y: 0.04794831071676797d), radius: 0.142945764973628d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5982350977919321d, y: 0.06881473392039239d), radius: 0.40990507050880365d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43988603416451444d, y: 0.43876320957483406d), radius: 0.840105365399732d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9698910721069375d, y: 0.320246505368293d), radius: 0.45835787853047283d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37021523833225933d, y: 0.27700217303220265d), radius: 0.14715154870415836d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5789415876841397d, y: 0.8081982817767152d), radius: 0.803513592829625d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3517397685238831d, y: 0.6747027451294726d), radius: 0.3719783774641664d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12953137388992841d, y: 0.27235211160463446d), radius: 0.9182292618726555d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08881733358373411d, y: 0.7609065970621592d), radius: 0.6136990275550348d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4431428533477224d, y: 0.12612560833052222d), radius: 0.931915396251958d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8391638790045886d, y: 0.873784957541542d), radius: 0.8706359971546835d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25289228314651246d, y: 0.14981855567083768d), radius: 0.7778497830118646d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2933662024469391d, y: 0.7390619422945346d), radius: 0.5404107925836232d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5945959099677391d, y: 0.7713454481513491d), radius: 0.1089309087060738d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.179690604313262d, y: 0.8530967572282478d), radius: 0.352553960216313d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2897369480027776d, y: 0.1855629477546542d), radius: 0.8696006811981329d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04802438370412088d, y: 0.9879236735881503d), radius: 0.8299498391018942d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40957721971126837d, y: 0.860331341808918d), radius: 0.49248095113798107d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14545240573527085d, y: 0.4938833778322178d), radius: 0.6738661763643373d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7028420433883503d, y: 0.646806896923636d), radius: 0.7151079718851142d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5359398966762807d, y: 0.807798608184348d), radius: 0.945419149579203d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18729875915818917d, y: 0.6510231493313761d), radius: 0.6926783088461316d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2861892157325311d, y: 0.079308839020378d), radius: 0.9001973816870845d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5599036916410814d, y: 0.5261389100675335d), radius: 0.4836846266902859d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5292334444606536d, y: 0.9281273475009032d), radius: 0.7587137723511065d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7319112702996944d, y: 0.0441625910973491d), radius: 0.15141604459147873d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7928478402503845d, y: 0.7801433931925521d), radius: 0.08051575714504144d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((92)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10144781448892426d, y: 0.7948431327207104d), radius: 0.2503742973893588d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7763397192018018d, y: 0.8823220045488479d), radius: 0.4874716158278354d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4098070650010861d, y: 0.6460442891064143d), radius: 0.9759252415615627d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6255352334818176d, y: 0.36187583090368003d), radius: 0.2278077035771744d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((98)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12015860735255979d, y: 0.023588384294333742d), radius: 0.8256583834664278d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7693113767022249d, y: 0.5103349102048784d), radius: 0.18192869848375526d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5863260482763035d, y: 0.5113703424864564d), radius: 0.018118500689013106d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6211703745263496d, y: 0.08083687511769921d), radius: 0.7963415063096048d))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37611808456850104d, y: 0.8612176661887414d), radius: 0.25444616129328357d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((106)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8232918469100755d, y: 0.41906373585445544d), radius: 0.18002052340541774d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8120643692577163d, y: 0.7912420347045946d), radius: 0.1020130810198644d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32389724886995075d, y: 0.4808130936041808d), radius: 0.3641674907133111d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11075703725911101d, y: 0.6894842608370148d), radius: 0.241901572601963d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3932613479082201d, y: 0.40663350082435945d), radius: 0.5161542715154083d))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31284917350296293d, y: 0.7538911739765398d), radius: 0.10322247267131501d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((113)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9516482549214003d, y: 0.671166610801806d), radius: 0.4582629470527768d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5309268445270698d, y: 0.8209431132558641d), radius: 0.2052049993114171d))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((188)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24161305803937572d, y: 0.6740724197384678d), radius: 0.6541201662416886d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5954514090594026d, y: 0.6704647276577541d), radius: 0.6636338622660041d))));

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlCircleSingleTypecircle)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(35));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((6)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07697092162894692d, y: 0.3101547039332643d), radius: 0.6327128923928644d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((10)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6802300890335996d, y: 0.12070759966709865d), radius: 0.7550031036535414d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4643223205474005d, y: 0.6076394869992406d), radius: 0.7473477990041172d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9901986131252176d, y: 0.7177677125366059d), radius: 0.17630420870849706d))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5180270185390338d, y: 0.7158502516093128d), radius: 0.7081111778355096d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7885832677434828d, y: 0.4565184597716082d), radius: 0.19632074329840865d))));

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.188495526145098d, y: 0.23712456546955996d), radius: 0.1826051454897475d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6865853618397699d, y: 0.7656291292911964d), radius: 0.8026960831337145d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13588483384680605d, y: 0.5218674317796783d), radius: 0.9233747585954827d))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((25)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09669917680826623d, y: 0.44575612692787403d), radius: 0.8533156112912159d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22238061595833325d, y: 0.028196365883743524d), radius: 0.8034579687810965d))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((29)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7042739903771772d, y: 0.31687558305036356d), radius: 0.5232531335551837d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.174026604568711d, y: 0.3678497961872642d), radius: 0.5284717773784796d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12144162934940739d, y: 0.3534735030399747d), radius: 0.1988420652599785d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9467715693836091d, y: 0.09717515244162045d), radius: 0.12375728205081749d))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((37)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7238155144759517d, y: 0.10657422859411225d), radius: 0.7910791518224775d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7176660240270306d, y: 0.7500754455522132d), radius: 0.5412487618339633d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((31)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5475694567029884d, y: 0.4829513984910857d), radius: 0.8455069857367171d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7046017504274418d, y: 0.6467690302912367d), radius: 0.6920118303020438d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.806558928075919d, y: 0.5982498031930317d), radius: 0.30223382027029966d))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9907578314571646d, y: 0.5147437790010618d), radius: 0.8017849958843055d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4692820548010319d, y: 0.7317561273386306d), radius: 0.001818896610282894d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.803266282930993d, y: 0.8646461258116812d), radius: 0.41106898901088007d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4781866476877853d, y: 0.2624135216675949d), radius: 0.048750086376801116d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((60)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8215443768126169d, y: 0.44968831637680595d), radius: 0.9740806570672972d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((62)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7614931237608122d, y: 0.35561143544149787d), radius: 0.9132729856917363d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39685328839566103d, y: 0.8353911611227143d), radius: 0.32061418245009365d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5339428353473834d, y: 0.6526634388820837d), radius: 0.21246236771340465d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08579170210011322d, y: 0.18587485681772753d), radius: 0.2563749488972069d))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22724253372099257d, y: 0.850386293860891d), radius: 0.7668002830887083d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((68)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2258850513466173d, y: 0.24327288888592102d), radius: 0.3765561177050193d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9009613930476825d, y: 0.42856611588239046d), radius: 0.020369898327448288d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7896893056697202d, y: 0.025024874153546706d), radius: 0.9386612634969644d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5531856486365925d, y: 0.5622958468467288d), radius: 0.8496085236780081d))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((74)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30978042733300126d, y: 3.348954386517278E-05d), radius: 0.8931625183824198d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6711506742463565d, y: 0.9372763955145387d), radius: 0.9980661089994964d))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7612210607723292d, y: 0.17296040903669163d), radius: 0.32271754830935007d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((54)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7280236330495486d, y: 0.7024697851505461d), radius: 0.457509687477732d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.025336319503895144d, y: 0.27563779484596473d), radius: 0.79719680833661d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6859912205877641d, y: 0.04794831071676797d), radius: 0.142945764973628d))));

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5982350977919321d, y: 0.06881473392039239d), radius: 0.40990507050880365d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43988603416451444d, y: 0.43876320957483406d), radius: 0.840105365399732d))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9698910721069375d, y: 0.320246505368293d), radius: 0.45835787853047283d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37021523833225933d, y: 0.27700217303220265d), radius: 0.14715154870415836d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5789415876841397d, y: 0.8081982817767152d), radius: 0.803513592829625d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3517397685238831d, y: 0.6747027451294726d), radius: 0.3719783774641664d))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((92)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12953137388992841d, y: 0.27235211160463446d), radius: 0.9182292618726555d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08881733358373411d, y: 0.7609065970621592d), radius: 0.6136990275550348d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4431428533477224d, y: 0.12612560833052222d), radius: 0.931915396251958d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8391638790045886d, y: 0.873784957541542d), radius: 0.8706359971546835d))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25289228314651246d, y: 0.14981855567083768d), radius: 0.7778497830118646d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2933662024469391d, y: 0.7390619422945346d), radius: 0.5404107925836232d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((77)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5945959099677391d, y: 0.7713454481513491d), radius: 0.1089309087060738d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.179690604313262d, y: 0.8530967572282478d), radius: 0.352553960216313d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2897369480027776d, y: 0.1855629477546542d), radius: 0.8696006811981329d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((130)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04802438370412088d, y: 0.9879236735881503d), radius: 0.8299498391018942d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((80)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40957721971126837d, y: 0.860331341808918d), radius: 0.49248095113798107d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14545240573527085d, y: 0.4938833778322178d), radius: 0.6738661763643373d))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((134)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7028420433883503d, y: 0.646806896923636d), radius: 0.7151079718851142d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5359398966762807d, y: 0.807798608184348d), radius: 0.945419149579203d))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((142)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18729875915818917d, y: 0.6510231493313761d), radius: 0.6926783088461316d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((84)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2861892157325311d, y: 0.079308839020378d), radius: 0.9001973816870845d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5599036916410814d, y: 0.5261389100675335d), radius: 0.4836846266902859d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5292334444606536d, y: 0.9281273475009032d), radius: 0.7587137723511065d))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((150)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7319112702996944d, y: 0.0441625910973491d), radius: 0.15141604459147873d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((152)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7928478402503845d, y: 0.7801433931925521d), radius: 0.08051575714504144d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((92)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10144781448892426d, y: 0.7948431327207104d), radius: 0.2503742973893588d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7763397192018018d, y: 0.8823220045488479d), radius: 0.4874716158278354d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4098070650010861d, y: 0.6460442891064143d), radius: 0.9759252415615627d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6255352334818176d, y: 0.36187583090368003d), radius: 0.2278077035771744d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((98)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12015860735255979d, y: 0.023588384294333742d), radius: 0.8256583834664278d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7693113767022249d, y: 0.5103349102048784d), radius: 0.18192869848375526d))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[30];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((167)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5863260482763035d, y: 0.5113703424864564d), radius: 0.018118500689013106d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6211703745263496d, y: 0.08083687511769921d), radius: 0.7963415063096048d))));

                model = models[31];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((170)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37611808456850104d, y: 0.8612176661887414d), radius: 0.25444616129328357d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((106)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8232918469100755d, y: 0.41906373585445544d), radius: 0.18002052340541774d))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8120643692577163d, y: 0.7912420347045946d), radius: 0.1020130810198644d))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32389724886995075d, y: 0.4808130936041808d), radius: 0.3641674907133111d))));

                model = models[32];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((172)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11075703725911101d, y: 0.6894842608370148d), radius: 0.241901572601963d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3932613479082201d, y: 0.40663350082435945d), radius: 0.5161542715154083d))));

                model = models[33];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((179)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31284917350296293d, y: 0.7538911739765398d), radius: 0.10322247267131501d))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((113)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9516482549214003d, y: 0.671166610801806d), radius: 0.4582629470527768d))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5309268445270698d, y: 0.8209431132558641d), radius: 0.2052049993114171d))));

                model = models[34];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((188)));//Id
                Assert.That((NpgsqlTypes.NpgsqlCircle)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24161305803937572d, y: 0.6740724197384678d), radius: 0.6541201662416886d))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlCircle?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5954514090594026d, y: 0.6704647276577541d), radius: 0.6636338622660041d))));

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
FROM public.binary_npgsqlcirclecircle0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircle0MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircle0MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircle0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleSingleTypecircle)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecircle0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleSingleTypecircle)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircle0MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircle0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleSingleTypecircle)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecircle0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleSingleTypecircle)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecircle0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircle0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircle0MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircle0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleSingleTypecircle)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecircle0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircle0MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircle0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleSingleTypecircle)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecircle0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleSingleTypecircle)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecircle0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecircle0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircle0MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircle0MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleSingleTypecircle)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleSingleTypecircle)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircle0MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircle0MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleSingleTypecircle)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleSingleTypecircle)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircle0MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecircle0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecircle0mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircle0MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircle0MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircle0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleSingleTypecircle)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleSingleTypecircle)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircle0MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircle0MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleSingleTypecircle)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleSingleTypecircle)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecircle0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlcirclecircle0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlCirclecircle0M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
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
FROM public.binary_npgsqlcirclecircle0m m
LEFT JOIN public.binary_npgsqlcirclecircle0mi mi ON mi.id = m.npgsqlcirclecircle0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircle0M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleSingleTypecircle)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlCircleSingleTypecircle)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircle0M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircle0M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleSingleTypecircle)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleSingleTypecircle)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircle0M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecircle0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlcirclecircle0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircle0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlCircleSingleTypecircle)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircle0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleSingleTypecircle)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircle0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MIWA), typeof(NpgsqlCirclecircle0MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
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
                var models1 = new List<NpgsqlCirclecircle0MIWA>();
                var models2 = new List<NpgsqlCirclecircle0MIWA>();
                await ((INpgsqlCircleSingleTypecircle)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecircle0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircle0MIWA>();
                var models2 = new List<NpgsqlCirclecircle0MIWA>();
                ((INpgsqlCircleSingleTypecircle)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecircle0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
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
                var models = await ((INpgsqlCircleSingleTypecircle)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecircle0mi
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
                    NpgsqlCirclecircle0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleSingleTypecircle)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecircle0mi
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
                    NpgsqlCirclecircle0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MIWA), typeof(NpgsqlCirclecircle0MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
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
                var models1 = new List<NpgsqlCirclecircle0MIWA>();
                var models2 = new List<NpgsqlCirclecircle0MIWA>();
                await ((INpgsqlCircleSingleTypecircle)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecircle0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircle0MIWA>();
                var models2 = new List<NpgsqlCirclecircle0MIWA>();
                ((INpgsqlCircleSingleTypecircle)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecircle0mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
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
                var models = await ((INpgsqlCircleSingleTypecircle)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecircle0mi
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
                    NpgsqlCirclecircle0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleSingleTypecircle)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecircle0mi
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
                    NpgsqlCirclecircle0MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecircle0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MI), typeof(NpgsqlCirclecircle0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
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
                var models1 = new List<NpgsqlCirclecircle0MI>();
                var models2 = new List<NpgsqlCirclecircle0MI>();
                await ((INpgsqlCircleSingleTypecircle)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircle0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircle0MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircle0MI>();
                var models2 = new List<NpgsqlCirclecircle0MI>();
                ((INpgsqlCircleSingleTypecircle)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircle0MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircle0MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecircle0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
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
                var models = await ((INpgsqlCircleSingleTypecircle)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircle0MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleSingleTypecircle)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircle0MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecircle0mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MIWA), typeof(NpgsqlCirclecircle0MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
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
                var models1 = new List<NpgsqlCirclecircle0MIWA>();
                var models2 = new List<NpgsqlCirclecircle0MIWA>();
                await ((INpgsqlCircleSingleTypecircle)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircle0MIWA>();
                var models2 = new List<NpgsqlCirclecircle0MIWA>();
                ((INpgsqlCircleSingleTypecircle)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecircle0mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircle0MIWA)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(5),
                (NpgsqlTypes.NpgsqlDbType)(5)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleSingleTypecircle))]
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
                var models = await ((INpgsqlCircleSingleTypecircle)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleSingleTypecircle)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircle0MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

