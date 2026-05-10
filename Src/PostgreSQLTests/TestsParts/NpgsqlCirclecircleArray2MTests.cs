

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
    internal partial interface INpgsqlCircleListcircleArray
    {
    }
    
    internal partial class NpgsqlCircleListcircleArray : INpgsqlCircleListcircleArray
    {


#region TestData

        private readonly NpgsqlCirclecircleArray2M[] _testData = new NpgsqlCirclecircleArray2M[]
        {
            new NpgsqlCirclecircleArray2M
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30664062089113353d, y: 0.989018210882541d), radius: 0.17608924439531715d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9496241572845805d, y: 0.8758061752449614d), radius: 0.2659041745272406d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30286165994191716d, y: 0.5693584961841929d), radius: 0.46132095092644665d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5361283047734384d, y: 0.2313253524188128d), radius: 0.7656359767720752d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2583169518473908d, y: 0.9885974488868445d), radius: 0.6269642045382642d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.248521925635662d, y: 0.889178762685695d), radius: 0.26952577714542625d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7852089097169617d, y: 0.7433579761844811d), radius: 0.8540531459735975d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4577371061722417d, y: 0.47035414653232044d), radius: 0.38976023520462444d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4066788754965137d, y: 0.9622316815627654d), radius: 0.7537356929433346d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6173999296810364d, y: 0.5498824813091595d), radius: 0.008072508427788283d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13782181023416995d, y: 0.7993122499060241d), radius: 0.11464443540505176d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8556206689698516d, y: 0.3384808839014317d), radius: 0.5031959271238458d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7359225687881701d, y: 0.8157472771076251d), radius: 0.5161938628580253d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9792337847070887d, y: 0.7331936152145632d), radius: 0.04255768414407468d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31961667046943276d, y: 0.7433716990510729d), radius: 0.16242966623546418d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03397222773312636d, y: 0.8828007941142895d), radius: 0.7048907143186806d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7116257524479223d, y: 0.4858829372977401d), radius: 0.19269311822363977d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5735077959215746d, y: 0.9223187811892547d), radius: 0.9109273405819995d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9082512340008096d, y: 0.21352282603061024d), radius: 0.5674092416970169d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46205811624825843d, y: 0.8020997523712291d), radius: 0.7586265438033979d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7209247901886623d, y: 0.638049844411583d), radius: 0.8795678873992079d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1601175319728544d, y: 0.13706112059042475d), radius: 0.5881006592544473d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14570411317801146d, y: 0.5470733977117982d), radius: 0.19805945603653274d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9069695801487409d, y: 0.939566186193226d), radius: 0.896519565064871d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9325102553906459d, y: 0.49342006042466113d), radius: 0.011559518340584773d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9713440586877089d, y: 0.9101958313383381d), radius: 0.6287129997244141d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42926978917724523d, y: 0.8911679217388215d), radius: 0.41376794226184666d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7057875995388603d, y: 0.9273918938179857d), radius: 0.7391473562915623d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6967328452983925d, y: 0.034494694073930465d), radius: 0.699219592987703d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34302593498952205d, y: 0.04453388583983431d), radius: 0.2162995120044372d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5164425075241752d, y: 0.5806423599318762d), radius: 0.19508730807742602d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.031350613121326476d, y: 0.32741587757524315d), radius: 0.7975446993820715d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8079925132930458d, y: 0.19590431590864654d), radius: 0.9958703306413551d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12314421060574499d, y: 0.6276875308058053d), radius: 0.35234088403125474d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3722129630507529d, y: 0.01621574234985179d), radius: 0.22307619700142067d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8969699005556523d, y: 0.9000434137559306d), radius: 0.7893547720612909d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9350868097515525d, y: 0.8649400426899249d), radius: 0.0650767085306122d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.520807240301774d, y: 0.25632697076473654d), radius: 0.20151155982701008d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5105327434770556d, y: 0.007315122939631213d), radius: 0.0970359538090293d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.750050982997578d, y: 0.8398465487348721d), radius: 0.11551207171003475d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05995589045026661d, y: 0.7975389705339146d), radius: 0.05955947985095211d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3989296508064739d, y: 0.3344587464490739d), radius: 0.5154128243877565d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6381025650593108d, y: 0.25788875802435285d), radius: 0.11121333242123177d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.736873941703612d, y: 0.9141026989026716d), radius: 0.9560752554871336d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6388536108672711d, y: 0.16824988892108372d), radius: 0.1266432895213776d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5334442505418369d, y: 0.5295466446153159d), radius: 0.05710652268508154d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5079544028121183d, y: 0.9761209621799878d), radius: 0.3074915063896957d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07589609403835651d, y: 0.5381935992853635d), radius: 0.3266301193506146d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11175487214471902d, y: 0.9905387970437867d), radius: 0.5113494198639723d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18743108630306637d, y: 0.5967357475881654d), radius: 0.8996102983921825d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8183341796446718d, y: 0.7326665818484478d), radius: 0.44538876036293085d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08915488768702173d, y: 0.6553542421314413d), radius: 0.739737249115877d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5467770468568539d, y: 0.7538081261696664d), radius: 0.6587935342952759d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29349639450300324d, y: 0.10424123567697685d), radius: 0.486141608980202d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.872246911414419d, y: 0.7829424447022011d), radius: 0.9567501127434931d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4726415536226882d, y: 0.7332027330028675d), radius: 0.8301381647912018d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9321696385502085d, y: 0.6747121980426957d), radius: 0.8385764302094919d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5577416673569001d, y: 0.22557414139012377d), radius: 0.9978836126584796d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9257078637482757d, y: 0.34177298668418266d), radius: 0.4656219009958654d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6281534079541581d, y: 0.009437247470677756d), radius: 0.884646069513403d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8251054371605884d, y: 0.11628585634264232d), radius: 0.6456999673624388d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6505283055373943d, y: 0.9229751163340774d), radius: 0.3341926451882016d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9019363113839184d, y: 0.00847875783212515d), radius: 0.26463903605050587d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4379468288435461d, y: 0.264882805153256d), radius: 0.8124686676354794d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06253258567706954d, y: 0.39305212302222026d), radius: 0.6413477842087912d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6990169800530843d, y: 0.2672898338061137d), radius: 0.05629067080292227d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10839140959682558d, y: 0.7504437252315914d), radius: 0.2516802145571735d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5299071829547616d, y: 0.5959460786455403d), radius: 0.9745851550007298d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10952574558396921d, y: 0.158197681924931d), radius: 0.4808621837953885d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3762143362513194d, y: 0.48565201880812614d), radius: 0.46009975306497053d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6496191695645127d, y: 0.19198564044152278d), radius: 0.21587298455463366d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9547235974402306d, y: 0.12639378977132676d), radius: 0.9748705903896363d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02187895285727759d, y: 0.4394974094699178d), radius: 0.5766050076609344d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02892379252143018d, y: 0.10426131058694599d), radius: 0.046721522410272165d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.978648662037057d, y: 0.4431675685883585d), radius: 0.6227334042009024d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25484505387014567d, y: 0.7044835974528694d), radius: 0.8260042044161149d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8525152663795657d, y: 0.27434859835305214d), radius: 0.7533274400053294d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.554118085443148d, y: 0.7405299321355275d), radius: 0.9470964768492134d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8639801482131816d, y: 0.24272833255847448d), radius: 0.44192848924046446d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1003332420385481d, y: 0.06415556058921656d), radius: 0.005893878318709578d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6743171976934339d, y: 0.6880952952388412d), radius: 0.31520026037583126d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8303632177000053d, y: 0.7409952088283233d), radius: 0.6059729220650469d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23682499718250516d, y: 0.8803665205558827d), radius: 0.23733881377214894d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13967323602089776d, y: 0.5152401094289981d), radius: 0.6531623580545962d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22163387282386993d, y: 0.25442854783476243d), radius: 0.8168882154612594d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3733916216607228d, y: 0.24131583424870695d), radius: 0.1897224301227175d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2864077301987893d, y: 0.22159080090463767d), radius: 0.48757700046143315d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2844569938404853d, y: 0.1446181630915665d), radius: 0.5581190261525056d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1489041844906055d, y: 0.42272115159070844d), radius: 0.3860545366796019d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11579395597474784d, y: 0.9601335734493452d), radius: 0.9640676993351848d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22303264845740634d, y: 0.4442096836285778d), radius: 0.10312051135309819d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7170653870967665d, y: 0.3531529752035891d), radius: 0.4939954473049266d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31358584420563707d, y: 0.6522224496010693d), radius: 0.837856548580298d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7558941251263008d, y: 0.7837242716585339d), radius: 0.8001642622451818d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0632286037079931d, y: 0.2124861613191349d), radius: 0.7788579006779979d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20772097491888086d, y: 0.8437181717236042d), radius: 0.6800930755469159d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3419515773334495d, y: 0.5784542317503587d), radius: 0.09234212807827613d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39557564142180357d, y: 0.9674246394727554d), radius: 0.029515457396569356d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.771145418523547d, y: 0.7681358164178724d), radius: 0.6296952935925566d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03990984481424098d, y: 0.24395166750877362d), radius: 0.608563586541391d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3756751814850252d, y: 0.03057305180364489d), radius: 0.6522995459531724d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4111135512321855d, y: 0.6959412952446461d), radius: 0.17655357708548358d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3486405625193729d, y: 0.776020593315861d), radius: 0.8067744299151149d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17498791965016225d, y: 0.5673584261782127d), radius: 0.9854210005596479d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05908698519613853d, y: 0.3088855873748858d), radius: 0.6691918763466339d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.931350634823606d, y: 0.10022128664447771d), radius: 0.3800978094768487d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9258229486971824d, y: 0.2555904845485748d), radius: 0.45986790400275934d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6159589485635749d, y: 0.8554989891766489d), radius: 0.09115561369919023d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.958862002873479d, y: 0.050429747877272835d), radius: 0.5003619020167644d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6893458710377508d, y: 0.5762299254857646d), radius: 0.15624583671560122d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3037580971187429d, y: 0.5942027984558176d), radius: 0.2317883746557774d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13765631675605217d, y: 0.18302015135007732d), radius: 0.9527725106700795d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3857904046313506d, y: 0.9144405063785014d), radius: 0.12214642425545319d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48730187637819933d, y: 0.5765497027088152d), radius: 0.06347905526989606d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6165776450036811d, y: 0.3814637657059591d), radius: 0.16611765122979816d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6780728198502736d, y: 0.2793452819117841d), radius: 0.6985077680875588d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8033979414037984d, y: 0.2565229567910233d), radius: 0.020781285043817488d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6698718254991538d, y: 0.7066762575894253d), radius: 0.15323842075387561d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5072608401916627d, y: 0.16556192273535686d), radius: 0.12031477265196622d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14711016553245593d, y: 0.15055222017320657d), radius: 0.3932970628221818d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.013589403750248086d, y: 0.055150589235820835d), radius: 0.7347318520220303d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.396607766973756d, y: 0.9341160576208417d), radius: 0.4513584365808019d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07248867666796488d, y: 0.23062476136850962d), radius: 0.20265400831018532d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8177377521832634d, y: 0.7308145583698596d), radius: 0.32315894433022285d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5671343549969893d, y: 0.28452570892752793d), radius: 0.07519933657794686d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3754547189172397d, y: 0.28710369730373464d), radius: 0.4795373456667068d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8452300696432441d, y: 0.6925541176396282d), radius: 0.6659540638416663d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5411109029978313d, y: 0.8304751134383352d), radius: 0.37722828895641636d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4691172899119863d, y: 0.4912547381013359d), radius: 0.9292446969716268d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8694170068729274d, y: 0.22020118642621023d), radius: 0.43342750796426643d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9146684223246504d, y: 0.2121692810440161d), radius: 0.23432206287119584d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7144614794688392d, y: 0.7538143883171905d), radius: 0.6794964077395188d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4748997262990715d, y: 0.2450015516217765d), radius: 0.7521341706749298d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09531247019727485d, y: 0.9954968839417029d), radius: 0.8102518190137562d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7980120682745256d, y: 0.5304520271983759d), radius: 0.6382402471247206d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12351358243184118d, y: 0.8821504851071457d), radius: 0.8285578855465402d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7059299839177662d, y: 0.9414187987220303d), radius: 0.17997466950229857d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6218018526193856d, y: 0.8917351357759001d), radius: 0.18628400277067303d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4656087688564221d, y: 0.8740022616439773d), radius: 0.29334505243601294d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5936415633889682d, y: 0.6939856836585322d), radius: 0.7576720879933665d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8862230274415233d, y: 0.4408495772631834d), radius: 0.10005962557327275d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2143721575137444d, y: 0.36980902631820023d), radius: 0.8271363546730778d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1524241989625873d, y: 0.5884462625365039d), radius: 0.0914982553420074d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9512446758884119d, y: 0.09501552141404845d), radius: 0.22726002351367625d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49460239544345463d, y: 0.38079578716156914d), radius: 0.2992506146082322d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20166129616431283d, y: 0.61603040863934d), radius: 0.4605134370353001d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05169971709536514d, y: 0.032357883220089034d), radius: 0.4767581277993336d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3463196389874226d, y: 0.24724818643493673d), radius: 0.7993892315670861d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9342652039480713d, y: 0.020423272944710358d), radius: 0.9461515632711406d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5457293246139312d, y: 0.33902850922433037d), radius: 0.402170661217532d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.022151001030166317d, y: 0.9709781368979103d), radius: 0.8944143458082027d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28547835055774573d, y: 0.9089533444386063d), radius: 0.6225600522611778d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2817546768889697d, y: 0.8460344887295241d), radius: 0.5443420988585709d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.276064986167157d, y: 0.691417412843478d), radius: 0.1536046366702718d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31875695210776556d, y: 0.48772298810796d), radius: 0.08158362289025345d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3155841194334944d, y: 0.41033594089179415d), radius: 0.04355867651858247d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9411763282409795d, y: 0.07244408112747103d), radius: 0.616242571432046d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6755023672966715d, y: 0.052605648511797054d), radius: 0.4286765586996749d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3678399738677861d, y: 0.9681906166341375d), radius: 0.7656633276482712d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33862997484771096d, y: 0.07047066910870137d), radius: 0.7837174704809147d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5580177699612826d, y: 0.9520813066092036d), radius: 0.14516554175918006d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9720933159920936d, y: 0.4359814265981564d), radius: 0.6841543684000795d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8437735164672898d, y: 0.5487601961369238d), radius: 0.10526548678615688d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5824126921846327d, y: 0.9943189150716798d), radius: 0.1562668018384218d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3236002856544137d, y: 0.00033836131610986975d), radius: 0.0813362346404004d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1369067235435606d, y: 0.8540450144360846d), radius: 0.025662750536045165d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6125954433993624d, y: 0.4577216698651777d), radius: 0.20165837755485083d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9920785242751934d, y: 0.4331269164224836d), radius: 0.8026979804461392d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8961021203800973d, y: 0.2080476986314027d), radius: 0.2334679848164931d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7164348262579944d, y: 0.04286820089099441d), radius: 0.9081715293334293d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7393091077736342d, y: 0.6690540560575365d), radius: 0.1256302324059546d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7813557974681662d, y: 0.18223918570780884d), radius: 0.5182425310933643d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3015858391555345d, y: 0.3636065826067001d), radius: 0.020534811166971534d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6214176949488215d, y: 0.911337381971339d), radius: 0.2532196739033622d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6844515945943914d, y: 0.12279223354988467d), radius: 0.1744009407093604d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8303528543783665d, y: 0.5988940593762512d), radius: 0.5918974374860714d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9944207563260309d, y: 0.04176002271800816d), radius: 0.050911263692967834d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9934760922700862d, y: 0.4337253218812851d), radius: 0.7599172753543144d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.655036643620439d, y: 0.5907111708322941d), radius: 0.7047693305275664d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 144,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8223044153653603d, y: 0.6097588829124182d), radius: 0.16653685300778343d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6072281451513153d, y: 0.0981651442508954d), radius: 0.7824440819827889d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7414509340957884d, y: 0.6652629436592195d), radius: 0.22135662406249557d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16903560682778052d, y: 0.2954089500069237d), radius: 0.3865563180489876d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39066037643173657d, y: 0.581598773093986d), radius: 0.042205371243430045d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6713212186029197d, y: 0.03510839476921257d), radius: 0.37719754118751114d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5778481125962662d, y: 0.4051064601114145d), radius: 0.8507403482838855d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1804349822368706d, y: 0.6399347111883228d), radius: 0.8504497998991463d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5656495366756032d, y: 0.06557934294190526d), radius: 0.9277267179890974d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2244605657225447d, y: 0.47991898733112637d), radius: 0.09104422976805038d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7420003811459758d, y: 0.6841061804997266d), radius: 0.29662413879448657d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24831509453217226d, y: 0.5314248899324001d), radius: 0.6403984912497644d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11882581182572005d, y: 0.15981123494195437d), radius: 0.05313837326026394d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9011876035287892d, y: 0.16436115072378554d), radius: 0.25508146009113775d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3185350941311901d, y: 0.7998008828304075d), radius: 0.82097710164077d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9099325420348107d, y: 0.6089692153893215d), radius: 0.3340391781744916d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6835887365207683d, y: 0.15883809787298642d), radius: 0.053922440941388206d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 156,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2105006381442287d, y: 0.8029182829821871d), radius: 0.6619441146141833d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9303591857407815d, y: 0.6491771332366433d), radius: 0.297804341521431d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08595501359667701d, y: 0.050406657018779444d), radius: 0.9610210203376667d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24783532485940507d, y: 0.7243911616453453d), radius: 0.6448842769809354d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4824663135087025d, y: 0.6748183950706766d), radius: 0.4168684064896224d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8604250982008619d, y: 0.45183769482366365d), radius: 0.991426681629959d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5715291702110737d, y: 0.6151636377144173d), radius: 0.753454587650529d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 164,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25985961316097794d, y: 0.6923876777834667d), radius: 0.5372053664097924d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6550840452674476d, y: 0.8285808004147511d), radius: 0.279143340461358d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8463216553577219d, y: 0.7053471297430595d), radius: 0.8772224294176966d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41673293778520304d, y: 0.5076080887263643d), radius: 0.6979279817632138d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.746092743982848d, y: 0.91218535362278d), radius: 0.7171163028734717d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5575065282067091d, y: 0.6041357771472641d), radius: 0.6352239285079356d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5473955152609387d, y: 0.8499966062547143d), radius: 0.2365886025117384d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.826569348336521d, y: 0.5139754380791052d), radius: 0.8675797781424281d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 166,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33956017204968036d, y: 0.9324242933700605d), radius: 0.23414798673200832d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9259398724230041d, y: 0.7692030161744504d), radius: 0.8957502680884765d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4755434759360814d, y: 0.08924548636147589d), radius: 0.8143794564526474d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5074456787667062d, y: 0.8066264139954138d), radius: 0.3838502052099503d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 171,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6342305079838274d, y: 0.35690321029450034d), radius: 0.024290755247890927d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8018972421625192d, y: 0.17390680355331878d), radius: 0.9387096594014703d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5326232653454573d, y: 0.47631409859996166d), radius: 0.8189231091758689d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6700303835357476d, y: 0.6690078131328958d), radius: 0.5381319571027638d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.945505921013546d, y: 0.6312115599661079d), radius: 0.675857930122931d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9751736231763766d, y: 0.2616381420221311d), radius: 0.6728068167586381d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1694753979431063d, y: 0.22524069312089767d), radius: 0.41906533190353856d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 178,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19478702552170224d, y: 0.33760204988835607d), radius: 0.17252044711915304d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.170453577282768d, y: 0.6948826705426517d), radius: 0.8586055824683099d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07982001380268589d, y: 0.4938676681749049d), radius: 0.1415353485089763d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37541567342307514d, y: 0.7305275088440469d), radius: 0.1962710193423124d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 181,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17428325828333058d, y: 0.5466091745771365d), radius: 0.8775267178077749d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8005732702511323d, y: 0.23651229944547525d), radius: 0.8567118392113646d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6084743603454394d, y: 0.20959132682607806d), radius: 0.8535901362316403d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9097912502087934d, y: 0.0237612994623011d), radius: 0.029103540002840655d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.029418129633783763d, y: 0.3368632173956081d), radius: 0.4780397747155918d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7495822069926082d, y: 0.6718415272864952d), radius: 0.2576222800785981d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39857451204253014d, y: 0.8515704831601613d), radius: 0.17912965242661838d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6184015993257644d, y: 0.3294249738875631d), radius: 0.3032773534263904d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26404900902834816d, y: 0.20193258910538292d), radius: 0.4684095545793566d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7971094060622026d, y: 0.36857708432495906d), radius: 0.12565867427397726d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6476922590164156d, y: 0.28314307436677966d), radius: 0.38119596001775147d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 186,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7415367368375322d, y: 0.9853285475894455d), radius: 0.3879184606443844d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5983614088995411d, y: 0.21974012716391245d), radius: 0.5758991821278515d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44769553359947056d, y: 0.43668340985236687d), radius: 0.5235586155982075d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 187,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19784800920225631d, y: 0.7728569037230073d), radius: 0.8361690869509697d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6781585211385678d, y: 0.4979430243263987d), radius: 0.5999637837790579d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3056356247985147d, y: 0.17259527427707855d), radius: 0.7298114567326879d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2034972565088473d, y: 0.13391908022701005d), radius: 0.7296199421703699d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3688223143109015d, y: 0.4997602359045662d), radius: 0.8107659928025228d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20056537014806164d, y: 0.6567117542765158d), radius: 0.22574802873832533d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6599022320650649d, y: 0.612720547562009d), radius: 0.7864572785621161d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24436739453857226d, y: 0.7160393962879705d), radius: 0.4186409383245703d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4420044888163338d, y: 0.34851972853241175d), radius: 0.5056812843188091d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1658094739539916d, y: 0.07514654254725017d), radius: 0.6856670461874255d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 194,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6820384425211323d, y: 0.207853674694498d), radius: 0.7987872111769841d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9769356719056398d, y: 0.12259487472084862d), radius: 0.5805727544971814d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7238175872964497d, y: 0.6345300004291543d), radius: 0.08673705585449432d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28626121921361825d, y: 0.046402574472172d), radius: 0.8080871007637414d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5710501421238673d, y: 0.9688115717619693d), radius: 0.017762258948421317d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40458661081766134d, y: 0.4745404139759293d), radius: 0.9956659313987595d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7148997180440417d, y: 0.0765701460460575d), radius: 0.8058556641985466d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3362164013513421d, y: 0.3930802322522444d), radius: 0.6827495471405685d),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray2mi(
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray2mi(
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
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
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

                changedRows =  ((INpgsqlCircleListcircleArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleListcircleArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray2m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray2mi_id
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclearray2mi_id", 
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
                changedRows =  ((INpgsqlCircleListcircleArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlCircleListcircleArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlCircleListcircleArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlCircleListcircleArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray2m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray2mi_id
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
    npgsqlcirclecirclearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray2m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray2mi_id
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
    npgsqlcirclecirclearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclearray2mi_id", 
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
                List<NpgsqlCirclecircleArray2M> models = null;

                models =  ((INpgsqlCircleListcircleArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlCircleListcircleArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlCircleListcircleArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlCircleListcircleArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleArray2M> models = null;

                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlCircleListcircleArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M), typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                ((INpgsqlCircleListcircleArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlCircleListcircleArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlCircleListcircleArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
                var models = await ((INpgsqlCircleListcircleArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlCircleListcircleArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M), typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                ((INpgsqlCircleListcircleArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleListcircleArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleListcircleArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
                var models = await ((INpgsqlCircleListcircleArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlCircleListcircleArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M), typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 61;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 144;
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 129;
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 45;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 12;
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[31],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 31;
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 14;
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 156;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
                var models = await((INpgsqlCircleListcircleArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 166;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[7], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[8], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[9], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[10], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[11], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[12], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[13], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[14], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[27],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[34], false);
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
                var models = ((INpgsqlCircleListcircleArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 171;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 45;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[10], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[11], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[12], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[13], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[14], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M), typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 12, query1, 103, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 181, query1, 54, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[23],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray2M>();
                ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 82, query1, 171, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 54, query1, 3, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[33],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 103, query1, 166, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                await ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 45, query1, 26, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 156, query1, 31, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
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
FROM public.npgsqlcirclecirclearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray2M>();
                 ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelBatch(connection, 166, query1, 135, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray2m m
LEFT JOIN public.npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
                var models = await((INpgsqlCircleListcircleArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelBatchAsync(connection, 82, 144))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[34], false);
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
                var models = ((INpgsqlCircleListcircleArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelBatch(connection, 82, 103))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[34], false);
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
                await using var cmd = await ((INpgsqlCircleListcircleArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlCircleListcircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 156);
                var models = await ((INpgsqlCircleListcircleArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[27], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[28], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[29], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[30], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[31], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[32], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[33], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleListcircleArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleListcircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 70);
                var models =  ((INpgsqlCircleListcircleArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(22));

                NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[13], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[14], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[15], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[16], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[17], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[18], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[19], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[20], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[21], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[22], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[23], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[24], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[25], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[26], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[27], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[28], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[29], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[30], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[31], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[32], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[33], false);
                NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[34], false);
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
FROM public.binary_npgsqlcirclecirclearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray2MIWA),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleListcircleArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleListcircleArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleListcircleArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleListcircleArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleListcircleArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleListcircleArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleListcircleArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleListcircleArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray2MI),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleListcircleArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleListcircleArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleListcircleArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleListcircleArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleListcircleArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleListcircleArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleListcircleArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleListcircleArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlcirclecirclearray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlCirclecircleArray2M),
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
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
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
FROM public.binary_npgsqlcirclecirclearray2m m
LEFT JOIN public.binary_npgsqlcirclecirclearray2mi mi ON mi.id = m.npgsqlcirclecirclearray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleListcircleArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlCircleListcircleArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleListcircleArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleListcircleArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlcirclecirclearray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
                var models =  ((INpgsqlCircleListcircleArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleListcircleArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA), typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
                var models1 = new List<NpgsqlCirclecircleArray2MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray2MIWA>();
                await ((INpgsqlCircleListcircleArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray2MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray2MIWA>();
                ((INpgsqlCircleListcircleArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
                var models = await ((INpgsqlCircleListcircleArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
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
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleListcircleArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
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
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA), typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
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
                var models1 = new List<NpgsqlCirclecircleArray2MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray2MIWA>();
                await ((INpgsqlCircleListcircleArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray2MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray2MIWA>();
                ((INpgsqlCircleListcircleArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
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
                var models = await ((INpgsqlCircleListcircleArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
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
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleListcircleArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
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
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclearray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MI), typeof(NpgsqlCirclecircleArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
                var models1 = new List<NpgsqlCirclecircleArray2MI>();
                var models2 = new List<NpgsqlCirclecircleArray2MI>();
                await ((INpgsqlCircleListcircleArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray2MI>();
                var models2 = new List<NpgsqlCirclecircleArray2MI>();
                ((INpgsqlCircleListcircleArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray)),
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
                var models = await ((INpgsqlCircleListcircleArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleListcircleArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclearray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA), typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
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
                var models1 = new List<NpgsqlCirclecircleArray2MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray2MIWA>();
                await ((INpgsqlCircleListcircleArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray2MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray2MIWA>();
                ((INpgsqlCircleListcircleArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleArray))]
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
                var models = await ((INpgsqlCircleListcircleArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleListcircleArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

