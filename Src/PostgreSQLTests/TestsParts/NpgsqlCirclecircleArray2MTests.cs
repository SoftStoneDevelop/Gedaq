

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
    Id = 2,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19410236922057345d, y: 0.3261973898554724d), radius: 0.718426843526696d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21618203277641013d, y: 0.5646533204284566d), radius: 0.3136516523769307d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25969710469164975d, y: 0.20199166023320037d), radius: 0.08862105847637114d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.584159006019249d, y: 0.021023009189427566d), radius: 0.48907442130609735d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7917918654441709d, y: 0.6195366715219573d), radius: 0.44535341219905644d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.030556882611546765d, y: 0.08444481317567987d), radius: 0.5134603566964349d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35939363650611134d, y: 0.9512872506463449d), radius: 0.9622272064146341d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10264386802620473d, y: 0.035867455426866424d), radius: 0.486148950901786d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5623741918334741d, y: 0.7273346378157761d), radius: 0.02253858670237252d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3104466911968735d, y: 0.6347063902288516d), radius: 0.5773080791717093d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26954774924708d, y: 0.48734165759730697d), radius: 0.3804865804276103d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4383064527326219d, y: 0.011044319788414358d), radius: 0.8324133946507504d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.168377114534082d, y: 0.14240634767538896d), radius: 0.8096630676161997d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20065559914992592d, y: 0.7762788502704611d), radius: 0.8006437944307716d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5287766374867361d, y: 0.8391192058872803d), radius: 0.9937952668953063d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37649950649699115d, y: 0.9660614072521518d), radius: 0.9078168092256861d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5941265035857022d, y: 0.7477312763033452d), radius: 0.9954437304998156d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04181543576487545d, y: 0.22172798884538358d), radius: 0.8286545607818758d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6601986297058587d, y: 0.7133608039019688d), radius: 0.40394559250196094d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4345296739619784d, y: 0.45353936440555376d), radius: 0.5685562873741681d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19368097812145835d, y: 0.8697788084722624d), radius: 0.20182114079446012d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9078698794295923d, y: 0.30128052717460696d), radius: 0.405028415050666d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.261975731748017d, y: 0.3108602971888398d), radius: 0.4183224673684076d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.279841094104316d, y: 0.8961076090693623d), radius: 0.16129226535486552d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9721386408643277d, y: 0.5158068061079923d), radius: 0.666977732521442d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8738151001537455d, y: 0.9994513636974685d), radius: 0.03237884191378726d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5238680907034229d, y: 0.29208205984252134d), radius: 0.11818762208671474d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9621135356410365d, y: 0.34231547079256286d), radius: 0.2520986052586235d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2010666005966537d, y: 0.1488800362217243d), radius: 0.6149172837524803d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8367213528672764d, y: 0.2658037500276954d), radius: 0.9908043713008372d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7912662039968046d, y: 0.6299999327380507d), radius: 0.2957209447397373d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9648831150541933d, y: 0.4812850155950026d), radius: 0.4510901578362243d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07915913544677533d, y: 0.5583189848802975d), radius: 0.615092668016827d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7380137050355395d, y: 0.47126609840468026d), radius: 0.5891382595436353d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9085198860656367d, y: 0.18098135577476526d), radius: 0.13011595202471749d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1517357472270503d, y: 0.19706377289829224d), radius: 0.188488796842195d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49963407264342297d, y: 0.2249456176083129d), radius: 0.62323644256846d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6962400997304125d, y: 0.8315386108874054d), radius: 0.7574696403904697d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3992819830736466d, y: 0.12629162456118115d), radius: 0.6916602242801099d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7675777161472469d, y: 0.11940549189434935d), radius: 0.1637481874504375d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7470847562055558d, y: 0.1949057341170033d), radius: 0.2619437520367883d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09411460662995219d, y: 0.5263883600430844d), radius: 0.22968007231442555d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14952691515761074d, y: 0.3978327800451026d), radius: 0.8597063551487486d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08688843223346954d, y: 0.3208940576583639d), radius: 0.2502823826053814d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8438957482882292d, y: 0.64746155035667d), radius: 0.7393643158945199d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5035835185742427d, y: 0.9985289816455485d), radius: 0.5326084325504806d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6347736444405231d, y: 0.5383384669873202d), radius: 0.17962691047451984d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9930236438106913d, y: 0.380531229413579d), radius: 0.2914181828162049d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7874841607979038d, y: 0.9401388905407295d), radius: 0.04900126634103019d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.438709827086853d, y: 0.05789804455309677d), radius: 0.17855926628645868d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7992074740936476d, y: 0.7425822636191711d), radius: 0.3782210941749561d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22316743987366316d, y: 0.252012972346479d), radius: 0.6369572712104412d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8571117458083906d, y: 0.17665214571010446d), radius: 0.5457679445102295d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.501632070996201d, y: 0.7392037326998451d), radius: 0.8118187539915458d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2683233994732821d, y: 0.619711017548553d), radius: 0.5229111364423842d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7193096538612759d, y: 0.3941740131248854d), radius: 0.8923833623297049d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2995306928946426d, y: 0.7361412548011735d), radius: 0.004366634925031754d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7772665970116924d, y: 0.08635038076470403d), radius: 0.5056680694310283d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41120072215736103d, y: 0.3895972145689496d), radius: 0.8349469283044085d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9091889882746087d, y: 0.5170141698523403d), radius: 0.9724119125935019d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06433328697191631d, y: 0.14761739452531664d), radius: 0.00390673133084618d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9517085204032022d, y: 0.1360788470301959d), radius: 0.6003473276083984d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9221996036638923d, y: 0.9392609794967348d), radius: 0.22092011129976874d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5176911962493647d, y: 0.49716936141154566d), radius: 0.13235967404877802d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6616548977050584d, y: 0.5461761723687883d), radius: 0.16965868405795737d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48336858051678255d, y: 0.8398766785310057d), radius: 0.8081850963306865d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7643777050370915d, y: 0.8971278686767399d), radius: 0.3347240919751585d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04777964334966911d, y: 0.01736611261204668d), radius: 0.7191495421284576d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6961340623149479d, y: 0.904189411394916d), radius: 0.25162431223808235d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8043065662181307d, y: 0.06614809417587797d), radius: 0.32878849262435605d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0021447512666353807d, y: 0.7322745548375539d), radius: 0.016840857113908703d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7649347269863743d, y: 0.14017045495266556d), radius: 0.6584200143702309d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27609919100798364d, y: 0.6966684762581065d), radius: 0.7990069841244295d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5216776282992929d, y: 0.6506430675688099d), radius: 0.923955820636106d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6767307108988977d, y: 0.33265537651828536d), radius: 0.557426203708548d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2838938409715527d, y: 0.1077666364272245d), radius: 0.7648390978115533d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30750823935883964d, y: 0.6493667365478263d), radius: 0.46601507282366395d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35156150091465754d, y: 0.08369076459012481d), radius: 0.48904278031734616d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8736513854315678d, y: 0.6592618908542714d), radius: 0.4434287471814089d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8279766334682649d, y: 0.2815263108041103d), radius: 0.6636898350817327d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07963174031995657d, y: 0.32137327491916745d), radius: 0.12081107930336887d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12614163558932678d, y: 0.2891815781992102d), radius: 0.8222661478057601d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26532549222349777d, y: 0.39701508783915196d), radius: 0.4762032357893672d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14302332968687292d, y: 0.17183748226769036d), radius: 0.9084708236584873d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6899857735847974d, y: 0.5736556506407462d), radius: 0.5456766788192218d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1657282876847025d, y: 0.129611182126107d), radius: 0.5490600083804106d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13280433066231578d, y: 0.30383926296095465d), radius: 0.8849790950183499d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7901947745650122d, y: 0.5849981488660878d), radius: 0.7875593196414329d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8087180725961273d, y: 0.5776563788368582d), radius: 0.6633518759633775d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7311450516061954d, y: 0.28360338452885825d), radius: 0.629701451512028d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5426930620045138d, y: 0.9316380740483252d), radius: 0.4490440184471398d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8495034863039884d, y: 0.4759757151902805d), radius: 0.33655331854528403d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16457155572342563d, y: 0.47446535097748177d), radius: 0.40280087532479014d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9319121019808739d, y: 0.7387407268192928d), radius: 0.8890982753970581d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28032445460870714d, y: 0.868552387600297d), radius: 0.8891504965884633d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8642507761927152d, y: 0.7155143202018012d), radius: 0.5022896634935029d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1959877256663295d, y: 0.4214634061035123d), radius: 0.1730400717219862d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7215068676761275d, y: 0.28784040171107694d), radius: 0.8806064087043005d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07957211388082386d, y: 0.8060729731185606d), radius: 0.7458822084361515d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.770608651244427d, y: 0.11347885855078599d), radius: 0.5078336114333034d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09813160464958248d, y: 0.08011701887587319d), radius: 0.9333422031408185d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.023294948931493753d, y: 0.015369900451371987d), radius: 0.9605429909253143d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7994388568086465d, y: 0.6202852748698492d), radius: 0.8117640028938703d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7864195810350963d, y: 0.1389013313273484d), radius: 0.521341682035344d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5314038115065374d, y: 0.06207302712533258d), radius: 0.7990947279916318d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17775207344035182d, y: 0.04706716855244575d), radius: 0.4521129121551587d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6670201073697977d, y: 0.5699920795405551d), radius: 0.6237245603147433d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4495476961130761d, y: 0.2105485457546986d), radius: 0.8322368869398812d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3541713553175766d, y: 0.4514873825886636d), radius: 0.3732262927528598d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29963024349766354d, y: 0.09680933618389198d), radius: 0.17103440369727474d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6815251580299889d, y: 0.9386959518944402d), radius: 0.1245369903759127d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3154327462370664d, y: 0.9652520242480607d), radius: 0.4067226584999588d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6833552646590803d, y: 0.9451803904276393d), radius: 0.5293789970928087d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2752716593543727d, y: 0.9914904964557646d), radius: 0.728072751479407d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5343856610817205d, y: 0.8240191936398257d), radius: 0.7345259373643048d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25836893519577064d, y: 0.7134861437735602d), radius: 0.20125463654994236d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11177526176231589d, y: 0.3588401864366507d), radius: 0.8064969682455158d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35289533222083425d, y: 0.9132880484913242d), radius: 0.10982947163555123d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14863915184810528d, y: 0.600616087923813d), radius: 0.6621511327838293d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2760540789818452d, y: 0.16886748565440024d), radius: 0.91800685859929d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.352411437120456d, y: 0.18879317446363897d), radius: 0.7635477233459527d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6541157362621894d, y: 0.7706899996299476d), radius: 0.7634172784649477d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7798439111810631d, y: 0.4507408438075705d), radius: 0.6542417706180506d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9643809001952676d, y: 0.18091212951449154d), radius: 0.6928515124210501d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27644143376192487d, y: 0.945209150512912d), radius: 0.2685811637437253d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47400385968997916d, y: 0.8499286396456862d), radius: 0.7251402572702047d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4134694232570948d, y: 0.3875773419771772d), radius: 0.7006357939788747d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8185266839183399d, y: 0.2073976409719227d), radius: 0.7067346043955909d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7214481909782483d, y: 0.2031798173133731d), radius: 0.6729041623294139d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7477563364282074d, y: 0.21421723137029958d), radius: 0.43180615988793525d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08020433676781147d, y: 0.4373608895843104d), radius: 0.4855253656953733d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1644040871578374d, y: 0.5996751995643225d), radius: 0.6787779355276264d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29554430489836625d, y: 0.33835824627653155d), radius: 0.39714710987548163d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8422822906436612d, y: 0.6901084620790456d), radius: 0.8824775022863776d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4595006663835626d, y: 0.9318091139752417d), radius: 0.2719460349628833d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5371258436234181d, y: 0.6418634994466998d), radius: 0.6721463890750653d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2946658777305816d, y: 0.18454356469882804d), radius: 0.34038410308342626d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05908610773063505d, y: 0.9743305668704677d), radius: 0.9682248155797294d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5166207055531068d, y: 0.6388254505300939d), radius: 0.44984358745085096d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8232507908016558d, y: 0.3705804463704574d), radius: 0.20264441220471252d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5307871539072273d, y: 0.9731507101415873d), radius: 0.27197397410313096d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2928267992626399d, y: 0.24299099703225946d), radius: 0.9965521080316254d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3601529890306653d, y: 0.13123995448128134d), radius: 0.09784762864458285d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18642701482821877d, y: 0.4771685642598712d), radius: 0.946987249809734d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04123956141532725d, y: 0.8563608413865959d), radius: 0.16013498167028717d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44821547433834397d, y: 0.48393055497809334d), radius: 0.7867960454159446d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.488416351348399d, y: 0.9392356781634642d), radius: 0.6862218868965488d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30097402326107847d, y: 0.8087182292711449d), radius: 0.9069554011666532d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3548904154836092d, y: 0.36373453758558616d), radius: 0.5154473906729388d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16034327350848365d, y: 0.20553787667296863d), radius: 0.02114285588349274d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14798934546272324d, y: 0.6013840419405974d), radius: 0.06290459573742513d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7211027093493975d, y: 0.6888303205868885d), radius: 0.4983195916050712d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1610373439981434d, y: 0.9668814635025162d), radius: 0.8996553922683763d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6325280068281173d, y: 0.7393392929274125d), radius: 0.28625198588781253d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6444255008726221d, y: 0.5736863609314315d), radius: 0.8049211632021872d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3654972989470383d, y: 0.4096368346960554d), radius: 0.8680011006216349d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0849481002228627d, y: 0.5051038170928258d), radius: 0.2995107698074d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5362279889517995d, y: 0.3273649120460004d), radius: 0.6122778849083477d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22602088727884262d, y: 0.9654532565752344d), radius: 0.4015551424597832d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6368514942785926d, y: 0.6487521679974723d), radius: 0.797938114895248d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.007768942437007764d, y: 0.7603855494742158d), radius: 0.5486884364726519d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8649701401850547d, y: 0.30836715605059695d), radius: 0.650629872347681d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8562353218870477d, y: 0.9737516267999362d), radius: 0.28137678775719466d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3344603051073597d, y: 0.4365748230572699d), radius: 0.42867946319800254d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13780886928660918d, y: 0.9520032062469901d), radius: 0.11801717854739135d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7625429024611288d, y: 0.1298015472484917d), radius: 0.5909656444520383d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 108,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8981260969501723d, y: 0.203595256080766d), radius: 0.2498236466815018d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7065729436218866d, y: 0.11498110323061228d), radius: 0.1228029614077315d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8236469663828956d, y: 0.6603457906714308d), radius: 0.9692489300406472d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6586023259150986d, y: 0.32165234711699575d), radius: 0.25721875390516535d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42240133934687774d, y: 0.8782835798590293d), radius: 0.6376978485854506d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27928857122540096d, y: 0.23405935887579699d), radius: 0.4584192541115536d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.024086722789500192d, y: 0.7050031964494099d), radius: 0.6020321592723371d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5587837655569694d, y: 0.647585897235987d), radius: 0.3465662454594173d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7805479218511611d, y: 0.9013143009661801d), radius: 0.6184895650744975d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8235076480298554d, y: 0.1647262807604154d), radius: 0.7739871618387658d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2573553864393987d, y: 0.9173810475757002d), radius: 0.5402496762514186d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8435609345505299d, y: 0.6055050417730038d), radius: 0.222810602739543d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9266145876961858d, y: 0.2734223671435172d), radius: 0.44980625928722706d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4750581402068603d, y: 0.4894379037366918d), radius: 0.14350437361069068d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9260602423244729d, y: 0.7498782269561062d), radius: 0.5967064176024133d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48275079081769134d, y: 0.8533406331771657d), radius: 0.6918841721709762d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7278585402397995d, y: 0.808733993625128d), radius: 0.12483814996450304d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18028839822881293d, y: 0.03493061159341404d), radius: 0.1320817957006024d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4258454416545928d, y: 0.618019973652514d), radius: 0.39130171786824186d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22707448405647157d, y: 0.5863995036718724d), radius: 0.7168598598805036d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6164398525004114d, y: 0.5329283010249157d), radius: 0.05098838077484302d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3141865305530638d, y: 0.690943367104857d), radius: 0.19147085575758838d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1996440606653045d, y: 0.9969719109690042d), radius: 0.7151131314673602d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9626375495567927d, y: 0.61980500874085d), radius: 0.31399957391862576d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8196299661768356d, y: 0.072457652116805d), radius: 0.737282846869464d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5285055967419627d, y: 0.9644648017674672d), radius: 0.44949204110616636d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20551891795460864d, y: 0.0318696060606829d), radius: 0.33976568051749423d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5209451444944556d, y: 0.401405802633266d), radius: 0.2219699266025511d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5866915068816861d, y: 0.48329353037065625d), radius: 0.7222805541545037d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11549396221976271d, y: 0.32087791081701245d), radius: 0.6833382195601454d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1731015216327717d, y: 0.7832847438494396d), radius: 0.8708251380066475d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5295761592878361d, y: 0.6996216851409106d), radius: 0.5488949109336401d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24080475684115032d, y: 0.06354022376888635d), radius: 0.039739986996585985d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11336670490193423d, y: 0.9228339567847994d), radius: 0.44831743701684845d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38321884576813003d, y: 0.14498578191146827d), radius: 0.5195836619849826d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18392821508773205d, y: 0.23034270262610168d), radius: 0.0097261884821358d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31359388371670205d, y: 0.5218823283092996d), radius: 0.9271750297142037d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.137645771540286d, y: 0.6016960660748999d), radius: 0.3686995653620704d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6193330720144873d, y: 0.6000267254880824d), radius: 0.7992757017336642d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7634192785995539d, y: 0.3424789905200367d), radius: 0.4499099270057364d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9906158321329761d, y: 0.5664791821971057d), radius: 0.1866303810485097d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6238010202721823d, y: 0.9334416231327523d), radius: 0.407313461412651d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9220156402128883d, y: 0.04147425760534473d), radius: 0.9699566356171481d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9648150154022408d, y: 0.032189243762148045d), radius: 0.5812702282864581d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03941357849748972d, y: 0.25285503864906045d), radius: 0.7121156006448133d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.914879973806511d, y: 0.4175372809246207d), radius: 0.12589514740346042d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47485724670282803d, y: 0.03325984600223875d), radius: 0.25745514708910133d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.642285800941138d, y: 0.7533483383672291d), radius: 0.7034220899837654d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1623010681276158d, y: 0.40232584513814995d), radius: 0.30730439633059115d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8806671195390058d, y: 0.8956765624599682d), radius: 0.2201756366994585d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29094511083947594d, y: 0.5377569193650711d), radius: 0.36439586240573885d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1968984634050387d, y: 0.6000042089549454d), radius: 0.6454462188144773d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6124450484723317d, y: 0.8860798621185376d), radius: 0.6891979031008807d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9946277517682877d, y: 0.7996363061446116d), radius: 0.864268897672446d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9838895355662054d, y: 0.07859003936626563d), radius: 0.39819489480125736d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8830307223482909d, y: 0.8337602600475851d), radius: 0.23036045131934635d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.016292318638058467d, y: 0.7065364131568467d), radius: 0.9741409112268915d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22670976813838561d, y: 0.7226792275558392d), radius: 0.022615342600209587d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23910797225640312d, y: 0.864689314316399d), radius: 0.47297686723596666d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14769568760445984d, y: 0.18170011546427955d), radius: 0.8255440434496497d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3840453389547157d, y: 0.8220421572788724d), radius: 0.9290771986088779d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07015814206679838d, y: 0.888135697470816d), radius: 0.08252348992613212d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6300916076446617d, y: 0.06427690489608184d), radius: 0.4625013893916454d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2430412089770384d, y: 0.3402203444728843d), radius: 0.13885765615823953d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2039569283028646d, y: 0.851445382132451d), radius: 0.8564213751077495d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6735816486850814d, y: 0.14098079634297667d), radius: 0.04538923574568776d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.635631860078437d, y: 0.22636113828509452d), radius: 0.5548906708029883d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6819421586577408d, y: 0.1664981846275143d), radius: 0.8442840813722576d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9672647434689855d, y: 0.5096008254742836d), radius: 0.45901990300317996d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5235342033951093d, y: 0.5187813368823131d), radius: 0.5216655609631965d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8382764814667645d, y: 0.37350012701655344d), radius: 0.47055863911961127d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7587979914047498d, y: 0.08747106455615916d), radius: 0.5675985059814087d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22255361461085d, y: 0.8442071152045031d), radius: 0.22026173351694056d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6345554532208703d, y: 0.0788489415264656d), radius: 0.6629128453951356d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8030188406914164d, y: 0.7414872680330008d), radius: 0.646747724101085d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9215409045378509d, y: 0.743910289861843d), radius: 0.40494532260246974d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 160,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29604850134916594d, y: 0.7449346022294661d), radius: 0.8526922126001288d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23295540310919682d, y: 0.6514589221069625d), radius: 0.5078020776562094d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45550543300050705d, y: 0.456549848819341d), radius: 0.7317969227330461d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9242707539865096d, y: 0.8864024800350574d), radius: 0.8529351015723796d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5505175872386533d, y: 0.717916937280687d), radius: 0.5609463325709525d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5349467450195761d, y: 0.3979482969933138d), radius: 0.6400202047837855d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30613874287745146d, y: 0.3668451751410692d), radius: 0.5550566582578731d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18579627064280613d, y: 0.04499668736119544d), radius: 0.23273990714455062d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.153329254925877d, y: 0.5066781927404701d), radius: 0.7816200778867102d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8003295729340477d, y: 0.17155149610915954d), radius: 0.7748633265032941d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38455215457423664d, y: 0.3991076047279891d), radius: 0.8211999411547468d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7443666944077251d, y: 0.24921541302752725d), radius: 0.603968681726219d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.006917585160932438d, y: 0.34229291906151904d), radius: 0.6562244804070105d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 164,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32584334036083473d, y: 0.24881729223850158d), radius: 0.6116604298163897d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5813185483740881d, y: 0.912788930784211d), radius: 0.5921352057288868d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9076725869509716d, y: 0.9710715884375355d), radius: 0.6267190456203524d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 167,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6582093018286845d, y: 0.5423874642562326d), radius: 0.7322119306962327d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6609432811818844d, y: 0.9068302547690363d), radius: 0.5087799478670889d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23486587288262806d, y: 0.24847452157907823d), radius: 0.3753467129521997d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5681781801942657d, y: 0.3504566060208565d), radius: 0.755016280383384d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9397667061953783d, y: 0.6704246572507d), radius: 0.29651292330786283d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5931657458472865d, y: 0.7652277648500276d), radius: 0.37540118527401867d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.00806495142268937d, y: 0.9235000150918447d), radius: 0.47102991420597773d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6802566236527195d, y: 0.11905715483246115d), radius: 0.8010443746777086d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9947023072801782d, y: 0.9197732596148169d), radius: 0.18029817017144723d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8350287460621877d, y: 0.5204877903250783d), radius: 0.1285806457142239d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8903794985241615d, y: 0.8885648577133929d), radius: 0.12219948249527934d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 168,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.835690337661648d, y: 0.4453173572424285d), radius: 0.07422675891711972d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37755541868652964d, y: 0.11698727950940035d), radius: 0.5241908491810596d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7287369973136769d, y: 0.695002206502671d), radius: 0.17850046373380402d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23686855262377782d, y: 0.5335378559198122d), radius: 0.32877669694462297d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 175,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4560673491328291d, y: 0.9157711024349742d), radius: 0.6749686160402573d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38650985302577d, y: 0.8752224031149055d), radius: 0.6150118075608407d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8427114067266354d, y: 0.15220206445865847d), radius: 0.9109666899289397d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2537582918445216d, y: 0.5795935775075334d), radius: 0.33091671311161286d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45245068176866765d, y: 0.9354810213428091d), radius: 0.5607330882798438d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.457306143533049d, y: 0.32816529784163817d), radius: 0.907590565429674d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4023909551839473d, y: 0.561262686841529d), radius: 0.3657522692347285d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7584164093208621d, y: 0.10050096571068634d), radius: 0.20624719724072427d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9075977612494511d, y: 0.4562476870677368d), radius: 0.7271307994298454d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9425327459519687d, y: 0.14961449850938646d), radius: 0.6622057159204267d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22537470587283737d, y: 0.07844733837683815d), radius: 0.2860965824508064d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5391566537128542d, y: 0.4761929882721472d), radius: 0.3871183233026596d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray2M
{
    Id = 178,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9702308328872288d, y: 0.2484348180075684d), radius: 0.09669559909324554d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41178063944518284d, y: 0.8927407615959049d), radius: 0.5415131554229202d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9152847101952174d, y: 0.5263147846212897d), radius: 0.20785046944983043d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.948051265845592d, y: 0.47177890763163677d), radius: 0.593740650742964d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.002504838383267205d, y: 0.06291309795070754d), radius: 0.6820475620086472d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5342533930311901d, y: 0.9908497064492997d), radius: 0.5899945687242827d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5721497632541602d, y: 0.1703529206590334d), radius: 0.6159652815308535d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 184,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6960959870609491d, y: 0.24944935326103912d), radius: 0.7523334384176329d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3938042729127641d, y: 0.6695262834428943d), radius: 0.9261228095178384d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7392894988135356d, y: 0.4144706268182665d), radius: 0.0903180644381798d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1427053366119423d, y: 0.9438958890627446d), radius: 0.9981895901363599d),

},
    ModelInner = new NpgsqlCirclecircleArray2MI
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.291096063947184d, y: 0.8781293581999328d), radius: 0.5587889309244539d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9744523173947841d, y: 0.4206828357757626d), radius: 0.8599139189935913d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.564057793010259d, y: 0.08545752334159762d), radius: 0.24473866838934266d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5087624917492221d, y: 0.29101860254857825d), radius: 0.5299021025584548d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.808509246910729d, y: 0.8473725544517865d), radius: 0.738117510242976d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7832442845037005d, y: 0.626392833862925d), radius: 0.05242278506182663d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09350569417578414d, y: 0.8831541373739386d), radius: 0.7726321391555068d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3390979701939737d, y: 0.27572793375648996d), radius: 0.5343261296050111d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2068819236767252d, y: 0.20519152876368085d), radius: 0.31634988260574526d),

},
},
            new NpgsqlCirclecircleArray2M
{
    Id = 186,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35183139514380823d, y: 0.46511340070219553d), radius: 0.672745381698281d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41279767523772837d, y: 0.5657576279205266d), radius: 0.19360082953315894d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5430878235170307d, y: 0.15131121955889693d), radius: 0.1659898849924183d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5152396641703819d, y: 0.12846080859009745d), radius: 0.7876787195157148d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22058012323781961d, y: 0.35936949542652996d), radius: 0.728266048553229d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6179708006193644d, y: 0.7305871856706465d), radius: 0.04592936255648106d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.571396963960967d, y: 0.8450058617901829d), radius: 0.13507563831027047d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19798842786500404d, y: 0.7542069562701129d), radius: 0.00736583296019977d),

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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 175;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[34], false);
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
                parametr2.Value = 178;
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
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                parametr1.Value = 2;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
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
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[34], false);
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
                parametr2.Value = 2;
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
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 2;
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
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 87;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[25],_testData[34], false);
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
                parametr1.Value = 29;
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
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[34], false);
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
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
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
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[20],_testData[34], false);
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
                parametr1.Value = 164;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
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
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[8], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[9], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[10], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[11], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[12], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[13], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[14], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                await ((INpgsqlCircleListcircleArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 64, query1, 71, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[22],_testData[34], false);
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
                await ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 78, query1, 100, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                 ((INpgsqlCircleListcircleArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 140, query1, 133, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[34], false);
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
                 ((INpgsqlCircleListcircleArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 36, query1, 160, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 117, query1, 134, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[34], false);
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
                await ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 78, query1, 55, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[25],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 55, query1, 153, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                 ((INpgsqlCircleListcircleArray)this).DbConnectionDynQuerySelectModelBatch(connection, 100, query1, 160, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlCirclecircleArray2M.AssertModel(secondItems2[6],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelBatchAsync(connection, 86, 12))
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
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[3], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[4], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[5], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[6], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[7], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[8], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[9], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[10], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[11], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[12], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[13], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[14], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[15], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[16], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[17], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[18], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[19], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[18],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[19],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[20],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[21],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[22],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[23],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[24],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[25],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[26],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[27],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[28],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[29],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[30],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[31],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlCircleListcircleArray)this).DbConnectionSTSelectModelBatch(connection, 108, 148))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[20], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[21], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[22], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[23], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[24], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[25], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[26], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[27], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[28], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[29], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[30], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[31], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[32], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[33], false);
                        NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[34], false);
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
                ((INpgsqlCircleListcircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 95);
                var models = await ((INpgsqlCircleListcircleArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(18));
NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[17], false);NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[18], false);NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[19], false);NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[20], false);NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[21], false);NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[22], false);NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[23], false);NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[24], false);NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[25], false);NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[26], false);NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[27], false);NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[28], false);NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[29], false);NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[30], false);NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[31], false);NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[32], false);NpgsqlCirclecircleArray2M.AssertModel(models[16],_testData[33], false);NpgsqlCirclecircleArray2M.AssertModel(models[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleListcircleArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleListcircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 100);
                var models =  ((INpgsqlCircleListcircleArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(16));
NpgsqlCirclecircleArray2M.AssertModel(models[0],_testData[19], false);NpgsqlCirclecircleArray2M.AssertModel(models[1],_testData[20], false);NpgsqlCirclecircleArray2M.AssertModel(models[2],_testData[21], false);NpgsqlCirclecircleArray2M.AssertModel(models[3],_testData[22], false);NpgsqlCirclecircleArray2M.AssertModel(models[4],_testData[23], false);NpgsqlCirclecircleArray2M.AssertModel(models[5],_testData[24], false);NpgsqlCirclecircleArray2M.AssertModel(models[6],_testData[25], false);NpgsqlCirclecircleArray2M.AssertModel(models[7],_testData[26], false);NpgsqlCirclecircleArray2M.AssertModel(models[8],_testData[27], false);NpgsqlCirclecircleArray2M.AssertModel(models[9],_testData[28], false);NpgsqlCirclecircleArray2M.AssertModel(models[10],_testData[29], false);NpgsqlCirclecircleArray2M.AssertModel(models[11],_testData[30], false);NpgsqlCirclecircleArray2M.AssertModel(models[12],_testData[31], false);NpgsqlCirclecircleArray2M.AssertModel(models[13],_testData[32], false);NpgsqlCirclecircleArray2M.AssertModel(models[14],_testData[33], false);NpgsqlCirclecircleArray2M.AssertModel(models[15],_testData[34], false);
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
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MIWA)],
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
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleListcircleArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
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
                var models = ((INpgsqlCircleListcircleArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclearray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
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
COPY public.binary_npgsqlcirclecirclearray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray2MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleListcircleArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
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
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlCircleListcircleArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

