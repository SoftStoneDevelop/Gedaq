

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
    internal partial interface INpgsqlPointListpointArray
    {
    }
    
    internal partial class NpgsqlPointListpointArray : INpgsqlPointListpointArray
    {


#region TestData

        private readonly NpgsqlPointpointArray2M[] _testData = new NpgsqlPointpointArray2M[]
        {
            new NpgsqlPointpointArray2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.04020163704155233d, y: 0.1813578391289885d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5216840484236731d, y: 0.872693166304138d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5556803177787104d, y: 0.9449688124151411d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8164915830414101d, y: 0.7065686729836949d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6821913205123155d, y: 0.9942818491498338d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6227838449052481d, y: 0.02633089218821616d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.15687613167410575d, y: 0.13668230529983716d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11920100729311311d, y: 0.9400899411670668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10745532421877713d, y: 0.6850678238233446d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6217898960252265d, y: 0.5476943306753376d),

new NpgsqlTypes.NpgsqlPoint(x: 0.012259150331997204d, y: 0.555399567548203d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5749325593426792d, y: 0.905681648355594d),

new NpgsqlTypes.NpgsqlPoint(x: 0.39989358771328876d, y: 0.952069123568135d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2822858819281805d, y: 0.5576593117061721d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8060835999897136d, y: 0.6297366326159975d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22373655250770164d, y: 0.9270696700430572d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5438994845787936d, y: 0.5057891394797384d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46850340765382203d, y: 0.6550544572119439d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9242724859665505d, y: 0.560036379957117d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7738774607659169d, y: 0.12959837563165288d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2952784842100763d, y: 0.3932364620805847d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.05046443999644368d, y: 0.1346179492276529d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0005158141657493065d, y: 0.9683174744734706d),

new NpgsqlTypes.NpgsqlPoint(x: 0.28913707135124334d, y: 0.20082219231747855d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20060554416337972d, y: 0.007322279162741752d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8459676808010274d, y: 0.6036616249081745d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9783274355843246d, y: 0.9315822158651256d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6443606762971559d, y: 0.6595543744665376d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19132710838825107d, y: 0.7944372339720934d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9909905295436824d, y: 0.5644489672975879d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4229396414301515d, y: 0.23423249454365547d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3574173096065125d, y: 0.7750791966786992d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6597962228674082d, y: 0.177713821931773d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3068449195753493d, y: 0.5729517492900131d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17284936377935844d, y: 0.5578052207449642d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6075776735296494d, y: 0.12196544922722419d),

new NpgsqlTypes.NpgsqlPoint(x: 2.1350502287575956E-05d, y: 0.25253696963745753d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7972405359825505d, y: 0.631383242019862d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20925538566868207d, y: 0.09468550705370571d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3212660565694595d, y: 0.6391261620568055d),

new NpgsqlTypes.NpgsqlPoint(x: 0.39098560578520636d, y: 0.7925538662849484d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8509760888008716d, y: 0.5172322344323896d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8338939798400873d, y: 0.8389411821954041d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17654697064738767d, y: 0.9890565741487625d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7022900336288234d, y: 0.854448567568609d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6782739027341259d, y: 0.03070689090226897d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7643482973364866d, y: 0.010878977649872001d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7594453655980077d, y: 0.18049068141804914d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19085417131906857d, y: 0.15750669549620389d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5327046778152509d, y: 0.5970841008105554d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6824494432407217d, y: 0.49159728181507d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6363477672244159d, y: 0.23150450930896505d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9192943899543303d, y: 0.8740974732714463d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5530827613006571d, y: 0.039602354349051794d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4789307642704286d, y: 0.18214594277836704d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1413101698089254d, y: 0.5922093138905119d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9781231223792074d, y: 0.713920402382764d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6577188869930352d, y: 0.36903877633959203d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.44510911382202156d, y: 0.4868040769084846d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9416525843830964d, y: 0.1141123983750788d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17343496817782178d, y: 0.20285727006096865d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9718980225303525d, y: 0.840018248545782d),

new NpgsqlTypes.NpgsqlPoint(x: 0.25595442094898535d, y: 0.3452629804019641d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2837032834326456d, y: 0.7168847503007288d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.49804543808756174d, y: 0.8910330075605563d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06422929127432941d, y: 0.5078017200761432d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9716379043799414d, y: 0.8604438720563456d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2840645347118078d, y: 0.8502136494309693d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.23844800047353787d, y: 0.16195125862052817d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12539151894226308d, y: 0.7477446157029961d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20835815950260883d, y: 0.05579986894259603d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.060604631234434825d, y: 0.6718086976029373d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9981519250802441d, y: 0.6508972159344717d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2090348555502115d, y: 0.08367537713755291d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1089931521142381d, y: 0.3632554201840238d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9485929095184793d, y: 0.841737496033126d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18326203420362253d, y: 0.6107836655646368d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6250724495789256d, y: 0.6932440590543446d),

new NpgsqlTypes.NpgsqlPoint(x: 0.90944439006486d, y: 0.5157753619987411d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08749659198365112d, y: 0.3994221351878715d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7308156788563142d, y: 0.6609412735784905d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8759288567343773d, y: 0.566498901081704d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8560174945648115d, y: 0.7847865582421483d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.26618418552534195d, y: 0.60307561351448d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7084416135001693d, y: 0.3590254456533398d),

new NpgsqlTypes.NpgsqlPoint(x: 0.30214341055720095d, y: 0.5679323447797301d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19285546496410855d, y: 0.8795917410796334d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5786492040074241d, y: 0.12945547763119758d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2974569480581274d, y: 0.7376724816932013d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5289240904370925d, y: 0.833286158010843d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09970313214761883d, y: 0.8327775423306869d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5021866351003468d, y: 0.7584910409173857d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2092325484582257d, y: 0.9317941231566184d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9378310144814934d, y: 0.6408379437152797d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3667943383120936d, y: 0.34176352479818695d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1027946082792407d, y: 0.017226295158310756d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9124707599212014d, y: 0.1318585199735518d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5934543061594754d, y: 0.7720223484565611d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6471377439073058d, y: 0.38682520672325316d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6355328015382045d, y: 0.3346304086526607d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6831513744058405d, y: 0.39481463114544957d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21830623493243573d, y: 0.20993837021305162d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7980669858899033d, y: 0.9349301107388834d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.23021449617198664d, y: 0.9493876679427115d),

new NpgsqlTypes.NpgsqlPoint(x: 0.28523458667756796d, y: 0.744559620809197d),

new NpgsqlTypes.NpgsqlPoint(x: 0.19844800432545628d, y: 0.572922519405456d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5933806297696719d, y: 0.2851719760910416d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5318627460438483d, y: 0.7382096355543697d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9313413453813867d, y: 0.982033890946135d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1206279843655167d, y: 0.1892465442192931d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9637600444462866d, y: 0.9875267501996052d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2797385312563838d, y: 0.14555798591515035d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9135154570443504d, y: 0.3099389519342338d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8244156212222139d, y: 0.9802940474410032d),

new NpgsqlTypes.NpgsqlPoint(x: 0.748694995720164d, y: 0.6144669798555331d),

new NpgsqlTypes.NpgsqlPoint(x: 0.16029324503279996d, y: 0.8728275429576615d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8375906636204473d, y: 0.14996798586304438d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16598976339824356d, y: 0.15333995082344842d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2987980176015559d, y: 0.38189247116828473d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5154134860238153d, y: 0.7005366476960022d),

new NpgsqlTypes.NpgsqlPoint(x: 0.42337682635537677d, y: 0.5468138001677282d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.28925158014918184d, y: 0.24498065293103521d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5574214826292206d, y: 0.957157179277972d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9945063351340413d, y: 0.03480404532795445d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.680491921087899d, y: 0.8683240085537526d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5566481599259434d, y: 0.7664447069710199d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04082314943849774d, y: 0.031257104796380775d),

new NpgsqlTypes.NpgsqlPoint(x: 0.33840852331842597d, y: 0.21566187644762302d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7767905006475027d, y: 0.6726551210417634d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26106688454105753d, y: 0.679000290523546d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24133847198490987d, y: 0.3068537511849877d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9324562576001199d, y: 0.027653636265182024d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.45040761323104495d, y: 0.9216958020773496d),

new NpgsqlTypes.NpgsqlPoint(x: 0.42149443342213855d, y: 0.7901743206279607d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04147214487254314d, y: 0.32359535139752804d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4873020780822489d, y: 0.8654541586301036d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22705523191862065d, y: 0.8042380660207707d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9080520921380868d, y: 0.83508385600493d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.015523935141950052d, y: 0.10986855367663517d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6641222480524833d, y: 0.32060655242025504d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38846488175905614d, y: 0.5468907264153657d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6904330657229919d, y: 0.9377407554819019d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.12013764700386342d, y: 0.7451387562627603d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27262485938364245d, y: 0.29015392548605645d),

new NpgsqlTypes.NpgsqlPoint(x: 0.12762339343394213d, y: 0.7522414084165677d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1723717182939114d, y: 0.3884878075714292d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.11894133130179485d, y: 0.8391412916618979d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45413496048323576d, y: 0.1673509808361171d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03249491506472735d, y: 0.03410228187887676d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7076508722803914d, y: 0.26677791102536097d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9137037875578191d, y: 0.9454967728875322d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08599134948609344d, y: 0.8937893662090576d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4670340760237345d, y: 0.6601666429743295d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.526353876222232d, y: 0.3797216107419418d),

new NpgsqlTypes.NpgsqlPoint(x: 0.42257531107645874d, y: 0.8437777339461928d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9442654502864775d, y: 0.512201956047546d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6367916254801713d, y: 0.47127741332678963d),

new NpgsqlTypes.NpgsqlPoint(x: 0.560836061290829d, y: 0.3164090846498696d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6900727213254366d, y: 0.2869320742481085d),

new NpgsqlTypes.NpgsqlPoint(x: 0.02013089530877321d, y: 0.54131186133469d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6935277486754032d, y: 0.4086725551884973d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8478135409636951d, y: 0.08995733584268084d),

new NpgsqlTypes.NpgsqlPoint(x: 0.63652124032226d, y: 0.910660623878074d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10077709976000304d, y: 0.748413619949154d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8638863560757203d, y: 0.2584019966902912d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5345427557376248d, y: 0.1250153684091777d),

new NpgsqlTypes.NpgsqlPoint(x: 0.28916814021066883d, y: 0.170211748876688d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06639833456598876d, y: 0.8100142913647679d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.29414009821321896d, y: 0.0308466008818169d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5656720798408443d, y: 0.393843391558203d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3827403612113358d, y: 0.4815899168291935d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.00305386269484742d, y: 0.6498705995539489d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3892918300838927d, y: 0.1918141097867908d),

new NpgsqlTypes.NpgsqlPoint(x: 0.39166839784479657d, y: 0.7303039926854628d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2593783945454333d, y: 0.9127856195564408d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5778503487885235d, y: 0.8103182399271457d),

new NpgsqlTypes.NpgsqlPoint(x: 0.47970796229882495d, y: 0.8672946497466868d),

new NpgsqlTypes.NpgsqlPoint(x: 0.675579712866825d, y: 0.8119757155747293d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45101989343289317d, y: 0.8393210244521978d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 119,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7072768477484437d, y: 0.5014285993691955d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9686774900873979d, y: 0.7379764578698073d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7042239604821818d, y: 0.39858792485033234d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9618444063769267d, y: 0.6690569812636917d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10333469859750977d, y: 0.7561515811668632d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6353248377418503d, y: 0.13902196738790717d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17145225379261597d, y: 0.5631449867990108d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14961665613514352d, y: 0.5418735532130814d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9072576442749904d, y: 0.452167991230886d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7637134953359925d, y: 0.9910490428239047d),

new NpgsqlTypes.NpgsqlPoint(x: 0.36226363851309085d, y: 0.5656114857283947d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6850649503948076d, y: 0.943285418469544d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4163924052614052d, y: 0.8265463322709614d),

new NpgsqlTypes.NpgsqlPoint(x: 0.018966787662766715d, y: 0.8943536067408718d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26719200971402757d, y: 0.5094900758631713d),

new NpgsqlTypes.NpgsqlPoint(x: 0.36728561951483574d, y: 0.9089582044817741d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9168538106652351d, y: 0.5141112374377219d),

new NpgsqlTypes.NpgsqlPoint(x: 0.31117670669303077d, y: 0.5804809377731771d),

new NpgsqlTypes.NpgsqlPoint(x: 0.013435076354795239d, y: 0.3037546517674935d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17396238617758164d, y: 0.10716197152282891d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9221480795415431d, y: 0.6242622057884833d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07313675028521094d, y: 0.2122685714109892d),

new NpgsqlTypes.NpgsqlPoint(x: 0.42507666292108237d, y: 0.2170299196289578d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7979455859885392d, y: 0.11905931392529479d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3569136279925793d, y: 0.8679032077889826d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1923271333349591d, y: 0.7890921723972344d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3667902870480426d, y: 0.7151816003355405d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17778499525999403d, y: 0.21744999706415657d),

new NpgsqlTypes.NpgsqlPoint(x: 0.31367845302232533d, y: 0.4705337841801891d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8306503411220153d, y: 0.22294835263249735d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 135,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6148458583371572d, y: 0.7797424193642783d),

new NpgsqlTypes.NpgsqlPoint(x: 0.876798244401895d, y: 0.482064199722786d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8817506423041003d, y: 0.020487840598978013d),

new NpgsqlTypes.NpgsqlPoint(x: 0.26391252991117975d, y: 0.14986255034047857d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9006636230044838d, y: 0.49093256372111393d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3541799953592387d, y: 0.5144069832751771d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5068645515209846d, y: 0.381906850289089d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5273625883074358d, y: 0.14613366849453435d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20386024295556193d, y: 0.7857141626343525d),

new NpgsqlTypes.NpgsqlPoint(x: 0.38705943517469665d, y: 0.4299375076315136d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8787258801024067d, y: 0.44865202180923114d),

new NpgsqlTypes.NpgsqlPoint(x: 0.28125707252305054d, y: 0.18091768327925795d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.327516708659531d, y: 0.08371944419144561d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7439428053935057d, y: 0.7323828961553273d),

new NpgsqlTypes.NpgsqlPoint(x: 0.40409381634153074d, y: 0.19635128964749493d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4562417161055109d, y: 0.7635293063276415d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.405759779307146d, y: 0.5013812139720244d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4353730835488602d, y: 0.6502647970325469d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13735346859547926d, y: 0.23784455432357532d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9000117133403188d, y: 0.0772294106966932d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.24711300211102538d, y: 0.9538909412627772d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5452696979207439d, y: 0.350041982299797d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5567116709244391d, y: 0.28596126295529734d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9777649671843132d, y: 0.7486357340283143d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.1992029263628584d, y: 0.13622644813043694d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8166395327687604d, y: 0.2821035793751284d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23861657114288326d, y: 0.371790332532389d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0882947659902239d, y: 0.19837901670489633d),

new NpgsqlTypes.NpgsqlPoint(x: 0.02775256016239136d, y: 0.00970599609920475d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7120919971939743d, y: 0.17931546797513698d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3563769249847112d, y: 0.6299849286085761d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 153,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2980509404047764d, y: 0.9808703046893975d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5000235006696813d, y: 0.7116846397782988d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5414630465341652d, y: 0.4855257097127772d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6509683933444496d, y: 0.2077933126780921d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7325491609945468d, y: 0.7151308893752445d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8874099031849829d, y: 0.25849384616156523d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7385914234573097d, y: 0.24670809572874053d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 160,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9366189600921473d, y: 0.053649510481887486d),

new NpgsqlTypes.NpgsqlPoint(x: 0.45844165559815364d, y: 0.037540930544175066d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6533871808327485d, y: 0.7531240385611363d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5989237442631009d, y: 0.8236105942337765d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08806272495214218d, y: 0.0773952573312866d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7904047513719886d, y: 0.9114505149684629d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18423513825835558d, y: 0.5713396921973983d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14791991618904654d, y: 0.2061940619576016d),

new NpgsqlTypes.NpgsqlPoint(x: 0.899814385246315d, y: 0.16997228901860129d),

new NpgsqlTypes.NpgsqlPoint(x: 0.28598146510331723d, y: 0.8659094168198471d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8504723999656167d, y: 0.3172235418200432d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 166,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.28160587840050777d, y: 0.43800831813918295d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2636805685315603d, y: 0.39695994697613546d),

new NpgsqlTypes.NpgsqlPoint(x: 0.612856556358307d, y: 0.9636184168916243d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6090835409188745d, y: 0.3561498854403611d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 168,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3096604713784523d, y: 0.4432109845251395d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8436612228644641d, y: 0.9729547588048598d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9985867917839578d, y: 0.5903867663748935d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6302676788961493d, y: 0.8277031204686306d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2880316383196274d, y: 0.3526096554958912d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7732736765588812d, y: 0.8175010235975964d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 171,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6636822808025229d, y: 0.8168449986601676d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7116526975540522d, y: 0.24199300982216787d),

new NpgsqlTypes.NpgsqlPoint(x: 0.48628876357721695d, y: 0.9879752424356293d),

new NpgsqlTypes.NpgsqlPoint(x: 0.656318354676522d, y: 0.2512761944309416d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4200847267535971d, y: 0.930148104845178d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3562349281556544d, y: 0.4588949239666318d),

new NpgsqlTypes.NpgsqlPoint(x: 0.30216572002881426d, y: 0.14106425832460134d),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2mi(
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2mi(
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
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
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

                changedRows =  ((INpgsqlPointListpointArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointListpointArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPointListpointArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointListpointArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPointListpointArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPointListpointArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray2mi_id
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
            asPartInterface: typeof(INpgsqlPointListpointArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointarray2mi_id", 
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
                changedRows =  ((INpgsqlPointListpointArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPointListpointArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPointListpointArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPointListpointArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray2mi_id
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
    npgsqlpointpointarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray2mi_id
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
    npgsqlpointpointarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointarray2mi_id", 
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
                List<NpgsqlPointpointArray2M> models = null;

                models =  ((INpgsqlPointListpointArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPointListpointArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPointListpointArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPointListpointArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointArray2M> models = null;

                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M), typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                ((INpgsqlPointListpointArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPointListpointArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPointListpointArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await ((INpgsqlPointListpointArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPointListpointArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M), typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                ((INpgsqlPointListpointArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointListpointArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointListpointArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await ((INpgsqlPointListpointArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPointListpointArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M), typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                await((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 135;
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 36;
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 160;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[29],_testData[34], false);
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 94;
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 49;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await((INpgsqlPointListpointArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[10], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[11], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[12], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[13], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[14], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[20],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[21],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[22],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[23],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[24],_testData[34], false);
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
                var models = ((INpgsqlPointListpointArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 160;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M), typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                await((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 7, query1, 128, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 166, query1, 141, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 95, query1, 83, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 146, query1, 135, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 94, query1, 36, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[28],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 93, query1, 36, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 57, query1, 97, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelBatch(connection, 130, query1, 42, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await((INpgsqlPointListpointArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelBatchAsync(connection, 7, 16))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[28],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[29],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[30],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[31],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[32],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[27],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[28],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[29],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[30],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[31],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[32],_testData[34], false);
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
                var models = ((INpgsqlPointListpointArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelBatch(connection, 153, 17))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[3], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[4], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[5], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[6], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[7], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[8], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[9], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[10], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[11], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[12], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[13], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[14], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[20],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[21],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[22],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[23],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[24],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[25],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[26],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[27],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[28],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[29],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[30],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[31],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPointListpointArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPointListpointArray)this).SetDbConnectionSelectModelParametrs(cmd, 77);
                var models = await ((INpgsqlPointListpointArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(22));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[13], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[14], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[15], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[16], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[17], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[18], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[11],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[12],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[13],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[14],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[15],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[16],_testData[29], false);NpgsqlPointpointArray2M.AssertModel(models[17],_testData[30], false);NpgsqlPointpointArray2M.AssertModel(models[18],_testData[31], false);NpgsqlPointpointArray2M.AssertModel(models[19],_testData[32], false);NpgsqlPointpointArray2M.AssertModel(models[20],_testData[33], false);NpgsqlPointpointArray2M.AssertModel(models[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointListpointArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointListpointArray)this).SetDbConnectionSelectModelParametrs(cmd, 89);
                var models =  ((INpgsqlPointListpointArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(20));
NpgsqlPointpointArray2M.AssertModel(models[0],_testData[15], false);NpgsqlPointpointArray2M.AssertModel(models[1],_testData[16], false);NpgsqlPointpointArray2M.AssertModel(models[2],_testData[17], false);NpgsqlPointpointArray2M.AssertModel(models[3],_testData[18], false);NpgsqlPointpointArray2M.AssertModel(models[4],_testData[19], false);NpgsqlPointpointArray2M.AssertModel(models[5],_testData[20], false);NpgsqlPointpointArray2M.AssertModel(models[6],_testData[21], false);NpgsqlPointpointArray2M.AssertModel(models[7],_testData[22], false);NpgsqlPointpointArray2M.AssertModel(models[8],_testData[23], false);NpgsqlPointpointArray2M.AssertModel(models[9],_testData[24], false);NpgsqlPointpointArray2M.AssertModel(models[10],_testData[25], false);NpgsqlPointpointArray2M.AssertModel(models[11],_testData[26], false);NpgsqlPointpointArray2M.AssertModel(models[12],_testData[27], false);NpgsqlPointpointArray2M.AssertModel(models[13],_testData[28], false);NpgsqlPointpointArray2M.AssertModel(models[14],_testData[29], false);NpgsqlPointpointArray2M.AssertModel(models[15],_testData[30], false);NpgsqlPointpointArray2M.AssertModel(models[16],_testData[31], false);NpgsqlPointpointArray2M.AssertModel(models[17],_testData[32], false);NpgsqlPointpointArray2M.AssertModel(models[18],_testData[33], false);NpgsqlPointpointArray2M.AssertModel(models[19],_testData[34], false);
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
FROM public.binary_npgsqlpointpointarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray2MIWA),
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
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointListpointArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointListpointArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointListpointArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointListpointArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray2MI),
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
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointListpointArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPointListpointArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointListpointArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointListpointArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpointpointarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPointpointArray2M),
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
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
FROM public.binary_npgsqlpointpointarray2m m
LEFT JOIN public.binary_npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointListpointArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPointListpointArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointListpointArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpointpointarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
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
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPointListpointArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointListpointArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA), typeof(NpgsqlPointpointArray2MIWA)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                await ((INpgsqlPointListpointArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                ((INpgsqlPointListpointArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await ((INpgsqlPointListpointArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointarray2mi
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
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointarray2mi
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
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA), typeof(NpgsqlPointpointArray2MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                await ((INpgsqlPointListpointArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                ((INpgsqlPointListpointArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
                var models = await ((INpgsqlPointListpointArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointarray2mi
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
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointarray2mi
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
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI), typeof(NpgsqlPointpointArray2MI)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models1 = new List<NpgsqlPointpointArray2MI>();
                var models2 = new List<NpgsqlPointpointArray2MI>();
                await ((INpgsqlPointListpointArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray2MI>();
                var models2 = new List<NpgsqlPointpointArray2MI>();
                ((INpgsqlPointListpointArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI)],
            dbTypes: new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await ((INpgsqlPointListpointArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA), typeof(NpgsqlPointpointArray2MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                await ((INpgsqlPointListpointArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                ((INpgsqlPointListpointArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
                var models = await ((INpgsqlPointListpointArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

