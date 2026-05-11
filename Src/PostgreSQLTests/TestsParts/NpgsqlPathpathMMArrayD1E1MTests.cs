

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
    internal partial interface INpgsqlPathMArraypathMMArrayD1
    {
    }
    
    internal partial class NpgsqlPathMArraypathMMArrayD1 : INpgsqlPathMArraypathMMArrayD1
    {


#region TestData

        private readonly NpgsqlPathpathMMArrayD1E1M[] _testData = new NpgsqlPathpathMMArrayD1E1M[]
        {
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2169050081213224d, y: 0.8137576468166505d), new NpgsqlTypes.NpgsqlPoint(x: 0.19808799278256195d, y: 0.40309775463219244d), new NpgsqlTypes.NpgsqlPoint(x: 0.4488554471816363d, y: 0.7705833933734356d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07794476064173639d, y: 0.3854096183096747d), new NpgsqlTypes.NpgsqlPoint(x: 0.08763853562693524d, y: 0.9297954539720976d), new NpgsqlTypes.NpgsqlPoint(x: 0.30406515356869945d, y: 0.6633170174736305d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8021424150549972d, y: 0.7532572701527503d), new NpgsqlTypes.NpgsqlPoint(x: 0.08004562748094879d, y: 0.253990384418447d), new NpgsqlTypes.NpgsqlPoint(x: 0.7049764432494932d, y: 0.7977915647562438d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.59911493692723d, y: 0.7825264246612537d), new NpgsqlTypes.NpgsqlPoint(x: 0.7679991406984492d, y: 0.7436351207389253d), new NpgsqlTypes.NpgsqlPoint(x: 0.712881938703214d, y: 0.9585651657272966d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9333617902805323d, y: 0.12841516990665025d), new NpgsqlTypes.NpgsqlPoint(x: 0.5397227626082133d, y: 0.972612324367083d), new NpgsqlTypes.NpgsqlPoint(x: 0.23768658711652746d, y: 0.9506211385899935d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6614082103267471d, y: 0.9544294446540281d), new NpgsqlTypes.NpgsqlPoint(x: 0.8317744243138971d, y: 0.6355142922124538d), new NpgsqlTypes.NpgsqlPoint(x: 0.010679673868602246d, y: 0.3330122401745539d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14609528314891163d, y: 0.3243450939563747d), new NpgsqlTypes.NpgsqlPoint(x: 0.7640821102149928d, y: 0.6392581905554292d), new NpgsqlTypes.NpgsqlPoint(x: 0.3318597785580599d, y: 0.1393456233151198d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7593543229078769d, y: 0.01946386525653665d), new NpgsqlTypes.NpgsqlPoint(x: 0.37183593182416086d, y: 0.7477214997104107d), new NpgsqlTypes.NpgsqlPoint(x: 0.17948581695302568d, y: 0.6709383182591391d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6504814110720849d, y: 0.08089207964266187d), new NpgsqlTypes.NpgsqlPoint(x: 0.5049173632931336d, y: 0.33341854765856116d), new NpgsqlTypes.NpgsqlPoint(x: 0.9754373692033426d, y: 0.24759084705128498d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5377250105097879d, y: 0.16306585678468877d), new NpgsqlTypes.NpgsqlPoint(x: 0.21027229665861036d, y: 0.13624489097433223d), new NpgsqlTypes.NpgsqlPoint(x: 0.7209137113481399d, y: 0.823489061150479d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7857044382666417d, y: 0.39357214290596165d), new NpgsqlTypes.NpgsqlPoint(x: 0.42273308899926865d, y: 0.11561025135293101d), new NpgsqlTypes.NpgsqlPoint(x: 0.6904168755768232d, y: 0.3590696168831303d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6813681084257098d, y: 0.3519047092586629d), new NpgsqlTypes.NpgsqlPoint(x: 0.3578929437248529d, y: 0.3882396051920145d), new NpgsqlTypes.NpgsqlPoint(x: 0.5990073442666676d, y: 0.7022437862530607d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7251642818819425d, y: 0.7456061646443504d), new NpgsqlTypes.NpgsqlPoint(x: 0.5401844006114712d, y: 0.381597005507716d), new NpgsqlTypes.NpgsqlPoint(x: 0.6059049141586472d, y: 0.22529013231145556d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.892314197041329d, y: 0.17385684666412116d), new NpgsqlTypes.NpgsqlPoint(x: 0.01870060096498205d, y: 0.641732624732803d), new NpgsqlTypes.NpgsqlPoint(x: 0.32026000005881283d, y: 0.26470654931224125d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45313517642602263d, y: 0.45472835760780095d), new NpgsqlTypes.NpgsqlPoint(x: 0.29186841942004815d, y: 0.6887380644899511d), new NpgsqlTypes.NpgsqlPoint(x: 0.9491606897745051d, y: 0.6160851109493599d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08176958530655676d, y: 0.5501167467627331d), new NpgsqlTypes.NpgsqlPoint(x: 0.755749685432134d, y: 0.9705630636546876d), new NpgsqlTypes.NpgsqlPoint(x: 0.08822219233335615d, y: 0.022242061378357603d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09408474141310108d, y: 0.34235922943177666d), new NpgsqlTypes.NpgsqlPoint(x: 0.989790215871114d, y: 0.7788347998957651d), new NpgsqlTypes.NpgsqlPoint(x: 0.24353578334226456d, y: 0.5214189701057417d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2763109443021221d, y: 0.7075866930128368d), new NpgsqlTypes.NpgsqlPoint(x: 0.5486051287001062d, y: 0.9955362704718879d), new NpgsqlTypes.NpgsqlPoint(x: 0.42965398630596197d, y: 0.7602270810308424d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14120501043207356d, y: 0.8074263678237991d), new NpgsqlTypes.NpgsqlPoint(x: 0.35549068945652174d, y: 0.929199309652809d), new NpgsqlTypes.NpgsqlPoint(x: 0.5016834603064528d, y: 0.5001883804457209d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.010389097523476942d, y: 0.003662325847502923d), new NpgsqlTypes.NpgsqlPoint(x: 0.5300182408266498d, y: 0.007603262094743046d), new NpgsqlTypes.NpgsqlPoint(x: 0.8911827415155247d, y: 0.987273314105356d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20833055551231527d, y: 0.06073670188396796d), new NpgsqlTypes.NpgsqlPoint(x: 0.7948665367093999d, y: 0.898933158940104d), new NpgsqlTypes.NpgsqlPoint(x: 0.6005323876623215d, y: 0.19753784667657415d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1048752904752519d, y: 0.5507725388403161d), new NpgsqlTypes.NpgsqlPoint(x: 0.07747026286128811d, y: 0.14050175676484322d), new NpgsqlTypes.NpgsqlPoint(x: 0.4347966481358134d, y: 0.5503925064466381d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8873238180114901d, y: 0.05159986148377704d), new NpgsqlTypes.NpgsqlPoint(x: 0.7545058233936179d, y: 0.8190310066201372d), new NpgsqlTypes.NpgsqlPoint(x: 0.731951299423409d, y: 0.8613582423582018d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.019555981695786206d, y: 0.7585122766419845d), new NpgsqlTypes.NpgsqlPoint(x: 0.5082914040161939d, y: 0.610521608449318d), new NpgsqlTypes.NpgsqlPoint(x: 0.18260447246281164d, y: 0.7849788603681351d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.595266550631429d, y: 0.8632125173503117d), new NpgsqlTypes.NpgsqlPoint(x: 0.42510546336740695d, y: 0.6669925185979446d), new NpgsqlTypes.NpgsqlPoint(x: 0.9259451739963264d, y: 0.060130304823282854d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19579159678195768d, y: 0.8751309043525723d), new NpgsqlTypes.NpgsqlPoint(x: 0.1268596335151565d, y: 0.1334767764814967d), new NpgsqlTypes.NpgsqlPoint(x: 0.5346847351830082d, y: 0.10176520674920875d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7325396880764611d, y: 0.914788267904121d), new NpgsqlTypes.NpgsqlPoint(x: 0.6329158409094234d, y: 0.6627155632506546d), new NpgsqlTypes.NpgsqlPoint(x: 0.7844924276962151d, y: 0.6775289225444102d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27995300732471273d, y: 0.3798571492086009d), new NpgsqlTypes.NpgsqlPoint(x: 0.39293361464706955d, y: 0.05566932584529849d), new NpgsqlTypes.NpgsqlPoint(x: 0.8763513306683285d, y: 0.38859294040346803d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5969410020041326d, y: 0.5345655695887043d), new NpgsqlTypes.NpgsqlPoint(x: 0.4962232756577152d, y: 0.608585728880849d), new NpgsqlTypes.NpgsqlPoint(x: 0.32413863582021996d, y: 0.11283499821270038d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8136825890569794d, y: 0.33836760830547374d), new NpgsqlTypes.NpgsqlPoint(x: 0.5137811752331645d, y: 0.9415372945131131d), new NpgsqlTypes.NpgsqlPoint(x: 0.8921250706856914d, y: 0.6318143845486984d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9747038091541397d, y: 0.3215407639146062d), new NpgsqlTypes.NpgsqlPoint(x: 0.051164913069795204d, y: 0.5285651467921914d), new NpgsqlTypes.NpgsqlPoint(x: 0.4155820306055361d, y: 0.8159688071911164d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7867654504120467d, y: 0.6936532593035011d), new NpgsqlTypes.NpgsqlPoint(x: 0.9722478885385194d, y: 0.6458299465011558d), new NpgsqlTypes.NpgsqlPoint(x: 0.3518791966422501d, y: 0.5497673102659608d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21367066730138407d, y: 0.09958510433893952d), new NpgsqlTypes.NpgsqlPoint(x: 0.616608462596312d, y: 0.8617975811343619d), new NpgsqlTypes.NpgsqlPoint(x: 0.6364572278259676d, y: 0.23300175313390747d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4288055459092126d, y: 0.24906655900986685d), new NpgsqlTypes.NpgsqlPoint(x: 0.6927758895665714d, y: 0.3617957677667092d), new NpgsqlTypes.NpgsqlPoint(x: 0.6170906578889791d, y: 0.38713652325191106d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8318148397515883d, y: 0.14072526600912116d), new NpgsqlTypes.NpgsqlPoint(x: 0.7330069266623818d, y: 0.7863781953568719d), new NpgsqlTypes.NpgsqlPoint(x: 0.04986029867559705d, y: 0.5163843780576942d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07863988249455889d, y: 0.9730802453145138d), new NpgsqlTypes.NpgsqlPoint(x: 0.16691133257005575d, y: 0.20958940326580044d), new NpgsqlTypes.NpgsqlPoint(x: 0.2454934224532278d, y: 0.18077410114065584d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5587522764262794d, y: 0.16012709652931023d), new NpgsqlTypes.NpgsqlPoint(x: 0.1587729790611755d, y: 0.48123624752651617d), new NpgsqlTypes.NpgsqlPoint(x: 0.8169414291804381d, y: 0.6031205139204749d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49247630839483025d, y: 0.9695972112388839d), new NpgsqlTypes.NpgsqlPoint(x: 0.6735951715780377d, y: 0.4387493155139901d), new NpgsqlTypes.NpgsqlPoint(x: 0.2301044908990023d, y: 0.08070417729349988d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9465981578600486d, y: 0.08192824222521422d), new NpgsqlTypes.NpgsqlPoint(x: 0.5822015664322943d, y: 0.18281520569408927d), new NpgsqlTypes.NpgsqlPoint(x: 0.9844600508764538d, y: 0.5560629743628475d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8275623281886076d, y: 0.7628865493048135d), new NpgsqlTypes.NpgsqlPoint(x: 0.13465319863945258d, y: 0.7966430817209988d), new NpgsqlTypes.NpgsqlPoint(x: 0.09707668164647032d, y: 0.09201994700748006d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4581128619256437d, y: 0.45214395075173164d), new NpgsqlTypes.NpgsqlPoint(x: 0.5648584483786453d, y: 0.644637946100793d), new NpgsqlTypes.NpgsqlPoint(x: 0.8943518193856306d, y: 0.8692739307062476d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4303716610611552d, y: 0.2723151037696734d), new NpgsqlTypes.NpgsqlPoint(x: 0.9283796592860434d, y: 0.3803375432725775d), new NpgsqlTypes.NpgsqlPoint(x: 0.616560573617761d, y: 0.957089486762628d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2229795308970236d, y: 0.3479453042780146d), new NpgsqlTypes.NpgsqlPoint(x: 0.2324523070975999d, y: 0.17159101453080672d), new NpgsqlTypes.NpgsqlPoint(x: 0.886545614613769d, y: 0.9224925588174108d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46731541753177197d, y: 0.266802848559494d), new NpgsqlTypes.NpgsqlPoint(x: 0.3468270071546322d, y: 0.74116838209433d), new NpgsqlTypes.NpgsqlPoint(x: 0.17324922287075784d, y: 0.9003539195931051d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22202480236533284d, y: 0.709534600599944d), new NpgsqlTypes.NpgsqlPoint(x: 0.7488812347319682d, y: 0.2261315704865171d), new NpgsqlTypes.NpgsqlPoint(x: 0.05873691129677694d, y: 0.055353131195736704d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7225037470907504d, y: 0.7787368796543498d), new NpgsqlTypes.NpgsqlPoint(x: 0.7411660491533367d, y: 0.8456356588859052d), new NpgsqlTypes.NpgsqlPoint(x: 0.9820398371871393d, y: 0.16859709347251128d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6275607959560291d, y: 0.4123891729064476d), new NpgsqlTypes.NpgsqlPoint(x: 0.8601393709534029d, y: 0.5548092015730377d), new NpgsqlTypes.NpgsqlPoint(x: 0.8461773104596619d, y: 0.262479335486285d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4936463103116885d, y: 0.09479427364963855d), new NpgsqlTypes.NpgsqlPoint(x: 0.6725045119509525d, y: 0.4361624409873308d), new NpgsqlTypes.NpgsqlPoint(x: 0.45611387684035265d, y: 0.48820981125708596d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7076507534662168d, y: 0.9762072316739738d), new NpgsqlTypes.NpgsqlPoint(x: 0.6043861063034408d, y: 0.3406330008741204d), new NpgsqlTypes.NpgsqlPoint(x: 0.2497331483001355d, y: 0.22362324801901612d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8897560004088549d, y: 0.263865899478409d), new NpgsqlTypes.NpgsqlPoint(x: 0.2124705218924956d, y: 0.2669462182114789d), new NpgsqlTypes.NpgsqlPoint(x: 0.1794247138248296d, y: 0.3172431209884935d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7218065285752849d, y: 0.08157223933073465d), new NpgsqlTypes.NpgsqlPoint(x: 0.7956736858298671d, y: 0.7416134511336223d), new NpgsqlTypes.NpgsqlPoint(x: 0.5107222677611268d, y: 0.593049158017891d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6625646563149831d, y: 0.9960622196258313d), new NpgsqlTypes.NpgsqlPoint(x: 0.7196627216738175d, y: 0.835604051370794d), new NpgsqlTypes.NpgsqlPoint(x: 0.7627186208882248d, y: 0.28069244688051975d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9327065226456748d, y: 0.2481202066319158d), new NpgsqlTypes.NpgsqlPoint(x: 0.05120988074801114d, y: 0.2582886268351017d), new NpgsqlTypes.NpgsqlPoint(x: 0.6755132680455622d, y: 0.8966852171968254d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24389093825771735d, y: 0.46073477750082226d), new NpgsqlTypes.NpgsqlPoint(x: 0.8262004740482637d, y: 0.7827436480242194d), new NpgsqlTypes.NpgsqlPoint(x: 0.5617666448974481d, y: 0.4965811556630946d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5850917787655511d, y: 0.6830147439037838d), new NpgsqlTypes.NpgsqlPoint(x: 0.34126201876833284d, y: 0.050707306492988935d), new NpgsqlTypes.NpgsqlPoint(x: 0.6579551737617366d, y: 0.5655441703826062d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.059852126568546105d, y: 0.3738868829104298d), new NpgsqlTypes.NpgsqlPoint(x: 0.41125041278093255d, y: 0.737891194761689d), new NpgsqlTypes.NpgsqlPoint(x: 0.6063068478760372d, y: 0.5272493554738399d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33311155483393384d, y: 0.8708222283790857d), new NpgsqlTypes.NpgsqlPoint(x: 0.6904210032959658d, y: 0.5235712436531956d), new NpgsqlTypes.NpgsqlPoint(x: 0.10666906552833955d, y: 0.44542300551315794d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4249404765567464d, y: 0.6474532135530772d), new NpgsqlTypes.NpgsqlPoint(x: 0.2826166438413482d, y: 0.3516816579782308d), new NpgsqlTypes.NpgsqlPoint(x: 0.8872034713235666d, y: 0.333416495921372d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08493133670419584d, y: 0.19615267880266385d), new NpgsqlTypes.NpgsqlPoint(x: 0.37557505664515434d, y: 0.7622687064451901d), new NpgsqlTypes.NpgsqlPoint(x: 0.7011015987952509d, y: 0.08085481160144059d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7534148273083365d, y: 0.09497774121759095d), new NpgsqlTypes.NpgsqlPoint(x: 0.651048023801746d, y: 0.9714550577034677d), new NpgsqlTypes.NpgsqlPoint(x: 0.015748653547321467d, y: 0.589088919082432d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2502153718710973d, y: 0.20084724463811365d), new NpgsqlTypes.NpgsqlPoint(x: 0.7213314733591036d, y: 0.0945214157295643d), new NpgsqlTypes.NpgsqlPoint(x: 0.7136239077661123d, y: 0.6594536112870013d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6238288429329244d, y: 0.6642971024102982d), new NpgsqlTypes.NpgsqlPoint(x: 0.4885950742237666d, y: 0.17782870997155031d), new NpgsqlTypes.NpgsqlPoint(x: 0.8390989704008073d, y: 0.1942099961281828d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10250847503246341d, y: 0.441141335734643d), new NpgsqlTypes.NpgsqlPoint(x: 0.479086738097948d, y: 0.20032646916403618d), new NpgsqlTypes.NpgsqlPoint(x: 0.251286869488312d, y: 0.7700747249909574d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6133730244261411d, y: 0.3792834528988619d), new NpgsqlTypes.NpgsqlPoint(x: 0.9966861989899312d, y: 0.7529033418586409d), new NpgsqlTypes.NpgsqlPoint(x: 0.6294806530815568d, y: 0.5545108791034482d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.570338153160351d, y: 0.06332532281569714d), new NpgsqlTypes.NpgsqlPoint(x: 0.28375898776347774d, y: 0.05259562188325817d), new NpgsqlTypes.NpgsqlPoint(x: 0.8496010162668506d, y: 0.9545246269618523d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8960148747745501d, y: 0.7861746211470616d), new NpgsqlTypes.NpgsqlPoint(x: 0.8116941258339634d, y: 0.5163060062202732d), new NpgsqlTypes.NpgsqlPoint(x: 0.18108425231274672d, y: 0.873935020109858d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4942510483774367d, y: 0.6634831481886367d), new NpgsqlTypes.NpgsqlPoint(x: 0.5859769850080496d, y: 0.9197709806719923d), new NpgsqlTypes.NpgsqlPoint(x: 0.6903415584245658d, y: 0.658670010682036d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19617910373221603d, y: 0.8731999612163789d), new NpgsqlTypes.NpgsqlPoint(x: 0.5575514657967311d, y: 0.37805024416864264d), new NpgsqlTypes.NpgsqlPoint(x: 0.8324634534956542d, y: 0.0649786553730024d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5015457404411826d, y: 0.5643412431829676d), new NpgsqlTypes.NpgsqlPoint(x: 0.21512443463457764d, y: 0.23755296049301966d), new NpgsqlTypes.NpgsqlPoint(x: 0.3660541384565772d, y: 0.03184805762121379d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8734713352319573d, y: 0.2919543222592099d), new NpgsqlTypes.NpgsqlPoint(x: 0.7295766762381941d, y: 0.8582393825244954d), new NpgsqlTypes.NpgsqlPoint(x: 0.7042250195867538d, y: 0.9136688285295612d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27490525628110907d, y: 0.23064165031938988d), new NpgsqlTypes.NpgsqlPoint(x: 0.638275890697973d, y: 0.9357379991545023d), new NpgsqlTypes.NpgsqlPoint(x: 0.5942919116009532d, y: 0.10946930932652943d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6528279734718027d, y: 0.6442583915290245d), new NpgsqlTypes.NpgsqlPoint(x: 0.34901716252670156d, y: 0.4272330048076919d), new NpgsqlTypes.NpgsqlPoint(x: 0.22995351234198413d, y: 0.14463389438989893d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.941922482476374d, y: 0.5813728853721417d), new NpgsqlTypes.NpgsqlPoint(x: 0.2871230494975706d, y: 0.4859209440691239d), new NpgsqlTypes.NpgsqlPoint(x: 0.7498965220918946d, y: 0.5343468160899447d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6968510197845263d, y: 0.13740396663162346d), new NpgsqlTypes.NpgsqlPoint(x: 0.875016705590526d, y: 0.041222178667975284d), new NpgsqlTypes.NpgsqlPoint(x: 0.8189922806154483d, y: 0.13782164076315095d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1367013988987822d, y: 0.1901688939039612d), new NpgsqlTypes.NpgsqlPoint(x: 0.9940148611349865d, y: 0.10152809445815547d), new NpgsqlTypes.NpgsqlPoint(x: 0.4506182758625531d, y: 0.4769198188733321d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4638535581219364d, y: 0.06556019454115669d), new NpgsqlTypes.NpgsqlPoint(x: 0.4112984451129198d, y: 0.29521916488819977d), new NpgsqlTypes.NpgsqlPoint(x: 0.5041173907643972d, y: 0.4469780288549733d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06005090447828254d, y: 0.2600172043633685d), new NpgsqlTypes.NpgsqlPoint(x: 0.8752721286912718d, y: 0.14326382813890526d), new NpgsqlTypes.NpgsqlPoint(x: 0.5981674175087811d, y: 0.35398036100603913d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17068905169504922d, y: 0.4285769851239801d), new NpgsqlTypes.NpgsqlPoint(x: 0.7953716929201502d, y: 0.9561705582839919d), new NpgsqlTypes.NpgsqlPoint(x: 0.4230689650775109d, y: 0.8697673202893342d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7764947169473779d, y: 0.1564889599779945d), new NpgsqlTypes.NpgsqlPoint(x: 0.07690354794703913d, y: 0.031525427487744895d), new NpgsqlTypes.NpgsqlPoint(x: 0.9455540236536033d, y: 0.09947400024601127d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8738061328089352d, y: 0.29597047132190146d), new NpgsqlTypes.NpgsqlPoint(x: 0.148261764573408d, y: 0.7273670461970432d), new NpgsqlTypes.NpgsqlPoint(x: 0.7902363606224594d, y: 0.6853929784159921d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5641098578189917d, y: 0.5038239458398924d), new NpgsqlTypes.NpgsqlPoint(x: 0.7973833814177596d, y: 0.5431242018458906d), new NpgsqlTypes.NpgsqlPoint(x: 0.0859667530338113d, y: 0.5537452405560799d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3474201568375572d, y: 0.7832597363604237d), new NpgsqlTypes.NpgsqlPoint(x: 0.8113990046978217d, y: 0.07045069833875406d), new NpgsqlTypes.NpgsqlPoint(x: 0.2591078629331136d, y: 0.5948596612983237d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02687071205502134d, y: 0.018051485184298555d), new NpgsqlTypes.NpgsqlPoint(x: 0.4649482662060035d, y: 0.3641365953582686d), new NpgsqlTypes.NpgsqlPoint(x: 0.3871182578105674d, y: 0.5681357743400864d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5646304663596217d, y: 0.7494413720706757d), new NpgsqlTypes.NpgsqlPoint(x: 0.1824331335474153d, y: 0.46129433444614754d), new NpgsqlTypes.NpgsqlPoint(x: 0.8747312723042711d, y: 0.7032096717628457d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1592972949508551d, y: 0.49522413901941975d), new NpgsqlTypes.NpgsqlPoint(x: 0.9111780689514138d, y: 0.6226692424345661d), new NpgsqlTypes.NpgsqlPoint(x: 0.6438989310265744d, y: 0.6164538087126464d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9312351160652317d, y: 0.9997402620669555d), new NpgsqlTypes.NpgsqlPoint(x: 0.7886161522144176d, y: 0.5455528475443223d), new NpgsqlTypes.NpgsqlPoint(x: 0.9782520989585138d, y: 0.693813378457668d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8829377791377924d, y: 0.054675369534313734d), new NpgsqlTypes.NpgsqlPoint(x: 0.5550353136836764d, y: 0.7448668024722105d), new NpgsqlTypes.NpgsqlPoint(x: 0.8512886538594492d, y: 0.33407408886552337d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.742084381427003d, y: 0.69303429308939d), new NpgsqlTypes.NpgsqlPoint(x: 0.6954794644241445d, y: 0.6595436714287369d), new NpgsqlTypes.NpgsqlPoint(x: 0.7686090234936562d, y: 0.08897474135376404d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3599461116678263d, y: 0.1410763657766938d), new NpgsqlTypes.NpgsqlPoint(x: 0.3142704619178348d, y: 0.7328494996359028d), new NpgsqlTypes.NpgsqlPoint(x: 0.9260788281707608d, y: 0.11266773549536935d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4615445810942479d, y: 0.8751981913915237d), new NpgsqlTypes.NpgsqlPoint(x: 0.3436992055041771d, y: 0.5051673856908073d), new NpgsqlTypes.NpgsqlPoint(x: 0.7693928020736308d, y: 0.6133029670855463d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9402437366638181d, y: 0.5982961138364867d), new NpgsqlTypes.NpgsqlPoint(x: 0.799770162197348d, y: 0.11483493923636523d), new NpgsqlTypes.NpgsqlPoint(x: 0.3028732281284432d, y: 0.7976882285589721d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20201373452829297d, y: 0.4703017731631396d), new NpgsqlTypes.NpgsqlPoint(x: 0.9687147475617132d, y: 0.01780356861556509d), new NpgsqlTypes.NpgsqlPoint(x: 0.4563660195265431d, y: 0.4685970171840479d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43874488811059087d, y: 0.9084771761358378d), new NpgsqlTypes.NpgsqlPoint(x: 0.8369219775279313d, y: 0.43676888960891613d), new NpgsqlTypes.NpgsqlPoint(x: 0.14585497084226762d, y: 0.12018382669052419d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6713861178057693d, y: 0.7337537414996946d), new NpgsqlTypes.NpgsqlPoint(x: 0.4856757220563025d, y: 0.5744348440206555d), new NpgsqlTypes.NpgsqlPoint(x: 0.33958625763479344d, y: 0.043986699226925774d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23096381044937853d, y: 0.3068817190188873d), new NpgsqlTypes.NpgsqlPoint(x: 0.34352601239390956d, y: 0.4128926662984883d), new NpgsqlTypes.NpgsqlPoint(x: 0.6356384139526366d, y: 0.09336596624629456d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6771109860096745d, y: 0.5113193732748182d), new NpgsqlTypes.NpgsqlPoint(x: 0.07009688059418673d, y: 0.7823495225889949d), new NpgsqlTypes.NpgsqlPoint(x: 0.2167451789342485d, y: 0.011130852751773168d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.924778504300342d, y: 0.6279483485955534d), new NpgsqlTypes.NpgsqlPoint(x: 0.4860102476169186d, y: 0.8324324068393932d), new NpgsqlTypes.NpgsqlPoint(x: 0.00804036331729907d, y: 0.015234564630946967d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48060286817277953d, y: 0.8058337852106839d), new NpgsqlTypes.NpgsqlPoint(x: 0.23711308552248755d, y: 0.8020028079532942d), new NpgsqlTypes.NpgsqlPoint(x: 0.028595241546021777d, y: 0.003950165622141011d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9023033949211663d, y: 0.6341894615222001d), new NpgsqlTypes.NpgsqlPoint(x: 0.23243154415594547d, y: 0.5509019355587058d), new NpgsqlTypes.NpgsqlPoint(x: 0.5449208403409911d, y: 0.8059871838468504d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3408350040237551d, y: 0.026668158978708445d), new NpgsqlTypes.NpgsqlPoint(x: 0.21445539903862876d, y: 0.4245364929651626d), new NpgsqlTypes.NpgsqlPoint(x: 0.8747521704333453d, y: 0.9601168179296948d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7330108688640121d, y: 0.17969071072169018d), new NpgsqlTypes.NpgsqlPoint(x: 0.8800562610458124d, y: 0.06192977250540754d), new NpgsqlTypes.NpgsqlPoint(x: 0.8401416305888482d, y: 0.6836135206974436d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4672197214554539d, y: 0.6961910478003163d), new NpgsqlTypes.NpgsqlPoint(x: 0.3248206543043841d, y: 0.1271737332650692d), new NpgsqlTypes.NpgsqlPoint(x: 0.543444561695405d, y: 0.5989493410431126d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3048743333602776d, y: 0.8934686752539474d), new NpgsqlTypes.NpgsqlPoint(x: 0.944785246065073d, y: 0.09699912444474612d), new NpgsqlTypes.NpgsqlPoint(x: 0.1698977163529959d, y: 0.9941717763899005d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41186743855705754d, y: 0.1229086961327518d), new NpgsqlTypes.NpgsqlPoint(x: 0.08760667501265684d, y: 0.38518106956595666d), new NpgsqlTypes.NpgsqlPoint(x: 0.8670917276442295d, y: 0.34177148034156524d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.008182603450426318d, y: 0.38279240648302737d), new NpgsqlTypes.NpgsqlPoint(x: 0.373976355540644d, y: 0.27819594816487114d), new NpgsqlTypes.NpgsqlPoint(x: 0.5133738329612186d, y: 0.994421564208391d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1945847603224854d, y: 0.8881941033807974d), new NpgsqlTypes.NpgsqlPoint(x: 0.8441191871313809d, y: 0.3935684910432059d), new NpgsqlTypes.NpgsqlPoint(x: 0.889019761425101d, y: 0.8238690612072783d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1657685172458091d, y: 0.6861175317247074d), new NpgsqlTypes.NpgsqlPoint(x: 0.2024295587993178d, y: 0.6624667802588421d), new NpgsqlTypes.NpgsqlPoint(x: 0.8202736817601137d, y: 0.11119357486488213d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09181290462192515d, y: 0.7243920781715094d), new NpgsqlTypes.NpgsqlPoint(x: 0.577544714609821d, y: 0.02565261552280962d), new NpgsqlTypes.NpgsqlPoint(x: 0.10577979634751267d, y: 0.18727863092717056d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8236990278620229d, y: 0.4866054598309173d), new NpgsqlTypes.NpgsqlPoint(x: 0.5141257568519819d, y: 0.0598086043842202d), new NpgsqlTypes.NpgsqlPoint(x: 0.7136983009819873d, y: 0.9465710006334891d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.044385996951297524d, y: 0.7280650899155947d), new NpgsqlTypes.NpgsqlPoint(x: 0.37735664521585777d, y: 0.13885016919187554d), new NpgsqlTypes.NpgsqlPoint(x: 0.3733294032909179d, y: 0.6949369856182734d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8729681901455186d, y: 0.5231085610686287d), new NpgsqlTypes.NpgsqlPoint(x: 0.29044484661517045d, y: 0.08433187838038836d), new NpgsqlTypes.NpgsqlPoint(x: 0.9858685671037886d, y: 0.15746684687468382d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.589111340872053d, y: 0.7984116357069746d), new NpgsqlTypes.NpgsqlPoint(x: 0.11529936611014213d, y: 0.6073725695298754d), new NpgsqlTypes.NpgsqlPoint(x: 0.2169682342996574d, y: 0.8980948242509053d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38751648292529906d, y: 0.8442938990115215d), new NpgsqlTypes.NpgsqlPoint(x: 0.2689389230873419d, y: 0.5501322253848268d), new NpgsqlTypes.NpgsqlPoint(x: 0.44431415062317203d, y: 0.24607284402840457d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2188999451807898d, y: 0.29153617639681606d), new NpgsqlTypes.NpgsqlPoint(x: 0.6018136719756875d, y: 0.3211204835094523d), new NpgsqlTypes.NpgsqlPoint(x: 0.08294083704053123d, y: 0.3623990836922556d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28747509608856536d, y: 0.12970554843516324d), new NpgsqlTypes.NpgsqlPoint(x: 0.7213823430928583d, y: 0.019404751969920975d), new NpgsqlTypes.NpgsqlPoint(x: 0.7629481552868789d, y: 0.6059299762185417d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7405078929715623d, y: 0.07762702788649667d), new NpgsqlTypes.NpgsqlPoint(x: 0.7368144567740372d, y: 0.6388278020557185d), new NpgsqlTypes.NpgsqlPoint(x: 0.9607827680462047d, y: 0.029918637957339622d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6183082747233808d, y: 0.7792883627099646d), new NpgsqlTypes.NpgsqlPoint(x: 0.8561096973157027d, y: 0.8513241257238487d), new NpgsqlTypes.NpgsqlPoint(x: 0.3408581608785586d, y: 0.7715052241438252d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6431998097849023d, y: 0.8784226835939986d), new NpgsqlTypes.NpgsqlPoint(x: 0.2056010994514602d, y: 0.9873264335587276d), new NpgsqlTypes.NpgsqlPoint(x: 0.3857101777662666d, y: 0.7554193998549051d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.858243076795615d, y: 0.3673528658375802d), new NpgsqlTypes.NpgsqlPoint(x: 0.5295268396965258d, y: 0.381638658846309d), new NpgsqlTypes.NpgsqlPoint(x: 0.25541427744450007d, y: 0.6680459312882449d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5998332088511952d, y: 0.5223675201222269d), new NpgsqlTypes.NpgsqlPoint(x: 0.4417216143459498d, y: 0.5894329313375983d), new NpgsqlTypes.NpgsqlPoint(x: 0.7451569868468155d, y: 0.11298885935747938d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7959649956628446d, y: 0.18479751950349277d), new NpgsqlTypes.NpgsqlPoint(x: 0.7591900145530506d, y: 0.5664598551853229d), new NpgsqlTypes.NpgsqlPoint(x: 0.9708684735811192d, y: 0.47734778184986537d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5435890035280329d, y: 0.6643789394297829d), new NpgsqlTypes.NpgsqlPoint(x: 0.2395699814886435d, y: 0.918773163609022d), new NpgsqlTypes.NpgsqlPoint(x: 0.014457029715985503d, y: 0.2806580583327021d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6706819788758969d, y: 0.600794553393261d), new NpgsqlTypes.NpgsqlPoint(x: 0.9515153232667242d, y: 0.12437135689399748d), new NpgsqlTypes.NpgsqlPoint(x: 0.4028045346528043d, y: 0.9421572818793239d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38614784105735755d, y: 0.08227806032849638d), new NpgsqlTypes.NpgsqlPoint(x: 0.6961827691791235d, y: 0.31087976805864537d), new NpgsqlTypes.NpgsqlPoint(x: 0.7837331883315685d, y: 0.1568262398255017d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7230811574713321d, y: 0.2330892619843269d), new NpgsqlTypes.NpgsqlPoint(x: 0.44663891490383556d, y: 0.8162959540097383d), new NpgsqlTypes.NpgsqlPoint(x: 0.44807910100614934d, y: 0.5883182683436904d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10863179544124557d, y: 0.5232648017220867d), new NpgsqlTypes.NpgsqlPoint(x: 0.5248430676805971d, y: 0.25709412788615904d), new NpgsqlTypes.NpgsqlPoint(x: 0.14018115522589336d, y: 0.8401967094416932d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8665707720048419d, y: 0.9610243008499862d), new NpgsqlTypes.NpgsqlPoint(x: 0.7513181293847262d, y: 0.618068455020586d), new NpgsqlTypes.NpgsqlPoint(x: 0.6381649679483643d, y: 0.826530158229196d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9430025654013972d, y: 0.7206943320534169d), new NpgsqlTypes.NpgsqlPoint(x: 0.4600392624752343d, y: 0.2224309009697667d), new NpgsqlTypes.NpgsqlPoint(x: 0.5491624559577492d, y: 0.7344729601624093d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3473791532685083d, y: 0.3798538647253119d), new NpgsqlTypes.NpgsqlPoint(x: 0.6823057137133288d, y: 0.8588597050380301d), new NpgsqlTypes.NpgsqlPoint(x: 0.6651600281128474d, y: 0.47307926478509865d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11899475353839928d, y: 0.26208423826856053d), new NpgsqlTypes.NpgsqlPoint(x: 0.2700607451790149d, y: 0.837063766751166d), new NpgsqlTypes.NpgsqlPoint(x: 0.8337961368336987d, y: 0.7545856025444363d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2920409967101284d, y: 0.502508066825832d), new NpgsqlTypes.NpgsqlPoint(x: 0.21049250331316527d, y: 0.39755066009544426d), new NpgsqlTypes.NpgsqlPoint(x: 0.5990882036123713d, y: 0.5314829661875349d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6371794789579346d, y: 0.8958641217099172d), new NpgsqlTypes.NpgsqlPoint(x: 0.3146533156443867d, y: 0.577461809607573d), new NpgsqlTypes.NpgsqlPoint(x: 0.12684453341269042d, y: 0.9362597896625426d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.005523400627884811d, y: 0.37982082532845496d), new NpgsqlTypes.NpgsqlPoint(x: 0.007182440121821898d, y: 0.10539072772820324d), new NpgsqlTypes.NpgsqlPoint(x: 0.38388643763226316d, y: 0.0373224439890214d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11912193288877837d, y: 0.884144407291616d), new NpgsqlTypes.NpgsqlPoint(x: 0.2809754031648871d, y: 0.41723811725969395d), new NpgsqlTypes.NpgsqlPoint(x: 0.41339785592210543d, y: 0.6381926139869346d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07901793408972901d, y: 0.664593535618815d), new NpgsqlTypes.NpgsqlPoint(x: 0.34878381025454275d, y: 0.6597186634518636d), new NpgsqlTypes.NpgsqlPoint(x: 0.562275854567548d, y: 0.3168977170394748d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5302052775415624d, y: 0.2951175794146993d), new NpgsqlTypes.NpgsqlPoint(x: 0.6451268379916654d, y: 0.7693345041878576d), new NpgsqlTypes.NpgsqlPoint(x: 0.26443359924587106d, y: 0.09114362060165926d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3892757507751208d, y: 0.21018426603106233d), new NpgsqlTypes.NpgsqlPoint(x: 0.009418111007274854d, y: 0.96302478026608d), new NpgsqlTypes.NpgsqlPoint(x: 0.6192878405437859d, y: 0.2771852042699624d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08865406176843738d, y: 0.4821775453614191d), new NpgsqlTypes.NpgsqlPoint(x: 0.992618280314948d, y: 0.714076076500373d), new NpgsqlTypes.NpgsqlPoint(x: 0.2220030082599318d, y: 0.6568670840911902d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1009119564216513d, y: 0.3456214469459187d), new NpgsqlTypes.NpgsqlPoint(x: 0.004611567518928328d, y: 0.3044173855726562d), new NpgsqlTypes.NpgsqlPoint(x: 0.10304214394679057d, y: 0.8709801514043903d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08468917059611103d, y: 0.8533838093775189d), new NpgsqlTypes.NpgsqlPoint(x: 0.08590036907371013d, y: 0.3624165530945722d), new NpgsqlTypes.NpgsqlPoint(x: 0.1975313535306078d, y: 0.34709464541754564d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19921757717710042d, y: 0.29069031826649205d), new NpgsqlTypes.NpgsqlPoint(x: 0.9653162598733371d, y: 0.7327186800372929d), new NpgsqlTypes.NpgsqlPoint(x: 0.25364046945019636d, y: 0.9468995239991254d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7782907234592704d, y: 0.2009086695023815d), new NpgsqlTypes.NpgsqlPoint(x: 0.6108236021332911d, y: 0.7453496568479363d), new NpgsqlTypes.NpgsqlPoint(x: 0.7377207180860423d, y: 0.11181441342634568d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14860149217103913d, y: 0.4424953176635369d), new NpgsqlTypes.NpgsqlPoint(x: 0.25987942390863616d, y: 0.09441947036013532d), new NpgsqlTypes.NpgsqlPoint(x: 0.7086238936050516d, y: 0.24719463967704003d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22471238456047204d, y: 0.939315698639113d), new NpgsqlTypes.NpgsqlPoint(x: 0.44249032338082794d, y: 0.6218990130191402d), new NpgsqlTypes.NpgsqlPoint(x: 0.23384808369384003d, y: 0.5547194921066685d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18082980836148543d, y: 0.06545801208083557d), new NpgsqlTypes.NpgsqlPoint(x: 0.4228940845019805d, y: 0.7847784952769563d), new NpgsqlTypes.NpgsqlPoint(x: 0.49294406226229515d, y: 0.17108974248289743d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8366809029521698d, y: 0.8490659352001658d), new NpgsqlTypes.NpgsqlPoint(x: 0.07025852834103297d, y: 0.05371440281066553d), new NpgsqlTypes.NpgsqlPoint(x: 0.8903105362502344d, y: 0.6596109665728525d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6783386758926317d, y: 0.25585422517431167d), new NpgsqlTypes.NpgsqlPoint(x: 0.351609462657276d, y: 0.7957001632665784d), new NpgsqlTypes.NpgsqlPoint(x: 0.7601793401314927d, y: 0.023978831884727048d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41346699251615815d, y: 0.9604538170136618d), new NpgsqlTypes.NpgsqlPoint(x: 0.6639411308402211d, y: 0.5532150889406945d), new NpgsqlTypes.NpgsqlPoint(x: 0.5356381287225085d, y: 0.2539537869968205d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.867600798063878d, y: 0.6096559296352214d), new NpgsqlTypes.NpgsqlPoint(x: 0.6465462104820011d, y: 0.4789460033263847d), new NpgsqlTypes.NpgsqlPoint(x: 0.8856960622788911d, y: 0.6674912172626987d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8856878524543237d, y: 0.4690504885150185d), new NpgsqlTypes.NpgsqlPoint(x: 0.3496163402086748d, y: 0.4297903363960597d), new NpgsqlTypes.NpgsqlPoint(x: 0.7835832695656376d, y: 0.012541040876609122d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9691218094781694d, y: 0.5702274673563156d), new NpgsqlTypes.NpgsqlPoint(x: 0.687824004198248d, y: 0.6727540123067749d), new NpgsqlTypes.NpgsqlPoint(x: 0.1785932629991549d, y: 0.3228276126742159d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3063813175544824d, y: 0.8699813492018869d), new NpgsqlTypes.NpgsqlPoint(x: 0.04984666221769929d, y: 0.2040483502471252d), new NpgsqlTypes.NpgsqlPoint(x: 0.3581598195135419d, y: 0.9288935558287228d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6032952549151296d, y: 0.7625939030412109d), new NpgsqlTypes.NpgsqlPoint(x: 0.31258968801136444d, y: 0.6211169197775884d), new NpgsqlTypes.NpgsqlPoint(x: 0.2019668215743754d, y: 0.793303707838721d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8777275471495283d, y: 0.8958721447711703d), new NpgsqlTypes.NpgsqlPoint(x: 0.9911350348262867d, y: 0.676436887228492d), new NpgsqlTypes.NpgsqlPoint(x: 0.9052768001233154d, y: 0.3261390880355364d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9101580711765342d, y: 0.22252931176510082d), new NpgsqlTypes.NpgsqlPoint(x: 0.8499140949357765d, y: 0.9413325386754449d), new NpgsqlTypes.NpgsqlPoint(x: 0.8988299441427875d, y: 0.8910318987961828d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5592465053952195d, y: 0.30727718060814624d), new NpgsqlTypes.NpgsqlPoint(x: 0.5703227958458159d, y: 0.14716798080998905d), new NpgsqlTypes.NpgsqlPoint(x: 0.8567543602359173d, y: 0.9664762361884798d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.783448471611206d, y: 0.48926550880459296d), new NpgsqlTypes.NpgsqlPoint(x: 0.35117474721749253d, y: 0.5093718324252539d), new NpgsqlTypes.NpgsqlPoint(x: 0.9395850940287593d, y: 0.386528141020009d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6747327951211685d, y: 0.2889424746187095d), new NpgsqlTypes.NpgsqlPoint(x: 0.724286834169488d, y: 0.9960449760380636d), new NpgsqlTypes.NpgsqlPoint(x: 0.25174022877173297d, y: 0.9120264982998418d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34323360429815475d, y: 0.6575118634300408d), new NpgsqlTypes.NpgsqlPoint(x: 0.08694269124925325d, y: 0.25185509596022304d), new NpgsqlTypes.NpgsqlPoint(x: 0.8539866594652246d, y: 0.26981881029045607d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8245244980367249d, y: 0.30102790688914594d), new NpgsqlTypes.NpgsqlPoint(x: 0.2245248754493413d, y: 0.6475745151392212d), new NpgsqlTypes.NpgsqlPoint(x: 0.6625131556654709d, y: 0.5895961066790492d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2996175922586286d, y: 0.1766385220797001d), new NpgsqlTypes.NpgsqlPoint(x: 0.16609912914835423d, y: 0.1575191806566002d), new NpgsqlTypes.NpgsqlPoint(x: 0.17867528403543775d, y: 0.8440728178867324d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 97,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9289172824587316d, y: 0.5412762626651623d), new NpgsqlTypes.NpgsqlPoint(x: 0.4211340969661356d, y: 0.44902400909829443d), new NpgsqlTypes.NpgsqlPoint(x: 0.34380644039212893d, y: 0.21427978246850554d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16986913278934157d, y: 0.6521114144481807d), new NpgsqlTypes.NpgsqlPoint(x: 0.02134727023694627d, y: 0.40344310170716535d), new NpgsqlTypes.NpgsqlPoint(x: 0.15492258829625294d, y: 0.7827437908859811d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9198345521861693d, y: 0.7167015578890631d), new NpgsqlTypes.NpgsqlPoint(x: 0.8702685306208832d, y: 0.8397781176102352d), new NpgsqlTypes.NpgsqlPoint(x: 0.14743128901407065d, y: 0.47530115523424776d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7272725722672223d, y: 0.11426453773673062d), new NpgsqlTypes.NpgsqlPoint(x: 0.0912131461605662d, y: 0.9728974385461943d), new NpgsqlTypes.NpgsqlPoint(x: 0.8043058599074087d, y: 0.4770920547492308d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21216294253538348d, y: 0.8097360458494317d), new NpgsqlTypes.NpgsqlPoint(x: 0.05824047208709171d, y: 0.789024224561976d), new NpgsqlTypes.NpgsqlPoint(x: 0.23049476632103627d, y: 0.6648040426260738d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7705905074058842d, y: 0.22744305527774755d), new NpgsqlTypes.NpgsqlPoint(x: 0.2511117837007605d, y: 0.9594276604533659d), new NpgsqlTypes.NpgsqlPoint(x: 0.4067528123830465d, y: 0.018441812472570596d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8465558670439879d, y: 0.5625117556200063d), new NpgsqlTypes.NpgsqlPoint(x: 0.9029002113353858d, y: 0.5308965823440893d), new NpgsqlTypes.NpgsqlPoint(x: 0.19447241869772092d, y: 0.9784117300555843d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6124441721290949d, y: 0.8745778459437163d), new NpgsqlTypes.NpgsqlPoint(x: 0.36039494884365975d, y: 0.5885519850215539d), new NpgsqlTypes.NpgsqlPoint(x: 0.40570093850893885d, y: 0.9307780077459886d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6622955703240061d, y: 0.5973341438680863d), new NpgsqlTypes.NpgsqlPoint(x: 0.42974218630490346d, y: 0.12778601495918862d), new NpgsqlTypes.NpgsqlPoint(x: 0.7555040793711935d, y: 0.39205334986035156d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4933727207376608d, y: 0.7279159355901712d), new NpgsqlTypes.NpgsqlPoint(x: 0.05196314217468334d, y: 0.939598871607449d), new NpgsqlTypes.NpgsqlPoint(x: 0.7450799673561986d, y: 0.6318693405059472d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1997408326814316d, y: 0.27121069070342496d), new NpgsqlTypes.NpgsqlPoint(x: 0.5643955333709116d, y: 0.9273811963331933d), new NpgsqlTypes.NpgsqlPoint(x: 0.40046341586919243d, y: 0.05667327468222216d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.014046608834371477d, y: 0.3059033745347286d), new NpgsqlTypes.NpgsqlPoint(x: 0.06496616706139946d, y: 0.39205348095001735d), new NpgsqlTypes.NpgsqlPoint(x: 0.9046914966953867d, y: 0.1323042219159194d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9402066831251764d, y: 0.20557543018614155d), new NpgsqlTypes.NpgsqlPoint(x: 0.08965303728879936d, y: 0.43509671595341426d), new NpgsqlTypes.NpgsqlPoint(x: 0.1936923333845998d, y: 0.22700608368280928d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 101,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48361657769809596d, y: 0.6009178092519427d), new NpgsqlTypes.NpgsqlPoint(x: 0.06593917066980826d, y: 0.2908729212463129d), new NpgsqlTypes.NpgsqlPoint(x: 0.953521537947165d, y: 0.7088499274845688d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6786350175409969d, y: 0.4893003437012241d), new NpgsqlTypes.NpgsqlPoint(x: 0.08499465849447252d, y: 0.5075174693871064d), new NpgsqlTypes.NpgsqlPoint(x: 0.6508219474007234d, y: 0.832957538161647d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8709501947526582d, y: 0.30039773242393386d), new NpgsqlTypes.NpgsqlPoint(x: 0.39562648373243126d, y: 0.17233707852159463d), new NpgsqlTypes.NpgsqlPoint(x: 0.9744545709742133d, y: 0.7238315352657605d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6933829749768815d, y: 0.47411578803444854d), new NpgsqlTypes.NpgsqlPoint(x: 0.0097483202862092d, y: 0.4211552597364504d), new NpgsqlTypes.NpgsqlPoint(x: 0.2184957419100062d, y: 0.1709208903921593d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4322764381636459d, y: 0.2951365194816131d), new NpgsqlTypes.NpgsqlPoint(x: 0.6859807100010507d, y: 0.27908453873848993d), new NpgsqlTypes.NpgsqlPoint(x: 0.39678115682887327d, y: 0.11845395077789889d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22088513917184693d, y: 0.024774312304294832d), new NpgsqlTypes.NpgsqlPoint(x: 0.82788881434062d, y: 0.9884701807536448d), new NpgsqlTypes.NpgsqlPoint(x: 0.6905116444736502d, y: 0.2886762502629573d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8565942574747611d, y: 0.39233277148884105d), new NpgsqlTypes.NpgsqlPoint(x: 0.6144765959579248d, y: 0.6977738054327469d), new NpgsqlTypes.NpgsqlPoint(x: 0.2263951472608685d, y: 0.9676510245151473d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 110,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.780094545055633d, y: 0.7731389879868671d), new NpgsqlTypes.NpgsqlPoint(x: 0.6914106660588492d, y: 0.9103519936062782d), new NpgsqlTypes.NpgsqlPoint(x: 0.18891200274982878d, y: 0.37471595951088976d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6769747122850837d, y: 0.20525217899472314d), new NpgsqlTypes.NpgsqlPoint(x: 0.9560268902491668d, y: 0.9414691122884508d), new NpgsqlTypes.NpgsqlPoint(x: 0.7287133974620885d, y: 0.9521883561914393d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23351447179514628d, y: 0.3520185032422587d), new NpgsqlTypes.NpgsqlPoint(x: 0.41969067795842385d, y: 0.3672726260915512d), new NpgsqlTypes.NpgsqlPoint(x: 0.6351458313139616d, y: 0.47051711575374866d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2310623105836681d, y: 0.3080533939141057d), new NpgsqlTypes.NpgsqlPoint(x: 0.49642749160902155d, y: 0.6869853827853962d), new NpgsqlTypes.NpgsqlPoint(x: 0.5862455653047156d, y: 0.6603984065532537d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23321807496220603d, y: 0.3541412494277607d), new NpgsqlTypes.NpgsqlPoint(x: 0.3550939211294808d, y: 0.8442768571390051d), new NpgsqlTypes.NpgsqlPoint(x: 0.2790761135502705d, y: 0.15081046469711057d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8167781618560929d, y: 0.3284777795654251d), new NpgsqlTypes.NpgsqlPoint(x: 0.1657828559917337d, y: 0.6360588196072239d), new NpgsqlTypes.NpgsqlPoint(x: 0.061581604185472094d, y: 0.4578583419555766d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4271943681907402d, y: 0.9605510623440862d), new NpgsqlTypes.NpgsqlPoint(x: 0.08340622216543436d, y: 0.21039669992351362d), new NpgsqlTypes.NpgsqlPoint(x: 0.6597840600651402d, y: 0.7658188549421583d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01722366765526584d, y: 0.7668672256276271d), new NpgsqlTypes.NpgsqlPoint(x: 0.8907579920240102d, y: 0.6993588563380079d), new NpgsqlTypes.NpgsqlPoint(x: 0.19080786703889607d, y: 0.13223420409962494d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9867352366379822d, y: 0.2231311262292074d), new NpgsqlTypes.NpgsqlPoint(x: 0.47579036280776543d, y: 0.2048787307455946d), new NpgsqlTypes.NpgsqlPoint(x: 0.055680989932925695d, y: 0.7025849545530353d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5776830889330415d, y: 0.8175162423212509d), new NpgsqlTypes.NpgsqlPoint(x: 0.3862977971800857d, y: 0.9131931230808007d), new NpgsqlTypes.NpgsqlPoint(x: 0.3948203635943587d, y: 0.20868633313449914d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2523286469845627d, y: 0.49492102530856263d), new NpgsqlTypes.NpgsqlPoint(x: 0.608988250292424d, y: 0.4425992895722789d), new NpgsqlTypes.NpgsqlPoint(x: 0.6443612447815291d, y: 0.4528654651833083d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 114,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8271298377955808d, y: 0.7322071297293998d), new NpgsqlTypes.NpgsqlPoint(x: 0.8838003086222652d, y: 0.8799213768597205d), new NpgsqlTypes.NpgsqlPoint(x: 0.04855915382069831d, y: 0.48469186323897695d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24065655161999355d, y: 0.3580409477332531d), new NpgsqlTypes.NpgsqlPoint(x: 0.13496954135881656d, y: 0.2524741149974312d), new NpgsqlTypes.NpgsqlPoint(x: 0.20349874353351494d, y: 0.24587382942313118d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8517303940641174d, y: 0.23268235224823108d), new NpgsqlTypes.NpgsqlPoint(x: 0.5475080139515162d, y: 0.18677191331271514d), new NpgsqlTypes.NpgsqlPoint(x: 0.4652073870860026d, y: 0.3258377039150552d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9511707627557823d, y: 0.6332673294343035d), new NpgsqlTypes.NpgsqlPoint(x: 0.3594628742070568d, y: 0.7849103880027639d), new NpgsqlTypes.NpgsqlPoint(x: 0.3507544528691656d, y: 0.049353444572116434d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14476387742799368d, y: 0.39094150331648403d), new NpgsqlTypes.NpgsqlPoint(x: 0.9583574331344119d, y: 0.9236038911829367d), new NpgsqlTypes.NpgsqlPoint(x: 0.8183846168849195d, y: 0.6807320044433652d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8239542362373838d, y: 0.9376456342836574d), new NpgsqlTypes.NpgsqlPoint(x: 0.5465617456628501d, y: 0.4122615796837056d), new NpgsqlTypes.NpgsqlPoint(x: 0.2837092820809285d, y: 0.6306298357168632d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8648590694655995d, y: 0.5670959874952165d), new NpgsqlTypes.NpgsqlPoint(x: 0.19028691077074322d, y: 0.8104193641594999d), new NpgsqlTypes.NpgsqlPoint(x: 0.001029192356423514d, y: 0.5452030131567442d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 118,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44579836330561373d, y: 0.4941963774548256d), new NpgsqlTypes.NpgsqlPoint(x: 0.6982587472819718d, y: 0.7129326477778066d), new NpgsqlTypes.NpgsqlPoint(x: 0.8832874946056233d, y: 0.06839167450953221d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3407892432354259d, y: 0.31883350177879377d), new NpgsqlTypes.NpgsqlPoint(x: 0.4204866955305636d, y: 0.3594553984298007d), new NpgsqlTypes.NpgsqlPoint(x: 0.9521723306338513d, y: 0.9272113934322477d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3635105785129361d, y: 0.6069692964081546d), new NpgsqlTypes.NpgsqlPoint(x: 0.999774077888238d, y: 0.36342038068715266d), new NpgsqlTypes.NpgsqlPoint(x: 0.03756134105069753d, y: 0.7902873575240974d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6554440747887347d, y: 0.28445162043670436d), new NpgsqlTypes.NpgsqlPoint(x: 0.5230918343210514d, y: 0.49708932603302636d), new NpgsqlTypes.NpgsqlPoint(x: 0.12748500431272158d, y: 0.21136074499443347d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9434536822355941d, y: 0.2055931984454531d), new NpgsqlTypes.NpgsqlPoint(x: 0.5247485134591691d, y: 0.8745523055661628d), new NpgsqlTypes.NpgsqlPoint(x: 0.7456690595418592d, y: 0.7007759877573215d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4856404027801341d, y: 0.2838025589555836d), new NpgsqlTypes.NpgsqlPoint(x: 0.1254639005645798d, y: 0.48395525864171396d), new NpgsqlTypes.NpgsqlPoint(x: 0.13968947513083285d, y: 0.12272784723637509d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47341305195484207d, y: 0.3495757350802513d), new NpgsqlTypes.NpgsqlPoint(x: 0.34837426169514485d, y: 0.9446066925786479d), new NpgsqlTypes.NpgsqlPoint(x: 0.9406840658553981d, y: 0.599198968207551d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07861942772685704d, y: 0.5064967138535917d), new NpgsqlTypes.NpgsqlPoint(x: 0.00556544698635697d, y: 0.3322651091173815d), new NpgsqlTypes.NpgsqlPoint(x: 0.999623155358138d, y: 0.2484829471012795d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.230098875471357d, y: 0.7862457164078128d), new NpgsqlTypes.NpgsqlPoint(x: 0.228624463266358d, y: 0.11324870056507297d), new NpgsqlTypes.NpgsqlPoint(x: 0.41465565576957375d, y: 0.7988281656167386d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03586734449359841d, y: 0.4767844373512752d), new NpgsqlTypes.NpgsqlPoint(x: 0.9335316356251567d, y: 0.9528648210468563d), new NpgsqlTypes.NpgsqlPoint(x: 0.5133929815299684d, y: 0.30603614537191415d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5692061894342679d, y: 0.013747178759087042d), new NpgsqlTypes.NpgsqlPoint(x: 0.9475237445756995d, y: 0.2881847781110196d), new NpgsqlTypes.NpgsqlPoint(x: 0.15811712278256385d, y: 0.9324795163374264d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 124,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7909763509381824d, y: 0.1675706353572336d), new NpgsqlTypes.NpgsqlPoint(x: 0.9926466456512661d, y: 0.26726298859412945d), new NpgsqlTypes.NpgsqlPoint(x: 0.6304387407935585d, y: 0.5377471783956475d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6158957233430631d, y: 0.5382555675908203d), new NpgsqlTypes.NpgsqlPoint(x: 0.8872184177844996d, y: 0.023790693595145962d), new NpgsqlTypes.NpgsqlPoint(x: 0.6994917398321456d, y: 0.7391653508393525d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8704691917191378d, y: 0.026685296001256686d), new NpgsqlTypes.NpgsqlPoint(x: 0.7655833729562239d, y: 0.5986593731324868d), new NpgsqlTypes.NpgsqlPoint(x: 0.11183967630117253d, y: 0.39041454169321055d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6303816591227539d, y: 0.15913247585216295d), new NpgsqlTypes.NpgsqlPoint(x: 0.09436727892205532d, y: 0.127286564648042d), new NpgsqlTypes.NpgsqlPoint(x: 0.32117091140178267d, y: 0.48037650831868706d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 129,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9500857727784832d, y: 0.4503446478768647d), new NpgsqlTypes.NpgsqlPoint(x: 0.026005044653542697d, y: 0.17414973332200878d), new NpgsqlTypes.NpgsqlPoint(x: 0.4111479837579396d, y: 0.7455285822448428d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5514862006573172d, y: 0.6220461838045773d), new NpgsqlTypes.NpgsqlPoint(x: 0.11290672801943058d, y: 0.0654108928396514d), new NpgsqlTypes.NpgsqlPoint(x: 0.11978253801863425d, y: 0.8635843531910325d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6818808417156333d, y: 0.2997691968030358d), new NpgsqlTypes.NpgsqlPoint(x: 0.7378734465644363d, y: 0.3070910670385968d), new NpgsqlTypes.NpgsqlPoint(x: 0.3920209285038828d, y: 0.9069569140838494d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4773799910674775d, y: 0.4644337856341665d), new NpgsqlTypes.NpgsqlPoint(x: 0.5553880283813084d, y: 0.23765971214537085d), new NpgsqlTypes.NpgsqlPoint(x: 0.43586249004801336d, y: 0.3979054726231026d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03675461492664489d, y: 0.5366013644933049d), new NpgsqlTypes.NpgsqlPoint(x: 0.5961481820518072d, y: 0.7587406285062486d), new NpgsqlTypes.NpgsqlPoint(x: 0.4921384076436547d, y: 0.2125159624379851d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4732587512128885d, y: 0.7312756842262508d), new NpgsqlTypes.NpgsqlPoint(x: 0.20453156257210126d, y: 0.3453989501925665d), new NpgsqlTypes.NpgsqlPoint(x: 0.4497331855913205d, y: 0.3927496438543244d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8027140921513279d, y: 0.2862027299033385d), new NpgsqlTypes.NpgsqlPoint(x: 0.13677156619425634d, y: 0.16858116455245464d), new NpgsqlTypes.NpgsqlPoint(x: 0.5425600027787741d, y: 0.8605103090045937d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6018942129086553d, y: 0.6157264899405764d), new NpgsqlTypes.NpgsqlPoint(x: 0.5006851257332325d, y: 0.45546327512666784d), new NpgsqlTypes.NpgsqlPoint(x: 0.2657707888469747d, y: 0.10120505116711542d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12415872835609054d, y: 0.17106059881563895d), new NpgsqlTypes.NpgsqlPoint(x: 0.3701092508593937d, y: 0.19233175590757923d), new NpgsqlTypes.NpgsqlPoint(x: 0.3307832782486011d, y: 0.4217857327483916d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5442266049322398d, y: 0.14549439096579198d), new NpgsqlTypes.NpgsqlPoint(x: 0.38404687119631853d, y: 0.7335545535579643d), new NpgsqlTypes.NpgsqlPoint(x: 0.7263536018934232d, y: 0.47838362495732634d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6070668147364505d, y: 0.7279067424024156d), new NpgsqlTypes.NpgsqlPoint(x: 0.25853779247439945d, y: 0.5123770937367699d), new NpgsqlTypes.NpgsqlPoint(x: 0.14159842477369888d, y: 0.21925202649877318d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5304368752580496d, y: 0.791859238298027d), new NpgsqlTypes.NpgsqlPoint(x: 0.5624233735903572d, y: 0.4034948615962083d), new NpgsqlTypes.NpgsqlPoint(x: 0.6504404458073658d, y: 0.38271938850618326d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9253641114772913d, y: 0.45435753382391963d), new NpgsqlTypes.NpgsqlPoint(x: 0.5485823758595358d, y: 0.885398072150014d), new NpgsqlTypes.NpgsqlPoint(x: 0.8187290789113897d, y: 0.40534098909566385d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42189750622466937d, y: 0.6741146754488134d), new NpgsqlTypes.NpgsqlPoint(x: 0.6145819413068263d, y: 0.7463730482986676d), new NpgsqlTypes.NpgsqlPoint(x: 0.8661985505664452d, y: 0.5085834025632622d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 138,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5232814983168483d, y: 0.5823845568696857d), new NpgsqlTypes.NpgsqlPoint(x: 0.003075344223866683d, y: 0.7741456379224205d), new NpgsqlTypes.NpgsqlPoint(x: 0.7779466890536105d, y: 0.4396070141256031d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5051035728326012d, y: 0.38571539126116083d), new NpgsqlTypes.NpgsqlPoint(x: 0.3167268113211723d, y: 0.12452654308227007d), new NpgsqlTypes.NpgsqlPoint(x: 0.8430833159454546d, y: 0.7007373524353542d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07982075265653676d, y: 0.23251328585158593d), new NpgsqlTypes.NpgsqlPoint(x: 0.6413134793261897d, y: 0.5031146080509112d), new NpgsqlTypes.NpgsqlPoint(x: 0.9273254456344135d, y: 0.3149742754299736d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 143,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2588431678495996d, y: 0.7267587191090968d), new NpgsqlTypes.NpgsqlPoint(x: 0.34453045929211235d, y: 0.3412997193557522d), new NpgsqlTypes.NpgsqlPoint(x: 0.9972032657049332d, y: 0.483454083512021d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13458748439055068d, y: 0.3870148512600813d), new NpgsqlTypes.NpgsqlPoint(x: 0.01154166664820222d, y: 0.8766681294638156d), new NpgsqlTypes.NpgsqlPoint(x: 0.8098458280074848d, y: 0.4000996442936714d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5120439897748741d, y: 0.8387101870249646d), new NpgsqlTypes.NpgsqlPoint(x: 0.770354025085388d, y: 0.049790579988393424d), new NpgsqlTypes.NpgsqlPoint(x: 0.475235941382228d, y: 0.42487760220907844d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.545724222561266d, y: 0.8453311924925417d), new NpgsqlTypes.NpgsqlPoint(x: 0.9384968072640295d, y: 0.3060780903852671d), new NpgsqlTypes.NpgsqlPoint(x: 0.3294105810721797d, y: 0.22254419567085504d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8778513366082032d, y: 0.2464152034228715d), new NpgsqlTypes.NpgsqlPoint(x: 0.6843550470151527d, y: 0.6282369798052656d), new NpgsqlTypes.NpgsqlPoint(x: 0.6804990066367949d, y: 0.7234459207634547d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12410593276191806d, y: 0.66369521731401d), new NpgsqlTypes.NpgsqlPoint(x: 0.9287970129948071d, y: 0.5427935675248257d), new NpgsqlTypes.NpgsqlPoint(x: 0.35439764009206465d, y: 0.2519663765530801d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08617384830312935d, y: 0.5616713137023817d), new NpgsqlTypes.NpgsqlPoint(x: 0.8233265409265215d, y: 0.7964074280178377d), new NpgsqlTypes.NpgsqlPoint(x: 0.8674729623156044d, y: 0.5772310578342402d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15981491404134507d, y: 0.4438556963409035d), new NpgsqlTypes.NpgsqlPoint(x: 0.07154435749655874d, y: 0.9429771917461097d), new NpgsqlTypes.NpgsqlPoint(x: 0.5401648419636632d, y: 0.5700256568219264d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7983960921596774d, y: 0.27703296864927396d), new NpgsqlTypes.NpgsqlPoint(x: 0.9534357868213629d, y: 0.852580851418448d), new NpgsqlTypes.NpgsqlPoint(x: 0.8063560752950447d, y: 0.6225019036847655d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9978880234165477d, y: 0.2583087753561454d), new NpgsqlTypes.NpgsqlPoint(x: 0.32466148889663204d, y: 0.9616240107955137d), new NpgsqlTypes.NpgsqlPoint(x: 0.3197626351003303d, y: 0.4467389809649879d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 150,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.767917041112899d, y: 0.931578375265963d), new NpgsqlTypes.NpgsqlPoint(x: 0.037674939674891106d, y: 0.7229248645200343d), new NpgsqlTypes.NpgsqlPoint(x: 0.8123774978112296d, y: 0.39683249160434253d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34706637268940055d, y: 0.7204501079051536d), new NpgsqlTypes.NpgsqlPoint(x: 0.9493913104978356d, y: 0.2558215219327318d), new NpgsqlTypes.NpgsqlPoint(x: 0.6018383454986506d, y: 0.7845172908537875d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1938662030377496d, y: 0.05269518806302176d), new NpgsqlTypes.NpgsqlPoint(x: 0.6104205308176796d, y: 0.6169946118622319d), new NpgsqlTypes.NpgsqlPoint(x: 0.1592497262528364d, y: 0.5567562250855492d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.036385728454365385d, y: 0.06848952432066024d), new NpgsqlTypes.NpgsqlPoint(x: 0.8640360992269531d, y: 0.7820796748431421d), new NpgsqlTypes.NpgsqlPoint(x: 0.44627699385579045d, y: 0.07465636555262622d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44002090498957425d, y: 0.005846483991415852d), new NpgsqlTypes.NpgsqlPoint(x: 0.9004413076598734d, y: 0.11796884925676898d), new NpgsqlTypes.NpgsqlPoint(x: 0.7505008381420747d, y: 0.08621395628364192d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5327240268608697d, y: 0.1573732291877048d), new NpgsqlTypes.NpgsqlPoint(x: 0.9712994317289956d, y: 0.217573790856341d), new NpgsqlTypes.NpgsqlPoint(x: 0.9488912114094634d, y: 0.5414012627578487d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 159,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.866843245646194d, y: 0.891714052869661d), new NpgsqlTypes.NpgsqlPoint(x: 0.07217154433116046d, y: 0.04957227486467419d), new NpgsqlTypes.NpgsqlPoint(x: 0.7910922606010182d, y: 0.2299875937130066d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06904321750340237d, y: 0.6259557644540517d), new NpgsqlTypes.NpgsqlPoint(x: 0.3755376370346939d, y: 0.007505615487256367d), new NpgsqlTypes.NpgsqlPoint(x: 0.5136034330065251d, y: 0.47628754990142974d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46269506807570293d, y: 0.4626437840898441d), new NpgsqlTypes.NpgsqlPoint(x: 0.9593729954528185d, y: 0.20223344945663968d), new NpgsqlTypes.NpgsqlPoint(x: 0.605443193206407d, y: 0.6019326970943066d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9490317656095164d, y: 0.9562701390496037d), new NpgsqlTypes.NpgsqlPoint(x: 0.9564492924938034d, y: 0.08776339391873489d), new NpgsqlTypes.NpgsqlPoint(x: 0.27773257619085634d, y: 0.3087702904637152d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8385441046913934d, y: 0.2936659874866645d), new NpgsqlTypes.NpgsqlPoint(x: 0.7851255248877219d, y: 0.8408813177805833d), new NpgsqlTypes.NpgsqlPoint(x: 0.7401737193608543d, y: 0.26826919948643346d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42348109757324226d, y: 0.03483479639060383d), new NpgsqlTypes.NpgsqlPoint(x: 0.1012730226948576d, y: 0.7963841034881324d), new NpgsqlTypes.NpgsqlPoint(x: 0.4122394741842008d, y: 0.0711951506028834d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27993456457911137d, y: 0.2492056679199498d), new NpgsqlTypes.NpgsqlPoint(x: 0.8460435742871287d, y: 0.8903815139735521d), new NpgsqlTypes.NpgsqlPoint(x: 0.6986361515991492d, y: 0.15330817480620895d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09808191343034278d, y: 0.6479142897445062d), new NpgsqlTypes.NpgsqlPoint(x: 0.562386561124309d, y: 0.3154414591631517d), new NpgsqlTypes.NpgsqlPoint(x: 0.6441512916229416d, y: 0.3722813208386009d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3442916831048404d, y: 0.8144677607960836d), new NpgsqlTypes.NpgsqlPoint(x: 0.14730401568149298d, y: 0.16827844278030957d), new NpgsqlTypes.NpgsqlPoint(x: 0.42680225140961825d, y: 0.09936579825345415d)),
},
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 167,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9349785719570012d, y: 0.7968563474685022d), new NpgsqlTypes.NpgsqlPoint(x: 0.21066605922217485d, y: 0.11455242120074038d), new NpgsqlTypes.NpgsqlPoint(x: 0.9913680278588178d, y: 0.47082971515482064d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25248560505240547d, y: 0.22755679733137268d), new NpgsqlTypes.NpgsqlPoint(x: 0.4235195202050991d, y: 0.5753812132735302d), new NpgsqlTypes.NpgsqlPoint(x: 0.951567123824127d, y: 0.7493776630253385d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08268901359044767d, y: 0.4559011945985959d), new NpgsqlTypes.NpgsqlPoint(x: 0.14978970974821604d, y: 0.09511179639276457d), new NpgsqlTypes.NpgsqlPoint(x: 0.5763639773189093d, y: 0.9856720906233531d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 171,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2020938708028105d, y: 0.6550368068311915d), new NpgsqlTypes.NpgsqlPoint(x: 0.37665777454209637d, y: 0.5962185952949376d), new NpgsqlTypes.NpgsqlPoint(x: 0.7329181820394309d, y: 0.5931449601757055d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8238999355503842d, y: 0.4632323767495947d), new NpgsqlTypes.NpgsqlPoint(x: 0.5406705288767378d, y: 0.5727941908623946d), new NpgsqlTypes.NpgsqlPoint(x: 0.8798402533178273d, y: 0.8362393667207746d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8748362693050014d, y: 0.3925139584366605d), new NpgsqlTypes.NpgsqlPoint(x: 0.5483900878115897d, y: 0.17388296544250315d), new NpgsqlTypes.NpgsqlPoint(x: 0.9128669365140338d, y: 0.5361482691973932d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8649265174853329d, y: 0.5553604648996407d), new NpgsqlTypes.NpgsqlPoint(x: 0.5415699916849439d, y: 0.3514248898302619d), new NpgsqlTypes.NpgsqlPoint(x: 0.5190471133322542d, y: 0.4692588879777708d)),
},
    ModelInner = new NpgsqlPathpathMMArrayD1E1MI
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3157994043789346d, y: 0.2901639205139114d), new NpgsqlTypes.NpgsqlPoint(x: 0.8347119801116878d, y: 0.0786619946917041d), new NpgsqlTypes.NpgsqlPoint(x: 0.9977996164576409d, y: 0.7469816836271153d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5551319037821336d, y: 0.28001693155523766d), new NpgsqlTypes.NpgsqlPoint(x: 0.25208758906142037d, y: 0.5715242225190605d), new NpgsqlTypes.NpgsqlPoint(x: 0.38720098652364787d, y: 0.2297909701476455d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08653843314079057d, y: 0.12880497814965475d), new NpgsqlTypes.NpgsqlPoint(x: 0.8561856929747267d, y: 0.6657370433152516d), new NpgsqlTypes.NpgsqlPoint(x: 0.20217337774868638d, y: 0.9170819885218715d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9572634940928101d, y: 0.9242908686372973d), new NpgsqlTypes.NpgsqlPoint(x: 0.8817726647171917d, y: 0.2741422574675406d), new NpgsqlTypes.NpgsqlPoint(x: 0.24125060846569357d, y: 0.28294408906599466d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5861384735821635d, y: 0.2546116220438056d), new NpgsqlTypes.NpgsqlPoint(x: 0.8403582626876352d, y: 0.47127247603752365d), new NpgsqlTypes.NpgsqlPoint(x: 0.9794454852683092d, y: 0.38994786824035d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1476167055851212d, y: 0.3823513740113409d), new NpgsqlTypes.NpgsqlPoint(x: 0.9199842427105636d, y: 0.3332243704163853d), new NpgsqlTypes.NpgsqlPoint(x: 0.020770784035327283d, y: 0.9996182346641896d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18436087357184305d, y: 0.21490170610522663d), new NpgsqlTypes.NpgsqlPoint(x: 0.4832687733715153d, y: 0.6306292494228214d), new NpgsqlTypes.NpgsqlPoint(x: 0.874553824650963d, y: 0.6398956972054122d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathMMArrayD1E1M
{
    Id = 180,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23323250772864135d, y: 0.6808906189507483d), new NpgsqlTypes.NpgsqlPoint(x: 0.5975984857717657d, y: 0.4398074103512407d), new NpgsqlTypes.NpgsqlPoint(x: 0.19946446486054015d, y: 0.7721895724014917d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2624209784468775d, y: 0.3630320269555054d), new NpgsqlTypes.NpgsqlPoint(x: 0.013581940906731371d, y: 0.6888429461533002d), new NpgsqlTypes.NpgsqlPoint(x: 0.06695150444565068d, y: 0.19917683566201272d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2299442140430148d, y: 0.917229903935919d), new NpgsqlTypes.NpgsqlPoint(x: 0.9281449418740929d, y: 0.7799675536184547d), new NpgsqlTypes.NpgsqlPoint(x: 0.5503021506264933d, y: 0.6021108652790984d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3021758040668999d, y: 0.2142457142935944d), new NpgsqlTypes.NpgsqlPoint(x: 0.6101333361825719d, y: 0.3073755093641455d), new NpgsqlTypes.NpgsqlPoint(x: 0.311852360352752d, y: 0.44616106688565293d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5455147785415606d, y: 0.8693146340931525d), new NpgsqlTypes.NpgsqlPoint(x: 0.0984886107396159d, y: 0.004271905176711832d), new NpgsqlTypes.NpgsqlPoint(x: 0.6464987145047048d, y: 0.2993330921404568d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6023419455847745d, y: 0.9686960115731109d), new NpgsqlTypes.NpgsqlPoint(x: 0.7410836114787025d, y: 0.01662645358243875d), new NpgsqlTypes.NpgsqlPoint(x: 0.6229951144733534d, y: 0.7178272459942392d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7069443970408363d, y: 0.8685869187127602d), new NpgsqlTypes.NpgsqlPoint(x: 0.6576112427338815d, y: 0.19256048815493132d), new NpgsqlTypes.NpgsqlPoint(x: 0.6720920572768367d, y: 0.2604545080000302d)),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd1e1mi(
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd1e1mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
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

                changedRows =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmmarrayd1e1mi_id
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpathmmarrayd1e1mi_id", 
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
                changedRows =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmmarrayd1e1mi_id
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
    npgsqlpathpathmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable =  ((INpgsqlPathMArraypathMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5969410020041326d, y: 0.5345655695887043d), new NpgsqlTypes.NpgsqlPoint(x: 0.4962232756577152d, y: 0.608585728880849d), new NpgsqlTypes.NpgsqlPoint(x: 0.32413863582021996d, y: 0.11283499821270038d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8136825890569794d, y: 0.33836760830547374d), new NpgsqlTypes.NpgsqlPoint(x: 0.5137811752331645d, y: 0.9415372945131131d), new NpgsqlTypes.NpgsqlPoint(x: 0.8921250706856914d, y: 0.6318143845486984d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9747038091541397d, y: 0.3215407639146062d), new NpgsqlTypes.NpgsqlPoint(x: 0.051164913069795204d, y: 0.5285651467921914d), new NpgsqlTypes.NpgsqlPoint(x: 0.4155820306055361d, y: 0.8159688071911164d)),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable =  ((INpgsqlPathMArraypathMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable = await ((INpgsqlPathMArraypathMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4936463103116885d, y: 0.09479427364963855d), new NpgsqlTypes.NpgsqlPoint(x: 0.6725045119509525d, y: 0.4361624409873308d), new NpgsqlTypes.NpgsqlPoint(x: 0.45611387684035265d, y: 0.48820981125708596d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7076507534662168d, y: 0.9762072316739738d), new NpgsqlTypes.NpgsqlPoint(x: 0.6043861063034408d, y: 0.3406330008741204d), new NpgsqlTypes.NpgsqlPoint(x: 0.2497331483001355d, y: 0.22362324801901612d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8897560004088549d, y: 0.263865899478409d), new NpgsqlTypes.NpgsqlPoint(x: 0.2124705218924956d, y: 0.2669462182114789d), new NpgsqlTypes.NpgsqlPoint(x: 0.1794247138248296d, y: 0.3172431209884935d)),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable = await ((INpgsqlPathMArraypathMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2502153718710973d, y: 0.20084724463811365d), new NpgsqlTypes.NpgsqlPoint(x: 0.7213314733591036d, y: 0.0945214157295643d), new NpgsqlTypes.NpgsqlPoint(x: 0.7136239077661123d, y: 0.6594536112870013d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6238288429329244d, y: 0.6642971024102982d), new NpgsqlTypes.NpgsqlPoint(x: 0.4885950742237666d, y: 0.17782870997155031d), new NpgsqlTypes.NpgsqlPoint(x: 0.8390989704008073d, y: 0.1942099961281828d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10250847503246341d, y: 0.441141335734643d), new NpgsqlTypes.NpgsqlPoint(x: 0.479086738097948d, y: 0.20032646916403618d), new NpgsqlTypes.NpgsqlPoint(x: 0.251286869488312d, y: 0.7700747249909574d)),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathmmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathmmarrayd1e1mi_id
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
    npgsqlpathpathmmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpathmmarrayd1e1mi_id", 
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
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                nullable =  ((INpgsqlPathMArraypathMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19617910373221603d, y: 0.8731999612163789d), new NpgsqlTypes.NpgsqlPoint(x: 0.5575514657967311d, y: 0.37805024416864264d), new NpgsqlTypes.NpgsqlPoint(x: 0.8324634534956542d, y: 0.0649786553730024d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5015457404411826d, y: 0.5643412431829676d), new NpgsqlTypes.NpgsqlPoint(x: 0.21512443463457764d, y: 0.23755296049301966d), new NpgsqlTypes.NpgsqlPoint(x: 0.3660541384565772d, y: 0.03184805762121379d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8734713352319573d, y: 0.2919543222592099d), new NpgsqlTypes.NpgsqlPoint(x: 0.7295766762381941d, y: 0.8582393825244954d), new NpgsqlTypes.NpgsqlPoint(x: 0.7042250195867538d, y: 0.9136688285295612d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27490525628110907d, y: 0.23064165031938988d), new NpgsqlTypes.NpgsqlPoint(x: 0.638275890697973d, y: 0.9357379991545023d), new NpgsqlTypes.NpgsqlPoint(x: 0.5942919116009532d, y: 0.10946930932652943d)),
}));
                nullable =  ((INpgsqlPathMArraypathMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                nullable = await ((INpgsqlPathMArraypathMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02687071205502134d, y: 0.018051485184298555d), new NpgsqlTypes.NpgsqlPoint(x: 0.4649482662060035d, y: 0.3641365953582686d), new NpgsqlTypes.NpgsqlPoint(x: 0.3871182578105674d, y: 0.5681357743400864d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5646304663596217d, y: 0.7494413720706757d), new NpgsqlTypes.NpgsqlPoint(x: 0.1824331335474153d, y: 0.46129433444614754d), new NpgsqlTypes.NpgsqlPoint(x: 0.8747312723042711d, y: 0.7032096717628457d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1592972949508551d, y: 0.49522413901941975d), new NpgsqlTypes.NpgsqlPoint(x: 0.9111780689514138d, y: 0.6226692424345661d), new NpgsqlTypes.NpgsqlPoint(x: 0.6438989310265744d, y: 0.6164538087126464d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9312351160652317d, y: 0.9997402620669555d), new NpgsqlTypes.NpgsqlPoint(x: 0.7886161522144176d, y: 0.5455528475443223d), new NpgsqlTypes.NpgsqlPoint(x: 0.9782520989585138d, y: 0.693813378457668d)),
}));
                nullable = await ((INpgsqlPathMArraypathMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathMMArrayD1E1M> models = null;

                models =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathMMArrayD1E1M> models = null;

                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPathMArraypathMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD1E1M), typeof(FlatNpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                ((INpgsqlPathMArraypathMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd1e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD1E1M), typeof(FlatNpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                ((INpgsqlPathMArraypathMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd1e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD1E1M), typeof(FlatNpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 129;
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[30],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                 ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 150;
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                 ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 65;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
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
                parametr1.Value = 84;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 159;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 88;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 78;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[34], false);
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
                parametr1.Value = 167;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 167;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                 ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd1e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
                var models = await((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[29], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[30], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[19],_testData[31], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[20],_testData[32], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[21],_testData[33], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 159;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[27],_testData[29], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[28],_testData[30], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[29],_testData[31], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[30],_testData[32], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[31],_testData[33], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[32], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[33], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD1E1M), typeof(FlatNpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 26, query1, 66, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 14, query1, 56, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[22],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                 ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 143, query1, 13, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[31],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                 ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 159, query1, 65, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[21],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 18, query1, 71, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[19],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 110, query1, 27, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 65, query1, 124, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
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
FROM public.npgsqlpathpathmmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathMMArrayD1E1M>();
                 ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 143, query1, 84, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlPathpathMMArrayD1E1M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.npgsqlpathpathmmarrayd1e1m m
LEFT JOIN public.npgsqlpathpathmmarrayd1e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
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
                var models = await((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 65, 81))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[19], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[20], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[21], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[22], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[23], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[24], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[25], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[26], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[27], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[28], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[29], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[30], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[31], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[32], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[33], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[34], false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathMArraypathMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 65, 71))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[15], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[16], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[17], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[18], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[19], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[20], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[21], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[22], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[23], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[24], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[25], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[26], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[27], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[28], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[29], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[30], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[31], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[32], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[33], false);
                        NpgsqlPathpathMMArrayD1E1M.AssertModel(models[19],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPathMArraypathMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathMArraypathMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 167);
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(2));

                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathMArraypathMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathMArraypathMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 78);
                var models =  ((INpgsqlPathMArraypathMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(19));

                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[0],_testData[16], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[1],_testData[17], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[2],_testData[18], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[3],_testData[19], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[4],_testData[20], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[5],_testData[21], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[6],_testData[22], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[7],_testData[23], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[8],_testData[24], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[9],_testData[25], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[10],_testData[26], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[11],_testData[27], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[12],_testData[28], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[13],_testData[29], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[14],_testData[30], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[15],_testData[31], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[16],_testData[32], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[17],_testData[33], false);
                NpgsqlPathpathMMArrayD1E1M.AssertModel(models[18],_testData[34], false);
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
FROM public.binary_npgsqlpathpathmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD1E1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD1E1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathMArraypathMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathMArraypathMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathmmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathMArraypathMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathMArraypathMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpathmmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathMMArrayD1E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
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
FROM public.binary_npgsqlpathpathmmarrayd1e1m m
LEFT JOIN public.binary_npgsqlpathpathmmarrayd1e1mi mi ON mi.id = m.npgsqlpathpathmmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathMArraypathMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathMArraypathMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpathmmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models =  ((INpgsqlPathMArraypathMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA), typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models1 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                ((INpgsqlPathMArraypathMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
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
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
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
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA), typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
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
                var models1 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                ((INpgsqlPathMArraypathMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
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
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
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
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
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
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MI), typeof(NpgsqlPathpathMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models1 = new List<NpgsqlPathpathMMArrayD1E1MI>();
                var models2 = new List<NpgsqlPathpathMMArrayD1E1MI>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD1E1MI>();
                var models2 = new List<NpgsqlPathpathMMArrayD1E1MI>();
                ((INpgsqlPathMArraypathMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathmmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA), typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
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
                var models1 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                await ((INpgsqlPathMArraypathMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlPathpathMMArrayD1E1MIWA>();
                ((INpgsqlPathMArraypathMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathmmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathMArraypathMMArrayD1))]
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
                var models = await ((INpgsqlPathMArraypathMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathMArraypathMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

