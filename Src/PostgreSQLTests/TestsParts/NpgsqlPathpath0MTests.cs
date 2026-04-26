

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
    internal partial interface INpgsqlPathSingleTypepath
    {
    }
    
    internal partial class NpgsqlPathSingleTypepath : INpgsqlPathSingleTypepath
    {


#region TestData

        private readonly NpgsqlPathpath0M[] _testData = new NpgsqlPathpath0M[]
        {
            new NpgsqlPathpath0M
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9344132428458164d, y: 0.40522834832847354d), new NpgsqlTypes.NpgsqlPoint(x: 0.9995696094048637d, y: 0.1415227694747454d), new NpgsqlTypes.NpgsqlPoint(x: 0.6782063503658687d, y: 0.4663119608143006d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5554549783916991d, y: 0.10479181001825033d), new NpgsqlTypes.NpgsqlPoint(x: 0.2467491183839331d, y: 0.5472671914350874d), new NpgsqlTypes.NpgsqlPoint(x: 0.25611846689920836d, y: 0.5244254741784456d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8892214630030745d, y: 0.5235182096078641d), new NpgsqlTypes.NpgsqlPoint(x: 0.14737497390792886d, y: 0.440983256110954d), new NpgsqlTypes.NpgsqlPoint(x: 0.7275950188580708d, y: 0.6066202822452224d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16219237483314364d, y: 0.8627055418238431d), new NpgsqlTypes.NpgsqlPoint(x: 0.21773870578083176d, y: 0.6399036247042652d), new NpgsqlTypes.NpgsqlPoint(x: 0.6155586457361163d, y: 0.8183694287586004d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27998952722981496d, y: 0.19075137023668098d), new NpgsqlTypes.NpgsqlPoint(x: 0.9253884435169634d, y: 0.44036752598326767d), new NpgsqlTypes.NpgsqlPoint(x: 0.7120887709035141d, y: 0.7420158259828084d)),
},
            new NpgsqlPathpath0M
{
    Id = 19,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33488550054072985d, y: 0.1600240494351759d), new NpgsqlTypes.NpgsqlPoint(x: 0.38742514599989475d, y: 0.1774105159131788d), new NpgsqlTypes.NpgsqlPoint(x: 0.6694756339163823d, y: 0.19807237845040904d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 24,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6732800738557224d, y: 0.5755731831383838d), new NpgsqlTypes.NpgsqlPoint(x: 0.3741118209580464d, y: 0.22973341842890027d), new NpgsqlTypes.NpgsqlPoint(x: 0.38571725957336767d, y: 0.7334747969275555d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 14,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.852491419968036d, y: 0.6235079368552496d), new NpgsqlTypes.NpgsqlPoint(x: 0.4881534729952559d, y: 0.31659987362610553d), new NpgsqlTypes.NpgsqlPoint(x: 0.2948235829454555d, y: 0.7980564598074066d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2902349542234214d, y: 0.6952383480773564d), new NpgsqlTypes.NpgsqlPoint(x: 0.10020084801181939d, y: 0.42935401232768666d), new NpgsqlTypes.NpgsqlPoint(x: 0.769843000386224d, y: 0.28031989733280116d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9755933185766131d, y: 0.729567447337437d), new NpgsqlTypes.NpgsqlPoint(x: 0.5763337547213196d, y: 0.7795148492238755d), new NpgsqlTypes.NpgsqlPoint(x: 0.7390404620983274d, y: 0.20022484163308718d)),
},
            new NpgsqlPathpath0M
{
    Id = 32,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8161729797937682d, y: 0.25756779088382475d), new NpgsqlTypes.NpgsqlPoint(x: 0.7099022618645796d, y: 0.013423176787772384d), new NpgsqlTypes.NpgsqlPoint(x: 0.9717374977374659d, y: 0.4226854351938598d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27008412857427166d, y: 0.11586715927737634d), new NpgsqlTypes.NpgsqlPoint(x: 0.20615294175649534d, y: 0.3190622927239317d), new NpgsqlTypes.NpgsqlPoint(x: 0.24269438253778852d, y: 0.47506835696254013d)),
},
            new NpgsqlPathpath0M
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.018323610195757567d, y: 0.4795796851526565d), new NpgsqlTypes.NpgsqlPoint(x: 0.3764133137369181d, y: 0.560962377580302d), new NpgsqlTypes.NpgsqlPoint(x: 0.19960775052855673d, y: 0.12611943257805636d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 23,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17811495902533736d, y: 0.8511288895277689d), new NpgsqlTypes.NpgsqlPoint(x: 0.2105839958224659d, y: 0.252216468303773d), new NpgsqlTypes.NpgsqlPoint(x: 0.19014431236843232d, y: 0.19203549120177543d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.350480065390809d, y: 0.39825545459268663d), new NpgsqlTypes.NpgsqlPoint(x: 0.3201040396048518d, y: 0.3271635167466006d), new NpgsqlTypes.NpgsqlPoint(x: 0.9360437606435211d, y: 0.06679483531482178d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 39,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0941776300205831d, y: 0.9418222980842068d), new NpgsqlTypes.NpgsqlPoint(x: 0.39890670535312d, y: 0.2857582230489123d), new NpgsqlTypes.NpgsqlPoint(x: 0.4325908345444178d, y: 0.8464939483257065d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.002171369774298104d, y: 0.2550579055702721d), new NpgsqlTypes.NpgsqlPoint(x: 0.49489189077660867d, y: 0.5200106709117555d), new NpgsqlTypes.NpgsqlPoint(x: 0.5557637839912367d, y: 0.34454450695062977d)),
},
            new NpgsqlPathpath0M
{
    Id = 46,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.237111021673723d, y: 0.7546682205038767d), new NpgsqlTypes.NpgsqlPoint(x: 0.09261129515306277d, y: 0.488262184738679d), new NpgsqlTypes.NpgsqlPoint(x: 0.4123146791625647d, y: 0.5918172170395731d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 32,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.77032603185126d, y: 0.09000602386788825d), new NpgsqlTypes.NpgsqlPoint(x: 0.7622489055404867d, y: 0.7408609477774195d), new NpgsqlTypes.NpgsqlPoint(x: 0.7006292586812409d, y: 0.0008179291344784234d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05670477111618d, y: 0.7925925168612267d), new NpgsqlTypes.NpgsqlPoint(x: 0.627078252543683d, y: 0.23262852202864992d), new NpgsqlTypes.NpgsqlPoint(x: 0.32570495394691235d, y: 0.5790955793687321d)),
},
            new NpgsqlPathpath0M
{
    Id = 55,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5714971105894264d, y: 0.4529330394296195d), new NpgsqlTypes.NpgsqlPoint(x: 0.19007607405096683d, y: 0.11176019073306376d), new NpgsqlTypes.NpgsqlPoint(x: 0.7808815149895312d, y: 0.03793206491585677d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42927183932071844d, y: 0.5299478813334146d), new NpgsqlTypes.NpgsqlPoint(x: 0.03783451835649476d, y: 0.17544336184849474d), new NpgsqlTypes.NpgsqlPoint(x: 0.8020175937912313d, y: 0.040935643742344374d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32580544898769337d, y: 0.7031048724908124d), new NpgsqlTypes.NpgsqlPoint(x: 0.3271474517096745d, y: 0.33667396287474216d), new NpgsqlTypes.NpgsqlPoint(x: 0.5418348223712389d, y: 0.240119412926183d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3571727615858501d, y: 0.054741118758890095d), new NpgsqlTypes.NpgsqlPoint(x: 0.2840544988750665d, y: 0.2956221289514004d), new NpgsqlTypes.NpgsqlPoint(x: 0.6893692974072203d, y: 0.9241973526553044d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.913407953746552d, y: 0.6647071358558121d), new NpgsqlTypes.NpgsqlPoint(x: 0.5214172613841843d, y: 0.414784255475809d), new NpgsqlTypes.NpgsqlPoint(x: 0.6228488813406426d, y: 0.34459915642265426d)),
},
            new NpgsqlPathpath0M
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8624329753278095d, y: 0.6461816765080703d), new NpgsqlTypes.NpgsqlPoint(x: 0.842042378880124d, y: 0.19059320850066586d), new NpgsqlTypes.NpgsqlPoint(x: 0.9682153775438516d, y: 0.4959369006136417d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5137597164720435d, y: 0.2004546492386754d), new NpgsqlTypes.NpgsqlPoint(x: 0.4897581466179546d, y: 0.7948892718122489d), new NpgsqlTypes.NpgsqlPoint(x: 0.38228277637807984d, y: 0.14899049668934206d)),
},
            new NpgsqlPathpath0M
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3300703639707653d, y: 0.9169600700686713d), new NpgsqlTypes.NpgsqlPoint(x: 0.7728114668119558d, y: 0.9579526466657787d), new NpgsqlTypes.NpgsqlPoint(x: 0.5780918333273007d, y: 0.9913851328930735d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 45,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.774442944297998d, y: 0.5927675208543527d), new NpgsqlTypes.NpgsqlPoint(x: 0.7359639042527086d, y: 0.2322866261176585d), new NpgsqlTypes.NpgsqlPoint(x: 0.4054451154703206d, y: 0.12925731326206114d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6333361661453281d, y: 0.5444859767693033d), new NpgsqlTypes.NpgsqlPoint(x: 0.24686731989718913d, y: 0.14124094410434163d), new NpgsqlTypes.NpgsqlPoint(x: 0.759460060676276d, y: 0.9237400950957505d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 70,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37401510459610166d, y: 0.12416771010642469d), new NpgsqlTypes.NpgsqlPoint(x: 0.7942597485425992d, y: 0.7308668060970779d), new NpgsqlTypes.NpgsqlPoint(x: 0.9051111116076801d, y: 0.7255273997951589d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9794488504681287d, y: 0.4937465179214392d), new NpgsqlTypes.NpgsqlPoint(x: 0.0619779065822359d, y: 0.3257753267205904d), new NpgsqlTypes.NpgsqlPoint(x: 0.3129946839125376d, y: 0.8486027927889574d)),
},
            new NpgsqlPathpath0M
{
    Id = 71,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9051245898510051d, y: 0.6265936713294158d), new NpgsqlTypes.NpgsqlPoint(x: 0.21272266231183734d, y: 0.893403889993993d), new NpgsqlTypes.NpgsqlPoint(x: 0.35887093868700104d, y: 0.7807749151776932d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.758398270909337d, y: 0.2622914035904951d), new NpgsqlTypes.NpgsqlPoint(x: 0.22019311189834012d, y: 0.43658105884019827d), new NpgsqlTypes.NpgsqlPoint(x: 0.033315987764844235d, y: 0.08466515327541713d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8746018867425128d, y: 0.36336580297659715d), new NpgsqlTypes.NpgsqlPoint(x: 0.714390639814034d, y: 0.21029369524581443d), new NpgsqlTypes.NpgsqlPoint(x: 0.2948808759447482d, y: 0.9932386791182569d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 80,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49234224021711614d, y: 0.9387752928166327d), new NpgsqlTypes.NpgsqlPoint(x: 0.6927963729121785d, y: 0.9443024596524286d), new NpgsqlTypes.NpgsqlPoint(x: 0.2683151400453795d, y: 0.05382993178246953d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 81,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26621523061593033d, y: 0.8362359920420828d), new NpgsqlTypes.NpgsqlPoint(x: 0.49407035997752835d, y: 0.6269993929610681d), new NpgsqlTypes.NpgsqlPoint(x: 0.22760893169405272d, y: 0.361660729790383d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.874658989793183d, y: 0.46121754802660875d), new NpgsqlTypes.NpgsqlPoint(x: 0.2064820459124771d, y: 0.25375768610935934d), new NpgsqlTypes.NpgsqlPoint(x: 0.997524977267156d, y: 0.8034154391661987d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7278456836135409d, y: 0.2554762793773112d), new NpgsqlTypes.NpgsqlPoint(x: 0.7269154219258088d, y: 0.01709578499686215d), new NpgsqlTypes.NpgsqlPoint(x: 0.8856282869264889d, y: 0.8373463197978699d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 83,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41848808025962225d, y: 0.41351358496234514d), new NpgsqlTypes.NpgsqlPoint(x: 0.1565493909055493d, y: 0.5416404157872334d), new NpgsqlTypes.NpgsqlPoint(x: 0.1320991607455435d, y: 0.97943821299891d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9693327682652896d, y: 0.9022776155352474d), new NpgsqlTypes.NpgsqlPoint(x: 0.3746132593249655d, y: 0.03285217709961197d), new NpgsqlTypes.NpgsqlPoint(x: 0.1716012274597113d, y: 0.16699243359685778d)),
},
            new NpgsqlPathpath0M
{
    Id = 90,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.320709788464561d, y: 0.05021687561072463d), new NpgsqlTypes.NpgsqlPoint(x: 0.27311509507697296d, y: 0.777019289684139d), new NpgsqlTypes.NpgsqlPoint(x: 0.7516954641086345d, y: 0.05650274984771664d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9466682786527097d, y: 0.23110938631807576d), new NpgsqlTypes.NpgsqlPoint(x: 0.6756247110880483d, y: 0.526350954714547d), new NpgsqlTypes.NpgsqlPoint(x: 0.29855656253034835d, y: 0.666053156095357d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47881544863888326d, y: 0.06649387851240063d), new NpgsqlTypes.NpgsqlPoint(x: 0.344356469250624d, y: 0.09887614355740881d), new NpgsqlTypes.NpgsqlPoint(x: 0.1648952024048842d, y: 0.21896701877643565d)),
},
            new NpgsqlPathpath0M
{
    Id = 98,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5650599560636058d, y: 0.0932046130613432d), new NpgsqlTypes.NpgsqlPoint(x: 0.3056289769192646d, y: 0.6174194221036183d), new NpgsqlTypes.NpgsqlPoint(x: 0.10511179254037828d, y: 0.48990606017347094d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 102,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04709767378986918d, y: 0.6996591709838087d), new NpgsqlTypes.NpgsqlPoint(x: 0.3898512759334899d, y: 0.39889285742106684d), new NpgsqlTypes.NpgsqlPoint(x: 0.5655598654834904d, y: 0.3629805711891775d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 65,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.740973861748367d, y: 0.1722480279455637d), new NpgsqlTypes.NpgsqlPoint(x: 0.6800257136437177d, y: 0.1516905589151002d), new NpgsqlTypes.NpgsqlPoint(x: 0.21011471952139715d, y: 0.7565268991187025d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9307353200107314d, y: 0.627161590010346d), new NpgsqlTypes.NpgsqlPoint(x: 0.7917949141434477d, y: 0.6145691807871473d), new NpgsqlTypes.NpgsqlPoint(x: 0.9641984122613042d, y: 0.36620962573236293d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 106,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8528296050778319d, y: 0.6741637091681683d), new NpgsqlTypes.NpgsqlPoint(x: 0.746306806666577d, y: 0.5669791830198243d), new NpgsqlTypes.NpgsqlPoint(x: 0.8149139541778871d, y: 0.5921544023343435d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8654852926417764d, y: 0.31033739667879645d), new NpgsqlTypes.NpgsqlPoint(x: 0.008868523337665968d, y: 0.15174936397670113d), new NpgsqlTypes.NpgsqlPoint(x: 0.34298086859941557d, y: 0.31824747774212514d)),
},
            new NpgsqlPathpath0M
{
    Id = 107,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05255287777552198d, y: 0.40373864018963446d), new NpgsqlTypes.NpgsqlPoint(x: 0.556898177210054d, y: 0.8665644409326728d), new NpgsqlTypes.NpgsqlPoint(x: 0.5550181430720145d, y: 0.30705299181354995d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6734993920479363d, y: 0.8861998703260131d), new NpgsqlTypes.NpgsqlPoint(x: 0.369465206000243d, y: 0.4572556738586008d), new NpgsqlTypes.NpgsqlPoint(x: 0.5722035865403604d, y: 0.176112590355605d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6545952765484444d, y: 0.941422973383447d), new NpgsqlTypes.NpgsqlPoint(x: 0.06411121483144366d, y: 0.8650268983777377d), new NpgsqlTypes.NpgsqlPoint(x: 0.5174569102613277d, y: 0.5848014912001167d)),
},
            new NpgsqlPathpath0M
{
    Id = 116,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5295349316532671d, y: 0.31952708350712955d), new NpgsqlTypes.NpgsqlPoint(x: 0.9091033818464792d, y: 0.33794687131285395d), new NpgsqlTypes.NpgsqlPoint(x: 0.6257693958563564d, y: 0.15098818797341151d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 117,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17927071905240588d, y: 0.5073526267581882d), new NpgsqlTypes.NpgsqlPoint(x: 0.13655018642472383d, y: 0.06507110349321499d), new NpgsqlTypes.NpgsqlPoint(x: 0.23985036786447778d, y: 0.2818879702126267d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 78,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3464296330254022d, y: 0.2746415621288768d), new NpgsqlTypes.NpgsqlPoint(x: 0.2686999207023666d, y: 0.37669090591695464d), new NpgsqlTypes.NpgsqlPoint(x: 0.22316253251413865d, y: 0.5785992304905915d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 123,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5705376005472131d, y: 0.6777525655762918d), new NpgsqlTypes.NpgsqlPoint(x: 0.049707759274746466d, y: 0.8390359769917024d), new NpgsqlTypes.NpgsqlPoint(x: 0.5010332918905597d, y: 0.6016600643451652d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 131,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22964680893570721d, y: 0.671003821324133d), new NpgsqlTypes.NpgsqlPoint(x: 0.8372362425266333d, y: 0.5419083152402465d), new NpgsqlTypes.NpgsqlPoint(x: 0.7897960352798842d, y: 0.06508720861366346d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 83,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17033105037848773d, y: 0.19462382572250014d), new NpgsqlTypes.NpgsqlPoint(x: 0.49865799955008905d, y: 0.6626552290497156d), new NpgsqlTypes.NpgsqlPoint(x: 0.6390499488940113d, y: 0.09936386016432042d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5161321066342638d, y: 0.34257561678649096d), new NpgsqlTypes.NpgsqlPoint(x: 0.8794527111617173d, y: 0.001043262320685967d), new NpgsqlTypes.NpgsqlPoint(x: 0.6854084521569092d, y: 0.6984327375583704d)),
},
            new NpgsqlPathpath0M
{
    Id = 135,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3764847452469334d, y: 0.3726078701775698d), new NpgsqlTypes.NpgsqlPoint(x: 0.8008371108512473d, y: 0.38774405650199284d), new NpgsqlTypes.NpgsqlPoint(x: 0.6359327304008894d, y: 0.3933735443849401d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08887770392234895d, y: 0.7628957862210329d), new NpgsqlTypes.NpgsqlPoint(x: 0.37120732583250016d, y: 0.7025407914943472d), new NpgsqlTypes.NpgsqlPoint(x: 0.2659510940201605d, y: 0.20011384138977362d)),
},
            new NpgsqlPathpath0M
{
    Id = 138,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.759000530589929d, y: 0.8184103734888876d), new NpgsqlTypes.NpgsqlPoint(x: 0.12018275939254186d, y: 0.30281657486719427d), new NpgsqlTypes.NpgsqlPoint(x: 0.07228116497330772d, y: 0.4380820896700697d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 86,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8934265068910956d, y: 0.5747391195677275d), new NpgsqlTypes.NpgsqlPoint(x: 0.09354192132432104d, y: 0.12885128536450352d), new NpgsqlTypes.NpgsqlPoint(x: 0.5099360054254544d, y: 0.24015370608736075d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3217356815260014d, y: 0.3727751681202215d), new NpgsqlTypes.NpgsqlPoint(x: 0.955838384868242d, y: 0.7299031244246565d), new NpgsqlTypes.NpgsqlPoint(x: 0.658650028915513d, y: 0.01791406915505689d)),
},
            new NpgsqlPathpath0M
{
    Id = 141,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6550058651759463d, y: 0.3885814083001702d), new NpgsqlTypes.NpgsqlPoint(x: 0.7781521584631059d, y: 0.5620464083197001d), new NpgsqlTypes.NpgsqlPoint(x: 0.3420632614800233d, y: 0.515188912929457d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 149,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8434751012213995d, y: 0.34732835019725805d), new NpgsqlTypes.NpgsqlPoint(x: 0.2570437705862725d, y: 0.42827712811694063d), new NpgsqlTypes.NpgsqlPoint(x: 0.8932174859819378d, y: 0.8556986741024213d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 89,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.012414824777664868d, y: 0.46806933948310414d), new NpgsqlTypes.NpgsqlPoint(x: 0.09276040204124447d, y: 0.004767050123645755d), new NpgsqlTypes.NpgsqlPoint(x: 0.002441877284527272d, y: 0.9795985506656033d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8809342676395575d, y: 0.8246479797846835d), new NpgsqlTypes.NpgsqlPoint(x: 0.8690903708609123d, y: 0.7101703570803172d), new NpgsqlTypes.NpgsqlPoint(x: 0.08746134940638972d, y: 0.735640319361848d)),
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0mi(
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0mi(
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
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(14))]
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

                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0mi(
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
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

                changedRows =  ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpath0mi_id
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpath0mi_id", 
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
                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpath0mi_id
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
    npgsqlpathpath0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                NpgsqlTypes.NpgsqlPath? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27008412857427166d, y: 0.11586715927737634d), new NpgsqlTypes.NpgsqlPoint(x: 0.20615294175649534d, y: 0.3190622927239317d), new NpgsqlTypes.NpgsqlPoint(x: 0.24269438253778852d, y: 0.47506835696254013d))));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlPath? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.002171369774298104d, y: 0.2550579055702721d), new NpgsqlTypes.NpgsqlPoint(x: 0.49489189077660867d, y: 0.5200106709117555d), new NpgsqlTypes.NpgsqlPoint(x: 0.5557637839912367d, y: 0.34454450695062977d))));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05670477111618d, y: 0.7925925168612267d), new NpgsqlTypes.NpgsqlPoint(x: 0.627078252543683d, y: 0.23262852202864992d), new NpgsqlTypes.NpgsqlPoint(x: 0.32570495394691235d, y: 0.5790955793687321d))));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpath0mi_id
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
    npgsqlpathpath0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpath0mi_id", 
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
                NpgsqlTypes.NpgsqlPath? nullable = null;
                nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.913407953746552d, y: 0.6647071358558121d), new NpgsqlTypes.NpgsqlPoint(x: 0.5214172613841843d, y: 0.414784255475809d), new NpgsqlTypes.NpgsqlPoint(x: 0.6228488813406426d, y: 0.34459915642265426d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath? nullable = null;
                nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5137597164720435d, y: 0.2004546492386754d), new NpgsqlTypes.NpgsqlPoint(x: 0.4897581466179546d, y: 0.7948892718122489d), new NpgsqlTypes.NpgsqlPoint(x: 0.38228277637807984d, y: 0.14899049668934206d))));
                nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpath0M> models = null;

                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpath0M> models = null;

                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpath0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlpathpath0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlPath), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlpathpath0mi_id", 
                methodParametrName: "npgsqlpathpath0mi_id", 
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

                changedRows =  ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M), typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await ((INpgsqlPathSingleTypepath)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathSingleTypepath)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M), typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await ((INpgsqlPathSingleTypepath)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathSingleTypepath)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M), typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                await((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[27],_testData[29], false);
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
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[29], false);
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
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[29], false);
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
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 32;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[24],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[29], false);
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
                parametr1.Value = 135;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 55;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[20],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[29], false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[7], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[8], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[9], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[10], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[11], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[12], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[13], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[14], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[19],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[20],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[21],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M), typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                await((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 117, query1, 102, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 19, query1, 57, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 107, query1, 61, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[17],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var firstItems2 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelBatch(connection, 57, query1, 35, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems2[18],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[23],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 106, query1, 56, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 102, query1, 131, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTDynQuerySelectModelBatch(connection, 70, query1, 46, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems1 = new List<FlatNpgsqlPathpath0M>();
                var secondItems2 = new List<FlatNpgsqlPathpath0M>();
                 ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatch(connection, 56, query1, 90, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(firstItems1[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPathpath0M.AssertModel(secondItems2[11],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatchAsync(connection, 15, 90))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPathpath0M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPathpath0M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPathpath0M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPathpath0M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPathpath0M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[11],_testData[29], false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSTSelectModelBatch(connection, 106, 106))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPathpath0M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPathpath0M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPathpath0M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPathpath0M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPathpath0M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPathpath0M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPathpath0M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPathpath0M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPathpath0M.AssertModel(models[8],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPathSingleTypepath)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 15);
                var models = await ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(28));
NpgsqlPathpath0M.AssertModel(models[0],_testData[2], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[3], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[4], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[5], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[6], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[7], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[8], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[9], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[10], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[11], false);NpgsqlPathpath0M.AssertModel(models[10],_testData[12], false);NpgsqlPathpath0M.AssertModel(models[11],_testData[13], false);NpgsqlPathpath0M.AssertModel(models[12],_testData[14], false);NpgsqlPathpath0M.AssertModel(models[13],_testData[15], false);NpgsqlPathpath0M.AssertModel(models[14],_testData[16], false);NpgsqlPathpath0M.AssertModel(models[15],_testData[17], false);NpgsqlPathpath0M.AssertModel(models[16],_testData[18], false);NpgsqlPathpath0M.AssertModel(models[17],_testData[19], false);NpgsqlPathpath0M.AssertModel(models[18],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[19],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[20],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[21],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[22],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[23],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[24],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[25],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[26],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[27],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathSingleTypepath)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 102);
                var models =  ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(10));
NpgsqlPathpath0M.AssertModel(models[0],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9344132428458164d, y: 0.40522834832847354d), new NpgsqlTypes.NpgsqlPoint(x: 0.9995696094048637d, y: 0.1415227694747454d), new NpgsqlTypes.NpgsqlPoint(x: 0.6782063503658687d, y: 0.4663119608143006d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5554549783916991d, y: 0.10479181001825033d), new NpgsqlTypes.NpgsqlPoint(x: 0.2467491183839331d, y: 0.5472671914350874d), new NpgsqlTypes.NpgsqlPoint(x: 0.25611846689920836d, y: 0.5244254741784456d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8892214630030745d, y: 0.5235182096078641d), new NpgsqlTypes.NpgsqlPoint(x: 0.14737497390792886d, y: 0.440983256110954d), new NpgsqlTypes.NpgsqlPoint(x: 0.7275950188580708d, y: 0.6066202822452224d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16219237483314364d, y: 0.8627055418238431d), new NpgsqlTypes.NpgsqlPoint(x: 0.21773870578083176d, y: 0.6399036247042652d), new NpgsqlTypes.NpgsqlPoint(x: 0.6155586457361163d, y: 0.8183694287586004d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27998952722981496d, y: 0.19075137023668098d), new NpgsqlTypes.NpgsqlPoint(x: 0.9253884435169634d, y: 0.44036752598326767d), new NpgsqlTypes.NpgsqlPoint(x: 0.7120887709035141d, y: 0.7420158259828084d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33488550054072985d, y: 0.1600240494351759d), new NpgsqlTypes.NpgsqlPoint(x: 0.38742514599989475d, y: 0.1774105159131788d), new NpgsqlTypes.NpgsqlPoint(x: 0.6694756339163823d, y: 0.19807237845040904d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6732800738557224d, y: 0.5755731831383838d), new NpgsqlTypes.NpgsqlPoint(x: 0.3741118209580464d, y: 0.22973341842890027d), new NpgsqlTypes.NpgsqlPoint(x: 0.38571725957336767d, y: 0.7334747969275555d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.852491419968036d, y: 0.6235079368552496d), new NpgsqlTypes.NpgsqlPoint(x: 0.4881534729952559d, y: 0.31659987362610553d), new NpgsqlTypes.NpgsqlPoint(x: 0.2948235829454555d, y: 0.7980564598074066d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2902349542234214d, y: 0.6952383480773564d), new NpgsqlTypes.NpgsqlPoint(x: 0.10020084801181939d, y: 0.42935401232768666d), new NpgsqlTypes.NpgsqlPoint(x: 0.769843000386224d, y: 0.28031989733280116d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9755933185766131d, y: 0.729567447337437d), new NpgsqlTypes.NpgsqlPoint(x: 0.5763337547213196d, y: 0.7795148492238755d), new NpgsqlTypes.NpgsqlPoint(x: 0.7390404620983274d, y: 0.20022484163308718d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8161729797937682d, y: 0.25756779088382475d), new NpgsqlTypes.NpgsqlPoint(x: 0.7099022618645796d, y: 0.013423176787772384d), new NpgsqlTypes.NpgsqlPoint(x: 0.9717374977374659d, y: 0.4226854351938598d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27008412857427166d, y: 0.11586715927737634d), new NpgsqlTypes.NpgsqlPoint(x: 0.20615294175649534d, y: 0.3190622927239317d), new NpgsqlTypes.NpgsqlPoint(x: 0.24269438253778852d, y: 0.47506835696254013d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.018323610195757567d, y: 0.4795796851526565d), new NpgsqlTypes.NpgsqlPoint(x: 0.3764133137369181d, y: 0.560962377580302d), new NpgsqlTypes.NpgsqlPoint(x: 0.19960775052855673d, y: 0.12611943257805636d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17811495902533736d, y: 0.8511288895277689d), new NpgsqlTypes.NpgsqlPoint(x: 0.2105839958224659d, y: 0.252216468303773d), new NpgsqlTypes.NpgsqlPoint(x: 0.19014431236843232d, y: 0.19203549120177543d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.350480065390809d, y: 0.39825545459268663d), new NpgsqlTypes.NpgsqlPoint(x: 0.3201040396048518d, y: 0.3271635167466006d), new NpgsqlTypes.NpgsqlPoint(x: 0.9360437606435211d, y: 0.06679483531482178d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0941776300205831d, y: 0.9418222980842068d), new NpgsqlTypes.NpgsqlPoint(x: 0.39890670535312d, y: 0.2857582230489123d), new NpgsqlTypes.NpgsqlPoint(x: 0.4325908345444178d, y: 0.8464939483257065d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.002171369774298104d, y: 0.2550579055702721d), new NpgsqlTypes.NpgsqlPoint(x: 0.49489189077660867d, y: 0.5200106709117555d), new NpgsqlTypes.NpgsqlPoint(x: 0.5557637839912367d, y: 0.34454450695062977d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.237111021673723d, y: 0.7546682205038767d), new NpgsqlTypes.NpgsqlPoint(x: 0.09261129515306277d, y: 0.488262184738679d), new NpgsqlTypes.NpgsqlPoint(x: 0.4123146791625647d, y: 0.5918172170395731d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.77032603185126d, y: 0.09000602386788825d), new NpgsqlTypes.NpgsqlPoint(x: 0.7622489055404867d, y: 0.7408609477774195d), new NpgsqlTypes.NpgsqlPoint(x: 0.7006292586812409d, y: 0.0008179291344784234d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05670477111618d, y: 0.7925925168612267d), new NpgsqlTypes.NpgsqlPoint(x: 0.627078252543683d, y: 0.23262852202864992d), new NpgsqlTypes.NpgsqlPoint(x: 0.32570495394691235d, y: 0.5790955793687321d)))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5714971105894264d, y: 0.4529330394296195d), new NpgsqlTypes.NpgsqlPoint(x: 0.19007607405096683d, y: 0.11176019073306376d), new NpgsqlTypes.NpgsqlPoint(x: 0.7808815149895312d, y: 0.03793206491585677d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42927183932071844d, y: 0.5299478813334146d), new NpgsqlTypes.NpgsqlPoint(x: 0.03783451835649476d, y: 0.17544336184849474d), new NpgsqlTypes.NpgsqlPoint(x: 0.8020175937912313d, y: 0.040935643742344374d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32580544898769337d, y: 0.7031048724908124d), new NpgsqlTypes.NpgsqlPoint(x: 0.3271474517096745d, y: 0.33667396287474216d), new NpgsqlTypes.NpgsqlPoint(x: 0.5418348223712389d, y: 0.240119412926183d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3571727615858501d, y: 0.054741118758890095d), new NpgsqlTypes.NpgsqlPoint(x: 0.2840544988750665d, y: 0.2956221289514004d), new NpgsqlTypes.NpgsqlPoint(x: 0.6893692974072203d, y: 0.9241973526553044d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.913407953746552d, y: 0.6647071358558121d), new NpgsqlTypes.NpgsqlPoint(x: 0.5214172613841843d, y: 0.414784255475809d), new NpgsqlTypes.NpgsqlPoint(x: 0.6228488813406426d, y: 0.34459915642265426d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8624329753278095d, y: 0.6461816765080703d), new NpgsqlTypes.NpgsqlPoint(x: 0.842042378880124d, y: 0.19059320850066586d), new NpgsqlTypes.NpgsqlPoint(x: 0.9682153775438516d, y: 0.4959369006136417d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5137597164720435d, y: 0.2004546492386754d), new NpgsqlTypes.NpgsqlPoint(x: 0.4897581466179546d, y: 0.7948892718122489d), new NpgsqlTypes.NpgsqlPoint(x: 0.38228277637807984d, y: 0.14899049668934206d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3300703639707653d, y: 0.9169600700686713d), new NpgsqlTypes.NpgsqlPoint(x: 0.7728114668119558d, y: 0.9579526466657787d), new NpgsqlTypes.NpgsqlPoint(x: 0.5780918333273007d, y: 0.9913851328930735d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.774442944297998d, y: 0.5927675208543527d), new NpgsqlTypes.NpgsqlPoint(x: 0.7359639042527086d, y: 0.2322866261176585d), new NpgsqlTypes.NpgsqlPoint(x: 0.4054451154703206d, y: 0.12925731326206114d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6333361661453281d, y: 0.5444859767693033d), new NpgsqlTypes.NpgsqlPoint(x: 0.24686731989718913d, y: 0.14124094410434163d), new NpgsqlTypes.NpgsqlPoint(x: 0.759460060676276d, y: 0.9237400950957505d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37401510459610166d, y: 0.12416771010642469d), new NpgsqlTypes.NpgsqlPoint(x: 0.7942597485425992d, y: 0.7308668060970779d), new NpgsqlTypes.NpgsqlPoint(x: 0.9051111116076801d, y: 0.7255273997951589d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9794488504681287d, y: 0.4937465179214392d), new NpgsqlTypes.NpgsqlPoint(x: 0.0619779065822359d, y: 0.3257753267205904d), new NpgsqlTypes.NpgsqlPoint(x: 0.3129946839125376d, y: 0.8486027927889574d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9051245898510051d, y: 0.6265936713294158d), new NpgsqlTypes.NpgsqlPoint(x: 0.21272266231183734d, y: 0.893403889993993d), new NpgsqlTypes.NpgsqlPoint(x: 0.35887093868700104d, y: 0.7807749151776932d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.758398270909337d, y: 0.2622914035904951d), new NpgsqlTypes.NpgsqlPoint(x: 0.22019311189834012d, y: 0.43658105884019827d), new NpgsqlTypes.NpgsqlPoint(x: 0.033315987764844235d, y: 0.08466515327541713d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8746018867425128d, y: 0.36336580297659715d), new NpgsqlTypes.NpgsqlPoint(x: 0.714390639814034d, y: 0.21029369524581443d), new NpgsqlTypes.NpgsqlPoint(x: 0.2948808759447482d, y: 0.9932386791182569d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49234224021711614d, y: 0.9387752928166327d), new NpgsqlTypes.NpgsqlPoint(x: 0.6927963729121785d, y: 0.9443024596524286d), new NpgsqlTypes.NpgsqlPoint(x: 0.2683151400453795d, y: 0.05382993178246953d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26621523061593033d, y: 0.8362359920420828d), new NpgsqlTypes.NpgsqlPoint(x: 0.49407035997752835d, y: 0.6269993929610681d), new NpgsqlTypes.NpgsqlPoint(x: 0.22760893169405272d, y: 0.361660729790383d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.874658989793183d, y: 0.46121754802660875d), new NpgsqlTypes.NpgsqlPoint(x: 0.2064820459124771d, y: 0.25375768610935934d), new NpgsqlTypes.NpgsqlPoint(x: 0.997524977267156d, y: 0.8034154391661987d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7278456836135409d, y: 0.2554762793773112d), new NpgsqlTypes.NpgsqlPoint(x: 0.7269154219258088d, y: 0.01709578499686215d), new NpgsqlTypes.NpgsqlPoint(x: 0.8856282869264889d, y: 0.8373463197978699d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41848808025962225d, y: 0.41351358496234514d), new NpgsqlTypes.NpgsqlPoint(x: 0.1565493909055493d, y: 0.5416404157872334d), new NpgsqlTypes.NpgsqlPoint(x: 0.1320991607455435d, y: 0.97943821299891d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9693327682652896d, y: 0.9022776155352474d), new NpgsqlTypes.NpgsqlPoint(x: 0.3746132593249655d, y: 0.03285217709961197d), new NpgsqlTypes.NpgsqlPoint(x: 0.1716012274597113d, y: 0.16699243359685778d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.320709788464561d, y: 0.05021687561072463d), new NpgsqlTypes.NpgsqlPoint(x: 0.27311509507697296d, y: 0.777019289684139d), new NpgsqlTypes.NpgsqlPoint(x: 0.7516954641086345d, y: 0.05650274984771664d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9466682786527097d, y: 0.23110938631807576d), new NpgsqlTypes.NpgsqlPoint(x: 0.6756247110880483d, y: 0.526350954714547d), new NpgsqlTypes.NpgsqlPoint(x: 0.29855656253034835d, y: 0.666053156095357d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47881544863888326d, y: 0.06649387851240063d), new NpgsqlTypes.NpgsqlPoint(x: 0.344356469250624d, y: 0.09887614355740881d), new NpgsqlTypes.NpgsqlPoint(x: 0.1648952024048842d, y: 0.21896701877643565d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5650599560636058d, y: 0.0932046130613432d), new NpgsqlTypes.NpgsqlPoint(x: 0.3056289769192646d, y: 0.6174194221036183d), new NpgsqlTypes.NpgsqlPoint(x: 0.10511179254037828d, y: 0.48990606017347094d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04709767378986918d, y: 0.6996591709838087d), new NpgsqlTypes.NpgsqlPoint(x: 0.3898512759334899d, y: 0.39889285742106684d), new NpgsqlTypes.NpgsqlPoint(x: 0.5655598654834904d, y: 0.3629805711891775d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.740973861748367d, y: 0.1722480279455637d), new NpgsqlTypes.NpgsqlPoint(x: 0.6800257136437177d, y: 0.1516905589151002d), new NpgsqlTypes.NpgsqlPoint(x: 0.21011471952139715d, y: 0.7565268991187025d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9307353200107314d, y: 0.627161590010346d), new NpgsqlTypes.NpgsqlPoint(x: 0.7917949141434477d, y: 0.6145691807871473d), new NpgsqlTypes.NpgsqlPoint(x: 0.9641984122613042d, y: 0.36620962573236293d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8528296050778319d, y: 0.6741637091681683d), new NpgsqlTypes.NpgsqlPoint(x: 0.746306806666577d, y: 0.5669791830198243d), new NpgsqlTypes.NpgsqlPoint(x: 0.8149139541778871d, y: 0.5921544023343435d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8654852926417764d, y: 0.31033739667879645d), new NpgsqlTypes.NpgsqlPoint(x: 0.008868523337665968d, y: 0.15174936397670113d), new NpgsqlTypes.NpgsqlPoint(x: 0.34298086859941557d, y: 0.31824747774212514d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05255287777552198d, y: 0.40373864018963446d), new NpgsqlTypes.NpgsqlPoint(x: 0.556898177210054d, y: 0.8665644409326728d), new NpgsqlTypes.NpgsqlPoint(x: 0.5550181430720145d, y: 0.30705299181354995d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6734993920479363d, y: 0.8861998703260131d), new NpgsqlTypes.NpgsqlPoint(x: 0.369465206000243d, y: 0.4572556738586008d), new NpgsqlTypes.NpgsqlPoint(x: 0.5722035865403604d, y: 0.176112590355605d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6545952765484444d, y: 0.941422973383447d), new NpgsqlTypes.NpgsqlPoint(x: 0.06411121483144366d, y: 0.8650268983777377d), new NpgsqlTypes.NpgsqlPoint(x: 0.5174569102613277d, y: 0.5848014912001167d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5295349316532671d, y: 0.31952708350712955d), new NpgsqlTypes.NpgsqlPoint(x: 0.9091033818464792d, y: 0.33794687131285395d), new NpgsqlTypes.NpgsqlPoint(x: 0.6257693958563564d, y: 0.15098818797341151d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17927071905240588d, y: 0.5073526267581882d), new NpgsqlTypes.NpgsqlPoint(x: 0.13655018642472383d, y: 0.06507110349321499d), new NpgsqlTypes.NpgsqlPoint(x: 0.23985036786447778d, y: 0.2818879702126267d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3464296330254022d, y: 0.2746415621288768d), new NpgsqlTypes.NpgsqlPoint(x: 0.2686999207023666d, y: 0.37669090591695464d), new NpgsqlTypes.NpgsqlPoint(x: 0.22316253251413865d, y: 0.5785992304905915d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5705376005472131d, y: 0.6777525655762918d), new NpgsqlTypes.NpgsqlPoint(x: 0.049707759274746466d, y: 0.8390359769917024d), new NpgsqlTypes.NpgsqlPoint(x: 0.5010332918905597d, y: 0.6016600643451652d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22964680893570721d, y: 0.671003821324133d), new NpgsqlTypes.NpgsqlPoint(x: 0.8372362425266333d, y: 0.5419083152402465d), new NpgsqlTypes.NpgsqlPoint(x: 0.7897960352798842d, y: 0.06508720861366346d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17033105037848773d, y: 0.19462382572250014d), new NpgsqlTypes.NpgsqlPoint(x: 0.49865799955008905d, y: 0.6626552290497156d), new NpgsqlTypes.NpgsqlPoint(x: 0.6390499488940113d, y: 0.09936386016432042d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5161321066342638d, y: 0.34257561678649096d), new NpgsqlTypes.NpgsqlPoint(x: 0.8794527111617173d, y: 0.001043262320685967d), new NpgsqlTypes.NpgsqlPoint(x: 0.6854084521569092d, y: 0.6984327375583704d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3764847452469334d, y: 0.3726078701775698d), new NpgsqlTypes.NpgsqlPoint(x: 0.8008371108512473d, y: 0.38774405650199284d), new NpgsqlTypes.NpgsqlPoint(x: 0.6359327304008894d, y: 0.3933735443849401d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08887770392234895d, y: 0.7628957862210329d), new NpgsqlTypes.NpgsqlPoint(x: 0.37120732583250016d, y: 0.7025407914943472d), new NpgsqlTypes.NpgsqlPoint(x: 0.2659510940201605d, y: 0.20011384138977362d)))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.759000530589929d, y: 0.8184103734888876d), new NpgsqlTypes.NpgsqlPoint(x: 0.12018275939254186d, y: 0.30281657486719427d), new NpgsqlTypes.NpgsqlPoint(x: 0.07228116497330772d, y: 0.4380820896700697d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8934265068910956d, y: 0.5747391195677275d), new NpgsqlTypes.NpgsqlPoint(x: 0.09354192132432104d, y: 0.12885128536450352d), new NpgsqlTypes.NpgsqlPoint(x: 0.5099360054254544d, y: 0.24015370608736075d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3217356815260014d, y: 0.3727751681202215d), new NpgsqlTypes.NpgsqlPoint(x: 0.955838384868242d, y: 0.7299031244246565d), new NpgsqlTypes.NpgsqlPoint(x: 0.658650028915513d, y: 0.01791406915505689d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6550058651759463d, y: 0.3885814083001702d), new NpgsqlTypes.NpgsqlPoint(x: 0.7781521584631059d, y: 0.5620464083197001d), new NpgsqlTypes.NpgsqlPoint(x: 0.3420632614800233d, y: 0.515188912929457d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8434751012213995d, y: 0.34732835019725805d), new NpgsqlTypes.NpgsqlPoint(x: 0.2570437705862725d, y: 0.42827712811694063d), new NpgsqlTypes.NpgsqlPoint(x: 0.8932174859819378d, y: 0.8556986741024213d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((89)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.012414824777664868d, y: 0.46806933948310414d), new NpgsqlTypes.NpgsqlPoint(x: 0.09276040204124447d, y: 0.004767050123645755d), new NpgsqlTypes.NpgsqlPoint(x: 0.002441877284527272d, y: 0.9795985506656033d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8809342676395575d, y: 0.8246479797846835d), new NpgsqlTypes.NpgsqlPoint(x: 0.8690903708609123d, y: 0.7101703570803172d), new NpgsqlTypes.NpgsqlPoint(x: 0.08746134940638972d, y: 0.735640319361848d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9344132428458164d, y: 0.40522834832847354d), new NpgsqlTypes.NpgsqlPoint(x: 0.9995696094048637d, y: 0.1415227694747454d), new NpgsqlTypes.NpgsqlPoint(x: 0.6782063503658687d, y: 0.4663119608143006d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5554549783916991d, y: 0.10479181001825033d), new NpgsqlTypes.NpgsqlPoint(x: 0.2467491183839331d, y: 0.5472671914350874d), new NpgsqlTypes.NpgsqlPoint(x: 0.25611846689920836d, y: 0.5244254741784456d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((8)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8892214630030745d, y: 0.5235182096078641d), new NpgsqlTypes.NpgsqlPoint(x: 0.14737497390792886d, y: 0.440983256110954d), new NpgsqlTypes.NpgsqlPoint(x: 0.7275950188580708d, y: 0.6066202822452224d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16219237483314364d, y: 0.8627055418238431d), new NpgsqlTypes.NpgsqlPoint(x: 0.21773870578083176d, y: 0.6399036247042652d), new NpgsqlTypes.NpgsqlPoint(x: 0.6155586457361163d, y: 0.8183694287586004d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27998952722981496d, y: 0.19075137023668098d), new NpgsqlTypes.NpgsqlPoint(x: 0.9253884435169634d, y: 0.44036752598326767d), new NpgsqlTypes.NpgsqlPoint(x: 0.7120887709035141d, y: 0.7420158259828084d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((19)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33488550054072985d, y: 0.1600240494351759d), new NpgsqlTypes.NpgsqlPoint(x: 0.38742514599989475d, y: 0.1774105159131788d), new NpgsqlTypes.NpgsqlPoint(x: 0.6694756339163823d, y: 0.19807237845040904d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6732800738557224d, y: 0.5755731831383838d), new NpgsqlTypes.NpgsqlPoint(x: 0.3741118209580464d, y: 0.22973341842890027d), new NpgsqlTypes.NpgsqlPoint(x: 0.38571725957336767d, y: 0.7334747969275555d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((14)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.852491419968036d, y: 0.6235079368552496d), new NpgsqlTypes.NpgsqlPoint(x: 0.4881534729952559d, y: 0.31659987362610553d), new NpgsqlTypes.NpgsqlPoint(x: 0.2948235829454555d, y: 0.7980564598074066d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2902349542234214d, y: 0.6952383480773564d), new NpgsqlTypes.NpgsqlPoint(x: 0.10020084801181939d, y: 0.42935401232768666d), new NpgsqlTypes.NpgsqlPoint(x: 0.769843000386224d, y: 0.28031989733280116d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9755933185766131d, y: 0.729567447337437d), new NpgsqlTypes.NpgsqlPoint(x: 0.5763337547213196d, y: 0.7795148492238755d), new NpgsqlTypes.NpgsqlPoint(x: 0.7390404620983274d, y: 0.20022484163308718d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((32)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8161729797937682d, y: 0.25756779088382475d), new NpgsqlTypes.NpgsqlPoint(x: 0.7099022618645796d, y: 0.013423176787772384d), new NpgsqlTypes.NpgsqlPoint(x: 0.9717374977374659d, y: 0.4226854351938598d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27008412857427166d, y: 0.11586715927737634d), new NpgsqlTypes.NpgsqlPoint(x: 0.20615294175649534d, y: 0.3190622927239317d), new NpgsqlTypes.NpgsqlPoint(x: 0.24269438253778852d, y: 0.47506835696254013d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((35)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.018323610195757567d, y: 0.4795796851526565d), new NpgsqlTypes.NpgsqlPoint(x: 0.3764133137369181d, y: 0.560962377580302d), new NpgsqlTypes.NpgsqlPoint(x: 0.19960775052855673d, y: 0.12611943257805636d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((23)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17811495902533736d, y: 0.8511288895277689d), new NpgsqlTypes.NpgsqlPoint(x: 0.2105839958224659d, y: 0.252216468303773d), new NpgsqlTypes.NpgsqlPoint(x: 0.19014431236843232d, y: 0.19203549120177543d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.350480065390809d, y: 0.39825545459268663d), new NpgsqlTypes.NpgsqlPoint(x: 0.3201040396048518d, y: 0.3271635167466006d), new NpgsqlTypes.NpgsqlPoint(x: 0.9360437606435211d, y: 0.06679483531482178d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0941776300205831d, y: 0.9418222980842068d), new NpgsqlTypes.NpgsqlPoint(x: 0.39890670535312d, y: 0.2857582230489123d), new NpgsqlTypes.NpgsqlPoint(x: 0.4325908345444178d, y: 0.8464939483257065d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.002171369774298104d, y: 0.2550579055702721d), new NpgsqlTypes.NpgsqlPoint(x: 0.49489189077660867d, y: 0.5200106709117555d), new NpgsqlTypes.NpgsqlPoint(x: 0.5557637839912367d, y: 0.34454450695062977d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((46)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.237111021673723d, y: 0.7546682205038767d), new NpgsqlTypes.NpgsqlPoint(x: 0.09261129515306277d, y: 0.488262184738679d), new NpgsqlTypes.NpgsqlPoint(x: 0.4123146791625647d, y: 0.5918172170395731d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((32)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.77032603185126d, y: 0.09000602386788825d), new NpgsqlTypes.NpgsqlPoint(x: 0.7622489055404867d, y: 0.7408609477774195d), new NpgsqlTypes.NpgsqlPoint(x: 0.7006292586812409d, y: 0.0008179291344784234d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05670477111618d, y: 0.7925925168612267d), new NpgsqlTypes.NpgsqlPoint(x: 0.627078252543683d, y: 0.23262852202864992d), new NpgsqlTypes.NpgsqlPoint(x: 0.32570495394691235d, y: 0.5790955793687321d)))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5714971105894264d, y: 0.4529330394296195d), new NpgsqlTypes.NpgsqlPoint(x: 0.19007607405096683d, y: 0.11176019073306376d), new NpgsqlTypes.NpgsqlPoint(x: 0.7808815149895312d, y: 0.03793206491585677d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42927183932071844d, y: 0.5299478813334146d), new NpgsqlTypes.NpgsqlPoint(x: 0.03783451835649476d, y: 0.17544336184849474d), new NpgsqlTypes.NpgsqlPoint(x: 0.8020175937912313d, y: 0.040935643742344374d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32580544898769337d, y: 0.7031048724908124d), new NpgsqlTypes.NpgsqlPoint(x: 0.3271474517096745d, y: 0.33667396287474216d), new NpgsqlTypes.NpgsqlPoint(x: 0.5418348223712389d, y: 0.240119412926183d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3571727615858501d, y: 0.054741118758890095d), new NpgsqlTypes.NpgsqlPoint(x: 0.2840544988750665d, y: 0.2956221289514004d), new NpgsqlTypes.NpgsqlPoint(x: 0.6893692974072203d, y: 0.9241973526553044d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.913407953746552d, y: 0.6647071358558121d), new NpgsqlTypes.NpgsqlPoint(x: 0.5214172613841843d, y: 0.414784255475809d), new NpgsqlTypes.NpgsqlPoint(x: 0.6228488813406426d, y: 0.34459915642265426d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8624329753278095d, y: 0.6461816765080703d), new NpgsqlTypes.NpgsqlPoint(x: 0.842042378880124d, y: 0.19059320850066586d), new NpgsqlTypes.NpgsqlPoint(x: 0.9682153775438516d, y: 0.4959369006136417d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5137597164720435d, y: 0.2004546492386754d), new NpgsqlTypes.NpgsqlPoint(x: 0.4897581466179546d, y: 0.7948892718122489d), new NpgsqlTypes.NpgsqlPoint(x: 0.38228277637807984d, y: 0.14899049668934206d)))));

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((61)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3300703639707653d, y: 0.9169600700686713d), new NpgsqlTypes.NpgsqlPoint(x: 0.7728114668119558d, y: 0.9579526466657787d), new NpgsqlTypes.NpgsqlPoint(x: 0.5780918333273007d, y: 0.9913851328930735d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.774442944297998d, y: 0.5927675208543527d), new NpgsqlTypes.NpgsqlPoint(x: 0.7359639042527086d, y: 0.2322866261176585d), new NpgsqlTypes.NpgsqlPoint(x: 0.4054451154703206d, y: 0.12925731326206114d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6333361661453281d, y: 0.5444859767693033d), new NpgsqlTypes.NpgsqlPoint(x: 0.24686731989718913d, y: 0.14124094410434163d), new NpgsqlTypes.NpgsqlPoint(x: 0.759460060676276d, y: 0.9237400950957505d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((70)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37401510459610166d, y: 0.12416771010642469d), new NpgsqlTypes.NpgsqlPoint(x: 0.7942597485425992d, y: 0.7308668060970779d), new NpgsqlTypes.NpgsqlPoint(x: 0.9051111116076801d, y: 0.7255273997951589d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9794488504681287d, y: 0.4937465179214392d), new NpgsqlTypes.NpgsqlPoint(x: 0.0619779065822359d, y: 0.3257753267205904d), new NpgsqlTypes.NpgsqlPoint(x: 0.3129946839125376d, y: 0.8486027927889574d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((71)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9051245898510051d, y: 0.6265936713294158d), new NpgsqlTypes.NpgsqlPoint(x: 0.21272266231183734d, y: 0.893403889993993d), new NpgsqlTypes.NpgsqlPoint(x: 0.35887093868700104d, y: 0.7807749151776932d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((47)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.758398270909337d, y: 0.2622914035904951d), new NpgsqlTypes.NpgsqlPoint(x: 0.22019311189834012d, y: 0.43658105884019827d), new NpgsqlTypes.NpgsqlPoint(x: 0.033315987764844235d, y: 0.08466515327541713d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8746018867425128d, y: 0.36336580297659715d), new NpgsqlTypes.NpgsqlPoint(x: 0.714390639814034d, y: 0.21029369524581443d), new NpgsqlTypes.NpgsqlPoint(x: 0.2948808759447482d, y: 0.9932386791182569d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((80)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49234224021711614d, y: 0.9387752928166327d), new NpgsqlTypes.NpgsqlPoint(x: 0.6927963729121785d, y: 0.9443024596524286d), new NpgsqlTypes.NpgsqlPoint(x: 0.2683151400453795d, y: 0.05382993178246953d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((81)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26621523061593033d, y: 0.8362359920420828d), new NpgsqlTypes.NpgsqlPoint(x: 0.49407035997752835d, y: 0.6269993929610681d), new NpgsqlTypes.NpgsqlPoint(x: 0.22760893169405272d, y: 0.361660729790383d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((48)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.874658989793183d, y: 0.46121754802660875d), new NpgsqlTypes.NpgsqlPoint(x: 0.2064820459124771d, y: 0.25375768610935934d), new NpgsqlTypes.NpgsqlPoint(x: 0.997524977267156d, y: 0.8034154391661987d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7278456836135409d, y: 0.2554762793773112d), new NpgsqlTypes.NpgsqlPoint(x: 0.7269154219258088d, y: 0.01709578499686215d), new NpgsqlTypes.NpgsqlPoint(x: 0.8856282869264889d, y: 0.8373463197978699d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((83)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41848808025962225d, y: 0.41351358496234514d), new NpgsqlTypes.NpgsqlPoint(x: 0.1565493909055493d, y: 0.5416404157872334d), new NpgsqlTypes.NpgsqlPoint(x: 0.1320991607455435d, y: 0.97943821299891d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9693327682652896d, y: 0.9022776155352474d), new NpgsqlTypes.NpgsqlPoint(x: 0.3746132593249655d, y: 0.03285217709961197d), new NpgsqlTypes.NpgsqlPoint(x: 0.1716012274597113d, y: 0.16699243359685778d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.320709788464561d, y: 0.05021687561072463d), new NpgsqlTypes.NpgsqlPoint(x: 0.27311509507697296d, y: 0.777019289684139d), new NpgsqlTypes.NpgsqlPoint(x: 0.7516954641086345d, y: 0.05650274984771664d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((57)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9466682786527097d, y: 0.23110938631807576d), new NpgsqlTypes.NpgsqlPoint(x: 0.6756247110880483d, y: 0.526350954714547d), new NpgsqlTypes.NpgsqlPoint(x: 0.29855656253034835d, y: 0.666053156095357d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47881544863888326d, y: 0.06649387851240063d), new NpgsqlTypes.NpgsqlPoint(x: 0.344356469250624d, y: 0.09887614355740881d), new NpgsqlTypes.NpgsqlPoint(x: 0.1648952024048842d, y: 0.21896701877643565d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((98)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5650599560636058d, y: 0.0932046130613432d), new NpgsqlTypes.NpgsqlPoint(x: 0.3056289769192646d, y: 0.6174194221036183d), new NpgsqlTypes.NpgsqlPoint(x: 0.10511179254037828d, y: 0.48990606017347094d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04709767378986918d, y: 0.6996591709838087d), new NpgsqlTypes.NpgsqlPoint(x: 0.3898512759334899d, y: 0.39889285742106684d), new NpgsqlTypes.NpgsqlPoint(x: 0.5655598654834904d, y: 0.3629805711891775d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((65)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.740973861748367d, y: 0.1722480279455637d), new NpgsqlTypes.NpgsqlPoint(x: 0.6800257136437177d, y: 0.1516905589151002d), new NpgsqlTypes.NpgsqlPoint(x: 0.21011471952139715d, y: 0.7565268991187025d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9307353200107314d, y: 0.627161590010346d), new NpgsqlTypes.NpgsqlPoint(x: 0.7917949141434477d, y: 0.6145691807871473d), new NpgsqlTypes.NpgsqlPoint(x: 0.9641984122613042d, y: 0.36620962573236293d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8528296050778319d, y: 0.6741637091681683d), new NpgsqlTypes.NpgsqlPoint(x: 0.746306806666577d, y: 0.5669791830198243d), new NpgsqlTypes.NpgsqlPoint(x: 0.8149139541778871d, y: 0.5921544023343435d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8654852926417764d, y: 0.31033739667879645d), new NpgsqlTypes.NpgsqlPoint(x: 0.008868523337665968d, y: 0.15174936397670113d), new NpgsqlTypes.NpgsqlPoint(x: 0.34298086859941557d, y: 0.31824747774212514d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((107)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05255287777552198d, y: 0.40373864018963446d), new NpgsqlTypes.NpgsqlPoint(x: 0.556898177210054d, y: 0.8665644409326728d), new NpgsqlTypes.NpgsqlPoint(x: 0.5550181430720145d, y: 0.30705299181354995d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((73)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6734993920479363d, y: 0.8861998703260131d), new NpgsqlTypes.NpgsqlPoint(x: 0.369465206000243d, y: 0.4572556738586008d), new NpgsqlTypes.NpgsqlPoint(x: 0.5722035865403604d, y: 0.176112590355605d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6545952765484444d, y: 0.941422973383447d), new NpgsqlTypes.NpgsqlPoint(x: 0.06411121483144366d, y: 0.8650268983777377d), new NpgsqlTypes.NpgsqlPoint(x: 0.5174569102613277d, y: 0.5848014912001167d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5295349316532671d, y: 0.31952708350712955d), new NpgsqlTypes.NpgsqlPoint(x: 0.9091033818464792d, y: 0.33794687131285395d), new NpgsqlTypes.NpgsqlPoint(x: 0.6257693958563564d, y: 0.15098818797341151d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17927071905240588d, y: 0.5073526267581882d), new NpgsqlTypes.NpgsqlPoint(x: 0.13655018642472383d, y: 0.06507110349321499d), new NpgsqlTypes.NpgsqlPoint(x: 0.23985036786447778d, y: 0.2818879702126267d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((78)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3464296330254022d, y: 0.2746415621288768d), new NpgsqlTypes.NpgsqlPoint(x: 0.2686999207023666d, y: 0.37669090591695464d), new NpgsqlTypes.NpgsqlPoint(x: 0.22316253251413865d, y: 0.5785992304905915d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((123)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5705376005472131d, y: 0.6777525655762918d), new NpgsqlTypes.NpgsqlPoint(x: 0.049707759274746466d, y: 0.8390359769917024d), new NpgsqlTypes.NpgsqlPoint(x: 0.5010332918905597d, y: 0.6016600643451652d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22964680893570721d, y: 0.671003821324133d), new NpgsqlTypes.NpgsqlPoint(x: 0.8372362425266333d, y: 0.5419083152402465d), new NpgsqlTypes.NpgsqlPoint(x: 0.7897960352798842d, y: 0.06508720861366346d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17033105037848773d, y: 0.19462382572250014d), new NpgsqlTypes.NpgsqlPoint(x: 0.49865799955008905d, y: 0.6626552290497156d), new NpgsqlTypes.NpgsqlPoint(x: 0.6390499488940113d, y: 0.09936386016432042d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5161321066342638d, y: 0.34257561678649096d), new NpgsqlTypes.NpgsqlPoint(x: 0.8794527111617173d, y: 0.001043262320685967d), new NpgsqlTypes.NpgsqlPoint(x: 0.6854084521569092d, y: 0.6984327375583704d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((135)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3764847452469334d, y: 0.3726078701775698d), new NpgsqlTypes.NpgsqlPoint(x: 0.8008371108512473d, y: 0.38774405650199284d), new NpgsqlTypes.NpgsqlPoint(x: 0.6359327304008894d, y: 0.3933735443849401d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08887770392234895d, y: 0.7628957862210329d), new NpgsqlTypes.NpgsqlPoint(x: 0.37120732583250016d, y: 0.7025407914943472d), new NpgsqlTypes.NpgsqlPoint(x: 0.2659510940201605d, y: 0.20011384138977362d)))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((138)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.759000530589929d, y: 0.8184103734888876d), new NpgsqlTypes.NpgsqlPoint(x: 0.12018275939254186d, y: 0.30281657486719427d), new NpgsqlTypes.NpgsqlPoint(x: 0.07228116497330772d, y: 0.4380820896700697d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((86)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8934265068910956d, y: 0.5747391195677275d), new NpgsqlTypes.NpgsqlPoint(x: 0.09354192132432104d, y: 0.12885128536450352d), new NpgsqlTypes.NpgsqlPoint(x: 0.5099360054254544d, y: 0.24015370608736075d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3217356815260014d, y: 0.3727751681202215d), new NpgsqlTypes.NpgsqlPoint(x: 0.955838384868242d, y: 0.7299031244246565d), new NpgsqlTypes.NpgsqlPoint(x: 0.658650028915513d, y: 0.01791406915505689d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6550058651759463d, y: 0.3885814083001702d), new NpgsqlTypes.NpgsqlPoint(x: 0.7781521584631059d, y: 0.5620464083197001d), new NpgsqlTypes.NpgsqlPoint(x: 0.3420632614800233d, y: 0.515188912929457d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((149)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8434751012213995d, y: 0.34732835019725805d), new NpgsqlTypes.NpgsqlPoint(x: 0.2570437705862725d, y: 0.42827712811694063d), new NpgsqlTypes.NpgsqlPoint(x: 0.8932174859819378d, y: 0.8556986741024213d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((89)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.012414824777664868d, y: 0.46806933948310414d), new NpgsqlTypes.NpgsqlPoint(x: 0.09276040204124447d, y: 0.004767050123645755d), new NpgsqlTypes.NpgsqlPoint(x: 0.002441877284527272d, y: 0.9795985506656033d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8809342676395575d, y: 0.8246479797846835d), new NpgsqlTypes.NpgsqlPoint(x: 0.8690903708609123d, y: 0.7101703570803172d), new NpgsqlTypes.NpgsqlPoint(x: 0.08746134940638972d, y: 0.735640319361848d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpath0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
FROM public.binary_npgsqlpathpath0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpath0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPathSingleTypepath)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPathSingleTypepath)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPathSingleTypepath)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpath0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpath0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
FROM public.binary_npgsqlpathpath0m m
LEFT JOIN public.binary_npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpath0M>(15);

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
                ((INpgsqlPathSingleTypepath)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPathpath0M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpath0M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpath0M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpath0M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpath0M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpath0M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpath0M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpath0M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpath0M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpath0M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpath0M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpath0M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpath0M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpath0M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpath0M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPathSingleTypepath)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPathSingleTypepath)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPathpath0M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpath0M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpath0M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpath0M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpath0M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpath0M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpath0M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpath0M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpath0M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpath0M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpath0M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpath0M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpath0M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpath0M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpath0M.AssertModel(models[14],_testData[14], false);
                NpgsqlPathpath0M.AssertModel(models[15],_testData[15], false);
                NpgsqlPathpath0M.AssertModel(models[16],_testData[16], false);
                NpgsqlPathpath0M.AssertModel(models[17],_testData[17], false);
                NpgsqlPathpath0M.AssertModel(models[18],_testData[18], false);
                NpgsqlPathpath0M.AssertModel(models[19],_testData[19], false);
                NpgsqlPathpath0M.AssertModel(models[20],_testData[20], false);
                NpgsqlPathpath0M.AssertModel(models[21],_testData[21], false);
                NpgsqlPathpath0M.AssertModel(models[22],_testData[22], false);
                NpgsqlPathpath0M.AssertModel(models[23],_testData[23], false);
                NpgsqlPathpath0M.AssertModel(models[24],_testData[24], false);
                NpgsqlPathpath0M.AssertModel(models[25],_testData[25], false);
                NpgsqlPathpath0M.AssertModel(models[26],_testData[26], false);
                NpgsqlPathpath0M.AssertModel(models[27],_testData[27], false);
                NpgsqlPathpath0M.AssertModel(models[28],_testData[28], false);
                NpgsqlPathpath0M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpath0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpath0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathSingleTypepath)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpath0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathSingleTypepath)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpath0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpath0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathSingleTypepath)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathSingleTypepath)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

