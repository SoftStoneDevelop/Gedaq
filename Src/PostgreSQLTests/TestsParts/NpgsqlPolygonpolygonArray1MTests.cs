

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
    internal partial interface INpgsqlPolygonArraypolygonArray
    {
    }
    
    internal partial class NpgsqlPolygonArraypolygonArray : INpgsqlPolygonArraypolygonArray
    {


#region TestData

        private readonly NpgsqlPolygonpolygonArray1M[] _testData = new NpgsqlPolygonpolygonArray1M[]
        {
            new NpgsqlPolygonpolygonArray1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.010349653060094721d, y: 0.6958683995850499d), new NpgsqlTypes.NpgsqlPoint(x: 0.3968329348535009d, y: 0.29453940308578896d), new NpgsqlTypes.NpgsqlPoint(x: 0.12545461147522718d, y: 0.27535621909101626d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6235154174517225d, y: 0.8876673250755196d), new NpgsqlTypes.NpgsqlPoint(x: 0.8903055474798965d, y: 0.21715751358295643d), new NpgsqlTypes.NpgsqlPoint(x: 0.07626501565725186d, y: 0.7272279607841913d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9045963822601493d, y: 0.6900272064705406d), new NpgsqlTypes.NpgsqlPoint(x: 0.8000999488269276d, y: 0.5426295551586036d), new NpgsqlTypes.NpgsqlPoint(x: 0.0024483971543152183d, y: 0.19546592460940382d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3195383494359898d, y: 0.6022534987847167d), new NpgsqlTypes.NpgsqlPoint(x: 0.36727746233247205d, y: 0.5853921076652898d), new NpgsqlTypes.NpgsqlPoint(x: 0.07309200495685209d, y: 0.991805075691262d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5060622898079623d, y: 0.8441667044899638d), new NpgsqlTypes.NpgsqlPoint(x: 0.3292750438488522d, y: 0.7688125304707096d), new NpgsqlTypes.NpgsqlPoint(x: 0.9257565890239043d, y: 0.25417509379096226d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06430515308620899d, y: 0.06355196876415281d), new NpgsqlTypes.NpgsqlPoint(x: 0.24592377961748835d, y: 0.638527041714119d), new NpgsqlTypes.NpgsqlPoint(x: 0.1785233948171696d, y: 0.215762640457011d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7791201700461751d, y: 0.9993615580099738d), new NpgsqlTypes.NpgsqlPoint(x: 0.9168065727783881d, y: 0.3148681003051932d), new NpgsqlTypes.NpgsqlPoint(x: 0.7677309814827789d, y: 0.11499651185026649d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.058072753622832485d, y: 0.2630137023330579d), new NpgsqlTypes.NpgsqlPoint(x: 0.7575154513252595d, y: 0.29124475369587544d), new NpgsqlTypes.NpgsqlPoint(x: 0.5906100885701172d, y: 0.21907567354622226d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9830450083364392d, y: 0.3296916473021958d), new NpgsqlTypes.NpgsqlPoint(x: 0.687060652800713d, y: 0.3273334701870755d), new NpgsqlTypes.NpgsqlPoint(x: 0.38590168675350844d, y: 0.24548942883405356d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5255242490279177d, y: 0.06793253915905162d), new NpgsqlTypes.NpgsqlPoint(x: 0.8339965935258152d, y: 0.4840474337614239d), new NpgsqlTypes.NpgsqlPoint(x: 0.027245050268701942d, y: 0.6430808815100064d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9188057831468046d, y: 0.13002843135703934d), new NpgsqlTypes.NpgsqlPoint(x: 0.9433753758264899d, y: 0.23557381527438281d), new NpgsqlTypes.NpgsqlPoint(x: 0.7626522120866243d, y: 0.07479682074691896d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6684484434324353d, y: 0.9764548462126343d), new NpgsqlTypes.NpgsqlPoint(x: 0.249961848313062d, y: 0.7003354439712112d), new NpgsqlTypes.NpgsqlPoint(x: 0.031205326761107655d, y: 0.663282547950739d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12139136823665997d, y: 0.7980120893282076d), new NpgsqlTypes.NpgsqlPoint(x: 0.8373210956173832d, y: 0.13640642973470685d), new NpgsqlTypes.NpgsqlPoint(x: 0.39157105820220206d, y: 0.6196160752816308d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4924148253510323d, y: 0.9303075857633555d), new NpgsqlTypes.NpgsqlPoint(x: 0.35987814964055975d, y: 0.09157857716243167d), new NpgsqlTypes.NpgsqlPoint(x: 0.6956427599175214d, y: 0.8386008378756485d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5999170367229143d, y: 0.9035581536007168d), new NpgsqlTypes.NpgsqlPoint(x: 0.07060247066584102d, y: 0.782848148287968d), new NpgsqlTypes.NpgsqlPoint(x: 0.7051265308922257d, y: 0.6592985437802364d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4744790737315844d, y: 0.13889791823017328d), new NpgsqlTypes.NpgsqlPoint(x: 0.6120536754249553d, y: 0.4822792549021987d), new NpgsqlTypes.NpgsqlPoint(x: 0.040554936427376176d, y: 0.2545610084084501d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8984798630995374d, y: 0.39515954228128747d), new NpgsqlTypes.NpgsqlPoint(x: 0.9331401658019226d, y: 0.17012686544958822d), new NpgsqlTypes.NpgsqlPoint(x: 0.06174768596082325d, y: 0.06985981360145332d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7473450036281722d, y: 0.7390352533814186d), new NpgsqlTypes.NpgsqlPoint(x: 0.5180053264149255d, y: 0.5571081032664047d), new NpgsqlTypes.NpgsqlPoint(x: 0.9934956479002809d, y: 0.10752227767642653d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.061414234238823195d, y: 0.24415690489592767d), new NpgsqlTypes.NpgsqlPoint(x: 0.4754530598516209d, y: 0.06270717008780713d), new NpgsqlTypes.NpgsqlPoint(x: 0.06778680225709977d, y: 0.1631107710295272d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47618070360778186d, y: 0.31555053736432936d), new NpgsqlTypes.NpgsqlPoint(x: 0.39346215619434466d, y: 0.5270231815875683d), new NpgsqlTypes.NpgsqlPoint(x: 0.9007255494687768d, y: 0.9334967792438298d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2219586145480691d, y: 0.021694641545064508d), new NpgsqlTypes.NpgsqlPoint(x: 0.6833034191864498d, y: 0.6705797026645441d), new NpgsqlTypes.NpgsqlPoint(x: 0.8619629686859865d, y: 0.8454528673447678d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4844468384147126d, y: 0.3325498489131672d), new NpgsqlTypes.NpgsqlPoint(x: 0.881224947147892d, y: 0.9891095155710639d), new NpgsqlTypes.NpgsqlPoint(x: 0.36892526739871623d, y: 0.9301707963965264d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7735028066593529d, y: 0.0783909768643023d), new NpgsqlTypes.NpgsqlPoint(x: 0.5234866953467203d, y: 0.0036705116472307564d), new NpgsqlTypes.NpgsqlPoint(x: 0.6256171455661067d, y: 0.39165913401170516d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3069954323896775d, y: 0.6843948250708588d), new NpgsqlTypes.NpgsqlPoint(x: 0.42839563319561635d, y: 0.9084412573104903d), new NpgsqlTypes.NpgsqlPoint(x: 0.10868352898721712d, y: 0.9051095446097053d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6151211046585354d, y: 0.620782758361623d), new NpgsqlTypes.NpgsqlPoint(x: 0.45552078713485367d, y: 0.3394323827143697d), new NpgsqlTypes.NpgsqlPoint(x: 0.828875198299014d, y: 0.5986138280488792d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7935550082928609d, y: 0.9535287046468088d), new NpgsqlTypes.NpgsqlPoint(x: 0.6124509826997097d, y: 0.9924173538054973d), new NpgsqlTypes.NpgsqlPoint(x: 0.41910954210299634d, y: 0.45832909997680715d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6793144987530003d, y: 0.7107526030907902d), new NpgsqlTypes.NpgsqlPoint(x: 0.16596939563146618d, y: 0.9299561388860915d), new NpgsqlTypes.NpgsqlPoint(x: 0.4885343019162317d, y: 0.6668392690330492d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.587613498084582d, y: 0.0756080908625083d), new NpgsqlTypes.NpgsqlPoint(x: 0.16453202922813925d, y: 0.08187392001759053d), new NpgsqlTypes.NpgsqlPoint(x: 0.9439271011208872d, y: 0.43181767918138336d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31625085671397857d, y: 0.6252847528616152d), new NpgsqlTypes.NpgsqlPoint(x: 0.8337315016315809d, y: 0.2510605446700245d), new NpgsqlTypes.NpgsqlPoint(x: 0.8136192779177603d, y: 0.4551265735048394d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6535830203393407d, y: 0.2848601922085586d), new NpgsqlTypes.NpgsqlPoint(x: 0.3650551522868445d, y: 0.9620477796474052d), new NpgsqlTypes.NpgsqlPoint(x: 0.6588203854019509d, y: 0.06524430270785464d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8074185811036565d, y: 0.19781088456593254d), new NpgsqlTypes.NpgsqlPoint(x: 0.3579321995402063d, y: 0.5849399374126063d), new NpgsqlTypes.NpgsqlPoint(x: 0.06252086891174091d, y: 0.3600744920904634d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3280089731614765d, y: 0.2373580334915243d), new NpgsqlTypes.NpgsqlPoint(x: 0.2876495682423207d, y: 0.8048372074197503d), new NpgsqlTypes.NpgsqlPoint(x: 0.49461243665020604d, y: 0.31747893853029985d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7210218890181335d, y: 0.6054294374172879d), new NpgsqlTypes.NpgsqlPoint(x: 0.6776362673742101d, y: 0.8450876205486345d), new NpgsqlTypes.NpgsqlPoint(x: 0.04991483700520505d, y: 0.7598225299435998d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8850633238851013d, y: 0.9387281093697143d), new NpgsqlTypes.NpgsqlPoint(x: 0.6688151655067063d, y: 0.09200499662359563d), new NpgsqlTypes.NpgsqlPoint(x: 0.17486746980453138d, y: 0.4633069572836903d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18977680899555782d, y: 0.8514678474507711d), new NpgsqlTypes.NpgsqlPoint(x: 0.7298393164226261d, y: 0.3810370325874597d), new NpgsqlTypes.NpgsqlPoint(x: 0.5308378343014972d, y: 0.8684275309279744d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.019414176921010662d, y: 0.31089044625278794d), new NpgsqlTypes.NpgsqlPoint(x: 0.07538185028156252d, y: 0.6347535384957151d), new NpgsqlTypes.NpgsqlPoint(x: 0.11830873229216621d, y: 0.8365191172276443d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7390600529558103d, y: 0.6402974242931532d), new NpgsqlTypes.NpgsqlPoint(x: 0.9168583784494336d, y: 0.3661286229436861d), new NpgsqlTypes.NpgsqlPoint(x: 0.8328955929979964d, y: 0.4317217093026806d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45461612993267364d, y: 0.37156290948677806d), new NpgsqlTypes.NpgsqlPoint(x: 0.6256415258343436d, y: 0.7720707660671126d), new NpgsqlTypes.NpgsqlPoint(x: 0.25217638062736625d, y: 0.5971374296540983d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32581512838825033d, y: 0.2291796878161746d), new NpgsqlTypes.NpgsqlPoint(x: 0.7624214245506175d, y: 0.3424940706182915d), new NpgsqlTypes.NpgsqlPoint(x: 0.6594259017987945d, y: 0.46882910295522906d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19297474272121762d, y: 0.5393147596905665d), new NpgsqlTypes.NpgsqlPoint(x: 0.5239523044215604d, y: 0.8937346111314695d), new NpgsqlTypes.NpgsqlPoint(x: 0.6501074040779791d, y: 0.27299085829029834d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48636116574283794d, y: 0.11704996896828401d), new NpgsqlTypes.NpgsqlPoint(x: 0.7851263251218992d, y: 0.46302618686418673d), new NpgsqlTypes.NpgsqlPoint(x: 0.17910700736244145d, y: 0.2753690506106534d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44610329919306646d, y: 0.269766345579308d), new NpgsqlTypes.NpgsqlPoint(x: 0.13042250095458097d, y: 0.19684683668518865d), new NpgsqlTypes.NpgsqlPoint(x: 0.28738361621913855d, y: 0.5643700693919109d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5173704077663033d, y: 0.33086043579440205d), new NpgsqlTypes.NpgsqlPoint(x: 0.5706524503054182d, y: 0.9793227549752916d), new NpgsqlTypes.NpgsqlPoint(x: 0.0637697630530688d, y: 0.2084730983761207d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9043925855519215d, y: 0.6016151786601432d), new NpgsqlTypes.NpgsqlPoint(x: 0.5155524105260828d, y: 0.866770838933865d), new NpgsqlTypes.NpgsqlPoint(x: 0.9012599040140735d, y: 0.5475373425686412d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20591531548690023d, y: 0.18902065358053977d), new NpgsqlTypes.NpgsqlPoint(x: 0.9917457335213044d, y: 0.9573696619772522d), new NpgsqlTypes.NpgsqlPoint(x: 0.6032428841269104d, y: 0.7581637207683475d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.810498996246176d, y: 0.1516149580081868d), new NpgsqlTypes.NpgsqlPoint(x: 0.389150401608539d, y: 0.47916862648369896d), new NpgsqlTypes.NpgsqlPoint(x: 0.421367162642051d, y: 0.017709333280455097d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.478417450298815d, y: 0.9607002311474204d), new NpgsqlTypes.NpgsqlPoint(x: 0.4665572951367777d, y: 0.2969759526741168d), new NpgsqlTypes.NpgsqlPoint(x: 0.1124134047934251d, y: 0.7198187195091056d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9975608797270233d, y: 0.2353554409430385d), new NpgsqlTypes.NpgsqlPoint(x: 0.21791629964454606d, y: 0.23039338162237866d), new NpgsqlTypes.NpgsqlPoint(x: 0.5536020103633812d, y: 0.1749257317138896d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7066545579121339d, y: 0.9137898782974188d), new NpgsqlTypes.NpgsqlPoint(x: 0.5213898540417543d, y: 0.4916515916218607d), new NpgsqlTypes.NpgsqlPoint(x: 0.8801020543270173d, y: 0.4200806029302532d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8045467605463843d, y: 0.19407916201295583d), new NpgsqlTypes.NpgsqlPoint(x: 0.9636957633619654d, y: 0.8919059199419187d), new NpgsqlTypes.NpgsqlPoint(x: 0.8619933168142331d, y: 0.17431497265978935d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2013939903668832d, y: 0.659697555606938d), new NpgsqlTypes.NpgsqlPoint(x: 0.5735527156275123d, y: 0.9486872463040396d), new NpgsqlTypes.NpgsqlPoint(x: 0.44043998283156893d, y: 0.14946192954238735d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.042471929578601686d, y: 0.7970976201654544d), new NpgsqlTypes.NpgsqlPoint(x: 0.35210633447737494d, y: 0.8302076530440597d), new NpgsqlTypes.NpgsqlPoint(x: 0.9346344454286669d, y: 0.15734129242184747d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09517858947893831d, y: 0.9471347505283417d), new NpgsqlTypes.NpgsqlPoint(x: 0.21195192492793447d, y: 0.06077974009198317d), new NpgsqlTypes.NpgsqlPoint(x: 0.451032854951141d, y: 0.9621428466730845d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3765158487586133d, y: 0.7102643547068285d), new NpgsqlTypes.NpgsqlPoint(x: 0.5371777335115786d, y: 0.0020493052869980932d), new NpgsqlTypes.NpgsqlPoint(x: 0.637383919064898d, y: 0.4088480942028484d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06134786517829871d, y: 0.9481214352252395d), new NpgsqlTypes.NpgsqlPoint(x: 0.2582513999835273d, y: 0.4256958962438431d), new NpgsqlTypes.NpgsqlPoint(x: 0.31671872615919305d, y: 0.1573654464056229d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09523937253838743d, y: 0.7842768320763001d), new NpgsqlTypes.NpgsqlPoint(x: 0.4582390211765338d, y: 0.4943786225145672d), new NpgsqlTypes.NpgsqlPoint(x: 0.32490978442572727d, y: 0.37922240023472675d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.056318740796121536d, y: 0.5716795906560849d), new NpgsqlTypes.NpgsqlPoint(x: 0.7263892424857021d, y: 0.5429849785981299d), new NpgsqlTypes.NpgsqlPoint(x: 0.7449454902936489d, y: 0.4299396365518676d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5401450880781119d, y: 0.22973766392739692d), new NpgsqlTypes.NpgsqlPoint(x: 0.23647611265960988d, y: 0.3601813779418016d), new NpgsqlTypes.NpgsqlPoint(x: 0.14935844580567204d, y: 0.007320628452212374d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6106250043943228d, y: 0.7600329181834794d), new NpgsqlTypes.NpgsqlPoint(x: 0.8742364565949166d, y: 0.2726299687010434d), new NpgsqlTypes.NpgsqlPoint(x: 0.37137876394547076d, y: 0.7320611884717452d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32619257403777013d, y: 0.5019972638175637d), new NpgsqlTypes.NpgsqlPoint(x: 0.46306862705902707d, y: 0.6049587304105987d), new NpgsqlTypes.NpgsqlPoint(x: 0.7754610300358796d, y: 0.22162341953640552d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34412927863434073d, y: 0.7439854855015606d), new NpgsqlTypes.NpgsqlPoint(x: 0.14631239417996067d, y: 0.3011151197690237d), new NpgsqlTypes.NpgsqlPoint(x: 0.6543638320838302d, y: 0.3091215616392299d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10502215774436308d, y: 0.513249168267894d), new NpgsqlTypes.NpgsqlPoint(x: 0.37478330993000786d, y: 0.27140925698141216d), new NpgsqlTypes.NpgsqlPoint(x: 0.1793679480714978d, y: 0.020117829411751775d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29346523443236716d, y: 0.7515727484533279d), new NpgsqlTypes.NpgsqlPoint(x: 0.7516119169600152d, y: 0.3042201280631992d), new NpgsqlTypes.NpgsqlPoint(x: 0.722268734784091d, y: 0.18494995605612152d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19506813176679294d, y: 0.2438004768530686d), new NpgsqlTypes.NpgsqlPoint(x: 0.31357748695066434d, y: 0.3547834002012119d), new NpgsqlTypes.NpgsqlPoint(x: 0.9672776762207737d, y: 0.5711272780046559d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25708374994761674d, y: 0.33083075214824764d), new NpgsqlTypes.NpgsqlPoint(x: 0.03437626254117776d, y: 0.08282003653510772d), new NpgsqlTypes.NpgsqlPoint(x: 0.3661983877241095d, y: 0.6957467185098126d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46852044401461246d, y: 0.626115858231629d), new NpgsqlTypes.NpgsqlPoint(x: 0.3577433293551566d, y: 0.4619045865761089d), new NpgsqlTypes.NpgsqlPoint(x: 0.2838337460816749d, y: 0.8792331925935736d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6735360150026072d, y: 0.4785775829902882d), new NpgsqlTypes.NpgsqlPoint(x: 0.7394390229754915d, y: 0.8026443748267901d), new NpgsqlTypes.NpgsqlPoint(x: 0.5707120295073601d, y: 0.9464620231497879d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3237914639023256d, y: 0.6913362319033134d), new NpgsqlTypes.NpgsqlPoint(x: 0.4900568328858752d, y: 0.10980951494895808d), new NpgsqlTypes.NpgsqlPoint(x: 0.24529578879728664d, y: 0.9560031849607028d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6635000208559827d, y: 0.07510075445512432d), new NpgsqlTypes.NpgsqlPoint(x: 0.23356527494215762d, y: 0.30997932595014754d), new NpgsqlTypes.NpgsqlPoint(x: 0.3488365660638727d, y: 0.05507984038248337d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12540291808544868d, y: 0.22726280747235073d), new NpgsqlTypes.NpgsqlPoint(x: 0.1881364236068236d, y: 0.7207010282183194d), new NpgsqlTypes.NpgsqlPoint(x: 0.7900593688586279d, y: 0.18624292413544963d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9880997452899184d, y: 0.4818728738898602d), new NpgsqlTypes.NpgsqlPoint(x: 0.12768859402316013d, y: 0.7964447450362272d), new NpgsqlTypes.NpgsqlPoint(x: 0.0198934609782494d, y: 0.3679543304197598d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3088993264788794d, y: 0.632580182016787d), new NpgsqlTypes.NpgsqlPoint(x: 0.48701183860039565d, y: 0.7864639285261488d), new NpgsqlTypes.NpgsqlPoint(x: 0.2292049989953585d, y: 0.9453403976125611d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4556484652456366d, y: 0.686790042694528d), new NpgsqlTypes.NpgsqlPoint(x: 0.842572060360867d, y: 0.9375771557890873d), new NpgsqlTypes.NpgsqlPoint(x: 0.7894641511022117d, y: 0.36412878342659893d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8894487705368521d, y: 0.05944856773796936d), new NpgsqlTypes.NpgsqlPoint(x: 0.46005563430521257d, y: 0.08776501099023493d), new NpgsqlTypes.NpgsqlPoint(x: 0.6236787572744502d, y: 0.15457496542454907d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9067255130125044d, y: 0.511216673669213d), new NpgsqlTypes.NpgsqlPoint(x: 0.3741848397134464d, y: 0.5324273145525381d), new NpgsqlTypes.NpgsqlPoint(x: 0.36808497732031187d, y: 0.732124561375233d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5560258966278057d, y: 0.09776209639632749d), new NpgsqlTypes.NpgsqlPoint(x: 0.5175508531646779d, y: 0.9135111479276063d), new NpgsqlTypes.NpgsqlPoint(x: 0.9532611034749268d, y: 0.9579424173897292d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6632008220900166d, y: 0.4455689959275012d), new NpgsqlTypes.NpgsqlPoint(x: 0.19825672939630135d, y: 0.5899174262681252d), new NpgsqlTypes.NpgsqlPoint(x: 0.7678201578482171d, y: 0.07940765587073406d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4656787558239007d, y: 0.04322303442895725d), new NpgsqlTypes.NpgsqlPoint(x: 0.8294382840772369d, y: 0.9486050301348503d), new NpgsqlTypes.NpgsqlPoint(x: 0.8497474103934524d, y: 0.025194382595473797d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6513264697440887d, y: 0.5053560278129539d), new NpgsqlTypes.NpgsqlPoint(x: 0.7443507021489462d, y: 0.14809383268552778d), new NpgsqlTypes.NpgsqlPoint(x: 0.8014935361590758d, y: 0.20483091834758893d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.650885210493337d, y: 0.9247766357540961d), new NpgsqlTypes.NpgsqlPoint(x: 0.5397589472865799d, y: 0.34563005253665213d), new NpgsqlTypes.NpgsqlPoint(x: 0.931809987706186d, y: 0.5344291461866799d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13330315861622255d, y: 0.552453116527934d), new NpgsqlTypes.NpgsqlPoint(x: 0.9444823335405136d, y: 0.08759816647109964d), new NpgsqlTypes.NpgsqlPoint(x: 0.29350176350565194d, y: 0.08987864555877856d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.696427311005501d, y: 0.4821688193395689d), new NpgsqlTypes.NpgsqlPoint(x: 0.1321901767791993d, y: 0.5706705017456907d), new NpgsqlTypes.NpgsqlPoint(x: 0.09742548178776278d, y: 0.08276146033504772d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7623830722927241d, y: 0.08788599026768051d), new NpgsqlTypes.NpgsqlPoint(x: 0.14761840956715444d, y: 0.2768056985709726d), new NpgsqlTypes.NpgsqlPoint(x: 0.5213979338410635d, y: 0.26908675012319405d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3433100472085284d, y: 0.7423842877267502d), new NpgsqlTypes.NpgsqlPoint(x: 0.7067994590148781d, y: 0.5595205636150692d), new NpgsqlTypes.NpgsqlPoint(x: 0.5624301371552056d, y: 0.992073251323649d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4578231800738356d, y: 0.9731525662961885d), new NpgsqlTypes.NpgsqlPoint(x: 0.06480015744857592d, y: 0.9631334339571535d), new NpgsqlTypes.NpgsqlPoint(x: 0.3475723880923254d, y: 0.2566632258133653d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.053725058613925736d, y: 0.8446151268911187d), new NpgsqlTypes.NpgsqlPoint(x: 0.2513013420998905d, y: 0.5182118670347295d), new NpgsqlTypes.NpgsqlPoint(x: 0.6526184163411609d, y: 0.3487136485740491d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9839041089628131d, y: 0.5332612144319914d), new NpgsqlTypes.NpgsqlPoint(x: 0.575572088519961d, y: 0.3172280990935039d), new NpgsqlTypes.NpgsqlPoint(x: 0.9044202696730838d, y: 0.9716596275845992d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.327707433435924d, y: 0.22268034349089139d), new NpgsqlTypes.NpgsqlPoint(x: 0.9862716668383606d, y: 0.9424768448536711d), new NpgsqlTypes.NpgsqlPoint(x: 0.3760375247372525d, y: 0.4568912705807413d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04240922760343413d, y: 0.7436451490955971d), new NpgsqlTypes.NpgsqlPoint(x: 0.07165162370021427d, y: 0.766526442770739d), new NpgsqlTypes.NpgsqlPoint(x: 0.7043634175771416d, y: 0.21372564253935689d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5137853484865182d, y: 0.6957013901344367d), new NpgsqlTypes.NpgsqlPoint(x: 0.41639405077162917d, y: 0.5452823168675293d), new NpgsqlTypes.NpgsqlPoint(x: 0.8717501369028529d, y: 0.29542975053121456d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6801965412966062d, y: 0.6339322551709691d), new NpgsqlTypes.NpgsqlPoint(x: 0.92881019361844d, y: 0.2321518420384312d), new NpgsqlTypes.NpgsqlPoint(x: 0.02965811041974764d, y: 0.471547541418999d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6837823858232881d, y: 0.42956215611541226d), new NpgsqlTypes.NpgsqlPoint(x: 0.5803324862581188d, y: 0.41591659493980526d), new NpgsqlTypes.NpgsqlPoint(x: 0.03534931828441723d, y: 0.5001461071823283d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3641636133522247d, y: 0.8180085733694072d), new NpgsqlTypes.NpgsqlPoint(x: 0.6002005035760044d, y: 0.030904828612873914d), new NpgsqlTypes.NpgsqlPoint(x: 0.8965737778998606d, y: 0.5560562300403945d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3895630688635354d, y: 0.9249315852932095d), new NpgsqlTypes.NpgsqlPoint(x: 0.42923106625264695d, y: 0.40747272842355087d), new NpgsqlTypes.NpgsqlPoint(x: 0.0899082042545637d, y: 0.6336183183213487d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8869502145283301d, y: 0.8776076721725815d), new NpgsqlTypes.NpgsqlPoint(x: 0.879531117170911d, y: 0.482139102649224d), new NpgsqlTypes.NpgsqlPoint(x: 0.5492702889506443d, y: 0.15460711643109504d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 95,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38498161715817414d, y: 0.017952183502734198d), new NpgsqlTypes.NpgsqlPoint(x: 0.33556327006665665d, y: 0.8796081721819194d), new NpgsqlTypes.NpgsqlPoint(x: 0.15308616622410165d, y: 0.12774201955185904d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18921355367276127d, y: 0.6299068197690566d), new NpgsqlTypes.NpgsqlPoint(x: 0.703710204779739d, y: 0.9716784437518942d), new NpgsqlTypes.NpgsqlPoint(x: 0.5741438941929573d, y: 0.45844031545413755d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39348249217010567d, y: 0.4496819951529376d), new NpgsqlTypes.NpgsqlPoint(x: 0.7510157951720772d, y: 0.3903950347604026d), new NpgsqlTypes.NpgsqlPoint(x: 0.09658029259191281d, y: 0.9050860637667658d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1638237828338417d, y: 0.8266676459373068d), new NpgsqlTypes.NpgsqlPoint(x: 0.39108262286675977d, y: 0.961864193661262d), new NpgsqlTypes.NpgsqlPoint(x: 0.016543257114967513d, y: 0.48290876646785175d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.264453920478552d, y: 0.5762241398605449d), new NpgsqlTypes.NpgsqlPoint(x: 0.45963164880266527d, y: 0.14216310712348756d), new NpgsqlTypes.NpgsqlPoint(x: 0.9472200140528105d, y: 0.503559767237202d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8780438832679847d, y: 0.2249203263753372d), new NpgsqlTypes.NpgsqlPoint(x: 0.18478625376838043d, y: 0.2046339042996802d), new NpgsqlTypes.NpgsqlPoint(x: 0.9117596400038117d, y: 0.784060630358098d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7159473419766726d, y: 0.16231659149469224d), new NpgsqlTypes.NpgsqlPoint(x: 0.6649046008078687d, y: 0.629209178834879d), new NpgsqlTypes.NpgsqlPoint(x: 0.30486584588303023d, y: 0.189927171118495d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6056953075430462d, y: 0.8818608934506491d), new NpgsqlTypes.NpgsqlPoint(x: 0.0018709251918019865d, y: 0.9255419744718815d), new NpgsqlTypes.NpgsqlPoint(x: 0.05311209292232366d, y: 0.9923073014456831d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6370733716937127d, y: 0.8196144552910538d), new NpgsqlTypes.NpgsqlPoint(x: 0.8692331878452598d, y: 0.05635244482960744d), new NpgsqlTypes.NpgsqlPoint(x: 0.32638997973687933d, y: 0.5502005851715427d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07806839545197897d, y: 0.44109182476123043d), new NpgsqlTypes.NpgsqlPoint(x: 0.0024267663141334106d, y: 0.36722074220567313d), new NpgsqlTypes.NpgsqlPoint(x: 0.18819311167691988d, y: 0.21429034965159743d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7505121815898276d, y: 0.7855565063751468d), new NpgsqlTypes.NpgsqlPoint(x: 0.6746540696556755d, y: 0.743792259244408d), new NpgsqlTypes.NpgsqlPoint(x: 0.13284988540402498d, y: 0.10064419762211008d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8192990813891248d, y: 0.7501384390550184d), new NpgsqlTypes.NpgsqlPoint(x: 0.47432617965727564d, y: 0.9379867766247327d), new NpgsqlTypes.NpgsqlPoint(x: 0.5901298567895165d, y: 0.2934420411867742d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03993461811815591d, y: 0.8643548821381555d), new NpgsqlTypes.NpgsqlPoint(x: 0.8965326618963584d, y: 0.10511432050186609d), new NpgsqlTypes.NpgsqlPoint(x: 0.2841144760310733d, y: 0.005316890704452293d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04351794626521244d, y: 0.7013007336944664d), new NpgsqlTypes.NpgsqlPoint(x: 0.24576373112148175d, y: 0.03811257208653074d), new NpgsqlTypes.NpgsqlPoint(x: 0.6302469944910157d, y: 0.9017289316552435d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 103,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33597861878752866d, y: 0.9881191166273084d), new NpgsqlTypes.NpgsqlPoint(x: 0.798563211408906d, y: 0.8290950359675455d), new NpgsqlTypes.NpgsqlPoint(x: 0.9302210098145041d, y: 0.344687755636613d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.00046775244189012355d, y: 0.8192807842800288d), new NpgsqlTypes.NpgsqlPoint(x: 0.6588635577630103d, y: 0.6843918698541422d), new NpgsqlTypes.NpgsqlPoint(x: 0.49495568485215025d, y: 0.48493744405982286d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2644933057175455d, y: 0.444892722841712d), new NpgsqlTypes.NpgsqlPoint(x: 0.5870246223579123d, y: 0.36845137100953806d), new NpgsqlTypes.NpgsqlPoint(x: 0.5008509486862239d, y: 0.2803310362656204d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38428501185345865d, y: 0.03499112263275317d), new NpgsqlTypes.NpgsqlPoint(x: 0.775875131671812d, y: 0.2033055951978857d), new NpgsqlTypes.NpgsqlPoint(x: 0.8137979290822888d, y: 0.41921894666551285d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16793314686630056d, y: 0.4810159816706022d), new NpgsqlTypes.NpgsqlPoint(x: 0.2580366444935568d, y: 0.03592533084999372d), new NpgsqlTypes.NpgsqlPoint(x: 0.2566323999676029d, y: 0.48465338572106986d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5236833253259356d, y: 0.4904618314638727d), new NpgsqlTypes.NpgsqlPoint(x: 0.17634043107483788d, y: 0.9824310601144445d), new NpgsqlTypes.NpgsqlPoint(x: 0.8919896900733556d, y: 0.23988385801790457d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 110,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7893680188626867d, y: 0.5054275765775339d), new NpgsqlTypes.NpgsqlPoint(x: 0.4068753088809681d, y: 0.2244099706917062d), new NpgsqlTypes.NpgsqlPoint(x: 0.253368896961357d, y: 0.5851951663582051d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46907966838279824d, y: 0.07174805812608853d), new NpgsqlTypes.NpgsqlPoint(x: 0.10145046280116321d, y: 0.5599542656314918d), new NpgsqlTypes.NpgsqlPoint(x: 0.8019238422367029d, y: 0.5469205124240211d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9004959620658155d, y: 0.899914075189843d), new NpgsqlTypes.NpgsqlPoint(x: 0.9573200184649717d, y: 0.88286585093208d), new NpgsqlTypes.NpgsqlPoint(x: 0.06507494829794225d, y: 0.7733030421133371d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4643420259946959d, y: 0.6362754253001942d), new NpgsqlTypes.NpgsqlPoint(x: 0.609071667591421d, y: 0.7930908749833229d), new NpgsqlTypes.NpgsqlPoint(x: 0.02389229648620672d, y: 0.9937503089573201d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30280742887452505d, y: 0.10535001477701422d), new NpgsqlTypes.NpgsqlPoint(x: 0.7170167726547412d, y: 0.39527222526476335d), new NpgsqlTypes.NpgsqlPoint(x: 0.3152159989018306d, y: 0.5628862736546227d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4581318544599916d, y: 0.34518010277581923d), new NpgsqlTypes.NpgsqlPoint(x: 0.33671379083560693d, y: 0.5297087928076339d), new NpgsqlTypes.NpgsqlPoint(x: 0.180761030039448d, y: 0.8496503334722089d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14184738101627958d, y: 0.6651498603580699d), new NpgsqlTypes.NpgsqlPoint(x: 0.9807226242202055d, y: 0.06016868340736359d), new NpgsqlTypes.NpgsqlPoint(x: 0.7164282319745486d, y: 0.8729264568078253d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 119,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10708173016105416d, y: 0.9608977882553531d), new NpgsqlTypes.NpgsqlPoint(x: 0.33530185311073235d, y: 0.04607780279315021d), new NpgsqlTypes.NpgsqlPoint(x: 0.9135856675121192d, y: 0.42114279692227974d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.027875375697022142d, y: 0.20717314366299977d), new NpgsqlTypes.NpgsqlPoint(x: 0.2523873505828186d, y: 0.4948226529535166d), new NpgsqlTypes.NpgsqlPoint(x: 0.6462191497043899d, y: 0.4491070388890629d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6860274429453764d, y: 0.6878416236518586d), new NpgsqlTypes.NpgsqlPoint(x: 0.32655676789835597d, y: 0.8681118462338181d), new NpgsqlTypes.NpgsqlPoint(x: 0.08319822758831874d, y: 0.7339522660575029d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.009162463173121083d, y: 0.8107907971519073d), new NpgsqlTypes.NpgsqlPoint(x: 0.7772538374661825d, y: 0.9674239153917957d), new NpgsqlTypes.NpgsqlPoint(x: 0.9910875073073963d, y: 0.028306744141452733d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 123,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15660925781627932d, y: 0.23357230509776516d), new NpgsqlTypes.NpgsqlPoint(x: 0.40660661536993736d, y: 0.8690899447505943d), new NpgsqlTypes.NpgsqlPoint(x: 0.5671463669497712d, y: 0.9894033589084171d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6703395636660806d, y: 0.111043338383084d), new NpgsqlTypes.NpgsqlPoint(x: 0.6375241791265019d, y: 0.7369420814829829d), new NpgsqlTypes.NpgsqlPoint(x: 0.1697298378935198d, y: 0.6366989826213497d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9748923006304896d, y: 0.014610934537121811d), new NpgsqlTypes.NpgsqlPoint(x: 0.41856300398460344d, y: 0.34804987178867575d), new NpgsqlTypes.NpgsqlPoint(x: 0.3281262983126184d, y: 0.5492439767751273d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21615317398595957d, y: 0.7435488069265749d), new NpgsqlTypes.NpgsqlPoint(x: 0.9459260930755492d, y: 0.09396407219455727d), new NpgsqlTypes.NpgsqlPoint(x: 0.33906648936797856d, y: 0.31187164784842936d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5468535454304667d, y: 0.7424949057242103d), new NpgsqlTypes.NpgsqlPoint(x: 0.27703119373848195d, y: 0.9436044517702861d), new NpgsqlTypes.NpgsqlPoint(x: 0.16527215626192926d, y: 0.7878732640140708d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21194793411320512d, y: 0.845588083008241d), new NpgsqlTypes.NpgsqlPoint(x: 0.45863843095304113d, y: 0.014167303729405667d), new NpgsqlTypes.NpgsqlPoint(x: 0.6110451393216331d, y: 0.6788179796614686d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08207267026515574d, y: 0.12689885311574578d), new NpgsqlTypes.NpgsqlPoint(x: 0.9759324859174147d, y: 0.7282205929924296d), new NpgsqlTypes.NpgsqlPoint(x: 0.7142530426514163d, y: 0.24215874308168273d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06142212179352957d, y: 0.8639041867724039d), new NpgsqlTypes.NpgsqlPoint(x: 0.28820145164407074d, y: 0.9106211180469918d), new NpgsqlTypes.NpgsqlPoint(x: 0.7183563364830909d, y: 0.6798811581352577d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7969473967931272d, y: 0.6823668562788501d), new NpgsqlTypes.NpgsqlPoint(x: 0.86362046922507d, y: 0.911585576716574d), new NpgsqlTypes.NpgsqlPoint(x: 0.28230246065690034d, y: 0.057251092602019216d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 125,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31126899256103935d, y: 0.6898662298291081d), new NpgsqlTypes.NpgsqlPoint(x: 0.05607799826814985d, y: 0.8809302660853126d), new NpgsqlTypes.NpgsqlPoint(x: 0.040440340414615084d, y: 0.24783520342544219d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.550164313202284d, y: 0.141107432322226d), new NpgsqlTypes.NpgsqlPoint(x: 0.6833798695530132d, y: 0.9581976132562694d), new NpgsqlTypes.NpgsqlPoint(x: 0.47317789018097234d, y: 0.0492833280953906d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7796440334288199d, y: 0.34744343366131447d), new NpgsqlTypes.NpgsqlPoint(x: 0.3857198870680185d, y: 0.6866632378974172d), new NpgsqlTypes.NpgsqlPoint(x: 0.6542438053053536d, y: 0.9292888821348049d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22723901425196136d, y: 0.7286261623922483d), new NpgsqlTypes.NpgsqlPoint(x: 0.8247080780200067d, y: 0.8008050098737782d), new NpgsqlTypes.NpgsqlPoint(x: 0.6839165302435948d, y: 0.5996245714834927d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21449163031122642d, y: 0.8823835244038266d), new NpgsqlTypes.NpgsqlPoint(x: 0.9200753346497675d, y: 0.24459824673990993d), new NpgsqlTypes.NpgsqlPoint(x: 0.2658504427799826d, y: 0.9068273456618312d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8079913090566905d, y: 0.11498128992365308d), new NpgsqlTypes.NpgsqlPoint(x: 0.6179745164666277d, y: 0.6047818787520424d), new NpgsqlTypes.NpgsqlPoint(x: 0.350112145368496d, y: 0.6803794061507383d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19121877341400562d, y: 0.6340679045528566d), new NpgsqlTypes.NpgsqlPoint(x: 0.06920426527588386d, y: 0.8762946296199976d), new NpgsqlTypes.NpgsqlPoint(x: 0.98583712418502d, y: 0.33494884659197777d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5096061154875992d, y: 0.9615063807219734d), new NpgsqlTypes.NpgsqlPoint(x: 0.6485867054226077d, y: 0.6245596696861363d), new NpgsqlTypes.NpgsqlPoint(x: 0.7236302937626962d, y: 0.7954306112068809d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9676849511328114d, y: 0.8797935988868306d), new NpgsqlTypes.NpgsqlPoint(x: 0.5320388878525946d, y: 0.39618379580982055d), new NpgsqlTypes.NpgsqlPoint(x: 0.3101134450988887d, y: 0.10057770343757755d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7818999861778957d, y: 0.12388958459649402d), new NpgsqlTypes.NpgsqlPoint(x: 0.9030834153872108d, y: 0.09304302077178517d), new NpgsqlTypes.NpgsqlPoint(x: 0.10805963177463251d, y: 0.5702864353681573d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6731462821099841d, y: 0.6975856299033919d), new NpgsqlTypes.NpgsqlPoint(x: 0.5741351898159401d, y: 0.6467471168303891d), new NpgsqlTypes.NpgsqlPoint(x: 0.01992245793249081d, y: 0.9471155814699129d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05615815183679884d, y: 0.8703242379856104d), new NpgsqlTypes.NpgsqlPoint(x: 0.3091215831701897d, y: 0.465067096352037d), new NpgsqlTypes.NpgsqlPoint(x: 0.6572958079658223d, y: 0.7192109275767978d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26487862731486644d, y: 0.09501857329580798d), new NpgsqlTypes.NpgsqlPoint(x: 0.10517456055040986d, y: 0.34180415257729513d), new NpgsqlTypes.NpgsqlPoint(x: 0.4065383517015595d, y: 0.3062602412249462d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 140,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3483023479626287d, y: 0.08016215616073508d), new NpgsqlTypes.NpgsqlPoint(x: 0.7655220172409458d, y: 0.2749929052301209d), new NpgsqlTypes.NpgsqlPoint(x: 0.32241658956931984d, y: 0.4332909514977139d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21081153457258384d, y: 0.8756487489242454d), new NpgsqlTypes.NpgsqlPoint(x: 0.8585840358560949d, y: 0.22681690183439662d), new NpgsqlTypes.NpgsqlPoint(x: 0.9385038904113805d, y: 0.9646596195683339d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15297983160769446d, y: 0.4731671418770299d), new NpgsqlTypes.NpgsqlPoint(x: 0.023310832870071185d, y: 0.23257300502603995d), new NpgsqlTypes.NpgsqlPoint(x: 0.9258448079067766d, y: 0.3912041805848616d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8476562395462219d, y: 0.4645526493779297d), new NpgsqlTypes.NpgsqlPoint(x: 0.07276860660413287d, y: 0.4609956939279317d), new NpgsqlTypes.NpgsqlPoint(x: 0.37274759911293176d, y: 0.7988308562078837d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6054860441606457d, y: 0.7926696065451673d), new NpgsqlTypes.NpgsqlPoint(x: 0.3750658908875111d, y: 0.5813226721342118d), new NpgsqlTypes.NpgsqlPoint(x: 0.907200988596946d, y: 0.12111830254368328d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2539961294345431d, y: 0.5612185404190574d), new NpgsqlTypes.NpgsqlPoint(x: 0.8426469739690878d, y: 0.1206423284195407d), new NpgsqlTypes.NpgsqlPoint(x: 0.24012397731432367d, y: 0.6927798211596374d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05238014212165154d, y: 0.5726846502659282d), new NpgsqlTypes.NpgsqlPoint(x: 0.3606222220798172d, y: 0.5970522090279752d), new NpgsqlTypes.NpgsqlPoint(x: 0.9555562036869173d, y: 0.1617829115464534d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7828683865565389d, y: 0.8574891440372998d), new NpgsqlTypes.NpgsqlPoint(x: 0.6862444573770693d, y: 0.7467258643172467d), new NpgsqlTypes.NpgsqlPoint(x: 0.6315175510889718d, y: 0.37774262767806555d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 143,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27740934596788114d, y: 0.8937261556599232d), new NpgsqlTypes.NpgsqlPoint(x: 0.33067728757687176d, y: 0.6750888424978848d), new NpgsqlTypes.NpgsqlPoint(x: 0.6887593062489575d, y: 0.9960567291930631d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4764542361550319d, y: 0.6641722340895428d), new NpgsqlTypes.NpgsqlPoint(x: 0.4035729338675229d, y: 0.6159689841101944d), new NpgsqlTypes.NpgsqlPoint(x: 0.48024193957711503d, y: 0.8802911169832333d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04408143954053745d, y: 0.10039009705113222d), new NpgsqlTypes.NpgsqlPoint(x: 0.20948255962047613d, y: 0.6391642633526292d), new NpgsqlTypes.NpgsqlPoint(x: 0.1589480672636041d, y: 0.7544079330939278d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6718747443853522d, y: 0.8236286702118106d), new NpgsqlTypes.NpgsqlPoint(x: 0.8395294190533332d, y: 0.14914824789096293d), new NpgsqlTypes.NpgsqlPoint(x: 0.13641207402272315d, y: 0.44072554006729125d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9532995563265668d, y: 0.392427186233945d), new NpgsqlTypes.NpgsqlPoint(x: 0.6374191829564441d, y: 0.0316625413508681d), new NpgsqlTypes.NpgsqlPoint(x: 0.653186807494516d, y: 0.5093678024265551d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.608765475877275d, y: 0.5377670824035793d), new NpgsqlTypes.NpgsqlPoint(x: 0.7076843175234211d, y: 0.28273343112898286d), new NpgsqlTypes.NpgsqlPoint(x: 0.8885334429405646d, y: 0.1888573772648503d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8723839732196726d, y: 0.8798276608744775d), new NpgsqlTypes.NpgsqlPoint(x: 0.1684777699626876d, y: 0.02360998059466346d), new NpgsqlTypes.NpgsqlPoint(x: 0.818476052646103d, y: 0.7175987319483129d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0016257446036223033d, y: 0.30345174347366044d), new NpgsqlTypes.NpgsqlPoint(x: 0.25853920369936334d, y: 0.8597046825201146d), new NpgsqlTypes.NpgsqlPoint(x: 0.10025170617273516d, y: 0.7076564216632657d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4440426796680913d, y: 0.4049859351431182d), new NpgsqlTypes.NpgsqlPoint(x: 0.6631646814641566d, y: 0.49390404370415486d), new NpgsqlTypes.NpgsqlPoint(x: 0.45584902931963134d, y: 0.08722431628717464d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 149,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5128483984451531d, y: 0.6241959806555013d), new NpgsqlTypes.NpgsqlPoint(x: 0.9751986172277433d, y: 0.3348987662605776d), new NpgsqlTypes.NpgsqlPoint(x: 0.7173500207972389d, y: 0.32772453332356566d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09548125824813991d, y: 0.7392642717315409d), new NpgsqlTypes.NpgsqlPoint(x: 0.8379383226874845d, y: 0.6173652864716703d), new NpgsqlTypes.NpgsqlPoint(x: 0.44110528139434757d, y: 0.6276353346179544d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10942994694889863d, y: 0.5317207730513752d), new NpgsqlTypes.NpgsqlPoint(x: 0.5232539800519185d, y: 0.627053182522403d), new NpgsqlTypes.NpgsqlPoint(x: 0.21990738978800717d, y: 0.40853055561113316d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5703590909407512d, y: 0.6657862048176133d), new NpgsqlTypes.NpgsqlPoint(x: 0.049437181511630124d, y: 0.5536287171216587d), new NpgsqlTypes.NpgsqlPoint(x: 0.1062126089869716d, y: 0.08112039993028386d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 150,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5495850183524178d, y: 0.03296217885944808d), new NpgsqlTypes.NpgsqlPoint(x: 0.8823956671744064d, y: 0.5697643691823313d), new NpgsqlTypes.NpgsqlPoint(x: 0.11805184455585671d, y: 0.8303787570119092d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5840218615547571d, y: 0.5768498611814536d), new NpgsqlTypes.NpgsqlPoint(x: 0.4688098304642938d, y: 0.360976852986833d), new NpgsqlTypes.NpgsqlPoint(x: 0.37833204270597787d, y: 0.897723370349576d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3162521428885282d, y: 0.1897209298891943d), new NpgsqlTypes.NpgsqlPoint(x: 0.7129273486218818d, y: 0.9353194228552277d), new NpgsqlTypes.NpgsqlPoint(x: 0.3022498002957863d, y: 0.1930320758144709d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06313079913364983d, y: 0.24944082091239295d), new NpgsqlTypes.NpgsqlPoint(x: 0.7118548487988486d, y: 0.8306199011026826d), new NpgsqlTypes.NpgsqlPoint(x: 0.004111271092392732d, y: 0.035962699686114874d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6044675310941312d, y: 0.3717042898710461d), new NpgsqlTypes.NpgsqlPoint(x: 0.12625860735310834d, y: 0.3735267352977951d), new NpgsqlTypes.NpgsqlPoint(x: 0.20432135500757864d, y: 0.7837576224718138d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7566598527234834d, y: 0.90209354205188d), new NpgsqlTypes.NpgsqlPoint(x: 0.9102219548533921d, y: 0.5045199737442305d), new NpgsqlTypes.NpgsqlPoint(x: 0.017598477991823014d, y: 0.8296951146215304d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8934628146245958d, y: 0.7997446970171609d), new NpgsqlTypes.NpgsqlPoint(x: 0.9634638051332257d, y: 0.34152825058493874d), new NpgsqlTypes.NpgsqlPoint(x: 0.7247895875075321d, y: 0.44111724666463703d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.695591721386617d, y: 0.3855931218784673d), new NpgsqlTypes.NpgsqlPoint(x: 0.7268181873465817d, y: 0.0946850718352702d), new NpgsqlTypes.NpgsqlPoint(x: 0.6583401605336122d, y: 0.021977282357081074d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13680542472038326d, y: 0.26569934326263867d), new NpgsqlTypes.NpgsqlPoint(x: 0.2157143077976411d, y: 0.5859394472366891d), new NpgsqlTypes.NpgsqlPoint(x: 0.967256164262809d, y: 0.5696058394945366d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3656000037754351d, y: 0.24271032654514035d), new NpgsqlTypes.NpgsqlPoint(x: 0.27604748991980976d, y: 0.1267823994999473d), new NpgsqlTypes.NpgsqlPoint(x: 0.1185404711203687d, y: 0.8575842619765608d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29274482459366125d, y: 0.8678195444875614d), new NpgsqlTypes.NpgsqlPoint(x: 0.00788930301716051d, y: 0.25137866038396517d), new NpgsqlTypes.NpgsqlPoint(x: 0.5805220523552691d, y: 0.7305363643596389d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 157,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9023305121989478d, y: 0.6131061292240196d), new NpgsqlTypes.NpgsqlPoint(x: 0.45872668739296485d, y: 0.7399318215907885d), new NpgsqlTypes.NpgsqlPoint(x: 0.6516428158386022d, y: 0.31559013330906094d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.364878853158467d, y: 0.0033720555247280792d), new NpgsqlTypes.NpgsqlPoint(x: 0.9932058421934228d, y: 0.6367443018485252d), new NpgsqlTypes.NpgsqlPoint(x: 0.2897688031721224d, y: 0.4944559657722798d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7185173835105104d, y: 0.46505041474736475d), new NpgsqlTypes.NpgsqlPoint(x: 0.97194018989242d, y: 0.49286695458041874d), new NpgsqlTypes.NpgsqlPoint(x: 0.4318897375175976d, y: 0.5799834055257616d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 163,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.817826834900754d, y: 0.6734696825854205d), new NpgsqlTypes.NpgsqlPoint(x: 0.2856255632681932d, y: 0.9790881256677146d), new NpgsqlTypes.NpgsqlPoint(x: 0.28558465322518656d, y: 0.5887997542701346d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4487244303716931d, y: 0.5189905267721134d), new NpgsqlTypes.NpgsqlPoint(x: 0.979706161600112d, y: 0.931843993458476d), new NpgsqlTypes.NpgsqlPoint(x: 0.6975633314684702d, y: 0.03871786403700328d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8205819817934971d, y: 0.2787507154924508d), new NpgsqlTypes.NpgsqlPoint(x: 0.7853680132039811d, y: 0.30499127070347964d), new NpgsqlTypes.NpgsqlPoint(x: 0.4306019816657678d, y: 0.20085400176684443d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07261115940106866d, y: 0.363242239546413d), new NpgsqlTypes.NpgsqlPoint(x: 0.49536046199439276d, y: 0.00478761504111469d), new NpgsqlTypes.NpgsqlPoint(x: 0.34330264198044735d, y: 0.5364427708117674d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.008693401650740062d, y: 0.6331944158325226d), new NpgsqlTypes.NpgsqlPoint(x: 0.29682799633224943d, y: 0.24136804287323366d), new NpgsqlTypes.NpgsqlPoint(x: 0.0712895118247232d, y: 0.568348263948019d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9437315277168136d, y: 0.5784033312074226d), new NpgsqlTypes.NpgsqlPoint(x: 0.31772035112237484d, y: 0.6331207597252005d), new NpgsqlTypes.NpgsqlPoint(x: 0.47004622249573813d, y: 0.23136015929853482d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9434403326197066d, y: 0.294598255086138d), new NpgsqlTypes.NpgsqlPoint(x: 0.13992325063955313d, y: 0.6114530245606983d), new NpgsqlTypes.NpgsqlPoint(x: 0.1273517295789346d, y: 0.3325821729422911d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02819353590312923d, y: 0.22490773378464368d), new NpgsqlTypes.NpgsqlPoint(x: 0.41701713749265656d, y: 0.5769787152440858d), new NpgsqlTypes.NpgsqlPoint(x: 0.8670986995629673d, y: 0.007811662780527584d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8670888062678513d, y: 0.24919516255985796d), new NpgsqlTypes.NpgsqlPoint(x: 0.2051121462220281d, y: 0.7996281686857372d), new NpgsqlTypes.NpgsqlPoint(x: 0.15290988983725995d, y: 0.42943664182960073d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5219753734416802d, y: 0.6912083698657094d), new NpgsqlTypes.NpgsqlPoint(x: 0.6442284909194992d, y: 0.27848698482028245d), new NpgsqlTypes.NpgsqlPoint(x: 0.5944951024444101d, y: 0.16190557243455372d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 165,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38917937376839684d, y: 0.9151650143796762d), new NpgsqlTypes.NpgsqlPoint(x: 0.2259069519580914d, y: 0.6805750304250903d), new NpgsqlTypes.NpgsqlPoint(x: 0.9621271494668051d, y: 0.19167176046594092d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21286401293228563d, y: 0.14184032161141613d), new NpgsqlTypes.NpgsqlPoint(x: 0.24163401859899702d, y: 0.41701811799615174d), new NpgsqlTypes.NpgsqlPoint(x: 0.5004389493110613d, y: 0.6634854343264536d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3333069761129156d, y: 0.20695959642235762d), new NpgsqlTypes.NpgsqlPoint(x: 0.18329957894228033d, y: 0.751045182361827d), new NpgsqlTypes.NpgsqlPoint(x: 0.3298050629336756d, y: 0.7723182245185836d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8388107640496434d, y: 0.7362544060785602d), new NpgsqlTypes.NpgsqlPoint(x: 0.2604043214950458d, y: 0.7433171487936645d), new NpgsqlTypes.NpgsqlPoint(x: 0.2308744896578877d, y: 0.4016321118643148d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 166,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20079106157027105d, y: 0.22404816147558593d), new NpgsqlTypes.NpgsqlPoint(x: 0.8890350773443138d, y: 0.6729745696327398d), new NpgsqlTypes.NpgsqlPoint(x: 0.15891431702029424d, y: 0.6247080789160014d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37078080559409743d, y: 0.8896014165046804d), new NpgsqlTypes.NpgsqlPoint(x: 0.12851633773356164d, y: 0.1505623135414894d), new NpgsqlTypes.NpgsqlPoint(x: 0.4030091457222893d, y: 0.5171820084415827d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.468157266353981d, y: 0.729950538596912d), new NpgsqlTypes.NpgsqlPoint(x: 0.568186931859677d, y: 0.3983473136938188d), new NpgsqlTypes.NpgsqlPoint(x: 0.28452434061820897d, y: 0.0838703447335507d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.057783206435491064d, y: 0.7256073788500738d), new NpgsqlTypes.NpgsqlPoint(x: 0.7306300117235905d, y: 0.9648993203328966d), new NpgsqlTypes.NpgsqlPoint(x: 0.31649274738157285d, y: 0.10102067944689164d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10621201447445705d, y: 0.5822745471646286d), new NpgsqlTypes.NpgsqlPoint(x: 0.6430099832289691d, y: 0.9369632601125624d), new NpgsqlTypes.NpgsqlPoint(x: 0.09342265083811774d, y: 0.006641511531903843d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09307422954186051d, y: 0.07171375023046356d), new NpgsqlTypes.NpgsqlPoint(x: 0.020259696257722393d, y: 0.7191112328362829d), new NpgsqlTypes.NpgsqlPoint(x: 0.5025196691765715d, y: 0.443266559839107d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9880501702437625d, y: 0.5558320810393359d), new NpgsqlTypes.NpgsqlPoint(x: 0.26008680394986383d, y: 0.7904137739001457d), new NpgsqlTypes.NpgsqlPoint(x: 0.5981533589423135d, y: 0.3691082188090845d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5032101403509656d, y: 0.7946461024601238d), new NpgsqlTypes.NpgsqlPoint(x: 0.2847510196485651d, y: 0.5718637382223566d), new NpgsqlTypes.NpgsqlPoint(x: 0.16659411250094913d, y: 0.4020324373865024d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5032561643675088d, y: 0.5050394763072535d), new NpgsqlTypes.NpgsqlPoint(x: 0.4428433875084763d, y: 0.17005084188535746d), new NpgsqlTypes.NpgsqlPoint(x: 0.5286461072698085d, y: 0.03547228015689352d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5543433009057703d, y: 0.4086364735866853d), new NpgsqlTypes.NpgsqlPoint(x: 0.6423755349302724d, y: 0.35338175920919157d), new NpgsqlTypes.NpgsqlPoint(x: 0.5900047764704857d, y: 0.7135008878942977d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 175,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2494778739131681d, y: 0.7612996045799544d), new NpgsqlTypes.NpgsqlPoint(x: 0.22553286337877065d, y: 0.01628756577812296d), new NpgsqlTypes.NpgsqlPoint(x: 0.09542164469771464d, y: 0.5217986539049512d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22951338487430217d, y: 0.7984621958564462d), new NpgsqlTypes.NpgsqlPoint(x: 0.4430664401105304d, y: 0.628284866116694d), new NpgsqlTypes.NpgsqlPoint(x: 0.8138664512210187d, y: 0.3094122758496838d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47043661735290276d, y: 0.34262774566744814d), new NpgsqlTypes.NpgsqlPoint(x: 0.3791921591758999d, y: 0.9060629680846075d), new NpgsqlTypes.NpgsqlPoint(x: 0.8844429164332769d, y: 0.26615132054051194d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5849988761245871d, y: 0.4407005179476565d), new NpgsqlTypes.NpgsqlPoint(x: 0.6924967534724862d, y: 0.10684928957059425d), new NpgsqlTypes.NpgsqlPoint(x: 0.20301425260242678d, y: 0.507768127737677d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11148892329131033d, y: 0.2518979785568356d), new NpgsqlTypes.NpgsqlPoint(x: 0.34541683931411704d, y: 0.9965725928416347d), new NpgsqlTypes.NpgsqlPoint(x: 0.9612393145228507d, y: 0.12742791541654463d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4064178581806419d, y: 0.22602403843636132d), new NpgsqlTypes.NpgsqlPoint(x: 0.7530760006361562d, y: 0.8618920148022521d), new NpgsqlTypes.NpgsqlPoint(x: 0.17662271341637925d, y: 0.9802742813107345d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15626492322947305d, y: 0.11730169009799085d), new NpgsqlTypes.NpgsqlPoint(x: 0.342960015602203d, y: 0.2189755022150277d), new NpgsqlTypes.NpgsqlPoint(x: 0.9254901440701916d, y: 0.8494401683171471d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.58937048064732d, y: 0.9037600261140389d), new NpgsqlTypes.NpgsqlPoint(x: 0.568492877277721d, y: 0.41973027944800423d), new NpgsqlTypes.NpgsqlPoint(x: 0.017927736584583687d, y: 0.8145482743346927d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 176,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.698781937000926d, y: 0.5870397614133451d), new NpgsqlTypes.NpgsqlPoint(x: 0.1551108138718419d, y: 0.9327299168745052d), new NpgsqlTypes.NpgsqlPoint(x: 0.10814333320508307d, y: 0.09653989177791178d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9101410917007163d, y: 0.4371067289564676d), new NpgsqlTypes.NpgsqlPoint(x: 0.8993570992244041d, y: 0.10287658325189031d), new NpgsqlTypes.NpgsqlPoint(x: 0.5386302530192171d, y: 0.9803503769982777d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33191983320874885d, y: 0.5116163574890372d), new NpgsqlTypes.NpgsqlPoint(x: 0.9578247324234714d, y: 0.9226354854281268d), new NpgsqlTypes.NpgsqlPoint(x: 0.984653118309277d, y: 0.14895183913542331d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9221962392022046d, y: 0.22880713667308406d), new NpgsqlTypes.NpgsqlPoint(x: 0.5102564196167365d, y: 0.1415640251197624d), new NpgsqlTypes.NpgsqlPoint(x: 0.4443373661796737d, y: 0.18523008671021945d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14791773610327974d, y: 0.11418531967256385d), new NpgsqlTypes.NpgsqlPoint(x: 0.9520927039225714d, y: 0.7215627812911788d), new NpgsqlTypes.NpgsqlPoint(x: 0.3809941537162409d, y: 0.9153986771508095d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4699450011679074d, y: 0.39951824059596974d), new NpgsqlTypes.NpgsqlPoint(x: 0.48992098340663104d, y: 0.8711566512873024d), new NpgsqlTypes.NpgsqlPoint(x: 0.36649830382683946d, y: 0.7583520037064051d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5657149054656908d, y: 0.7437332067463989d), new NpgsqlTypes.NpgsqlPoint(x: 0.9898807082305134d, y: 0.3080506512721177d), new NpgsqlTypes.NpgsqlPoint(x: 0.06987428716130661d, y: 0.4895808538027936d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7679740869665351d, y: 0.7635088736518018d), new NpgsqlTypes.NpgsqlPoint(x: 0.18529995840060676d, y: 0.4454725498732047d), new NpgsqlTypes.NpgsqlPoint(x: 0.4097013536182763d, y: 0.9939803914100019d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8400354829606032d, y: 0.24689633648621467d), new NpgsqlTypes.NpgsqlPoint(x: 0.9311963522127121d, y: 0.9989849646784551d), new NpgsqlTypes.NpgsqlPoint(x: 0.12840116618782893d, y: 0.0008393272264551888d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11990842535519153d, y: 0.323736061092886d), new NpgsqlTypes.NpgsqlPoint(x: 0.027439591470599156d, y: 0.06610384549756265d), new NpgsqlTypes.NpgsqlPoint(x: 0.21432799635398303d, y: 0.5611377052974958d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09381049959798893d, y: 0.6532231938764819d), new NpgsqlTypes.NpgsqlPoint(x: 0.18789776429617688d, y: 0.9668285174631625d), new NpgsqlTypes.NpgsqlPoint(x: 0.5169335083799168d, y: 0.5528896290149001d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 181,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6154180700948878d, y: 0.4772248723115363d), new NpgsqlTypes.NpgsqlPoint(x: 0.4175533929971682d, y: 0.3165593497166045d), new NpgsqlTypes.NpgsqlPoint(x: 0.14914988700475973d, y: 0.6495060953644338d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.86769802494995d, y: 0.5235296711205037d), new NpgsqlTypes.NpgsqlPoint(x: 0.556377604937881d, y: 0.5043611891065243d), new NpgsqlTypes.NpgsqlPoint(x: 0.8055642211832134d, y: 0.4631332276073439d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4923817574000654d, y: 0.13180022031212457d), new NpgsqlTypes.NpgsqlPoint(x: 0.13922142223645695d, y: 0.7246381229402172d), new NpgsqlTypes.NpgsqlPoint(x: 0.03708756180116746d, y: 0.7816627327414446d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8273787155234895d, y: 0.263690773104964d), new NpgsqlTypes.NpgsqlPoint(x: 0.15371908574263238d, y: 0.5927636516161157d), new NpgsqlTypes.NpgsqlPoint(x: 0.31028366153408693d, y: 0.47701958895553154d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15093041499569093d, y: 0.12509578838772906d), new NpgsqlTypes.NpgsqlPoint(x: 0.8985237131080404d, y: 0.5174559487566162d), new NpgsqlTypes.NpgsqlPoint(x: 0.8495827089069996d, y: 0.5530380619917608d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2662541031629154d, y: 0.8607107677675497d), new NpgsqlTypes.NpgsqlPoint(x: 0.685325124196981d, y: 0.5564799502292804d), new NpgsqlTypes.NpgsqlPoint(x: 0.007933129781883985d, y: 0.03641588024935305d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6212762068220337d, y: 0.5490597255730614d), new NpgsqlTypes.NpgsqlPoint(x: 0.011297137269027369d, y: 0.886257934248874d), new NpgsqlTypes.NpgsqlPoint(x: 0.9574031775022213d, y: 0.7063019435268761d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 182,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9084896215670268d, y: 0.19304973721210839d), new NpgsqlTypes.NpgsqlPoint(x: 0.05432431652077385d, y: 0.48400291631716985d), new NpgsqlTypes.NpgsqlPoint(x: 0.45910099593622455d, y: 0.5456081174585041d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.757600610283928d, y: 0.049970562649022d), new NpgsqlTypes.NpgsqlPoint(x: 0.9319397404136901d, y: 0.5449599002924137d), new NpgsqlTypes.NpgsqlPoint(x: 0.6681140639220109d, y: 0.7604142876200262d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.827063944304107d, y: 0.3164395387786634d), new NpgsqlTypes.NpgsqlPoint(x: 0.2121224773510073d, y: 0.35804100906507896d), new NpgsqlTypes.NpgsqlPoint(x: 0.7453526845171514d, y: 0.4068883493629901d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17654112820329793d, y: 0.8467019124711439d), new NpgsqlTypes.NpgsqlPoint(x: 0.09037408729220642d, y: 0.8637357560334379d), new NpgsqlTypes.NpgsqlPoint(x: 0.07194188954020864d, y: 0.7321152277647526d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7080856142275205d, y: 0.30747311306901304d), new NpgsqlTypes.NpgsqlPoint(x: 0.5605642823390442d, y: 0.4358100481902052d), new NpgsqlTypes.NpgsqlPoint(x: 0.2779503897176038d, y: 0.7456324537614781d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8984262373478793d, y: 0.12341330259051753d), new NpgsqlTypes.NpgsqlPoint(x: 0.8111220200606304d, y: 0.175500519084832d), new NpgsqlTypes.NpgsqlPoint(x: 0.5504373244711381d, y: 0.3842713589758652d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.032458283402246324d, y: 0.3314393500127415d), new NpgsqlTypes.NpgsqlPoint(x: 0.5319917697514329d, y: 0.560206033294222d), new NpgsqlTypes.NpgsqlPoint(x: 0.19028518649116d, y: 0.44831985883148673d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6803883894764183d, y: 0.39667938385381385d), new NpgsqlTypes.NpgsqlPoint(x: 0.5195551978685785d, y: 0.8831986671301558d), new NpgsqlTypes.NpgsqlPoint(x: 0.48915664737233133d, y: 0.30130663230836163d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3576703303076748d, y: 0.0442726754792665d), new NpgsqlTypes.NpgsqlPoint(x: 0.5972843190543944d, y: 0.50216145253203d), new NpgsqlTypes.NpgsqlPoint(x: 0.03834804639571576d, y: 0.5600541060507478d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6209290792821052d, y: 0.3334769717373298d), new NpgsqlTypes.NpgsqlPoint(x: 0.19322606692647026d, y: 0.7239586400859596d), new NpgsqlTypes.NpgsqlPoint(x: 0.4780986383943898d, y: 0.04983983664223679d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 191,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4231210933213445d, y: 0.32177726617947733d), new NpgsqlTypes.NpgsqlPoint(x: 0.6518540121629737d, y: 0.9035401912405339d), new NpgsqlTypes.NpgsqlPoint(x: 0.7819888225372261d, y: 0.8637193751481824d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6810819394639844d, y: 0.3267976158072723d), new NpgsqlTypes.NpgsqlPoint(x: 0.8021146198743708d, y: 0.6125329021138789d), new NpgsqlTypes.NpgsqlPoint(x: 0.9079462419773715d, y: 0.16791693863452173d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22748282050848112d, y: 0.5685273899097655d), new NpgsqlTypes.NpgsqlPoint(x: 0.42788932778679634d, y: 0.10481646300810288d), new NpgsqlTypes.NpgsqlPoint(x: 0.9030847856101696d, y: 0.20986675075015437d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08313403396457475d, y: 0.46155342784313746d), new NpgsqlTypes.NpgsqlPoint(x: 0.8718407548384656d, y: 0.006616614655135411d), new NpgsqlTypes.NpgsqlPoint(x: 0.36769592166963994d, y: 0.09305197089052486d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7394067883094754d, y: 0.7944833070424145d), new NpgsqlTypes.NpgsqlPoint(x: 0.7915312605282424d, y: 0.31058889694368497d), new NpgsqlTypes.NpgsqlPoint(x: 0.2717385986975851d, y: 0.4136554377841333d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.814605011932316d, y: 0.5423809545647972d), new NpgsqlTypes.NpgsqlPoint(x: 0.31356135972332067d, y: 0.05332313417621848d), new NpgsqlTypes.NpgsqlPoint(x: 0.6224787282645201d, y: 0.7394811545711603d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5084426212989227d, y: 0.36262828874152964d), new NpgsqlTypes.NpgsqlPoint(x: 0.8841827605763443d, y: 0.45031782894821826d), new NpgsqlTypes.NpgsqlPoint(x: 0.41309446384815784d, y: 0.18229718380456306d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 193,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07845683874653286d, y: 0.2228019305998019d), new NpgsqlTypes.NpgsqlPoint(x: 0.9239037027671868d, y: 0.6675092612122542d), new NpgsqlTypes.NpgsqlPoint(x: 0.9013228682312802d, y: 0.7452238523551907d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5807848785881352d, y: 0.20996800416315398d), new NpgsqlTypes.NpgsqlPoint(x: 0.8260058525500572d, y: 0.17266566671099715d), new NpgsqlTypes.NpgsqlPoint(x: 0.49911728145230816d, y: 0.6384704447157088d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.011537562165081616d, y: 0.7698856769694148d), new NpgsqlTypes.NpgsqlPoint(x: 0.42635206782312784d, y: 0.22871749649665585d), new NpgsqlTypes.NpgsqlPoint(x: 0.875005345648538d, y: 0.6006648036986606d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3749942679122026d, y: 0.9965621530140208d), new NpgsqlTypes.NpgsqlPoint(x: 0.45275650507871334d, y: 0.4384203884266996d), new NpgsqlTypes.NpgsqlPoint(x: 0.6380782657255321d, y: 0.07472053706066961d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4264548367523273d, y: 0.09541545683605834d), new NpgsqlTypes.NpgsqlPoint(x: 0.20187375448830724d, y: 0.4974174933604337d), new NpgsqlTypes.NpgsqlPoint(x: 0.6769392261066871d, y: 0.6553483159083984d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.049596691454900976d, y: 0.13915348291022567d), new NpgsqlTypes.NpgsqlPoint(x: 0.43593478495354776d, y: 0.9078508599169065d), new NpgsqlTypes.NpgsqlPoint(x: 0.4096377726292837d, y: 0.3053251535965804d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7266449654209979d, y: 0.03181728637535375d), new NpgsqlTypes.NpgsqlPoint(x: 0.4432404027915954d, y: 0.09086945275940472d), new NpgsqlTypes.NpgsqlPoint(x: 0.45765633981742004d, y: 0.27565274851307153d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5110105805167507d, y: 0.6251420049935407d), new NpgsqlTypes.NpgsqlPoint(x: 0.43612744182795293d, y: 0.7641796592779567d), new NpgsqlTypes.NpgsqlPoint(x: 0.4133169533674874d, y: 0.37450995700643563d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17269796662386583d, y: 0.5676660480331384d), new NpgsqlTypes.NpgsqlPoint(x: 0.05806991037337639d, y: 0.37620368168437457d), new NpgsqlTypes.NpgsqlPoint(x: 0.7109577181019445d, y: 0.719045262899411d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9785707985179242d, y: 0.7032169849022258d), new NpgsqlTypes.NpgsqlPoint(x: 0.6725210751856847d, y: 0.568626303179505d), new NpgsqlTypes.NpgsqlPoint(x: 0.19178512041918516d, y: 0.2778225159800778d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33504424821052947d, y: 0.12481536597107457d), new NpgsqlTypes.NpgsqlPoint(x: 0.09313978156405045d, y: 0.013693971242646596d), new NpgsqlTypes.NpgsqlPoint(x: 0.22175698135392752d, y: 0.07867284576966982d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 202,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5958238324825459d, y: 0.5689879036636467d), new NpgsqlTypes.NpgsqlPoint(x: 0.28650031255730535d, y: 0.15143251583566186d), new NpgsqlTypes.NpgsqlPoint(x: 0.9518019807253733d, y: 0.3027152706559887d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7627740430996801d, y: 0.7581597375012734d), new NpgsqlTypes.NpgsqlPoint(x: 0.6612327470215698d, y: 0.6355665172078425d), new NpgsqlTypes.NpgsqlPoint(x: 0.6041237814356463d, y: 0.332542504214966d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12790915220815846d, y: 0.7150535519558834d), new NpgsqlTypes.NpgsqlPoint(x: 0.6069536131160506d, y: 0.7193748253993519d), new NpgsqlTypes.NpgsqlPoint(x: 0.16693413249339528d, y: 0.45316399247859385d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38633929045487425d, y: 0.3490770955632859d), new NpgsqlTypes.NpgsqlPoint(x: 0.47476215784702946d, y: 0.2321052656128444d), new NpgsqlTypes.NpgsqlPoint(x: 0.39322811507751d, y: 0.44813814176619393d)),
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray1mi(
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
INSERT INTO public.npgsqlpolygonpolygonarray1mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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

                changedRows =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray1mi_id
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)), 
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
                methodParametrName: "npgsqlpolygonpolygonarray1mi_id", 
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
                changedRows =  ((INpgsqlPolygonArraypolygonArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPolygonArraypolygonArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray1mi_id
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
    npgsqlpolygonpolygonarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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

                    nullable =  ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18977680899555782d, y: 0.8514678474507711d), new NpgsqlTypes.NpgsqlPoint(x: 0.7298393164226261d, y: 0.3810370325874597d), new NpgsqlTypes.NpgsqlPoint(x: 0.5308378343014972d, y: 0.8684275309279744d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.019414176921010662d, y: 0.31089044625278794d), new NpgsqlTypes.NpgsqlPoint(x: 0.07538185028156252d, y: 0.6347535384957151d), new NpgsqlTypes.NpgsqlPoint(x: 0.11830873229216621d, y: 0.8365191172276443d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7390600529558103d, y: 0.6402974242931532d), new NpgsqlTypes.NpgsqlPoint(x: 0.9168583784494336d, y: 0.3661286229436861d), new NpgsqlTypes.NpgsqlPoint(x: 0.8328955929979964d, y: 0.4317217093026806d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45461612993267364d, y: 0.37156290948677806d), new NpgsqlTypes.NpgsqlPoint(x: 0.6256415258343436d, y: 0.7720707660671126d), new NpgsqlTypes.NpgsqlPoint(x: 0.25217638062736625d, y: 0.5971374296540983d)),
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

                    nullable =  ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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

                    nullable = await ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7066545579121339d, y: 0.9137898782974188d), new NpgsqlTypes.NpgsqlPoint(x: 0.5213898540417543d, y: 0.4916515916218607d), new NpgsqlTypes.NpgsqlPoint(x: 0.8801020543270173d, y: 0.4200806029302532d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8045467605463843d, y: 0.19407916201295583d), new NpgsqlTypes.NpgsqlPoint(x: 0.9636957633619654d, y: 0.8919059199419187d), new NpgsqlTypes.NpgsqlPoint(x: 0.8619933168142331d, y: 0.17431497265978935d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2013939903668832d, y: 0.659697555606938d), new NpgsqlTypes.NpgsqlPoint(x: 0.5735527156275123d, y: 0.9486872463040396d), new NpgsqlTypes.NpgsqlPoint(x: 0.44043998283156893d, y: 0.14946192954238735d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.042471929578601686d, y: 0.7970976201654544d), new NpgsqlTypes.NpgsqlPoint(x: 0.35210633447737494d, y: 0.8302076530440597d), new NpgsqlTypes.NpgsqlPoint(x: 0.9346344454286669d, y: 0.15734129242184747d)),
}));
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

                    nullable = await ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray1mi_id
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
    npgsqlpolygonpolygonarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                methodParametrName: "npgsqlpolygonpolygonarray1mi_id", 
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
                nullable =  ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4656787558239007d, y: 0.04322303442895725d), new NpgsqlTypes.NpgsqlPoint(x: 0.8294382840772369d, y: 0.9486050301348503d), new NpgsqlTypes.NpgsqlPoint(x: 0.8497474103934524d, y: 0.025194382595473797d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6513264697440887d, y: 0.5053560278129539d), new NpgsqlTypes.NpgsqlPoint(x: 0.7443507021489462d, y: 0.14809383268552778d), new NpgsqlTypes.NpgsqlPoint(x: 0.8014935361590758d, y: 0.20483091834758893d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.650885210493337d, y: 0.9247766357540961d), new NpgsqlTypes.NpgsqlPoint(x: 0.5397589472865799d, y: 0.34563005253665213d), new NpgsqlTypes.NpgsqlPoint(x: 0.931809987706186d, y: 0.5344291461866799d)),
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
                nullable = await ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonArray1M> models = null;

                models =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonArray1M> models = null;

                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M), typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                ((INpgsqlPolygonArraypolygonArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPolygonArraypolygonArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPolygonArraypolygonArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                var models = await ((INpgsqlPolygonArraypolygonArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPolygonArraypolygonArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M), typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                ((INpgsqlPolygonArraypolygonArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonArraypolygonArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonArraypolygonArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                var models = await ((INpgsqlPolygonArraypolygonArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPolygonArraypolygonArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M), typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 182;
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 181;
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                ((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 95;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 176;
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                 ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 103;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 70;
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                 ((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[24],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 41;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[28],_testData[34], false);
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
                parametr1.Value = 70;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 110;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                 ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                var models = await((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 175;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[29], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[30], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[31], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[32], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[33], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[29], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[30], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[31], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[32], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[33], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[34], false);
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
                var models = ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[20], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[21], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[22], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[23], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[24], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[25], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[26], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[27], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[29], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[30], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[31], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[32], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[33], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[17], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[18], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[19], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[20], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[21], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[22], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[23], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[24], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[25], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[26], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[27], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[29], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[30], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[31], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[32], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[33], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M), typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 77, query1, 165, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 140, query1, 181, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                ((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                 ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 123, query1, 77, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                 ((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 39, query1, 90, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[21],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 65, query1, 103, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[25],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 70, query1, 175, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 24, query1, 32, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[30],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                 ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelBatch(connection, 181, query1, 176, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray1M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                var models = await((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTSelectModelBatchAsync(connection, 95, 82))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[14], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[15], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[16], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[17], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[18], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[19], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[20], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[21], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[22], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[23], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[24], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[25], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[26], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[27], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[29], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[30], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[31], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[32], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[33], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[29], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[30], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[31], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[32], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[33], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[34], false);
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
                var models = ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSTSelectModelBatch(connection, 90, 70))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[13], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[14], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[15], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[16], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[17], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[18], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[19], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[20], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[21], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[22], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[23], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[24], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[25], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[26], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[27], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[29], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[30], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[31], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[32], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[33], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[10], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[11], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[12], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[13], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[14], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[15], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[16], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[17], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[18], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[19], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[20], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[21], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[22], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[23], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[24], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[25], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[26], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[27], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[28], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[29], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[30], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[31], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[32], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[33], false);
                        NpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPolygonArraypolygonArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPolygonArraypolygonArray)this).SetDbConnectionSelectModelParametrs(cmd, 82);
                var models = await ((INpgsqlPolygonArraypolygonArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(23));

                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[12], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[13], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[14], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[15], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[16], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[17], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[18], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[19], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[20], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[21], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[22], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[23], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[24], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[25], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[26], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[27], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[28], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[29], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[30], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[31], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[32], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[33], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonArraypolygonArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonArraypolygonArray)this).SetDbConnectionSelectModelParametrs(cmd, 149);
                var models =  ((INpgsqlPolygonArraypolygonArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(12));

                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[23], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[24], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[25], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[26], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[27], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[28], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[29], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[30], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[31], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[32], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[33], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[34], false);
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
FROM public.binary_npgsqlpolygonpolygonarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonArray1MIWA),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonArraypolygonArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonArraypolygonArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonArraypolygonArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonArraypolygonArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonArraypolygonArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonArraypolygonArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonArraypolygonArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonArraypolygonArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonArray1MI),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonArraypolygonArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonArraypolygonArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonArraypolygonArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonArraypolygonArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonArraypolygonArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonArraypolygonArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonArraypolygonArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonArraypolygonArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygonarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPolygonpolygonArray1M),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
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
FROM public.binary_npgsqlpolygonpolygonarray1m m
LEFT JOIN public.binary_npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonArraypolygonArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonArraypolygonArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonArraypolygonArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonArraypolygonArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygonarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                var models =  ((INpgsqlPolygonArraypolygonArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonArraypolygonArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MIWA), typeof(NpgsqlPolygonpolygonArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                var models1 = new List<NpgsqlPolygonpolygonArray1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonArray1MIWA>();
                await ((INpgsqlPolygonArraypolygonArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonArray1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonArray1MIWA>();
                ((INpgsqlPolygonArraypolygonArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                var models = await ((INpgsqlPolygonArraypolygonArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygonarray1mi
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
                    NpgsqlPolygonpolygonArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonArraypolygonArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygonarray1mi
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
                    NpgsqlPolygonpolygonArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MIWA), typeof(NpgsqlPolygonpolygonArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
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
                var models1 = new List<NpgsqlPolygonpolygonArray1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonArray1MIWA>();
                await ((INpgsqlPolygonArraypolygonArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonArray1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonArray1MIWA>();
                ((INpgsqlPolygonArraypolygonArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonarray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
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
                var models = await ((INpgsqlPolygonArraypolygonArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygonarray1mi
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
                    NpgsqlPolygonpolygonArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonArraypolygonArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygonarray1mi
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
                    NpgsqlPolygonpolygonArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygonarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MI), typeof(NpgsqlPolygonpolygonArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                var models1 = new List<NpgsqlPolygonpolygonArray1MI>();
                var models2 = new List<NpgsqlPolygonpolygonArray1MI>();
                await ((INpgsqlPolygonArraypolygonArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonArray1MI>();
                var models2 = new List<NpgsqlPolygonpolygonArray1MI>();
                ((INpgsqlPolygonArraypolygonArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                var models = await ((INpgsqlPolygonArraypolygonArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonArraypolygonArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygonarray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MIWA), typeof(NpgsqlPolygonpolygonArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
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
                var models1 = new List<NpgsqlPolygonpolygonArray1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonArray1MIWA>();
                await ((INpgsqlPolygonArraypolygonArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonArray1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonArray1MIWA>();
                ((INpgsqlPolygonArraypolygonArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
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
                var models = await ((INpgsqlPolygonArraypolygonArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonArraypolygonArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

